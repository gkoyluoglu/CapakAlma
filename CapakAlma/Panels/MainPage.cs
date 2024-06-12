using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeiRobotProject;
using TeiRobotProject.Common;

namespace CapakAlma.Panels
{
    public partial class MainPage : UserControl
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }


        private void cycleStartButton_Click(object sender, EventArgs e)
        {
            
            
        }


        private void robotHoldButton_Click(object sender, EventArgs e)
        {
            
            
        }


        private async void systemResetButton_Click(object sender, EventArgs e)
        {
            
            PLCHaberlesme.Instance.sendBitToPLC(1, 5, 0, true);
            
            await Task.Delay(20);
            PLCHaberlesme.Instance.sendBitToPLC(1, 5, 0, false);
        }
    }
}
