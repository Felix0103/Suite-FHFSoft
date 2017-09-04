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
    public partial class Proveedor : Form
    {
        int vProveedorID=0;
        int vOpt = 0;
        DataTable dtProveedor = new DataTable();
        public Proveedor()
        {
            InitializeComponent();
        }



        #region METODOS

        private void FillCombo()
        {
            PaisID.DisplayMember = "Descripcion";
            PaisID.ValueMember = "PaisID";
            PaisID.DataSource = C.SQL("Pais_L");

        }
        private void FillGrid()
        {
            dtProveedor = C.SQL("proveedores_L");
            GRD.DataSource = dtProveedor;

        }

        private bool Validacion()
        {
            if (Nombre.Text.Length == 0)
            {
                MessageBox.Show("Debes Digitar un Nombre de Cliente");
                Nombre.Focus();
                return false;
            }

            return true;
        }
        private void setNewCliente()
        {
            lblStatus.Text = "Creando";
            vProveedorID = 0;
            vOpt = 0;
            Codigo.Text = "";
            Nombre.Text = "";
            Contacto.Text = "";
            CargoContato.Text = "";
            Cedula.Value = "";
            Direccion.Text = "";
            PaisID.Text = "";
            ProvinciaID.Text = "";
            CiudadID.Text = "";
            Telefono.Value = "";
            Celular.Value = "";
            Estatus.Checked = true;
            Fecha.Value = DateTime.Today;
            Email.Text = "";
            bEditar.Enabled = false;
            bGuardar.Enabled = true;
            bDeshacer.Enabled = true;
            setEditar();


        }

        private void setEditar()
        {

            Nombre.ReadOnly = false;
            Contacto.ReadOnly = false;
            Cedula.ReadOnly = false;
            CargoContato.ReadOnly = false;
            Direccion.ReadOnly = false;
            PaisID.ReadOnly = false;
            ProvinciaID.ReadOnly = false;
            CiudadID.ReadOnly = false;
            Telefono.ReadOnly = false;
            Celular.ReadOnly = false;
            Estatus.ReadOnly = false;
            Email.ReadOnly = false;
            bNuevo.Enabled = true;
            bEditar.Enabled = false;
            bGuardar.Enabled = true;
            bDeshacer.Enabled = true;


        }

        private void noEditar()
        {

            Nombre.ReadOnly = true;
            Contacto.ReadOnly = true;
            Cedula.ReadOnly = true;
            CargoContato.ReadOnly = true;
            Direccion.ReadOnly = true;
            PaisID.ReadOnly = true;
            ProvinciaID.ReadOnly = true;
            CiudadID.ReadOnly = true;
            Telefono.ReadOnly = true;
            Celular.ReadOnly = true;
            Estatus.ReadOnly = true;
            Email.ReadOnly = true;
            bNuevo.Enabled = true;
            bEditar.Enabled = true;
            bGuardar.Enabled = false;
            bDeshacer.Enabled = true;
        }

        private void Putdata()
        {
            try
            {
                dtProveedor.PrimaryKey = new DataColumn[] { dtProveedor.Columns["ProveedorID"] };
                DataRow vRow = dtProveedor.Rows.Find(vProveedorID);

                setNewCliente();
                vProveedorID = C.Cint(vRow["ProveedorID"].ToString());
                Codigo.Text = vRow["Codigo"].ToString();
                lblStatus.Text = "Editable";
                Nombre.Text = vRow["Nombre"].ToString();
                Contacto.Text = vRow["Contacto"].ToString();
                Cedula.Value = vRow["Cedula"].ToString();
                CargoContato.Text = vRow["CArgoContacto"].ToString();
                Direccion.Text = vRow["Direccion"].ToString();
                PaisID.SelectedValue = C.Cint(vRow["PaisID"].ToString());
                ProvinciaID.SelectedValue = C.Cint(vRow["ProvinciaID"].ToString());
                CiudadID.SelectedValue = C.Cint(vRow["CiudadID"].ToString());
                Telefono.Value = vRow["Telefono"].ToString();
                Celular.Value = vRow["Celular"].ToString();
                Estatus.Checked = (vRow["Estatus"].ToString() == "1" ? true : false);
                Fecha.Value = C.Cdate(vRow["FechaCreacion"].ToString());
                Email.Text = vRow["Email"].ToString();
                noEditar();

                bEditar.Enabled = true;
                bGuardar.Enabled = false;

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                setNewCliente();

            }


        }
        #endregion FINAL METODOS
        private void Proveedor_Load(object sender, EventArgs e)
        {
            FillCombo();
            FillGrid();
            bNuevo_Click(null, null);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            setNewCliente();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Editando";
            vOpt = 1;
            setEditar();
        }

        private void PaisID_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ProvinciaID.DisplayMember = "Descripcion";
            ProvinciaID.ValueMember = "ProvinciaID";
            ProvinciaID.DataSource = C.SQL("Provincia_L " + (PaisID.SelectedValue == null ? "0" : PaisID.SelectedValue.ToString()));

            ProvinciaID.Text = "";
        }

        private void ProvinciaID_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            CiudadID.DisplayMember = "Descripcion";
            CiudadID.ValueMember = "CiudadID";
            CiudadID.DataSource = C.SQL("Ciudades_L " + (ProvinciaID.SelectedValue == null ? "0" : ProvinciaID.SelectedValue.ToString()));

            CiudadID.Text = "";
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacion())
                {
                    return;
                }

                dtProveedor = C.SQL("Proveedores_M " + vOpt + C.QII + vProveedorID + C.QIS + Nombre.Text + C.QSS +  Cedula.Value + C.QSS + Contacto.Text +
                C.QSS + CargoContato.Text +  C.QSS + Telefono.Value + C.QSS + Celular.Value + C.QSS + Email.Text +C.QSS +  Direccion.Text + C.QSI +
                (PaisID.SelectedValue == null ? "NULL" : PaisID.SelectedValue) + C.QII + (ProvinciaID.SelectedValue == null ? "NULL" : ProvinciaID.SelectedValue) + C.QII +
                (CiudadID.SelectedValue == null ? "NULL" : CiudadID.SelectedValue) + C.QII + C.vUserID + C.QII + (Estatus.Checked == true ? 1 : 0));


                if (dtProveedor.Rows[0][0].ToString() == "0" && dtProveedor.Rows.Count>0)
                {
                    int v = vOpt;
                    bNuevo_Click(null, null);
                    GRD.DataSource = dtProveedor;
                    MessageBox.Show("Proveedor " + (v == 0 ? "Guardado" : "Actualizado") + " Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {

                    MessageBox.Show(dtProveedor.Rows[0][0].ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtProveedor = C.SQL("Proveedores_L ");
                    GRD.DataSource = dtProveedor;
                }


                return;


            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            vProveedorID = Convert.ToInt32(GRD.CurrentRow.Cells[0].Value);
            Putdata();
        }

        private void GRD_SelectionChanged(object sender, EventArgs e)
        {
            setNewCliente();
        }

        private void bDeshacer_Click(object sender, EventArgs e)
        {
            if (vProveedorID == 0)
            {
                setNewCliente();
            }
            else
            {
                Putdata();
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
