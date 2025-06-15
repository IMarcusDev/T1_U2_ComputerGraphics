namespace Formulas.Forms
{
    partial class InputsPolygon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumLados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lados";
            // 
            // txtNumLados
            // 
            this.txtNumLados.Location = new System.Drawing.Point(107, 35);
            this.txtNumLados.Name = "txtNumLados";
            this.txtNumLados.Size = new System.Drawing.Size(140, 26);
            this.txtNumLados.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Magnitud";
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(371, 34);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(159, 26);
            this.txtMagnitud.TabIndex = 3;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(561, 25);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 35);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // InputsPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtMagnitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumLados);
            this.Controls.Add(this.label1);
            this.Name = "InputsPolygon";
            this.Size = new System.Drawing.Size(658, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumLados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.Button btnDraw;
    }
}