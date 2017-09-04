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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.GRD = new Telerik.WinControls.UI.RadGridView();
            this.lblArticulo = new Telerik.WinControls.UI.RadLabel();
            this.Fecha = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Precio = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            this.bGuardar = new Telerik.WinControls.UI.RadButton();
            this.bNuevo = new Telerik.WinControls.UI.RadButton();
            this.Hora = new Telerik.WinControls.UI.RadTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hora)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(551, 42);
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
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ArticulosPreciosID";
            gridViewTextBoxColumn4.HeaderText = "ArticulosPreciosID";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ArticulosPreciosID";
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "Fechahora";
            gridViewDateTimeColumn3.HeaderText = "Fecha";
            gridViewDateTimeColumn3.Name = "FECHA";
            gridViewDateTimeColumn3.ReadOnly = true;
            gridViewDateTimeColumn3.Width = 122;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Precio";
            gridViewTextBoxColumn5.FormatString = "{0:#,###,###.#0}";
            gridViewTextBoxColumn5.HeaderText = "Precio";
            gridViewTextBoxColumn5.Name = "Precio";
            gridViewTextBoxColumn5.Width = 92;
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FieldName = "FechaCreacion";
            gridViewDateTimeColumn4.HeaderText = "Fecha Creacion";
            gridViewDateTimeColumn4.Name = "FEchaCreacion";
            gridViewDateTimeColumn4.Width = 123;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Usuario";
            gridViewTextBoxColumn6.HeaderText = "Usuario";
            gridViewTextBoxColumn6.Name = "column1";
            gridViewTextBoxColumn6.Width = 158;
            this.GRD.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn4,
            gridViewTextBoxColumn6});
            this.GRD.MasterTemplate.ViewDefinition = tableViewDefinition2;
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
            this.lblArticulo.Size = new System.Drawing.Size(484, 54);
            this.lblArticulo.TabIndex = 36;
            this.lblArticulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArticulo.Click += new System.EventHandler(this.lblArticulo_Click);
            // 
            // Fecha
            // 
            this.Fecha.CustomFormat = "";
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(90, 132);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(94, 20);
            this.Fecha.TabIndex = 38;
            this.Fecha.TabStop = false;
            this.Fecha.Text = "3/9/2017";
            this.Fecha.Value = new System.DateTime(2017, 9, 3, 20, 13, 22, 0);
            // 
            // radLabel5
            // 
            this.radLabel5.AutoSize = false;
            this.radLabel5.Location = new System.Drawing.Point(13, 132);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(71, 18);
            this.radLabel5.TabIndex = 37;
            this.radLabel5.Text = "Fecha Inicio";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(208, 132);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 18);
            this.radLabel1.TabIndex = 37;
            this.radLabel1.Text = "Hora";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Precio
            // 
            this.Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Precio.Location = new System.Drawing.Point(427, 132);
            this.Precio.Mask = "f";
            this.Precio.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(69, 20);
            this.Precio.TabIndex = 39;
            this.Precio.TabStop = false;
            this.Precio.Text = "0.00";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(377, 132);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(44, 18);
            this.radLabel2.TabIndex = 37;
            this.radLabel2.Text = "Precio";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bSalir
            // 
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
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(259, 131);
            this.Hora.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.Hora.MinValue = new System.DateTime(((long)(0)));
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(93, 20);
            this.Hora.Step = 30;
            this.Hora.TabIndex = 57;
            this.Hora.TabStop = false;
            this.Hora.TimeTables = Telerik.WinControls.UI.TimeTables.HoursAndMinutesInOneTable;
            this.Hora.Value = new System.DateTime(2017, 9, 3, 10, 0, 0, 0);
            // 
            // PrecioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 621);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.GRD);
            this.Controls.Add(this.radTitleBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrecioVentas";
            this.Text = "Historico Precios";
            this.Load += new System.EventHandler(this.PrecioVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadGridView GRD;
        private Telerik.WinControls.UI.RadLabel lblArticulo;
        private Telerik.WinControls.UI.RadDateTimePicker Fecha;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMaskedEditBox Precio;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton bSalir;
        private Telerik.WinControls.UI.RadButton bGuardar;
        private Telerik.WinControls.UI.RadButton bNuevo;
        private Telerik.WinControls.UI.RadTimePicker Hora;
    }
}