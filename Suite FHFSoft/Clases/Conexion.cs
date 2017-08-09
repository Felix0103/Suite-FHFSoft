using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;


namespace Suite_FHFSoft
{
    public static class C
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

        public static void OpenForm(String FormName)
        {

            try
            {
                Assembly asm = Assembly.GetEntryAssembly();
                Type formtype = asm.GetType("Suite_FHFSoft." + FormName);
                Form form = (Form)Activator.CreateInstance(formtype);

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == form.GetType())
                    {
                        frm.BringToFront();
                        return;
                    }
                }

                form.MdiParent = MainMenu.ActiveForm;
                //form.StartPosition = FormStartPosition.CenterScreen;
                form.Icon = MainMenu.ActiveForm.Icon;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                return;
            }
            catch (Exception)
            {

                MessageBox.Show("El Formulario " + FormName + " No fue encontrado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public static DateTime Cdate(string dato)
        {
            try
            {
                DateTime date = Convert.ToDateTime(dato);
                return date;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateTime date = new DateTime();
                return date ;
            }
           
        }
        public static int Cint(string dato)
        {
            try
            {
                int date = Convert.ToInt32(dato);
                return date;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                int date = new int();
                return date;
            }

        }

        public static string QSS = "','";
        public static string QII = ",";
        public static string QIS = ",'";
        public static string QSI = "',";
        public static string QS = "'";
        public static string vProfileName;
        public static string vUserName;
        public static int vUserID;
        public static int vSucursalID;
        public static int vPerfilID;
        public static string vSucursalName;
    }
}





