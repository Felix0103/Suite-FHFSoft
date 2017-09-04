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
    public partial class BuscarCliente : Form
    {
        public string vForm="";
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void FillGrid()
        {
            GRD.DataSource = C.SQL("Clientes_L");
        }
        private void BuscarCliente_Load(object sender, EventArgs e)
        {

            FillGrid();
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                }
            }
        }

        private void BuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (int.Parse(GRD.CurrentRow.Cells[0].Value.ToString()) > 0)
                {
                    GRD_CellDoubleClick(null, null);
                }
                else
                {
                    MessageBox.Show("Selecione un Cliente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    

   
    }
}
