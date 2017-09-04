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
    public partial class Cliente : Form
    {
        public int vClienteID = 0;
        private int vOpt = 0;
        DataTable dtClientes = new DataTable();
        public Cliente()
        {
            InitializeComponent();
        }



        #region Metodos



        private void FillGrid()
        {
            dtClientes = C.SQL("Clientes_L");
            GRD.DataSource = dtClientes;

        }
        private void setNewCliente()
        {
            lblStatus.Text = "Creando";
            vClienteID = 0;
            vOpt=0;
            Codigo.Text = "";
            Nombre.Text = "";
            Apellido.Text = "";
            Cedula.Value = "";
            Descuento.Value = 0;
            LimiteCredito.Value = 0;
            Direccion.Text = "";
            PaisID.Text = "";
            ProvinciaID.Text = "";
            TipodeComprobanteID.Text = "";
            CiudadID.Text = "";
            Telefono.Value = "";
            Celular.Value= "";
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
            
            Nombre.ReadOnly=false;
            Apellido.ReadOnly = false;
            Cedula.ReadOnly = false;
            Descuento.ReadOnly = false;
            LimiteCredito.ReadOnly = false;
            Direccion.ReadOnly = false;
            PaisID.ReadOnly = false;
            ProvinciaID.ReadOnly = false;
            CiudadID.ReadOnly = false;
            Telefono.ReadOnly = false;
            Celular.ReadOnly = false;
            Estatus.ReadOnly = false;
            Fecha.ReadOnly = false;
            Email.ReadOnly = false;
            TipodeComprobanteID.ReadOnly = false;

            bNuevo.Enabled = true;
            bEditar.Enabled = false;
            bGuardar.Enabled = true;
            bDeshacer.Enabled = true;


        }

        private void  Putdata()
        {
            try
            {
                dtClientes.PrimaryKey = new DataColumn[] { dtClientes.Columns["ClienteID"] };
                DataRow vRow = dtClientes.Rows.Find(vClienteID);

                setNewCliente();
                vClienteID = C.Cint(vRow["ClienteId"].ToString());
                Codigo.Text = vRow["Codigo"].ToString();
                lblStatus.Text = "Editable";
                Nombre.Text = vRow["Nombre"].ToString();
                Apellido.Text = vRow["Apellido"].ToString();
                Cedula.Value = vRow["Cedula"].ToString();
                Descuento.Value = vRow["descuento"].ToString();
                LimiteCredito.Value = vRow["LimiteCredito"].ToString();
                Direccion.Text = vRow["Direccion"].ToString();
                PaisID.SelectedValue = C.Cint(vRow["PaisID"].ToString());
                ProvinciaID.SelectedValue = C.Cint(vRow["ProvinciaID"].ToString());
                CiudadID.SelectedValue = C.Cint(vRow["CiudadID"].ToString());
                Telefono.Value = vRow["Telefono"].ToString();
                Celular.Value = vRow["Celular"].ToString();
                Estatus.Checked = (vRow["Estatus"].ToString() == "1" ? true : false);
                Fecha.Value = C.Cdate(vRow["FechaCreacion"].ToString());
                Email.Text = vRow["Email"].ToString();
                TipodeComprobanteID.SelectedValue= C.Cint(vRow["TipoComprobanteID"].ToString());
                noEditar();
                bEditar.Enabled = true;
                bGuardar.Enabled = false;

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message,Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);
                setNewCliente();

            }
         

        }

        private void noEditar()
        {
           
            Nombre.ReadOnly = true;
            Apellido.ReadOnly = true;
            Cedula.ReadOnly = true;
            Descuento.ReadOnly = true;
            LimiteCredito.ReadOnly = true;
            Direccion.ReadOnly = true;
            PaisID.ReadOnly = true;
            ProvinciaID.ReadOnly = true;
            CiudadID.ReadOnly = true;
            Telefono.ReadOnly = true;
            Celular.ReadOnly = true;
            Estatus.ReadOnly = true;
            Fecha.ReadOnly = true;
            Email.ReadOnly = true;
            TipodeComprobanteID.ReadOnly = true;
            bNuevo.Enabled = true;
            bEditar.Enabled = true;
            bGuardar.Enabled = false;
            bDeshacer.Enabled = true;
        }

        private void FillCombo()
        {
            PaisID.DisplayMember = "Descripcion";
            PaisID.ValueMember = "PaisID";
            PaisID.DataSource = C.SQL("Pais_L");

            TipodeComprobanteID.DisplayMember = "Descripcion";
            TipodeComprobanteID.ValueMember = "TipoComprobanteFiscalID";
            TipodeComprobanteID.DataSource = C.SQL("TIPOCOMPROBANTEFISCAL_L");

        }


        private bool Validacion()
        {
            if (Nombre.Text.Length==0)
            {
                MessageBox.Show("Debes Digitar un Nombre de Cliente");
                Nombre.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Eventos 

        private void Cliente_Load(object sender, EventArgs e)
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
                if(!Validacion())
                {
                    return;
                }

                dtClientes = C.SQL("Cliente_M " + vOpt + C.QII + vClienteID + C.QIS + Nombre.Text + C.QSS + Apellido.Text + C.QSS + Cedula.Value + C.QSI + Descuento.Value +
                C.QII + LimiteCredito.Value + C.QIS + Email.Value + C.QSS + Telefono.Value + C.QSS + Celular.Value + C.QSS + Direccion.Text + C.QSI +
                (ProvinciaID.SelectedValue == null ? "NULL" : ProvinciaID.SelectedValue) + C.QII + (PaisID.SelectedValue == null ? "NULL" : PaisID.SelectedValue) + C.QII +
                (CiudadID.SelectedValue == null ? "NULL" : CiudadID.SelectedValue) + C.QII + C.vUserID + C.QII + (Estatus.Checked == true ? 1 : 0) + C.QII +
                (TipodeComprobanteID.SelectedValue == null ? "NULL" : TipodeComprobanteID.SelectedValue));

                if  (dtClientes.Rows[0][0].ToString()=="0")
                {
                    int v = vOpt;
                    bNuevo_Click(null, null);
                    MessageBox.Show("Cliente " + (v==0?"Guardado":"Actualizado") + " Exitosamente",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    GRD.DataSource = dtClientes;
                }
                else
                {
                    
                    MessageBox.Show(dtClientes.Rows[0][0].ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtClientes = C.SQL("Clientes_L ");
                    GRD.DataSource = dtClientes;
                }

                
                return;


            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void MasterTemplate_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            
            vClienteID = Convert.ToInt32(GRD.CurrentRow.Cells[0].Value);
            Putdata();


        }

        #endregion

        private void bDeshacer_Click(object sender, EventArgs e)
        {
            if(vClienteID==0)
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

        private void MasterTemplate_SelectionChanged(object sender, EventArgs e)
        {
            setNewCliente();
        }
    }
}


