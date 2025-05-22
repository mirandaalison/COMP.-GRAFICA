using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerEstrella;

namespace zurita_leccion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEstrella1_Click(object sender, EventArgs e)
        {
            FrmEstrella1 frmEstrella1 = new FrmEstrella1();
            frmEstrella1.ShowDialog();
        }

        private void btnEstrella2_Click(object sender, EventArgs e)
        {
            figuras figuras = new figuras();
            figuras.ShowDialog();
        }
    }
}
