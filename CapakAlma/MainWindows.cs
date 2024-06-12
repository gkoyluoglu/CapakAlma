using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapakAlma
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainPageButton_Paint(object sender, PaintEventArgs e)
        {
            
            Button btn = (Button)sender;

            paintBorder(btn , e);
        }

        private void defineToolPageButton_Paint(object sender, PaintEventArgs e)
        {
             
            Button btn = (Button)sender;
            
            paintBorder(btn , e);
        }

        private void paintBorder(Button btn, PaintEventArgs e)
        {
            
            ControlPaint.DrawBorder(e.Graphics, btn.ClientRectangle,
                btn.BackColor, 5, ButtonBorderStyle.Solid,
                btn.BackColor, 5, ButtonBorderStyle.Solid,
                btn.BackColor, 5, ButtonBorderStyle.Solid,
                btn.BackColor, 5, ButtonBorderStyle.Solid
            );
        }


        private void defineToolPageButton_Click(object sender, EventArgs e)
        {

            this.customTabControl1.SelectedIndex = 1;
        }


        private void mainPageButton_Click(object sender, EventArgs e)
        {
            
            this.customTabControl1.SelectedIndex = 0;
        }
    }
}