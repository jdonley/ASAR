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

            // Initialise the frequency graph
            seriesFrequency = chartFrequency.Series[0];
            seriesFrequency.Points.Clear();
            int frequencyResolution = 50;
            for (int i = 0; i < frequencyResolution; i++)
                seriesFrequency.Points.AddY( Math.Sin(((double)i / frequencyResolution) / Math.PI * 10)); //This is just a sample to see what the chart looks like

                //Initial serial port settings
                serialPort.PortName = "COM1";
			serialPort.BaudRate = 9600;
			serialPort.DataBits = 8;
			serialPort.StopBits = StopBits.One;
			serialPort.Parity = Parity.None;
			serialPort.Handshake = Handshake.None;
			serialPort.ReadBufferSize = 4096;
			serialPort.ReadTimeout = -1;
			serialPort.WriteBufferSize = 2048;
			serialPort.WriteTimeout = -1;
        }

        private void btnRotateCCW_Click(object sender, EventArgs e)
        {
            double step = -7.5;
			lblCurrentPosition.Text = (Convert.ToDouble(lblCurrentPosition.Text.Replace("°", "")) + step).ToString() + "°";
			seriesLocation.Points[0].XValue += step;
        }

        private void btnRotateCW_Click(object sender, EventArgs e)
        {
            double step = 7.5;
			lblCurrentPosition.Text = (Convert.ToDouble(lblCurrentPosition.Text.Replace("°", "")) + step).ToString() + "°";
			seriesLocation.Points[0].XValue += step;
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
                audacityWindow.Close();
            }
            catch (Exception ex)
            { }
        }

    }
}
