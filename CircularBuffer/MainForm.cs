using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CircularBufferRealization
{
    public partial class MainForm : Form
    {
        //delegates for updating the UI elements (ListBoxes with CircularBuffer and numbers picked from it)
        private delegate void RefreshQueueViewerListBox(int queueAdded, int? queueRemoved);
        private RefreshQueueViewerListBox refreshQWDelegate;
        private delegate void RefreshNumbersPickerListBox(int queueAdded, int? queueRemoved);
        private RefreshNumbersPickerListBox refreshNPDelegate;
        //Threads and ThreadStarts for generating and picking numbers
        private ThreadStart GenerationNumThreadStart;
        private ThreadStart PickingNumThreadStart;
        private Thread generationNumThread;
        private Thread pickingNumThread;
        private ManualResetEvent generationNumEvent;
        private ManualResetEvent pickingNumEvent;
        //start number for generating numbers
        private int startNumber;
        private int maxQueueCount;
        private bool isGenerationStopped = true;
        private bool isPickingStopped = true;
        private int? removed;
        //circular queue for generated numbers
        public ThreadSafeCircularQueue CircularBuffer;
        private int generationThreadSleep = 100;
        private int pickingThreadSleep = 100;
        public MainForm()
        {
            InitializeComponent();
            StopGenerateNumbersButton.Enabled = false;
            StopPickNumbersButton.Enabled = false;
            StartGenerateNumbersButton.Enabled = false;
            StartPickNumbersButton.Enabled = false;
            QueueIsGeneratedLabel.Visible = false;
            GenerationNumThreadStart = new ThreadStart(GenerateNumbers);
            generationNumThread = new Thread(GenerationNumThreadStart);
            PickingNumThreadStart = new ThreadStart(PickNumbers);
            pickingNumThread = new Thread(PickingNumThreadStart);
            generationNumEvent = new ManualResetEvent(false);
            pickingNumEvent = new ManualResetEvent(false);
            refreshQWDelegate += UpdateQueueViewerListBox;
            refreshNPDelegate += UpdateNumbersPickerAndQueueViewer;
        }

        private void StartGenerateNumbers_Click(object sender, EventArgs e)
        {
            //change the state to indicate that generation is started (this variable is used in a generation loop)
            isGenerationStopped = false;
            //restart the thread if it is stopped or aborted
            if (generationNumThread.ThreadState==ThreadState.Unstarted)
            {
                generationNumThread.Start();
            }
            //otherwise resume the thread
            generationNumEvent.Set();
            //disable Start and enable Stop button for this thread
            ChangeControlState(StartGenerateNumbersButton, StopGenerateNumbersButton);
        }

        private void StopGenerateNumbers_Click(object sender, EventArgs e)
        {
            //restart the stopped or aborted thread, because we cannot suspend the thread in these states
            generationNumEvent.Reset();
            //disable Stop and enable Start button for this thread
            ChangeControlState(StartGenerateNumbersButton, StopGenerateNumbersButton);
            //change the state to indicate that generation is stopped (this variable is used in a generation loop)
            isGenerationStopped = true;

        }

        private void StartPickNumbers_Click(object sender, EventArgs e)
        {
            //change the state to indicate that picking is started (this variable is used in a picking loop)
            isPickingStopped = false;
            //restart the thread if it is stopped or aborted
            if (pickingNumThread.ThreadState==ThreadState.Unstarted)
            {
                pickingNumThread.Start();
            }
            pickingNumEvent.Set();
            //disable Start and enable Stop button for this thread
            ChangeControlState(StartPickNumbersButton, StopPickNumbersButton);
        }

        private void StopPickNumbers_Click(object sender, EventArgs e)
        {
            //disable Stop and enable Start button for this thread
            ChangeControlState(StartPickNumbersButton, StopPickNumbersButton);
            //restart the stopped or aborted thread, because we cannot suspend the thread in these states
            pickingNumEvent.Reset();
            isPickingStopped = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //abort the threads because of program closing (if these threads are suspended, we have to resume them because they cannot be aborted in a Suspended state)
            if (generationNumThread.ThreadState == ThreadState.Suspended)
            {
                generationNumThread.Resume();
            }
            generationNumThread.Abort();
            if (pickingNumThread.ThreadState == ThreadState.Suspended)
            {
                pickingNumThread.Resume();
            }
            pickingNumThread.Abort();
        }

        private void StartNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            StartNumberTBErrorProvider.Clear();
            try
            {
                startNumber = Int32.Parse(StartNumberTextBox.Text);
            }
            catch (Exception ex)
            {
                StartNumberTBErrorProvider.SetError(StartNumberTextBox, ex.Message);
            }
        }

        private void MaxQueueCountTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxQueueCountTBErrorProvider.Clear();
            try
            {
                maxQueueCount = Int32.Parse(MaxQueueCountTextBox.Text);
            }
            catch (Exception ex)
            {
                MaxQueueCountTBErrorProvider.SetError(MaxQueueCountTextBox, ex.Message);
            }
        }

        private void CreateCircularQueueButton_Click(object sender, EventArgs e)
        {
            //if there are no incorrect input data, we can generate a CircularBuffer
            if ((StartNumberTBErrorProvider.GetError(this.StartNumberTextBox) == "") && (MaxQueueCountTBErrorProvider.GetError(this.MaxQueueCountTextBox) == "")&&(maxQueueCount>0))
            {
                //change text boxes and CreateCircularQueueButton states to avoid the data changing and recreating of the CircularBuffer
                ChangeControlState(MaxQueueCountTextBox, StartNumberTextBox, CreateCircularQueueButton);
                //creating CircularBuffer and seting the start points to generate numbers
                CircularBuffer = new ThreadSafeCircularQueue(maxQueueCount);
                //show message about successfully created CircularBuffer
                QueueIsGeneratedLabel.Visible = true;
                //enable the Start buttons for both generation and picking threads
                ChangeControlState(StartGenerateNumbersButton, StartPickNumbersButton);
            }
        }

        private void GenerateNumbers()
        {
            if (CircularBuffer != null)
            {
                while (generationNumEvent.WaitOne())
                {
                    if (!isGenerationStopped)
                    {
                        CircularBuffer.Add(startNumber);
                        //update data in QueueViewer ListBox
                        if (isPickingStopped)
                        {
                            if (refreshQWDelegate != null)
                            {
                                this.QueueViewerListBox.Invoke(refreshQWDelegate, startNumber, null);
                            }
                        }
                        //generating new number via increment, startNumber is used like a current number here
                        startNumber++;
                       // System.Diagnostics.Debug.Print("StartNumber: {0}", startNumber.ToString());
                        Thread.Sleep(generationThreadSleep); 
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void PickNumbers()
        {
            if (CircularBuffer != null)
            {
                while (pickingNumEvent.WaitOne())
                {
                    if (!isPickingStopped)
                    {
                        //pick the element from the CircularBuffer
                        int? queueRemoved = CircularBuffer.Pick();
                        //if it is not null, add it to the NumbersPickerListBox items
                        if (queueRemoved.HasValue)
                        {
                            //update data in NumbersPicker ListBox
                            if (refreshNPDelegate != null)
                            {
                                this.NumbersPickerListBox.Invoke(refreshNPDelegate, startNumber, queueRemoved);
                            }
                        }
                        Thread.Sleep(pickingThreadSleep); 
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void UpdateQueueViewerListBox(int queueAdded, int? queueRemoved)
        {
                if (CircularBuffer != null)
                {
                    if (!isGenerationStopped)
                    {
                        QueueViewerListBox.Items.Add(queueAdded);
                        // System.Diagnostics.Debug.Print("+ {0}", queueAdded.ToString());
                    }
                    //free the space for the new element by removing extra elements
                    while (QueueViewerListBox.Items.Count > CircularBuffer.ElementCount)
                    {
                        QueueViewerListBox.Items.RemoveAt(0);
                    }
                    //adding the element and refreshing the QueueViewerListBox
                    if (queueRemoved.HasValue)
                    {
                        QueueViewerListBox.Items.Remove(queueRemoved);
                    }
//#if DEBUG
//                    System.Diagnostics.Debug.Print("777777");
//#endif
                    QueueViewerListBox.Refresh();
                }
                else
                {
                    throw new NullReferenceException();
                }
        }

        private void UpdateNumbersPickerListBox(int? queueRemoved)
        {
                if (CircularBuffer != null)
                {
                    //free the space for the new element by removing extra elements
                        while (NumbersPickerListBox.Items.Count >= 20)
                        {
                            NumbersPickerListBox.Items.RemoveAt(0);
                        }
                        //adding the element and refreshing the NumbersPickerListBox
                        if (queueRemoved.HasValue)
                        {
                            NumbersPickerListBox.Items.Add(queueRemoved);
                        }
                        NumbersPickerListBox.Refresh();
                }
                else
                {
                    throw new NullReferenceException();
                }
        }

        private void UpdateNumbersPickerAndQueueViewer(int queueAdded, int? queueRemoved)
        {
            UpdateQueueViewerListBox(startNumber, queueRemoved);
            UpdateNumbersPickerListBox(queueRemoved);
        }

        //parsing the text from controls in order to set an error message to the rigth control if there is incorrect data in that control
        private int TextBoxTextParse(Control control)
        {
            int retValue = 0;
            try
            {
                retValue = Int32.Parse(control.Text);
            }
            catch (Exception ex)
            {
                StartNumberTBErrorProvider.SetError(control, ex.Message);
            }
            return retValue;
        }

        //enable/disable controls
        private void ChangeControlState(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = !control.Enabled;
            }
        }


    }
}
