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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            frmRectangle frmRectangle = new frmRectangle();
            frmRectangle.ShowDialog();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            FrmSquare frmSquare = new FrmSquare();
            frmSquare.ShowDialog();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            FrmTriangle frmTriangle = new FrmTriangle();
            frmTriangle.ShowDialog();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            FrmCircle frmCircle = new FrmCircle();
            frmCircle.ShowDialog();
        }

        private void btnRhombus_Click(object sender, EventArgs e)
        {
            FrmRhombus frmRhombus = new FrmRhombus();
            frmRhombus.ShowDialog();
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            FrmPentagon frmPentagon = new FrmPentagon();
            frmPentagon.ShowDialog();
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            FrmHexagon frmHexagon = new FrmHexagon();
            frmHexagon.ShowDialog();
        }

        private void btnTrapezoid_Click(object sender, EventArgs e)
        {
            FrmTrapezoid frmTrapezoid = new FrmTrapezoid();
            frmTrapezoid.ShowDialog();
        }

        private void btnIsoscelesTrapezoid_Click(object sender, EventArgs e)
        {
            FrmIsoscelesTrapezoid frmIsoscelesTrapezoid = new FrmIsoscelesTrapezoid();
            frmIsoscelesTrapezoid.ShowDialog();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            FrmEllipse frmEllipse = new FrmEllipse();
            frmEllipse.ShowDialog();
        }

        private void btnRhomboid_Click(object sender, EventArgs e)
        {
            FrmRhomboid frmRhomboid = new FrmRhomboid();
            frmRhomboid.ShowDialog();
        }

        private void btnOval_Click(object sender, EventArgs e)
        {
            FrmOval frmOval = new FrmOval();
            frmOval.ShowDialog();
        }

        private void btnOctagon_Click(object sender, EventArgs e)
        {
            FrmOctagon frmOctagon = new FrmOctagon();
            frmOctagon.ShowDialog();
        }

        private void btnHeptagon_Click(object sender, EventArgs e)
        {
            FrmHeptagon frmHeptagon = new FrmHeptagon();
            frmHeptagon.ShowDialog();
        }

        private void btnDecagon_Click(object sender, EventArgs e)
        {
            FrmDecagon frmDecagon = new FrmDecagon();
            frmDecagon.ShowDialog();
        }

        private void btnEnneagon_Click(object sender, EventArgs e)
        {
            FrmEnneagon frmEnneagon = new FrmEnneagon();
            frmEnneagon.ShowDialog();
        }

        private void btnDeltoid_Click(object sender, EventArgs e)
        {
            FrmDeltoid frmDeltoid = new FrmDeltoid();
            frmDeltoid.ShowDialog();
        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrapezium = new FrmTrapecio();
            frmTrapezium.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnneagon_Click_1(object sender, EventArgs e)
        {
            FrmEnneagon frmEnneagon = new FrmEnneagon();
            frmEnneagon.ShowDialog();
        }
    }
}
