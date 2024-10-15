namespace MacroSim
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            connectedToSimLabel = new ToolStripStatusLabel();
            connectedToMacroPadLabel = new ToolStripStatusLabel();
            stateLabel = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            altitude = new SevenSegmentDisplay();
            com1standby = new SevenSegmentDisplay();
            lblCom1Standby = new Label();
            lblCom1Active = new Label();
            com1active = new SevenSegmentDisplay();
            lblCom2Standby = new Label();
            lblCom2Active = new Label();
            com2standby = new SevenSegmentDisplay();
            com2active = new SevenSegmentDisplay();
            nav1standby = new SevenSegmentDisplay();
            nav1active = new SevenSegmentDisplay();
            nav2standby = new SevenSegmentDisplay();
            nav2active = new SevenSegmentDisplay();
            lblNav1Standby = new Label();
            lblNav1Active = new Label();
            lblNav2Standby = new Label();
            lblNav2Active = new Label();
            lblHeading = new Label();
            lblCourse = new Label();
            heading = new SevenSegmentDisplay();
            course = new SevenSegmentDisplay();
            lblAltitude = new Label();
            lblVerticalSpeed = new Label();
            verticalspeed = new SevenSegmentDisplay();
            txtOutput = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblHdgHold = new Label();
            lblVSHold = new Label();
            lblAPMaster = new Label();
            lblAltHold = new Label();
            menuStrip1 = new MenuStrip();
            appToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            macroPadToolStripMenuItem = new ToolStripMenuItem();
            baud9600ToolStripMenuItem = new ToolStripMenuItem();
            baud115200ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            altitudeToolStripMenuItem = new ToolStripMenuItem();
            altitudeIncrease1000ToolStripMenuItem = new ToolStripMenuItem();
            altitudeDecrease1000ToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel1);
            toolStripContainer1.ContentPanel.Size = new Size(745, 574);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(745, 622);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { connectedToSimLabel, connectedToMacroPadLabel, stateLabel });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(745, 24);
            statusStrip1.TabIndex = 0;
            // 
            // connectedToSimLabel
            // 
            connectedToSimLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            connectedToSimLabel.Name = "connectedToSimLabel";
            connectedToSimLabel.Size = new Size(126, 19);
            connectedToSimLabel.Text = "Not connected to sim";
            // 
            // connectedToMacroPadLabel
            // 
            connectedToMacroPadLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            connectedToMacroPadLabel.Name = "connectedToMacroPadLabel";
            connectedToMacroPadLabel.Size = new Size(161, 19);
            connectedToMacroPadLabel.Text = "Not connected to MacroPad";
            // 
            // stateLabel
            // 
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(36, 19);
            stateLabel.Text = "None";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(altitude, 0, 12);
            tableLayoutPanel1.Controls.Add(com1standby, 0, 2);
            tableLayoutPanel1.Controls.Add(lblCom1Standby, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCom1Active, 1, 1);
            tableLayoutPanel1.Controls.Add(com1active, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCom2Standby, 0, 3);
            tableLayoutPanel1.Controls.Add(lblCom2Active, 1, 3);
            tableLayoutPanel1.Controls.Add(com2standby, 0, 4);
            tableLayoutPanel1.Controls.Add(com2active, 1, 4);
            tableLayoutPanel1.Controls.Add(nav1standby, 0, 6);
            tableLayoutPanel1.Controls.Add(nav1active, 1, 6);
            tableLayoutPanel1.Controls.Add(nav2standby, 0, 8);
            tableLayoutPanel1.Controls.Add(nav2active, 1, 8);
            tableLayoutPanel1.Controls.Add(lblNav1Standby, 0, 5);
            tableLayoutPanel1.Controls.Add(lblNav1Active, 1, 5);
            tableLayoutPanel1.Controls.Add(lblNav2Standby, 0, 7);
            tableLayoutPanel1.Controls.Add(lblNav2Active, 1, 7);
            tableLayoutPanel1.Controls.Add(lblHeading, 0, 9);
            tableLayoutPanel1.Controls.Add(lblCourse, 1, 9);
            tableLayoutPanel1.Controls.Add(heading, 0, 10);
            tableLayoutPanel1.Controls.Add(course, 1, 10);
            tableLayoutPanel1.Controls.Add(lblAltitude, 0, 11);
            tableLayoutPanel1.Controls.Add(lblVerticalSpeed, 1, 11);
            tableLayoutPanel1.Controls.Add(verticalspeed, 1, 12);
            tableLayoutPanel1.Controls.Add(txtOutput, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.53F));
            tableLayoutPanel1.Size = new Size(745, 574);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // altitude
            // 
            altitude.Anchor = AnchorStyles.None;
            altitude.BackColor = Color.Black;
            altitude.FontColor = Color.Red;
            altitude.FractDigits = 0;
            altitude.LeftMargin = 0;
            altitude.Location = new Point(25, 517);
            altitude.Margin = new Padding(0);
            altitude.Name = "altitude";
            altitude.RightMargin = 0;
            altitude.Selection = FrequencySelection.None;
            altitude.SelectionColor = Color.Yellow;
            altitude.Size = new Size(170, 50);
            altitude.TabIndex = 23;
            altitude.TopMargin = 5;
            altitude.Value = new decimal(new int[] { 321, 0, 0, 0 });
            altitude.WholeDigits = 5;
            // 
            // com1standby
            // 
            com1standby.Anchor = AnchorStyles.None;
            com1standby.BackColor = Color.Black;
            com1standby.FontColor = Color.Red;
            com1standby.LeftMargin = 0;
            com1standby.Location = new Point(25, 65);
            com1standby.Margin = new Padding(0);
            com1standby.Name = "com1standby";
            com1standby.RightMargin = 0;
            com1standby.Selection = FrequencySelection.None;
            com1standby.SelectionColor = Color.Yellow;
            com1standby.Size = new Size(170, 50);
            com1standby.TabIndex = 0;
            com1standby.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblCom1Standby
            // 
            lblCom1Standby.Anchor = AnchorStyles.None;
            lblCom1Standby.AutoSize = true;
            lblCom1Standby.Font = new Font("Segoe UI", 11.25F);
            lblCom1Standby.Location = new Point(56, 35);
            lblCom1Standby.Name = "lblCom1Standby";
            lblCom1Standby.Size = new Size(108, 20);
            lblCom1Standby.TabIndex = 1;
            lblCom1Standby.Text = "COM1 Standby";
            // 
            // lblCom1Active
            // 
            lblCom1Active.Anchor = AnchorStyles.None;
            lblCom1Active.AutoSize = true;
            lblCom1Active.Font = new Font("Segoe UI", 11.25F);
            lblCom1Active.Location = new Point(282, 35);
            lblCom1Active.Name = "lblCom1Active";
            lblCom1Active.Size = new Size(95, 20);
            lblCom1Active.TabIndex = 2;
            lblCom1Active.Text = "COM1 Active";
            // 
            // com1active
            // 
            com1active.Anchor = AnchorStyles.None;
            com1active.BackColor = Color.Black;
            com1active.FontColor = Color.Red;
            com1active.LeftMargin = 0;
            com1active.Location = new Point(245, 65);
            com1active.Margin = new Padding(0);
            com1active.Name = "com1active";
            com1active.RightMargin = 0;
            com1active.Selection = FrequencySelection.None;
            com1active.SelectionColor = Color.Yellow;
            com1active.Size = new Size(170, 50);
            com1active.TabIndex = 3;
            com1active.Value = new decimal(new int[] { 134225, 0, 0, 196608 });
            // 
            // lblCom2Standby
            // 
            lblCom2Standby.Anchor = AnchorStyles.None;
            lblCom2Standby.AutoSize = true;
            lblCom2Standby.Font = new Font("Segoe UI", 11.25F);
            lblCom2Standby.Location = new Point(56, 125);
            lblCom2Standby.Name = "lblCom2Standby";
            lblCom2Standby.Size = new Size(108, 20);
            lblCom2Standby.TabIndex = 4;
            lblCom2Standby.Text = "COM2 Standby";
            // 
            // lblCom2Active
            // 
            lblCom2Active.Anchor = AnchorStyles.None;
            lblCom2Active.AutoSize = true;
            lblCom2Active.Font = new Font("Segoe UI", 11.25F);
            lblCom2Active.Location = new Point(282, 125);
            lblCom2Active.Name = "lblCom2Active";
            lblCom2Active.Size = new Size(95, 20);
            lblCom2Active.TabIndex = 5;
            lblCom2Active.Text = "COM2 Active";
            // 
            // com2standby
            // 
            com2standby.Anchor = AnchorStyles.None;
            com2standby.BackColor = Color.Black;
            com2standby.FontColor = Color.Red;
            com2standby.LeftMargin = 0;
            com2standby.Location = new Point(25, 155);
            com2standby.Margin = new Padding(0);
            com2standby.Name = "com2standby";
            com2standby.RightMargin = 0;
            com2standby.Selection = FrequencySelection.None;
            com2standby.SelectionColor = Color.Yellow;
            com2standby.Size = new Size(170, 50);
            com2standby.TabIndex = 6;
            com2standby.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // com2active
            // 
            com2active.Anchor = AnchorStyles.None;
            com2active.BackColor = Color.Black;
            com2active.FontColor = Color.Red;
            com2active.LeftMargin = 0;
            com2active.Location = new Point(245, 155);
            com2active.Margin = new Padding(0);
            com2active.Name = "com2active";
            com2active.RightMargin = 0;
            com2active.Selection = FrequencySelection.None;
            com2active.SelectionColor = Color.Yellow;
            com2active.Size = new Size(170, 50);
            com2active.TabIndex = 7;
            com2active.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nav1standby
            // 
            nav1standby.Anchor = AnchorStyles.None;
            nav1standby.BackColor = Color.Black;
            nav1standby.FontColor = Color.Red;
            nav1standby.FractDigits = 2;
            nav1standby.LeftMargin = 0;
            nav1standby.Location = new Point(25, 245);
            nav1standby.Margin = new Padding(0);
            nav1standby.Name = "nav1standby";
            nav1standby.RightMargin = 0;
            nav1standby.Selection = FrequencySelection.None;
            nav1standby.SelectionColor = Color.Yellow;
            nav1standby.Size = new Size(170, 50);
            nav1standby.TabIndex = 8;
            nav1standby.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nav1active
            // 
            nav1active.Anchor = AnchorStyles.None;
            nav1active.BackColor = Color.Black;
            nav1active.FontColor = Color.Red;
            nav1active.FractDigits = 2;
            nav1active.LeftMargin = 0;
            nav1active.Location = new Point(245, 245);
            nav1active.Margin = new Padding(0);
            nav1active.Name = "nav1active";
            nav1active.RightMargin = 0;
            nav1active.Selection = FrequencySelection.None;
            nav1active.SelectionColor = Color.Yellow;
            nav1active.Size = new Size(170, 50);
            nav1active.TabIndex = 9;
            nav1active.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nav2standby
            // 
            nav2standby.Anchor = AnchorStyles.None;
            nav2standby.BackColor = Color.Black;
            nav2standby.FontColor = Color.Red;
            nav2standby.FractDigits = 2;
            nav2standby.LeftMargin = 0;
            nav2standby.Location = new Point(25, 335);
            nav2standby.Margin = new Padding(0);
            nav2standby.Name = "nav2standby";
            nav2standby.RightMargin = 0;
            nav2standby.Selection = FrequencySelection.None;
            nav2standby.SelectionColor = Color.Yellow;
            nav2standby.Size = new Size(170, 50);
            nav2standby.TabIndex = 10;
            nav2standby.Value = new decimal(new int[] { 321, 0, 0, 0 });
            // 
            // nav2active
            // 
            nav2active.Anchor = AnchorStyles.None;
            nav2active.BackColor = Color.Black;
            nav2active.FontColor = Color.Red;
            nav2active.FractDigits = 2;
            nav2active.LeftMargin = 0;
            nav2active.Location = new Point(245, 335);
            nav2active.Margin = new Padding(0);
            nav2active.Name = "nav2active";
            nav2active.RightMargin = 0;
            nav2active.Selection = FrequencySelection.None;
            nav2active.SelectionColor = Color.Yellow;
            nav2active.Size = new Size(170, 50);
            nav2active.TabIndex = 11;
            nav2active.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblNav1Standby
            // 
            lblNav1Standby.Anchor = AnchorStyles.None;
            lblNav1Standby.AutoSize = true;
            lblNav1Standby.Font = new Font("Segoe UI", 11.25F);
            lblNav1Standby.Location = new Point(58, 215);
            lblNav1Standby.Name = "lblNav1Standby";
            lblNav1Standby.Size = new Size(104, 20);
            lblNav1Standby.TabIndex = 12;
            lblNav1Standby.Text = "NAV1 Standby";
            // 
            // lblNav1Active
            // 
            lblNav1Active.Anchor = AnchorStyles.None;
            lblNav1Active.AutoSize = true;
            lblNav1Active.Font = new Font("Segoe UI", 11.25F);
            lblNav1Active.Location = new Point(284, 215);
            lblNav1Active.Name = "lblNav1Active";
            lblNav1Active.Size = new Size(91, 20);
            lblNav1Active.TabIndex = 13;
            lblNav1Active.Text = "NAV1 Active";
            // 
            // lblNav2Standby
            // 
            lblNav2Standby.Anchor = AnchorStyles.None;
            lblNav2Standby.AutoSize = true;
            lblNav2Standby.Font = new Font("Segoe UI", 11.25F);
            lblNav2Standby.Location = new Point(58, 305);
            lblNav2Standby.Name = "lblNav2Standby";
            lblNav2Standby.Size = new Size(104, 20);
            lblNav2Standby.TabIndex = 14;
            lblNav2Standby.Text = "NAV2 Standby";
            // 
            // lblNav2Active
            // 
            lblNav2Active.Anchor = AnchorStyles.None;
            lblNav2Active.AutoSize = true;
            lblNav2Active.Font = new Font("Segoe UI", 11.25F);
            lblNav2Active.Location = new Point(284, 305);
            lblNav2Active.Name = "lblNav2Active";
            lblNav2Active.Size = new Size(91, 20);
            lblNav2Active.TabIndex = 15;
            lblNav2Active.Text = "NAV2 Active";
            // 
            // lblHeading
            // 
            lblHeading.Anchor = AnchorStyles.None;
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 11.25F);
            lblHeading.Location = new Point(77, 395);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(66, 20);
            lblHeading.TabIndex = 16;
            lblHeading.Text = "Heading";
            // 
            // lblCourse
            // 
            lblCourse.Anchor = AnchorStyles.None;
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 11.25F);
            lblCourse.Location = new Point(303, 395);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(54, 20);
            lblCourse.TabIndex = 17;
            lblCourse.Text = "Course";
            // 
            // heading
            // 
            heading.Anchor = AnchorStyles.None;
            heading.BackColor = Color.Black;
            heading.FontColor = Color.Red;
            heading.FractDigits = 0;
            heading.LeftMargin = 0;
            heading.Location = new Point(25, 425);
            heading.Margin = new Padding(0);
            heading.Name = "heading";
            heading.RightMargin = 0;
            heading.Selection = FrequencySelection.None;
            heading.SelectionColor = Color.Yellow;
            heading.Size = new Size(170, 50);
            heading.TabIndex = 18;
            heading.TopMargin = 5;
            heading.Value = new decimal(new int[] { 321, 0, 0, 0 });
            // 
            // course
            // 
            course.Anchor = AnchorStyles.None;
            course.BackColor = Color.Black;
            course.FontColor = Color.Red;
            course.FractDigits = 0;
            course.LeftMargin = 0;
            course.Location = new Point(245, 425);
            course.Margin = new Padding(0);
            course.Name = "course";
            course.RightMargin = 0;
            course.Selection = FrequencySelection.None;
            course.SelectionColor = Color.Yellow;
            course.Size = new Size(170, 50);
            course.TabIndex = 19;
            course.TopMargin = 5;
            course.Value = new decimal(new int[] { 321, 0, 0, 0 });
            // 
            // lblAltitude
            // 
            lblAltitude.Anchor = AnchorStyles.None;
            lblAltitude.AutoSize = true;
            lblAltitude.Font = new Font("Segoe UI", 11.25F);
            lblAltitude.Location = new Point(79, 485);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new Size(62, 20);
            lblAltitude.TabIndex = 20;
            lblAltitude.Text = "Altitude";
            // 
            // lblVerticalSpeed
            // 
            lblVerticalSpeed.Anchor = AnchorStyles.None;
            lblVerticalSpeed.AutoSize = true;
            lblVerticalSpeed.Font = new Font("Segoe UI", 11.25F);
            lblVerticalSpeed.Location = new Point(278, 485);
            lblVerticalSpeed.Name = "lblVerticalSpeed";
            lblVerticalSpeed.Size = new Size(104, 20);
            lblVerticalSpeed.TabIndex = 21;
            lblVerticalSpeed.Text = "Vertical Speed";
            // 
            // verticalspeed
            // 
            verticalspeed.Anchor = AnchorStyles.None;
            verticalspeed.BackColor = Color.Black;
            verticalspeed.CanBeNegative = true;
            verticalspeed.FontColor = Color.Red;
            verticalspeed.FractDigits = 0;
            verticalspeed.LeftMargin = 0;
            verticalspeed.Location = new Point(245, 517);
            verticalspeed.Margin = new Padding(0);
            verticalspeed.Name = "verticalspeed";
            verticalspeed.RightMargin = 0;
            verticalspeed.Selection = FrequencySelection.None;
            verticalspeed.SelectionColor = Color.Yellow;
            verticalspeed.Size = new Size(170, 50);
            verticalspeed.TabIndex = 22;
            verticalspeed.TopMargin = 5;
            verticalspeed.Value = new decimal(new int[] { 321, 0, 0, 0 });
            verticalspeed.WholeDigits = 4;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(443, 33);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(txtOutput, 12);
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(290, 489);
            txtOutput.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.Black;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(lblHdgHold, 3, 0);
            tableLayoutPanel2.Controls.Add(lblVSHold, 2, 0);
            tableLayoutPanel2.Controls.Add(lblAPMaster, 0, 0);
            tableLayoutPanel2.Controls.Add(lblAltHold, 1, 0);
            tableLayoutPanel2.Location = new Point(20, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(400, 24);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // lblHdgHold
            // 
            lblHdgHold.Anchor = AnchorStyles.None;
            lblHdgHold.AutoSize = true;
            lblHdgHold.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHdgHold.ForeColor = Color.Red;
            lblHdgHold.Location = new Point(328, 1);
            lblHdgHold.Name = "lblHdgHold";
            lblHdgHold.Size = new Size(43, 21);
            lblHdgHold.TabIndex = 3;
            lblHdgHold.Text = "HDG";
            // 
            // lblVSHold
            // 
            lblVSHold.Anchor = AnchorStyles.None;
            lblVSHold.AutoSize = true;
            lblVSHold.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVSHold.ForeColor = Color.Red;
            lblVSHold.Location = new Point(235, 1);
            lblVSHold.Name = "lblVSHold";
            lblVSHold.Size = new Size(29, 21);
            lblVSHold.TabIndex = 2;
            lblVSHold.Text = "VS";
            // 
            // lblAPMaster
            // 
            lblAPMaster.Anchor = AnchorStyles.None;
            lblAPMaster.AutoSize = true;
            lblAPMaster.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAPMaster.ForeColor = Color.Red;
            lblAPMaster.Location = new Point(35, 1);
            lblAPMaster.Name = "lblAPMaster";
            lblAPMaster.Size = new Size(29, 21);
            lblAPMaster.TabIndex = 0;
            lblAPMaster.Text = "AP";
            // 
            // lblAltHold
            // 
            lblAltHold.Anchor = AnchorStyles.None;
            lblAltHold.AutoSize = true;
            lblAltHold.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltHold.ForeColor = Color.Red;
            lblAltHold.Location = new Point(132, 1);
            lblAltHold.Name = "lblAltHold";
            lblAltHold.Size = new Size(35, 21);
            lblAltHold.TabIndex = 1;
            lblAltHold.Text = "ALT";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem, macroPadToolStripMenuItem, altitudeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(745, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(41, 20);
            appToolStripMenuItem.Text = "App";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(156, 22);
            connectToolStripMenuItem.Text = "Connect to Sim";
            connectToolStripMenuItem.Click += ConnectToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(156, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // macroPadToolStripMenuItem
            // 
            macroPadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { baud9600ToolStripMenuItem, baud115200ToolStripMenuItem, toolStripSeparator2 });
            macroPadToolStripMenuItem.Name = "macroPadToolStripMenuItem";
            macroPadToolStripMenuItem.Size = new Size(73, 20);
            macroPadToolStripMenuItem.Text = "MacroPad";
            // 
            // baud9600ToolStripMenuItem
            // 
            baud9600ToolStripMenuItem.Name = "baud9600ToolStripMenuItem";
            baud9600ToolStripMenuItem.Size = new Size(140, 22);
            baud9600ToolStripMenuItem.Tag = "9600";
            baud9600ToolStripMenuItem.Text = "9600 Baud";
            baud9600ToolStripMenuItem.Click += BaudRateMenuItem_Click;
            // 
            // baud115200ToolStripMenuItem
            // 
            baud115200ToolStripMenuItem.Checked = true;
            baud115200ToolStripMenuItem.CheckState = CheckState.Checked;
            baud115200ToolStripMenuItem.Name = "baud115200ToolStripMenuItem";
            baud115200ToolStripMenuItem.Size = new Size(140, 22);
            baud115200ToolStripMenuItem.Tag = "115200";
            baud115200ToolStripMenuItem.Text = "115200 Baud";
            baud115200ToolStripMenuItem.Click += BaudRateMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(137, 6);
            // 
            // altitudeToolStripMenuItem
            // 
            altitudeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altitudeIncrease1000ToolStripMenuItem, altitudeDecrease1000ToolStripMenuItem });
            altitudeToolStripMenuItem.Name = "altitudeToolStripMenuItem";
            altitudeToolStripMenuItem.Size = new Size(61, 20);
            altitudeToolStripMenuItem.Text = "Altitude";
            // 
            // altitudeIncrease1000ToolStripMenuItem
            // 
            altitudeIncrease1000ToolStripMenuItem.Name = "altitudeIncrease1000ToolStripMenuItem";
            altitudeIncrease1000ToolStripMenuItem.Size = new Size(193, 22);
            altitudeIncrease1000ToolStripMenuItem.Text = "Altitude Increase 1000";
            altitudeIncrease1000ToolStripMenuItem.Click += altitudeIncrease1000ToolStripMenuItem_Click;
            // 
            // altitudeDecrease1000ToolStripMenuItem
            // 
            altitudeDecrease1000ToolStripMenuItem.Name = "altitudeDecrease1000ToolStripMenuItem";
            altitudeDecrease1000ToolStripMenuItem.Size = new Size(193, 22);
            altitudeDecrease1000ToolStripMenuItem.Text = "Altitude Decrease 1000";
            altitudeDecrease1000ToolStripMenuItem.Click += altitudeDecrease1000ToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 622);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MacroSim";
            FormClosed += MainForm_FormClosed;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private SevenSegmentDisplay com1standby;
        private Label lblCom1Standby;
        private Label lblCom1Active;
        private SevenSegmentDisplay com1active;
        private Label lblCom2Standby;
        private Label lblCom2Active;
        private SevenSegmentDisplay com2standby;
        private SevenSegmentDisplay com2active;
        private SevenSegmentDisplay nav1standby;
        private SevenSegmentDisplay nav1active;
        private SevenSegmentDisplay nav2standby;
        private SevenSegmentDisplay nav2active;
        private Label lblNav1Standby;
        private Label lblNav1Active;
        private Label lblNav2Standby;
        private Label lblNav2Active;
        private Label lblHeading;
        private Label lblCourse;
        private SevenSegmentDisplay altitude;
        private SevenSegmentDisplay heading;
        private SevenSegmentDisplay course;
        private Label lblAltitude;
        private Label lblVerticalSpeed;
        private SevenSegmentDisplay verticalspeed;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel connectedToSimLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem macroPadToolStripMenuItem;
        private ToolStripMenuItem baud9600ToolStripMenuItem;
        private ToolStripMenuItem baud115200ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem altitudeToolStripMenuItem;
        private ToolStripMenuItem altitudeIncrease1000ToolStripMenuItem;
        private ToolStripMenuItem altitudeDecrease1000ToolStripMenuItem;
        private ToolStripStatusLabel connectedToMacroPadLabel;
        private ToolStripStatusLabel stateLabel;
        private TextBox txtOutput;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblAPMaster;
        private Label lblAltHold;
        private Label lblVSHold;
        private Label lblHdgHold;
    }
}