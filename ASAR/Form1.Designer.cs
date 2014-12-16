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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnAudacityRecord = new System.Windows.Forms.Button();
            this.btnAudacityPlay = new System.Windows.Forms.Button();
            this.btnAudacitySkipToEnd = new System.Windows.Forms.Button();
            this.btnAudacityStop = new System.Windows.Forms.Button();
            this.btnAudacityPause = new System.Windows.Forms.Button();
            this.btnAudacitySkipToStart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnReturnBoomHome = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtSerialLog = new System.Windows.Forms.TextBox();
            this.btnStart360Rec = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.tabDisplayChoice = new System.Windows.Forms.TabControl();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.chartLocation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAudacity = new System.Windows.Forms.Button();
            this.timerChartAnimation = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabDisplayChoice.SuspendLayout();
            this.tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAudacityRecord
            // 
            this.btnAudacityRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudacityRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityRecord.Location = new System.Drawing.Point(131, 141);
            this.btnAudacityRecord.Name = "btnAudacityRecord";
            this.btnAudacityRecord.Size = new System.Drawing.Size(123, 35);
            this.btnAudacityRecord.TabIndex = 21;
            this.btnAudacityRecord.Text = "Record";
            this.btnAudacityRecord.UseVisualStyleBackColor = true;
            this.btnAudacityRecord.Click += new System.EventHandler(this.btnAudacityRecord_Click);
            // 
            // btnAudacityPlay
            // 
            this.btnAudacityPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudacityPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityPlay.Location = new System.Drawing.Point(131, 59);
            this.btnAudacityPlay.Name = "btnAudacityPlay";
            this.btnAudacityPlay.Size = new System.Drawing.Size(123, 35);
            this.btnAudacityPlay.TabIndex = 22;
            this.btnAudacityPlay.Text = "Play";
            this.btnAudacityPlay.UseVisualStyleBackColor = true;
            this.btnAudacityPlay.Click += new System.EventHandler(this.btnAudacityPlay_Click);
            // 
            // btnAudacitySkipToEnd
            // 
            this.btnAudacitySkipToEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudacitySkipToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacitySkipToEnd.Location = new System.Drawing.Point(131, 100);
            this.btnAudacitySkipToEnd.Name = "btnAudacitySkipToEnd";
            this.btnAudacitySkipToEnd.Size = new System.Drawing.Size(123, 35);
            this.btnAudacitySkipToEnd.TabIndex = 23;
            this.btnAudacitySkipToEnd.Text = "Skip to End";
            this.btnAudacitySkipToEnd.UseVisualStyleBackColor = true;
            this.btnAudacitySkipToEnd.Click += new System.EventHandler(this.btnAudacitySkipToEnd_Click);
            // 
            // btnAudacityStop
            // 
            this.btnAudacityStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudacityStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityStop.Location = new System.Drawing.Point(3, 141);
            this.btnAudacityStop.Name = "btnAudacityStop";
            this.btnAudacityStop.Size = new System.Drawing.Size(122, 35);
            this.btnAudacityStop.TabIndex = 24;
            this.btnAudacityStop.Text = "Stop";
            this.btnAudacityStop.UseVisualStyleBackColor = true;
            this.btnAudacityStop.Click += new System.EventHandler(this.btnAudacityStop_Click);
            // 
            // btnAudacityPause
            // 
            this.btnAudacityPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudacityPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityPause.Location = new System.Drawing.Point(3, 59);
            this.btnAudacityPause.Name = "btnAudacityPause";
            this.btnAudacityPause.Size = new System.Drawing.Size(122, 35);
            this.btnAudacityPause.TabIndex = 25;
            this.btnAudacityPause.Text = "Pause";
            this.btnAudacityPause.UseVisualStyleBackColor = true;
            this.btnAudacityPause.Click += new System.EventHandler(this.btnAudacityPause_Click);
            // 
            // btnAudacitySkipToStart
            // 
            this.btnAudacitySkipToStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudacitySkipToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacitySkipToStart.Location = new System.Drawing.Point(3, 100);
            this.btnAudacitySkipToStart.Name = "btnAudacitySkipToStart";
            this.btnAudacitySkipToStart.Size = new System.Drawing.Size(122, 35);
            this.btnAudacitySkipToStart.TabIndex = 26;
            this.btnAudacitySkipToStart.Text = "Skip to Start";
            this.btnAudacitySkipToStart.UseVisualStyleBackColor = true;
            this.btnAudacitySkipToStart.Click += new System.EventHandler(this.btnAudacitySkipToStart_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 500;
            this.serialPort1.WriteTimeout = 500;
            // 
            // btnReturnBoomHome
            // 
            this.btnReturnBoomHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnBoomHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBoomHome.Location = new System.Drawing.Point(421, 50);
            this.btnReturnBoomHome.Name = "btnReturnBoomHome";
            this.btnReturnBoomHome.Size = new System.Drawing.Size(204, 60);
            this.btnReturnBoomHome.TabIndex = 46;
            this.btnReturnBoomHome.Text = "Return to Zero°";
            this.btnReturnBoomHome.UseVisualStyleBackColor = true;
            this.btnReturnBoomHome.Click += new System.EventHandler(this.btnReturnBoomHome_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2°",
            "4°",
            "6°",
            "10°",
            "20°",
            "30°",
            "60°",
            "120°"});
            this.comboBox3.Location = new System.Drawing.Point(421, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(204, 33);
            this.comboBox3.TabIndex = 44;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtSerialLog
            // 
            this.txtSerialLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txtSerialLog, 2);
            this.txtSerialLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialLog.Location = new System.Drawing.Point(3, 182);
            this.txtSerialLog.Multiline = true;
            this.txtSerialLog.Name = "txtSerialLog";
            this.txtSerialLog.ReadOnly = true;
            this.txtSerialLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSerialLog.Size = new System.Drawing.Size(251, 542);
            this.txtSerialLog.TabIndex = 32;
            this.txtSerialLog.Text = "Receive here";
            this.txtSerialLog.WordWrap = false;
            // 
            // btnStart360Rec
            // 
            this.btnStart360Rec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart360Rec.BackColor = System.Drawing.Color.MistyRose;
            this.btnStart360Rec.Enabled = false;
            this.btnStart360Rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart360Rec.Location = new System.Drawing.Point(0, 0);
            this.btnStart360Rec.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart360Rec.Name = "btnStart360Rec";
            this.btnStart360Rec.Size = new System.Drawing.Size(209, 47);
            this.btnStart360Rec.TabIndex = 30;
            this.btnStart360Rec.Text = "Start 360° Recording";
            this.btnStart360Rec.UseVisualStyleBackColor = false;
            this.btnStart360Rec.Click += new System.EventHandler(this.btnStart360Rec_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.69537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.30464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 733);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lblCurrentPosition, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRotateCCW, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox3, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnReturnBoomHome, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRotateCW, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnStart360Rec, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabDisplayChoice, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(628, 727);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPosition.Location = new System.Drawing.Point(421, 0);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(204, 47);
            this.lblCurrentPosition.TabIndex = 16;
            this.lblCurrentPosition.Text = "0°";
            this.lblCurrentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Position:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotateCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCCW.Location = new System.Drawing.Point(3, 50);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(203, 60);
            this.btnRotateCCW.TabIndex = 9;
            this.btnRotateCCW.Text = "Rotate Counter-Clockwise";
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Current Step Size:";
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotateCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCW.Location = new System.Drawing.Point(212, 50);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(203, 60);
            this.btnRotateCW.TabIndex = 10;
            this.btnRotateCW.Text = "Rotate Clockwise";
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            // 
            // tabDisplayChoice
            // 
            this.tabDisplayChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.tabDisplayChoice, 3);
            this.tabDisplayChoice.Controls.Add(this.tabLocation);
            this.tabDisplayChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplayChoice.Location = new System.Drawing.Point(3, 136);
            this.tabDisplayChoice.Name = "tabDisplayChoice";
            this.tabDisplayChoice.SelectedIndex = 0;
            this.tabDisplayChoice.Size = new System.Drawing.Size(622, 588);
            this.tabDisplayChoice.TabIndex = 18;
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.chartLocation);
            this.tabLocation.Location = new System.Drawing.Point(4, 29);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocation.Size = new System.Drawing.Size(614, 555);
            this.tabLocation.TabIndex = 0;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // chartLocation
            // 
            this.chartLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartLocation.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Interval = 90D;
            chartArea1.Name = "ChartArea1";
            this.chartLocation.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartLocation.Legends.Add(legend1);
            this.chartLocation.Location = new System.Drawing.Point(6, 6);
            this.chartLocation.Name = "chartLocation";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.CustomProperties = "LabelStyle=Top";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerBorderWidth = 2;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 20;
            series1.MarkerStep = 2;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10;
            series1.Name = "Location";
            series1.SmartLabelStyle.Enabled = false;
            series1.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center)));
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartLocation.Series.Add(series1);
            this.chartLocation.Size = new System.Drawing.Size(602, 553);
            this.chartLocation.TabIndex = 18;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Location";
            title1.Text = "Location";
            this.chartLocation.Titles.Add(title1);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnAudacityRecord, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacityStop, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacityPause, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtSerialLog, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacityPlay, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacitySkipToEnd, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacity, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacitySkipToStart, 0, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(637, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(257, 727);
            this.tableLayoutPanel6.TabIndex = 49;
            // 
            // btnAudacity
            // 
            this.btnAudacity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.btnAudacity, 2);
            this.btnAudacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacity.Location = new System.Drawing.Point(3, 3);
            this.btnAudacity.Name = "btnAudacity";
            this.btnAudacity.Size = new System.Drawing.Size(251, 50);
            this.btnAudacity.TabIndex = 20;
            this.btnAudacity.Text = "Start Audacity";
            this.btnAudacity.UseVisualStyleBackColor = true;
            this.btnAudacity.Click += new System.EventHandler(this.btnAudacity_Click);
            // 
            // timerChartAnimation
            // 
            this.timerChartAnimation.Interval = 1;
            this.timerChartAnimation.Tick += new System.EventHandler(this.timerChartAnimation_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 757);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automated Spatial Audio Recorder - ASAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabDisplayChoice.ResumeLayout(false);
            this.tabLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAudacityRecord;
        private System.Windows.Forms.Button btnAudacityPlay;
        private System.Windows.Forms.Button btnAudacitySkipToEnd;
        private System.Windows.Forms.Button btnAudacityStop;
        private System.Windows.Forms.Button btnAudacityPause;
        private System.Windows.Forms.Button btnAudacitySkipToStart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnReturnBoomHome;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtSerialLog;
        private System.Windows.Forms.Button btnStart360Rec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLocation;
        private System.Windows.Forms.TabControl tabDisplayChoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAudacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerChartAnimation;
    }
}

