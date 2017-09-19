namespace Suite_FHFSoft
{
    partial class Configuraciones
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
            this.NombreEmpresa = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.chkFactura = new Telerik.WinControls.UI.RadCheckBox();
            this.ChkFActuraP = new Telerik.WinControls.UI.RadCheckBox();
            this.Fondo = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.bExit = new Telerik.WinControls.UI.RadButton();
            this.bGuardar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.NombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkFActuraP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.Location = new System.Drawing.Point(163, 58);
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.Size = new System.Drawing.Size(305, 20);
            this.NombreEmpresa.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(13, 61);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(143, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Nombre de la Empresa";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkFactura
            // 
            this.chkFactura.AutoSize = false;
            this.chkFactura.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFactura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFactura.Location = new System.Drawing.Point(64, 85);
            this.chkFactura.Name = "chkFactura";
            this.chkFactura.Size = new System.Drawing.Size(113, 18);
            this.chkFactura.TabIndex = 52;
            this.chkFactura.Text = "Imprimir Factura";
            this.chkFactura.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // ChkFActuraP
            // 
            this.ChkFActuraP.AutoSize = false;
            this.ChkFActuraP.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkFActuraP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFActuraP.Location = new System.Drawing.Point(19, 109);
            this.ChkFActuraP.Name = "ChkFActuraP";
            this.ChkFActuraP.Size = new System.Drawing.Size(158, 18);
            this.ChkFActuraP.TabIndex = 52;
            this.ChkFActuraP.Text = "Imprimir Factura Pequeña";
            this.ChkFActuraP.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Fondo.Location = new System.Drawing.Point(163, 133);
            this.Fondo.Mask = "f";
            this.Fondo.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(87, 20);
            this.Fondo.TabIndex = 64;
            this.Fondo.TabStop = false;
            this.Fondo.Text = "0.00";
            this.Fondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(19, 133);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(137, 18);
            this.radLabel2.TabIndex = 63;
            this.radLabel2.Text = "Fondos de Caja";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bExit
            // 
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bExit.Location = new System.Drawing.Point(348, 209);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(110, 24);
            this.bExit.TabIndex = 65;
            this.bExit.Text = "Salir";
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(232, 209);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(110, 24);
            this.bGuardar.TabIndex = 66;
            this.bGuardar.Text = "&Guardar";
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 245);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.Fondo);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.ChkFActuraP);
            this.Controls.Add(this.chkFactura);
            this.Controls.Add(this.NombreEmpresa);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Configuraciones";
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.Configuraciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkFActuraP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox NombreEmpresa;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox chkFactura;
        private Telerik.WinControls.UI.RadCheckBox ChkFActuraP;
        private Telerik.WinControls.UI.RadMaskedEditBox Fondo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton bExit;
        private Telerik.WinControls.UI.RadButton bGuardar;
    }
}