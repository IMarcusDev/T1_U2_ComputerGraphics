namespace Formulas.Forms
{
    partial class InputsCircunference
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio
            // 
            this.radio.AutoSize = true;
            this.radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio.Location = new System.Drawing.Point(134, 30);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(77, 29);
            this.radio.TabIndex = 0;
            this.radio.Text = "Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(217, 34);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(137, 26);
            this.txtRadio.TabIndex = 1;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(394, 29);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(90, 37);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // InputsCircunference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.radio);
            this.Name = "InputsCircunference";
            this.Size = new System.Drawing.Size(658, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnDraw;
    }
}
