using System.Drawing.Drawing2D;

namespace OtelRezervasyonSistemi
{
    public partial class MainForm : Form
    {

 
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            MusteriForm musteriForm = new MusteriForm();
            musteriForm.Show();
        }

        private void btnYoneticiGirisi_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
        }
    }

    public class CustomButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;

            // Düðmenin arka planýný ve kenarlarýný çizin.
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = ClientRectangle;
            rect.Inflate(-1, -1); // Kenarlýk için küçült

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 30; // Oval kenar yarýçapý
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillPath(brush, path);
                }

                using (Pen pen = new Pen(Color.DarkGray, 2))
                {
                    g.DrawPath(pen, path);
                }
            }

            // Metni ortalayarak çiz.
            TextRenderer.DrawText(g, Text, Font, rect, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
