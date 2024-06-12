using System.Collections.Generic;
using System.Windows.Forms;
using TeiRobotProject;

namespace CapakAlma.Panels
{
    public partial class MediaRack : UserControl
    {
   
        public MediaRack()
        {
            InitializeComponent();
            
            var colection = Model.Instance.ToolColection; 
            
            colection.Add(rackSlotPanel1);
            colection.Add(rackSlotPanel2);
            colection.Add(rackSlotPanel3);
            colection.Add(rackSlotPanel4);
            colection.Add(rackSlotPanel5);
            colection.Add(rackSlotPanel6);
            colection.Add(rackSlotPanel7);
            colection.Add(rackSlotPanel8);
            colection.Add(rackSlotPanel9);
            colection.Add(rackSlotPanel10);
            colection.Add(rackSlotPanel11);
            colection.Add(rackSlotPanel12);
            colection.Add(rackSlotPanel13);
            colection.Add(rackSlotPanel14);
            colection.Add(rackSlotPanel15);
            colection.Add(rackSlotPanel16);
            colection.Add(rackSlotPanel17);
        }
    }
}