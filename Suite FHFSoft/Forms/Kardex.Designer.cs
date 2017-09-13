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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn15 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn16 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn17 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn18 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn19 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn20 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn21 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
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
            this.bBuscarCliente = new Telerik.WinControls.UI.RadButton();
            this.radLabel23 = new Telerik.WinControls.UI.RadLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.bBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel23)).BeginInit();
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
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "FechaCreacion";
            gridViewDateTimeColumn3.HeaderText = "Fecha";
            gridViewDateTimeColumn3.Name = "Fecha";
            gridViewDateTimeColumn3.ReadOnly = true;
            gridViewDateTimeColumn3.Width = 142;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Documento";
            gridViewTextBoxColumn5.HeaderText = "Documento";
            gridViewTextBoxColumn5.Name = "Documento";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 131;
            gridViewDecimalColumn15.EnableExpressionEditor = false;
            gridViewDecimalColumn15.FieldName = "Entrada";
            gridViewDecimalColumn15.HeaderText = "Entrada";
            gridViewDecimalColumn15.Name = "Entrada";
            gridViewDecimalColumn15.ReadOnly = true;
            gridViewDecimalColumn15.Width = 69;
            gridViewDecimalColumn16.EnableExpressionEditor = false;
            gridViewDecimalColumn16.FieldName = "Salida";
            gridViewDecimalColumn16.HeaderText = "Salida";
            gridViewDecimalColumn16.Name = "Salida";
            gridViewDecimalColumn16.ReadOnly = true;
            gridViewDecimalColumn16.Width = 62;
            gridViewDecimalColumn17.DecimalPlaces = 0;
            gridViewDecimalColumn17.EnableExpressionEditor = false;
            gridViewDecimalColumn17.FieldName = "Costo";
            gridViewDecimalColumn17.HeaderText = "Costo";
            gridViewDecimalColumn17.Name = "Costo";
            gridViewDecimalColumn17.ReadOnly = true;
            gridViewDecimalColumn17.Width = 77;
            gridViewDecimalColumn18.EnableExpressionEditor = false;
            gridViewDecimalColumn18.FieldName = "PrecioVenta";
            gridViewDecimalColumn18.HeaderText = "Precio Venta";
            gridViewDecimalColumn18.Name = "Precio_Venta";
            gridViewDecimalColumn18.ReadOnly = true;
            gridViewDecimalColumn18.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDecimalColumn18.Width = 84;
            gridViewDecimalColumn19.EnableExpressionEditor = false;
            gridViewDecimalColumn19.FieldName = "StockActual";
            gridViewDecimalColumn19.HeaderText = "Stock Actual";
            gridViewDecimalColumn19.Name = "StockActual";
            gridViewDecimalColumn19.ReadOnly = true;
            gridViewDecimalColumn19.Width = 81;
            gridViewDecimalColumn20.EnableExpressionEditor = false;
            gridViewDecimalColumn20.FieldName = "NuevoStock";
            gridViewDecimalColumn20.HeaderText = "Nuevo Stock";
            gridViewDecimalColumn20.Name = "Nuevo Stock";
            gridViewDecimalColumn20.ReadOnly = true;
            gridViewDecimalColumn20.Width = 85;
            gridViewDecimalColumn21.EnableExpressionEditor = false;
            gridViewDecimalColumn21.FieldName = "ValorExistencia";
            gridViewDecimalColumn21.HeaderText = "Valor en Existencia";
            gridViewDecimalColumn21.Name = "ValorExistencia";
            gridViewDecimalColumn21.ReadOnly = true;
            gridViewDecimalColumn21.Width = 102;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Observaciones";
            gridViewTextBoxColumn6.HeaderText = "Observaciones";
            gridViewTextBoxColumn6.Name = "Observaciones";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 169;
            this.GRD.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn15,
            gridViewDecimalColumn16,
            gridViewDecimalColumn17,
            gridViewDecimalColumn18,
            gridViewDecimalColumn19,
            gridViewDecimalColumn20,
            gridViewDecimalColumn21,
            gridViewTextBoxColumn6});
            sortDescriptor3.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor3.PropertyName = "Precio_Venta";
            this.GRD.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.GRD.MasterTemplate.ViewDefinition = tableViewDefinition3;
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
            this.lblArticulo.Size = new System.Drawing.Size(1028, 54);
            this.lblArticulo.TabIndex = 53;
            this.lblArticulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.bBuscarCliente);
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
            this.radGroupBox1.Location = new System.Drawing.Point(12, 88);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1033, 48);
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
            // bBuscarCliente
            // 
            this.bBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.bBuscarCliente.Image = global::Suite_FHFSoft.Properties.Resources._1481444391_search;
            this.bBuscarCliente.Location = new System.Drawing.Point(970, 13);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(38, 30);
            this.bBuscarCliente.TabIndex = 26;
            this.bBuscarCliente.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscarCliente.Click += new System.EventHandler(this.bBuscarCliente_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.bBuscarCliente.GetChildAt(0))).Image = global::Suite_FHFSoft.Properties.Resources._1481444391_search;
            ((Telerik.WinControls.UI.RadButtonElement)(this.bBuscarCliente.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.bBuscarCliente.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).LeftColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).TopColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).RightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).BottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).ForeColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).ForeColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).ForeColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.bBuscarCliente.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // radLabel23
            // 
            this.radLabel23.AutoSize = false;
            this.radLabel23.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel23.ForeColor = System.Drawing.Color.DarkGreen;
            this.radLabel23.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabel23.Location = new System.Drawing.Point(12, 602);
            this.radLabel23.Name = "radLabel23";
            this.radLabel23.Size = new System.Drawing.Size(197, 18);
            this.radLabel23.TabIndex = 55;
            this.radLabel23.Text = "F5-Buscar Articulos";
            this.radLabel23.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 634);
            this.Controls.Add(this.radLabel23);
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
            ((System.ComponentModel.ISupportInitialize)(this.bBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel23)).EndInit();
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
        private Telerik.WinControls.UI.RadButton bBuscarCliente;
        private Telerik.WinControls.UI.RadLabel radLabel23;
    }
}