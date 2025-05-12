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
    public partial class FrmPentagon : Form
    {

        CPentagon objPentagon = new CPentagon();
        public FrmPentagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objPentagon.ReadData(txtSide);
            objPentagon.PerimeterPentagon();
            objPentagon.AreaPentagon();
            objPentagon.PrintData(txtPerimeter, txtArea);
        }
    }
}
