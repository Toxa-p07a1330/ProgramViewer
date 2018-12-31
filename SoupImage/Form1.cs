using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoupImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width/8, Screen.PrimaryScreen.Bounds.Height/8);
        public static Bitmap soup = new Bitmap(Screen.PrimaryScreen.Bounds.Width/8, Screen.PrimaryScreen.Bounds.Height/8);
        double percent = 0.5;
        private void makeScreen_Click(object sender, EventArgs e)
        {
            Graphics GH = Graphics.FromImage(screen as Image);
            GH.CopyFromScreen(0, 0, 0, 0, screen.Size);
            screen_picture.Image = screen;
        }
        private Color mixPixels(Bitmap source, int x, int y, double percent)
        {
            Color colorCentral;
            int colorAddR=0, colorAddG=0, colorAddB = 0;
            colorCentral = source.GetPixel(x, y);
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    try
                    {
                        colorAddB += source.GetPixel(x + i, y + j).B;
                        colorAddG += source.GetPixel(x + i, y + j).G;
                        colorAddR += source.GetPixel(x + i, y + j).R;
                    }
                    catch
                    { }
                }
            }
            colorAddB = (int)((colorAddB * percent + colorCentral.B) / (1 + percent * 9));
            colorAddG = (int)((colorAddG * percent + colorCentral.G) / (1 + percent * 9));
            colorAddR = (int)((colorAddR * percent + colorCentral.R) / (1 + percent * 9));
            colorCentral = Color.FromArgb(255, colorAddR, colorAddG, colorAddB);
            return colorCentral;
        }

        private void soup_button_Click(object sender, EventArgs e)
        {
            for (int i=0; i<soup.Width; i++)
                for (int j = 0; j<soup.Height; j++)
                {
                    soup.SetPixel(i, j, mixPixels(screen, i, j, percent));
                }
            soup_picture.Image = soup;
        }

        private void percenOfSoup_Scroll(object sender, EventArgs e)
        {
            percent = percenOfSoup.Value / 100;
            label1.Text = "persent:" + percenOfSoup.Value.ToString();
        }

        private void makeBW_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < soup.Width; i++)
                for (int j = 0; j < soup.Height; j++)
                {
                    try
                    {
                        Color color = screen.GetPixel(i, j);
                        int midd = color.R + color.B + color.G;
                        midd /= 3;
                        soup.SetPixel(i, j, Color.FromArgb(255, midd, midd, midd));
                    }
                    catch { }
                }
            soup_picture.Image = soup;
        }

        private void transporate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < soup.Width; i++)
                for (int j = 0; j < soup.Height; j++)
                {
                    try
                    {
                        soup.SetPixel(i, j, screen.GetPixel(i, soup.Height - j));
                    }
                    catch { };

                }
            soup_picture.Image = soup;
        }

        private void import_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap tmp = (Bitmap)Image.FromFile(openFileDialog1.FileName);
            for (int i = 0; i<screen.Width; i++)
            {
                for (int j =0; j<screen.Height; j++)
                {
                    screen.SetPixel(i, j, tmp.GetPixel(i, j));
                }
            }
            screen_picture.Image = screen;
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            screen = soup;
            screen_picture.Image = soup_picture.Image;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            for(int i=0; i<screen.Width; i++)
            {
                for (int j =0; j<screen.Height; j++)
                {
                    //try
                    //{
                        Color color1 = screen.GetPixel(i, j);
                        Color color2 = soup.GetPixel(i, j);
                        Color color = new Color();
                        color = Color.FromArgb((int)(color1.R * percent + color2.R * (1 - percent)), (int)(color1.G * percent + color2.G * (1 - percent)), (int)(color1.B * percent + color2.B * (1 - percent)));
                        soup.SetPixel(i, j, color);
                        
                    //}
                    //catch { }
                }
                soup_picture.Image = soup;
            }
        }

        private void pass_button_Click(object sender, EventArgs e)
        {
            soup = screen;
            soup_picture.Image = screen_picture.Image;
        }
    }
}
