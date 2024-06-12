using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapakAlma.Common;
using CapakAlma.Panels;
using TeiRobotProject.Common;

namespace TeiRobotProject
{
    internal class Model
    {
        private static volatile Model _instance;
        private static readonly object SyncRoot = new object();

        private List<String> _aviableRackSlots;

        private List<Tool> _toolList = new List<Tool>();

        private ProgramData _programData = new ProgramData();
        private Robot _robot;
        private Timer _robotConnectTimer;
        public List<RackSlotPanel> ToolColection { get; }

        public Model()
        {
            this.ToolColection = new List<RackSlotPanel>();
            
            
            _robot = new Robot("192.168.1.200", 60008, 1000);
            
            this._robotConnectTimer = new Timer();
            this._robotConnectTimer.Interval = 150;
            this._robotConnectTimer.Tick += (sender, args) =>
            {
                Ping pinger = new Ping();
                PingReply reply = pinger.Send("192.168.1.200");
                var pingable = reply.Status == IPStatus.Success;

                if (pingable && !_robot.IsConnected)
                {
                
                    _robot.ConnectAsync();
                }
                else
                {
                    
                    _robot.Disconnect();
                }
            };
            this._robotConnectTimer.Enabled = true;
        }

        public static Model Instance
        {
            get
            {
                
                if (_instance == null)
                {
                    
                    lock (SyncRoot)
                    {
                    
                        if (_instance == null)
                        {
                        
                            _instance = new Model();
                        }
                    }
                }

                return _instance;
            }
        }


        public string getValue(String key)
        {
            
            return PLCHaberlesme.Instance.getValue(key);
        }

        public void setAviableRackSlots(List<string> rackSlots)
        {
            
            this._aviableRackSlots = rackSlots;
        }

        public List<String> getAviableRackSlots()
        {
            
            return _aviableRackSlots;
        }

        public void addTool(Tool tool)
        {
            
            _toolList.Add(tool);
        }

        public void saveMedaiFile()
        {
            
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            string path = Path.Combine(documentsPath, @"TeiCapakAlma\Media\Media.bin").ToString();

            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, _toolList);
            }
        }

        internal void readMediaFile()
        {
            
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            string path = Path.Combine(documentsPath, @"TeiCapakAlma\Media\Media.bin").ToString();


            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                _toolList = (List<Tool>)bformatter.Deserialize(stream);
            }

            Console.WriteLine(_toolList.Count);
        }

        internal List<Tool> getTools()
        {
            
            return _toolList;
        }

        // internal ConcurrentDictionary<String, ToolSelectorPanel> getToolMap()
        // {
        //
        //     return keyValuePairs;
        // }

        internal void setProgramData(string mediaProgramName, string toolPickProgramName, int ofsett, int rpm, int id)
        {
            
            _programData.MediaPickProgramName = mediaProgramName;
            _programData.ToolPickProgramName = toolPickProgramName;
            _programData.Id = id;
            _programData.Rpm = rpm;
            _programData.ToolOffsetIndex = ofsett;
        }

        internal ProgramData GetProgramData()
        {
            
            return _programData;
        }


        public Robot Robot => _robot;
    }
}