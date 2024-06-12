using System.Windows.Forms;
using CapakAlma.Common;

namespace CapakAlma.Panels
{
    public partial class RackSlotPanel : UserControl
    {
        public int RackNo { get; set; }

        private Tool _tool;

        public RackSlotPanel()
        {
            InitializeComponent();
            this._tool = new Tool();
        }

        private void ToolChanged()
        {
            
        }

        internal Tool getTool()
        {

            return _tool;
        }
        
        internal void setTool(Tool tool)
        {
            
            this._tool = tool;
            ToolChanged();
        }
    }
}