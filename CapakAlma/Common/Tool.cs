using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiRobotProject.Common
{
    [Serializable]
    internal class Tool
    {
        
        public String Name { get; set; }
    
        public int Id { get; set; }
        
        public System.Drawing.Image Picture { get; set; }
        
        public int Rpm { get; set; }
        
        
    }
}
