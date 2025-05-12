using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CTrapezoid
    {
        private float mBase1;
        private float mBase2;
        private float mHeight;
        private float mSide1;
        private float mSide2;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CTrapezoid()
        {
            mBase1 = 0.0f;
            mBase2 = 0.0f;
            mHeight = 0.0f;
            mSide1 = 0.0f;
            mSide2 = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight,
                            TextBox txtSide1, TextBox txtSide2)
        {
            try
            {
                mBase1 = float.Parse(txtBase1.Text);
                mBase2 = float.Parse(txtBase2.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);

                if (!IsValidTrapezoid())
                {
                    MessageBox.Show("No es un trapezoide válido",
                                "Mensaje de error");
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }

        private bool IsValidTrapezoid()
        {
            float baseDiff = Math.Abs(mBase1 - mBase2) / 2;
            float side1Calculated = (float)Math.Sqrt(mHeight * mHeight + baseDiff * baseDiff);
            float side2Calculated = (float)Math.Sqrt(mHeight * mHeight + baseDiff * baseDiff);

            return Math.Abs(side1Calculated - mSide1) < 0.0001f &&
                   Math.Abs(side2Calculated - mSide2) < 0.0001f;
        }

        public void PerimeterTrapezoid()
        {
            mPerimeter = mBase1 + mBase2 + mSide1 + mSide2;
        }

        public void AreaTrapezoid()
        {
            mArea = ((mBase1 + mBase2) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight,
                                  TextBox txtSide1, TextBox txtSide2,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase1 = 0.0f;
            mBase2 = 0.0f;
            mHeight = 0.0f;
            mSide1 =
            mSide2 = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtBase1.Text = "";
            txtBase2.Text = "";
            txtHeight.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
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