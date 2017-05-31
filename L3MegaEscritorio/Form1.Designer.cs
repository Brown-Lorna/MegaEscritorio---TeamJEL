namespace L3MegaEscritorio
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.quoteDateDisplay = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfDrawers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.prepareQuoteButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noticeInstructions = new System.Windows.Forms.Label();
            this.rushOrderPanel = new System.Windows.Forms.Panel();
            this.dayFourteen = new System.Windows.Forms.RadioButton();
            this.daySeven = new System.Windows.Forms.RadioButton();
            this.dayFive = new System.Windows.Forms.RadioButton();
            this.dayThree = new System.Windows.Forms.RadioButton();
            this.deskOptionsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            this.rushOrderPanel.SuspendLayout();
            this.deskOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quote Date";
            // 
            // quoteDateDisplay
            // 
            this.quoteDateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quoteDateDisplay.Location = new System.Drawing.Point(134, 41);
            this.quoteDateDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteDateDisplay.Name = "quoteDateDisplay";
            this.quoteDateDisplay.Size = new System.Drawing.Size(184, 22);
            this.quoteDateDisplay.TabIndex = 1;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(130, 94);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(454, 24);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Enter Your Desired Desktop Dimensions in Inches.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desk Width (max 100)";
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(225, 137);
            this.deskWidth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deskWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(93, 26);
            this.deskWidth.TabIndex = 1;
            this.deskWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desk Depth (max 50)";
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(225, 175);
            this.deskDepth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deskDepth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.deskDepth.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(93, 26);
            this.deskDepth.TabIndex = 2;
            this.deskDepth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Desk Options.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number of Drawers";
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfDrawers.FormattingEnabled = true;
            this.numberOfDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numberOfDrawers.Location = new System.Drawing.Point(179, 140);
            this.numberOfDrawers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(191, 30);
            this.numberOfDrawers.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Surface Material";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Cherry",
            "Walnut",
            "Ipe"});
            this.surfaceMaterial.Location = new System.Drawing.Point(179, 196);
            this.surfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(191, 30);
            this.surfaceMaterial.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Rush Order (in days)";
            // 
            // prepareQuoteButton
            // 
            this.prepareQuoteButton.AutoSize = true;
            this.prepareQuoteButton.Location = new System.Drawing.Point(247, 265);
            this.prepareQuoteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.prepareQuoteButton.Name = "prepareQuoteButton";
            this.prepareQuoteButton.Size = new System.Drawing.Size(123, 39);
            this.prepareQuoteButton.TabIndex = 6;
            this.prepareQuoteButton.Text = "Prepare Quote";
            this.prepareQuoteButton.UseVisualStyleBackColor = true;
            this.prepareQuoteButton.Click += new System.EventHandler(this.PrepareQuote_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 584);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(484, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "VIew Desk Quotes with the Selcted Surface Material.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 640);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Select the Surface Material to View";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(372, 637);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(180, 30);
            this.comboBox4.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(225, 693);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "View Selected Desk Qotes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Note: You must make a selection from each item.";
            // 
            // noticeInstructions
            // 
            this.noticeInstructions.AutoSize = true;
            this.noticeInstructions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeInstructions.ForeColor = System.Drawing.Color.Red;
            this.noticeInstructions.Location = new System.Drawing.Point(6, 65);
            this.noticeInstructions.Name = "noticeInstructions";
            this.noticeInstructions.Size = new System.Drawing.Size(0, 22);
            this.noticeInstructions.TabIndex = 20;
            // 
            // rushOrderPanel
            // 
            this.rushOrderPanel.Controls.Add(this.dayFourteen);
            this.rushOrderPanel.Controls.Add(this.daySeven);
            this.rushOrderPanel.Controls.Add(this.dayFive);
            this.rushOrderPanel.Controls.Add(this.dayThree);
            this.rushOrderPanel.Controls.Add(this.label9);
            this.rushOrderPanel.Location = new System.Drawing.Point(405, 74);
            this.rushOrderPanel.Name = "rushOrderPanel";
            this.rushOrderPanel.Size = new System.Drawing.Size(235, 160);
            this.rushOrderPanel.TabIndex = 5;
            // 
            // dayFourteen
            // 
            this.dayFourteen.AutoSize = true;
            this.dayFourteen.Location = new System.Drawing.Point(17, 123);
            this.dayFourteen.Name = "dayFourteen";
            this.dayFourteen.Size = new System.Drawing.Size(209, 26);
            this.dayFourteen.TabIndex = 3;
            this.dayFourteen.TabStop = true;
            this.dayFourteen.Text = "14 days (normal delivery)";
            this.dayFourteen.UseVisualStyleBackColor = true;
            this.dayFourteen.CheckedChanged += new System.EventHandler(this.DayFourteenChanged);
            // 
            // daySeven
            // 
            this.daySeven.AutoSize = true;
            this.daySeven.Location = new System.Drawing.Point(17, 95);
            this.daySeven.Name = "daySeven";
            this.daySeven.Size = new System.Drawing.Size(67, 26);
            this.daySeven.TabIndex = 2;
            this.daySeven.TabStop = true;
            this.daySeven.Text = "7days";
            this.daySeven.UseVisualStyleBackColor = true;
            this.daySeven.CheckedChanged += new System.EventHandler(this.DaySevenChanged);
            // 
            // dayFive
            // 
            this.dayFive.AutoSize = true;
            this.dayFive.Location = new System.Drawing.Point(17, 67);
            this.dayFive.Name = "dayFive";
            this.dayFive.Size = new System.Drawing.Size(72, 26);
            this.dayFive.TabIndex = 1;
            this.dayFive.TabStop = true;
            this.dayFive.Text = "5 days";
            this.dayFive.UseVisualStyleBackColor = true;
            this.dayFive.CheckedChanged += new System.EventHandler(this.DayFiveChanged);
            // 
            // dayThree
            // 
            this.dayThree.AutoSize = true;
            this.dayThree.Location = new System.Drawing.Point(17, 38);
            this.dayThree.Name = "dayThree";
            this.dayThree.Size = new System.Drawing.Size(72, 26);
            this.dayThree.TabIndex = 0;
            this.dayThree.TabStop = true;
            this.dayThree.Text = "3 days";
            this.dayThree.UseVisualStyleBackColor = true;
            this.dayThree.CheckedChanged += new System.EventHandler(this.DayThreeChanged);
            // 
            // deskOptionsGroupBox
            // 
            this.deskOptionsGroupBox.Controls.Add(this.noticeInstructions);
            this.deskOptionsGroupBox.Controls.Add(this.rushOrderPanel);
            this.deskOptionsGroupBox.Controls.Add(this.label8);
            this.deskOptionsGroupBox.Controls.Add(this.numberOfDrawers);
            this.deskOptionsGroupBox.Controls.Add(this.label7);
            this.deskOptionsGroupBox.Controls.Add(this.label2);
            this.deskOptionsGroupBox.Controls.Add(this.surfaceMaterial);
            this.deskOptionsGroupBox.Controls.Add(this.prepareQuoteButton);
            this.deskOptionsGroupBox.Controls.Add(this.label6);
            this.deskOptionsGroupBox.Location = new System.Drawing.Point(12, 223);
            this.deskOptionsGroupBox.Name = "deskOptionsGroupBox";
            this.deskOptionsGroupBox.Size = new System.Drawing.Size(659, 324);
            this.deskOptionsGroupBox.TabIndex = 22;
            this.deskOptionsGroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 774);
            this.Controls.Add(this.deskOptionsGroupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.quoteDateDisplay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            this.rushOrderPanel.ResumeLayout(false);
            this.rushOrderPanel.PerformLayout();
            this.deskOptionsGroupBox.ResumeLayout(false);
            this.deskOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quoteDateDisplay;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox numberOfDrawers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button prepareQuoteButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noticeInstructions;
        private System.Windows.Forms.Panel rushOrderPanel;
        private System.Windows.Forms.RadioButton dayFourteen;
        private System.Windows.Forms.RadioButton daySeven;
        private System.Windows.Forms.RadioButton dayFive;
        private System.Windows.Forms.RadioButton dayThree;
        private System.Windows.Forms.GroupBox deskOptionsGroupBox;
    }
}

