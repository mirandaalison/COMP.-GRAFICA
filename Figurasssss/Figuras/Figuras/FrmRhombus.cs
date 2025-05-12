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
    public partial class FrmRhombus : Form
    {

        CRhombus objRhombus = new CRhombus();
        public FrmRhombus()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRhombus.ReadData(txtSide, txtDiagonalA, txtDiagonalB);
            objRhombus.PerimeterRhombus();
            objRhombus.AreaRhombus();
            objRhombus.PrintData(txtPerimeter, txtArea);
        }
    }
}
