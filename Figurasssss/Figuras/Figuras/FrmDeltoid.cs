using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class FrmDeltoid : Form
    {

        CDeltoid objDeltoid = new CDeltoid();
        public FrmDeltoid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objDeltoid.ReadData(txtDiagonal1,txtDiagonal2, txtSide1, txtSide2);
            objDeltoid.PerimeterDeltoid();
            objDeltoid.AreaDeltoid();
            objDeltoid.PrintData(txtPerimeter, txtArea);
        }
    }
}
