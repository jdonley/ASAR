using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;

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

    public partial class Form1 : Form
    {        
		Series seriesLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        // Code to run when the Form loads
		    // Initialise the graph
		    seriesLocation = chartLocation.Series[0];
			seriesLocation.Points.Clear();
			seriesLocation.Points.AddXY(0, 10);
			seriesLocation.Points.AddXY(0, 0);

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
    }
}
