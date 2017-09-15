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
        DataTable dtInventario = new DataTable();
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
            FillCombo();
            AlmacenID.SelectedValue = null;
            ArticuloId.SelectedValue = null;
            Date2.Value= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            Date1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            FillGrid();
        }

        private void FillGrid()
        {
            dtInventario = C.SQL("INVENTARIO_L " + (Date1.Value.Year == 1 ? "NULL" : "'" + Date1.Value.Date.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + "'") + C.QII +
                        (Date2.Value.Year == 1 ? "NULL" : "'" + Date2.Value.Date.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + "'") + C.QII +
                        (AlmacenID.SelectedValue == null ? "NULL" : AlmacenID.SelectedValue.ToString()) + C.QII + (ArticuloId.SelectedValue == null ? "NULL" : ArticuloId.SelectedValue.ToString()));


            GRD.DataSource = dtInventario;

            
        }

        private void FillCombo()
        {
            AlmacenID.DisplayMember = "Descripcion";
            AlmacenID.ValueMember = "SucursalID";
            AlmacenID.DataSource = C.SQL("SUCURSAL_L " + C.vPerfilID);

            ArticuloId.DisplayMember = "Descripcion";
            ArticuloId.ValueMember = "ArticuloID";
            ArticuloId.DataSource = C.SQL("[ARTICULOS_L] ");



        }
        private void bIngresoMercancia_Click(object sender, EventArgs e)
        {
            EntradaPedidos frm = new EntradaPedidos();
            frm.Show(this);
        }

        private void bArticulos_Click(object sender, EventArgs e)
        {
            C.OpenForm("Articulos");
        }

        private void bKardex_Click(object sender, EventArgs e)
        {
            C.OpenForm("Kardex");
        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
