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
    public partial class FrmTrapecio : Form
    {

        CTrapecio objTrapecio = new CTrapecio();
        public FrmTrapecio()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTrapecio.ReadData(txtBase1, txtBase2, txtSide1, txtSide2, txtHeight);
            objTrapecio.PerimeterTrapecio();
            objTrapecio.AreaTrapecio();
            objTrapecio.PrintData(txtPerimeter, txtArea);
        }
    }
}
