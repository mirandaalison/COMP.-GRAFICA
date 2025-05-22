using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Windows.Markup;
using System.Security.Cryptography.X509Certificates;

namespace zurita_leccion
{
    class cFiguras
    {
        private float mRadius;
        private float mPerimeter;
        private int mFigureNumberSides;
        
        private float mArea;
        //Objeto que actva el modo gráfico
        private Graphics mGraph;
        // Constante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja o escribe en un lienzo ( canvas)
        private Pen mPen;
        //Funciones miemro ( métodos)
        // Constructor sin parámetros
        public cFiguras()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            mFigureNumberSides = 0;
        }
        //Función que lee los datos de entrada del circulo.
        public void ReadData(TextBox txtRadius, NumericUpDown npdNumberSides)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text)*10;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: El radio solo permite números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (npdNumberSides.Value < 3)
            {
                MessageBox.Show("Error: El número de lados no puede menor a 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                mFigureNumberSides = (int)npdNumberSides.Value;

            }

            if (mRadius < 0.0f)
            {
                MessageBox.Show("Error: El radio no puede ser menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Función que calcula el perímetro del círculo
        public void Perimeter()
        {
            mPerimeter = mFigureNumberSides * (2 * mRadius * (float)Math.Sin((float)Math.PI / mFigureNumberSides));
        }
        //Función que calcula el área del círculo
        public void Area()
        {
            mArea = (0.5f * mFigureNumberSides * mRadius * mRadius) * ((float)Math.Sin((2 * (float)Math.PI) / mFigureNumberSides));
        } 
        // Función que imprime el perímetro y el área del círculo.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString() + " m";
            txtArea.Text = mArea.ToString() + " m²";
        }
        //Función que inicializa los datos y controles del círculo
        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas, NumericUpDown npdNumberSides)
        {
            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;

            txtRadius.Text = "15"; txtPerimeter.Text = ""; txtArea.Text = "";
            npdNumberSides.Value = 3;
            //Mantiene el cursor titileando en una caja de texto
            txtRadius.Focus();
            picCanvas.Refresh();
        }
        public PointF[] getVertices()
        {
            PointF[] vertices = new PointF[mFigureNumberSides];
            for (int i = 0; i < mFigureNumberSides; i++)
            {
                float angulo = (float)(i * 2 * Math.PI / mFigureNumberSides);
                vertices[i] = new PointF(
                    mRadius * (float)Math.Cos(angulo),
                    -mRadius * (float)Math.Sin(angulo)
                );
            }
            return vertices;
        }
        public Graphics CanvaConfigure(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            Pen pen = new Pen(Color.Black, 3);



            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            mGraph.TranslateTransform(centerX, centerY);
            float angle = -90;
            if (mFigureNumberSides <= 8)
            {
                if (mFigureNumberSides % 2 == 0)
                {
                    angle = -45;
                    if (mFigureNumberSides % 3 == 0)
                    {
                        angle = 0;
                    }
                }
            }
            mGraph.RotateTransform(angle);
            return mGraph;
        }
        public void PlotShape(Graphics mGraph, PointF[] mVertices, string Tipo)
        {
            if (Tipo == "full")
            {
                mGraph.FillPolygon(Brushes.Blue, mVertices);
                /*
                 * Graficar un polígono dividido en triangulos de diferentes colores
                 
                 */
            }
            else if (Tipo == "triangle")
            {
                PointF[] vertices2 = new PointF[3];
                for (int i = 0; i < mFigureNumberSides; i++)
                {
                    vertices2[0] = mVertices[i];
                    vertices2[1] = new PointF(0, 0);
                    if (i == mFigureNumberSides - 1)
                    {
                        vertices2[2] = mVertices[0];
                    }
                    else
                        vertices2[2] = mVertices[i + 1];

                    byte r = (byte)(25 * i);
                    byte g = (byte)(50 * i);
                    byte b = (byte)(75 * i);

                    Brush brush = new SolidBrush(Color.FromArgb(r, g, b));

                    mGraph.FillPolygon(brush, vertices2);
                }
            }
            else if (Tipo == "")
            {
                mGraph.DrawPolygon(mPen, mVertices);
            }
        }


                //Función que cierra el formulario
                public void CloseForm(Form ObjForm)
                {
                    ObjForm.Close();
                }
    }
}
