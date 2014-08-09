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

//Web
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Net.Http;

using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;

//UI Automation with White
using TestStack.White;
using TestStack.White.WindowsAPI;
using TestStack.White.UIItems;

namespace ASAR
{
    /* Attn. Matthew Dabin
* Feel free to start writing code here which will connect
* to the COM port of choice and you can display the output
* in a TextBox object on Form1.
* Once you get connected and start transceiving clean signals
* you can create functions for the buttons to send the appropriate commands.
* After this is done you can look at writing a class for the code OR just start a class/object right away :)
*/

    public partial class formMain : Form
    {
        //Charts
        Series seriesLocation;
        Series seriesFrequency;

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

        //Miscellaneous
        bool ExitFlag = false;
        String rotation = "1"; //Stepper motor step size
        String serialLog;
        String currentPosition;
        double AngleOfRotation;
        String Btn360RecString;

        public formMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Code to run when the Form loads
            // Initialise the location graph
            seriesLocation = chartLocation.Series[0];
            seriesLocation.Points.Clear();
            seriesLocation.Points.AddXY(0, 10);
            seriesLocation.Points.AddXY(0, 0);
            
            // Initialise the frequency graph
            seriesFrequency = chartFrequency.Series[0];
            seriesFrequency.Points.Clear();
            int frequencyResolution = 50;
            for (int i = 0; i < frequencyResolution; i++)
                seriesFrequency.Points.AddY(Math.Sin(((double)i / frequencyResolution) / Math.PI * 10)); //This is just a sample to see what the chart looks like

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

            //Find available COM ports and list them
            findPorts();

            //Miscellaneous
            currentPosition = lblCurrentPosition.Text;
        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            //Rotate Left
            String textmessage = "l";
            double step = -Convert.ToDouble(rotation);

            if (serialPort1.IsOpen)
            {
                // Update Rotation Degrees and Send command
                serialPort1.WriteLine(rotation);
                serialLog += Environment.NewLine + rotation;
                serialPort1.WriteLine(textmessage);
                serialLog += Environment.NewLine + textmessage;
                currentPosition = (Convert.ToDouble(currentPosition.Replace("°", "")) + step).ToString() + "°";
                AngleOfRotation += step;
            }
            else
            {
                serialLog = "Port Is Not Open";
            }

        }

        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            //Rotate Right
            String textmessage = "r";
            double step = Convert.ToDouble(rotation);

            if (serialPort1.IsOpen)
            {
                // Update Rotation Degrees and Send command
                serialPort1.WriteLine(rotation);
                serialLog += Environment.NewLine + rotation;
                serialPort1.WriteLine(textmessage);
                serialLog += Environment.NewLine + textmessage;
                currentPosition = (Convert.ToDouble(currentPosition.Replace("°", "")) + step).ToString() + "°";
                AngleOfRotation += step;
            }
            else
            {
                serialLog = "Port Is Not Open";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void findPorts()
        {
            // Get availble port names
            string[] objectArray = SerialPort.GetPortNames();
            // Add string to combobox
            comboBox1.Items.AddRange(objectArray);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Initialise Button
            //int _Baud = 9600;

            serialLog = String.Empty;
            //this->serialPort1->BaudRate = Int32::Parse(System::String ^_Baud);
            //if (this->comboBox1->Text == String::Empty || this->comboBox2->Text == String::Empty) {
            if (comboBox1.Text == String.Empty)
            {
                // Check port setting are selected
                serialLog = "Select Port Settings";
            }
            else
            {
                try
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.PortName = comboBox1.Text;
                        //this->serialPort1->BaudRate = Int32::Parse(this->comboBox2->Text);
                        serialPort1.ReadTimeout = 500;
                        serialPort1.WriteTimeout = 500;
                        serialLog = "Enter Message Here";
                        // Open Serial Port
                        serialPort1.Open();
                        progressBar1.Value = 100;
                        serialLog = "Serial Port Initialised";
                        button5.Enabled = false;
                        comboBox2.Enabled = false;
                        comboBox1.Enabled = false;
                    }
                    else
                    {
                        serialLog = "Port is not opened";
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    serialLog = "Unauthorised Access";
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Close Port
            serialPort1.Close();
            // Update Status Bar
            progressBar1.Value = 0;
            // Enable Read Button
            // this->button8_Click->Enabled = true;
            // Enable Init Button
            button5.Enabled = true;
        }

        private void btnReturnBoomHome_Click(object sender, EventArgs e)
        {
            //Rotate Right
            String textmessage = "z";

            if (serialPort1.IsOpen)
            {
                // Send command
                serialPort1.WriteLine(textmessage);
                serialLog += Environment.NewLine + textmessage;
                currentPosition = (0).ToString() + "°";
                AngleOfRotation = 0;
            }
            else
            {
                serialLog = "Port Is Not Open";
            }
        }

        private void btnStart360Rec_Click(object sender, EventArgs e)
        {
            if (btnStart360Rec.Text == "STOP")
            {
                ExitFlag = true; 
                btnStart360Rec.Text = Btn360RecString;
                serialLogUpdateTimer.Enabled = false; 
                serialLogText.Text = serialLog;
                lblCurrentPosition.Text = currentPosition;
                seriesLocation.Points[0].XValue = AngleOfRotation;
                this.TopMost = true;
                this.TopMost = false;
                this.Activate();
            }
            else
            {
                ExitFlag = false;
                Btn360RecString = btnStart360Rec.Text;
                btnStart360Rec.Text = "STOP";
                currentPosition = lblCurrentPosition.Text;
                serialLogUpdateTimer.Enabled = true;
                System.Threading.Thread thread1 = new System.Threading.Thread(new System.Threading.ThreadStart(Record_360));
                thread1.Start();
            }
        }
        private void Record_360()
        {
            //
            //Start 360 degree recording sequence here
            //
            object sender = new object();
            EventArgs e = new EventArgs();

            //Initialise
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please connect to COM port first.");
                return;
            }
            btnAudacity_Click(sender, e);
            //Something like
            int recDuration = 1000; //10000ms = 10s  //TODO: Should obtain this value from the duration of the audio file used !
            for (double angle = 0; angle < 360; angle += Convert.ToDouble(rotation))
            {
                btnAudacityRecord_Click(sender, e); // start recording
                System.Threading.Thread.Sleep(recDuration + 100/*plus buffer*/); //Sleep program for duration of recording
                btnAudacityStop_Click(sender, e); // stop recording
                if (ExitFlag)
                    break;
                btnRotateCW_Click(sender, e); // Rotate to next position
                System.Threading.Thread.Sleep(1000); //One second wait for rotation to complete                
            }
            if (!ExitFlag)
            {//Last angle's recording
                btnAudacityRecord_Click(sender, e); // start recording
                System.Threading.Thread.Sleep(recDuration + 100/*plus buffer*/);//Sleep program for duration of recording
                btnAudacityStop_Click(sender, e); // stop recording
            }
            btnReturnBoomHome_Click(sender, e); // Return the boom to it's home location
            ExitFlag = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // Send Button
            String name = serialPort1.PortName;
            String textmessage = textBox2.Text;
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(textmessage);
                serialLog += Environment.NewLine + textmessage;
            }
            else
            {
                serialLog = "Port Is Not Open";
            }
        }

        private void Recieve_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //serialLog = String.Empty;
                try
                {
                    serialLog += Environment.NewLine + serialPort1.ReadLine();
                }
                catch (TimeoutException)
                {
                    serialLog = "Timeout Exception";
                }
                button5.Enabled = false;
            }
            else
            {
                serialLog = "Port Is Not Open";
            }
            // Recieve Button
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            rotation = comboBox3.Text;
        }

        private void serialLogUpdateTimer_Tick(object sender, EventArgs e)
        {
            serialLogText.Text = "";
            serialLogText.AppendText(serialLog);
            lblCurrentPosition.Text = currentPosition;
            seriesLocation.Points[0].XValue = AngleOfRotation;

            this.TopMost = true;
            this.TopMost = false;
            this.Activate();
            if(ExitFlag)
            {
                serialLogUpdateTimer.Enabled = false;
                btnStart360Rec.Text = Btn360RecString;                
            }
        }

        private void btnReturnBoomHome_MouseClick(object sender, MouseEventArgs e)
        {
            serialLogUpdateTimer_Tick(sender, e);
        }

        private void btnRotateCW_MouseClick(object sender, MouseEventArgs e)
        {
            serialLogUpdateTimer_Tick(sender, e);
        }

        private void btnRotateCCW_MouseClick(object sender, MouseEventArgs e)
        {
            serialLogUpdateTimer_Tick(sender, e);
        }

  
    }
}
