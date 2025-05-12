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
    public partial class FrmEllipse : Form
    {

        CEllipse objEllipse = new CEllipse();
        public FrmEllipse()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objEllipse.ReadData(txtSemiMajorAxis, txtSemiMinorAxis);
            objEllipse.PerimeterEllipse();
            objEllipse.AreaEllipse();
            objEllipse.PrintData(txtPerimeter, txtArea);
        }
    }
}
