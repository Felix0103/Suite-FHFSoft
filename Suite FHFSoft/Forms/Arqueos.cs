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
    public partial class Arqueos : Form
    {
        DataTable dtArqueos = new DataTable();
        public Arqueos()
        {
            InitializeComponent();
        }

        private void Arqueos_Load(object sender, EventArgs e)
        {
            FillCombo();
            Date2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            Date1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            AlmacenID.SelectedValue = null;
            UsuarioID.SelectedValue = null;
            FillGrid();
        }

        private void FillCombo()
        {
            AlmacenID.DisplayMember = "Descripcion";
            AlmacenID.ValueMember = "SucursalID";
            AlmacenID.DataSource = C.SQL("SUCURSAL_L " + C.vPerfilID);

            UsuarioID.DisplayMember = "NombreCompleto";
            UsuarioID.ValueMember = "usuarioid";
            UsuarioID.DataSource = C.SQL("USUARIOS_L");

        }

        private void FillGrid()
        {
            dtArqueos = C.SQL("ARQUEOS_L "  + (Date1.Value.Year == 1 ? "NULL" : "'" + Date1.Value.Date.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + "'") + C.QII
                    + (Date2.Value.Year == 1 ? "NULL" : "'" + Date2.Value.Date.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + "'") + C.QII +
                (AlmacenID.SelectedValue == null ? "NULL" : AlmacenID.SelectedValue.ToString()) + C.QII + (UsuarioID.SelectedValue == null ? "NULL" : UsuarioID.SelectedValue.ToString()));
            GRD.DataSource = dtArqueos;

        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           

            for (int i = 0; i <= Application.OpenForms.Count - 1; i++)
            {
                if (Application.OpenForms[i].Name == "ArqueoCaja")
                {
                    ((ArqueoCaja)Application.OpenForms[i]).vArqueoID = C.Cint(GRD.CurrentRow.Cells[0].Value.ToString());
                    ((ArqueoCaja)Application.OpenForms[i]).COMPLETE();
                    ((ArqueoCaja)Application.OpenForms[i]).BringToFront();

                    return;
                }
            }

            ArqueoCaja form = new ArqueoCaja();
            form.vArqueoID = C.Cint(GRD.CurrentRow.Cells[0].Value.ToString());
            form.MdiParent = MainMenu.ActiveForm;
            form.Show();
        }
    }
}
