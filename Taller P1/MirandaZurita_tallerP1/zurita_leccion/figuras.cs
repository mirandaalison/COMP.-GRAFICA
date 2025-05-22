using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zurita_leccion
{
    public partial class figuras : Form
    {
        private cFiguras ObjFiguras = new cFiguras();
        private PointF[] mVertices; 
        private CFigureFlower ObjFlower = new CFigureFlower();
        private Graphics mGraph;
        GeometricTransform geometricTransform = new GeometricTransform();

        cStar ObjStar = new cStar();
        private PointF[] mSmallStarVertices;
        private PointF[] mBigStarVertices;
        private Graphics mStarGraph;

        public figuras()
        {
            InitializeComponent();
            this.KeyPreview = true;
            ObjFiguras.ReadData(txtRadius, npdNumberSides);
            ObjFiguras.PrintData(txtPerimeter, txtArea);
            mGraph = ObjFiguras.CanvaConfigure(picCanvas);
            mVertices = ObjFiguras.getVertices();
            ObjFiguras.PlotShape(mGraph, mVertices, "");
            
            
            // Initialize the field in the constructor  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        

        private void lblFigureName_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjFiguras.ReadData(txtRadius, npdNumberSides);
            ObjFiguras.Area();
            ObjFiguras.Perimeter();
            ObjFiguras.PrintData(txtPerimeter, txtArea);
            picCanvas.Refresh();
            PointF[] mDefaultVertices = ObjFiguras.getVertices();
            ObjFiguras.PlotShape(mGraph, mDefaultVertices, "");
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjFiguras.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas, npdNumberSides);

        }
        private void btnDrawFlower_Click(object sender, EventArgs e)
        {
            ObjFlower.PlotShape(picFlowerFigure);
        }

        private void btnExit1_Click_1(object sender, EventArgs e)
        {
            ObjFiguras.CloseForm(this);
        }
        
        private void ResponsiveGraphicsX(int tX)
        {
            picCanvas.Refresh();
            mVertices = geometricTransform.TranslationX(mVertices, tX);
            ObjFiguras.PlotShape(mGraph, mVertices, "");
        }
        private void ResponsiveGraphicsY(int tY)
        {
            picCanvas.Refresh();
            mVertices = geometricTransform.TranslationY(mVertices, tY);
            ObjFiguras.PlotShape(mGraph, mVertices, "");
        }
        private void AntiClockWise(float angle)
        {
            picCanvas.Refresh();
            mVertices = geometricTransform.RotationAntiClockwise(mVertices, angle);
            ObjFiguras.PlotShape(mGraph, mVertices, "");
        }
        


        private void picCanvas_Click(object sender, EventArgs e)
        {
            // Este evento no puede manejar teclas, ya que EventArgs no tiene KeyCode.
            // Si quieres mover la figura con las teclas de flecha, debes usar el evento KeyDown del formulario.
            // Puedes dejar este método vacío o mostrar un mensaje si es necesario.
        }

        // Agrega este método al formulario para manejar las teclas de flecha
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                switch (keyData)
                {
                    case Keys.Right:
                        ResponsiveGraphicsY(10);
                        StarTranslateX(10);
                        return true;
                    case Keys.Left:
                        ResponsiveGraphicsY(-10);
                        StarTranslateX(-10);
                        return true;
                    case Keys.Up:
                        ResponsiveGraphicsX(10);
                        StarTranslateY(-10);
                        return true;
                    case Keys.Down:
                        ResponsiveGraphicsX(-10);
                        StarTranslateY(10);
                        return true;
                    case Keys.N:
                        AntiClockWise(5);
                        return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void StarTranslateX(int tX)
        {
            picStarCanvas.Refresh();
            mSmallStarVertices = geometricTransform.TranslationX(mSmallStarVertices, tX);
            mBigStarVertices = geometricTransform.TranslationX(mBigStarVertices, tX);
            ObjStar.DrawStar(mSmallStarVertices, mStarGraph);
            ObjStar.LinesSmallStar(mSmallStarVertices, mStarGraph);

            ObjStar.DrawStar(mBigStarVertices, mStarGraph);
            ObjStar.LinesBigStar(mBigStarVertices, mStarGraph);
        }
        private void StarTranslateY(int tY)
        {
            picStarCanvas.Refresh();
            mSmallStarVertices = geometricTransform.TranslationY(mSmallStarVertices, tY);
            mBigStarVertices = geometricTransform.TranslationY(mBigStarVertices, tY);
            ObjStar.DrawStar(mSmallStarVertices, mStarGraph);
            ObjStar.LinesSmallStar(mSmallStarVertices, mStarGraph);
            ObjStar.DrawStar(mBigStarVertices, mStarGraph);
            ObjStar.LinesBigStar(mBigStarVertices, mStarGraph);
        }
        private void btnStarDraw_Click(object sender, EventArgs e)
        {
            ObjStar.ReadData(txtRadius);
            mStarGraph = ObjStar.CanvaConfigure(picStarCanvas);

            mSmallStarVertices=ObjStar.getStarVertices(3);
            mBigStarVertices = ObjStar.getStarVertices(2);

            ObjStar.DrawStar(mSmallStarVertices, mStarGraph);
            ObjStar.LinesSmallStar(mSmallStarVertices, mStarGraph);

            ObjStar.DrawStar(mBigStarVertices, mStarGraph);
            ObjStar.LinesBigStar(mBigStarVertices, mStarGraph);

        }
    }
}
