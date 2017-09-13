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
    public partial class FBackup : Form
    {
        DataTable dtresult = new DataTable();
        public FBackup()
        {
            InitializeComponent();
        }

        private void FBackup_Load(object sender, EventArgs e)
        {

        }

        private void bBackup_Click(object sender, EventArgs e)
        {
            dtresult = C.SQL("[BACKUPDATEBASE_S] ");

            if (dtresult.Rows.Count==0) { MessageBox.Show("Favor Contactar a su Supervisor o al encargado de sistemas", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if(dtresult.Rows[0]["R"].ToString()=="0")
            {
                MessageBox.Show(dtresult.Rows[0]["MSGBOX"].ToString(),Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(dtresult.Rows[0][0].ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
