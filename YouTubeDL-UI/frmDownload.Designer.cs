namespace YouTubeDL_UI
{
    partial class frmDownload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.chkMetadata = new System.Windows.Forms.CheckBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Enter YouTube URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(211, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(258, 23);
            this.txtURL.TabIndex = 1;
            // 
            // chkMetadata
            // 
            this.chkMetadata.AutoSize = true;
            this.chkMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMetadata.Location = new System.Drawing.Point(171, 64);
            this.chkMetadata.Name = "chkMetadata";
            this.chkMetadata.Size = new System.Drawing.Size(123, 21);
            this.chkMetadata.TabIndex = 2;
            this.chkMetadata.Text = "Add &Metadata?";
            this.chkMetadata.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(51, 99);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(119, 34);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(314, 99);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(119, 34);
            this.txtExit.TabIndex = 4;
            this.txtExit.Text = "&Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            // 
            // frmDownload
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 151);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.chkMetadata);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTubeDL-UI";
            this.Load += new System.EventHandler(this.frmDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.CheckBox chkMetadata;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button txtExit;
    }
}

