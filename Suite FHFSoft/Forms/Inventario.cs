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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void bIngresoMercancia_Click(object sender, EventArgs e)
        {
            EntradaPedidos frm = new EntradaPedidos();
            frm.Show(this);
        }
    }
}
