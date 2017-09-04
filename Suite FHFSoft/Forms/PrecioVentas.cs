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
    public partial class PrecioVentas : Form
    {
        public string vForm;
        public int vArticuloID = 0;
        int PrecioID = 0;
        int vOpt = 0;
        DataTable dtPrecios = new DataTable();
        public PrecioVentas()
        {
            InitializeComponent();
        }

        private void PrecioVentas_Load(object sender, EventArgs e)
        {
            dtPrecios = C.SQL("ARTICULOSPRECIOS_L " + vArticuloID);
            lblArticulo.Text = dtPrecios.Rows[0]["Articulo"].ToString();
            if (dtPrecios.Rows[0]["R"].ToString() == "0")
            {
                GRD.DataSource = dtPrecios;
            }
            

        }


        private void PrecioVentas_Load_1(object sender, EventArgs e)
        {

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bDeshacer_Click(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {


            string FechaHora = Fecha.Text + " " + Hora.Value.ToString().Substring(Hora.Value.ToString().IndexOf(" "), Hora.Value.ToString().Length - Hora.Value.ToString().IndexOf(" "));


 
             


            dtPrecios = C.SQL("ARTICULOSPRECIOS_M " + vOpt + C.QII + PrecioID + C.QII+ vArticuloID + C.QII + Precio.Value + C.QII + 1 + C.QIS +
                                FechaHora.Replace("p.m.", "PM").Replace("a.m.", "AM") + C.QSI + C.vUserID );
            GRD.DataSource = dtPrecios;

            bNuevo_Click(null, null);
            MessageBox.Show("Guardado Con Exito",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void lblArticulo_Click(object sender, EventArgs e)
        {

        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            Fecha.Text = "";
            Hora.Text = "";
            Precio.Value = 0;

        }
    }
}
