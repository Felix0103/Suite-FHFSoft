namespace Suite_FHFSoft
{
    partial class Wait
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
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.rotatingRingsWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.RotatingRingsWaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(12, 12);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(403, 276);
            this.radWaitingBar1.TabIndex = 0;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.WaitingIndicators.Add(this.rotatingRingsWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingStep = 7;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.RotatingRings;
            // 
            // rotatingRingsWaitingBarIndicatorElement1
            // 
            this.rotatingRingsWaitingBarIndicatorElement1.AutoSize = true;
            this.rotatingRingsWaitingBarIndicatorElement1.Name = "rotatingRingsWaitingBarIndicatorElement1";
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 286);
            this.Controls.Add(this.radWaitingBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wait";
            this.Text = "Wait";
            this.Load += new System.EventHandler(this.Wait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.RotatingRingsWaitingBarIndicatorElement rotatingRingsWaitingBarIndicatorElement1;
    }
}