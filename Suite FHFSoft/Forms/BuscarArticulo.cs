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
    public partial class BuscarArticulo : Form
    {
        public string vForm = "";
        public BuscarArticulo()
        {
            InitializeComponent();
        }

        private void BuscarArticulo_Load(object sender, EventArgs e)
        {
            GRD.DataSource = C.SQL("Articulos_L");
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            for (int i = 0; i <= Application.OpenForms.Count - 1; i++)
            {
                if (Application.OpenForms[i].Name == vForm)
                {
                    if (vForm == "EntradaPedidos")
                    {
                        ((EntradaPedidos)Application.OpenForms[i]).vArticulo = int.Parse(GRD.CurrentRow.Cells[0].Value.ToString());
                        this.Close();
                    }
                    else if(vForm == "Facturacion")
                    {
                        ((Facturacion)Application.OpenForms[i]).vArticuloID = int.Parse(GRD.CurrentRow.Cells[0].Value.ToString());
                        this.Close();
                    }
                }
            }
        }

        private void BuscarArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==27)
            {
                this.Close();
            }

            
            if (e.KeyValue == 13)
            {
                if (GRD.CurrentRow.Cells[0].Value == null) { MessageBox.Show("Selecione un Articulo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (int.Parse(GRD.CurrentRow.Cells[0].Value.ToString()) > 0)
                {
                    GRD_CellDoubleClick(null, null);
                }
                else
                {
                    MessageBox.Show("Selecione un Articulo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
