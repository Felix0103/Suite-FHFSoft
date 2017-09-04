using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace Suite_FHFSoft
{

    
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = C.SQL("[LOGIN_L] '" + Username.Text + C.QSS + Password.Text + C.QS);
            DataRow vRow = dtLogin.Rows[0];
            if (vRow["RESULT"].ToString() == "0")
            {
                Username.Text = "";
                Password.Text = "";
                C.vPerfilID = C.Cint(vRow["UserProfileID"].ToString());
                C.vUserName = vRow["Nombre"].ToString() + " " + vRow["Apellido"].ToString();
                C.vUserID = C.Cint(vRow["UsuarioID"].ToString());
                C.vSucursalID= C.Cint(vRow["SucursalID"].ToString());
                C.vProfileName = vRow["PerfilName"].ToString();
                C.vSucursalName = vRow["SucursalName"].ToString(); 
                MainMenu vMenu = new MainMenu();
                vMenu.SetRibbon(dtLogin);
                vMenu.setStatus();
                vMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(dtLogin.Rows[0]["MSGBOX"].ToString(),Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
            {
                Username.Text = Properties.Settings.Default.USER1;
                Password.Text = Properties.Settings.Default.PASS1;

                bLogin_Click(null, null);
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            DateTime Licencia = C.Cdate(Seguridad.DesEncriptar(C.SQL("ini_L").Rows[0][0].ToString()));
            if (Licencia < DateTime.Today)
            {
                MessageBox.Show("Su Lcencia esta Vencida, Favor contactar a su Representante de Suite FHFSoft.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Username.ReadOnly = true;
                Password.ReadOnly = true;
            }
            else if ((Licencia - DateTime.Today).TotalDays < 31)
            {
                var dias = (Licencia - DateTime.Today).TotalDays;
                MessageBox.Show("Solo le quedan " + dias.ToString() + " Dias de vigencia de su Licencia, Favor contactar a un Representante de Suite FHFSoft.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
