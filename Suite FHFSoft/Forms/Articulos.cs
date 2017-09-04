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
                Codigo.Text = vRow["Codigo"].ToString();
                lblStatus.Text = "Editable";
                Descripcion.Text = vRow["Descripcion"].ToString();
                CodigodeBarras.Text = vRow["CodigoBarras"].ToString();
                CategoriaID.SelectedValue = C.Cint(vRow["CategoriaID"].ToString());
                SubCategoriaID.SelectedValue = C.Cint(vRow["SubcategoriaID"].ToString());
                Fecha.Value = C.Cdate(vRow["FechaCreacion"].ToString());
                Stock.Value= C.Cint(vRow["StockMinimo"].ToString());
                ITBISID.SelectedValue = C.Cint(vRow["ITBISID"].ToString());
                UnidadMedidaID.SelectedValue = C.Cint(vRow["UnidadMedidaID"].ToString());
                MarcaID.SelectedValue = C.Cint(vRow["MarcaID"].ToString());
                Estatus.Checked = (vRow["Estatus"].ToString() == "1" ? true : false);
                Notas.Text = vRow["Notas"].ToString();

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
            Codigo.ReadOnly = false;
            Descripcion.ReadOnly = false;
            CodigodeBarras.ReadOnly = false;
            CategoriaID.ReadOnly = false;
            SubCategoriaID.ReadOnly = false;

            Stock.ReadOnly = false;
            ITBISID.ReadOnly = false;
            UnidadMedidaID.ReadOnly = false;
            MarcaID.ReadOnly = false;
            Estatus.ReadOnly = false;
            Notas.ReadOnly = false;

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
            ITBISID.ReadOnly = true;
            UnidadMedidaID.ReadOnly = true;
            MarcaID.ReadOnly = true;
            Estatus.ReadOnly = true;
            Notas.ReadOnly = true;

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

            setEditable();



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

                dtArticulo = C.SQL("Articulos_M " + vOpt + C.QII + vArticulos + C.QIS + Descripcion.Text + C.QSS + Codigo.Text + C.QSS + CodigodeBarras.Text + C.QSI + 
                (CategoriaID.SelectedValue == null ? "NULL" : CategoriaID.SelectedValue) + C.QII + (SubCategoriaID.SelectedValue == null ? "NULL" : SubCategoriaID.SelectedValue) +
                C.QII + Stock.Value + C.QII + (ITBISID.SelectedValue == null ? "NULL" : ITBISID.SelectedValue) + C.QII + (UnidadMedidaID.SelectedValue == null ? "NULL" : UnidadMedidaID.SelectedValue) +
                C.QII + (MarcaID.SelectedValue == null ? "NULL" : MarcaID.SelectedValue) + C.QIS + Notas.Text + C.QSI +C.vUserID + C.QII + (Estatus.Checked == true ? 1 : 0));



                if (dtArticulo.Rows[0][0].ToString() == "0")
                {
                    int v = vOpt;
                    bNuevo_Click(null, null);
                    MessageBox.Show("Articulo " + (v == 0 ? "Guardado" : "Actualizado") + " Exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GRD.DataSource = dtArticulo;
                }
                else
                {

                    MessageBox.Show(dtArticulo.Rows[0][0].ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtArticulo = C.SQL("Articulos_L ");
                    GRD.DataSource = dtArticulo;
                }


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
            

        }
    }
}
