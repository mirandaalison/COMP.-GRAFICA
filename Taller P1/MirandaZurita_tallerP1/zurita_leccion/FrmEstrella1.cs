using System;
using System.Drawing;
using System.Windows.Forms;

namespace TallerEstrella
{
    public partial class FrmEstrella1 : Form
    {
        private CEstrella1 estrella = new CEstrella1();

        public FrmEstrella1()
        {
            InitializeComponent();

            // Configuración inicial controles
            trbEscala.Minimum = 5;
            trbEscala.Maximum = 20;
            trbEscala.Value = 10;
            txtRadio.Text = "100";

            estrella.SetEscala(trbEscala.Value / 10f);
            estrella.SetRadioBase(100);

            // Suscribir evento Paint del picCanvas
            picCanvas.Paint += PicCanvas_Paint;

            // Inicializar el centro de la estrella para que quede en el centro del picCanvas
            estrella.SetCentro(picCanvas.Width / 2f, picCanvas.Height / 2f);
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            estrella.Dibujar(e.Graphics);
        }

        private void btnDibujar__Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtRadio.Text, out float radio) && radio > 0)
            {
                estrella.SetRadioBase(radio);
                picCanvas.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un radio válido mayor a cero.");
            }
        }

        private void trbEscala__Scroll(object sender, EventArgs e)
        {
            estrella.SetEscala(trbEscala.Value / 10f);
            picCanvas.Invalidate();
        }

        private void btnRotarIzquierda_Click(object sender, EventArgs e)
        {
            estrella.Rotar(-10);
            picCanvas.Invalidate();
        }

        private void btnRotarDerecha_Click(object sender, EventArgs e)
        {
            estrella.Rotar(10);
            picCanvas.Invalidate();
        }

        private void btnTrasladarArriba_Click(object sender, EventArgs e)
        {
            estrella.Trasladar(0, -10);
            picCanvas.Invalidate();
        }

        private void btnTrasladarAbajo_Click(object sender, EventArgs e)
        {
            estrella.Trasladar(0, 10);
            picCanvas.Invalidate();
        }

        private void btnTrasladarIzquierda_Click(object sender, EventArgs e)
        {
            estrella.Trasladar(-10, 0);
            picCanvas.Invalidate();
        }

        private void btnTrasladarDerecha_Click(object sender, EventArgs e)
        {
            estrella.Trasladar(10, 0);
            picCanvas.Invalidate();
        }
    }
}
