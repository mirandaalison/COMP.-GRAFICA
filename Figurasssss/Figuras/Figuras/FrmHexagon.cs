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
    public partial class FrmHexagon : Form
    {
        CHexagon objHexagon = new CHexagon();
        public FrmHexagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objHexagon.ReadData(txtSide);
            objHexagon.PerimeterHexagon();
            objHexagon.AreaHexagon();
            objHexagon.PrintData(txtPerimeter, txtArea);
        }
    }
}
