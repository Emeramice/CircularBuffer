namespace CircularBufferRealization
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartNumberTextBox = new System.Windows.Forms.TextBox();
            this.QueueViewerListBox = new System.Windows.Forms.ListBox();
            this.NumbersPickerListBox = new System.Windows.Forms.ListBox();
            this.StartGenerateNumbersButton = new System.Windows.Forms.Button();
            this.StopGenerateNumbersButton = new System.Windows.Forms.Button();
            this.StartPickNumbersButton = new System.Windows.Forms.Button();
            this.StopPickNumbersButton = new System.Windows.Forms.Button();
            this.StartNumLabel = new System.Windows.Forms.Label();
            this.CircQueueLabel = new System.Windows.Forms.Label();
            this.PickedNumbersLabel = new System.Windows.Forms.Label();
            this.MaxQueueCountTextBox = new System.Windows.Forms.TextBox();
            this.MaxQueueCountLabel = new System.Windows.Forms.Label();
            this.CreateCircularQueueButton = new System.Windows.Forms.Button();
            this.StartNumberTBErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.QueueIsGeneratedLabel = new System.Windows.Forms.Label();
            this.MaxQueueCountTBErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StartNumberTBErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxQueueCountTBErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // StartNumberTextBox
            // 
            this.StartNumberTextBox.Location = new System.Drawing.Point(191, 12);
            this.StartNumberTextBox.Name = "StartNumberTextBox";
            this.StartNumberTextBox.Size = new System.Drawing.Size(167, 20);
            this.StartNumberTextBox.TabIndex = 0;
            this.StartNumberTextBox.TextChanged += new System.EventHandler(this.StartNumberTextBox_TextChanged);
            // 
            // QueueViewerListBox
            // 
            this.QueueViewerListBox.FormattingEnabled = true;
            this.QueueViewerListBox.Location = new System.Drawing.Point(38, 117);
            this.QueueViewerListBox.Name = "QueueViewerListBox";
            this.QueueViewerListBox.Size = new System.Drawing.Size(152, 264);
            this.QueueViewerListBox.TabIndex = 1;
            // 
            // NumbersPickerListBox
            // 
            this.NumbersPickerListBox.FormattingEnabled = true;
            this.NumbersPickerListBox.Location = new System.Drawing.Point(223, 117);
            this.NumbersPickerListBox.Name = "NumbersPickerListBox";
            this.NumbersPickerListBox.Size = new System.Drawing.Size(148, 264);
            this.NumbersPickerListBox.TabIndex = 2;
            // 
            // StartGenerateNumbersButton
            // 
            this.StartGenerateNumbersButton.Location = new System.Drawing.Point(38, 395);
            this.StartGenerateNumbersButton.Name = "StartGenerateNumbersButton";
            this.StartGenerateNumbersButton.Size = new System.Drawing.Size(152, 23);
            this.StartGenerateNumbersButton.TabIndex = 3;
            this.StartGenerateNumbersButton.Text = "Start";
            this.StartGenerateNumbersButton.UseVisualStyleBackColor = true;
            this.StartGenerateNumbersButton.Click += new System.EventHandler(this.StartGenerateNumbers_Click);
            // 
            // StopGenerateNumbersButton
            // 
            this.StopGenerateNumbersButton.Location = new System.Drawing.Point(38, 424);
            this.StopGenerateNumbersButton.Name = "StopGenerateNumbersButton";
            this.StopGenerateNumbersButton.Size = new System.Drawing.Size(152, 23);
            this.StopGenerateNumbersButton.TabIndex = 5;
            this.StopGenerateNumbersButton.Text = "Stop";
            this.StopGenerateNumbersButton.UseVisualStyleBackColor = true;
            this.StopGenerateNumbersButton.Click += new System.EventHandler(this.StopGenerateNumbers_Click);
            // 
            // StartPickNumbersButton
            // 
            this.StartPickNumbersButton.Location = new System.Drawing.Point(223, 395);
            this.StartPickNumbersButton.Name = "StartPickNumbersButton";
            this.StartPickNumbersButton.Size = new System.Drawing.Size(148, 23);
            this.StartPickNumbersButton.TabIndex = 4;
            this.StartPickNumbersButton.Text = "Start";
            this.StartPickNumbersButton.UseVisualStyleBackColor = true;
            this.StartPickNumbersButton.Click += new System.EventHandler(this.StartPickNumbers_Click);
            // 
            // StopPickNumbersButton
            // 
            this.StopPickNumbersButton.Location = new System.Drawing.Point(223, 424);
            this.StopPickNumbersButton.Name = "StopPickNumbersButton";
            this.StopPickNumbersButton.Size = new System.Drawing.Size(148, 23);
            this.StopPickNumbersButton.TabIndex = 6;
            this.StopPickNumbersButton.Text = "Stop";
            this.StopPickNumbersButton.UseVisualStyleBackColor = true;
            this.StopPickNumbersButton.Click += new System.EventHandler(this.StopPickNumbers_Click);
            // 
            // StartNumLabel
            // 
            this.StartNumLabel.AutoSize = true;
            this.StartNumLabel.Location = new System.Drawing.Point(42, 15);
            this.StartNumLabel.Name = "StartNumLabel";
            this.StartNumLabel.Size = new System.Drawing.Size(127, 13);
            this.StartNumLabel.TabIndex = 7;
            this.StartNumLabel.Text = "Start number to generate:";
            // 
            // CircQueueLabel
            // 
            this.CircQueueLabel.AutoSize = true;
            this.CircQueueLabel.Location = new System.Drawing.Point(66, 101);
            this.CircQueueLabel.Name = "CircQueueLabel";
            this.CircQueueLabel.Size = new System.Drawing.Size(78, 13);
            this.CircQueueLabel.TabIndex = 8;
            this.CircQueueLabel.Text = "Circular queue:";
            // 
            // PickedNumbersLabel
            // 
            this.PickedNumbersLabel.AutoSize = true;
            this.PickedNumbersLabel.Location = new System.Drawing.Point(254, 101);
            this.PickedNumbersLabel.Name = "PickedNumbersLabel";
            this.PickedNumbersLabel.Size = new System.Drawing.Size(86, 13);
            this.PickedNumbersLabel.TabIndex = 9;
            this.PickedNumbersLabel.Text = "Picked numbers:";
            // 
            // MaxQueueCountTextBox
            // 
            this.MaxQueueCountTextBox.Location = new System.Drawing.Point(191, 42);
            this.MaxQueueCountTextBox.Name = "MaxQueueCountTextBox";
            this.MaxQueueCountTextBox.Size = new System.Drawing.Size(167, 20);
            this.MaxQueueCountTextBox.TabIndex = 1;
            this.MaxQueueCountTextBox.TextChanged += new System.EventHandler(this.MaxQueueCountTextBox_TextChanged);
            // 
            // MaxQueueCountLabel
            // 
            this.MaxQueueCountLabel.AutoSize = true;
            this.MaxQueueCountLabel.Location = new System.Drawing.Point(41, 45);
            this.MaxQueueCountLabel.Name = "MaxQueueCountLabel";
            this.MaxQueueCountLabel.Size = new System.Drawing.Size(138, 13);
            this.MaxQueueCountLabel.TabIndex = 11;
            this.MaxQueueCountLabel.Text = "Max queue elements count:";
            // 
            // CreateCircularQueueButton
            // 
            this.CreateCircularQueueButton.Location = new System.Drawing.Point(139, 73);
            this.CreateCircularQueueButton.Name = "CreateCircularQueueButton";
            this.CreateCircularQueueButton.Size = new System.Drawing.Size(130, 23);
            this.CreateCircularQueueButton.TabIndex = 2;
            this.CreateCircularQueueButton.Text = "Create circular queue";
            this.CreateCircularQueueButton.UseVisualStyleBackColor = true;
            this.CreateCircularQueueButton.Click += new System.EventHandler(this.CreateCircularQueueButton_Click);
            // 
            // StartNumberTBErrorProvider
            // 
            this.StartNumberTBErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.StartNumberTBErrorProvider.ContainerControl = this;
            // 
            // QueueIsGeneratedLabel
            // 
            this.QueueIsGeneratedLabel.AutoSize = true;
            this.QueueIsGeneratedLabel.Location = new System.Drawing.Point(276, 79);
            this.QueueIsGeneratedLabel.Name = "QueueIsGeneratedLabel";
            this.QueueIsGeneratedLabel.Size = new System.Drawing.Size(103, 13);
            this.QueueIsGeneratedLabel.TabIndex = 13;
            this.QueueIsGeneratedLabel.Text = "Queue is generated!";
            // 
            // MaxQueueCountTBErrorProvider
            // 
            this.MaxQueueCountTBErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 459);
            this.Controls.Add(this.QueueIsGeneratedLabel);
            this.Controls.Add(this.CreateCircularQueueButton);
            this.Controls.Add(this.MaxQueueCountLabel);
            this.Controls.Add(this.MaxQueueCountTextBox);
            this.Controls.Add(this.PickedNumbersLabel);
            this.Controls.Add(this.CircQueueLabel);
            this.Controls.Add(this.StartNumLabel);
            this.Controls.Add(this.StopPickNumbersButton);
            this.Controls.Add(this.StartPickNumbersButton);
            this.Controls.Add(this.StopGenerateNumbersButton);
            this.Controls.Add(this.StartGenerateNumbersButton);
            this.Controls.Add(this.NumbersPickerListBox);
            this.Controls.Add(this.QueueViewerListBox);
            this.Controls.Add(this.StartNumberTextBox);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StartNumberTBErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxQueueCountTBErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartNumberTextBox;
        private System.Windows.Forms.ListBox QueueViewerListBox;
        private System.Windows.Forms.ListBox NumbersPickerListBox;
        private System.Windows.Forms.Button StartGenerateNumbersButton;
        private System.Windows.Forms.Button StopGenerateNumbersButton;
        private System.Windows.Forms.Button StartPickNumbersButton;
        private System.Windows.Forms.Button StopPickNumbersButton;
        private System.Windows.Forms.Label StartNumLabel;
        private System.Windows.Forms.Label CircQueueLabel;
        private System.Windows.Forms.Label PickedNumbersLabel;
        private System.Windows.Forms.TextBox MaxQueueCountTextBox;
        private System.Windows.Forms.Label MaxQueueCountLabel;
        private System.Windows.Forms.Button CreateCircularQueueButton;
        private System.Windows.Forms.ErrorProvider StartNumberTBErrorProvider;
        private System.Windows.Forms.Label QueueIsGeneratedLabel;
        private System.Windows.Forms.ErrorProvider MaxQueueCountTBErrorProvider;
    }
}

