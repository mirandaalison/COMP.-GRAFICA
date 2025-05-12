using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CTriangle
    {
        private float mSideA;
        private float mSideB;
        private float mSideC;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CTriangle()
        {
            mSideA = 0.0f;
            mSideB = 0.0f;
            mSideC = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC)
        {
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mSideC = float.Parse(txtSideC.Text);

                if (!IsValidTriangle())
                {
                    MessageBox.Show("No es un triángulo válido",
                                "Mensaje de error");
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }

        private bool IsValidTriangle()
        {
            return (mSideA + mSideB > mSideC) &&
                   (mSideA + mSideC > mSideB) &&
                   (mSideB + mSideC > mSideA);
        }

        public void PerimeterTriangle()
        {
            mPerimeter = mSideA + mSideB + mSideC;
        }

        public void AreaTriangle()
        {
            float s = mPerimeter / 2;
            mArea = (float)Math.Sqrt(s * (s - mSideA) * (s - mSideB) * (s - mSideC));
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSideA = 0.0f;
            mSideB = 0.0f;
            mSideC = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtSideC.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSideA.Focus();
            picCanvas.Refresh();
        }

        

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}