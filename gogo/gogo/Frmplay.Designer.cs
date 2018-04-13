namespace gogo
{
    partial class Frmplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmplay));
            this.axplay = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmrplay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axplay)).BeginInit();
            this.SuspendLayout();
            // 
            // axplay
            // 
            this.axplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axplay.Enabled = true;
            this.axplay.Location = new System.Drawing.Point(0, 0);
            this.axplay.Name = "axplay";
            this.axplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axplay.OcxState")));
            this.axplay.Size = new System.Drawing.Size(520, 496);
            this.axplay.TabIndex = 0;
            // 
            // tmrplay
            // 
            this.tmrplay.Tick += new System.EventHandler(this.tmrplay_Tick);
            // 
            // Frmplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 496);
            this.Controls.Add(this.axplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Frmplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Frmplay_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.axplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axplay;
        private System.Windows.Forms.Timer tmrplay;
    }
}