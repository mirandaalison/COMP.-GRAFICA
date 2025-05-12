using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CRhombus
    {
        private float mSide;
        private float mDiagonalA;
        private float mDiagonalB;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CRhombus()
        {
            mSide = 0.0f;
            mDiagonalA = 0.0f;
            mDiagonalB = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide, TextBox txtDiagonalA, TextBox txtDiagonalB)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                mDiagonalA = float.Parse(txtDiagonalA.Text);
                mDiagonalB = float.Parse(txtDiagonalB.Text);

                if (!IsValidRhombus())
                {
                    MessageBox.Show("No es un rombo válido",
                                "Mensaje de error");
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }

        private bool IsValidRhombus()
        {
            float diagonalHalfSquareSum = (mDiagonalA * mDiagonalA) / 4 + (mDiagonalB * mDiagonalB) / 4;
            return Math.Abs(diagonalHalfSquareSum - mSide * mSide) < 0.0001f;
        }

        public void PerimeterRhombus()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaRhombus()
        {
            mArea = (mDiagonalA * mDiagonalB) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSide, TextBox txtDiagonalA, TextBox txtDiagonalB,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSide = 0.0f;
            mDiagonalA = 0.0f;
            mDiagonalB = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtSide.Text = "";
            txtDiagonalA.Text = "";
            txtDiagonalB.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

       

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}