using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class COval
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public COval()
        {
            mWidth = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                 "Mensaje de error");
            }
        }

        public void PerimeterOval()
        {
            float a = mWidth / 2;
            float b = mHeight / 2;
            float h = (float)Math.Pow((a - b) / (a + b), 2);
            mPerimeter = (float)(Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }

        public void AreaOval()
        {
            mArea = (float)Math.PI * (mWidth / 2) * (mHeight / 2);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mWidth = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtWidth.Focus();
            picCanvas.Refresh();
        }

        

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}