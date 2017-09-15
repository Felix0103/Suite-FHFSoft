namespace Suite_FHFSoft
{
    partial class ReporteVentas
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
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.bImprimir = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.AlmacenID = new Telerik.WinControls.UI.RadDropDownList();
            this.UsuarioID = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Date2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.Date1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(273, 36);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Reporte de Ventas";
            // 
            // bImprimir
            // 
            this.bImprimir.Location = new System.Drawing.Point(12, 192);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(109, 53);
            this.bImprimir.TabIndex = 1;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel9);
            this.radGroupBox1.Controls.Add(this.AlmacenID);
            this.radGroupBox1.Controls.Add(this.UsuarioID);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.Date2);
            this.radGroupBox1.Controls.Add(this.Date1);
            this.radGroupBox1.HeaderText = "Filtros";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 42);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(245, 144);
            this.radGroupBox1.TabIndex = 55;
            this.radGroupBox1.Text = "Filtros";
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Location = new System.Drawing.Point(27, 98);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(60, 18);
            this.radLabel3.TabIndex = 24;
            this.radLabel3.Text = "Almacen";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel9
            // 
            this.radLabel9.AutoSize = false;
            this.radLabel9.Location = new System.Drawing.Point(27, 72);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(60, 18);
            this.radLabel9.TabIndex = 24;
            this.radLabel9.Text = "Usuario";
            this.radLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AlmacenID
            // 
            this.AlmacenID.Location = new System.Drawing.Point(93, 98);
            this.AlmacenID.Name = "AlmacenID";
            this.AlmacenID.Size = new System.Drawing.Size(124, 20);
            this.AlmacenID.TabIndex = 25;
            // 
            // UsuarioID
            // 
            this.UsuarioID.Location = new System.Drawing.Point(93, 72);
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.Size = new System.Drawing.Size(124, 20);
            this.UsuarioID.TabIndex = 25;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(17, 47);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 18);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "Fecha Final";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(9, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(78, 18);
            this.radLabel1.TabIndex = 23;
            this.radLabel1.Text = "Fecha Inicio";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date2
            // 
            this.Date2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date2.Location = new System.Drawing.Point(93, 46);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(124, 20);
            this.Date2.TabIndex = 22;
            this.Date2.TabStop = false;
            this.Date2.Value = new System.DateTime(((long)(0)));
            // 
            // Date1
            // 
            this.Date1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date1.Location = new System.Drawing.Point(93, 20);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(124, 20);
            this.Date1.TabIndex = 22;
            this.Date1.TabStop = false;
            this.Date1.Value = new System.DateTime(((long)(0)));
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(148, 192);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(109, 53);
            this.bSalir.TabIndex = 1;
            this.bSalir.Text = "&Salir";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(273, 263);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.radTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadButton bImprimir;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadDropDownList AlmacenID;
        private Telerik.WinControls.UI.RadDropDownList UsuarioID;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker Date2;
        private Telerik.WinControls.UI.RadDateTimePicker Date1;
        private Telerik.WinControls.UI.RadButton bSalir;
    }
}