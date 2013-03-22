using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace FirebirdBackupKitTest
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }



}
