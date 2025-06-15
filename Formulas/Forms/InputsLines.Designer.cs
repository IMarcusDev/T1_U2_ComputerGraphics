namespace Formulas.Forms
{
    partial class InputsLines
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
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(163, 13);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 26);
            this.txtX1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(115, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "X2";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(163, 48);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 26);
            this.txtX2.TabIndex = 3;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(325, 48);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 26);
            this.txtY2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(277, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y2";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(325, 13);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 26);
            this.txtY1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(277, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y1";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(464, 25);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(94, 39);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // InputsLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label1);
            this.Name = "InputsLines";
            this.Size = new System.Drawing.Size(658, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDraw;
    }
}