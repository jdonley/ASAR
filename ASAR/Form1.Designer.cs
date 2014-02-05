namespace ASAR
{
    partial class formMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.tabDisplayChoice = new System.Windows.Forms.TabControl();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.chartLocation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabFrequency = new System.Windows.Forms.TabPage();
            this.chartFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAudacity = new System.Windows.Forms.Button();
            this.btnAudacityRecord = new System.Windows.Forms.Button();
            this.btnAudacityPlay = new System.Windows.Forms.Button();
            this.btnAudacitySkipToEnd = new System.Windows.Forms.Button();
            this.btnAudacityStop = new System.Windows.Forms.Button();
            this.btnAudacityPause = new System.Windows.Forms.Button();
            this.btnAudacitySkipToStart = new System.Windows.Forms.Button();
            this.tabDisplayChoice.SuspendLayout();
            this.tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).BeginInit();
            this.tabFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 487);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Serial Feed";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(256, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 74);
            this.button4.TabIndex = 13;
            this.button4.Text = "Start 360 degree Recording";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "Start Recording";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Position:";
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCW.Location = new System.Drawing.Point(222, 9);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(191, 61);
            this.btnRotateCW.TabIndex = 10;
            this.btnRotateCW.Text = "Rotate Clockwise";
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCCW.Location = new System.Drawing.Point(22, 9);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(194, 61);
            this.btnRotateCCW.TabIndex = 9;
            this.btnRotateCCW.Text = "Rotate Counter-Clockwise";
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPosition.Location = new System.Drawing.Point(225, 73);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(40, 31);
            this.lblCurrentPosition.TabIndex = 16;
            this.lblCurrentPosition.Text = "0°";
            // 
            // tabDisplayChoice
            // 
            this.tabDisplayChoice.Controls.Add(this.tabLocation);
            this.tabDisplayChoice.Controls.Add(this.tabFrequency);
            this.tabDisplayChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplayChoice.Location = new System.Drawing.Point(12, 203);
            this.tabDisplayChoice.Name = "tabDisplayChoice";
            this.tabDisplayChoice.SelectedIndex = 0;
            this.tabDisplayChoice.Size = new System.Drawing.Size(401, 315);
            this.tabDisplayChoice.TabIndex = 18;
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.chartLocation);
            this.tabLocation.Location = new System.Drawing.Point(4, 29);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocation.Size = new System.Drawing.Size(393, 282);
            this.tabLocation.TabIndex = 0;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // chartLocation
            // 
            this.chartLocation.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.chartLocation.ChartAreas.Add(chartArea11);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartLocation.Legends.Add(legend6);
            this.chartLocation.Location = new System.Drawing.Point(1, 6);
            this.chartLocation.Name = "chartLocation";
            series11.BorderWidth = 5;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series11.Legend = "Legend1";
            series11.MarkerBorderColor = System.Drawing.Color.Blue;
            series11.MarkerBorderWidth = 2;
            series11.MarkerSize = 15;
            series11.MarkerStep = 2;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series11.Name = "Location";
            series11.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartLocation.Series.Add(series11);
            this.chartLocation.Size = new System.Drawing.Size(386, 277);
            this.chartLocation.TabIndex = 18;
            title11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.Name = "Location";
            title11.Text = "Location";
            this.chartLocation.Titles.Add(title11);
            // 
            // tabFrequency
            // 
            this.tabFrequency.Controls.Add(this.chartFrequency);
            this.tabFrequency.Location = new System.Drawing.Point(4, 29);
            this.tabFrequency.Name = "tabFrequency";
            this.tabFrequency.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrequency.Size = new System.Drawing.Size(393, 282);
            this.tabFrequency.TabIndex = 1;
            this.tabFrequency.Text = "Frequency";
            this.tabFrequency.UseVisualStyleBackColor = true;
            // 
            // chartFrequency
            // 
            chartArea12.Name = "ChartArea1";
            this.chartFrequency.ChartAreas.Add(chartArea12);
            this.chartFrequency.Location = new System.Drawing.Point(6, 6);
            this.chartFrequency.Name = "chartFrequency";
            this.chartFrequency.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series12.ChartArea = "ChartArea1";
            series12.Name = "Series1";
            this.chartFrequency.Series.Add(series12);
            this.chartFrequency.Size = new System.Drawing.Size(381, 270);
            this.chartFrequency.TabIndex = 0;
            this.chartFrequency.Text = "chartFrequency";
            title12.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title12.Name = "Frequency";
            title12.Text = "Frequency";
            this.chartFrequency.Titles.Add(title12);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "UI Automation";
            // 
            // btnAudacity
            // 
            this.btnAudacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacity.Location = new System.Drawing.Point(588, 32);
            this.btnAudacity.Name = "btnAudacity";
            this.btnAudacity.Size = new System.Drawing.Size(312, 50);
            this.btnAudacity.TabIndex = 20;
            this.btnAudacity.Text = "Start Audacity";
            this.btnAudacity.UseVisualStyleBackColor = true;
            this.btnAudacity.Click += new System.EventHandler(this.btnAudacity_Click);
            // 
            // btnAudacityRecord
            // 
            this.btnAudacityRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityRecord.Location = new System.Drawing.Point(800, 144);
            this.btnAudacityRecord.Name = "btnAudacityRecord";
            this.btnAudacityRecord.Size = new System.Drawing.Size(100, 50);
            this.btnAudacityRecord.TabIndex = 21;
            this.btnAudacityRecord.Text = "Record";
            this.btnAudacityRecord.UseVisualStyleBackColor = true;
            this.btnAudacityRecord.Click += new System.EventHandler(this.btnAudacityRecord_Click);
            // 
            // btnAudacityPlay
            // 
            this.btnAudacityPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityPlay.Location = new System.Drawing.Point(694, 88);
            this.btnAudacityPlay.Name = "btnAudacityPlay";
            this.btnAudacityPlay.Size = new System.Drawing.Size(100, 50);
            this.btnAudacityPlay.TabIndex = 22;
            this.btnAudacityPlay.Text = "Play";
            this.btnAudacityPlay.UseVisualStyleBackColor = true;
            this.btnAudacityPlay.Click += new System.EventHandler(this.btnAudacityPlay_Click);
            // 
            // btnAudacitySkipToEnd
            // 
            this.btnAudacitySkipToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacitySkipToEnd.Location = new System.Drawing.Point(694, 144);
            this.btnAudacitySkipToEnd.Name = "btnAudacitySkipToEnd";
            this.btnAudacitySkipToEnd.Size = new System.Drawing.Size(100, 50);
            this.btnAudacitySkipToEnd.TabIndex = 23;
            this.btnAudacitySkipToEnd.Text = "Skip to End";
            this.btnAudacitySkipToEnd.UseVisualStyleBackColor = true;
            this.btnAudacitySkipToEnd.Click += new System.EventHandler(this.btnAudacitySkipToEnd_Click);
            // 
            // btnAudacityStop
            // 
            this.btnAudacityStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityStop.Location = new System.Drawing.Point(800, 88);
            this.btnAudacityStop.Name = "btnAudacityStop";
            this.btnAudacityStop.Size = new System.Drawing.Size(100, 50);
            this.btnAudacityStop.TabIndex = 24;
            this.btnAudacityStop.Text = "Stop";
            this.btnAudacityStop.UseVisualStyleBackColor = true;
            this.btnAudacityStop.Click += new System.EventHandler(this.btnAudacityStop_Click);
            // 
            // btnAudacityPause
            // 
            this.btnAudacityPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityPause.Location = new System.Drawing.Point(588, 88);
            this.btnAudacityPause.Name = "btnAudacityPause";
            this.btnAudacityPause.Size = new System.Drawing.Size(100, 50);
            this.btnAudacityPause.TabIndex = 25;
            this.btnAudacityPause.Text = "Pause";
            this.btnAudacityPause.UseVisualStyleBackColor = true;
            this.btnAudacityPause.Click += new System.EventHandler(this.btnAudacityPause_Click);
            // 
            // btnAudacitySkipToStart
            // 
            this.btnAudacitySkipToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacitySkipToStart.Location = new System.Drawing.Point(588, 144);
            this.btnAudacitySkipToStart.Name = "btnAudacitySkipToStart";
            this.btnAudacitySkipToStart.Size = new System.Drawing.Size(100, 50);
            this.btnAudacitySkipToStart.TabIndex = 26;
            this.btnAudacitySkipToStart.Text = "Skip to Start";
            this.btnAudacitySkipToStart.UseVisualStyleBackColor = true;
            this.btnAudacitySkipToStart.Click += new System.EventHandler(this.btnAudacitySkipToStart_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 527);
            this.Controls.Add(this.btnAudacitySkipToStart);
            this.Controls.Add(this.btnAudacityPause);
            this.Controls.Add(this.btnAudacityStop);
            this.Controls.Add(this.btnAudacitySkipToEnd);
            this.Controls.Add(this.btnAudacityPlay);
            this.Controls.Add(this.btnAudacityRecord);
            this.Controls.Add(this.btnAudacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabDisplayChoice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRotateCW);
            this.Controls.Add(this.btnRotateCCW);
            this.Controls.Add(this.lblCurrentPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDisplayChoice.ResumeLayout(false);
            this.tabLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).EndInit();
            this.tabFrequency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.TabControl tabDisplayChoice;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLocation;
        private System.Windows.Forms.TabPage tabFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAudacity;
        private System.Windows.Forms.Button btnAudacityRecord;
        private System.Windows.Forms.Button btnAudacityPlay;
        private System.Windows.Forms.Button btnAudacitySkipToEnd;
        private System.Windows.Forms.Button btnAudacityStop;
        private System.Windows.Forms.Button btnAudacityPause;
        private System.Windows.Forms.Button btnAudacitySkipToStart;
    }
}

