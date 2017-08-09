namespace Suite_FHFSoft
{
    partial class EncriDescri
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ValorAscii = new Telerik.WinControls.UI.RadTextBox();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.Encrip = new Telerik.WinControls.UI.RadTextBox();
            this.bExit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorAscii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bExit)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(12, 60);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(100, 20);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Valor Ascii";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValorAscii
            // 
            this.ValorAscii.Location = new System.Drawing.Point(118, 60);
            this.ValorAscii.Name = "ValorAscii";
            this.ValorAscii.Size = new System.Drawing.Size(247, 20);
            this.ValorAscii.TabIndex = 0;
            this.ValorAscii.TextChanged += new System.EventHandler(this.ValorAscii_TextChanged);
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(378, 33);
            this.radTitleBar1.TabIndex = 2;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Encriptado";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(12, 86);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(100, 20);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Valor Encriptado";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Encrip
            // 
            this.Encrip.Location = new System.Drawing.Point(118, 86);
            this.Encrip.Name = "Encrip";
            this.Encrip.Size = new System.Drawing.Size(247, 20);
            this.Encrip.TabIndex = 1;
            // 
            // bExit
            // 
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bExit.Location = new System.Drawing.Point(255, 112);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(110, 24);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Salir";
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // EncriDescri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bExit;
            this.ClientSize = new System.Drawing.Size(378, 149);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.Encrip);
            this.Controls.Add(this.ValorAscii);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTitleBar1);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EncriDescri";
            this.Text = "Encriptado";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorAscii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox ValorAscii;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox Encrip;
        private Telerik.WinControls.UI.RadButton bExit;
    }
}