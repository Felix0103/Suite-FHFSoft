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
    public partial class BuscarOrdenCompras : Form
    {
        public string vForm = "";
        public BuscarOrdenCompras()
        {
            InitializeComponent();
        }
        private void FillGrid()
        {
            GRD.DataSource = C.SQL("ORDENTOINGRESO_L 1," + C.vPerfilID);
        }

        private void BuscarOrdenCompras_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

    

        private void BuscarOrdenCompras_Load_1(object sender, EventArgs e)
        {

        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            for (int i = 0; i <= Application.OpenForms.Count - 1; i++)
            {
                if (Application.OpenForms[i].Name == vForm)
                {
                  if (vForm == "IngresoMercancia")
                    {
                        ((IngresoMercancia)Application.OpenForms[i]).vOrdenID = int.Parse(GRD.CurrentRow.Cells[0].Value.ToString());
                        this.Close();
                        break;
                    }
                }
            }
        }

        private void BuscarOrdenCompras_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                if (int.Parse(GRD.CurrentRow.Cells[0].Value.ToString()) > 0)
                {
                    GRD_CellDoubleClick(null, null);
                }
                else
                {
                    MessageBox.Show("Selecione una Orden De Compras", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
