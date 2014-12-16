using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Serial Includes
using System.IO.Ports;
using System.IO;
using System.Management;

namespace ASAR
{
    public partial class formConnect : Form
    {
        public String Port_Name = "";
        private ComboBox serialItems = new ComboBox();
        private bool isCompleted = false;

        public formConnect()
        {
            InitializeComponent();
        }

        private void formConnect_Load(object sender, EventArgs e)
        {
            findPorts2();

            int platform_index = comboBox_Ports.FindString("UOW Rotating Platform", 0);

            if (platform_index >= 0)
                comboBox_Ports.SelectedIndex = platform_index;
            else
            {
                platform_index = comboBox_Ports.FindString("COM1", 0);

                if (platform_index >= 0)
                    comboBox_Ports.SelectedIndex = platform_index;
                else if (comboBox_Ports.Items.Count >= 0)
                    comboBox_Ports.SelectedIndex = 0;
            }
        }
        
        private void findPorts2()
        {
            comboBox_Ports.Items.Clear();
            serialItems.Items.Clear();

            // Get availble port names
            string[] objectArray = SerialPort.GetPortNames();
            // Add string to combobox
            comboBox_Ports.Items.AddRange(objectArray);
        }

        private void findPorts()
        {
            try
            {
                comboBox_Ports.Items.Clear();
                serialItems.Items.Clear();

                ManagementObjectSearcher searcher = new ManagementObjectSearcher( new SelectQuery("WIN32_SerialPort"));
                ManagementOperationObserver results = new ManagementOperationObserver();
                results.ObjectReady += new ObjectReadyEventHandler(this.NewObject);
                results.Completed += new CompletedEventHandler(this.Done);

                // Get availble port names asynchronously
                searcher.Get(results); 

                while (!this.Completed)
                {
                    System.Threading.Thread.Sleep(1000);
                }
                this.Reset(); 

            }
            catch (ManagementException e)
            {
                MessageBox.Show("Failed to run query: " + e.Message);
                throw;
            }

            foreach (object port in serialItems.Items)
            {
                comboBox_Ports.Items.Add(port);
            }                       

        }
        private void NewObject(object sender,
            ObjectReadyEventArgs obj)
        {
            try
            {
                serialItems.Items.Add( obj.NewObject["Caption"].ToString().Clone() );
            }
            catch (ManagementException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

        }
        private bool Completed
        {
            get
            {
                return isCompleted;
            }
        }

        private void Reset()
        {
            isCompleted = false;
        }

        private void Done(object sender,
                 CompletedEventArgs obj)
        {
            isCompleted = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SerialConnect2();
        }
        private void SerialConnect2()
        {
            if (comboBox_Ports.SelectedItem == null)
            {
                MessageBox.Show("Please select a port to communicate over.");
            }
            else
            {
                Port_Name = comboBox_Ports.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
        private void SerialConnect()
        {
            if (comboBox_Ports.SelectedItem == null)
            {
                MessageBox.Show("Please select a port to communicate over.");
            }
            else
            {
                Port_Name = comboBox_Ports.SelectedItem.ToString().Split(new char[] { '(', ')' })[1];
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
    }

}
