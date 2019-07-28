using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDL_UI
{
    public class CommandProcessor
    {
        public static void OpenCommandPrompt(string app, string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(app);
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = command;
            Process.Start(startInfo);
        }
    }
}
