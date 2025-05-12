using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CEllipse
    {
        private float mSemiMajorAxis;
        private float mSemiMinorAxis;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CEllipse()
        {
            mSemiMajorAxis = 0.0f;
            mSemiMinorAxis = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSemiMajorAxis, TextBox txtSemiMinorAxis)
        {
            try
            {
                mSemiMajorAxis = float.Parse(txtSemiMajorAxis.Text);
                mSemiMinorAxis = float.Parse(txtSemiMinorAxis.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }
        }

        public void PerimeterEllipse()
        {
            float a = mSemiMajorAxis;
            float b = mSemiMinorAxis;
            float h = (float)Math.Pow((a - b) / (a + b), 2);
            mPerimeter = (float)(Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }

        public void AreaEllipse()
        {
            mArea = (float)Math.PI * mSemiMajorAxis * mSemiMinorAxis;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSemiMajorAxis, TextBox txtSemiMinorAxis,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSemiMajorAxis = 0.0f;
            mSemiMinorAxis = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtSemiMajorAxis.Text = "";
            txtSemiMinorAxis.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSemiMajorAxis.Focus();
            picCanvas.Refresh();
        }

       

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}