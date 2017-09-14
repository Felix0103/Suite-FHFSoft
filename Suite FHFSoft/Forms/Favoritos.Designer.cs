namespace Suite_FHFSoft
{
    partial class Favoritos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favoritos));
            this.FavoritosList = new Telerik.WinControls.UI.RadCheckedListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            this.bGuardar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.FavoritosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // FavoritosList
            // 
            this.FavoritosList.ImageList = this.imageList1;
            this.FavoritosList.ItemSize = new System.Drawing.Size(100, 40);
            this.FavoritosList.Location = new System.Drawing.Point(12, 39);
            this.FavoritosList.Name = "FavoritosList";
            this.FavoritosList.Size = new System.Drawing.Size(586, 325);
            this.FavoritosList.TabIndex = 0;
            this.FavoritosList.Text = "radCheckedListBox1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_System_105256.png");
            this.imageList1.Images.SetKeyName(1, "if_Blue_Backup_W_66549.png");
            this.imageList1.Images.SetKeyName(2, "if_licence_49373.png");
            this.imageList1.Images.SetKeyName(3, "if_testimonials_45013.png");
            this.imageList1.Images.SetKeyName(4, "if_gear-user_532766.png");
            this.imageList1.Images.SetKeyName(5, "if_network_close_41768.png");
            this.imageList1.Images.SetKeyName(6, "if_47_973988.png");
            this.imageList1.Images.SetKeyName(7, "if_List_2290853.png");
            this.imageList1.Images.SetKeyName(8, "if_favorites_37406.png");
            this.imageList1.Images.SetKeyName(9, "1481542733_Cash_register.png");
            this.imageList1.Images.SetKeyName(10, "if_Sales-by-Payment-Method-rep_49616.png");
            this.imageList1.Images.SetKeyName(11, "if_bookmarks_list_add_18556.png");
            this.imageList1.Images.SetKeyName(12, "if_kthememgr_3472.png");
            this.imageList1.Images.SetKeyName(13, "if_folder_favorites_3668.png");
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(611, 33);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Favoritos";
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(486, 370);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(110, 24);
            this.bSalir.TabIndex = 53;
            this.bSalir.Text = "&Salir";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(370, 370);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(110, 24);
            this.bGuardar.TabIndex = 52;
            this.bGuardar.Text = "&Guardar";
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 402);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.radTitleBar1);
            this.Controls.Add(this.FavoritosList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Favoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favoritos";
            this.Load += new System.EventHandler(this.Favoritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FavoritosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckedListBox FavoritosList;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadButton bSalir;
        private Telerik.WinControls.UI.RadButton bGuardar;
    }
}