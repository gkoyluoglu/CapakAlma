using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using FluentFTP;
using Newtonsoft.Json;
using TeiRobotProject;
using TeiRobotProject.Common;

namespace CapakAlma.Panels
{
    public partial class MainPage : UserControl
    {
        private static readonly string LastLoadedFilesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) , @"TeiCapakAlma\Robot\lastLoadedFiles.json");
        private static readonly string FilePath = @"C:\TeiRobot";
        private static readonly string RobotTpPath = @"/md:/";

        private List<string> _loadedFiles;
        private List<string> _lastLoadedFiles;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            string fileContents = File.Exists(LastLoadedFilesPath) ? File.ReadAllText(LastLoadedFilesPath) : " [ ] ";
            
            _lastLoadedFiles = JsonConvert.DeserializeObject<List<string>>(fileContents);
                
            var directories = Directory.GetDirectories(FilePath);

            for (int i = 0; i < directories.Length; i++)
            {
                
                directories[i] = directories[i].Substring(directories[i].LastIndexOf(Path.DirectorySeparatorChar) + 1);
            }
            
            this.comboBox1.DataSource = directories;

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

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            var confirmResult =  MessageBox.Show("Are you sure to delete this item ??",
                "Confirm Delete!!",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                
                _loadedFiles = new List<string>(Directory.GetFiles(Path.Combine(FilePath, comboBox1.SelectedValue.ToString())));

                var client = new FtpClient("192.168.1.200" , "HEPRO" ,"hepro26" );
            
                client.AutoConnect();
            
                var files = client.GetListing("/md:/*.tp");

                for (int i = 0; i < _lastLoadedFiles.Count; i++)
                {
                
                    client.DeleteFile(_lastLoadedFiles[i]);
                }

                _lastLoadedFiles.Clear();
                foreach (var file in _loadedFiles)
                {
                    if(!file.Contains(".vr"))
                    {
                    
                        string fileName = RobotTpPath + file.Substring(file.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                        _lastLoadedFiles.Add(
                            RobotTpPath + file.Substring(file.LastIndexOf(Path.DirectorySeparatorChar) + 1));
                    }
                
                }

                string directoryPath = Path.Combine(FilePath, comboBox1.SelectedValue.ToString());
            
                client.UploadDirectory( directoryPath ,RobotTpPath);
                client.Disconnect();
            
                string json = JsonConvert.SerializeObject(_lastLoadedFiles);

                File.WriteAllText(LastLoadedFilesPath , json);

            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {

            string t1   = Model.Instance.getValue("robotT1");
            string t2   = Model.Instance.getValue("robotT2");
            string auto = Model.Instance.getValue("robotAuto");
            
            this.oparationModeLabel.Text = t1 == "True" ? "T1" : t2 == "True" ? "T2" : "Auto";
        }

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            var robotProgramStatus = Model.Instance.Robot.ReadCurrentProgram();
            
            if (robotProgramStatus == null) return;
            
            
            this.programNameLabel.Text = robotProgramStatus.ProgramName;
            this.robotRunnigStatusLabel.Text = robotProgramStatus.State.ToString();
        }
    }
}
