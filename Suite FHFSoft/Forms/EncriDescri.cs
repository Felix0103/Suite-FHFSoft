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
    public partial class EncriDescri : Form
    {
        public EncriDescri()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValorAscii_TextChanged(object sender, EventArgs e)
        {
            Encrip.Text = Seguridad.Encriptar(ValorAscii.Text);
        }
    }
}
