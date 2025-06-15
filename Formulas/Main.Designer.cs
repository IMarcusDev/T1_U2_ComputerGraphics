namespace Formulas
{
    partial class Main
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.dataGridPoints = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circunferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPoints)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(37, 151);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(658, 552);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // dataGridPoints
            // 
            this.dataGridPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPoints.Location = new System.Drawing.Point(712, 51);
            this.dataGridPoints.Name = "dataGridPoints";
            this.dataGridPoints.RowHeadersWidth = 62;
            this.dataGridPoints.RowTemplate.Height = 28;
            this.dataGridPoints.Size = new System.Drawing.Size(468, 652);
            this.dataGridPoints.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linesToolStripMenuItem,
            this.circunferenceToolStripMenuItem,
            this.polygonFillToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem});
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.linesToolStripMenuItem.Text = "Lines";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.bresenhamToolStripMenuItem.Text = "Bresenham";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // circunferenceToolStripMenuItem
            // 
            this.circunferenceToolStripMenuItem.Name = "circunferenceToolStripMenuItem";
            this.circunferenceToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.circunferenceToolStripMenuItem.Text = "Circunference";
            this.circunferenceToolStripMenuItem.Click += new System.EventHandler(this.circunferenceToolStripMenuItem_Click);
            // 
            // polygonFillToolStripMenuItem
            // 
            this.polygonFillToolStripMenuItem.Name = "polygonFillToolStripMenuItem";
            this.polygonFillToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.polygonFillToolStripMenuItem.Text = "Polygon Fill";
            this.polygonFillToolStripMenuItem.Click += new System.EventHandler(this.polygonFillToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(37, 51);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(658, 94);
            this.panelContainer.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 728);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.dataGridPoints);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPoints)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.DataGridView dataGridPoints;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circunferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonFillToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
    }
}

