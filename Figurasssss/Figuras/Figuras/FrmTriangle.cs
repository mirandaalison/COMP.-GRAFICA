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
    public partial class FrmTriangle : Form
    {

        CTriangle objTriangle = new CTriangle();
        public FrmTriangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTriangle.ReadData(txtSide, txtSideDos, txtSideTres);
            objTriangle.PerimeterTriangle();
            objTriangle.AreaTriangle();
            objTriangle.PrintData(txtPerimeter, txtArea);
        }
    }
}
