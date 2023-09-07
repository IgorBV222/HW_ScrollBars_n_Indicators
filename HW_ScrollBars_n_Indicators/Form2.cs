using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_ScrollBars_n_Indicators
{
    public partial class FormTools : Form
    {
        public PictureBox pictureBox2; // эта переменная будет содержать ссылку на кнопку pictureBox2 из формы Form1
        Form mainForm;
        public FormTools(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        public void trackBar_Scroll(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size((74 + trackBar.Value * 10), (42 + trackBar.Value * 10));
        }

        private void btn_counter_clockwise_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox2.Size = new Size(pictureBox2.Size.Width + 1, pictureBox2.Size.Height + 1);
        }

        private void btn_clockwise_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Size = new Size(pictureBox2.Size.Width + 1, pictureBox2.Size.Height + 1);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, vScrollBar1.Value + 13);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox2.Location = new Point(hScrollBar1.Value + 372, pictureBox2.Location.Y);
        }
    }
}
