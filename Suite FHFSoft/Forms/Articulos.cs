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
    public partial class Articulos : Form
    {
        int vArticulos = 0;
        int vOpt = 0;
        DataTable dtArticulo = new DataTable();
        DataTable dtArticulodetalle = new DataTable();
        public Articulos()
        {
            InitializeComponent();
        }

        #region METODOS
        private void FillCombos()
        {
            CategoriaID.DisplayMember = "Descripcion";
            CategoriaID.ValueMember = "CategoriaID";
            CategoriaID.DataSource = C.SQL("Categorias_L ");

            MarcaID.DisplayMember = "Descripcion";
            MarcaID.ValueMember = "MarcaID";
            MarcaID.DataSource = C.SQL("Marcas_L");

            UnidadMedidaID.DisplayMember = "Descripcion";
            UnidadMedidaID.ValueMember = "UnidadMedidaID";
            UnidadMedidaID.DataSource = C.SQL("UNIDADESMEDIDAS_L ");

            ITBISID.DisplayMember = "Descripcion";
            ITBISID.ValueMember = "ItbisID";
            ITBISID.DataSource = C.SQL("ITBIS_L ");




        }

        private void Putdata()
        {
            try
            {
                dtArticulo.PrimaryKey = new DataColumn[] { dtArticulo.Columns["ArticuloID"] };
                DataRow vRow = dtArticulo.Rows.Find(vArticulos);

                setNewArticulo();
                vArticulos = C.Cint(vRow["ArticuloId"].ToString());
                dtArticulodetalle = C.SQL("Articulos_L " + vArticulos + ",NULL,1");
                grdArticulos.DataSource = dtArticulodetalle;
                Codigo.Text = vRow["Codigo"].ToString();
                lblStatus.Text = "Editable";
                Descripcion.Text = vRow["Descripcion"].ToString();
                CodigodeBarras.Text = vRow["CodigoBarras"].ToString();
                CodigodeBarras.Enabled = (vRow["CodigoBarras"].ToString().Length>0?false:true);
                CategoriaID.SelectedValue = C.Cint(vRow["CategoriaID"].ToString());
                SubCategoriaID.SelectedValue = C.Cint(vRow["SubcategoriaID"].ToString());
                Fecha.Value = C.Cdate(vRow["FechaCreacion"].ToString());
                Stock.Value= C.Cint(vRow["StockMinimo"].ToString());
                stockM.Value = C.Cint(vRow["StockMaximo"].ToString());
                ITBISID.SelectedValue = C.Cint(vRow["ITBISID"].ToString());
                UnidadMedidaID.SelectedValue = C.Cint(vRow["UnidadMedidaID"].ToString());
                MarcaID.SelectedValue = C.Cint(vRow["MarcaID"].ToString());
                Estatus.Checked = (vRow["Estatus"].ToString() == "1" ? true : false);
                Notas.Text = vRow["Notas"].ToString();
                clearAuxiliar();
                setNoEditable();
                bEditar.Enabled = true;
                bGuardar.Enabled = false;


            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                setNewArticulo();

            }


        }

        private void setEditable()
        {
            Codigo.ReadOnly = true;
            Descripcion.ReadOnly = false;
            CodigodeBarras.ReadOnly = false;
            CategoriaID.ReadOnly = false;
            SubCategoriaID.ReadOnly = false;

            Stock.ReadOnly = false;
            stockM.ReadOnly = false;
            ITBISID.ReadOnly = false;
            UnidadMedidaID.ReadOnly = false;
            UnidadMedidaID.Enabled = (dtArticulodetalle.Rows.Count > 0 ? false : true);
            MarcaID.ReadOnly = false;
            Estatus.ReadOnly = false;
            Notas.ReadOnly = false;

            DescripcionD.ReadOnly = false;
            CodigoD.ReadOnly = false;
            CodigoBarrasD.ReadOnly = false;
            UnidadMedidaD.ReadOnly = false;
            NotasD.ReadOnly = false;
            btagregar.Enabled = true;

            bNuevo.Enabled = true;
            bEditar.Enabled = false;
            bGuardar.Enabled = true;
            bDeshacer.Enabled = true;
        }

        private void setNoEditable()
        {
            Codigo.ReadOnly = true;
            Descripcion.ReadOnly = true;
            CodigodeBarras.ReadOnly = true;
            CategoriaID.ReadOnly = true;
            SubCategoriaID.ReadOnly = true;

            Stock.ReadOnly = true;
            stockM.ReadOnly = true;
            ITBISID.ReadOnly = true;
            UnidadMedidaID.ReadOnly = true;
            MarcaID.ReadOnly = true;
            Estatus.ReadOnly = true;
            Notas.ReadOnly = true;

            DescripcionD.ReadOnly = true;
            CodigoD.ReadOnly = true;
            CodigoBarrasD.ReadOnly = true;
            UnidadMedidaD.ReadOnly = true;
            NotasD.ReadOnly = true;
            btagregar.Enabled = false;

            bNuevo.Enabled = true;
            bEditar.Enabled = true;
            bGuardar.Enabled = false;
            bDeshacer.Enabled = true;
        }
        private void setNewArticulo()
        {
            vArticulos = 0;
            lblStatus.Text = "Creando";
            vOpt = 0;
            Codigo.Text = "";
            Descripcion.Text = "";
            CodigodeBarras.Text = "";
            CategoriaID.Text = "";
            SubCategoriaID.Text = "";
            Fecha.Value = DateTime.Today;
            Stock.Value = 0;
            ITBISID.Text = "";
            UnidadMedidaID.Text = "";
            MarcaID.Text = "";
            Estatus.Checked = true;
            Notas.Text = "";
            dtArticulodetalle = C.SQL("Articulos_L " + 0 + ",NULL,1");
            grdArticulos.DataSource = dtArticulodetalle;
            clearAuxiliar();
            setEditable();
            UnidadMedidaID.Enabled = true;
            CodigodeBarras.Enabled = true;


        }

        private void FillGrid()
        {
            dtArticulo = C.SQL("Articulos_L ");
            GRD.DataSource = dtArticulo;
        }

        private bool Validacion()
        {
            if (Descripcion.Text.Length == 0)
            {
                MessageBox.Show("Debes Digitar un Nombre de Articulo");
                Descripcion.Focus();
                return false;
            }

            return true;
        }

        #endregion FINAL DE METODOS
        private void Articulos_Load(object sender, EventArgs e)
        {
            FillCombos();
            
            FillGrid();
            setNewArticulo();

        }

        private void radPageViewPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoriaID_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            SubCategoriaID.DisplayMember = "Descripcion";
            SubCategoriaID.ValueMember = "SubcategoriaID";
            SubCategoriaID.DataSource = C.SQL("Subcategorias_L " + (CategoriaID.SelectedValue == null ? "0" : CategoriaID.SelectedValue.ToString()));

            SubCategoriaID.Text = "";
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            setNewArticulo();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Editando";
            vOpt = 1;
            setEditable();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacion())
                {
                    return;
                }

                string vsql="";

                vsql = "Set nocount on  Declare @ID int  SET @ID = " + vArticulos + Environment.NewLine;

                vsql += " Exec Articulos_M " + vOpt + C.QII + vArticulos + C.QIS + Descripcion.Text + C.QSS + Codigo.Text + C.QSS + CodigodeBarras.Text + C.QSI +
                (CategoriaID.SelectedValue == null ? "NULL" : CategoriaID.SelectedValue) + C.QII + (SubCategoriaID.SelectedValue == null ? "NULL" : SubCategoriaID.SelectedValue) +
                C.QII + Stock.Value + C.QII + (ITBISID.SelectedValue == null ? "NULL" : ITBISID.SelectedValue) + C.QII + (UnidadMedidaID.SelectedValue == null ? "NULL" : UnidadMedidaID.SelectedValue) +
                C.QII + (MarcaID.SelectedValue == null ? "NULL" : MarcaID.SelectedValue) + C.QIS + Notas.Text + C.QSI + C.vUserID + C.QII + (Estatus.Checked == true ? 1 : 0) + C.QII + 1 + ",NULL,"+stockM.Value + C.QII + (FechaExpiracion.Checked == true ? 1 : 0) + ", @ID OUTPUT" + Environment.NewLine;


                foreach (DataRow vRow in dtArticulodetalle.Rows)
                {
                    vsql += " Exec Articulos_M " + vRow["Edit"] + C.QII + "@ID" + C.QIS + vRow["Descripcion"] + C.QSS + vRow["Codigo"] + C.QSS + vRow["CodigoBarras"] + C.QSI +
                   (CategoriaID.SelectedValue == null ? "NULL" : CategoriaID.SelectedValue) + C.QII + (SubCategoriaID.SelectedValue == null ? "NULL" : SubCategoriaID.SelectedValue) +
                   C.QII + Stock.Value + C.QII + (ITBISID.SelectedValue == null ? "NULL" : ITBISID.SelectedValue) + C.QII + vRow["UnidadMedidaID"] +
                   C.QII + (MarcaID.SelectedValue == null ? "NULL" : MarcaID.SelectedValue) + C.QIS + Notas.Text + C.QSI + C.vUserID + C.QII + vRow["Estatus"] + C.QII + 2 + ",@ID,"+stockM.Value + C.QII + (FechaExpiracion.Checked == true ? 1 : 0) + ", @ID OUTPUT" + Environment.NewLine;
                }


                C.SQL(vsql);

        
                    int v = vOpt;
                    bNuevo_Click(null, null);
                    MessageBox.Show("Articulo " + (vOpt == 0 ? "Guardado" : "Actualizado") + " Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtArticulo = C.SQL("Articulos_L ");
                    GRD.DataSource = dtArticulo;
          


                return;


            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MasterTemplate_SelectionChanged(object sender, EventArgs e)
        {
            setNewArticulo();
        }

        private void MasterTemplate_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            vArticulos = Convert.ToInt32(GRD.CurrentRow.Cells[0].Value);
            Putdata();

        }

        private void bDeshacer_Click(object sender, EventArgs e)
        {
            if (vArticulos == 0)
            {
                setNewArticulo();
            }
            else
            {
                Putdata();
            }
        }

        private void actualizarPrecioDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrecioVentas form = new PrecioVentas();
            form.vForm = this.Name;
            form.vArticuloID = Convert.ToInt32(GRD.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            FillGrid();

        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kardex form = new Kardex();
            form.vArticuloID = Convert.ToInt32(GRD.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void GRD_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            
        }

        private void bImprimirArticulos_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.MdiParent = MainMenu.ActiveForm;
            frm.vReportName = "ListaArticulos.rpt";
            frm.vImprimir = 0;
            frm.vSQLString = "[ARTICULOS_R] ";
            frm.vTitleReports = "Lista de Articulos";
            frm.SetTitle();
            frm.Show();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {

            if (DescripcionD.Text.Length == 0)
            {
                MessageBox.Show("Debes Digitar un Nombre del Articulo Auxiliar");
                DescripcionD.Focus();
                return;
            }
            if (CodigoD.Text.Length == 0)
            {
                MessageBox.Show("Debes Digitar un Codigo para el Articulo Auxiliar");
                CodigoD.Focus();
                return;
            }
            if (UnidadMedidaD.Text.Length == 0 || UnidadMedidaD.SelectedValue==null)
            {
                MessageBox.Show("Debes Seleccionar  una unidad de medida para el Articulo Auxiliar");
                UnidadMedidaD.Focus();
                return;
            }



            DataRow vRow = dtArticulodetalle.NewRow();
            vRow["Edit"] = 0;
            vRow["Descripcion"] = DescripcionD.Text;
            vRow["Codigo"] = CodigoD.Text;
            vRow["CodigoBarras"] = CodigoBarrasD.Text;
            vRow["UnidadMedidaID"] = UnidadMedidaD.SelectedValue;
            vRow["UnidadMedida"] = UnidadMedidaD.Text;
            vRow["Estatus"] = (EstatusD.Checked == true ? 1 : 0);
            dtArticulodetalle.Rows.Add(vRow);
            clearAuxiliar();
        }
        private void clearAuxiliar()
        {
            DescripcionD.Text = "";
            CodigoD.Text = "";
            CodigoBarrasD.Text = "";
            UnidadMedidaD.Text = "";
            NotasD.Text = "";
            UnidadMedidaD.SelectedValue = null;
            EstatusD.Checked = true;
        }

        private void UnidadMedidaID_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UnidadMedidaD.DisplayMember = "Descripcion";
            UnidadMedidaD.ValueMember = "UnidadMedidaAUID";
            UnidadMedidaD.DataSource =  C.SQL("UNIDADESMEDIDASAU_L " + (UnidadMedidaID.SelectedValue == null ? "NULL" : UnidadMedidaID.SelectedValue.ToString()));

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrecioVentas form = new PrecioVentas();
            form.vForm = this.Name;
            form.vArticuloID = Convert.ToInt32(grdArticulos.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            dtArticulodetalle = C.SQL("Articulos_L " + vArticulos + ",NULL,1");
            grdArticulos.DataSource = dtArticulodetalle;

        }

        private void CodigoD_Leave(object sender, EventArgs e)
        {
            if (CodigoD.Text == "") { return; }
            if (C.SQL("Codigoveri 1," + CodigoD.Text).Rows[0]["R"].ToString()!="0" )
            {
                MessageBox.Show("Este codigo existe para otro articulo favor de ingresar un codigo difrente");
                CodigoD.Focus();
                CodigoD.Text = "";
            }
        }

        private void CodigoBarrasD_Leave(object sender, EventArgs e)
        {
            if (CodigoBarrasD.Text == "") { return; }
            if (C.SQL("Codigoveri 2," + CodigoBarrasD.Text).Rows[0]["R"].ToString() != "0")
            {
                MessageBox.Show("Este codigo de barras existe para otro articulo favor de ingresar un codigo diferente");
                CodigoBarrasD.Focus();
                CodigoBarrasD.Text = "";
            }
        }

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (Codigo.Text == "") { return; }
            if (C.SQL("Codigoveri 1," + Codigo.Text).Rows[0]["R"].ToString() != "0" && vOpt==0)
            {
                MessageBox.Show("Este codigo de barras existe para otro articulo favor de ingresar un codigo diferente");
                Codigo.Focus();
                Codigo.Text = "";
                return;
            }

        }

        private void CodigodeBarras_Leave(object sender, EventArgs e)
        {
            if (CodigodeBarras.Text == "") { return; }
            if (C.SQL("Codigoveri 2," + CodigodeBarras.Text).Rows[0]["R"].ToString() != "0" && vOpt == 0)
            {
                MessageBox.Show("Este codigo de barras de barras existe para otro articulo favor de ingresar un codigo diferente");
                CodigodeBarras.Focus();
                CodigodeBarras.Text = "";
            }
        }

        private void busqueda_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtArticulo);
            dv.RowFilter = "Descripcion like '%" + busqueda.Text + "%'";
            GRD.DataSource = dv;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            busqueda.Text = "";
        }
    }
}
