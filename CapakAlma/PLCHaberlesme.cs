using Newtonsoft.Json;
using S7.Net;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using TeiRobotProject.Common;

namespace TeiRobotProject
{
    internal class PLCHaberlesme
    {

        private static volatile PLCHaberlesme instance;
        private static object syncRoot = new object();

        private static List<SensorAdresName> measuringPoints = new List<SensorAdresName>();

        private static ConcurrentDictionary<String, String> values = new ConcurrentDictionary<String, String>();
        
        private static Thread raedThread;
        private static bool _killThread = false;
        
        Mutex mutex = new Mutex(false);


        Plc plc = new Plc(CpuType.S71500, "192.168.1.1", 0, 1);
        private PLCHaberlesme()
        {
            plc.OpenAsync();
            init();
        }

        public static PLCHaberlesme Instance
        {

            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {

                            instance = new PLCHaberlesme();
                        }
                    }
                }

                return instance;
            }
        }

        private void readData()
        {
            raedThread = new Thread(() =>
            {
                int i = 0;
                while (!_killThread)
                {
                    if (plc.IsConnected)
                    {

                        try
                        {
                            if (measuringPoints[i].type.ToLower().Equals("real"))
                            {

                                float result = ((uint)plc.Read(measuringPoints[i].adress)).ConvertToFloat();
                                values[measuringPoints[i].name] = result.ToString();
                            }
                            else
                            {
                                var result = (plc.Read(measuringPoints[i].adress));
                                values[measuringPoints[i].name] = result.ToString();
                            }
                        }
                        catch (PlcException ex)
                        {

                            plc.OpenAsync();
                            //Connection Lost
                        }

                        i = ++i % measuringPoints.Count;
                    }
                }
            });
            raedThread.Start();
        }
        public string getValue(string key)
        {
            
            return values.ContainsKey(key) ? values[key] : null;
        }

        public async void killReadThread()
        {
            
            _killThread = true;
            await Task.Delay(50);
            raedThread.Abort();
        }
        private void init()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            string path = Path.Combine(documentsPath , @"TeiCapakAlma\OlcumNoktalari\OlcumNoktalari.json").ToString();
            
            string fileContents = File.ReadAllText(path);
            
            measuringPoints = JsonConvert.DeserializeObject<List<SensorAdresName>>(fileContents);


            readData(); 
        }


        public void sendBitToPLC(int db, int dbAddress , int bitAddress ,   bool value)
        {
            if (plc.IsConnected)
            {

                plc.WriteBit(DataType.DataBlock, db, dbAddress, bitAddress, value);
            }
        }

        public void sendDataToPLC(int db, int startAddres, float value)
        {
            if (plc.IsConnected)
            {

                plc.Write(DataType.DataBlock, db, startAddres, value);
            }
        }

        public void sendDataToPLC(int db, int startAddres, double value)
        {
            if (plc.IsConnected)
            {

                plc.Write(DataType.DataBlock, db, startAddres, value);
            }
        }
        public void sendDataToPLC(int db, int startAddres, Int32 value)
        {
            if (plc.IsConnected)
            {

                plc.Write(DataType.DataBlock, db, startAddres, value);
            }
        }
        public void sendDataToPLC(int db, int startAddres, Int16 value)
        {
            if (plc.IsConnected)
            {

                plc.Write(DataType.DataBlock, db, startAddres, value);
            }            
        }
        public void sendDataToPLC(int db, int startAddres, Int64 value)
        {
            if (plc.IsConnected)
            {

                plc.Write(DataType.DataBlock, db, startAddres, value);
            }
        }

        public object readOnce(string db)
        {

            var readValue = plc.Read(db);
            return readValue;
        }
    }

    class SensorAdresName
    {
        public string name;
        public string adress;
        public string type;
        
        public SensorAdresName(string name, string adress , string type) 
        { 
            this.name = name;
            this.adress = adress;   
            this.type = type;
        }

    }
}
