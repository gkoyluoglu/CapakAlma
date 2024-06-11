using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeiRobotProject.Common;

namespace TeiRobotProject
{
    internal class Model
    {

        private static volatile Model instance;
        private static object syncRoot = new object();

        private List<String> aviableRackSlots;
        private List<Tool> toolList = new List<Tool>();
        // private ConcurrentDictionary<String , ToolSelectorPanel> keyValuePairs 
        //     = new ConcurrentDictionary<String , ToolSelectorPanel>();
        
        private ProgramData programData = new ProgramData();
        
        public static Model Instance
        {

            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {

                            instance = new Model();
                        }
                    }
                }

                return instance;
            }
        }


        public string getValue(String key)
        {

            return PLCHaberlesme.Instance.getValue(key);
        }

        public void setAviableRackSlots(List<string> rackSlots)
        {
            this.aviableRackSlots = rackSlots;
        }

        public List<String> getAviableRackSlots()
        {
            return aviableRackSlots;
        }

        public void addTool(Tool tool)
        {

            toolList.Add(tool);
        }

        public void saveMedaiFile()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            string path = Path.Combine(documentsPath, @"TeiCapakAlma\Media\Media.bin").ToString();

            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, toolList);
            }
        }

        internal void readMediaFile()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            string path = Path.Combine(documentsPath, @"TeiCapakAlma\Media\Media.bin").ToString();


            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                toolList = (List<Tool>)bformatter.Deserialize(stream);
            }

            Console.WriteLine(toolList.Count);
        }

        internal List<Tool> getTools()
        {
            return toolList;
        }

        // internal ConcurrentDictionary<String, ToolSelectorPanel> getToolMap()
        // {
        //
        //     return keyValuePairs;
        // }

        internal void setProgramData(string mediaProgramName , string toolPickProgramName , int ofsett , int rpm , int id)
        {
            programData.MediaPickProgramName = mediaProgramName;
            programData.ToolPickProgramName = toolPickProgramName;
            programData.Rpm = rpm;
            programData.Id = id;
            programData.ToolOffsetIndex = ofsett;
        }

        internal ProgramData GetProgramData()
        {
           return programData;
        }
    }
}
