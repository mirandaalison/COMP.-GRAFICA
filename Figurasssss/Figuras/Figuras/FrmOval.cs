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
    public partial class FrmOval : Form
    {

        COval objOval = new COval();
        public FrmOval()
        {
            InitializeComponent();
        }

        private void lblRadius_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objOval.ReadData(txtWidth, txtHeight);
            objOval.PerimeterOval();
            objOval.AreaOval();
            objOval.PrintData(txtPerimeter, txtArea);
        }
    }
}
