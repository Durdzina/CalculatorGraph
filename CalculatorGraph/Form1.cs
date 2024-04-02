using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGraph
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }
        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (TxtResult.Text == "0")
                TxtResult.Text = "";
            {
                if (num.Text == ",")
                {
                    if (!TxtResult.Text.Contains(","))
                        TxtResult.Text = TxtResult.Text + num.Text;
                }
                else
                {
                    TxtResult.Text = TxtResult.Text + num.Text;
                }
            }
        }
        private void NumberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(TxtResult.Text);
            op = num.Text;
            TxtResult.Text = "";
        }

        private void BtnEquals(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(TxtResult.Text);

            switch (op)
            {
                case "+":
                    TxtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;
                case "-":
                    TxtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;
                case "*":
                    TxtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "/":
                    TxtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                default:
                    break;
            }
        }

        private void BtnClear(object sender, EventArgs e)
        {
            TxtResult.Text = "0";
        }

        private void BtnClearEntry(object sender, EventArgs e)
        {
            TxtResult.Text = "0";

            string f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 333;
            TxtResult.Width = 278;
        }

        private void BtnBS_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text.Length > 0)
            {
                TxtResult.Text = TxtResult.Text.Remove(TxtResult.Text.Length - 1, 1);
            }
            if (TxtResult.Text == "")
            {
                TxtResult.Text = "0";
            }
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "3.141592653589976323";
        }

        private void BtnSom_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(q * q);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if u want exit", "Scientific calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 627;
            TxtResult.Width = 584;
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(TxtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            TxtResult.Text = Convert.ToString(sqrt);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(q / 100);
        }
        private double selectedXValue;
        private void BtnSin_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(TxtResult.Text);
            double sin;
            sin = Math.Sin(input);
            TxtResult.Text = Convert.ToString(sin);
            double startX = 0; // Zakres od -2*pi do 2*pi dla sinusoidalnej funkcji
            double endX = 2 * Math.PI;
            double step = 0.1; // Krok dla x

            Bitmap bitmap = new Bitmap(GraphPictureBox.Width, GraphPictureBox.Height);
            using (Graphics g = Graphics.FromImage(bitmap))           
            {
                SolidBrush redBrush = new SolidBrush(Color.Red);
                int punktX = (int)(((int) input - startX) / (endX - startX) * GraphPictureBox.Width);
                double przeskalonwanyY = (sin + 1) / 2;
                int punktY = GraphPictureBox.Height-(int)(przeskalonwanyY * GraphPictureBox.Height);
                Rectangle rect = new Rectangle(punktX, punktY, 5, 5);
                 
                g.FillPie(redBrush, rect, 0F, 360F);
               
                Pen pen = new Pen(Color.Blue);

                // Początkowe punkty dla rysowania wykresu
                float prevX = 0;
                float prevY = 0;

                // Rysowanie wykresu funkcji sinus
                for (double x = startX; x <= endX; x += step)
                {
                    double y = Math.Sin(x);

                    // Skalowanie wartości y na zakres 0 - 1
                    double scaledY = (y +1) / 2;

                    // Przekształcenie skalowanej wartości y na współrzędną piksela
                    int pixelX = (int)((x - startX) / (endX - startX) * GraphPictureBox.Width);
                    int pixelY = GraphPictureBox.Height-(int)(scaledY * GraphPictureBox.Height);
                    
                    
                    // Rysowanie linii na wykresie
                    if (prevX != 0 || prevY != 0)
                    {
                        g.DrawLine(pen, prevX, prevY, pixelX, pixelY);
                    }

                    prevX = pixelX;
                    prevY = pixelY;
                }

                // Rysowanie osi X
                int zeroY = GraphPictureBox.Height / 2;
                g.DrawLine(pen, 0, zeroY, GraphPictureBox.Width, zeroY);
            }

            // Wyświetlenie wykresu na PictureBox
            GraphPictureBox.Image = bitmap;
        }   
        private void BtnCos_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(TxtResult.Text);
            double cos;
            cos= Math.Cos(input);
            TxtResult.Text=Convert.ToString(cos);
            double startX = 0;
            double endX = 2 * Math.PI;
            double step = 0.1;
            Bitmap bitmap=new Bitmap(GraphPictureBox1.Width, GraphPictureBox1.Height);
            using (Graphics h=  Graphics.FromImage(bitmap))
            {
                SolidBrush greenBrush = new SolidBrush(Color.Green);
                int punktX = (int)(((int)input - startX) / (endX - startX) * GraphPictureBox1.Width);
                double przeskalowanyY = (cos + 1) / 2;
                int punktY = GraphPictureBox1.Height-(int)(przeskalowanyY* GraphPictureBox1.Height);
                Rectangle rect = new Rectangle(punktX,punktY,5,5);
                h.FillPie(greenBrush, rect, 0F, 360F);
                Pen pen= new Pen(Color.Blue);
                float prevX = 0;
                float prevY=0;
                for (double x=startX; x <=endX;x+=step)
                {
                    double y = Math.Cos(x);
                    double scaledY = (y + 1) / 2;
                    int pixelX=(int)((x-startX)/(endX - startX)*GraphPictureBox1.Width);
                    int pixelY=GraphPictureBox1.Height-(int)(scaledY*GraphPictureBox1.Height);
                    if(prevX !=0 || prevY !=0)
                    {
                        h.DrawLine(pen,prevX,prevY ,pixelX,pixelY);
                    }
                    prevX = pixelX;
                    prevY = pixelY;
                }
                int zeroY = GraphPictureBox1.Height /2;
                h.DrawLine(pen,0,zeroY,GraphPictureBox1.Width,zeroY);
            }
            GraphPictureBox1.Image = bitmap;
        }

        private void BtnTg_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(TxtResult.Text);
            double tan;
            tan = Math.Tan(input);
            TxtResult.Text=Convert.ToString(tan);
            double startX = -Math.PI;
            double endX =  Math.PI;
            double step = 0.1;

            Bitmap bitmap= new Bitmap(GraphPictureBox2.Width, GraphPictureBox2.Height);
            using (Graphics j = Graphics.FromImage(bitmap))
            {
                SolidBrush purpleBrush = new SolidBrush(Color.Purple);
                int zeroY = GraphPictureBox2.Height / 2;
                int punktX = (int)(((int)input - startX) / (endX - startX) * GraphPictureBox2.Width);
                double przeskalowanyY = (1-tan) /2;
                int punktY= GraphPictureBox2.Height-(int)(przeskalowanyY * GraphPictureBox2.Height);
                Rectangle rect = new Rectangle(punktX,punktY,5,5);
                j.FillPie(purpleBrush, rect, 0F, 360F);
                Pen pen = new Pen(Color.Blue);
                float prevX = 0;
                float prevY = 0;
                for(double x=startX; x<=endX; x+=step)
                {
                    double y = Math.Tan(x);
                    double scaledY = (y+1) / 2;
                    int pixelX=(int)((x-startX)/ (endX - startX)*GraphPictureBox2.Width);
                    int pixelY=GraphPictureBox2.Height-(int)(scaledY * GraphPictureBox2.Height);
                    if(prevX !=0||prevY !=0)
                    {
                        j.DrawLine(pen, prevX, prevY, pixelX, pixelY);
                    }
                    prevX= pixelX;
                    prevY= pixelY;
                }
                
                j.DrawLine(pen,0,zeroY,GraphPictureBox2.Width,zeroY);
            }
            GraphPictureBox2.Image = bitmap;
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(TxtResult.Text);
            logg = Math.Log10(logg);
            TxtResult.Text = Convert.ToString(logg);
        }

        private void BtnLnX_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(TxtResult.Text);
            log = Math.Log(log);
            TxtResult.Text = Convert.ToString(log);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(1 / q);
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1140;
            TxtResult.Width = 584;
        }
        private void GraphPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlusMinus(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(-1 * q);
        }
    }
}
