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
    public partial class FrmEnneagon : Form
    {

        CEnneagon objEnneagon = new CEnneagon();
        public FrmEnneagon()
        {
            InitializeComponent();
        }

        private void lblInstruccion_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objEnneagon.ReadData(txtSide);
            objEnneagon.PerimeterEnneagon();
            objEnneagon.AreaEnneagon();
            objEnneagon.PrintData(txtPerimeter, txtArea);
        }
    }
}
