namespace Suite_FHFSoft
{
    partial class Login
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.bSalir = new Telerik.WinControls.UI.RadButton();
            this.bEntrar = new Telerik.WinControls.UI.RadButton();
            this.Password = new Telerik.WinControls.UI.RadTextBox();
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox1.Controls.Add(this.bSalir);
            this.radGroupBox1.Controls.Add(this.bEntrar);
            this.radGroupBox1.Controls.Add(this.Password);
            this.radGroupBox1.Controls.Add(this.txtUsername);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(275, 154);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Opacity = 1D;
            this.radGroupBox1.Size = new System.Drawing.Size(313, 187);
            this.radGroupBox1.TabIndex = 0;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(184, 138);
            this.bSalir.Name = "bSalir";
            // 
            // 
            // 
            this.bSalir.RootElement.Opacity = 1D;
            this.bSalir.Size = new System.Drawing.Size(87, 24);
            this.bSalir.TabIndex = 2;
            this.bSalir.Text = "Cancel";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bEntrar
            // 
            this.bEntrar.BackgroundImage = global::Suite_FHFSoft.Properties.Resources.ILogin;
            this.bEntrar.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.bEntrar.ForeColor = System.Drawing.Color.Transparent;
            this.bEntrar.Image = global::Suite_FHFSoft.Properties.Resources.ILogin;
            this.bEntrar.Location = new System.Drawing.Point(71, 129);
            this.bEntrar.Name = "bEntrar";
            // 
            // 
            // 
            this.bEntrar.RootElement.Opacity = 9D;
            this.bEntrar.Size = new System.Drawing.Size(87, 44);
            this.bEntrar.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(108, 85);
            this.Password.Name = "Password";
            // 
            // 
            // 
            this.Password.RootElement.RippleAnimationColor = System.Drawing.Color.Transparent;
            this.Password.Size = new System.Drawing.Size(163, 20);
            this.Password.TabIndex = 1;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.Password.GetChildAt(0).GetChildAt(0))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.Password.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(108, 49);
            this.txtUsername.Name = "txtUsername";
            // 
            // 
            // 
            this.txtUsername.RootElement.RippleAnimationColor = System.Drawing.Color.Transparent;
            this.txtUsername.Size = new System.Drawing.Size(163, 20);
            this.txtUsername.TabIndex = 1;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtUsername.GetChildAt(0).GetChildAt(0))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.txtUsername.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(10, 87);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(82, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Contraseña";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(29, 51);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(63, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Usuario";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.White;
            this.radLabel3.Location = new System.Drawing.Point(285, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(286, 43);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Suite FHFSOFT";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Suite_FHFSoft.Properties.Resources.MundoTeclado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 539);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.8D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox Password;
        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton bEntrar;
        private Telerik.WinControls.UI.RadButton bSalir;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
