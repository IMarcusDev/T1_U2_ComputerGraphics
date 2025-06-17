using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulas.clases;
using Formulas.Forms;

namespace Formulas
{
    public partial class Main : Form
    {
        private LineFormula lineFormula;
        private LineBresenham lineBresenham;
        private Polygon polygon;
        private Pen pen;
        Bitmap picCanvasCopy;
        List<Color> colors = new List<Color> { Color.Violet, Color.Red, Color.Purple, Color.Green, Color.DarkGreen, Color.DarkOrange, Color.Orange, Color.Peru, Color.Pink, Color.Tan };
        List<Action<Graphics>> framesCopy = new List<Action<Graphics>>();
        private Timer animationTimer;
        private int IndexAnimation = 0;
        private PointF[] lastPolygonOutline = null;

        private InputsLines inputsLines;
        private InputsLines inputsLinesBresenham;
        private InputsPolygon inputsPolygon;
        private InputsPolygonParallel inputsPolygonParallel;
        private InputsCircunference inputsCircunference;

        public Main()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
            picCanvasCopy = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = picCanvasCopy;

            inputsLines = new InputsLines();
            inputsLinesBresenham = new InputsLines();
            inputsPolygon = new InputsPolygon(getCenter());
            inputsPolygonParallel = new InputsPolygonParallel(getCenter());
            inputsCircunference = new InputsCircunference();

            inputsLines.OnDrawClicked += InputsLines_OnDrawClicked;
            inputsLinesBresenham.OnDrawClicked += InputsLinesBresenham_OnDrawClicked;
            inputsPolygon.OnDrawClicked += InputsPolygon_OnDrawClicked;
            inputsCircunference.OnDrawClicked += CircunferenceBresenham_OnDrawClicked;
            inputsPolygonParallel.OnDrawClicked += InputsPolygonParallel_OnDrawClicked;

            dataGridPoints.Columns.Clear();
            dataGridPoints.Columns.Add("#", "#");
            dataGridPoints.Columns.Add("x", "x");
            dataGridPoints.Columns.Add("y", "y");

            dataGridPoints.AllowUserToAddRows = false;
            dataGridPoints.AllowUserToDeleteRows = false;
            dataGridPoints.ReadOnly = true;
            dataGridPoints.RowHeadersVisible = false;
        }

        private void ShowPointsInGrid(Point[] points)
        {
            dataGridPoints.Rows.Clear();
            for (int i = 0; i < points.Length; i++)
            {
                dataGridPoints.Rows.Add(i + 1, points[i].X, points[i].Y);
            }
        }

        private void openChildForm(object childForm)
        {
            if (childForm == null)
            {
                MessageBox.Show("El formulario no puede ser nulo.", "Error");
                return;
            }

            if (this.panelContainer.Controls.Count > 0) this.panelContainer.Controls.RemoveAt(0);
            UserControl uc = childForm as UserControl;
            if (uc != null)
            {
                uc.Dock = DockStyle.Fill;
                this.panelContainer.Controls.Add(uc);
                this.panelContainer.Tag = uc;
            }
            else
            {
                MessageBox.Show("El objeto no es un UserControl válido.", "Error");
            }
        }


        private void ensureFramesUpTo(int target, Point[] points)
        {
            for (int i = 0; i < target && i < points.Length; i++)
            {
                int colorIndex = i % colors.Count;
                Color currentColor = this.colors[colorIndex];
                int index = i;

                framesCopy.Add(g =>
                {
                    using (Pen localPen = new Pen(currentColor, 2))
                    {
                        g.DrawRectangle(localPen, points[index].X * 10, points[index].Y * 10, 4, 4);
                    }
                });
            }
        }

        private void ensureFramesUpToCircunference(int target, Point[] points)
        {
            for (int i = 0; i < target && i < points.Length; i++)
            {
                int colorIndex = i % colors.Count;
                Color currentColor = this.colors[colorIndex];
                int index = i;

                framesCopy.Add(g =>
                {
                    using (SolidBrush brush = new SolidBrush(currentColor))
                    {
                        g.FillRectangle(brush, points[index].X , points[index].Y, 3, 3);
                    }
                });
            }
        }

        private void ensureFramesUpToFill(int target, Point[] points)
        {
            for (int i = 0; i < target && i < points.Length; i++)
            {
                int colorIndex = i % colors.Count;
                Color currentColor = this.colors[colorIndex];
                int index = i;

                framesCopy.Add(g =>
                {
                    using (SolidBrush brush = new SolidBrush(currentColor))
                    {
                        g.FillRectangle(brush, points[index].X, points[index].Y, 1, 1);
                    }
                });
            }
        }


        private void PlayFrames()
        {
            if (framesCopy.Count == 0)
                return;

            IndexAnimation = 0;

            if (animationTimer == null)
            {
                animationTimer = new Timer();
                animationTimer.Interval = 100;
                animationTimer.Tick += AnimationTimer_Tick;
            }

            animationTimer.Start();
        }

        private void PlayFramesCircle()
        {
            if (framesCopy.Count == 0)
                return;

            IndexAnimation = 0;

            if (animationTimer == null)
            {
                animationTimer = new Timer();
                animationTimer.Interval = 20;
                animationTimer.Tick += AnimationTimer_Tick;
            }

            animationTimer.Start();
        }

        private void PlayFramesToFill()
        {
            if (framesCopy.Count == 0)
                return;

            IndexAnimation = 0;

            if (animationTimer == null)
            {
                animationTimer = new Timer();
                animationTimer.Interval = 10;
                animationTimer.Tick += AnimationTimer_Tick;
            }

            animationTimer.Start();
        }
        
        private void PlayFramesToFillParallel()
        {
            if (framesCopy.Count == 0)
                return;

            IndexAnimation = 0;

            if (animationTimer == null)
            {
                animationTimer = new Timer();
                animationTimer.Interval = 2;
                animationTimer.Tick += AnimationTimer_Tick;
            }

            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (IndexAnimation <= framesCopy.Count)
            {
                drawAllAgain();
                IndexAnimation++;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void drawAllAgain()
        {
            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);

                for (int i = 0; i < IndexAnimation && i < framesCopy.Count; i++)
                {
                    framesCopy[i](g);
                }

                if (lastPolygonOutline != null)
                {
                    g.DrawPolygon(pen, lastPolygonOutline);
                }
            }
            picCanvas.Invalidate();
        }


        private PointF getCenter()
        {
            PointF center = new PointF();
            center.X = picCanvas.Width/2;
            center.Y = picCanvas.Height/2;
            return center;
        }

        private Point[] GetCirclePoints(int xc, int yc, int r)
        {
            List<Point> points = new List<Point>();
            circunferenceBresenham.DrawCircle(xc, yc, r, (x, y) => points.Add(new Point(x, y)));
            return points.ToArray();
        }

        private Point[] GetCirclePointsUnique(int xc, int yc, int r)
        {
            HashSet<Point> points = new HashSet<Point>();
            circunferenceBresenham.DrawCircle(xc, yc, r, (x, y) => points.Add(new Point(x, y)));
            return points.ToArray();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(this.inputsLines);
        }

        private void circunferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(this.inputsCircunference);
        }

        private void polygonFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(this.inputsPolygon);
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(this.inputsLinesBresenham);
        }

        private void iterativoConParalelismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(this.inputsPolygonParallel);
        }

        private void InputsLines_OnDrawClicked(Point p1, Point p2)
        {
            lastPolygonOutline = null;
            lineFormula = new LineFormula(p1, p2);
            Point[] linePoints = lineFormula.getLinePoints();
            framesCopy.Clear();
            ensureFramesUpTo(linePoints.Length, linePoints);
            PlayFrames();
            ShowPointsInGrid(linePoints);
        }

        private void InputsLinesBresenham_OnDrawClicked(Point p1, Point p2)
        {
            lastPolygonOutline = null;
            lineBresenham = new LineBresenham(p1, p2);
            Point[] linePoints = lineBresenham.getBresenhamPoints();
            framesCopy.Clear();
            ensureFramesUpTo(linePoints.Length, linePoints);
            PlayFrames();
            ShowPointsInGrid(linePoints);
        }

        private void CircunferenceBresenham_OnDrawClicked(int radio)
        {
            lastPolygonOutline = null;
            int xc = picCanvas.Width / 2;
            int yc = picCanvas.Height / 2;
            int r = radio;

            Point[] circlePointsUnique = GetCirclePointsUnique(xc, yc, r);
            framesCopy.Clear();
            ensureFramesUpToCircunference(circlePointsUnique.Length, circlePointsUnique);
            PlayFramesCircle();
            ShowPointsInGrid(circlePointsUnique);
        }

        private void InputsPolygon_OnDrawClicked(int lados, float magnitud, PointF center)
        {
            polygon = new Polygon(lados, magnitud, center);
            PointF[] points = polygon.GetOutline();
            lastPolygonOutline = points;

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                g.DrawPolygon(pen, points);
            }

            Point seed = new Point((int)center.X, (int)center.Y);

            Point[] filledPixels = FillAlgorithm.Recursive_Flood_Fill(picCanvasCopy, seed.X, seed.Y, Color.Blue);

            framesCopy.Clear();
            ensureFramesUpToFill(filledPixels.Length, filledPixels);
            PlayFramesToFill();
            ShowPointsInGrid(filledPixels);
        }

        private void InputsPolygonParallel_OnDrawClicked(int lados, float magnitud, PointF center)
        {
            polygon = new Polygon(lados, magnitud, center);
            PointF[] points = polygon.GetOutline();
            lastPolygonOutline = points;

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                g.DrawPolygon(pen, points);
            }

            Point seed = new Point((int)center.X, (int)center.Y);

            Point[] filledPixels = FillAlgorithm.Iterative_Parallel_Flood_Fill(picCanvasCopy, seed.X, seed.Y, Color.Blue);

            framesCopy.Clear();
            ensureFramesUpToFill(filledPixels.Length, filledPixels);
            PlayFramesToFillParallel();
            ShowPointsInGrid(filledPixels);
        } 
    }
}
