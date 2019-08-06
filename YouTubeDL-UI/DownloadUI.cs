using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YouTubeDL_UI
{
    public class DownloadUI
    {
        public void CheckDependencies(string path, List<string> dependencies)
        {
            foreach (string dependency in dependencies)
            {
                if (!File.Exists(path + dependency))
                {
                    throw new FileNotFoundException("Missing dependencies", dependency);
                }
            }
        }

        public bool CheckIfEmpty(string str)
        {
            if (str == "")
                return true;
            else
                return false;
        }

        public void Download(string url)
        {
            CommandProcessor.OpenCommandPrompt("cmd.exe", "/C youtube-dl -x --audio-format mp3 " + url);
        }
    }
}
