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

        public formConnect()
        {
            InitializeComponent();
        }

        private void formConnect_Load(object sender, EventArgs e)
        {
            findPorts();
        }

        private void findPorts()
        {
            // Get availble port names
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select p["Caption"]).ToList();

                foreach (string COM_Name in tList)
                {
                    comboBox_Ports.Items.Add(COM_Name);
                }
            }
            
            int platform_index = comboBox_Ports.FindString("UOW Rotating Platform",0);
            
            if (platform_index >= 0)
                comboBox_Ports.SelectedIndex = platform_index;
            else if (comboBox_Ports.Items.Count >= 0)
                comboBox_Ports.SelectedIndex = 0;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (comboBox_Ports.SelectedItem == null)
            {
                MessageBox.Show("Please select a port to communicate over.");
            }
            else
            {
                Port_Name = comboBox_Ports.SelectedItem.ToString().Split(new char[] { '(', ')' })[1];
                this.DialogResult = DialogResult.OK;
            }
        }
    }

}
