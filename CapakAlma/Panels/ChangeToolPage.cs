using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CapakAlma.Panels
{
    public partial class ChangeToolPage : UserControl
    {
        private BindingList<MediaSelection> _mediaSelections;
        private BindingList<MediaSelection> _toolSelections;

        public ChangeToolPage()
        {
            InitializeComponent();
            
            _mediaSelections = new BindingList<MediaSelection>();
            _toolSelections = new BindingList<MediaSelection>();
            
            
        }
        
        

        struct MediaSelection
        {
            public List<Image> image;
            public string Name;
            public string RackIndex;
            
            
            public MediaSelection(string name, string rackIndex, List<Image> image1)
            {
                Name = name;
                RackIndex = rackIndex;
                this.image = image1;
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            
            string pathMedia = Path.Combine(documentsPath, @"TeiCapakAlma\Tools\Media.json");
            string pathTool = Path.Combine(documentsPath, @"TeiCapakAlma\Tools\Tool.json");
            
            string jsonMedia = JsonConvert.SerializeObject(_mediaSelections);
//            string jsonMedia = JsonConvert.SerializeObject(_mediaSelections);

            File.WriteAllText(pathMedia , jsonMedia);
        }
    }
}