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
    public partial class Configuraciones : Form
    {
        DataTable dtConfi = new DataTable();
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {
            dtConfi = C.SQL("CONFIGURACIONES_L");
            if (dtConfi.Rows.Count == 0) { return; }

            NombreEmpresa.Text = dtConfi.Rows[0]["NombreEmpresa"].ToString();
            chkFactura.Checked = (dtConfi.Rows[0]["ImprimirFactura"].ToString() == "1" ? true : false);
            ChkFActuraP.Checked = (dtConfi.Rows[0]["FacturaPequena"].ToString() == "1" ? true : false);
            Fondo.Value = Convert.ToDecimal(dtConfi.Rows[0]["MontoFondo"].ToString());

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            dtConfi = C.SQL("CONFIGURACIONES_M '" + NombreEmpresa.Text + C.QSI + (chkFactura.Checked?1:0) + C.QII + (ChkFActuraP.Checked ? 1 : 0) + C.QII + Fondo.Value);

            MessageBox.Show("Guardado",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
