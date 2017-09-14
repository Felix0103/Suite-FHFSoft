using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suite_FHFSoft
{
    public partial class Usuario : Form
    {
        DataTable dtUsuarios = new DataTable();
        int vUsuarioID = 0;
        int vOpt = 0;
        public Usuario()
        {
            InitializeComponent();
        }


        private void Usuario_Load(object sender, EventArgs e)
        {
            FillCombo();
            FillGrid();
            ClearUsuario();
        }

        private void ClearUsuario()
        {
            vUsuarioID = 0;
            Nombre.Text = "";
            Apellido.Text = "";
            TelefonoR.Value = "";
            Celular.Value = "";
            PaisID.Text = "";
            ProvinciaID.Text = "";
            Direccion.Text = "";
            Email.Text = "";
            ComisionPorc.Value = 0;
            PerfilID.Text = "";
            User.Text = "";
            PassWord.Text = "";
            CofPassWord.Text = "";
            Activo.CheckState = CheckState.Checked;
            bEditar.Enabled = false;
            bGuardar.Enabled = true;
        }
        void FillCombo()
        {
            PerfilID.DataSource = C.SQL("USERPROFILE_L ");
            PerfilID.DisplayMember = "Detalle";
            PerfilID.ValueMember = "UserProfileID";
        

            PaisID.DisplayMember = "Descripcion";
            PaisID.ValueMember = "PaisID";
            PaisID.DataSource = C.SQL("Pais_L");



        }

        private void FillGrid()
        {
            dtUsuarios = C.SQL("[USUARIOS_L] ");
            GRD.DataSource = dtUsuarios;

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bNuevo_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Creando";
            ClearUsuario();
            vOpt = 0;
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Editando";
            UnlockField();
            bEditar.Enabled = false;
            bGuardar.Enabled = true;
            vOpt = 1;
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            lblStatus.Text = "Editable";
            vUsuarioID = C.Cint(GRD.CurrentRow.Cells[0].Value.ToString());
            Putdata();
            User.ReadOnly = true;
        }

        private void Putdata()
        {
            dtUsuarios.PrimaryKey = new DataColumn[] {dtUsuarios.Columns["UsuarioID"] };

            DataRow vRow = dtUsuarios.Rows.Find(vUsuarioID);


            Nombre.Text = vRow["Nombre"].ToString();
            Apellido.Text = vRow["Apellido"].ToString();
            TelefonoR.Text = vRow["Telefono"].ToString();
            Celular.Text = vRow["Celular"].ToString();
            PaisID.SelectedValue = C.Cint(vRow["PaisID"].ToString());
            ProvinciaID.SelectedValue = C.Cint(vRow["ProvinciaID"].ToString());
            Direccion.Text = vRow["Direccion"].ToString();
            Email.Text = vRow["Email"].ToString(); 
            ComisionPorc.Value = Convert.ToDecimal(vRow["Comicion"].ToString());
            PerfilID.SelectedValue = Convert.ToInt64(vRow["UserProfileID"].ToString()); 
            User.Text = vRow["UserName"].ToString();
            PassWord.Text = vRow["Password"].ToString();
            CofPassWord.Text = vRow["Password"].ToString();
            Activo.CheckState =(vRow["Active"].ToString()=="1"? CheckState.Checked: CheckState.Unchecked)  ;
            bEditar.Enabled = true;
            bGuardar.Enabled = false;
            lockField();

        }

        private void lockField()
        {
            Nombre.ReadOnly = true;
            Apellido.ReadOnly = true;
            TelefonoR.ReadOnly = true;
            Celular.ReadOnly = true;
            PaisID.ReadOnly = true;
            ProvinciaID.ReadOnly = true;
            Direccion.ReadOnly = true;
            Email.ReadOnly = true;
            ComisionPorc.ReadOnly = true;
            PerfilID.ReadOnly = true;
            User.ReadOnly = true;
            PassWord.ReadOnly = true;
            CofPassWord.ReadOnly = true;
            Activo.ReadOnly = true;
        }

        private void UnlockField()
        {
            Nombre.ReadOnly = false;
            Apellido.ReadOnly = false;
            TelefonoR.ReadOnly = false;
            Celular.ReadOnly = false;
            PaisID.ReadOnly = false;
            ProvinciaID.ReadOnly = false;
            Direccion.ReadOnly = false;
            Email.ReadOnly = false;
            ComisionPorc.ReadOnly = false;
            PerfilID.ReadOnly = false;
            User.ReadOnly = false;
            PassWord.ReadOnly = false;
            CofPassWord.ReadOnly = false;
            Activo.ReadOnly = false;
        }
        private void PaisID_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ProvinciaID.DisplayMember = "Descripcion";
            ProvinciaID.ValueMember = "ProvinciaID";
            ProvinciaID.DataSource = C.SQL("Provincia_L " + (PaisID.SelectedValue == null ? "0" : PaisID.SelectedValue.ToString()));

            ProvinciaID.Text = "";
        }

        private void bDeshacer_Click(object sender, EventArgs e)
        {
            if(vUsuarioID==0)
            {
                ClearUsuario();
            }
            else
            {
                Putdata();
            }
        }

        private bool validar()
        {
            if(Nombre.Text.Length==0)
            {
                MessageBox.Show("El Campo nombre esta vacio",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Nombre.Focus();
                return false;
            }

            if (Apellido.Text.Length == 0)
            {
                MessageBox.Show("El Campo Apellido esta vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Apellido.Focus();
                return false;
            }

            if (PaisID.Text.Length == 0 || PaisID.SelectedValue ==null)
            {
                MessageBox.Show("El Campo Pais esta vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PaisID.Focus();
                return false;
            }

            if (ProvinciaID.Text.Length == 0 || ProvinciaID.SelectedValue == null)
            {
                MessageBox.Show("El Campo Provincia esta vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProvinciaID.Focus();
                return false;
            }

            if (PerfilID.Text.Length == 0 || PerfilID.SelectedValue == null)
            {
                MessageBox.Show("El Campo Prefil esta vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PerfilID.Focus();
                return false;
            }

            if (User.Text.Length == 0)
            {
                MessageBox.Show("El Campo Usuario esta vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                User.Focus();
                return false;
            }

            if (PassWord.Text.Length == 0)
            {
                MessageBox.Show("El Campo Contraseña esta vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PassWord.Focus();
                return false;
            }
            if (CofPassWord.Text.Length == 0)
            {
                MessageBox.Show("El Campo Confirmar Contraseña esta vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CofPassWord.Focus();
                return false;
            }

            if (CofPassWord.Text != PassWord.Text)
            {
                MessageBox.Show("La Contraseña no coinciden favor confirme", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PassWord.Focus();
                return false;
            }

            return true;
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {

            if (!validar()) { return; }
            string vSqlstring = "";

            vSqlstring = " USUARIOS_M " + vOpt + C.QII + vUsuarioID + C.QIS + Nombre.Text + C.QSS + Apellido.Text + C.QSS + User.Text + C.QSS + PassWord.Text+ C.QSI +
                            ProvinciaID.SelectedValue + C.QII + PaisID.SelectedValue + C.QIS + Direccion.Text + C.QSS + TelefonoR.Text + C.QSS + Celular.Text + C.QSS +
                            Email.Text + C.QSI + ComisionPorc.Value + C.QII + PerfilID.SelectedValue + C.QII + (Activo.Checked==true?1:0);
            dtUsuarios = C.SQL(vSqlstring);
            GRD.DataSource = dtUsuarios;
            bNuevo_Click(null, null);

        }
    }
}
