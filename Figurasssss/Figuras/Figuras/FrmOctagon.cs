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
    public partial class FrmOctagon : Form
    {

        COctagon objOctagon = new COctagon();
        public FrmOctagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objOctagon.ReadData(txtSide);
            objOctagon.PerimeterOctagon();
            objOctagon.AreaOctagon();
            objOctagon.PrintData(txtPerimeter, txtArea);
        }
    }
}
