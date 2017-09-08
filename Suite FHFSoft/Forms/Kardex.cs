﻿using System;
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
    public partial class Kardex : Form
    {
        public int vArticuloID;

        DataTable dtSurcursal = new DataTable();
        DataTable dtKardex = new DataTable();
        public Kardex()
        {
            InitializeComponent();
        }

        private void FillCombo()
        {
            AlmacenID.DisplayMember = "Descripcion";
            AlmacenID.ValueMember = "SucursalID";
            dtSurcursal = C.SQL("SUCURSAL_L " + C.vPerfilID);
            AlmacenID.DataSource = dtSurcursal;

            UsuarioID.DisplayMember = "NombreCompleto";
            UsuarioID.ValueMember = "Susuarioid";
            UsuarioID.DataSource = C.SQL("USUARIOS_L") ;

            ArticuloId.DisplayMember = "Descripcion";
            ArticuloId.ValueMember = "ArticuloID";
            ArticuloId.DataSource = C.SQL("[ARTICULOS_L] ");

            
            

            
        }

        private void FillGrid()
        {

            if (ArticuloId.SelectedValue == null) { MessageBox.Show("Seleccione Un Articulo Para buscar su Kardex "); return; }
                dtKardex = C.SQL("KARDEX_L 0," + ArticuloId.SelectedValue + C.QII+ (Date1.Value.Year==1?"NULL": "'" + Date1.Value.Date.ToString() + "'" ) + C.QII + (Date2.Value.Year == 1 ? "NULL" : "'" + Date2.Value.Date.ToString() + "'") + C.QII +
                (AlmacenID.SelectedValue == null ? "NULL" : AlmacenID.SelectedValue.ToString() ) + C.QII + (UsuarioID.SelectedValue == null ? "NULL" : UsuarioID.SelectedValue.ToString()));
            GRD.DataSource = dtKardex;
        }

        private void Kardex_Load(object sender, EventArgs e)
        {
            FillCombo();
            AlmacenID.SelectedValue = (dtSurcursal.Rows.Count == 1 ? Convert.ToInt64(dtSurcursal.Rows[0]["SucursalID"].ToString()) : 0);
            AlmacenID.ReadOnly= (dtSurcursal.Rows.Count == 1 ? true : false);
            UsuarioID.Text = "";
            Date1.Text = "";
            Date2.Value = DateTime.Today.Date;
            ArticuloId.SelectedValue = vArticuloID;
            FillGrid();

        }

        private void ArticuloId_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            lblArticulo.Text = ArticuloId.Text;
            FillGrid();
        }
    }
}
