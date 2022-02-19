namespace level_2
{
    public partial class Form1 : Form
    {
        private PointF[] p = new PointF[200];
        public Form1()
        {
            InitializeComponent();
            Calc();
        }

        private void Calc()
        {
            for (int x = -100; x < 100; x++)
            {
                double res = Math.Pow(x, 3) + 5 * Math.Pow(x, 2) + 14 * x - 56;
                p[x + 100] = new PointF(x, (float)res);

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(150, 150);
            e.Graphics.ScaleTransform(1, -0.25F);
            e.Graphics.DrawLines(Pens.Blue, p);
        }
    }
}