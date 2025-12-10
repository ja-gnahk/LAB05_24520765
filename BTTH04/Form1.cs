using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontFamilies = FontFamily.Families;
            foreach (FontFamily font in fontFamilies)
            {
                cbFont.Items.Add(font.Name);
            }
            cbFont.SelectedIndex = 0;
            string[] sizes = { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
            cbSize.Items.AddRange(sizes);
            cbSize.SelectedItem = "28";

            // Đặt mặc định Center và áp dụng Font ban đầu
            rbCenter.Checked = true;
            CapNhat();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
                btnColor.BackColor = colorDialog1.Color;
            }
        }

        private void CapNhat()
        {
            if (cbFont.SelectedItem == null || cbSize.SelectedItem == null) return;

            string fontName = cbFont.SelectedItem.ToString();
            float sizeName = float.Parse(cbSize.SelectedItem.ToString());

            FontStyle fontstyle = FontStyle.Regular;

            if (ckbBold.Checked) fontstyle = fontstyle | FontStyle.Bold;
            if (ckbItalic.Checked) fontstyle = fontstyle | FontStyle.Italic;
            if (ckbUnderlined.Checked) fontstyle |= FontStyle.Underline;

            textBox1.Font = new Font(fontName, sizeName, fontstyle);
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void ckbUnderlined_CheckedChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void rbLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLeft.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Left;
            }
        }
        private void rbCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCenter.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
        }
        private void rbRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRight.Checked)
            {
                textBox1.TextAlign = HorizontalAlignment.Right;
            }
        }
    }
}