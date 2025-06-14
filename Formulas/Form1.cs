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

namespace Formulas
{
    public partial class Form1 : Form
    {
        private LineFormula lineFormula;
        private LineBresenham lineBresenham;
        private Polygon polygon;
        private Graphics graphics;
        private Pen pen;
        Bitmap picCanvasCopy;
        List<Color> colors = new List<Color> { Color.Violet, Color.Red, Color.Purple, Color.Green, Color.DarkGreen, Color.DarkOrange, Color.Orange, Color.Peru, Color.Pink, Color.Tan };
        List<Action<Graphics>> framesCopy = new List<Action<Graphics>>();
        private int currentFrame = 0;
        private Timer animationTimer;
        private int IndexAnimation = 0;
        private PointF[] lastPolygonOutline = null;

        public Form1()
        {
            InitializeComponent();
            lineFormula = new LineFormula(new Point(3,4), new Point(13,11));
            lineBresenham = new LineBresenham(new Point(1, 2), new Point(4, 20));
            graphics = picCanvas.CreateGraphics();
            pen = new Pen(Color.Black, 1);
            picCanvasCopy = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = picCanvasCopy;
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
                        g.DrawRectangle(localPen, points[index].X * 20, points[index].Y * 20, 4, 4);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Point[] linePoints = lineFormula.getLinePoints();
            framesCopy.Clear();
            ensureFramesUpTo(linePoints.Length, linePoints);
            PlayFrames();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point[] linePoints = lineBresenham.getBresenhamPoints();
            framesCopy.Clear();
            ensureFramesUpTo(linePoints.Length, linePoints);
            PlayFrames();
        }

        private Point[] GetCirclePoints(int xc, int yc, int r)
        {
            List<Point> points = new List<Point>();
            circunferenceBresenham.DrawCircle(xc, yc, r, (x, y) => points.Add(new Point(x / 20, y / 20)));
            return points.ToArray();
        }

        private Point[] GetCirclePointsUnique(int xc, int yc, int r)
        {
            HashSet<Point> points = new HashSet<Point>();
            circunferenceBresenham.DrawCircle(xc, yc, r, (x, y) => points.Add(new Point(x/20, y/20)));
            return points.ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int xc = picCanvas.Width / 2;
            int yc = picCanvas.Height / 2;
            int r = 100;

            Point[] circlePointsUnique = GetCirclePointsUnique(xc, yc, r);
            framesCopy.Clear();
            ensureFramesUpTo(circlePointsUnique.Length, circlePointsUnique);
            PlayFrames();
        }

        private List<Point> GetNonWhitePixels(Bitmap bmp)
        {
            List<Point> pixels = new List<Point>();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (bmp.GetPixel(x, y).ToArgb() != Color.White.ToArgb())
                    {
                        pixels.Add(new Point(x, y));
                    }
                }
            }
            return pixels;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numLados = int.Parse(txtNumLados.Text);
            polygon = new Polygon(numLados, 20);
            polygon.SetCenter(getCenter());
            PointF[] points = polygon.GetOutline();

            lastPolygonOutline = points;

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                g.DrawPolygon(pen, points);
            }

            Point seed = new Point((int)getCenter().X, (int)getCenter().Y);

            Point[] filledPixels = FillAlgorithm.Recursive_Flood_Fill(picCanvasCopy, seed.X, seed.Y, Color.Blue);

            framesCopy.Clear();
            ensureFramesUpToFill(filledPixels.Length, filledPixels);
            PlayFrames();
        }


    }
}
