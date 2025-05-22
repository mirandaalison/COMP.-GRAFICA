namespace zurita_leccion
{
    partial class figuras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcMultiTask = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.npdNumberSides = new System.Windows.Forms.NumericUpDown();
            this.lblNumberSides = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.tbpFlowerFigure = new System.Windows.Forms.TabPage();
            this.btnDrawFlower = new System.Windows.Forms.Button();
            this.gbxCanvaGT = new System.Windows.Forms.GroupBox();
            this.picFlowerFigure = new System.Windows.Forms.PictureBox();
            this.tbpStar = new System.Windows.Forms.TabPage();
            this.picStarCanvas = new System.Windows.Forms.PictureBox();
            this.gbxStarGraph = new System.Windows.Forms.GroupBox();
            this.lblRaiudsStar = new System.Windows.Forms.Label();
            this.txbRadiusStar = new System.Windows.Forms.TextBox();
            this.btnStarDraw = new System.Windows.Forms.Button();
            this.tbcMultiTask.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbOutputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdNumberSides)).BeginInit();
            this.tbpFlowerFigure.SuspendLayout();
            this.gbxCanvaGT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlowerFigure)).BeginInit();
            this.tbpStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStarCanvas)).BeginInit();
            this.gbxStarGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMultiTask
            // 
            this.tbcMultiTask.Controls.Add(this.tabPage1);
            this.tbcMultiTask.Controls.Add(this.tbpFlowerFigure);
            this.tbcMultiTask.Controls.Add(this.tbpStar);
            this.tbcMultiTask.Location = new System.Drawing.Point(12, 12);
            this.tbcMultiTask.Name = "tbcMultiTask";
            this.tbcMultiTask.SelectedIndex = 0;
            this.tbcMultiTask.Size = new System.Drawing.Size(786, 442);
            this.tbcMultiTask.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbCanvas);
            this.tabPage1.Controls.Add(this.grbOutputs);
            this.tabPage1.Controls.Add(this.grbProcess);
            this.tabPage1.Controls.Add(this.grbInputs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(285, 7);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(483, 403);
            this.grbCanvas.TabIndex = 19;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfica";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(18, 25);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(447, 367);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(11, 294);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(257, 116);
            this.grbOutputs.TabIndex = 18;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(109, 67);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(111, 22);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(109, 30);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(111, 22);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(51, 70);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área: ";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(17, 33);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(82, 16);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro: ";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit1);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(11, 141);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(257, 130);
            this.grbProcess.TabIndex = 17;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(84, 80);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(86, 30);
            this.btnExit1.TabIndex = 2;
            this.btnExit1.Text = "Salir";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(148, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 32);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.npdNumberSides);
            this.grbInputs.Controls.Add(this.lblNumberSides);
            this.grbInputs.Controls.Add(this.txtRadius);
            this.grbInputs.Controls.Add(this.lblHeight);
            this.grbInputs.Controls.Add(this.lblRadius);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(11, 7);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(257, 103);
            this.grbInputs.TabIndex = 16;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // npdNumberSides
            // 
            this.npdNumberSides.Location = new System.Drawing.Point(109, 69);
            this.npdNumberSides.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.npdNumberSides.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.npdNumberSides.Name = "npdNumberSides";
            this.npdNumberSides.Size = new System.Drawing.Size(111, 22);
            this.npdNumberSides.TabIndex = 6;
            this.npdNumberSides.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblNumberSides
            // 
            this.lblNumberSides.AutoSize = true;
            this.lblNumberSides.Location = new System.Drawing.Point(12, 71);
            this.lblNumberSides.Name = "lblNumberSides";
            this.lblNumberSides.Size = new System.Drawing.Size(87, 16);
            this.lblNumberSides.TabIndex = 5;
            this.lblNumberSides.Text = "Nro Lados: ";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(109, 31);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(111, 22);
            this.txtRadius.TabIndex = 2;
            this.txtRadius.Text = "15";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(21, 66);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(0, 16);
            this.lblHeight.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(42, 37);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(57, 16);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radio: ";
            // 
            // tbpFlowerFigure
            // 
            this.tbpFlowerFigure.Controls.Add(this.btnDrawFlower);
            this.tbpFlowerFigure.Controls.Add(this.gbxCanvaGT);
            this.tbpFlowerFigure.Location = new System.Drawing.Point(4, 22);
            this.tbpFlowerFigure.Name = "tbpFlowerFigure";
            this.tbpFlowerFigure.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFlowerFigure.Size = new System.Drawing.Size(778, 416);
            this.tbpFlowerFigure.TabIndex = 1;
            this.tbpFlowerFigure.Text = "Flor";
            this.tbpFlowerFigure.UseVisualStyleBackColor = true;
            this.tbpFlowerFigure.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnDrawFlower
            // 
            this.btnDrawFlower.Location = new System.Drawing.Point(332, 351);
            this.btnDrawFlower.Name = "btnDrawFlower";
            this.btnDrawFlower.Size = new System.Drawing.Size(132, 40);
            this.btnDrawFlower.TabIndex = 1;
            this.btnDrawFlower.Text = "Dibuja";
            this.btnDrawFlower.UseVisualStyleBackColor = true;
            this.btnDrawFlower.Click += new System.EventHandler(this.btnDrawFlower_Click);
            // 
            // gbxCanvaGT
            // 
            this.gbxCanvaGT.Controls.Add(this.picFlowerFigure);
            this.gbxCanvaGT.Location = new System.Drawing.Point(6, 3);
            this.gbxCanvaGT.Name = "gbxCanvaGT";
            this.gbxCanvaGT.Size = new System.Drawing.Size(767, 329);
            this.gbxCanvaGT.TabIndex = 0;
            this.gbxCanvaGT.TabStop = false;
            this.gbxCanvaGT.Text = "Gráfico";
            // 
            // picFlowerFigure
            // 
            this.picFlowerFigure.Location = new System.Drawing.Point(23, 20);
            this.picFlowerFigure.Name = "picFlowerFigure";
            this.picFlowerFigure.Size = new System.Drawing.Size(726, 295);
            this.picFlowerFigure.TabIndex = 0;
            this.picFlowerFigure.TabStop = false;
            // 
            // tbpStar
            // 
            this.tbpStar.Controls.Add(this.btnStarDraw);
            this.tbpStar.Controls.Add(this.txbRadiusStar);
            this.tbpStar.Controls.Add(this.lblRaiudsStar);
            this.tbpStar.Controls.Add(this.gbxStarGraph);
            this.tbpStar.Location = new System.Drawing.Point(4, 22);
            this.tbpStar.Name = "tbpStar";
            this.tbpStar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStar.Size = new System.Drawing.Size(778, 416);
            this.tbpStar.TabIndex = 2;
            this.tbpStar.Text = "Estrella";
            this.tbpStar.UseVisualStyleBackColor = true;
            // 
            // picStarCanvas
            // 
            this.picStarCanvas.Location = new System.Drawing.Point(17, 19);
            this.picStarCanvas.Name = "picStarCanvas";
            this.picStarCanvas.Size = new System.Drawing.Size(350, 350);
            this.picStarCanvas.TabIndex = 0;
            this.picStarCanvas.TabStop = false;
            // 
            // gbxStarGraph
            // 
            this.gbxStarGraph.Controls.Add(this.picStarCanvas);
            this.gbxStarGraph.Location = new System.Drawing.Point(372, 24);
            this.gbxStarGraph.Name = "gbxStarGraph";
            this.gbxStarGraph.Size = new System.Drawing.Size(380, 380);
            this.gbxStarGraph.TabIndex = 1;
            this.gbxStarGraph.TabStop = false;
            this.gbxStarGraph.Text = "groupBox1";
            // 
            // lblRaiudsStar
            // 
            this.lblRaiudsStar.AutoSize = true;
            this.lblRaiudsStar.Location = new System.Drawing.Point(34, 45);
            this.lblRaiudsStar.Name = "lblRaiudsStar";
            this.lblRaiudsStar.Size = new System.Drawing.Size(41, 13);
            this.lblRaiudsStar.TabIndex = 2;
            this.lblRaiudsStar.Text = "Radio: ";
            // 
            // txbRadiusStar
            // 
            this.txbRadiusStar.Location = new System.Drawing.Point(81, 42);
            this.txbRadiusStar.Name = "txbRadiusStar";
            this.txbRadiusStar.Size = new System.Drawing.Size(116, 20);
            this.txbRadiusStar.TabIndex = 3;
            this.txbRadiusStar.Text = "15";
            // 
            // btnStarDraw
            // 
            this.btnStarDraw.Location = new System.Drawing.Point(37, 90);
            this.btnStarDraw.Name = "btnStarDraw";
            this.btnStarDraw.Size = new System.Drawing.Size(159, 26);
            this.btnStarDraw.TabIndex = 4;
            this.btnStarDraw.Text = "Graficar";
            this.btnStarDraw.UseVisualStyleBackColor = true;
            this.btnStarDraw.Click += new System.EventHandler(this.btnStarDraw_Click);
            // 
            // figuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcMultiTask);
            this.Name = "figuras";
            this.Text = "figuras";
            this.tbcMultiTask.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdNumberSides)).EndInit();
            this.tbpFlowerFigure.ResumeLayout(false);
            this.gbxCanvaGT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFlowerFigure)).EndInit();
            this.tbpStar.ResumeLayout(false);
            this.tbpStar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStarCanvas)).EndInit();
            this.gbxStarGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMultiTask;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.NumericUpDown npdNumberSides;
        private System.Windows.Forms.Label lblNumberSides;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TabPage tbpFlowerFigure;
        private System.Windows.Forms.GroupBox gbxCanvaGT;
        private System.Windows.Forms.PictureBox picFlowerFigure;
        private System.Windows.Forms.Button btnDrawFlower;
        private System.Windows.Forms.TabPage tbpStar;
        private System.Windows.Forms.GroupBox gbxStarGraph;
        private System.Windows.Forms.PictureBox picStarCanvas;
        private System.Windows.Forms.TextBox txbRadiusStar;
        private System.Windows.Forms.Label lblRaiudsStar;
        private System.Windows.Forms.Button btnStarDraw;
    }
}