namespace TallerEstrella
{
    partial class FrmEstrella1
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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnTrasladarAbajo = new System.Windows.Forms.Button();
            this.btnTrasladarDerecha = new System.Windows.Forms.Button();
            this.btnTrasladarIzquierda = new System.Windows.Forms.Button();
            this.btnTrasladarArriba = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRotarDerecha = new System.Windows.Forms.Button();
            this.btnRotarIzquierda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEscala = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.trbEscala = new System.Windows.Forms.TrackBar();
            this.btnDibujar_ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trbEscala_ = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala_)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDibujar.Location = new System.Drawing.Point(579, -61);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(162, 39);
            this.btnDibujar.TabIndex = 25;
            this.btnDibujar.Text = "DIBUJAR";
            this.btnDibujar.UseVisualStyleBackColor = false;
            // 
            // btnTrasladarAbajo
            // 
            this.btnTrasladarAbajo.Location = new System.Drawing.Point(626, 361);
            this.btnTrasladarAbajo.Name = "btnTrasladarAbajo";
            this.btnTrasladarAbajo.Size = new System.Drawing.Size(60, 60);
            this.btnTrasladarAbajo.TabIndex = 24;
            this.btnTrasladarAbajo.Text = "Abajo";
            this.btnTrasladarAbajo.UseVisualStyleBackColor = true;
            this.btnTrasladarAbajo.Click += new System.EventHandler(this.btnTrasladarAbajo_Click);
            // 
            // btnTrasladarDerecha
            // 
            this.btnTrasladarDerecha.Location = new System.Drawing.Point(703, 361);
            this.btnTrasladarDerecha.Name = "btnTrasladarDerecha";
            this.btnTrasladarDerecha.Size = new System.Drawing.Size(60, 60);
            this.btnTrasladarDerecha.TabIndex = 23;
            this.btnTrasladarDerecha.TabStop = false;
            this.btnTrasladarDerecha.Text = "-->";
            this.btnTrasladarDerecha.UseVisualStyleBackColor = true;
            this.btnTrasladarDerecha.Click += new System.EventHandler(this.btnTrasladarDerecha_Click);
            // 
            // btnTrasladarIzquierda
            // 
            this.btnTrasladarIzquierda.Location = new System.Drawing.Point(548, 361);
            this.btnTrasladarIzquierda.Name = "btnTrasladarIzquierda";
            this.btnTrasladarIzquierda.Size = new System.Drawing.Size(60, 60);
            this.btnTrasladarIzquierda.TabIndex = 22;
            this.btnTrasladarIzquierda.Text = "<--";
            this.btnTrasladarIzquierda.UseVisualStyleBackColor = true;
            this.btnTrasladarIzquierda.Click += new System.EventHandler(this.btnTrasladarIzquierda_Click);
            // 
            // btnTrasladarArriba
            // 
            this.btnTrasladarArriba.Location = new System.Drawing.Point(626, 283);
            this.btnTrasladarArriba.Name = "btnTrasladarArriba";
            this.btnTrasladarArriba.Size = new System.Drawing.Size(60, 60);
            this.btnTrasladarArriba.TabIndex = 21;
            this.btnTrasladarArriba.Text = "Arriba";
            this.btnTrasladarArriba.UseVisualStyleBackColor = true;
            this.btnTrasladarArriba.Click += new System.EventHandler(this.btnTrasladarArriba_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Trasladar figura:";
            // 
            // btnRotarDerecha
            // 
            this.btnRotarDerecha.Location = new System.Drawing.Point(652, 131);
            this.btnRotarDerecha.Name = "btnRotarDerecha";
            this.btnRotarDerecha.Size = new System.Drawing.Size(60, 60);
            this.btnRotarDerecha.TabIndex = 19;
            this.btnRotarDerecha.TabStop = false;
            this.btnRotarDerecha.Text = "Der - 5º";
            this.btnRotarDerecha.UseVisualStyleBackColor = true;
            this.btnRotarDerecha.Click += new System.EventHandler(this.btnRotarDerecha_Click);
            // 
            // btnRotarIzquierda
            // 
            this.btnRotarIzquierda.Location = new System.Drawing.Point(571, 131);
            this.btnRotarIzquierda.Name = "btnRotarIzquierda";
            this.btnRotarIzquierda.Size = new System.Drawing.Size(60, 60);
            this.btnRotarIzquierda.TabIndex = 18;
            this.btnRotarIzquierda.Text = "Izq - 5º";
            this.btnRotarIzquierda.UseVisualStyleBackColor = true;
            this.btnRotarIzquierda.Click += new System.EventHandler(this.btnRotarIzquierda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rotar figura:";
            // 
            // lblEscala
            // 
            this.lblEscala.AutoSize = true;
            this.lblEscala.Location = new System.Drawing.Point(30, -61);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(109, 16);
            this.lblEscala.TabIndex = 16;
            this.lblEscala.Text = "Modificar escala:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(24, 83);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(500, 500);
            this.picCanvas.TabIndex = 15;
            this.picCanvas.TabStop = false;
            // 
            // trbEscala
            // 
            this.trbEscala.Location = new System.Drawing.Point(145, -61);
            this.trbEscala.Name = "trbEscala";
            this.trbEscala.Size = new System.Drawing.Size(388, 56);
            this.trbEscala.TabIndex = 14;
            // 
            // btnDibujar_
            // 
            this.btnDibujar_.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDibujar_.Location = new System.Drawing.Point(427, 18);
            this.btnDibujar_.Name = "btnDibujar_";
            this.btnDibujar_.Size = new System.Drawing.Size(162, 39);
            this.btnDibujar_.TabIndex = 28;
            this.btnDibujar_.Text = "DIBUJAR";
            this.btnDibujar_.UseVisualStyleBackColor = false;
            this.btnDibujar_.Click += new System.EventHandler(this.btnDibujar__Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Modificar escala:";
            // 
            // trbEscala_
            // 
            this.trbEscala_.Location = new System.Drawing.Point(555, 498);
            this.trbEscala_.Name = "trbEscala_";
            this.trbEscala_.Size = new System.Drawing.Size(221, 56);
            this.trbEscala_.TabIndex = 26;
            this.trbEscala_.Scroll += new System.EventHandler(this.trbEscala__Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ingrese un radio para graficar la estrella:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(293, 35);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 30;
            // 
            // FrmEstrella1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 604);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDibujar_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trbEscala_);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnTrasladarAbajo);
            this.Controls.Add(this.btnTrasladarDerecha);
            this.Controls.Add(this.btnTrasladarIzquierda);
            this.Controls.Add(this.btnTrasladarArriba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRotarDerecha);
            this.Controls.Add(this.btnRotarIzquierda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEscala);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.trbEscala);
            this.Name = "FrmEstrella1";
            this.Text = "FrmEstrella1";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnTrasladarAbajo;
        private System.Windows.Forms.Button btnTrasladarDerecha;
        private System.Windows.Forms.Button btnTrasladarIzquierda;
        private System.Windows.Forms.Button btnTrasladarArriba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRotarDerecha;
        private System.Windows.Forms.Button btnRotarIzquierda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TrackBar trbEscala;
        private System.Windows.Forms.Button btnDibujar_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trbEscala_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRadio;
    }
}