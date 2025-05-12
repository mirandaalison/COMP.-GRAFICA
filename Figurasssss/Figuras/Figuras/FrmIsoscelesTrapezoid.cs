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
    public partial class FrmIsoscelesTrapezoid : Form
    {

        CIsoscelesTrapezoid objIsoscelesTrapezoid = new CIsoscelesTrapezoid();
        public FrmIsoscelesTrapezoid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objIsoscelesTrapezoid.ReadData(txtBase1, txtBase2, txtHeight, txtSide);
            objIsoscelesTrapezoid.PerimeterIsoscelesTrapezoid();
            objIsoscelesTrapezoid.AreaIsoscelesTrapezoid();
            objIsoscelesTrapezoid.PrintData(txtPerimeter, txtArea);
        }
    }
}
