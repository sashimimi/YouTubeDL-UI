using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeDL_UI
{
    public partial class frmDownload : Form
    {
        public frmDownload()
        {
            InitializeComponent();
        }

        private void frmDownload_Load(object sender, EventArgs e)
        {
            String path = Application.StartupPath.ToString(); //returns file path of the executable

            if (!File.Exists(path + "\ffmpeg.exe") && !File.Exists(path + "\\youtube-dl.exe"))
            {
                MessageBox.Show("Dependencies missing.\n\n" +
                    "Please ensure you have \"ffmpeg.exe\" and \"youtube-dl.exe\" in the current folder directory.",
                    "YouTubeDL-UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
