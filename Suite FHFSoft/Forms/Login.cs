using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Runtime.InteropServices;
using Suite_FHFSoft;
using System.Data.SqlClient;
using System.Configuration;



namespace Suite_FHFSoft
{


    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        DataTable dtLogin = new DataTable();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Login()
        {
           
            InitializeComponent();
        }


        private void bLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                bLogin_Click(null, null);
            }


            if (e.KeyValue == 112)
            {
                User.Text = Properties.Settings.Default.USER1;
                Password.Text = Properties.Settings.Default.PASS1;
                bLogin_Click(null, null);
            }
        }
    }
}
