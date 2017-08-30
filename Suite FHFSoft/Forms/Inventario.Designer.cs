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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.MasterTemplate = new Telerik.WinControls.UI.RadGridView();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
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
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "Codigo";
            gridViewTextBoxColumn1.Width = 104;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "Articulo";
            gridViewTextBoxColumn2.Name = "Articulo";
            gridViewTextBoxColumn2.Width = 311;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "Marca";
            gridViewTextBoxColumn3.Name = "Marca";
            gridViewTextBoxColumn3.Width = 108;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "Categoria";
            gridViewTextBoxColumn4.Name = "Categoria";
            gridViewTextBoxColumn4.Width = 115;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.HeaderText = "Stock";
            gridViewDecimalColumn1.Name = "Stock";
            gridViewDecimalColumn1.Width = 94;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.HeaderText = "Costo";
            gridViewDecimalColumn2.Name = "Costo";
            gridViewDecimalColumn2.Width = 74;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.HeaderText = "Valor de Inventario";
            gridViewDecimalColumn3.Name = "ValorInventario";
            gridViewDecimalColumn3.Width = 134;
            this.MasterTemplate.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3});
            this.MasterTemplate.MasterTemplate.EnableFiltering = true;
            this.MasterTemplate.MasterTemplate.ShowRowHeaderColumn = false;
            this.MasterTemplate.MasterTemplate.ViewDefinition = tableViewDefinition1;
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
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton1.Location = new System.Drawing.Point(12, 478);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(155, 33);
            this.radButton1.TabIndex = 9;
            this.radButton1.Text = "Ingreso de Mercancia";
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
            // radButton3
            // 
            this.radButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton3.Location = new System.Drawing.Point(334, 478);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(155, 33);
            this.radButton3.TabIndex = 9;
            this.radButton3.Text = "Kardex";
            // 
            // radButton4
            // 
            this.radButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton4.Location = new System.Drawing.Point(495, 478);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(155, 33);
            this.radButton4.TabIndex = 9;
            this.radButton4.Text = "Lista de Articulos";
            // 
            // radButton5
            // 
            this.radButton5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton5.Location = new System.Drawing.Point(656, 478);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(155, 33);
            this.radButton5.TabIndex = 9;
            this.radButton5.Text = "Movimientos";
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
            this.Controls.Add(this.radButton5);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.MasterTemplate);
            this.Controls.Add(this.radTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadButton radButton5;
        private Telerik.WinControls.UI.RadButton bSalir;
    }
}