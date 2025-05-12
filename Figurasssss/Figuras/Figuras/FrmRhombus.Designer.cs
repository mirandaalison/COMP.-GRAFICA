namespace Figuras
{
    partial class FrmRhombus
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
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.lblSide3 = new System.Windows.Forms.Label();
            this.txtDiagonalB = new System.Windows.Forms.TextBox();
            this.txtSide2 = new System.Windows.Forms.Label();
            this.txtDiagonalA = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutput.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(12, 27);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(384, 29);
            this.lblInstruccion.TabIndex = 10;
            this.lblInstruccion.Text = "Ingrese las dimesiones del rombo:";
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.txtPerimeter);
            this.grbOutput.Controls.Add(this.txtArea);
            this.grbOutput.Controls.Add(this.lblPerimeter);
            this.grbOutput.Controls.Add(this.lblArea);
            this.grbOutput.Location = new System.Drawing.Point(17, 275);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(356, 156);
            this.grbOutput.TabIndex = 9;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Salidas";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(143, 101);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(107, 22);
            this.txtPerimeter.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(143, 46);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(107, 22);
            this.txtArea.TabIndex = 2;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(24, 101);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(91, 20);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "Perímetro";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(24, 48);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 20);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.btnCalculate);
            this.grbInput.Controls.Add(this.lblSide3);
            this.grbInput.Controls.Add(this.txtDiagonalB);
            this.grbInput.Controls.Add(this.txtSide2);
            this.grbInput.Controls.Add(this.txtDiagonalA);
            this.grbInput.Controls.Add(this.lblSide);
            this.grbInput.Controls.Add(this.txtSide);
            this.grbInput.Location = new System.Drawing.Point(17, 82);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(510, 169);
            this.grbInput.TabIndex = 8;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entradas";
            // 
            // lblSide3
            // 
            this.lblSide3.AutoSize = true;
            this.lblSide3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide3.Location = new System.Drawing.Point(36, 129);
            this.lblSide3.Name = "lblSide3";
            this.lblSide3.Size = new System.Drawing.Size(141, 20);
            this.lblSide3.TabIndex = 4;
            this.lblSide3.Text = "Diagonal Menor";
            // 
            // txtDiagonalB
            // 
            this.txtDiagonalB.Location = new System.Drawing.Point(204, 127);
            this.txtDiagonalB.Name = "txtDiagonalB";
            this.txtDiagonalB.Size = new System.Drawing.Size(107, 22);
            this.txtDiagonalB.TabIndex = 5;
            // 
            // txtSide2
            // 
            this.txtSide2.AutoSize = true;
            this.txtSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSide2.Location = new System.Drawing.Point(36, 89);
            this.txtSide2.Name = "txtSide2";
            this.txtSide2.Size = new System.Drawing.Size(140, 20);
            this.txtSide2.TabIndex = 2;
            this.txtSide2.Text = "Diagonal Mayor";
            // 
            // txtDiagonalA
            // 
            this.txtDiagonalA.Location = new System.Drawing.Point(204, 87);
            this.txtDiagonalA.Name = "txtDiagonalA";
            this.txtDiagonalA.Size = new System.Drawing.Size(107, 22);
            this.txtDiagonalA.TabIndex = 3;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(36, 52);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(56, 20);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Lado ";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(126, 50);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(107, 22);
            this.txtSide.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(348, 75);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CALCULAR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FrmRhombus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.Name = "FrmRhombus";
            this.Text = "FrmRhombus";
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Label lblSide3;
        private System.Windows.Forms.TextBox txtDiagonalB;
        private System.Windows.Forms.Label txtSide2;
        private System.Windows.Forms.TextBox txtDiagonalA;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Button btnCalculate;
    }
}