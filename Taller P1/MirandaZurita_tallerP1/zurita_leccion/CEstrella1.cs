using System;
using System.Collections.Generic;
using System.Drawing;

namespace TallerEstrella
{
    public class CEstrella1
    {
        private float cx = 200, cy = 200;
        private float anguloRotacion = 0;
        private float escala = 1.0f;
        private float radioBase = 100;
        private int numEstrellas = 4;

        public void SetCentro(float x, float y)
        {
            cx = x;
            cy = y;
        }

        public void SetEscala(float nuevaEscala)
        {
            escala = nuevaEscala;
        }

        public void Rotar(float grados)
        {
            anguloRotacion += grados;
        }

        public void Trasladar(float dx, float dy)
        {
            cx += dx;
            cy += dy;
        }

        public void SetRadioBase(float radio)
        {
            radioBase = radio;
        }

        private List<PointF> GenerarPuntosEstrella(float rOuter, float rInner)
        {
            List<PointF> puntos = new List<PointF>();
            double angulo = -Math.PI / 2 + anguloRotacion * Math.PI / 180;
            double paso = Math.PI / 5;

            for (int i = 0; i < 10; i++)
            {
                float r = (i % 2 == 0) ? rOuter : rInner;
                float x = cx + (float)(r * escala * Math.Cos(angulo));
                float y = cy + (float)(r * escala * Math.Sin(angulo));
                puntos.Add(new PointF(x, y));
                angulo += paso;
            }
            return puntos;
        }

        public void Dibujar(Graphics g)
        {
            Pen lapiz = new Pen(Color.Blue, 2);

            for (int i = 0; i < numEstrellas; i++)
            {
                float rOuter = radioBase - i * (radioBase / numEstrellas);
                float rInner = rOuter / 2;
                var puntos = GenerarPuntosEstrella(rOuter, rInner);

                for (int j = 0; j < puntos.Count; j++)
                {
                    int siguiente = (j + 1) % puntos.Count;
                    g.DrawLine(lapiz, puntos[j], puntos[siguiente]);
                }
            }
        }
    }
}
