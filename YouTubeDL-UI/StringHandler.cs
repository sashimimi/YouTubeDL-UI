using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDL_UI
{
    public class StringHandler
    {
        public static String BuildString(List<string> commands)
        {
            string cmd = "";
            foreach (string command in commands)
            {
                cmd += " " + command + " ";
            }
            return cmd;
        }
    }
}
