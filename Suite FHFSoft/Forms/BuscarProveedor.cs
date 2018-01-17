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
    public partial class BuscarProveedor : Form
    {
        public string vForm = "";
        public BuscarProveedor()
        {
            InitializeComponent();
        }

        private void FillGrid()
        {
            GRD.DataSource = C.SQL("Proveedores_L");
        }
        private void BuscarProveedor_Load(object sender, EventArgs e)
        {
            FillGrid();

        }

        private void MasterTemplate_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            for (int i = 0; i <= Application.OpenForms.Count - 1; i++)
            {
                if (Application.OpenForms[i].Name == vForm)
                {
                    if (vForm == "EntradaPedidos")
                    {
                        ((EntradaPedidos)Application.OpenForms[i]).vProveedorID = int.Parse(GRD.CurrentRow.Cells[0].Value.ToString());
                        this.Close();
                    }
                    else if (vForm == "IngresoMercancia")
                    {
                        ((IngresoMercancia)Application.OpenForms[i]).vProveedorID = int.Parse(GRD.CurrentRow.Cells[0].Value.ToString());
                        this.Close();
                    }
                }
            }
        }

        private void BuscarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                if(int.Parse(GRD.CurrentRow.Cells[0].Value.ToString())>0)
                {
                    MasterTemplate_CellDoubleClick(null, null);
                }
                else
                {
                    MessageBox.Show("Selecione un Proveedor",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
