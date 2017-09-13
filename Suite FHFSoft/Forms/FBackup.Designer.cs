namespace Suite_FHFSoft
{
    partial class FBackup
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
            this.bBackup = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.bBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // bBackup
            // 
            this.bBackup.Location = new System.Drawing.Point(38, 88);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(197, 77);
            this.bBackup.TabIndex = 0;
            this.bBackup.Text = "Guardar Backup";
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // FBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBackup";
            this.Text = "FBackup";
            this.Load += new System.EventHandler(this.FBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton bBackup;
    }
}