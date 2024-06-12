using System.ComponentModel;

namespace CapakAlma.Panels
{
    partial class MainPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cycleStartButton = new System.Windows.Forms.Button();
            this.robotHoldButton = new System.Windows.Forms.Button();
            this.systemResetButton = new System.Windows.Forms.Button();
            this.grouper = new CapakAlma.CostumComponents.Grouper();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.robotRunnigStatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oparationModeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Timers.Timer();
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grouper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CapakAlma.Properties.Resources.TEI_CAPAK_ALMA_2_Kamera_Kamera_4;
            this.pictureBox1.Location = new System.Drawing.Point(416, -107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1153, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cycleStartButton
            // 
            this.cycleStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cycleStartButton.Location = new System.Drawing.Point(60, 226);
            this.cycleStartButton.Name = "cycleStartButton";
            this.cycleStartButton.Size = new System.Drawing.Size(273, 81);
            this.cycleStartButton.TabIndex = 1;
            this.cycleStartButton.Text = "Cycle Start";
            this.cycleStartButton.UseVisualStyleBackColor = true;
            this.cycleStartButton.Click += new System.EventHandler(this.cycleStartButton_Click);
            // 
            // robotHoldButton
            // 
            this.robotHoldButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.robotHoldButton.Location = new System.Drawing.Point(60, 313);
            this.robotHoldButton.Name = "robotHoldButton";
            this.robotHoldButton.Size = new System.Drawing.Size(273, 81);
            this.robotHoldButton.TabIndex = 2;
            this.robotHoldButton.Text = "Hold";
            this.robotHoldButton.UseVisualStyleBackColor = true;
            this.robotHoldButton.Click += new System.EventHandler(this.robotHoldButton_Click);
            // 
            // systemResetButton
            // 
            this.systemResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.systemResetButton.Location = new System.Drawing.Point(60, 400);
            this.systemResetButton.Name = "systemResetButton";
            this.systemResetButton.Size = new System.Drawing.Size(273, 81);
            this.systemResetButton.TabIndex = 3;
            this.systemResetButton.Text = "System Reset";
            this.systemResetButton.UseVisualStyleBackColor = true;
            this.systemResetButton.Click += new System.EventHandler(this.systemResetButton_Click);
            // 
            // grouper
            // 
            this.grouper.BackgroundColor = System.Drawing.Color.Transparent;
            this.grouper.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper.BackgroundGradientMode = CapakAlma.CostumComponents.Grouper.GroupBoxGradientMode.Vertical;
            this.grouper.BorderColor = System.Drawing.Color.Black;
            this.grouper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grouper.BorderThickness = 3F;
            this.grouper.Controls.Add(this.label16);
            this.grouper.Controls.Add(this.label17);
            this.grouper.Controls.Add(this.label18);
            this.grouper.Controls.Add(this.label7);
            this.grouper.Controls.Add(this.label8);
            this.grouper.Controls.Add(this.robotRunnigStatusLabel);
            this.grouper.Controls.Add(this.label4);
            this.grouper.Controls.Add(this.label5);
            this.grouper.Controls.Add(this.programNameLabel);
            this.grouper.Controls.Add(this.label3);
            this.grouper.Controls.Add(this.label2);
            this.grouper.Controls.Add(this.oparationModeLabel);
            this.grouper.CustomGroupBoxColor = System.Drawing.Color.White;
            this.grouper.GroupImage = null;
            this.grouper.GroupTitle = "Robot Data";
            this.grouper.Location = new System.Drawing.Point(3, 3);
            this.grouper.Name = "grouper";
            this.grouper.Padding = new System.Windows.Forms.Padding(20);
            this.grouper.PaintGroupBox = true;
            this.grouper.RoundCorners = 10;
            this.grouper.ShadowColor = System.Drawing.Color.SeaShell;
            this.grouper.ShadowControl = true;
            this.grouper.ShadowThickness = 3;
            this.grouper.Size = new System.Drawing.Size(407, 194);
            this.grouper.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(182, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 23);
            this.label16.TabIndex = 11;
            this.label16.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.Location = new System.Drawing.Point(23, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 24);
            this.label17.TabIndex = 10;
            this.label17.Text = "Running Status";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label18.Location = new System.Drawing.Point(282, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 9;
            this.label18.Text = "label18";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(182, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(23, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enable Status";
            // 
            // robotRunnigStatusLabel
            // 
            this.robotRunnigStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.robotRunnigStatusLabel.Location = new System.Drawing.Point(282, 76);
            this.robotRunnigStatusLabel.Name = "robotRunnigStatusLabel";
            this.robotRunnigStatusLabel.Size = new System.Drawing.Size(100, 23);
            this.robotRunnigStatusLabel.TabIndex = 6;
            this.robotRunnigStatusLabel.Text = "label9";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(182, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(23, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Program";
            // 
            // programNameLabel
            // 
            this.programNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.programNameLabel.Location = new System.Drawing.Point(282, 111);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(100, 23);
            this.programNameLabel.TabIndex = 3;
            this.programNameLabel.Text = "label6";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(182, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oparation Mode";
            // 
            // oparationModeLabel
            // 
            this.oparationModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.oparationModeLabel.Location = new System.Drawing.Point(282, 43);
            this.oparationModeLabel.Name = "oparationModeLabel";
            this.oparationModeLabel.Size = new System.Drawing.Size(100, 23);
            this.oparationModeLabel.TabIndex = 0;
            this.oparationModeLabel.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1653, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1653, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 150D;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grouper);
            this.Controls.Add(this.systemResetButton);
            this.Controls.Add(this.robotHoldButton);
            this.Controls.Add(this.cycleStartButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1890, 972);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grouper.ResumeLayout(false);
            this.grouper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer2;

        private System.Windows.Forms.Label oparationModeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label robotRunnigStatusLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;

        private System.Timers.Timer timer1;


        private System.Windows.Forms.Button button1;


        private System.Windows.Forms.ComboBox comboBox1;


        private CapakAlma.CostumComponents.Grouper grouper;

        private System.Windows.Forms.Button cycleStartButton;

        private System.Windows.Forms.Button robotHoldButton;

        private System.Windows.Forms.Button systemResetButton;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}