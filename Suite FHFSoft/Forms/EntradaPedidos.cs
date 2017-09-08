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
    public partial class EntradaPedidos : Form
    {
        public int vProveedorID=0;
        public int vArticulo = 0;
        public int vOrdenCompras = 0;
        int vORDENCOMPRASDETALLEID = 0;
        string Itbis = "";
        decimal ItbisPorciento = 0;
        public DataTable dtOrdenCompras = new DataTable();
        DataTable dtSurcursal = new DataTable();
        int Contador = -3000;
        int vedit =0;
        int vOpt = 0;
        int vLock = 0;
        int Prosesada = 0;
        public EntradaPedidos()
        {
            InitializeComponent();
        }
        #region METODOS

        private bool ValidarTodo()
        {
            if(vProveedorID==0 || Nombre.Text.Length==0)
            {
                MessageBox.Show("No puede Procesar una Orden de Compras sin definir un Proveedor",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CodigoProveedor.Focus();
                return false;
            }

            if (AlmacenID.SelectedValue == null || AlmacenID.Text.Length == 0)
            {
                MessageBox.Show("No puede Procesar una Orden de Compras sin definir un Almacen de Destino", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AlmacenID.Focus();
                return false;
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
                if(FormadePagoID.Items[i].Checked) { ii = 1;break; }
            }
            if (ii ==0)
            {
                MessageBox.Show("No puede Procesar una Orden de Compras si una Forma de Pago ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TipodeComprobanteID.Focus();
                return false;
            }

            return true;
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

        private void buscarArticulo()
        {
            vArticulo = 0;
            if (Prosesada == 1) { MessageBox.Show("Esta Orden ya Fue Procesada, Cree una nueva para poder agregar mas Articulos",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information); return; }

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
        private void BuscarProveedores(int vProveedor)
        {
            DataTable Proveedor = C.SQL("Proveedores_L " + vProveedor);

            if(Proveedor.Rows.Count==0)
            {
                MessageBox.Show("NO EXISTE NINGUN PROVEEDOR CON ESTE CODIGO, BUSQUELO EN LA LISTA",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                CodigoProveedor.Text = "";
                BuscarProveedor Form = new BuscarProveedor();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vProveedorID > 0) { Proveedor =C.SQL("Proveedores_L " + vProveedorID); if (Proveedor.Rows.Count>0) { FillProveedor(Proveedor.Rows[0]); } } else { return; }
            }
            else
            {
                FillProveedor(Proveedor.Rows[0]);
               
            }
            
            


        }

        private void CalcularImporte()
        {
            decimal importes = (Convert.ToDecimal(Costo.Text) * Convert.ToDecimal(Cantidad.Text));

            SubTotal.Value = importes;
        }
         private void BuscarArticulos(int vArticulos)
        {
            DataTable Articulos = C.SQL("Articulos_L " + vArticulos);

            if(Articulos.Rows.Count==0)
            {
                MessageBox.Show("NO EXISTE NINGUN ARTICULO CON ESTE CODIGO, BUSQUELO EN LA LISTA",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                BuscarCliente Form = new BuscarCliente();
                Form.vForm = this.Name;
                Form.ShowDialog();

                if (vArticulo > 0) {  C.SQL("Articulos_L " + vArticulo); if (Articulos.Rows.Count>0) { FillArticulo(Articulos.Rows[0]); } } else { return; }
            }
            else
            {
                FillArticulo(Articulos.Rows[0]);
               
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

                if (vArticulo > 0) { Articulos =C.SQL("Articulos_L " + vArticulo); if (Articulos.Rows.Count > 0) { FillArticulo(Articulos.Rows[0]); } } else { return; }
            }
            else
            {
                FillArticulo(Articulos.Rows[0]);

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

        private void LimpiarArticulo()
        {
            CodigoA.Text = "";
            Descripcion.Text = "";
            Unidad.Text = "";
            Costo.Value = 0;
            Lote.Text = "";
            FechaExpiracion.Text="01/01/0001";
            StockActual.Text = "";
            Cantidad.Value = 0;
            SubTotal.Value = 0;
            Itbis = "";
            txtItbis.Text = "";
            ItbisPorciento = 0;
            vArticulo = 0;

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

        private void clearProveedor()
        {

            CodigoProveedor.Text ="";
            Nombre.Text = "";
            Telefonos.Text ="";
            Direccion.Text = "";
            Cedula.Text = "";

        }

        private void FillGrid()
        {

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

        }

        private void Calcular()
        {
            decimal Subtotal = 0;
            decimal itbis = 0;
            foreach (DataRow vRows in dtOrdenCompras.Rows)
            {
                Subtotal += Convert.ToDecimal(vRows["Importe"].ToString())-( Convert.ToDecimal(vRows["ItbisPorciento"].ToString()) * Convert.ToDecimal(vRows["Importe"].ToString()));
                itbis += Convert.ToDecimal(vRows["ItbisPorciento"].ToString()) * Convert.ToDecimal(vRows["Importe"].ToString());
                
            }
            SubtotalF.Value = Subtotal;
            ITBISF.Value = itbis;
            TotalF.Value = itbis + Subtotal;
            TotalNeto.Value = TotalF.Value;
            
        }

        private void Limpiar()
        {

            GRD.ShowRowHeaderColumn = true;
            GRD.Columns[1].IsVisible = false;
            TipodeComprobanteID.Text = "";
            FormadePagoID.Text = "";
            Fecha.Value = DateTime.Today;
            clearProveedor();
            OrdenNumber.Text = "";
            AlmacenID.Text = "";
            AlmacenID.SelectedValue = (dtSurcursal.Rows.Count == 1 ? Convert.ToInt64(dtSurcursal.Rows[0]["SucursalID"].ToString()) :0);


            DataTable dd = C.SQL("ORDENCOMPRAS_L 0");
            GRD.DataSource = dd;
            vLock = 0;

        }

        private void ModificarProcesar()
        {
            GRD.ShowRowHeaderColumn = false;
            GRD.Columns[1].IsVisible = true;
        }
        private void Procesar()
        {
            string sqlString = " set nocount on ";
            foreach (DataRow vRow in dtOrdenCompras.Rows)
            {
                sqlString += " Exec KARDEX_M 0," + vRow["ArticuloId"] + C.QII + vRow["Cantidad"] + C.QIS +
                    DateTime.Today.Date + C.QSI + C.vUserID + C.QII + vRow["OrdencompraId"] + C.QII + vRow["ORDENCOMPRASDETALLEID"] + C.QII +
                    (AlmacenID.SelectedValue==null?"Null": AlmacenID.SelectedValue.ToString());
                

            }

            DataTable Result = C.SQL(sqlString + " Select R=0");

            if(Result.Rows[0][0].ToString()=="0")
            {
                MessageBox.Show("Entrada de todos los articulos Correctamente ",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Prosesada = 1;
                lblStatus.Text = "Orden Procesada";
            }
            else
            {
                MessageBox.Show("Error al Procesar entrada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Bloquear()
        {
            vLock = 1;
            lblStatus.Text = "Editable";

        }
        private void Desbloquear()
        {
            vLock = 0;

        }
        #endregion FINAL DE LOS METODOS

        public void CargarOrden()
        {
            Limpiar();
            Bloquear();



            DataRow vRow = dtOrdenCompras.Rows[0];
            vProveedorID = int.Parse(vRow["ProveedorID"].ToString());
            if (vProveedorID > 0)
            {
                vLock = 0;
                BuscarProveedores(vProveedorID);
                vLock = 1;
            }

            vOrdenCompras = int.Parse(vRow["OrdenCompraId"].ToString());
            Fecha.Value = C.Cdate(vRow["Fecha"].ToString());
            TipodeComprobanteID.SelectedValue = C.Cint(vRow["TipoComprobanteID"].ToString());
            NoComprobantes.Text = vRow["NoComprobante"].ToString();
            OrdenNumber.Text= vRow["OrdenCompraID"].ToString();
            Vendedor.Text= vRow["Usuario"].ToString();
            Prosesada = C.Cint(vRow["Process"].ToString());
            lblStatus.Text = (Prosesada == 1 ? "Orden Procesada" : "Editable");
            //formas de pago
            string Formasdepagos = vRow["Formasdepago"].ToString();
            int vv = 0;
            int indexof = 0;

            while (Formasdepagos.Length>0)
            {
                indexof = (Formasdepagos.IndexOf(",") == -1 ? Formasdepagos.Length : Formasdepagos.IndexOf(","));
                vv =int.Parse(Formasdepagos.Substring(0, indexof));
                for (int i = 0; i < FormadePagoID.Items.Count; i++)
                {
                    if(FormadePagoID.Items[i].Value.ToString()==vv.ToString())
                    {
                        FormadePagoID.Items[i].Checked = true;
                    }
                }
                if (indexof == Formasdepagos.Length) { break; }
                Formasdepagos = Formasdepagos.Substring(indexof+1, Formasdepagos.Length- (indexof+1));
            }


            Calcular();
            GRD.DataSource = dtOrdenCompras;
        }

        private void EntradaPedidos_Load(object sender, EventArgs e)
        {
            Vendedor.Text = C.vUserName;
            FillCombo();
            bNuevo_Click(null, null);
            dtOrdenCompras = C.SQL("ORDENCOMPRAS_L 0");
            GRD.DataSource = dtOrdenCompras;
            // vOrdenCompras = 18;
            if (vOrdenCompras > 0) { CargarOrden(); }
        }

        private void bBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void CodigoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar==13)
            {
                BuscarProveedor();
            }
            
        }

        private void CodigoProveedor_TextChanged(object sender, EventArgs e)
        {
            
            if(Nombre.Text.Length>0)
            {
                clearProveedor();
            }
          
        }

        private void Telefonos_TextChanged(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Prosesada == 1) { MessageBox.Show("Esta Orden ya Fue Procesada,No Puede Guardar cambios ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (vLock == 1) { return; }

          
                    if (!ValidarTodo()) { return; }
                    if (GRD.RowCount == 0)
                    { MessageBox.Show("No se Puede Guardar una Orden de Compras vacia, agrege articulos a la lista e intente de nuevo",
                        Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
                    sqlString += "Declare @OrdenID int;  set @ordenid = " + (vOrdenCompras==0?0: vOrdenCompras);
            
                    if(vOpt==0)
                    {
                        foreach (DataRow vRow in dtOrdenCompras.Rows)
                        {
                            sqlString += " Exec ORDENCOMPRAS_M " + vOpt + C.QII + (vOrdenCompras == 0 ? "@OrdenID" : vOrdenCompras.ToString()) + C.QII + vProveedorID + C.QIS + Fecha.Value + C.QSI +
                            (TipodeComprobanteID.SelectedValue == null ? "Null" : TipodeComprobanteID.SelectedValue) + C.QIS + NoComprobantes.Text + C.QSS + Formaspago + C.QSI +
                            C.vUserID + C.QII + vRow["ORDENCOMPRASDETALLEID"].ToString() + C.QII + vRow["ArticuloID"].ToString() + C.QII + vRow["Costo"].ToString() + C.QIS +
                            vRow["Lote"].ToString() + C.QSI + (C.Cdate(vRow["FechaExpiracion"].ToString()).Year==1?"NULL":"'" + vRow["FechaExpiracion"].ToString() +"'") + C.QII + vRow["Cantidad"].ToString() + C.QII +
                            AlmacenID.SelectedValue.ToString() + ", @OrdenID output ";
                        }
                    }
                    else
                    {
                        int addnew = 0;

                        foreach (DataRow vRow in dtOrdenCompras.Rows)
                        {
                            if(vRow["edit"].ToString()!="-1")
                            {
                                sqlString += " Exec ORDENCOMPRAS_M " + vOpt + C.QII + (vOrdenCompras == 0 ? "@OrdenID" : vOrdenCompras.ToString()) + C.QII + vProveedorID + C.QIS + Fecha.Value + C.QSI +
                            (TipodeComprobanteID.SelectedValue == null ? "Null" : TipodeComprobanteID.SelectedValue) + C.QIS + NoComprobantes.Text + C.QSS + Formaspago + C.QSI +
                            C.vUserID + C.QII + vRow["ORDENCOMPRASDETALLEID"].ToString() + C.QII + vRow["ArticuloID"].ToString() + C.QII + vRow["Costo"].ToString() + C.QIS +
                            vRow["Lote"].ToString() + C.QSI + (C.Cdate(vRow["FechaExpiracion"].ToString()).Year == 1 ? "NULL" : "'" + vRow["FechaExpiracion"].ToString() + "'") + C.QII + vRow["Cantidad"].ToString() + C.QII +
                            AlmacenID.SelectedValue.ToString() + ", @OrdenID output ";
                                addnew = 1;
                            }
                    
                        }

                        if(addnew==0)
                        {
                            DataRow vRow = dtOrdenCompras.Rows[0];
                            sqlString += " Exec ORDENCOMPRAS_M " + vOpt + C.QII + (vOrdenCompras == 0 ? "@OrdenID" : vOrdenCompras.ToString()) + C.QII + vProveedorID + C.QIS + Fecha.Value + C.QSI +
                           (TipodeComprobanteID.SelectedValue == null ? "Null" : TipodeComprobanteID.SelectedValue) + C.QIS + NoComprobantes.Text + C.QSS + Formaspago + C.QSI +
                           C.vUserID + C.QII + vRow["ORDENCOMPRASDETALLEID"].ToString() + C.QII + vRow["ArticuloID"].ToString() + C.QII + vRow["Costo"].ToString() + C.QIS +
                           vRow["Lote"].ToString() + C.QSI + (C.Cdate(vRow["FechaExpiracion"].ToString()).Year == 1 ? "NULL" : "'" + vRow["FechaExpiracion"].ToString() + "'") + C.QII + vRow["Cantidad"].ToString() + C.QII +
                            AlmacenID.SelectedValue.ToString() + ", @OrdenID output ";
                        }

                    }



                    dtOrdenCompras = C.SQL(sqlString + " exec ('ORDENCOMPRAS_L ' + @OrdenID)");
                    CargarOrden();
                    MessageBox.Show("Orden de Compras Guardada", Application.ProductName,MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message,Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void bAddArticulo_Click(object sender, EventArgs e)
        {

            if (vArticulo==0 || Descripcion.Text.Length==0)
            {
                MessageBox.Show("Indique que articulo desea agregar",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CodigoA.Focus();
                return;
            }

            if(Costo.Text=="0.00")
            {
                MessageBox.Show("Indique el Costo del Articulo ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Costo.Focus();
                return;
            }

            if (Cantidad.Text=="0")
            {
                MessageBox.Show("Indique la Cantidad de Articulos que decea agregar ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cantidad.Focus();
                return;
            }


            if(vedit==0)
            {

           
                dtOrdenCompras.PrimaryKey = new DataColumn[] { dtOrdenCompras.Columns["ArticuloID"]};
               
                DataRow vRowActual = dtOrdenCompras.Rows.Find(vArticulo);
            
                if (vRowActual==null)
                {
                    dtOrdenCompras.PrimaryKey = new DataColumn[] { dtOrdenCompras.Columns["ORDENCOMPRASDETALLEID"] };
                    decimal importes = (Convert.ToDecimal(Costo.Text) * Convert.ToDecimal(Cantidad.Text));
                    DataRow vRow = dtOrdenCompras.NewRow();
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
                    dtOrdenCompras.Rows.Add(vRow);
                }
                else
                {
                    if (vRowActual["Costo"].ToString() != Costo.Value.ToString() || vRowActual["Lote"].ToString()!= Lote.Text || vRowActual["FechaExpiracion"].ToString() != FechaExpiracion.Value.Date.ToString())
                    {
                        dtOrdenCompras.PrimaryKey = new DataColumn[] { dtOrdenCompras.Columns["ORDENCOMPRASDETALLEID"] };
                        decimal importes = (Convert.ToDecimal(Costo.Text) * Convert.ToDecimal(Cantidad.Text));
                        DataRow vRow = dtOrdenCompras.NewRow();
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
                        dtOrdenCompras.Rows.Add(vRow);
                    }
                    else
                    {
                        vRowActual["Edit"] = (vRowActual["Edit"].ToString()=="-1"?1:0);
                        vRowActual["Cantidad"] = int.Parse(vRowActual["Cantidad"].ToString()) + int.Parse(Cantidad.Value.ToString());
                        decimal importes = Convert.ToDecimal(vRowActual["Costo"].ToString()) * int.Parse(vRowActual["Cantidad"].ToString());
                        vRowActual["Importe"] = importes;
                    
                    }

      
                }
            }
            else
            {
                dtOrdenCompras.PrimaryKey = new DataColumn[] { dtOrdenCompras.Columns["ORDENCOMPRASDETALLEID"] };
                DataRow vRow = dtOrdenCompras.Rows.Find(vORDENCOMPRASDETALLEID);
                if(vRow!=null)
                {
                  
                    vRow["EDIT"] = 1;
                    vRow["Lote"] =Lote.Text;
                    vRow["FechaExpiracion"] = (FechaExpiracion.Value.Date);
                    vRow["Costo"] =Costo.Value;
                    vRow["Cantidad"] =Cantidad.Value;
                }
                
            }

            GRD.DataSource = dtOrdenCompras;
            LimpiarArticulo();
            Calcular();
            vedit = 0;
            CodigoA.Focus();

        }

        private void CodigoA_TextChanged(object sender, EventArgs e)
        {

            if (Descripcion.Text.Length > 0) { LimpiarArticulo(); }
        }

        private void bBuscarArticulo_Click(object sender, EventArgs e)
        {
            buscarArticulo();
        }

        private void CodigoA_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                buscarArticulo();
            }
        }


        private void Costo_TextChanged(object sender, EventArgs e)
        {
            if (vArticulo == 0  && Costo.Text !="0.00")
            {
                Lote.Text = "";
                MessageBox.Show("Seleccione el articulo que decea agregar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoA.Focus();
                return;
            }
            CalcularImporte();
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

        private void Lote_TextChanged(object sender, EventArgs e)
        {
            if(vArticulo==0)
            {
                Lote.Text = "";
                MessageBox.Show("Seleccione el articulo que decea agregar",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CodigoA.Focus();
            }
        }

        private void FechaExpiracion_ValueChanged(object sender, EventArgs e)
        {
            if (vArticulo == 0 && FechaExpiracion.Text=="01/01/0001")
            {
                Lote.Text = "";
                MessageBox.Show("Seleccione el articulo que decea agregar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoA.Focus();
            }
        }

        private void Cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                bAddArticulo_Click(null, null);
            }
        }

        private void TipodeComprobanteID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                FormadePagoID.Focus();
            }
        }

        private void FormadePagoID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                CodigoA.Focus();
            }
        }

        private void Lote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                FechaExpiracion.Focus();
            }
        }

        private void FechaExpiracion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Costo.Focus();
            }
        }

        private void Costo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Cantidad.Focus();
            }
        }

        private void TipodeComprobanteID_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            NoComprobantes.Enabled = true;
        }

        private void GRD_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (GRD.RowCount == 0 || !radGroupBox3.Enabled) { return; }

            vORDENCOMPRASDETALLEID = int.Parse(GRD.CurrentRow.Cells[0].Value.ToString());
                
            dtOrdenCompras.PrimaryKey = new DataColumn[] { dtOrdenCompras.Columns["ORDENCOMPRASDETALLEID"] };
            DataRow vRow = dtOrdenCompras.Rows.Find(vORDENCOMPRASDETALLEID);

            if(vRow!=null)
            {
                BuscarArticulos(int.Parse(vRow["ArticuloID"].ToString()));

                vedit = 1;
                Lote.Text = vRow["Lote"].ToString();
                FechaExpiracion.Value= C.Cdate(vRow["FechaExpiracion"].ToString());
                Costo.Value = vRow["Costo"].ToString();
                Cantidad.Value = vRow["Cantidad"].ToString();


            }
        }

        private void EntradaPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==113)
            {
                bBuscarArticulo_Click(null, null);
                return;
            }

            if (e.KeyValue == 112)
            {
                bBuscarProveedor_Click(null, null);
                return;
            }

            if (e.KeyValue == 114)
            {
                bProcesar_Click(null, null);
                return;
            }
        }

        private void bProcesar_Click(object sender, EventArgs e)
        {

            if (Prosesada == 1) { MessageBox.Show("Esta Orden ya Fue Procesada, no Puede ser procesada nuevamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (vOpt == 0) { return; }

            //Poner aqui que si un articulo se guarda por serie no pregunte y pase a introducir las serieas
            if (MessageBox.Show("Necesitas hacer modificaciones a la orden de compra (Cantidad de Articulos,Precio, Lote, Fecha Expiracion", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ModificarProcesar();
            }
            else
            {
                Procesar();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (Prosesada == 1) { MessageBox.Show("Esta Orden ya Fue Procesada, No puede Ser Editada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (vLock == 0) { return; }
            vOpt = 1;
            lblStatus.Text = "Editando";

        }

        private void CodigoProveedor_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
        {
            if (vLock == 1)
            { e.Cancel=true; }
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            vLock = 0;
            vOpt = 0;
            lblStatus.Text = "Creacion";
            Limpiar();
            
        }

        private void bNotas_Click(object sender, EventArgs e)
        {

        }
    }
}
