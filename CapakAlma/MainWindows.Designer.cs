using CapakAlma.CostumComponents;

namespace CapakAlma
{
    partial class MainWindows
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
            this.customTabControl1 = new CapakAlma.CostumComponents.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainPage1 = new CapakAlma.Panels.MainPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.defineToolPageButton = new System.Windows.Forms.Button();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customTabControl1
            // 
            this.customTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.customTabControl1.Controls.Add(this.tabPage1);
            this.customTabControl1.Controls.Add(this.tabPage2);
            this.customTabControl1.Location = new System.Drawing.Point(0, 37);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(1904, 1004);
            this.customTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mainPage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1896, 978);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainPage1
            // 
            this.mainPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage1.Location = new System.Drawing.Point(3, 3);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(1890, 972);
            this.mainPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1896, 978);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.defineToolPageButton);
            this.panel2.Controls.Add(this.mainPageButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 42);
            this.panel2.TabIndex = 1;
            // 
            // defineToolPageButton
            // 
            this.defineToolPageButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.defineToolPageButton.Location = new System.Drawing.Point(149, 0);
            this.defineToolPageButton.Name = "defineToolPageButton";
            this.defineToolPageButton.Size = new System.Drawing.Size(109, 42);
            this.defineToolPageButton.TabIndex = 2;
            this.defineToolPageButton.Text = "Define Tool Page";
            this.defineToolPageButton.UseVisualStyleBackColor = false;
            this.defineToolPageButton.Click += new System.EventHandler(this.defineToolPageButton_Click);
            // 
            // mainPageButton
            // 
            this.mainPageButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mainPageButton.Location = new System.Drawing.Point(22, 0);
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.Size = new System.Drawing.Size(109, 42);
            this.mainPageButton.TabIndex = 1;
            this.mainPageButton.Text = "Main Page";
            this.mainPageButton.UseVisualStyleBackColor = false;
            this.mainPageButton.Click += new System.EventHandler(this.mainPageButton_Click);
            this.mainPageButton.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPageButton_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.customTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 1041);
            this.panel1.TabIndex = 0;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainWindows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindows_FormClosing);
            this.customTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private CapakAlma.Panels.MainPage mainPage1;

        private System.Windows.Forms.Button defineToolPageButton;

        private System.Windows.Forms.Button mainPageButton;

        private System.Windows.Forms.Panel panel2;

        private CapakAlma.CostumComponents.CustomTabControl customTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}