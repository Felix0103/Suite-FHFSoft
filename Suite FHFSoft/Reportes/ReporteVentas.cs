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
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

    
        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            FillCombo();
            Date1.Value = DateTime.Today;
            Date2.Value = DateTime.Today;
            AlmacenID.SelectedValue = null;
            UsuarioID.SelectedValue = null;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bImprimir_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.MdiParent = MainMenu.ActiveForm;
            frm.vReportName = "ReporteVentas.rpt";
            frm.vImprimir = 0;
            frm.vSQLString = "[VENTAS_R] " + (Date1.Value.Year == 1 ? "NULL" : "'" + Date1.Value.Date.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + "'") + C.QII +
                        (Date2.Value.Year == 1 ? "NULL" : "'" + Date2.Value.Date.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + "'") + C.QII +
                        (UsuarioID.SelectedValue == null ? "NULL" : UsuarioID.SelectedValue.ToString()) + C.QII + (AlmacenID.SelectedValue == null ? "NULL" : AlmacenID.SelectedValue.ToString());
            frm.vTitleReports = "Reporte de ventas";
            frm.SetTitle();
            frm.Show();
        }
    }
}
