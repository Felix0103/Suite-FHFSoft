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
    public partial class FinalCompra : Form
    {
        public string vForm = "";
        DataTable dtDetallepago = new DataTable();
        public FinalCompra()
        {
            InitializeComponent();
        }

        public void Facturacion(decimal monto)
        {
            TotalFacturado.Value = monto;
        }
        private void FinalCompra_Load(object sender, EventArgs e)
        {
            dtDetallepago = C.SQL("COBRAR_FACTURA_L 0");

            TipodeTarjeta.DisplayMember = "Descripcion";
            TipodeTarjeta.ValueMember = "Formaspagosid";
            TipodeTarjeta.DataSource = C.SQL("[FORMASPAGOS_L] 1 ");
            TipodeTarjeta.Text = "";
        }
        
        private void Calculate()
        {

            Cambio.Value = ((Convert.ToDecimal(TotalFacturado.Value) -( Convert.ToDecimal(Tarjeta.Value) + 
                Convert.ToDecimal(Cheque.Value)+ Convert.ToDecimal(Credito.Value))) - Convert.ToDecimal(Efectivo.Value))*-1;
        }

        private bool CalculateTotal()
        {
            if((Convert.ToDecimal(Tarjeta.Value) + Convert.ToDecimal(Cheque.Value) + Convert.ToDecimal(Credito.Value) + Convert.ToDecimal(Efectivo.Value))> Convert.ToDecimal(TotalFacturado.Value))
            {
                MessageBox.Show("No Puedes Cobrar mas de lo facturado",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void Efectivo_KeyDown(object sender, KeyEventArgs e)
        {
            
         
        }

        private void Tarjeta_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(Tarjeta.Value)>0)
            {
                this.Size = new Size(810,353);
                TipodeTarjeta.Visible = true;
                NumeroTarjeta.Visible = true;
            }
            else
            {
                this.Size = new Size(347, 353);
                TipodeTarjeta.Visible = false;
                NumeroTarjeta.Visible = false;
            }
            
            if (!CalculateTotal())
            {
                Tarjeta.Value = 0;

            }

            Calculate();
        }

        private void Cheque_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(Cheque.Value) > 0)
            {
                this.Size = new Size(810, 353);
                NumeroCheque.Visible = true;
            }
            else
            {
                this.Size = new Size(347, 353);
                NumeroCheque.Visible = false;
            }

            if (!CalculateTotal())
            {
                Cheque.Value = 0;
            }

            Calculate();
        }

        private void Credito_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(Cheque.Value) > 0)
            {
                this.Size = new Size(810, 353);
                Referencia.Visible = true;
            }
            else
            {
                this.Size = new Size(347, 353);
                Referencia.Visible = false;
            }
            if (!CalculateTotal())
            {
                Credito.Value = 0;
            }

            Calculate();
        }

        private void TipodeTarjeta_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FinalCompra_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == 13 && Convert.ToDecimal(Efectivo.Value) >= Convert.ToDecimal(TotalFacturado.Value))
            {
                bAplicar.Focus();
            }
            else if (e.KeyValue == 13)
            {
                SendKeys.Send("{TAB}");
            }

            
        }

        private void Efectivo_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Cambio_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(Cambio.Value)>=0)
            {
                Cambio.BackColor = Color.GreenYellow;
            }
            else
            {
                Cambio.BackColor = Color.OrangeRed;
            }
        }

        private void Tarjeta_ValueChanging(object sender, CancelEventArgs e)
        {

           
            
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deceas Salir sin Cobrar?",Application.ProductName,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                for (int i = 0; i <= Application.OpenForms.Count - 1; i++)
                {
                    if (Application.OpenForms[i].Name == vForm)
                    {

                        if (vForm == "Facturacion")
                        {
                            ((Facturacion)Application.OpenForms[i]).vCobro = 0;
                            this.Close();
                        }
                    }
                }
            }
            
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Application.OpenForms.Count - 1; i++)
            {
                if (Application.OpenForms[i].Name == vForm)
                {

                    if (vForm == "Facturacion")
                    {
                        if (Convert.ToDecimal(Efectivo.Value)>0)
                        {
                            DataRow vRow = dtDetallepago.NewRow();
                            vRow["TipoFormaPagoID"] = 1;
                            vRow["Monto"] = Convert.ToDecimal(Efectivo.Value)- Convert.ToDecimal(Cambio.Value);
                            vRow["TipodeTransaccion"] = 1;

                            dtDetallepago.Rows.Add(vRow);
                        }

                        if (Convert.ToDecimal(Tarjeta.Value) > 0)
                        {
                            if (TipodeTarjeta.SelectedValue == null)
                            { MessageBox.Show("Selecione el tipo de Tarjeta con la realizo el pago",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                return;

                            }
                            DataRow vRow = dtDetallepago.NewRow();
                            vRow["TipoFormaPagoID"] = TipodeTarjeta.SelectedValue;
                            vRow["Monto"] = Convert.ToDecimal(Tarjeta.Value);
                            vRow["TipodeTransaccion"] = 1;
                            vRow["NoFormapago"] = NumeroTarjeta.Text;


                            dtDetallepago.Rows.Add(vRow);
                        }

                        if (Convert.ToDecimal(Cheque.Value) > 0)
                        {
                            if (NumeroCheque.Text.Length==0)
                            {
                                MessageBox.Show("Digite el numero de Cheque y el Banco Ejemplo: 001278-Banco Cuarquiera", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;

                            }
                            DataRow vRow = dtDetallepago.NewRow();
                            vRow["TipoFormaPagoID"] = 4;
                            vRow["Monto"] = Convert.ToDecimal(Cheque.Value);
                            vRow["TipodeTransaccion"] = 1;
                            vRow["NoFormapago"] = NumeroCheque.Text;


                            dtDetallepago.Rows.Add(vRow);
                        }

                        if (Convert.ToDecimal(Credito.Value) > 0)
                        {
                            DataRow vRow = dtDetallepago.NewRow();
                            vRow["TipoFormaPagoID"] = 5;
                            vRow["Monto"] = Convert.ToDecimal(Credito.Value);
                            vRow["TipodeTransaccion"] = 1;
                            vRow["Reference"] = 0;
                            dtDetallepago.Rows.Add(vRow);
                        }
                        decimal cambio = Convert.ToDecimal(Cambio.Value);
                        if(cambio<0 || cambio > 1999)
                        {
                            MessageBox.Show("Verifique la distribucion de pagos," + (cambio < 0?"Falta dinero para saldar la factura, indique a que pertenece":"Distribucion de pagos no real"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        ((Facturacion)Application.OpenForms[i]).AdministrarPagos(dtDetallepago);
                        ((Facturacion)Application.OpenForms[i]).vCobro=1;
                        ((Facturacion)Application.OpenForms[i]).vImprimir = (chkFactura.Checked?1:0);
                        this.Close();
                    }
                }
            }
        }
    }
}
