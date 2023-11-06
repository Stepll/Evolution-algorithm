namespace Gen1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.runStopTickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iterationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.skipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticksToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticksToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toIterationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.longestLive = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ticker
            // 
            this.Ticker.Interval = 150;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runStopTickerToolStripMenuItem,
            this.iterationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ticksToolStripMenuItem,
            this.toolStripMenuItem2,
            this.liveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.skipToolStripMenuItem,
            this.toIterationToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1604, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menu";
            // 
            // runStopTickerToolStripMenuItem
            // 
            this.runStopTickerToolStripMenuItem.Name = "runStopTickerToolStripMenuItem";
            this.runStopTickerToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.runStopTickerToolStripMenuItem.Text = "Run / Stop Ticker";
            this.runStopTickerToolStripMenuItem.Click += new System.EventHandler(this.runStopTickerToolStripMenuItem_Click);
            // 
            // iterationToolStripMenuItem
            // 
            this.iterationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genMapToolStripMenuItem});
            this.iterationToolStripMenuItem.Name = "iterationToolStripMenuItem";
            this.iterationToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.iterationToolStripMenuItem.Text = "Iteration";
            // 
            // genMapToolStripMenuItem
            // 
            this.genMapToolStripMenuItem.Name = "genMapToolStripMenuItem";
            this.genMapToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.genMapToolStripMenuItem.Text = "genMap()";
            this.genMapToolStripMenuItem.Click += new System.EventHandler(this.genMapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem1.Text = "0";
            // 
            // ticksToolStripMenuItem
            // 
            this.ticksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.ticksToolStripMenuItem.Name = "ticksToolStripMenuItem";
            this.ticksToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ticksToolStripMenuItem.Text = "Ticks";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem4.Text = "+ 100";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem5.Text = "+ 1000";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem6.Text = "- 100";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem7.Text = "- 1000";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem2.Text = "0";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.liveToolStripMenuItem.Text = "Live Bots";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(31, 20);
            this.toolStripMenuItem3.Text = "64";
            // 
            // skipToolStripMenuItem
            // 
            this.skipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticksToolStripMenuItem1,
            this.ticksToolStripMenuItem2,
            this.ticksToolStripMenuItem3});
            this.skipToolStripMenuItem.Name = "skipToolStripMenuItem";
            this.skipToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.skipToolStripMenuItem.Text = "Skip";
            // 
            // ticksToolStripMenuItem1
            // 
            this.ticksToolStripMenuItem1.Name = "ticksToolStripMenuItem1";
            this.ticksToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.ticksToolStripMenuItem1.Text = "100 ticks";
            this.ticksToolStripMenuItem1.Click += new System.EventHandler(this.ticksToolStripMenuItem1_Click);
            // 
            // ticksToolStripMenuItem2
            // 
            this.ticksToolStripMenuItem2.Name = "ticksToolStripMenuItem2";
            this.ticksToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.ticksToolStripMenuItem2.Text = "1000 ticks";
            this.ticksToolStripMenuItem2.Click += new System.EventHandler(this.ticksToolStripMenuItem2_Click);
            // 
            // ticksToolStripMenuItem3
            // 
            this.ticksToolStripMenuItem3.Name = "ticksToolStripMenuItem3";
            this.ticksToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.ticksToolStripMenuItem3.Text = "10000 ticks";
            this.ticksToolStripMenuItem3.Click += new System.EventHandler(this.ticksToolStripMenuItem3_Click);
            // 
            // toIterationToolStripMenuItem
            // 
            this.toIterationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19});
            this.toIterationToolStripMenuItem.Name = "toIterationToolStripMenuItem";
            this.toIterationToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.toIterationToolStripMenuItem.Text = "To Iteration";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem9.Text = "10";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem10.Text = "50";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem11.Text = "100";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem12.Text = "200";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem13.Text = "500";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem14.Text = "1000";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem15.Text = "2000";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem16.Text = "3000";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem17.Text = "4000";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem17_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem18.Text = "5000";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem19.Text = "10000";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem19_Click);
            // 
            // longestLive
            // 
            this.longestLive.FormattingEnabled = true;
            this.longestLive.ItemHeight = 15;
            this.longestLive.Location = new System.Drawing.Point(1532, 27);
            this.longestLive.Name = "longestLive";
            this.longestLive.Size = new System.Drawing.Size(72, 274);
            this.longestLive.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Tick Iteration";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 699);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 726);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wait to time live";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 744);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 23);
            this.textBox2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 744);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Wait";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 707);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "3000";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Spaw Food Per Tick";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 700);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 23);
            this.textBox3.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 700);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 726);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Spawn Poison Per Tick";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 745);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 23);
            this.textBox4.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 744);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(166, 774);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Can Food Spawn In Poison";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 707);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 748);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1259, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "HP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1303, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1259, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Energy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1303, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1259, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(224, 23);
            this.textBox5.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 698);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "New Iteration";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 681);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Wait to live bots count";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(549, 699);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(62, 23);
            this.textBox6.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(617, 700);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Wait";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 845);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longestLive);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Ticker;
        private MenuStrip menuStrip;
        private ToolStripMenuItem runStopTickerToolStripMenuItem;
        private ToolStripMenuItem iterationToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ticksToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem genMapToolStripMenuItem;
        private ToolStripMenuItem liveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem skipToolStripMenuItem;
        private ToolStripMenuItem ticksToolStripMenuItem1;
        private ToolStripMenuItem ticksToolStripMenuItem2;
        private ToolStripMenuItem ticksToolStripMenuItem3;
        private ToolStripMenuItem toIterationToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ListBox longestLive;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem19;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
        private Label label6;
        private TextBox textBox4;
        private Button button4;
        private CheckBox checkBox1;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private Button button5;
        private Label label12;
        private TextBox textBox6;
        private Button button6;
    }
}