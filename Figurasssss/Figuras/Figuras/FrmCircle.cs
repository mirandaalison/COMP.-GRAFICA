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
    public partial class FrmCircle : Form
    {

        CCircle objCircle = new CCircle();
        public FrmCircle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objCircle.ReadData(txtRadius);
            objCircle.PerimeterCircle();
            objCircle.AreaCircle();
            objCircle.PrintData(txtPerimeter, txtArea);
        }
    }
}
