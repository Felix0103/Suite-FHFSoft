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
        public Cliente()
        {
            InitializeComponent();
        }



        #region Metodos

        private void setNewCliente()
        {
            lblStatus.Text = "Creando";
            vClienteID = 0;
            vOpt=0;
            Nombre.Text = "";
            Apellido.Text = "";
            Cedula.Value = "";
            Descuento.Value = 0;
            LimiteCredito.Value = 0;
            Direccion.Text = "";
            ProvinciaID.Text = "";
            PaisID.Text = "";
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
            ProvinciaID.ReadOnly = false;
            PaisID.ReadOnly = false;
            CiudadID.ReadOnly = false;
            Telefono.ReadOnly = false;
            Celular.ReadOnly = false;
            Estatus.ReadOnly = false;
            Fecha.ReadOnly = false;
            Email.ReadOnly = false;
            bNuevo.Enabled = true;
            bEditar.Enabled = false;
            bGuardar.Enabled = true;
            bDeshacer.Enabled = true;


        }

        private void noEditar()
        {
           
            Nombre.ReadOnly = true;
            Apellido.ReadOnly = true;
            Cedula.ReadOnly = true;
            Descuento.ReadOnly = true;
            LimiteCredito.ReadOnly = true;
            Direccion.ReadOnly = true;
            ProvinciaID.ReadOnly = true;
            PaisID.ReadOnly = true;
            CiudadID.ReadOnly = true;
            Telefono.ReadOnly = true;
            Celular.ReadOnly = true;
            Estatus.ReadOnly = true;
            Fecha.ReadOnly = true;
            Email.ReadOnly = true;
            bNuevo.Enabled = true;
            bEditar.Enabled = true;
            bGuardar.Enabled = false;
            bDeshacer.Enabled = true;
        }



        #endregion

        #region Eventos 

        private void Cliente_Load(object sender, EventArgs e)
        {

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

        #endregion


    }
}
