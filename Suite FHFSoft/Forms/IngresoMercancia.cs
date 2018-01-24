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
    public partial class IngresoMercancia : Form
    {

        DataTable dtSurcursal = new DataTable();
        DataTable dtIngreso = new DataTable();
        int vIngresoDetalleID = 0;
        int vIngresoID = 0;
        public int vProveedorID = 0;
        public int vOrdenID = 0;
        public int vArticulo = 0;
        int vORDENCOMPRASDETALLEID = 0;
        string Itbis = "";
        decimal ItbisPorciento = 0;
        int vedit = 0;
        int Contador = -10000;
        
        public IngresoMercancia()
        {
            InitializeComponent();
        }

        private void IngresoMercancia_Load(object sender, EventArgs e)
        {
            FillCombo();
            bNuevo_Click(null, null);
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillCombo()
        {
            TipodeComprobanteID.DisplayMember = "Descripcion";
            TipodeComprobanteID.ValueMember = "TipoComprobanteFiscalID";
            TipodeComprobanteID.DataSource = C.SQL("TIPOCOMPROBANTEFISCAL_L");

            FormadePagoID.DisplayMember = "Descripcion";
            FormadePagoID.ValueMember = "FormasPagosID";
            FormadePagoID.DataSource = C.SQL("FORMASPAGOS_L");

            AlmacenID.DisplayMember = "Descripcion";
            AlmacenID.ValueMember = "SucursalID";
            dtSurcursal = C.SQL("SUCURSAL_L " + C.vPerfilID);
            AlmacenID.DataSource = dtSurcursal;

            TipodeEntradaID.DisplayMember = "Descripcion";
            TipodeEntradaID.ValueMember = "TipoEntradaID";
            TipodeEntradaID.DataSource = C.SQL("TipoEntradas_L");
            

        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Creacion";
            Limpiar();
            bProcesar.Enabled = true;
            bNotas.Enabled = true;
            TipodeEntradaID.SelectedValue = null;
            vOrdenID = 0;
            Vendedor.Text = C.vUserName;
        }

        private void Limpiar()
        {

            GRD.ShowRowHeaderColumn = true;
            GRD.Columns[1].IsVisible = false;
            TipodeComprobanteID.Text = "";

            vIngresoDetalleID = 0;
            vIngresoID = 0;
            FormadePagoID.Text = "";
            Fecha.Value = DateTime.Today;
            clearProveedor();
            OrdenNumber.Text = "";
            AlmacenID.Text = "";
            OrdenNumber.Text = "";
            vProveedorID = 0;


            AlmacenID.SelectedValue = (dtSurcursal.Rows.Count == 1 ? Convert.ToInt64(dtSurcursal.Rows[0]["SucursalID"].ToString()) : 0);


            dtIngreso = C.SQL("ORDENCOMPRAS_L " + vIngresoID);
            GRD.DataSource = dtIngreso;
          

        }

        private void clearProveedor()
        {

            CodigoProveedor.Text = "";
            Nombre.Text = "";
            Telefonos.Text = "";
            Direccion.Text = "";
            Cedula.Text = "";

        }

        private void TipodeEntradaID_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
            bool value = (TipodeEntradaID.SelectedValue != null && TipodeEntradaID.SelectedValue.ToString() == "1"  ? true : false);

            radLabel34.Visible = value;
            OrdenID.Visible = value;
            bBuscarOrden.Visible = value;
            CodigoProveedor.Enabled = !value;
            bBuscarProveedor.Visible= !value;
            clearProveedor();


        }

        private void bBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void BuscarProveedor()
        {
            vProveedorID = 0;

            if (CodigoProveedor.Text.Length == 0)
            {
                BuscarProveedor C = new BuscarProveedor();
                C.vForm = this.Name;
                C.ShowDialog();
                if (vProveedorID == 0) { return; }
                BuscarProveedores(vProveedorID);

            }
            else
            {
                vProveedorID = int.Parse(System.Text.RegularExpressions.Regex.Replace(CodigoProveedor.Text, @"[^\d]", "")); ;

                BuscarProveedores(vProveedorID);
            }

        }
        private void BuscarOrden()
        {
            vOrdenID = 0;

            if (OrdenID.Text.Length == 0 || OrdenID.Text =="0")
            {
                OrdenID.Text = "";
                BuscarOrdenCompras C = new BuscarOrdenCompras();
                C.vForm = this.Name;
                C.ShowDialog();
                if (vOrdenID == 0) { return; }
                BuscarOrdenes(vOrdenID);

            }
            else
            {
                vOrdenID = int.Parse(System.Text.RegularExpressions.Regex.Replace(OrdenID.Text, @"[^\d]", "")); ;

                BuscarOrdenes(vOrdenID);
            }

        }
        private void BuscarOrdenes(int vOrdenID)
        {
            dtIngreso = C.SQL("ORDENCOMPRAS_L " + vOrdenID);

            if (dtIngreso.Rows.Count == 0)
            {
                
                MessageBox.Show("NO EXISTE NINGUNA ORDEN CON ESTE CODIGO, BUSQUELO EN LA LISTA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                OrdenID.Text = "";
                BuscarOrdenCompras Form = new BuscarOrdenCompras();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vOrdenID > 0) { dtIngreso = C.SQL("ORDENCOMPRAS_L " + vOrdenID); if (dtIngreso.Rows.Count > 0) { FillOrden(dtIngreso.Rows[0]); GRD.DataSource = dtIngreso; } } else { return; }
            }
            else
            {
                if (dtIngreso.Rows[0]["Process"].ToString() == "1")
                {
                    MessageBox.Show("ESTA ORDEN DE COMPRAS YA FUE PROCESADA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    OrdenID.Text = "";
                    return;
                }
                FillOrden(dtIngreso.Rows[0]);
                GRD.DataSource = dtIngreso;
            }




        }
        private void BuscarProveedores(int vProveedor)
        {
            DataTable Proveedor = C.SQL("Proveedores_L " + vProveedor);

            if (Proveedor.Rows.Count == 0)
            {
                MessageBox.Show("NO EXISTE NINGUN PROVEEDOR CON ESTE CODIGO, BUSQUELO EN LA LISTA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CodigoProveedor.Text = "";
                BuscarProveedor Form = new BuscarProveedor();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vProveedorID > 0) { Proveedor = C.SQL("Proveedores_L " + vProveedorID); if (Proveedor.Rows.Count > 0) { FillProveedor(Proveedor.Rows[0]);  } } else { return; }
            }
            else
            {
                
                FillProveedor(Proveedor.Rows[0]);

            }




        }

        private void FillProveedor(DataRow vRow)
        {
            CodigoProveedor.Text = vRow["Codigo"].ToString();
            Nombre.Text = vRow["Nombre"].ToString();
            Telefonos.Text = (vRow["Telefono"].ToString().Length > 6 ? "Tel:" + vRow["Telefono"].ToString() + " " : "") + (vRow["Celular"].ToString().Length > 6 ? "Cel:" + vRow["Celular"].ToString() : "");
            Direccion.Text = (vRow["Provincia"].ToString().Length > 2 ? vRow["Provincia"].ToString() + "," : "") +
                            (vRow["Ciudad"].ToString().Length > 2 ? vRow["Ciudad"].ToString() + "," : "") + vRow["Pais"].ToString();
            Cedula.Text = vRow["Cedula"].ToString();

            TipodeComprobanteID.Focus();
        }

        private void bBuscarOrden_Click(object sender, EventArgs e)
        {
            BuscarOrden();
        }

        private void FillOrden(DataRow vRow)
        {
            BuscarProveedores(Convert.ToInt32(vRow["ProveedorId"].ToString()));
            vProveedorID = Convert.ToInt32(vRow["ProveedorId"].ToString());
            OrdenNumber.Text = vRow["OrdenCompraID"].ToString();
            TipodeComprobanteID.SelectedValue = (Convert.ToInt32((vRow["TipoComprobanteID"].ToString()==""?null: vRow["TipoComprobanteID"].ToString())));
            NoComprobantes.Text = vRow["NoComprobante"].ToString();
            string Formasdepagos = vRow["Formasdepago"].ToString();
            int vv = 0;
            int indexof = 0;

            while (Formasdepagos.Length > 0)
            {
                indexof = (Formasdepagos.IndexOf(",") == -1 ? Formasdepagos.Length : Formasdepagos.IndexOf(","));
                vv = int.Parse(Formasdepagos.Substring(0, indexof));
                for (int i = 0; i < FormadePagoID.Items.Count; i++)
                {
                    if (FormadePagoID.Items[i].Value.ToString() == vv.ToString())
                    {
                        FormadePagoID.Items[i].Checked = true;
                    }
                }
                if (indexof == Formasdepagos.Length) { break; }
                Formasdepagos = Formasdepagos.Substring(indexof + 1, Formasdepagos.Length - (indexof + 1));
            }

            AlmacenID.SelectedValue = (Convert.ToInt32((vRow["AlmacenID"].ToString() == "" ? null : vRow["AlmacenID"].ToString())));

            Calcular();
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (GRD.RowCount == 0 || !radGroupBox3.Enabled) { return; }

            vORDENCOMPRASDETALLEID = int.Parse(GRD.CurrentRow.Cells[0].Value.ToString());

            dtIngreso.PrimaryKey = new DataColumn[] { dtIngreso.Columns["ORDENCOMPRASDETALLEID"] };
            DataRow vRow = dtIngreso.Rows.Find(vORDENCOMPRASDETALLEID);

            if (vRow != null)
            {
                BuscarArticulos(int.Parse(vRow["ArticuloID"].ToString()));

                vedit = 1;
                Lote.Text = vRow["Lote"].ToString();
                FechaExpiracion.Value = C.Cdate(vRow["FechaExpiracion"].ToString());
                Costo.Value = vRow["Costo"].ToString();
                Cantidad.Value = vRow["Cantidad"].ToString();


            }
        }

        private void BuscarArticulos(int vArticulos)
        {
            DataTable Articulos = C.SQL("Articulos_L " + vArticulos);

            if (Articulos.Rows.Count == 0)
            {
                MessageBox.Show("NO EXISTE NINGUN ARTICULO CON ESTE CODIGO, BUSQUELO EN LA LISTA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCliente Form = new BuscarCliente();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vArticulo > 0) { C.SQL("Articulos_L " + vArticulo); if (Articulos.Rows.Count > 0) { FillArticulo(Articulos.Rows[0]); } } else { return; }
            }
            else
            {
                FillArticulo(Articulos.Rows[0]);

            }




        }


        private void FillArticulo(DataRow vRow)
        {
            LimpiarArticulo();
            CodigoA.Text = vRow["Codigo"].ToString();
            Descripcion.Text = vRow["Descripcion"].ToString();
            Unidad.Text = vRow["UnidadMedida"].ToString();
            StockActual.Text = vRow["StockActual"].ToString();
            Itbis = vRow["Itbis"].ToString();
            ItbisPorciento = Convert.ToDecimal(vRow["ItbisPorciento"].ToString());
            vArticulo = int.Parse(vRow["ArticuloID"].ToString());
            txtItbis.Text = Itbis;

            Lote.Focus();
        }

        private void LimpiarArticulo()
        {
            CodigoA.Text = "";
            Descripcion.Text = "";
            Unidad.Text = "";
            Costo.Value = 0;
            Lote.Text = "";
            FechaExpiracion.Text ="" ;
            StockActual.Text = "";
            Cantidad.Value = 0;
            SubTotal.Value = 0;
            Itbis = "";
            txtItbis.Text = "";
            ItbisPorciento = 0;
            vArticulo = 0;

        }

        private void bAddArticulo_Click(object sender, EventArgs e)
        {
            if (vArticulo == 0 || Descripcion.Text.Length == 0)
            {
                MessageBox.Show("Indique que articulo desea agregar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoA.Focus();
                return;
            }

            if (Costo.Text == "0.00")
            {
                MessageBox.Show("Indique el Costo del Articulo ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Costo.Focus();
                return;
            }

            if (Cantidad.Text == "0")
            {
                MessageBox.Show("Indique la Cantidad de Articulos que decea agregar ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cantidad.Focus();
                return;
            }


            if (vedit == 0)
            {


                dtIngreso.PrimaryKey = new DataColumn[] { dtIngreso.Columns["ArticuloID"] };

                DataRow vRowActual = dtIngreso.Rows.Find(vArticulo);

                if (vRowActual == null)
                {
                    dtIngreso.PrimaryKey = new DataColumn[] { dtIngreso.Columns["ORDENCOMPRASDETALLEID"] };
                    decimal importes = (Convert.ToDecimal(Costo.Text) * Convert.ToDecimal(Cantidad.Text));
                    DataRow vRow = dtIngreso.NewRow();
                    vRow["Edit"] = 0;
                    vRow["OrdenCompraID"] = 0;
                    vRow["ProveedorID"] = vProveedorID;
                    vRow["ORDENCOMPRASDETALLEID"] = Contador;
                    vRow["Descripcion"] = Descripcion.Text;
                    vRow["Codigo"] = CodigoA.Text;
                    vRow["ArticuloID"] = vArticulo;
                    vRow["Costo"] = Costo.Value;
                    vRow["Lote"] = Lote.Text;
                    vRow["UnidadMedida"] = Unidad.Text;
                    vRow["FechaExpiracion"] = FechaExpiracion.Value.Date;
                    vRow["Cantidad"] = Cantidad.Value;
                    vRow["Importe"] = importes;
                    vRow["ITBIS"] = Itbis;
                    vRow["ItbisPorciento"] = ItbisPorciento;

                    Contador++;
                    dtIngreso.Rows.Add(vRow);
                }
                else
                {
                    if (vRowActual["Costo"].ToString() != Costo.Value.ToString() || vRowActual["Lote"].ToString() != Lote.Text || vRowActual["FechaExpiracion"].ToString() != FechaExpiracion.Value.Date.ToString())
                    {
                        dtIngreso.PrimaryKey = new DataColumn[] { dtIngreso.Columns["ORDENCOMPRASDETALLEID"] };
                        decimal importes = (Convert.ToDecimal(Costo.Text) * Convert.ToDecimal(Cantidad.Text));
                        DataRow vRow = dtIngreso.NewRow();
                        vRow["Edit"] = 0;
                        vRow["OrdenCompraID"] = 0;
                        vRow["ProveedorID"] = vProveedorID;
                        vRow["ORDENCOMPRASDETALLEID"] = Contador;
                        vRow["Descripcion"] = Descripcion.Text;
                        vRow["Codigo"] = CodigoA.Text;
                        vRow["ArticuloID"] = vArticulo;
                        vRow["Costo"] = Costo.Value;
                        vRow["Lote"] = Lote.Text;
                        vRow["UnidadMedida"] = Unidad.Text;
                        vRow["FechaExpiracion"] = (FechaExpiracion.Value);
                        vRow["Cantidad"] = Cantidad.Value;
                        vRow["Importe"] = importes;
                        vRow["ITBIS"] = Itbis;
                        vRow["ItbisPorciento"] = ItbisPorciento;

                        Contador++;
                        dtIngreso.Rows.Add(vRow);
                    }
                    else
                    {
                        vRowActual["Edit"] = (vRowActual["Edit"].ToString() == "-1" ? 1 : 0);
                        vRowActual["Cantidad"] = int.Parse(vRowActual["Cantidad"].ToString()) + int.Parse(Cantidad.Value.ToString());
                        decimal importes = Convert.ToDecimal(vRowActual["Costo"].ToString()) * int.Parse(vRowActual["Cantidad"].ToString());
                        vRowActual["Importe"] = importes;

                    }


                }
            }
            else
            {
                dtIngreso.PrimaryKey = new DataColumn[] { dtIngreso.Columns["ORDENCOMPRASDETALLEID"] };
                DataRow vRow = dtIngreso.Rows.Find(vORDENCOMPRASDETALLEID);
                if (vRow != null)
                {
                    decimal importes = (Convert.ToDecimal(Costo.Text) * Convert.ToDecimal(Cantidad.Text));
                    vRow["EDIT"] = 1;
                    vRow["Lote"] = Lote.Text;
                    vRow["FechaExpiracion"] = (FechaExpiracion.Value.Date.Year<2010?"1/1/3000": FechaExpiracion.Value.Date.ToString());
                    vRow["Costo"] = Costo.Value;
                    vRow["Cantidad"] = Cantidad.Value;
                    vRow["Importe"] = importes;
                }

            }

            GRD.DataSource = dtIngreso;
            LimpiarArticulo();
            Calcular();
            vedit = 0;
            CodigoA.Focus();
        }


        private void Calcular()
        {
            decimal Subtotal = 0;
            decimal itbis = 0;
            foreach (DataRow vRows in dtIngreso.Rows)
            {
                Subtotal += Convert.ToDecimal(vRows["Importe"].ToString()) - (Convert.ToDecimal(vRows["ItbisPorciento"].ToString()) * Convert.ToDecimal(vRows["Importe"].ToString()));
                itbis += Convert.ToDecimal(vRows["ItbisPorciento"].ToString()) * Convert.ToDecimal(vRows["Importe"].ToString());

            }
            SubtotalF.Value = Subtotal;
            ITBISF.Value = itbis;
            TotalF.Value = itbis + Subtotal;
            TotalNeto.Value = TotalF.Value;

        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (vArticulo == 0)
            {
                Lote.Text = "";
                MessageBox.Show("Seleccione el articulo que decea agregar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoA.Focus();
                return;
            }
            CalcularImporte();
        }


        private void CalcularImporte()
        {
            decimal importes = (Convert.ToDecimal(Costo.Text) * Convert.ToDecimal(Cantidad.Text));

            SubTotal.Value = importes;
        }

        private void GRD_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
           
           
        }

        private void GRD_RowsChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {

        }

        private void bBuscarArticulo_Click(object sender, EventArgs e)
        {
            buscarArticulo();
        }

        private void CodigoA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                buscarArticulo();
            }
        }

        private void buscarArticulo()
        {
            vArticulo = 0;
 
            if (CodigoA.Text.Length == 0)
            {
                BuscarArticulo C = new BuscarArticulo();
                C.vForm = this.Name;
                C.ShowDialog();
                if (vArticulo == 0) { return; }
                BuscarArticulos(vArticulo);

            }
            else
            {

                BuscarArticulosCodigo(CodigoA.Text);
            }
        }
        private void BuscarArticulosCodigo(string vArticulos)
        {
            DataTable Articulos = C.SQL("Articulos_L Null,'" + vArticulos + C.QS);

            if (Articulos.Rows.Count == 0)
            {
                MessageBox.Show("NO EXISTE NINGUN ARTICULO CON ESTE CODIGO, BUSQUELO EN LA LISTA", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarArticulo Form = new BuscarArticulo();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vArticulo > 0) { Articulos = C.SQL("Articulos_L " + vArticulo); if (Articulos.Rows.Count > 0) { FillArticulo(Articulos.Rows[0]); } } else { return; }
            }
            else
            {
                FillArticulo(Articulos.Rows[0]);

            }




        }

        private void bProcesar_Click(object sender, EventArgs e)
        {
            if (!ValidarTodo()) { return; }

            if (GRD.RowCount == 0)
            {
                MessageBox.Show("No se Puede Guardar una Orden de Compras vacia, agrege articulos a la lista e intente de nuevo",
                  Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string Formaspago = "";


            for (int i = 0; i <= FormadePagoID.Items.Count - 1; i++)
            {
                if (FormadePagoID.Items[i].Checked)
                {
                    Formaspago += (Formaspago.Length > 0 ? "," : "") + FormadePagoID.Items[i].Value.ToString();
                }

            }


            string sqlString = "";

            sqlString = "Set nocount on; ";
            sqlString += "Declare @OrdenID int;  set @ordenid = null"  ;

            
            
                foreach (DataRow vRow in dtIngreso.Rows)
                {
                    sqlString += " Exec IngresoMercancas_M " + 0 + C.QII + vOrdenID + C.QII + vProveedorID + C.QIS + Fecha.Value.ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + C.QSI +
                    (TipodeComprobanteID.SelectedValue == null ? "Null" : TipodeComprobanteID.SelectedValue) + C.QIS + NoComprobantes.Text + C.QSS + Formaspago + C.QSI +
                    C.vUserID + C.QII + vRow["ORDENCOMPRASDETALLEID"].ToString() + C.QII + vRow["ArticuloID"].ToString() + C.QII + vRow["Costo"].ToString() + C.QIS +
                    vRow["Lote"].ToString() + C.QSI + (C.Cdate(vRow["FechaExpiracion"].ToString()).Year == 1 ? "NULL" : "'" + vRow["FechaExpiracion"].ToString().Replace("a.m.", "AM").Replace("p.m.", "PM") + "'") + C.QII + vRow["Cantidad"].ToString() + C.QII +
                    AlmacenID.SelectedValue.ToString() + ", @OrdenID output ";
                }
                dtIngreso = C.SQL(sqlString + " exec ('ORDENCOMPRAS_L ' + @OrdenID)");

            MessageBox.Show("Todos los articulos fueron Ingesados con Exito");
            bNuevo_Click(null, null);

        }
        private bool ValidarTodo()
        {
            if (vProveedorID == 0 || Nombre.Text.Length == 0)
            {
                MessageBox.Show("No puede Procesar una Orden de Compras sin definir un Proveedor", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoProveedor.Focus();
                return false;
            }

            if (AlmacenID.SelectedValue == null || AlmacenID.Text.Length == 0)
            {
                MessageBox.Show("No puede Procesar una Orden de Compras sin definir un Almacen de Destino", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AlmacenID.Focus();
                return false;
            }


            foreach (DataRow vRow in dtIngreso.Rows)
            {
                if(vRow["Expiracion"].ToString()=="1" && vRow["FECHAEXPIRACION"].ToString() == "" )
                {
                    MessageBox.Show("Para dar entrada al Articulo " + vRow["Descripcion"].ToString()+ ", debes ingresar la fecha de Expiracion o vencimiento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
            if (TipodeComprobanteID.SelectedValue == null || TipodeComprobanteID.Text.Length == 0)
            {
                MessageBox.Show("No puede Procesar una Orden de Compras si un tipo de Comprobante ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TipodeComprobanteID.Focus();
                return false;
            }
            int ii = 0;
            for (int i = 0; i < FormadePagoID.Items.Count; i++)
            {
                if (FormadePagoID.Items[i].Checked) { ii = 1; break; }
            }
            if (ii == 0)
            {
                MessageBox.Show("No puede Procesar una Orden de Compras si una Forma de Pago ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TipodeComprobanteID.Focus();
                return false;
            }

            return true;
        }
    }
}
