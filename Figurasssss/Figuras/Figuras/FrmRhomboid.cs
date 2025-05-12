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
    public partial class FrmRhomboid : Form
    {

        CRhomboid objRhomboid = new CRhomboid();
        public FrmRhomboid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRhomboid.ReadData(txtBase, txtHeight, txtSide);
            objRhomboid.PerimeterRhomboid();
            objRhomboid.AreaRhomboid();
            objRhomboid.PrintData(txtPerimeter, txtArea);
        }
    }
}
