using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

namespace BTH06
{
    public partial class Form1 : Form
    {
        private const int Font_Size = 16;
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            listBox1.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;
            
            foreach (FontFamily fontFamily in fontFamilies)
            {
                listBox1.Items.Add(fontFamily.Name);
            }
        }
        private void listBox1_DrawItem (object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= listBox1.Items.Count) return;

            string fontName = listBox1.Items[e.Index].ToString();
            e.DrawBackground();

            try
            {
                using (Font drawFont = new Font(fontName, Font_Size))
                {
                    Brush drawBrush = new SolidBrush(e.ForeColor);

                    e.Graphics.DrawString(
                        fontName,
                        drawFont,
                        drawBrush,
                        e.Bounds.Left,
                        e.Bounds.Top
                    );
                }
            }
            catch (Exception) { }
            e.DrawFocusRectangle();
        }
    }
}
