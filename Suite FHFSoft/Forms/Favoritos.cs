using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
namespace Suite_FHFSoft
{
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();
        }

        DataTable dtfavorites = new DataTable();
        private void Favoritos_Load(object sender, EventArgs e)
        {
            dtfavorites = C.SQL("MISFAVORITOS_L " + C.vUserID);

            foreach ( DataRow vRow in dtfavorites.Rows)
            {
                ListViewDataItem checkedItem = new ListViewDataItem(vRow["detalle"].ToString());
                checkedItem.ImageIndex = C.Cint(vRow["ImageID"].ToString());
                checkedItem.Tag = vRow["MenuitemID"].ToString();
                checkedItem.CheckState =(vRow["Access"].ToString()=="0"? ToggleState.Off: ToggleState.On);
                this.FavoritosList.Items.Add(checkedItem);
            }
            

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {

            string sqlstring = "EXEC FAVORITOS_M 0," + C.vUserID;
            
            for (int i = 0; i < FavoritosList.Items.Count; i++)
            {
                if (FavoritosList.Items[i].CheckState==ToggleState.On)
                {
                    sqlstring += "  EXEC FAVORITOS_M 1," + C.vUserID + C.QII + FavoritosList.Items[i].Tag.ToString();
                }

            }

            dtfavorites =  C.SQL(sqlstring + " EXEC MISFAVORITOS_L " + C.vUserID);

            for (int i = 0; i <= Application.OpenForms.Count - 1; i++)
            {
                if (Application.OpenForms[i].Name == "MainMenu")
                {
                    ((MainMenu)Application.OpenForms[i]).setFavorites(dtfavorites);
                       
                }
            }

              this.Close();
        }
    }
}
