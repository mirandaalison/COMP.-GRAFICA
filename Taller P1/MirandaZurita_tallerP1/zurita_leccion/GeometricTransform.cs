using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zurita_leccion
{
    class GeometricTransform
   
    {
        //Funciones de Traslación en X y en Y
       public PointF[] TranslationX(PointF[] vertices, int TranslationX)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].X += TranslationX;
            }
            return vertices;
        }
        public PointF[] TranslationY(PointF[] vertices, int TranslationY)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].Y += TranslationY;
            }
            return vertices;
        }

        //Funciones de de Rotación Antihoraria
        public PointF[] RotationAntiClockwise(PointF[] vertices, 
            float angle)
        {
            double rad = angle* Math.PI / 180;
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].X = (float)(vertices[i].X * Math.Cos(rad) - vertices[i].Y * Math.Sin(rad));
                vertices[i].Y = (float)(vertices[i].X * Math.Sin(rad) + vertices[i].Y *Math.Cos(rad));
            }
            return vertices;
        }

    }
}
