using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zurita_leccion
{
    class cStar
    {
        private float mRadius;
        private Graphics mGraph;
        private Pen mPen;

        //Constructor sin parametros
        public cStar()
        {
            mRadius = 0.0f;
        }
        public Graphics CanvaConfigure(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            Pen pen = new Pen(Color.Black, 3);
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            mGraph.TranslateTransform(centerX, centerY);
            return mGraph;
        }
        //Función para leet el radio
        public void ReadData(TextBox txtRadius)
        {
            if (txtRadius.Text != "")
            {
                mRadius = float.Parse(txtRadius.Text)*10;
            }
            else
            {
                MessageBox.Show("Error: El radio no puede ser menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Función para obtener los vertices
        public PointF[] getStarVertices(int n)
        {
            PointF[] vertices = new PointF[10];
            for (int i = 0; i < 10; i++)
            {
                float angle = (float)(i * Math.PI / 5);
                float radius = (i % 2 == 0) ? mRadius : mRadius / n;
                vertices[i] = new PointF(radius * (float)Math.Cos(angle), radius * (float)Math.Sin(angle));
            }
            return vertices;
        }
        //función para dibujar una estrella
        public void DrawStar(PointF[] vertices, Graphics mGraph)
        {
            mGraph.DrawPolygon(mPen, vertices);
            
            
        }
        public void LinesSmallStar(PointF[] vertices, Graphics mGraph)
        {
            mGraph.DrawLine(mPen, vertices[1], vertices[3]);
            mGraph.DrawLine(mPen, vertices[3], vertices[5]);
            mGraph.DrawLine(mPen, vertices[5], vertices[7]);
            mGraph.DrawLine(mPen, vertices[7], vertices[9]);
            mGraph.DrawLine(mPen, vertices[9], vertices[1]);
        }
        public void LinesBigStar(PointF[] vertices, Graphics mGraph)
        {
            for (int i = 0; i < vertices.Length - 5; i++)
            {
                mGraph.DrawLine(mPen, vertices[i], vertices[i + 5]);
            }
        }

    }
}
