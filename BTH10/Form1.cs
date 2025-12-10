using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Linq;
namespace BTH10
{
    public partial class Form1 : Form
    {
        private Color demoColor = Color.Red;
        private Pen currentPen;
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            SetupPenControlsEvents();
            pnlCanvas.Paint += new PaintEventHandler(pnlCanvas_Paint);
        }
        private PointF[] demoPoints = new PointF[]
        {
            new PointF(20, 70),
            new PointF(150, 250),
            new PointF(280, 70)
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDashStyle.Items.AddRange(Enum.GetNames(typeof(DashStyle)));
            cmbLineJoin.Items.AddRange(Enum.GetNames(typeof(LineJoin)));
            cmbDashCap.Items.AddRange(Enum.GetNames(typeof(DashCap)));
            cmbStartCap.Items.AddRange(Enum.GetNames(typeof(LineCap)));
            cmbEndCap.Items.AddRange(Enum.GetNames(typeof(LineCap)));

            string[] widths = { "1", "3", "5", "8", "9", "12", "15" };
            cmbWidth.Items.AddRange(widths);

            cmbDashStyle.SelectedItem = "DashDot";
            cmbLineJoin.SelectedItem = "Round";
            cmbDashCap.SelectedItem = "Triangle";
            cmbStartCap.SelectedItem = "Triangle";
            cmbEndCap.SelectedItem = "RoundAnchor";
            cmbWidth.SelectedItem = "9";

            UpdateDrawing();
        }

        private void SetupPenControlsEvents()
        {
            cmbDashStyle.SelectedIndexChanged += (s, e) => UpdateDrawing();
            cmbLineJoin.SelectedIndexChanged += (s, e) => UpdateDrawing();
            cmbDashCap.SelectedIndexChanged += (s, e) => UpdateDrawing();
            cmbStartCap.SelectedIndexChanged += (s, e) => UpdateDrawing();
            cmbEndCap.SelectedIndexChanged += (s, e) => UpdateDrawing();

            cmbWidth.TextChanged += (s, e) => UpdateDrawing();
        }

        private void UpdateDrawing()
        {
            if (cmbDashStyle.SelectedItem == null || cmbWidth.Text == "") return;

            float penWidth = 1f;
            if (!float.TryParse(cmbWidth.Text, out penWidth))
            {
                penWidth = 1f;
            }
            if (penWidth < 1) penWidth = 1f;

            if (currentPen != null) currentPen.Dispose();
            currentPen = new Pen(demoColor, penWidth);

            try
            {
                currentPen.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), cmbDashStyle.SelectedItem.ToString());
                currentPen.LineJoin = (LineJoin)Enum.Parse(typeof(LineJoin), cmbLineJoin.SelectedItem.ToString());
                currentPen.DashCap = (DashCap)Enum.Parse(typeof(DashCap), cmbDashCap.SelectedItem.ToString());
                currentPen.StartCap = (LineCap)Enum.Parse(typeof(LineCap), cmbStartCap.SelectedItem.ToString());
                currentPen.EndCap = (LineCap)Enum.Parse(typeof(LineCap), cmbEndCap.SelectedItem.ToString());
            }
            catch
            {
            }
            pnlCanvas.Invalidate();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (currentPen == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawLines(currentPen, demoPoints);
        }
    }
}
