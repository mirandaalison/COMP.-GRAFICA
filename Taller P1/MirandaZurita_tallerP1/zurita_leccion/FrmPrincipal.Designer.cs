namespace zurita_leccion
{
    partial class FrmPrincipal
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
            this.btnEstrella1 = new System.Windows.Forms.Button();
            this.btnEstrella2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEstrella1
            // 
            this.btnEstrella1.Location = new System.Drawing.Point(219, 229);
            this.btnEstrella1.Name = "btnEstrella1";
            this.btnEstrella1.Size = new System.Drawing.Size(140, 55);
            this.btnEstrella1.TabIndex = 0;
            this.btnEstrella1.Text = "Estrella Loop";
            this.btnEstrella1.UseVisualStyleBackColor = true;
            this.btnEstrella1.Click += new System.EventHandler(this.btnEstrella1_Click);
            // 
            // btnEstrella2
            // 
            this.btnEstrella2.Location = new System.Drawing.Point(444, 228);
            this.btnEstrella2.Name = "btnEstrella2";
            this.btnEstrella2.Size = new System.Drawing.Size(163, 56);
            this.btnEstrella2.TabIndex = 1;
            this.btnEstrella2.Text = "Estrella Compleja";
            this.btnEstrella2.UseVisualStyleBackColor = true;
            this.btnEstrella2.Click += new System.EventHandler(this.btnEstrella2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUÉ ESTRELLA DESEA VISUALIZAR?";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstrella2);
            this.Controls.Add(this.btnEstrella1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstrella1;
        private System.Windows.Forms.Button btnEstrella2;
        private System.Windows.Forms.Label label1;
    }
}