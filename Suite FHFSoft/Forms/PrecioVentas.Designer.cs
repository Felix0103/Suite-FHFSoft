namespace Suite_FHFSoft
{
    partial class PrecioVentas
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn9 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn10 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.GRD = new Telerik.WinControls.UI.RadGridView();
            this.lblArticulo = new Telerik.WinControls.UI.RadLabel();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            this.bGuardar = new Telerik.WinControls.UI.RadButton();
            this.bNuevo = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.Hora = new Telerik.WinControls.UI.RadTimePicker();
            this.Precio = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Fecha = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(546, 42);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Historico Precios";
            // 
            // GRD
            // 
            this.GRD.BackColor = System.Drawing.Color.White;
            this.GRD.Cursor = System.Windows.Forms.Cursors.Default;
            this.GRD.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GRD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GRD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GRD.Location = new System.Drawing.Point(12, 158);
            // 
            // 
            // 
            this.GRD.MasterTemplate.AllowAddNewRow = false;
            this.GRD.MasterTemplate.AllowDeleteRow = false;
            this.GRD.MasterTemplate.AllowEditRow = false;
            this.GRD.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "ArticulosPreciosID";
            gridViewTextBoxColumn13.HeaderText = "ArticulosPreciosID";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "ArticulosPreciosID";
            gridViewDateTimeColumn9.EnableExpressionEditor = false;
            gridViewDateTimeColumn9.FieldName = "Fechahora";
            gridViewDateTimeColumn9.HeaderText = "Fecha";
            gridViewDateTimeColumn9.Name = "FECHA";
            gridViewDateTimeColumn9.ReadOnly = true;
            gridViewDateTimeColumn9.Width = 122;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "Precio";
            gridViewTextBoxColumn14.FormatString = "{0:#,###,###.#0}";
            gridViewTextBoxColumn14.HeaderText = "Precio";
            gridViewTextBoxColumn14.Name = "Precio";
            gridViewTextBoxColumn14.Width = 92;
            gridViewDateTimeColumn10.EnableExpressionEditor = false;
            gridViewDateTimeColumn10.FieldName = "FechaCreacion";
            gridViewDateTimeColumn10.HeaderText = "Fecha Creacion";
            gridViewDateTimeColumn10.Name = "FEchaCreacion";
            gridViewDateTimeColumn10.Width = 123;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "Usuario";
            gridViewTextBoxColumn15.HeaderText = "Usuario";
            gridViewTextBoxColumn15.Name = "column1";
            gridViewTextBoxColumn15.Width = 158;
            this.GRD.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn13,
            gridViewDateTimeColumn9,
            gridViewTextBoxColumn14,
            gridViewDateTimeColumn10,
            gridViewTextBoxColumn15});
            this.GRD.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.GRD.Name = "GRD";
            this.GRD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GRD.Size = new System.Drawing.Size(527, 410);
            this.GRD.TabIndex = 1;
            this.GRD.Text = "radGridView1";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = false;
            this.lblArticulo.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblArticulo.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArticulo.Location = new System.Drawing.Point(12, 48);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(527, 54);
            this.lblArticulo.TabIndex = 36;
            this.lblArticulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArticulo.Click += new System.EventHandler(this.lblArticulo_Click);
            // 
            // bSalir
            // 
            this.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSalir.Location = new System.Drawing.Point(315, 574);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(81, 24);
            this.bSalir.TabIndex = 56;
            this.bSalir.Text = "&Salir";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(228, 574);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(81, 24);
            this.bGuardar.TabIndex = 52;
            this.bGuardar.Text = "&Guardar";
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(141, 574);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(81, 24);
            this.bNuevo.TabIndex = 53;
            this.bNuevo.Text = "&Nuevo";
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.Hora);
            this.radGroupBox1.Controls.Add(this.Precio);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.Fecha);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.HeaderText = "Datos Nuevo Precio";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 100);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(527, 52);
            this.radGroupBox1.TabIndex = 58;
            this.radGroupBox1.Text = "Datos Nuevo Precio";
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(268, 19);
            this.Hora.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.Hora.MinValue = new System.DateTime(((long)(0)));
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(93, 20);
            this.Hora.Step = 30;
            this.Hora.TabIndex = 63;
            this.Hora.TabStop = false;
            this.Hora.TimeTables = Telerik.WinControls.UI.TimeTables.HoursAndMinutesInOneTable;
            this.Hora.Value = new System.DateTime(2017, 9, 3, 0, 0, 0, 0);
            // 
            // Precio
            // 
            this.Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Precio.Location = new System.Drawing.Point(436, 20);
            this.Precio.Mask = "f";
            this.Precio.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(69, 20);
            this.Precio.TabIndex = 62;
            this.Precio.TabStop = false;
            this.Precio.Text = "0.00";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(386, 20);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(44, 18);
            this.radLabel2.TabIndex = 58;
            this.radLabel2.Text = "Precio";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(217, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 18);
            this.radLabel1.TabIndex = 59;
            this.radLabel1.Text = "Hora";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Fecha
            // 
            this.Fecha.CustomFormat = "";
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(99, 20);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(94, 20);
            this.Fecha.TabIndex = 61;
            this.Fecha.TabStop = false;
            this.Fecha.Text = "9/3/2017";
            this.Fecha.Value = new System.DateTime(2017, 9, 3, 20, 13, 22, 0);
            // 
            // radLabel5
            // 
            this.radLabel5.AutoSize = false;
            this.radLabel5.Location = new System.Drawing.Point(22, 20);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(71, 18);
            this.radLabel5.TabIndex = 60;
            this.radLabel5.Text = "Fecha Inicio";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PrecioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bSalir;
            this.ClientSize = new System.Drawing.Size(546, 619);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.GRD);
            this.Controls.Add(this.radTitleBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrecioVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico Precios";
            this.Load += new System.EventHandler(this.PrecioVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadGridView GRD;
        private Telerik.WinControls.UI.RadLabel lblArticulo;
        private Telerik.WinControls.UI.RadButton bSalir;
        private Telerik.WinControls.UI.RadButton bGuardar;
        private Telerik.WinControls.UI.RadButton bNuevo;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTimePicker Hora;
        private Telerik.WinControls.UI.RadMaskedEditBox Precio;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker Fecha;
        private Telerik.WinControls.UI.RadLabel radLabel5;
    }
}