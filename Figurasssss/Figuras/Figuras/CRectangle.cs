using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class CRectangle
    {
        //ancho
        private float mWidth;
        //largo
        private float mHeight;
        //perimetro 
        private float mPerimeter;
        //area  
        private float mArea;
        //objeto que activa modo grafico
        private Graphics mGraph;
        //constante scale factor (zoom in/ zoom out)
        private const float SF = 20;
        //obj boligrafo que dibuja o escribe en un lienoz (canvas)
        private Pen mPen;




        //funciones miembro (metodos)

        //constructor sin parametros
        public CRectangle()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //funcion que lee datos de entrada del rectangulo
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

        //funcion que calcula el perimetro del rectangulo
        public void PerimeterRectangle()
        {
            mPerimeter = 2 * mWidth +  2 * mHeight;
        }

        //funcion que calcula el area del rectangulo
        public void AreaRectangle()
        {
            mArea = mWidth * mHeight;
        }

        //funcion que imprime el perimetro y el area del rectangulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //funcion que inicialia los datos y controles del rectangulo
        public void InitializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtWidth.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titileando en una caja de texto
            txtWidth.Focus();
            picCanvas.Refresh();

        }

        //funcion que grafica un rectangulo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //graficar un rectangulo
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }

        //funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
