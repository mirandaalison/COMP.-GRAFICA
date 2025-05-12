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
    public partial class FrmTrapezoid : Form
    {

        CTrapezoid objTrapezoid = new CTrapezoid();
        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTrapezoid.ReadData(txtSide1, txtSide2, txtSide3, txtSide4, txtDiagonal1);

            objTrapezoid.PerimeterTrapezoid();
            objTrapezoid.AreaTrapezoid();
            objTrapezoid.PrintData(txtPerimeter, txtArea);
        }
    }
}
