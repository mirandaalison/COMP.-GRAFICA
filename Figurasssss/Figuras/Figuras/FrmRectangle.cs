using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{

    public partial class frmRectangle : Form
    {
        //definicion de un objeto de tipo rectangle
        private CRectangle ObjRectangle = new CRectangle();

        public frmRectangle()
        {
            InitializeComponent();
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            //inicialiacion de datod y controles
            //llamada a funcion InitializeData
            ObjRectangle.InitializeData(txtWidth, txtHeight,
                                                  txtPerimeter, txtArea,
                                                  picCanvas);
            }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la función ReadData
            ObjRectangle.ReadData(txtWidth, txtHeight);
            //Cálculo del perímetro de un rectángulo
            //Llamada a la función PerimeterRectangle
            ObjRectangle.PerimeterRectangle();
            //Cálculo del área de un rectángulo
            //Llamada a la función AreaRectangle
            ObjRectangle.AreaRectangle();
            //Impresión de datos
            //Llamada a la función PrintData
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            //Graficación de un rectángulo
            //Llamada a la función PlotShape
            ObjRectangle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicializacion de datos y controles
            //llamada a la funcion InitializeData
            ObjRectangle.InitializeData(txtWidth, txtHeight,
                                                  txtPerimeter, txtArea,
                                                  picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //cirre de un formualrio
            // llama    da a la funcion CloseForm
            ObjRectangle.CloseForm(this);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }

}
