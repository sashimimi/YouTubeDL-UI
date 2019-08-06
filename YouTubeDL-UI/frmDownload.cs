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
        private DownloadUI logic = new DownloadUI();

        public frmDownload()
        {
            InitializeComponent();
        }

        private void frmDownload_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath.ToString(); //returns file path of the executable
            List<string> dependencies = new List<string>() {"\\ffmpeg.exe", "\\youtube-dl.exe"};

            try
            {
                logic.CheckDependencies(path, dependencies);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Dependencies missing.\n\n" +
                    "Please ensure you have \"ffmpeg.exe\" and \"youtube-dl.exe\" in the current folder directory.",
                    "YouTubeDL-UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
