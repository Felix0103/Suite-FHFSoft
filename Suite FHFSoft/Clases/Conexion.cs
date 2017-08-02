using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Suite_FHFSoft.Clases
{
    class Conexion
    {

        public static DataTable SQL(string SP)
        {


            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(SP, Properties.Settings.Default.Setting.ToString());
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }
    }
}





