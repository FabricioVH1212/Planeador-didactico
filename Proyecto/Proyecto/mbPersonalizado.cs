using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class mbPersonalizado : Form
    {
        public mbPersonalizado()
        {
            InitializeComponent();
        }

        private void mbPersonalizado_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigoTecla = (int)e.KeyChar;
            if (codigoTecla == 13)
            {
                btn_Aceptar_Click(sender, e);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
