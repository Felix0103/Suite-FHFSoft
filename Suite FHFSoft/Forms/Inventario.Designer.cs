namespace Suite_FHFSoft
{
    partial class Inventario
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.MasterTemplate = new Telerik.WinControls.UI.RadGridView();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.bIngresoMercancia = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.bKardex = new Telerik.WinControls.UI.RadButton();
            this.bArticulos = new Telerik.WinControls.UI.RadButton();
            this.bMovimientos = new Telerik.WinControls.UI.RadButton();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIngresoMercancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(985, 35);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Inventario";
            // 
            // MasterTemplate
            // 
            this.MasterTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterTemplate.BackColor = System.Drawing.Color.White;
            this.MasterTemplate.Cursor = System.Windows.Forms.Cursors.Default;
            this.MasterTemplate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MasterTemplate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MasterTemplate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasterTemplate.Location = new System.Drawing.Point(14, 118);
            // 
            // 
            // 
            this.MasterTemplate.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.HeaderText = "Codigo";
            gridViewTextBoxColumn13.Name = "Codigo";
            gridViewTextBoxColumn13.Width = 104;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.HeaderText = "Articulo";
            gridViewTextBoxColumn14.Name = "Articulo";
            gridViewTextBoxColumn14.Width = 311;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.HeaderText = "Marca";
            gridViewTextBoxColumn15.Name = "Marca";
            gridViewTextBoxColumn15.Width = 108;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.HeaderText = "Categoria";
            gridViewTextBoxColumn16.Name = "Categoria";
            gridViewTextBoxColumn16.Width = 115;
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.HeaderText = "Stock";
            gridViewDecimalColumn10.Name = "Stock";
            gridViewDecimalColumn10.Width = 94;
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.HeaderText = "Costo";
            gridViewDecimalColumn11.Name = "Costo";
            gridViewDecimalColumn11.Width = 74;
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.HeaderText = "Valor de Inventario";
            gridViewDecimalColumn12.Name = "ValorInventario";
            gridViewDecimalColumn12.Width = 134;
            this.MasterTemplate.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewDecimalColumn10,
            gridViewDecimalColumn11,
            gridViewDecimalColumn12});
            this.MasterTemplate.MasterTemplate.EnableFiltering = true;
            this.MasterTemplate.MasterTemplate.ShowRowHeaderColumn = false;
            this.MasterTemplate.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.MasterTemplate.Name = "MasterTemplate";
            this.MasterTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MasterTemplate.Size = new System.Drawing.Size(959, 351);
            this.MasterTemplate.TabIndex = 1;
            this.MasterTemplate.Text = "radGridView1";
            // 
            // radLabel6
            // 
            this.radLabel6.AutoSize = false;
            this.radLabel6.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.radLabel6.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabel6.Location = new System.Drawing.Point(267, 41);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(389, 71);
            this.radLabel6.TabIndex = 8;
            this.radLabel6.Text = "Inventario";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bIngresoMercancia
            // 
            this.bIngresoMercancia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bIngresoMercancia.Location = new System.Drawing.Point(12, 478);
            this.bIngresoMercancia.Name = "bIngresoMercancia";
            this.bIngresoMercancia.Size = new System.Drawing.Size(155, 33);
            this.bIngresoMercancia.TabIndex = 9;
            this.bIngresoMercancia.Text = "Ingreso de Mercancia";
            this.bIngresoMercancia.Click += new System.EventHandler(this.bIngresoMercancia_Click);
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton2.Location = new System.Drawing.Point(173, 478);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(155, 33);
            this.radButton2.TabIndex = 9;
            this.radButton2.Text = "Salida de Mercancia";
            // 
            // bKardex
            // 
            this.bKardex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bKardex.Location = new System.Drawing.Point(334, 478);
            this.bKardex.Name = "bKardex";
            this.bKardex.Size = new System.Drawing.Size(155, 33);
            this.bKardex.TabIndex = 9;
            this.bKardex.Text = "Kardex";
            this.bKardex.Click += new System.EventHandler(this.bKardex_Click);
            // 
            // bArticulos
            // 
            this.bArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bArticulos.Location = new System.Drawing.Point(495, 478);
            this.bArticulos.Name = "bArticulos";
            this.bArticulos.Size = new System.Drawing.Size(155, 33);
            this.bArticulos.TabIndex = 9;
            this.bArticulos.Text = "Lista de Articulos";
            this.bArticulos.Click += new System.EventHandler(this.bArticulos_Click);
            // 
            // bMovimientos
            // 
            this.bMovimientos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bMovimientos.Location = new System.Drawing.Point(656, 478);
            this.bMovimientos.Name = "bMovimientos";
            this.bMovimientos.Size = new System.Drawing.Size(155, 33);
            this.bMovimientos.TabIndex = 9;
            this.bMovimientos.Text = "Movimientos";
            // 
            // bSalir
            // 
            this.bSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSalir.Location = new System.Drawing.Point(817, 478);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(155, 33);
            this.bSalir.TabIndex = 9;
            this.bSalir.Text = "Salir";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 517);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bMovimientos);
            this.Controls.Add(this.bArticulos);
            this.Controls.Add(this.bKardex);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.bIngresoMercancia);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.MasterTemplate);
            this.Controls.Add(this.radTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIngresoMercancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton bIngresoMercancia;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton bKardex;
        private Telerik.WinControls.UI.RadButton bArticulos;
        private Telerik.WinControls.UI.RadButton bMovimientos;
        private Telerik.WinControls.UI.RadButton bSalir;
    }
}