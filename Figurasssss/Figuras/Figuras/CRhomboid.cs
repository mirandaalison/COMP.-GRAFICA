using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CRhomboid
    {
        private float mBase;
        private float mHeight;
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CRhomboid()
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtSide)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide = float.Parse(txtSide.Text);

                if (!IsValidRhomboid())
                {
                    MessageBox.Show("No es un romboide válido",
                                "Mensaje de error");
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }

        private bool IsValidRhomboid()
        {
            float baseMinusX = mBase;
            float heightSquared = mHeight * mHeight;

            // Find x where x² + height² = side²
            float x = (float)Math.Sqrt(mSide * mSide - heightSquared);

            // The remaining part of base should fit the other side
            return Math.Abs(baseMinusX - x) > 0.0001f;
        }

        public void PerimeterRhomboid()
        {
            mPerimeter = 2 * (mBase + mSide);
        }

        public void AreaRhomboid()
        {
            mArea = mBase * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtSide,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtBase.Text = "";
            txtHeight.Text = "";
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
        }

       

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}