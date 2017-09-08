namespace Suite_FHFSoft
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.vCerrarSesion = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // radRibbonBar1
            // 
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRibbonBar1.ImageList = this.imageList1;
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.Size = new System.Drawing.Size(1087, 151);
            this.radRibbonBar1.StartButtonImage = global::Suite_FHFSoft.Properties.Resources.if_Creative_Suite_63827;
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.vCerrarSesion});
            this.radRibbonBar1.TabIndex = 3;
            this.radRibbonBar1.Text = "Suite FHFSoft";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "Suite FHFSoft";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radRibbonBar1.GetChildAt(0).GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radRibbonBar1.GetChildAt(0).GetChildAt(0))).ImageIndex = 1;
            // 
            // vCerrarSesion
            // 
            this.vCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("vCerrarSesion.Image")));
            this.vCerrarSesion.ImageIndex = 5;
            this.vCerrarSesion.Name = "vCerrarSesion";
            this.vCerrarSesion.Text = "Cerrar sesión";
            this.vCerrarSesion.Click += new System.EventHandler(this.vCerrarSesion_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 560);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1087, 26);
            this.radStatusStrip1.TabIndex = 5;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 586);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suite FHFSoft";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadMenuButtonItem vCerrarSesion;
    }
}