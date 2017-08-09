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
        public Usuario()
        {
            InitializeComponent();
        }

        private void radGroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        void FillGrid()
        {
            PerfilID.DataSource = C.SQL("USERPROFILE_L ");
            PerfilID.DisplayMember = "Detalle";
            PerfilID.ValueMember = "UserProfileID";
            PerfilID.SelectedValue = null;

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GRD_Click(object sender, EventArgs e)
        {

        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Creando";
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Editando";
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            lblStatus.Text = "Editable";
        }
    }
}
