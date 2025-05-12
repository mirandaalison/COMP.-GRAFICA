using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CDeltoid
    {
        private float mDiagonal1;
        private float mDiagonal2;
        private float mSide1;
        private float mSide2;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CDeltoid()
        {
            mDiagonal1 = 0.0f;
            mDiagonal2 = 0.0f;
            mSide1 = 0.0f;
            mSide2 = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtDiagonal1, TextBox txtDiagonal2, TextBox txtSide1, TextBox txtSide2)
        {
            try
            {
                mDiagonal1 = float.Parse(txtDiagonal1.Text);
                mDiagonal2 = float.Parse(txtDiagonal2.Text);
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);

                if (!IsValidDeltoid())
                {
                    MessageBox.Show("No es un deltoide válido",
                                   "Mensaje de error");
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }

        private bool IsValidDeltoid()
        {
            float halfDiag1 = mDiagonal1 / 2;
            float halfDiag2 = mDiagonal2 / 2;

            float calculatedSide1 = (float)Math.Sqrt(halfDiag1 * halfDiag1 + halfDiag2 * halfDiag2);
            float calculatedSide2 = calculatedSide1;

            return Math.Abs(calculatedSide1 - mSide1) < 0.0001f &&
                   Math.Abs(calculatedSide2 - mSide2) < 0.0001f;
        }

        public void PerimeterDeltoid()
        {
            mPerimeter = 2 * (mSide1 + mSide2);
        }

        public void AreaDeltoid()
        {
            mArea = (mDiagonal1 * mDiagonal2) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtDiagonal1, TextBox txtDiagonal2, TextBox txtSide1, TextBox txtSide2,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mDiagonal1 = 0.0f;
            mDiagonal2 = 0.0f;
            mSide1 = 0.0f;
            mSide2 = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtDiagonal1.Text = "";
            txtDiagonal2.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtDiagonal1.Focus();
            picCanvas.Refresh();
        }

        

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}