using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zurita_leccion
{
    class CFigureFlower
    {
        private Graphics mGraph;
        // Constante scale factor (Zoom in/Zoom out)
        private Pen mPen;
        int mFigureNumberSides = 5;
        float mRadius = 150.0f;
        
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
        public void PlotShape(PictureBox picFlowerFigure)
        {
            mGraph = picFlowerFigure.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            Pen pen = new Pen(Color.Black, 3);
            float mApothem = mRadius * (float)Math.Cos(Math.PI / mFigureNumberSides);


            int centerX = picFlowerFigure.Width / 2;
            int centerY = picFlowerFigure.Height / 2;
            mGraph.TranslateTransform(centerX, centerY);
            float angle = -90;
            mGraph.RotateTransform(angle);
            PointF[] centrePentagon = getVertices();
            mGraph.DrawPolygon(mPen, centrePentagon);

            for (int i = 0; i < mFigureNumberSides; i++)
            {
                float angulo = (float)(i * 2 * Math.PI / mFigureNumberSides);
                centrePentagon[i].X = centrePentagon[i].X  /5;
                centrePentagon[i].Y = centrePentagon[i].Y / 5;
            }
            mGraph.FillPolygon(Brushes.Red, centrePentagon);


        }
    }
}
