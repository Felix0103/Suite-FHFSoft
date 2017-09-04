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
        int Contador = -3000;

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
            DataTable dtArticulos = C.SQL("Articulos_L " + vArticulos);

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
            DataTable dtArticulos = C.SQL("Articulos_L Null,'" + vArticulos + C.QS);

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
            GRD.DataSource = dtFactura;


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


            dtFactura.PrimaryKey = new DataColumn[] { dtFactura.Columns["ArticuloID"] };

            DataRow vRowActual = dtFactura.Rows.Find(vArticuloID);

            if (vRowActual == null)
            {
                dtFactura.PrimaryKey = new DataColumn[] { dtFactura.Columns["FacturaDetalleID"] };
                decimal importes = (Convert.ToDecimal(Precio.Text) * Convert.ToDecimal(Cantidad.Text));
                decimal Itbisamount = importes * ItbisPorciento;

                DataRow vRow = dtFactura.NewRow();
                vRow["Edit"] = 0;
                vRow["FacturaDetalleID"] = Contador;
                vRow["Descripcion"] = Descripcion.Text;
                vRow["Codigo"] = CodigoA.Text;
                vRow["ArticuloID"] = vArticuloID;
                vRow["PrecioActual"] = Precio.Value;
                vRow["UnidadMedida"] = Unidad.Text;
                vRow["Cantidad"] = Cantidad.Value;
                vRow["Importe"] = importes;
                vRow["ITBISAMOUNT"] = Itbisamount;
               

                Contador++;
                dtFactura.Rows.Add(vRow);
            }

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
    }
}
