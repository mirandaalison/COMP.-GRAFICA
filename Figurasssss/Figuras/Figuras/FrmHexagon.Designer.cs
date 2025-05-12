namespace Figuras
{
    partial class FrmHexagon
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
            this.lblPerimeterSquare = new System.Windows.Forms.Label();
            this.lblAreaSquare = new System.Windows.Forms.Label();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.grbOutput.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(27, 21);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(420, 29);
            this.lblInstruccion.TabIndex = 7;
            this.lblInstruccion.Text = "Ingrese las dimesiones del hexágono:";
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.txtPerimeter);
            this.grbOutput.Controls.Add(this.txtArea);
            this.grbOutput.Controls.Add(this.lblPerimeterSquare);
            this.grbOutput.Controls.Add(this.lblAreaSquare);
            this.grbOutput.Location = new System.Drawing.Point(32, 269);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(356, 156);
            this.grbOutput.TabIndex = 6;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Salidas";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(143, 101);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(107, 22);
            this.txtPerimeter.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(143, 46);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(107, 22);
            this.txtArea.TabIndex = 2;
            // 
            // lblPerimeterSquare
            // 
            this.lblPerimeterSquare.AutoSize = true;
            this.lblPerimeterSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterSquare.Location = new System.Drawing.Point(24, 101);
            this.lblPerimeterSquare.Name = "lblPerimeterSquare";
            this.lblPerimeterSquare.Size = new System.Drawing.Size(91, 20);
            this.lblPerimeterSquare.TabIndex = 3;
            this.lblPerimeterSquare.Text = "Perímetro";
            // 
            // lblAreaSquare
            // 
            this.lblAreaSquare.AutoSize = true;
            this.lblAreaSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaSquare.Location = new System.Drawing.Point(24, 48);
            this.lblAreaSquare.Name = "lblAreaSquare";
            this.lblAreaSquare.Size = new System.Drawing.Size(48, 20);
            this.lblAreaSquare.TabIndex = 2;
            this.lblAreaSquare.Text = "Area";
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.btnCalculate);
            this.grbInput.Controls.Add(this.lblSide);
            this.grbInput.Controls.Add(this.txtSide);
            this.grbInput.Location = new System.Drawing.Point(32, 76);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(356, 169);
            this.grbInput.TabIndex = 5;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entradas";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(103, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "CALCULAR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(36, 52);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(50, 20);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Lado";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(103, 50);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(107, 22);
            this.txtSide.TabIndex = 1;
            // 
            // FrmHexagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.Name = "FrmHexagon";
            this.Text = "FrmHexagon";
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
        private System.Windows.Forms.Label lblPerimeterSquare;
        private System.Windows.Forms.Label lblAreaSquare;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Button btnCalculate;
    }
}