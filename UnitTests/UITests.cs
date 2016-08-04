using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircularBufferRealization;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace TestTaskUnitTests
{
    [TestClass]
    public class UITests
    {
        [TestMethod]
        public void StartNumberTextBoxTest_NotANumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "a";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void StartNumberTextBoxTest_OutOfBoundsPositiveNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "2147483648";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void StartNumberTextBoxTest_OutOfBoundsNegativeNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "-2147483649";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void StartNumberTextBoxTest_BoundsNegativeNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "-2147483648";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void StartNumberTextBoxTest_BoundsPositiveNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "2147483647";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void StartNumberTextBoxTest_PositiveNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void StartNumberTextBoxTest_ZeroNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "0";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void StartNumberTextBoxTest_NegativeNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "-1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_NotANumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "a";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_OutOfBoundsPositiveNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "2147483648";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_OutOfBoundsNegativeNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "-2147483649";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_BoundsNegativeNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "-2147483648";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_BoundsPositiveNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "2147483647";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_PositiveNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_ZeroNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "0";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void MaxQueueCountTextBoxTest_NegativeNumber()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "-1";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["QueueIsGeneratedLabel"].Visible);
            MF.Close();
        }

        [TestMethod]
        public void ShownFormStartAndStopButtonsTest()
        {
            MainForm MF = new MainForm();
            MF.Show();
            Assert.AreEqual(false, MF.Controls["StartGenerateNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopGenerateNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StartPickNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopPickNumbersButton"].Enabled);
            Assert.AreEqual(true, MF.Controls["CreateCircularQueueButton"].Enabled);
            Assert.AreEqual(true,  MF.Controls["StartNumberTextBox"].Enabled);
            Assert.AreEqual(true, MF.Controls["MaxQueueCountTextBox"].Enabled);
            MF.Close();
        }

        [TestMethod]
        public void CreateCircularQueueButtonPressWithCorrectDataTest()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["StartGenerateNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopGenerateNumbersButton"].Enabled);
            Assert.AreEqual(true, MF.Controls["StartPickNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopPickNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["CreateCircularQueueButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StartNumberTextBox"].Enabled);
            Assert.AreEqual(false, MF.Controls["MaxQueueCountTextBox"].Enabled);
            MF.Close();
        }

        [TestMethod]
        public void CreateCircularQueueButtonPressWithIncorrectDataTest()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "-20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["StartGenerateNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopGenerateNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StartPickNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopPickNumbersButton"].Enabled);
            Assert.AreEqual(true, MF.Controls["CreateCircularQueueButton"].Enabled);
            Assert.AreEqual(true, MF.Controls["StartNumberTextBox"].Enabled);
            Assert.AreEqual(true, MF.Controls["MaxQueueCountTextBox"].Enabled);
            MF.Close();
        }

        [TestMethod]
        public void StartGenerateNumbersButtonTest_Press()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Thread.Sleep(1000);
            (MF.Controls["StartGenerateNumbersButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["StartGenerateNumbersButton"].Enabled);
            Assert.AreEqual(true, MF.Controls["StopGenerateNumbersButton"].Enabled);
            MF.Close();
        }

        [TestMethod]
        public void StopGenerateNumbersButtonTest_Press()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Thread.Sleep(1000);
            (MF.Controls["StartGenerateNumbersButton"] as Button).PerformClick();
            Thread.Sleep(1000);
            (MF.Controls["StopGenerateNumbersButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["StartGenerateNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopGenerateNumbersButton"].Enabled);
            MF.Close();
        }

        [TestMethod]
        public void StartPickNumbersButton_Press()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Thread.Sleep(1000);
            (MF.Controls["StartPickNumbersButton"] as Button).PerformClick();
            Assert.AreEqual(false, MF.Controls["StartPickNumbersButton"].Enabled);
            Assert.AreEqual(true, MF.Controls["StopPickNumbersButton"].Enabled);
            MF.Close();
        }

        [TestMethod]
        public void StopPickNumbersButton_Press()
        {
            MainForm MF = new MainForm();
            MF.Controls["StartNumberTextBox"].Text = "1";
            MF.Controls["MaxQueueCountTextBox"].Text = "20";
            MF.Show();
            (MF.Controls["CreateCircularQueueButton"] as Button).PerformClick();
            Thread.Sleep(1000);
            (MF.Controls["StartPickNumbersButton"] as Button).PerformClick();
            Thread.Sleep(1000);
            (MF.Controls["StopPickNumbersButton"] as Button).PerformClick();
            Assert.AreEqual(true, MF.Controls["StartPickNumbersButton"].Enabled);
            Assert.AreEqual(false, MF.Controls["StopPickNumbersButton"].Enabled);
            MF.Close();
        }
    }
}
