using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figuras
{
    public partial class FrmSquare : Form
    {

        CSquare objSquare = new CSquare();
        public FrmSquare()
        {
            InitializeComponent();
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objSquare.ReadData(txtSide);
            objSquare.PerimeterSquare();
            objSquare.AreaSquare();
            objSquare.PrintData(txtPerimeter, txtArea);

        }
    }
}
