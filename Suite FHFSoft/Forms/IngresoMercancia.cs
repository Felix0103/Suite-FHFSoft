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
            bGuardar.Enabled = true;
            bEdit.Enabled = false;
            bProcesar.Enabled = false;
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


        }

    }
}
