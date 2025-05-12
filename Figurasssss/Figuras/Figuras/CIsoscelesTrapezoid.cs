using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CIsoscelesTrapezoid
    {
        private float mBase1;
        private float mBase2;
        private float mHeight;
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CIsoscelesTrapezoid()
        {
            mBase1 = 0.0f;
            mBase2 = 0.0f;
            mHeight = 0.0f;
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight, TextBox txtSide)
        {
            try
            {
                mBase1 = float.Parse(txtBase1.Text);
                mBase2 = float.Parse(txtBase2.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide = float.Parse(txtSide.Text);

                if (!IsValidIsoscelesTrapezoid())
                {
                    MessageBox.Show("No es un trapecio isóceles válido",
                                   "Mensaje de error");
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }

        private bool IsValidIsoscelesTrapezoid()
        {
            float baseDiff = Math.Abs(mBase1 - mBase2) / 2;
            float sideCalculated = (float)Math.Sqrt(mHeight * mHeight + baseDiff * baseDiff);

            return Math.Abs(sideCalculated - mSide) < 0.0001f;
        }

        public void PerimeterIsoscelesTrapezoid()
        {
            mPerimeter = mBase1 + mBase2 + 2 * mSide;
        }

        public void AreaIsoscelesTrapezoid()
        {
            mArea = ((mBase1 + mBase2) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight, TextBox txtSide,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase1 = 0.0f;
            mBase2 = 0.0f;
            mHeight = 0.0f;
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtBase1.Text = "";
            txtBase2.Text = "";
            txtHeight.Text = "";
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtBase1.Focus();
            picCanvas.Refresh();
        }

        

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}