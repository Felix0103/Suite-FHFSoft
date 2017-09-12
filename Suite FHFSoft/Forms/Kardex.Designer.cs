namespace Suite_FHFSoft
{
    partial class Kardex
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.GRD = new Telerik.WinControls.UI.RadGridView();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            this.lblArticulo = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.AlmacenID = new Telerik.WinControls.UI.RadDropDownList();
            this.ArticuloId = new Telerik.WinControls.UI.RadDropDownList();
            this.UsuarioID = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Date2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.Date1 = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(1057, 30);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Kardex";
            // 
            // GRD
            // 
            this.GRD.BackColor = System.Drawing.Color.White;
            this.GRD.Cursor = System.Windows.Forms.Cursors.Default;
            this.GRD.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GRD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GRD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GRD.Location = new System.Drawing.Point(12, 141);
            // 
            // 
            // 
            this.GRD.MasterTemplate.AllowAddNewRow = false;
            this.GRD.MasterTemplate.AllowDeleteRow = false;
            this.GRD.MasterTemplate.AutoGenerateColumns = false;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "FechaCreacion";
            gridViewDateTimeColumn1.HeaderText = "Fecha";
            gridViewDateTimeColumn1.Name = "Fecha";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 142;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Documento";
            gridViewTextBoxColumn1.HeaderText = "Documento";
            gridViewTextBoxColumn1.Name = "Documento";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 131;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Entrada";
            gridViewDecimalColumn1.HeaderText = "Entrada";
            gridViewDecimalColumn1.Name = "Entrada";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 69;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Salida";
            gridViewDecimalColumn2.HeaderText = "Salida";
            gridViewDecimalColumn2.Name = "Salida";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 62;
            gridViewDecimalColumn3.DecimalPlaces = 0;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Costo";
            gridViewDecimalColumn3.HeaderText = "Costo";
            gridViewDecimalColumn3.Name = "Costo";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn3.Width = 77;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "PrecioVenta";
            gridViewDecimalColumn4.HeaderText = "Precio Venta";
            gridViewDecimalColumn4.Name = "Precio_Venta";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewDecimalColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDecimalColumn4.Width = 84;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "StockActual";
            gridViewDecimalColumn5.HeaderText = "Stock Actual";
            gridViewDecimalColumn5.Name = "StockActual";
            gridViewDecimalColumn5.ReadOnly = true;
            gridViewDecimalColumn5.Width = 81;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "NuevoStock";
            gridViewDecimalColumn6.HeaderText = "Nuevo Stock";
            gridViewDecimalColumn6.Name = "Nuevo Stock";
            gridViewDecimalColumn6.ReadOnly = true;
            gridViewDecimalColumn6.Width = 85;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "ValorExistencia";
            gridViewDecimalColumn7.HeaderText = "Valor en Existencia";
            gridViewDecimalColumn7.Name = "ValorExistencia";
            gridViewDecimalColumn7.ReadOnly = true;
            gridViewDecimalColumn7.Width = 102;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Observaciones";
            gridViewTextBoxColumn2.HeaderText = "Observaciones";
            gridViewTextBoxColumn2.Name = "Observaciones";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 169;
            this.GRD.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewTextBoxColumn2});
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Precio_Venta";
            this.GRD.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.GRD.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GRD.Name = "GRD";
            this.GRD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GRD.Size = new System.Drawing.Size(1036, 455);
            this.GRD.TabIndex = 1;
            this.GRD.Text = "radGridView1";
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(938, 602);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(110, 24);
            this.bSalir.TabIndex = 52;
            this.bSalir.Text = "&Salir";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = false;
            this.lblArticulo.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblArticulo.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArticulo.Location = new System.Drawing.Point(12, 36);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(977, 54);
            this.lblArticulo.TabIndex = 53;
            this.lblArticulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel9);
            this.radGroupBox1.Controls.Add(this.AlmacenID);
            this.radGroupBox1.Controls.Add(this.ArticuloId);
            this.radGroupBox1.Controls.Add(this.UsuarioID);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.Date2);
            this.radGroupBox1.Controls.Add(this.Date1);
            this.radGroupBox1.HeaderText = "Filtros";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 90);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(977, 45);
            this.radGroupBox1.TabIndex = 54;
            this.radGroupBox1.Text = "Filtros";
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Location = new System.Drawing.Point(753, 21);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(60, 18);
            this.radLabel3.TabIndex = 24;
            this.radLabel3.Text = "Almacen";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.Location = new System.Drawing.Point(13, 21);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(60, 18);
            this.radLabel4.TabIndex = 24;
            this.radLabel4.Text = "Articulo";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel9
            // 
            this.radLabel9.AutoSize = false;
            this.radLabel9.Location = new System.Drawing.Point(558, 20);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(60, 18);
            this.radLabel9.TabIndex = 24;
            this.radLabel9.Text = "Usuario";
            this.radLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AlmacenID
            // 
            this.AlmacenID.Location = new System.Drawing.Point(819, 21);
            this.AlmacenID.Name = "AlmacenID";
            this.AlmacenID.Size = new System.Drawing.Size(124, 20);
            this.AlmacenID.TabIndex = 25;
            // 
            // ArticuloId
            // 
            this.ArticuloId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ArticuloId.AutoSizeItems = true;
            this.ArticuloId.DropDownMinSize = new System.Drawing.Size(400, 0);
            this.ArticuloId.EnableAlternatingItemColor = true;
            this.ArticuloId.Location = new System.Drawing.Point(79, 21);
            this.ArticuloId.Name = "ArticuloId";
            this.ArticuloId.Size = new System.Drawing.Size(124, 20);
            this.ArticuloId.TabIndex = 25;
            this.ArticuloId.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ArticuloId_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ArticuloId.GetChildAt(0))).DefaultSize = new System.Drawing.Size(400, 0);
            // 
            // UsuarioID
            // 
            this.UsuarioID.Location = new System.Drawing.Point(624, 20);
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.Size = new System.Drawing.Size(124, 20);
            this.UsuarioID.TabIndex = 25;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(383, 21);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 18);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "Fecha Final";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(200, 21);
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
            this.Date2.Location = new System.Drawing.Point(459, 20);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(93, 20);
            this.Date2.TabIndex = 22;
            this.Date2.TabStop = false;
            this.Date2.Value = new System.DateTime(((long)(0)));
            // 
            // Date1
            // 
            this.Date1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date1.Location = new System.Drawing.Point(284, 20);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(93, 20);
            this.Date1.TabIndex = 22;
            this.Date1.TabStop = false;
            this.Date1.Value = new System.DateTime(((long)(0)));
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 634);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.GRD);
            this.Controls.Add(this.radTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Kardex";
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.Kardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadGridView GRD;
        private Telerik.WinControls.UI.RadButton bSalir;
        private Telerik.WinControls.UI.RadLabel lblArticulo;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker Date2;
        private Telerik.WinControls.UI.RadDateTimePicker Date1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadDropDownList AlmacenID;
        private Telerik.WinControls.UI.RadDropDownList UsuarioID;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList ArticuloId;
    }
}