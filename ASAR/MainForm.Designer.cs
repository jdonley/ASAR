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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnAudacityRecord = new System.Windows.Forms.Button();
            this.btnAudacityPlay = new System.Windows.Forms.Button();
            this.btnAudacitySkipToEnd = new System.Windows.Forms.Button();
            this.btnAudacityStop = new System.Windows.Forms.Button();
            this.btnAudacityPause = new System.Windows.Forms.Button();
            this.btnAudacitySkipToStart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnReturnBoomHome = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Recieve = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialLogText = new System.Windows.Forms.TextBox();
            this.btnStart360Rec = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabDisplayChoice = new System.Windows.Forms.TabControl();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.chartLocation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabFrequency = new System.Windows.Forms.TabPage();
            this.chartFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAudacity = new System.Windows.Forms.Button();
            this.serialLogUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabDisplayChoice.SuspendLayout();
            this.tabLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).BeginInit();
            this.tabFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequency)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAudacityRecord
            // 
            this.btnAudacityRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudacityRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudacityRecord.Location = new System.Drawing.Point(117, 141);
            this.btnAudacityRecord.Name = "btnAudacityRecord";
            this.btnAudacityRecord.Size = new System.Drawing.Size(108, 35);
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
            this.btnAudacityPlay.Location = new System.Drawing.Point(117, 59);
            this.btnAudacityPlay.Name = "btnAudacityPlay";
            this.btnAudacityPlay.Size = new System.Drawing.Size(108, 35);
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
            this.btnAudacitySkipToEnd.Location = new System.Drawing.Point(117, 100);
            this.btnAudacitySkipToEnd.Name = "btnAudacitySkipToEnd";
            this.btnAudacitySkipToEnd.Size = new System.Drawing.Size(108, 35);
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
            this.btnAudacityStop.Size = new System.Drawing.Size(108, 35);
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
            this.btnAudacityPause.Size = new System.Drawing.Size(108, 35);
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
            this.btnAudacitySkipToStart.Size = new System.Drawing.Size(108, 35);
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
            this.btnReturnBoomHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBoomHome.Location = new System.Drawing.Point(311, 50);
            this.btnReturnBoomHome.Name = "btnReturnBoomHome";
            this.btnReturnBoomHome.Size = new System.Drawing.Size(148, 50);
            this.btnReturnBoomHome.TabIndex = 46;
            this.btnReturnBoomHome.Text = "Return Home";
            this.btnReturnBoomHome.UseVisualStyleBackColor = true;
            this.btnReturnBoomHome.Click += new System.EventHandler(this.btnReturnBoomHome_Click);
            this.btnReturnBoomHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturnBoomHome_MouseClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Step Size";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(73, 85);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(88, 21);
            this.comboBox3.TabIndex = 44;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 26);
            this.label5.TabIndex = 43;
            this.label5.Text = "Port Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(47, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(14, 10);
            this.progressBar1.TabIndex = 42;
            // 
            // Recieve
            // 
            this.Recieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recieve.Location = new System.Drawing.Point(73, 438);
            this.Recieve.Name = "Recieve";
            this.Recieve.Size = new System.Drawing.Size(70, 30);
            this.Recieve.TabIndex = 41;
            this.Recieve.Text = "Receive";
            this.Recieve.UseVisualStyleBackColor = true;
            this.Recieve.Click += new System.EventHandler(this.Recieve_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 438);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 30);
            this.button7.TabIndex = 40;
            this.button7.Text = "Send";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.SetColumnSpan(this.textBox2, 3);
            this.textBox2.Location = new System.Drawing.Point(3, 412);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "Send Here";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(167, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 35);
            this.button6.TabIndex = 38;
            this.button6.Text = "Close Serial Port";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(167, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 35);
            this.button5.TabIndex = 37;
            this.button5.Text = "Initialise Serial Port";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "COM port";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "9600",
            "115200"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(73, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 21);
            this.comboBox2.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // serialLogText
            // 
            this.serialLogText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.SetColumnSpan(this.serialLogText, 3);
            this.serialLogText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialLogText.Location = new System.Drawing.Point(3, 112);
            this.serialLogText.Multiline = true;
            this.serialLogText.Name = "serialLogText";
            this.serialLogText.ReadOnly = true;
            this.serialLogText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serialLogText.Size = new System.Drawing.Size(222, 294);
            this.serialLogText.TabIndex = 32;
            this.serialLogText.Text = "Receive here";
            // 
            // btnStart360Rec
            // 
            this.btnStart360Rec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart360Rec.BackColor = System.Drawing.Color.MistyRose;
            this.btnStart360Rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart360Rec.Location = new System.Drawing.Point(0, 0);
            this.btnStart360Rec.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart360Rec.Name = "btnStart360Rec";
            this.btnStart360Rec.Size = new System.Drawing.Size(154, 47);
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 516);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel3, 2, 5);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.comboBox3, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.Recieve, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.button7, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.comboBox2, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.textBox2, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.serialLogText, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(705, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(228, 510);
            this.tableLayoutPanel8.TabIndex = 49;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBar1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(164, 435);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(64, 75);
            this.tableLayoutPanel3.TabIndex = 50;
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
            this.tableLayoutPanel2.Controls.Add(this.tabDisplayChoice, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCurrentPosition, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRotateCCW, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnReturnBoomHome, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRotateCW, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnStart360Rec, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 510);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // tabDisplayChoice
            // 
            this.tabDisplayChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.tabDisplayChoice, 3);
            this.tabDisplayChoice.Controls.Add(this.tabLocation);
            this.tabDisplayChoice.Controls.Add(this.tabFrequency);
            this.tabDisplayChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplayChoice.Location = new System.Drawing.Point(3, 106);
            this.tabDisplayChoice.Name = "tabDisplayChoice";
            this.tabDisplayChoice.SelectedIndex = 0;
            this.tabDisplayChoice.Size = new System.Drawing.Size(456, 401);
            this.tabDisplayChoice.TabIndex = 18;
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.chartLocation);
            this.tabLocation.Location = new System.Drawing.Point(4, 29);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocation.Size = new System.Drawing.Size(448, 368);
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
            chartArea5.Name = "ChartArea1";
            this.chartLocation.ChartAreas.Add(chartArea5);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartLocation.Legends.Add(legend3);
            this.chartLocation.Location = new System.Drawing.Point(6, 6);
            this.chartLocation.Name = "chartLocation";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.Blue;
            series5.MarkerBorderWidth = 2;
            series5.MarkerSize = 15;
            series5.MarkerStep = 2;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Location";
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartLocation.Series.Add(series5);
            this.chartLocation.Size = new System.Drawing.Size(436, 356);
            this.chartLocation.TabIndex = 18;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Location";
            title5.Text = "Location";
            this.chartLocation.Titles.Add(title5);
            // 
            // tabFrequency
            // 
            this.tabFrequency.Controls.Add(this.chartFrequency);
            this.tabFrequency.Location = new System.Drawing.Point(4, 29);
            this.tabFrequency.Name = "tabFrequency";
            this.tabFrequency.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrequency.Size = new System.Drawing.Size(448, 368);
            this.tabFrequency.TabIndex = 1;
            this.tabFrequency.Text = "Frequency";
            this.tabFrequency.UseVisualStyleBackColor = true;
            // 
            // chartFrequency
            // 
            this.chartFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chartFrequency.ChartAreas.Add(chartArea6);
            this.chartFrequency.Location = new System.Drawing.Point(6, 6);
            this.chartFrequency.Name = "chartFrequency";
            this.chartFrequency.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.Name = "Series1";
            this.chartFrequency.Series.Add(series6);
            this.chartFrequency.Size = new System.Drawing.Size(266, 350);
            this.chartFrequency.TabIndex = 0;
            this.chartFrequency.Text = "chartFrequency";
            title6.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title6.Name = "Frequency";
            title6.Text = "Frequency";
            this.chartFrequency.Titles.Add(title6);
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPosition.Location = new System.Drawing.Point(311, 0);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(148, 47);
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
            this.label1.Location = new System.Drawing.Point(157, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Position:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotateCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCCW.Location = new System.Drawing.Point(3, 50);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(148, 50);
            this.btnRotateCCW.TabIndex = 9;
            this.btnRotateCCW.Text = "Rotate CCW";
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.btnRotateCCW_Click);
            this.btnRotateCCW.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRotateCCW_MouseClick);
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotateCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateCW.Location = new System.Drawing.Point(157, 50);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(148, 50);
            this.btnRotateCW.TabIndex = 10;
            this.btnRotateCW.Text = "Rotate CW";
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.btnRotateCW_Click);
            this.btnRotateCW.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRotateCW_MouseClick);
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
            this.tableLayoutPanel6.Controls.Add(this.btnAudacityPlay, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacitySkipToEnd, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacity, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAudacitySkipToStart, 0, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(471, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(228, 510);
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
            this.btnAudacity.Size = new System.Drawing.Size(222, 50);
            this.btnAudacity.TabIndex = 20;
            this.btnAudacity.Text = "Start Audacity";
            this.btnAudacity.UseVisualStyleBackColor = true;
            this.btnAudacity.Click += new System.EventHandler(this.btnAudacity_Click);
            // 
            // serialLogUpdateTimer
            // 
            this.serialLogUpdateTimer.Interval = 1000;
            this.serialLogUpdateTimer.Tick += new System.EventHandler(this.serialLogUpdateTimer_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automated Spatial Audio Recorder - ASAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabDisplayChoice.ResumeLayout(false);
            this.tabLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLocation)).EndInit();
            this.tabFrequency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequency)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Recieve;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox serialLogText;
        private System.Windows.Forms.Button btnStart360Rec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.TabPage tabFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequency;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLocation;
        private System.Windows.Forms.TabControl tabDisplayChoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAudacity;
        private System.Windows.Forms.Timer serialLogUpdateTimer;
    }
}

