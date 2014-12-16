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
                serialPort1.PortName = connection_dialog.Port_Name.ToString();
            } while (Connect_Serial() < 0);

            this.myDelegate = new AddDataDelegate(serial_Logger);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            comboBox3.SelectedIndex = 0;

        }

        private int Connect_Serial()
        {
            //Initialise Button
            textBox1.Text = String.Empty;
            try
            {
                if (!serialPort1.IsOpen)
                {
                    // Open Serial Port
                    serialPort1.Open();
                    textBox1.Text = "Serial Port Initialised\n";
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
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.HResult.ToString());
            //    return -3;
            //}
        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            //Rotate Left
            String textmessage = "l";

            if (serialPort1.IsOpen)
            {
                // Update Rotation Degrees and Send command
                serialPort1.WriteLine(textmessage);
                lblCurrentPosition.Text = (Convert.ToDouble(lblCurrentPosition.Text.Replace("°", "")) - currentStepSize).ToString() + "°";
                seriesLocation.Points[0].XValue -= currentStepSize;
            }
            else
            {
                textBox1.Text = "Port Is Not Open";
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
                lblCurrentPosition.Text = (Convert.ToDouble(lblCurrentPosition.Text.Replace("°", "")) + currentStepSize).ToString() + "°";
                seriesLocation.Points[0].XValue += currentStepSize;
            }
            else
            {
                textBox1.Text = "Port Is Not Open";
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
        }

        private void btnReturnBoomHome_Click(object sender, EventArgs e)
        {
            //Return to zero
            String textmessage = "z";

            if (serialPort1.IsOpen)
            {
                // Update Rotation Degrees and Send command
                serialPort1.WriteLine(textmessage);
                lblCurrentPosition.Text = "0°";
                seriesLocation.Points[0].XValue = 0;
            }
            else
            {
                textBox1.Text = "Port Is Not Open";
            }
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

        private void formMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {            
            // Close Port
            serialPort1.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStepSize();

        }
        private void UpdateStepSize()
        {
            String stepSizeChange = Convert.ToString(comboBox3.SelectedIndex + 2);

            if (serialPort1.IsOpen)  // Update Rotation Degrees and Send command
            {
                serialPort1.WriteLine(stepSizeChange);

                if ((comboBox3.SelectedIndex + 2) == 2)
                    currentStepSize = 2;
                else if ((comboBox3.SelectedIndex + 2) == 3)
                    currentStepSize = 4;
                else if ((comboBox3.SelectedIndex + 2) == 4)
                    currentStepSize = 6;
                else if ((comboBox3.SelectedIndex + 2) == 5)
                    currentStepSize = 10;
                else if ((comboBox3.SelectedIndex + 2) == 6)
                    currentStepSize = 20;
                else if ((comboBox3.SelectedIndex + 2) == 7)
                    currentStepSize = 30;
                else if ((comboBox3.SelectedIndex + 2) == 8)
                    currentStepSize = 60;
                else if ((comboBox3.SelectedIndex + 2) == 9)
                    currentStepSize = 120;
            }
            else
                textBox1.Text = "Port Is Not Open";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    textBox1.Invoke(this.myDelegate, new Object[] {serialPort1.ReadExisting()});
                }
                catch (TimeoutException)
                {
                    textBox1.Invoke(this.myDelegate, new Object[] { "Timeout Exception" }); 
                }
            }
            else
            {
                textBox1.Invoke(this.myDelegate, new Object[] { "Port Is Not Open" });                
            }
        }
        public void serial_Logger(String myString)
        {
            textBox1.AppendText(myString);
        }
    }
}
