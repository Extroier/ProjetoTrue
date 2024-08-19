
namespace ProjetoMosquitoVelho
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblNumberPercent = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.PgbProgress = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(257, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(278, 293);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblNumberPercent
            // 
            this.lblNumberPercent.AutoSize = true;
            this.lblNumberPercent.Location = new System.Drawing.Point(375, 322);
            this.lblNumberPercent.Name = "lblNumberPercent";
            this.lblNumberPercent.Size = new System.Drawing.Size(19, 13);
            this.lblNumberPercent.TabIndex = 1;
            this.lblNumberPercent.Text = "0  ";
            this.lblNumberPercent.Click += new System.EventHandler(this.lblNumberPercent_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(400, 322);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 13);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "%\r\n";
            // 
            // PgbProgress
            // 
            this.PgbProgress.Location = new System.Drawing.Point(207, 338);
            this.PgbProgress.MarqueeAnimationSpeed = 1;
            this.PgbProgress.Maximum = 99;
            this.PgbProgress.Name = "PgbProgress";
            this.PgbProgress.Size = new System.Drawing.Size(389, 33);
            this.PgbProgress.Step = 1;
            this.PgbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PgbProgress.TabIndex = 3;
            this.PgbProgress.Click += new System.EventHandler(this.PgbProgress_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 10;
            this.tmrSplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PgbProgress);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblNumberPercent);
            this.Controls.Add(this.pctLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOS-Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblNumberPercent;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ProgressBar PgbProgress;
        private System.Windows.Forms.Timer tmrSplash;
    }
}