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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(416, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 1080);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cycleStartButton
            // 
            this.cycleStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cycleStartButton.Location = new System.Drawing.Point(3, 936);
            this.cycleStartButton.Name = "cycleStartButton";
            this.cycleStartButton.Size = new System.Drawing.Size(173, 41);
            this.cycleStartButton.TabIndex = 1;
            this.cycleStartButton.Text = "Cycle Start";
            this.cycleStartButton.UseVisualStyleBackColor = true;
            this.cycleStartButton.Click += new System.EventHandler(this.cycleStartButton_Click);
            // 
            // robotHoldButton
            // 
            this.robotHoldButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.robotHoldButton.Location = new System.Drawing.Point(3, 983);
            this.robotHoldButton.Name = "robotHoldButton";
            this.robotHoldButton.Size = new System.Drawing.Size(173, 41);
            this.robotHoldButton.TabIndex = 2;
            this.robotHoldButton.Text = "Hold";
            this.robotHoldButton.UseVisualStyleBackColor = true;
            this.robotHoldButton.Click += new System.EventHandler(this.robotHoldButton_Click);
            // 
            // systemResetButton
            // 
            this.systemResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.systemResetButton.Location = new System.Drawing.Point(3, 1030);
            this.systemResetButton.Name = "systemResetButton";
            this.systemResetButton.Size = new System.Drawing.Size(173, 38);
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
            this.grouper.Size = new System.Drawing.Size(407, 307);
            this.grouper.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1673, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1673, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load Files";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Size = new System.Drawing.Size(1918, 1078);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }


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