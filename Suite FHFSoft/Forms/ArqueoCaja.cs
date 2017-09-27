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
    public partial class ArqueoCaja : Form
    {
        DataTable dtFacturas = new DataTable();
        public int vArqueoID = 0;
        string Notas = "";
        public ArqueoCaja()
        {
            InitializeComponent();
        }

        private void ArqueoCaja_Load(object sender, EventArgs e)
        {
            if (vArqueoID == 0) { FillGrid(); lblStatus.Text = "Creando"; }
            else{ COMPLETE(); lblStatus.Text = "Guardado"; }
            
            
        }

        private void limpiar()
        {
            MontoEfectivo.Value = 0;
            MontoTarjeta.Value = 0;
            MontoCheque.Value = 0;
            MontoCredito.Value = 0;
            TotalVentas.Value = 0;
            Efectivo.Value = 0;
            TarjetaCheques.Value = 0;
            Credito.Value = 0;
            Cheque.Value = 0;
            FondoNuevo.Value = 0;
            TotalFondo.Value = 0;

            EfectivoEnCaja.Value = (Convert.ToDecimal(MontoEfectivo.Value) + Convert.ToDecimal(TotalEfectivoCobro.Value) + Convert.ToDecimal(TotalFondo.Value)) -
              Convert.ToDecimal(GastosCaja.Value);
            Calculate();
        }

        private void FillGrid()
        {
            limpiar();
            dtFacturas = C.SQL("Arqueo_C ");
            grdFacturas.DataSource = dtFacturas;
            if (dtFacturas.Rows.Count == 0) { return; }
            

            DataRow vRow = dtFacturas.Rows[0];
            MontoEfectivo.Value = vRow["Efectivo"].ToString();
            MontoTarjeta.Value= vRow["Tarjeta"].ToString();
            MontoCheque.Value = vRow["Cheque"].ToString();
            MontoCredito.Value = vRow["Credito"].ToString();
            TotalFondo.Value = vRow["FondoAnterior"].ToString();

            TotalVentas.Value = Convert.ToDecimal(vRow["Efectivo"].ToString()) + Convert.ToDecimal(vRow["Tarjeta"].ToString()) +
                Convert.ToDecimal(vRow["Cheque"].ToString()) + Convert.ToDecimal(vRow["Credito"].ToString());

            EfectivoEnCaja.Value=(Convert.ToDecimal(MontoEfectivo.Value) + Convert.ToDecimal(TotalEfectivoCobro.Value) + Convert.ToDecimal(TotalFondo.Value)) -
                Convert.ToDecimal(GastosCaja.Value);

            Calculate();
        }

        public void COMPLETE()
        {
            limpiar();
            dtFacturas = C.SQL("[ARQUEO_L] " + vArqueoID );
            grdFacturas.DataSource = dtFacturas;
            if (dtFacturas.Rows.Count == 0) { return; }


            DataRow vRow = dtFacturas.Rows[0];
            MontoEfectivo.Value = vRow["Efectivo"].ToString();
            MontoTarjeta.Value = vRow["Tarjeta"].ToString();
            MontoCheque.Value = vRow["Cheque"].ToString();
            MontoCredito.Value = vRow["Credito"].ToString();
            TotalFondo.Value = vRow["FondoAnterior"].ToString();
            FondoNuevo.Value= vRow["Fondo"].ToString();


            TotalVentas.Value = Convert.ToDecimal(vRow["Efectivo"].ToString()) + Convert.ToDecimal(vRow["Tarjeta"].ToString()) +
                Convert.ToDecimal(vRow["Cheque"].ToString()) + Convert.ToDecimal(vRow["Credito"].ToString());

            EfectivoEnCaja.Value = (Convert.ToDecimal(MontoEfectivo.Value) + Convert.ToDecimal(TotalEfectivoCobro.Value) + Convert.ToDecimal(TotalFondo.Value)) -
                Convert.ToDecimal(GastosCaja.Value);

            Efectivo.Value = vRow["Efectivo2"].ToString();
            TarjetaCheques.Value = vRow["Tarjeta2"].ToString();
            Cheque.Value = vRow["Cheque2"].ToString();
            Credito.Value = vRow["Credito2"].ToString();


            Calculate();
        }

        private void Calculate()
        {
            FaltanteTarjeta.Value = (Convert.ToDecimal(MontoTarjeta.Value) + Convert.ToDecimal(TotalTarjetaCobro.Value)) - Convert.ToDecimal(TarjetaCheques.Value);
            FaltanteEfectivo.Value= (Convert.ToDecimal(EfectivoEnCaja.Value) + Convert.ToDecimal(TotalEfectivoCobro.Value)) - Convert.ToDecimal(Efectivo.Value);
            FaltanteCheque.Value = (Convert.ToDecimal(MontoCheque.Value)+ Convert.ToDecimal(TotalChequeCobro.Value)) - Convert.ToDecimal(Cheque.Value);
            FaltanteCredito.Value = (Convert.ToDecimal(MontoCredito.Value)) - Convert.ToDecimal(Credito.Value);
        }

        private void TarjetaCheques_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Cheque_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Efectivo_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Credito_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void bCobrar_Click(object sender, EventArgs e)
        {
            if (dtFacturas.Rows.Count == 0) { MessageBox.Show("No se an Generado movimientos para crear arqueo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if(FaltanteEfectivo.Value.ToString() !="0.00" || FaltanteTarjeta.Value.ToString() != "0.00" || FaltanteCredito.Value.ToString() != "0.00" ||
                FaltanteCheque.Value.ToString() != "0.00")
            {
                if (MessageBox.Show("En la distribucion existe una diferencia desea guardar de todos modos?",Application.ProductName,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                {
                    return;
                }
            }


            string vFacturaid = "";

            foreach (DataRow VRow in dtFacturas.Rows)
            {
                vFacturaid = (vFacturaid.Length > 0 ? vFacturaid + "," : "") + VRow["FacturaID"].ToString();
            }


           DataTable result = C.SQL("ARQUEO_M " + EfectivoEnCaja.Value + C.QII + Efectivo.Value + C.QII + TarjetaCheques.Value + C.QII + Cheque.Value + C.QII +
                    Credito.Value + C.QIS + Notas + C.QSI + GastosCaja.Value + C.QII + C.vUserID + C.QIS +  vFacturaid + C.QSI + FondoNuevo.Value );

            if(result.Rows[0][0].ToString()=="0")
            {
                FillGrid();
                MessageBox.Show("Arqueo Guardado",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            
        }

        private void radButton9_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
