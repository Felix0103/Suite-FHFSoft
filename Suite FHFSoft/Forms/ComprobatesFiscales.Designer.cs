namespace Suite_FHFSoft.Forms
{
    partial class ComprobanteFiscal
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.SequenciaFinal = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.SequenciaInicial = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.bEditar = new Telerik.WinControls.UI.RadButton();
            this.bDeshacer = new Telerik.WinControls.UI.RadButton();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            this.bGuardar = new Telerik.WinControls.UI.RadButton();
            this.bNuevo = new Telerik.WinControls.UI.RadButton();
            this.GRD = new Telerik.WinControls.UI.RadGridView();
            this.AreadeImpresion = new Telerik.WinControls.UI.RadTextBox();
            this.UltimaSequenciaGenerada = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.PuntodeEmision = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.DivisiondeNegocios = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.Serie = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.TipodeComprobanteID = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDeshacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreadeImpresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltimaSequenciaGenerada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuntodeEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisiondeNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Serie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipodeComprobanteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // SequenciaFinal
            // 
            this.SequenciaFinal.Location = new System.Drawing.Point(538, 158);
            this.SequenciaFinal.Mask = "d";
            this.SequenciaFinal.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.SequenciaFinal.Name = "SequenciaFinal";
            this.SequenciaFinal.Size = new System.Drawing.Size(213, 20);
            this.SequenciaFinal.TabIndex = 52;
            this.SequenciaFinal.TabStop = false;
            this.SequenciaFinal.Text = "0";
            this.SequenciaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SequenciaInicial
            // 
            this.SequenciaInicial.Location = new System.Drawing.Point(538, 133);
            this.SequenciaInicial.Mask = "d";
            this.SequenciaInicial.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.SequenciaInicial.Name = "SequenciaInicial";
            this.SequenciaInicial.Size = new System.Drawing.Size(213, 20);
            this.SequenciaInicial.TabIndex = 51;
            this.SequenciaInicial.TabStop = false;
            this.SequenciaInicial.Text = "0";
            this.SequenciaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(217, 454);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(110, 24);
            this.bEditar.TabIndex = 48;
            this.bEditar.Text = "&Editar";
            // 
            // bDeshacer
            // 
            this.bDeshacer.Location = new System.Drawing.Point(449, 454);
            this.bDeshacer.Name = "bDeshacer";
            this.bDeshacer.Size = new System.Drawing.Size(110, 24);
            this.bDeshacer.TabIndex = 49;
            this.bDeshacer.Text = "&Deshacer";
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(565, 454);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(110, 24);
            this.bSalir.TabIndex = 50;
            this.bSalir.Text = "&Salir";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(333, 454);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(110, 24);
            this.bGuardar.TabIndex = 47;
            this.bGuardar.Text = "&Guardar";
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(101, 454);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(110, 24);
            this.bNuevo.TabIndex = 46;
            this.bNuevo.Text = "&Nuevo";
            // 
            // GRD
            // 
            this.GRD.BackColor = System.Drawing.Color.White;
            this.GRD.Cursor = System.Windows.Forms.Cursors.Default;
            this.GRD.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GRD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GRD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GRD.Location = new System.Drawing.Point(12, 209);
            // 
            // 
            // 
            this.GRD.MasterTemplate.AllowAddNewRow = false;
            this.GRD.MasterTemplate.AllowDeleteRow = false;
            this.GRD.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ComprobanteFiscalID";
            gridViewTextBoxColumn1.HeaderText = "column4";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column4";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Comprobante";
            gridViewTextBoxColumn2.HeaderText = "Tipo de Comprobante";
            gridViewTextBoxColumn2.Name = "TipoComprobante";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ComprobanteCompleto";
            gridViewTextBoxColumn3.HeaderText = "Comprobante Completo";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "SequenciaInicial";
            gridViewTextBoxColumn4.HeaderText = "Sequencia Inicial";
            gridViewTextBoxColumn4.Name = "column2";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 120;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Proxima";
            gridViewTextBoxColumn5.HeaderText = "Proxima Sequencia a Generar";
            gridViewTextBoxColumn5.Name = "column3";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 200;
            this.GRD.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.GRD.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GRD.Name = "GRD";
            this.GRD.ReadOnly = true;
            this.GRD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GRD.Size = new System.Drawing.Size(762, 230);
            this.GRD.TabIndex = 44;
            this.GRD.Text = "radGridView1";
            // 
            // AreadeImpresion
            // 
            this.AreadeImpresion.Location = new System.Drawing.Point(538, 81);
            this.AreadeImpresion.MaxLength = 3;
            this.AreadeImpresion.Name = "AreadeImpresion";
            this.AreadeImpresion.Size = new System.Drawing.Size(213, 20);
            this.AreadeImpresion.TabIndex = 43;
            this.AreadeImpresion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UltimaSequenciaGenerada
            // 
            this.UltimaSequenciaGenerada.Enabled = false;
            this.UltimaSequenciaGenerada.Location = new System.Drawing.Point(379, 183);
            this.UltimaSequenciaGenerada.MaxLength = 3;
            this.UltimaSequenciaGenerada.Name = "UltimaSequenciaGenerada";
            this.UltimaSequenciaGenerada.Size = new System.Drawing.Size(93, 20);
            this.UltimaSequenciaGenerada.TabIndex = 42;
            this.UltimaSequenciaGenerada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel8
            // 
            this.radLabel8.AutoSize = false;
            this.radLabel8.Location = new System.Drawing.Point(388, 159);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(144, 18);
            this.radLabel8.TabIndex = 39;
            this.radLabel8.Text = "Sequencia Final";
            this.radLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PuntodeEmision
            // 
            this.PuntodeEmision.Location = new System.Drawing.Point(162, 134);
            this.PuntodeEmision.MaxLength = 3;
            this.PuntodeEmision.Name = "PuntodeEmision";
            this.PuntodeEmision.Size = new System.Drawing.Size(213, 20);
            this.PuntodeEmision.TabIndex = 41;
            this.PuntodeEmision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(388, 134);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(144, 18);
            this.radLabel1.TabIndex = 37;
            this.radLabel1.Text = "Sequencia Inicial";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DivisiondeNegocios
            // 
            this.DivisiondeNegocios.Location = new System.Drawing.Point(162, 108);
            this.DivisiondeNegocios.MaxLength = 2;
            this.DivisiondeNegocios.Name = "DivisiondeNegocios";
            this.DivisiondeNegocios.Size = new System.Drawing.Size(213, 20);
            this.DivisiondeNegocios.TabIndex = 40;
            this.DivisiondeNegocios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel5
            // 
            this.radLabel5.AutoSize = false;
            this.radLabel5.Location = new System.Drawing.Point(388, 82);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(144, 18);
            this.radLabel5.TabIndex = 36;
            this.radLabel5.Text = "Area de Impresion";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Serie
            // 
            this.Serie.Location = new System.Drawing.Point(162, 82);
            this.Serie.MaxLength = 1;
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(213, 20);
            this.Serie.TabIndex = 35;
            this.Serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel7
            // 
            this.radLabel7.AutoSize = false;
            this.radLabel7.Location = new System.Drawing.Point(205, 184);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(168, 18);
            this.radLabel7.TabIndex = 34;
            this.radLabel7.Text = "Ultima Sequencia Generada";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Location = new System.Drawing.Point(12, 109);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(144, 18);
            this.radLabel3.TabIndex = 33;
            this.radLabel3.Text = "Division de Negocios";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.Location = new System.Drawing.Point(12, 135);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(144, 18);
            this.radLabel4.TabIndex = 32;
            this.radLabel4.Text = "Punto de Emision";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TipodeComprobanteID
            // 
            this.TipodeComprobanteID.Location = new System.Drawing.Point(538, 107);
            this.TipodeComprobanteID.Name = "TipodeComprobanteID";
            this.TipodeComprobanteID.Size = new System.Drawing.Size(213, 20);
            this.TipodeComprobanteID.TabIndex = 45;
            // 
            // radLabel6
            // 
            this.radLabel6.AutoSize = false;
            this.radLabel6.Location = new System.Drawing.Point(388, 107);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(144, 18);
            this.radLabel6.TabIndex = 31;
            this.radLabel6.Text = "Tipo de Comprobante";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(12, 83);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(144, 18);
            this.radLabel2.TabIndex = 38;
            this.radLabel2.Text = "Serie";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(794, 40);
            this.radTitleBar1.TabIndex = 30;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Comprobante Fiscal";
            // 
            // ComprobanteFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 490);
            this.Controls.Add(this.SequenciaFinal);
            this.Controls.Add(this.SequenciaInicial);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bDeshacer);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.GRD);
            this.Controls.Add(this.AreadeImpresion);
            this.Controls.Add(this.UltimaSequenciaGenerada);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.PuntodeEmision);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.DivisiondeNegocios);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.Serie);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.TipodeComprobanteID);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprobanteFiscal";
            this.Text = "Comprobante Fiscal";
            this.Load += new System.EventHandler(this.ComprobatesFiscales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDeshacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreadeImpresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltimaSequenciaGenerada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuntodeEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisiondeNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Serie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipodeComprobanteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMaskedEditBox SequenciaFinal;
        private Telerik.WinControls.UI.RadMaskedEditBox SequenciaInicial;
        private Telerik.WinControls.UI.RadButton bEditar;
        private Telerik.WinControls.UI.RadButton bDeshacer;
        private Telerik.WinControls.UI.RadButton bSalir;
        private Telerik.WinControls.UI.RadButton bGuardar;
        private Telerik.WinControls.UI.RadButton bNuevo;
        private Telerik.WinControls.UI.RadGridView GRD;
        private Telerik.WinControls.UI.RadTextBox AreadeImpresion;
        private Telerik.WinControls.UI.RadTextBox UltimaSequenciaGenerada;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadTextBox PuntodeEmision;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox DivisiondeNegocios;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox Serie;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList TipodeComprobanteID;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
    }
}