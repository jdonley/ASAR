using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

//UI Automation with White
using TestStack.White;
using TestStack.White.WindowsAPI;
using TestStack.White.UIItems;

//Serial Includes
using System.IO.Ports;
using System.IO;
using System.Management;


namespace ASAR
{

    public partial class formMain : Form
    {
        // Port selection/connection dialog
        formConnect connection_dialog = new formConnect();

        // Platform Control
        double currentStepSize = 2;
        int currentStepDirection = 0;
        double startPosition = 0;
        double counterAnimation = 0; 
        double smallestIncrement = 2.0 / 25.0 * 4;


        //Charts
        Series seriesLocation;

        //UI Automation Applications
        TestStack.White.Application appAudacity;
        TestStack.White.UIItems.WindowItems.Window audacityWindow;
        TestStack.White.UIItems.Panel audacityToolDock;
        TestStack.White.UIItems.Panel audacityTransportToolbar;
        TestStack.White.UIItems.Button AudacityButton_Record;
        TestStack.White.UIItems.Button AudacityButton_Pause;
        TestStack.White.UIItems.Button AudacityButton_Play;
        TestStack.White.UIItems.Button AudacityButton_Stop;
        TestStack.White.UIItems.Button AudacityButton_SkipToStart;
        TestStack.White.UIItems.Button AudacityButton_SkipToEnd;

        // Threading
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to run when the Form loads
            // Initialise the location graph
            seriesLocation = chartLocation.Series[0];
            seriesLocation.Points.Clear();
            seriesLocation.Points.AddXY(0, 10);
            seriesLocation.Points.AddXY(0, 0);
            seriesLocation.Points[0].Label = seriesLocation.Points[0].XValue.ToString() + "°";

            //Initial serial port settings
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.None;
            serialPort1.Handshake = Handshake.None;
            serialPort1.ReadBufferSize = 4096;
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteBufferSize = 2048;
            serialPort1.WriteTimeout = 500;


            // Show port selection dialog
             do
             {
                if (connection_dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                    return;
                }
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                serialPort1.PortName = connection_dialog.Port_Name;
            } while (Connect_Serial() < 0);

            this.myDelegate = new AddDataDelegate(serial_Logger);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            comboCurrentStepSize.SelectedIndex = 0;

        }

        private int Connect_Serial()
        {
            //Initialise Button
            txtSerialLog.Text = String.Empty;
            try
            {
                if (!serialPort1.IsOpen)
                {
                    // Open Serial Port
                    serialPort1.Open();
                    txtSerialLog.Text = "Serial Port Initialised\n";
                    UpdateStepSize();
                    return 1;
                }
                else
                {
                    MessageBox.Show("Port is not opened");
                    return -1;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorised Access");
                return -2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -3;
            }
        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            //Rotate Left
            String textmessage = "l";

            if (serialPort1.IsOpen)
            {
                // Update Rotation Degrees and Send command
                serialPort1.WriteLine(textmessage);
                btnRotateCCW.Enabled = btnRotateCW.Enabled = btnReturnBoomHome.Enabled = comboCurrentStepSize.Enabled = false;
                currentStepDirection = -1;
                startPosition = Math.Round(seriesLocation.Points[0].XValue, 2);

                timerChartAnimation.Enabled = true;
            }
            else
            {
                txtSerialLog.Text = "Port Is Not Open";
            }

        }

        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            //Rotate Right
            String textmessage = "r";

            if (serialPort1.IsOpen)
            {
                // Update Rotation Degrees and Send command
                serialPort1.WriteLine(textmessage);
                btnRotateCCW.Enabled = btnRotateCW.Enabled = btnReturnBoomHome.Enabled = comboCurrentStepSize.Enabled = false;
                currentStepDirection = +1;
                startPosition = Math.Round(seriesLocation.Points[0].XValue, 2);

                timerChartAnimation.Enabled = true;
            }
            else
            {
                txtSerialLog.Text = "Port Is Not Open";
            }
        }


        private void btnReturnBoomHome_Click(object sender, EventArgs e)
        {
            //Return to zero
            String textmessage = "z";

            if (serialPort1.IsOpen)
            {
                // Update Rotation Degrees and Send command
                serialPort1.WriteLine(textmessage);
                btnRotateCCW.Enabled = btnRotateCW.Enabled = btnReturnBoomHome.Enabled = comboCurrentStepSize.Enabled = false;
                startPosition = Math.Round(seriesLocation.Points[0].XValue, 2);
                currentStepDirection = startPosition > 0 ? -1 : 1;
                currentStepSize = Math.Abs(startPosition);

                timerChartAnimation.Enabled = true;

            }
            else
            {
                txtSerialLog.Text = "Port Is Not Open";
            }
        }

        private void btnAudacity_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Audacity\\Audacity.exe"))
            {
                MessageBox.Show("Audacity is not installed...");
                return;
            }
            try
            {
                System.Diagnostics.ProcessStartInfo audacityProcess = new System.Diagnostics.ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Audacity\\Audacity.exe");
                appAudacity = TestStack.White.Application.AttachOrLaunch(audacityProcess);

                audacityWindow = appAudacity.GetWindow("Audacity", TestStack.White.Factory.InitializeOption.NoCache);
                audacityToolDock = (TestStack.White.UIItems.Panel)audacityWindow.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("ToolDock"))[0];
                audacityTransportToolbar = (TestStack.White.UIItems.Panel)audacityToolDock.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("Audacity Transport ToolBar"))[0];

                AudacityButton_Record = (TestStack.White.UIItems.Button)audacityTransportToolbar.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("Record"))[0];
                AudacityButton_Pause = (TestStack.White.UIItems.Button)audacityTransportToolbar.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("Pause"))[0];
                AudacityButton_Play = (TestStack.White.UIItems.Button)audacityTransportToolbar.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("Play"))[0];
                AudacityButton_Stop = (TestStack.White.UIItems.Button)audacityTransportToolbar.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("Stop"))[0];
                AudacityButton_SkipToStart = (TestStack.White.UIItems.Button)audacityTransportToolbar.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("Skip to Start"))[0];
                AudacityButton_SkipToEnd = (TestStack.White.UIItems.Button)audacityTransportToolbar.GetMultiple(TestStack.White.UIItems.Finders.SearchCriteria.ByText("Skip to End"))[0];

                this.TopMost = true;
                this.TopMost = false;
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Window Unavailable\n"+ex.Message);
            }

        }
        private void click_ExternBtn(TestStack.White.UIItems.Button Button_)
        {
            try
            {
                if (Button_.Enabled)
                {
                    Point cursorPos = System.Windows.Forms.Cursor.Position;
                    Button_.Click();
                    System.Windows.Forms.Cursor.Position = cursorPos;
                    this.TopMost = true;
                    this.TopMost = false;
                    this.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Button Unavailable");
            }
        }

        private void btnAudacityRecord_Click(object sender, EventArgs e)
        {            
            click_ExternBtn(AudacityButton_Record);
        }

        private void btnAudacityStop_Click(object sender, EventArgs e)
        {
            click_ExternBtn(AudacityButton_Stop);
        }

        private void btnAudacityPause_Click(object sender, EventArgs e)
        {
            click_ExternBtn(AudacityButton_Pause);
        }

        private void btnAudacityPlay_Click(object sender, EventArgs e)
        {
            click_ExternBtn(AudacityButton_Play);
        }

        private void btnAudacitySkipToStart_Click(object sender, EventArgs e)
        {
            click_ExternBtn(AudacityButton_SkipToStart);
        }

        private void btnAudacitySkipToEnd_Click(object sender, EventArgs e)
        {
            click_ExternBtn(AudacityButton_SkipToEnd);
        }

        private void btnStart360Rec_Click(object sender, EventArgs e)
        {
            //
            //Start 360 degree recording sequence here
            //

            //Something like
            int recDuration = 10000; //10000ms = 10s  //TODO: Should obtain this value from the duration of the audio file used !
            for (double angle = 0; angle < 360; angle += 7.5)
            {
                btnAudacityRecord_Click(sender, e); // start recording
                System.Threading.Thread.Sleep(recDuration + 100/*plus buffer*/); //Sleep program for duration of recording
                btnAudacityStop_Click(sender, e); // stop recording
                btnRotateCW_Click(sender, e); // Rotate to next position
            }
            //Last angle's recording
            btnAudacityRecord_Click(sender, e); // start recording
            System.Threading.Thread.Sleep(recDuration + 100/*plus buffer*/);//Sleep program for duration of recording
            btnAudacityStop_Click(sender, e); // stop recording

            btnReturnBoomHome_Click(sender, e); // Return the boom to it's home location
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Point cursorPos = System.Windows.Forms.Cursor.Position;
                audacityWindow.Close();
                System.Windows.Forms.Cursor.Position = cursorPos;
            }
            catch (Exception ex)
            { }

            // Close Port
            serialPort1.Close();

            // Close connection form
            connection_dialog.Close();
            connection_dialog.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStepSize();

        }
        private void UpdateStepSize(Boolean Skip_Serial_Write = false)
        {
            String stepSizeChange = Convert.ToString(comboCurrentStepSize.SelectedIndex + 2);

            if (serialPort1.IsOpen)  // Update Rotation Degrees and Send command
            {
                if (!Skip_Serial_Write)
                    serialPort1.WriteLine(stepSizeChange);

                if ((comboCurrentStepSize.SelectedIndex + 2) == 2)
                    currentStepSize = 2;
                else if ((comboCurrentStepSize.SelectedIndex + 2) == 3)
                    currentStepSize = 4;
                else if ((comboCurrentStepSize.SelectedIndex + 2) == 4)
                    currentStepSize = 6;
                else if ((comboCurrentStepSize.SelectedIndex + 2) == 5)
                    currentStepSize = 10;
                else if ((comboCurrentStepSize.SelectedIndex + 2) == 6)
                    currentStepSize = 20;
                else if ((comboCurrentStepSize.SelectedIndex + 2) == 7)
                    currentStepSize = 30;
                else if ((comboCurrentStepSize.SelectedIndex + 2) == 8)
                    currentStepSize = 60;
                else if ((comboCurrentStepSize.SelectedIndex + 2) == 9)
                    currentStepSize = 120;
            }
            else
                txtSerialLog.Text = "Port Is Not Open";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    txtSerialLog.Invoke(this.myDelegate, new Object[] {serialPort1.ReadExisting()});
                }
                catch (TimeoutException)
                {
                    txtSerialLog.Invoke(this.myDelegate, new Object[] { "Timeout Exception" }); 
                }
            }
            else
            {
                txtSerialLog.Invoke(this.myDelegate, new Object[] { "Port Is Not Open" });                
            }
        }
        public void serial_Logger(String myString)
        {
            txtSerialLog.AppendText(myString);
        }

        private void timerChartAnimation_Tick(object sender, EventArgs e)
        {
            seriesLocation.Points[0].XValue = Math.Round(seriesLocation.Points[0].XValue + (double)currentStepDirection * smallestIncrement, 4);
            seriesLocation.Points[0].Label = Math.Round(seriesLocation.Points[0].XValue, 0).ToString() + "°";
            lblCurrentPosition.Text = seriesLocation.Points[0].Label;

            counterAnimation = counterAnimation + smallestIncrement;

            if (counterAnimation >= Math.Abs(currentStepSize))
            {
                seriesLocation.Points[0].XValue = Math.Round(startPosition + (double)currentStepDirection * currentStepSize, 0);
                seriesLocation.Points[0].Label = Math.Round(seriesLocation.Points[0].XValue, 0).ToString() + "°";
                lblCurrentPosition.Text = seriesLocation.Points[0].Label;

                timerChartAnimation.Enabled = false;
                counterAnimation = 0;
                UpdateStepSize(true);
                btnRotateCCW.Enabled = btnRotateCW.Enabled = btnReturnBoomHome.Enabled = comboCurrentStepSize.Enabled = true;

            }




        }
    }
}
