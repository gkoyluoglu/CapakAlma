using Fanuc.RobotInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeiRobotProject.Common
{
    public class Robot
    {
        private IExRobotIF RobotIF { get; }

        private string robotIp;
        private ushort robotPort;
        private int robotTimeoutDuration;

        private static int ALARM_COUNT_TO_READ = 10;

        RobotAlarm[] alarmList;
        public bool IsConnected 
        {
            
            get 
            {
                
                return RobotIF.IsConnected;
            }
        }

        public Robot(string robotIp, ushort robotPort, int robotTimeoutDuration)
        {

            RobotIF =  new ExRobotIF(new RobotIF());
            alarmList = new RobotAlarm[ALARM_COUNT_TO_READ];
            this.robotIp = robotIp;
            this.robotPort = robotPort;
            this.robotTimeoutDuration = robotTimeoutDuration;
        }
         
        public void ConnectAsync()
        {
            try
            {

                    RobotIF.ConnectAsync( robotIp, robotPort, robotTimeoutDuration);
            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }

        public void Disconnect()
        {

            RobotIF.Disconnect();
        }

        #region Read/Write String
        public string ReadStringRegister(int registerNumber)
        {

            if (RobotIF.IsConnected)
            {

                registerNumber = RobotIF.WriteAssignment(40, $"SR[{registerNumber}] 1");
                return Encoding.ASCII.GetString(RobotIF.ReadSNPX(registerNumber, 80));
            }

            return null;
        }
        public void WriteStringRegister(int registerNumber , string value)
        {
            if (RobotIF.IsConnected)
            {

                var bytes = Encoding.ASCII.GetBytes(value);
                if (bytes.Length % 2 == 1)
                    bytes = bytes.Concat(new byte[1]).ToArray();

                registerNumber = RobotIF.WriteAssignment(40, $"SR[{registerNumber}] 1");

                RobotIF.WriteSNPX(registerNumber, bytes.Take(80).ToArray());
            }
        }
        #endregion

        #region Read/Write Numeric

        public void WriteNumericRegister(int registerNumber, float value)
        {
            if (RobotIF.IsConnected)
            {


                registerNumber = RobotIF.WriteAssignment(2, $"R[{registerNumber}] 0");
                RobotIF.WriteSNPX(registerNumber, BitConverter.GetBytes(value));
            }
        }
        public float ReadNumericRegister(int registerNumber)
        {
            if (RobotIF.IsConnected)
            {


                registerNumber = RobotIF.WriteAssignment(2, $"R[{registerNumber}] 0");
                return BitConverter.ToSingle(RobotIF.ReadSNPX(registerNumber, 4), 0);
            }
            
            return -999999;
        }
        #endregion

        #region Read/Write DigitalOutput

        public bool readDigitalOutput(int outputRegisterNumber)
        {
            if (RobotIF.IsConnected)
            {
                return RobotIF.ReadSDO(outputRegisterNumber, 1)[0];
            }
            return false;
        }
        public void writeDigitalOutput(int outputRegisterNumber, bool value)
        {
            if (RobotIF.IsConnected)
            {

                RobotIF.WriteSDO(outputRegisterNumber, value);
            }
        }
        #endregion  

        #region Alarm

        public RobotAlarm[] readAlarm()
        {
            if (RobotIF.IsConnected)
            {

                for (int i = 0; i < ALARM_COUNT_TO_READ; i++)
                {
                    int index = RobotIF.WriteAssignment(100, $"ALM[{(false ? "E" : "")}{i + 1}] 1");
                    alarmList[i] = RobotAlarm.FromBytes(RobotIF.ReadSNPX(index, 200));

                }

                return alarmList;
            }

            return null;

        }

        #endregion

        #region CureentProgram

        public RobotTaskStatus ReadCurrentProgram()
        {
            if (RobotIF.IsConnected)
            {

                int registerNumber = RobotIF.WriteAssignment(18, _TaskTypeToAssignmentString(RobotTaskType.All));

                return RobotTaskStatus.FromBytes(RobotIF.ReadSNPX(1, 36));
            }
            return null;
        }
        private string _TaskTypeToAssignmentString(RobotTaskType t)
        {
            switch (t)
            {
                case RobotTaskType.All: return $"PRG[{1}] 1";
                case RobotTaskType.IgnoreMacro: return $"PRG[M{1}] 1";
                case RobotTaskType.IgnoreKarel: return $"PRG[K{1}] 1";
                case RobotTaskType.IgnoreMacroKarel: return $"PRG[MK{1}] 1";
                default:
                    throw new ArgumentException($"Unknown RobotTaskType {RobotTaskType.All}", nameof(RobotTaskType.All));
            }
        }
        #endregion
    }
}
