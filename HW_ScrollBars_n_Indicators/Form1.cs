using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_ScrollBars_n_Indicators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {       
            textBox1.Location = new Point(textBox1.Location.X, vScrollBar1.Value);
            textBox1.Text = $"Верхний левый угол: {textBox1.Location.X} : {textBox1.Location.Y} " + $"\n" +
                $"\nПравы нижний угол: {textBox1.Location.X + textBox1.Size.Width} : " +
                $"{textBox1.Location.Y + textBox1.Size.Height}";
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Location = new Point(hScrollBar1.Value, textBox1.Location.Y );
            textBox1.Text = $"Верхний левый угол: {textBox1.Location.X} : {textBox1.Location.Y} " + $"\n" +
                $"\nПравы нижний угол: {textBox1.Location.X + textBox1.Size.Width} : " +
                $"{textBox1.Location.Y + textBox1.Size.Height}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size((74 + trackBar1.Value * 10), (42 + trackBar1.Value * 10));
        }

        private void btn_clockwise_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Size = new Size(pictureBox2.Size.Width + 1, pictureBox2.Size.Height + 1);            
        }

        private void btn_counter_clockwise_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox2.Size = new Size(pictureBox2.Size.Width + 1, pictureBox2.Size.Height + 1);            
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, vScrollBar2.Value + 289);            
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(hScrollBar2.Value +13, pictureBox1.Location.Y);
        }      

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            FormTools newFormTools = new FormTools(this);
            newFormTools.pictureBox2 = pictureBox2; // связываем ссылкой pictureBox2 с FormTools
            newFormTools.Show();
        }
    }
}
