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
    public partial class Facturacion : Form
    {

        public int vClienteID = 0;
        public int vArticuloID = 0;

        decimal ItbisPorciento = 0;
        DataTable dtFactura = new DataTable();
        DataTable dtArticulos = new DataTable();
        DataTable dtDetallepago = new DataTable();
        int Contador = -3000;
        public int vCobro = 0;
        int vFacturaID = 0;
        int vOpt = 0;

        public Facturacion()
        {
            InitializeComponent();
        }

        #region METODOS

        private void FillCombo()
        {
            TipodeComprobanteID.DisplayMember = "Descripcion";
            TipodeComprobanteID.ValueMember = "TipoComprobanteFiscalID";
            TipodeComprobanteID.DataSource = C.SQL("TIPOCOMPROBANTEFISCAL_L");

            FormadePagoID.DisplayMember = "Descripcion";
            FormadePagoID.ValueMember = "FormasPagosID";
            FormadePagoID.DataSource = C.SQL("FORMASPAGOS_L");


        }
        private void BuscarCliente()
        {
            vClienteID = 0;

            if (Codigo.Text.Length == 0)
            {
                BuscarCliente Form = new BuscarCliente();
                Form.vForm = this.Name;
                Form.ShowDialog();
                if (vClienteID == 0) { return; }
                BuscarClientes(vClienteID);

            }
            else
            {
                vClienteID = int.Parse(System.Text.RegularExpressions.Regex.Replace(Codigo.Text, @"[^\d]", "")); ;

                BuscarClientes(vClienteID);
            }

        }

        private void BuscarClientes(int vCliente)
        {
            DataTable dtCliente = C.SQL("CLIENTES_L " + vCliente);

            if (dtCliente.Rows.Count == 0)
            {
                MessageBox.Show("NO EXISTE NINGUN PROVEEDOR CON ESTE CODIGO, BUSQUELO EN LA LISTA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Codigo.Text = "";
                BuscarCliente Form = new BuscarCliente();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vCliente > 0) { dtCliente = C.SQL("CLIENTES_L " + vCliente); if (dtCliente.Rows.Count > 0) { FillCliente(dtCliente.Rows[0]); } } else { return; }
            }
            else
            {
                FillCliente(dtCliente.Rows[0]);

            }




        }

        private void FillCliente(DataRow vRow)
        {
            Codigo.Text = vRow["Codigo"].ToString();
            Nombre.Text = vRow["Nombre"].ToString() + " " + vRow["Apellido"].ToString() ;
            Telefonos.Text = (vRow["Telefono"].ToString().Length > 6 ? "Tel:" + vRow["Telefono"].ToString() + " " : "") + (vRow["Celular"].ToString().Length > 6 ? "Cel:" + vRow["Celular"].ToString() : "");
            Direccion.Text = (vRow["Provincia"].ToString().Length > 2 ? vRow["Provincia"].ToString() + "," : "") +
                            (vRow["Ciudad"].ToString().Length > 2 ? vRow["Ciudad"].ToString() + "," : "") + vRow["Pais"].ToString();
            Cedula.Text = vRow["Cedula"].ToString();
            Desc.Value= vRow["Descuento"].ToString();
            Desc.Visible = (Convert.ToDecimal(Desc.Value) == 0 ? false : true);
            radLabel28.Visible= (Convert.ToDecimal(Desc.Value) == 0 ? false : true);
            TipodeComprobanteID.SelectedValue =( C.Cint(vRow["TipoComprobanteID"].ToString())==0?2: C.Cint(vRow["TipoComprobanteID"].ToString()));

            CodigoA.Focus();
        }


        private void clearCliente()
        {

            Codigo.Text = "";
            Nombre.Text = "";
            Telefonos.Text = "";
            Direccion.Text = "";
            Cedula.Text = "";
            Desc.Value = 0;

        }

        private void buscarArticulo()
        {
            vArticuloID = 0;

            if (CodigoA.Text.Length == 0 || Descripcion.Text.Length >0 )
            {
                BuscarArticulo C = new BuscarArticulo();
                C.vForm = this.Name;
                C.ShowDialog();
                if (vArticuloID == 0) { return; }
                BuscarArticulos(vArticuloID);

            }
            else
            {

                BuscarArticulosCodigo(CodigoA.Text);
            }
        }

        private void BuscarArticulos(int vArticulos)
        {
            dtArticulos = C.SQL("Articulos_L " + vArticulos);

            if (dtArticulos.Rows.Count == 0)
            {
                MessageBox.Show("NO EXISTE NINGUN ARTICULO CON ESTE CODIGO, BUSQUELO EN LA LISTA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCliente Form = new BuscarCliente();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vArticuloID > 0) { dtArticulos =C.SQL("Articulos_L " + vArticuloID); if (dtArticulos.Rows.Count > 0) { FillArticulo(dtArticulos.Rows[0]); } } else { return; }
            }
            else
            {
                FillArticulo(dtArticulos.Rows[0]);

            }




        }
        private void BuscarArticulosCodigo(string vArticulos)
        {
            dtArticulos = C.SQL("Articulos_L Null,'" + vArticulos + C.QS);

            if (dtArticulos.Rows.Count == 0)
            {
                MessageBox.Show("NO EXISTE NINGUN ARTICULO CON ESTE CODIGO, BUSQUELO EN LA LISTA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarArticulo Form = new BuscarArticulo();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vArticuloID > 0) { dtArticulos = C.SQL("Articulos_L " + vArticuloID); if (dtArticulos.Rows.Count > 0) { FillArticulo(dtArticulos.Rows[0]); } } else { return; }
            }
            else
            {
                FillArticulo(dtArticulos.Rows[0]);

            }




        }

        private void FillArticulo(DataRow vRow)
        {
            LimpiarArticulo();
            if (vRow["PrecioActual"].ToString() == "0.0000")
            {
                MessageBox.Show("Este Articulo no tiene Precio definido, favor hable con su supervisor para poder facturar este articulo",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (vRow["StockActual"].ToString() == "0.0000")
            {
                MessageBox.Show("Este Articulo no tiene Existencia, favor hablar con su supervisor para poder facturar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CodigoA.Text = vRow["Codigo"].ToString();
            Descripcion.Text = vRow["Descripcion"].ToString();
            Unidad.Text = vRow["UnidadMedida"].ToString();
            Existencia.Text = vRow["StockActual"].ToString();
            ItbisPorciento = Convert.ToDecimal(vRow["ItbisPorciento"].ToString());
            vArticuloID = int.Parse(vRow["ArticuloID"].ToString());
            Precio.Value = vRow["PrecioActual"].ToString();  
            Cantidad.Focus();
        }

        private void LimpiarArticulo()
        {
            CodigoA.Text = "";
            Descripcion.Text = "";
            Unidad.Text = "";
            Precio.Value = 0;
            Existencia.Text = "";
            Cantidad.Value = 0;
            SubTotal.Value = 0;
            ItbisPorciento = 0;
            vArticuloID = 0;


        }

        private void NewFactura()
        {
            LimpiarArticulo();
            clearCliente();
            dtFactura = C.SQL("FACTURA_L 0");
            dtDetallepago= C.SQL("COBRAR_FACTURA_L 0");
            GRD.DataSource = dtFactura;
            vFacturaID = 0;
            vOpt = 0;
            Calcular();
            Codigo.Text = "1";
            BuscarCliente();
            CodigoA.Focus();
            
        }

        private void Calcular()
        {
            decimal subtotal = 0;
            decimal totalItbis = 0;
            decimal descuentos = 0;
            foreach (DataRow vRow in dtFactura.Rows)
            {
                subtotal += ((Convert.ToDecimal(vRow["Precioactual"].ToString()) * Convert.ToDecimal(vRow["Cantidad"].ToString())));
                totalItbis += Convert.ToDecimal(vRow["ITBISAMOUNT"].ToString()) * Convert.ToDecimal(vRow["Cantidad"].ToString());
                descuentos+= Convert.ToDecimal(vRow["Descuento"].ToString());

            }

            SubtotalF.Value = subtotal;
            ITBISF.Value = totalItbis;
            TotalF.Value= subtotal+ totalItbis;
            DESCF.Value = descuentos;
            TotalNeto.Value = (subtotal + totalItbis) - descuentos;
        }

        public void AdministrarPagos(DataTable dt)
        {
            dtDetallepago = dt;
        }
        #endregion FINAL DE METODOS ADICIONALES



        private void Facturacion_Load(object sender, EventArgs e)
        {
            FillCombo();
            NewFactura();
            Vendedor.Text = C.vUserName;
        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void Facturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==112)
            {
                BuscarCliente();
            }
            else if(e.KeyValue==113)
            {
                buscarArticulo();
            }
            else if(e.KeyValue==114)
            {
                bCobrar_Click(null, null);
            }
        }

        private void Codigo_TextChanged(object sender, EventArgs e)
        {
            if (Nombre.Text.Length > 0)
            {
                clearCliente();
            }
        }

        private void Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                BuscarCliente();
            }
            
        }

        private void bAddArticulo_Click(object sender, EventArgs e)
        {
            if(vClienteID==0 || Codigo.Text.Length==0)
            {
                MessageBox.Show("Debes indicar el Cliente antes de iniciar a Facturar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Codigo.Focus();
                return;
            }

            if (vArticuloID == 0 || Descripcion.Text.Length == 0)
            {
                MessageBox.Show("Indique que articulo desea Facturar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoA.Focus();
                return;
            }

            if (Cantidad.Text == "0")
            {
                MessageBox.Show("Indique la Cantidad de Articulos que decea Facturar ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cantidad.Focus();
                return;
            }

            if (Convert.ToDecimal(Existencia.Text)  < Convert.ToDecimal(Cantidad.Value.ToString()))
            {
                MessageBox.Show((Convert.ToDecimal(Existencia.Text) == 0 ? "Este Articulo no Tiene existencia Para facturar" : "La Cantidad de Articulos que deseas Facturar es mayor a la disponible en su inventario"),
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cantidad.Focus();
                return;
            }

            dtFactura.PrimaryKey = new DataColumn[] { dtFactura.Columns["ArticuloID"] };

            DataRow vRowActual = dtFactura.Rows.Find(vArticuloID);

            if (vRowActual == null)
            {
                dtFactura.PrimaryKey = new DataColumn[] { dtFactura.Columns["FacturaDetalleID"] };
                decimal importes = (Convert.ToDecimal(Precio.Text) * Convert.ToDecimal(Cantidad.Text));
                decimal Itbisamount = (Convert.ToDecimal(Precio.Text) * Convert.ToDecimal(dtArticulos.Rows[0]["ITBISPorciento"].ToString()));
                decimal precioActual = Convert.ToDecimal(Precio.Text)-(Convert.ToDecimal(Precio.Text) * Convert.ToDecimal(dtArticulos.Rows[0]["ITBISPorciento"].ToString())) ;

                DataRow vRow = dtFactura.NewRow();
                vRow["Edit"] = 0;
                vRow["FacturaDetalleID"] = Contador;
                vRow["Descripcion"] = Descripcion.Text;
                vRow["Codigo"] = CodigoA.Text;
                vRow["ArticuloID"] = vArticuloID;
                vRow["PrecioActual"] = precioActual;
                vRow["ArticuloPrecioID"] = dtArticulos.Rows[0]["PrecioActualId"].ToString();
                vRow["UnidadMedida"] = Unidad.Text;
                vRow["Cantidad"] = Cantidad.Value;
                vRow["ItbisID"] = dtArticulos.Rows[0]["ItbisID"].ToString();
                vRow["Importe"] = importes - (importes * Convert.ToDecimal(Desc.Value));
                vRow["Descuento"] = importes * Convert.ToDecimal(Desc.Value);
                vRow["ITBISAMOUNT"] = Itbisamount;
               

                Contador++;
                dtFactura.Rows.Add(vRow);
            }
            else
            {
                if (Convert.ToDecimal(Existencia.Text) - Convert.ToDecimal(vRowActual["Cantidad"].ToString())  < Convert.ToDecimal(Cantidad.Value.ToString()))
                {
                    MessageBox.Show((Convert.ToDecimal(Existencia.Text) == 0 ? "No hay articulos Disponibles para Facturar" : "La Cantidad de Articulos que deseas Facturar es mayor a la disponible en su inventario"),
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                vRowActual["Cantidad"] = Convert.ToInt32( vRowActual["Cantidad"].ToString()) + Convert.ToInt32( Cantidad.Value);
                decimal importes = (Convert.ToDecimal(Precio.Text) * Convert.ToDecimal(vRowActual["Cantidad"].ToString()));
                vRowActual["Importe"] = importes - (importes * Convert.ToDecimal(Desc.Value));




            }

            Calcular();
            LimpiarArticulo();
            CodigoA.Focus();

        }

        private void bBuscarArticulo_Click(object sender, EventArgs e)
        {
            buscarArticulo();
        }

        private void CodigoA_TextChanged(object sender, EventArgs e)
        {
            if(Descripcion.Text.Length>0)
            {
                LimpiarArticulo();
            }
        }

        private void CodigoA_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                buscarArticulo();
            }
        }

        private void Cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) { bAddArticulo_Click(null, null); }
        }

        private void GRD_CellValueNeeded(object sender, Telerik.WinControls.UI.GridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == e.Column.Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void bCobrar_Click(object sender, EventArgs e)
        {
            if (GRD.RowCount == 0) { MessageBox.Show("Esta Factura no tene articulos para Cobrar",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation); return; }
            vCobro = 0;
            FinalCompra form = new FinalCompra();
            form.vForm = this.Name;
            form.Facturacion(Convert.ToDecimal(TotalNeto.Value));
            form.ShowDialog();

            if (vCobro == 1)
            {
                string sqlString = "";

                sqlString = "Set nocount on; ";
                sqlString += "Declare @FacturaID int;  set @Facturaid = " + (vFacturaID == 0 ? 0 : vFacturaID);



                foreach (DataRow vRow in dtFactura.Rows)
                {
                    sqlString += " Exec [FACTURA_M] " + vOpt + C.QII + "@FacturaID" + C.QII + vClienteID + C.QIS + Fecha.Value.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + C.QSI +                                       
                    TipodeComprobanteID.SelectedValue + C.QII + C.vUserID + C.QII + vRow["FacturaDetalleID"].ToString() + C.QII + vRow["ArticuloID"].ToString() + C.QII + 
                    vRow["ARTICULOPRECIOID"].ToString() + C.QII + vRow["Cantidad"].ToString() + C.QII + vRow["Descuento"].ToString() + C.QII + vRow["ITBISID"].ToString() + C.QII +
                    C.vSucursalID + ", @FacturaID output ";
                }


                dtFactura = C.SQL(sqlString + " Select R= @FacturaID");
                MessageBox.Show(dtFactura.Rows[0][0].ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewFactura();
                
                
                
            }
            else if (vCobro==0)
            {
                //Cancelado el cobro
            }
           

        }

        private void Cantidad_ValueChanged(object sender, EventArgs e)
        {
            SubTotal.Value = Convert.ToDecimal(Precio.Value) * Convert.ToDecimal(Cantidad.Value);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if(GRD.RowCount>0)
            {
                if (MessageBox.Show("Deseas Cancelar la Factura?",Application.ProductName,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    NewFactura();
                }
                else
                {
                    CodigoA.Focus();
                }
            }
            else
            {
                NewFactura();
            }
        }
    }
}
