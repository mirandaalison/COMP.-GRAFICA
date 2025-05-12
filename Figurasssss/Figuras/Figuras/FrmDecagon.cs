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
    public partial class FrmDecagon : Form
    {

        CDecagon objDecagon = new CDecagon();
        public FrmDecagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objDecagon.ReadData(txtSide);
            objDecagon.PerimeterDecagon();
            objDecagon.AreaDecagon();
            objDecagon.PrintData(txtPerimeterDecagon, txtAreaDecagon);
        }
    }
}
