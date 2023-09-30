using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calc_Tarasov
{

    public partial class Form1 : Form
    {
        int n;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Rost = double.Parse(textBox1.Text)/n;
            int Ves = int.Parse(textBox2.Text);
            double bmi = Ves/(Rost * Rost);
            trackBar1.Value = Convert.ToInt32(bmi) ;
            tb.Text = Math.Round( bmi,1).ToString();

            bmi = trackBar1.Value;
            panel2.Visible = true;
            if (bmi >= 20 && bmi <= 25)
            {
                label6.Text = "Здоровый";
                pictHealth.Image = Image.FromFile("C:\\Users\\STORM\\Desktop\\BMI calc\\bmi-healthy-icon.png");
            }
            else if(bmi<20)
            {
                label6.Text = "Недостаточный";
                pictHealth.Image = Image.FromFile("C:\\Users\\STORM\\Desktop\\BMI calc\\bmi-underweight-icon.png");
            }
            else if(bmi>25 && bmi < 30)
            {

            }
            else if(bmi>30 && bmi<35)
            {
                label6.Text = "Избыточный";
                pictHealth.Image = Image.FromFile("C:\\Users\\STORM\\Desktop\\BMI calc\\bmi-overweight-icon.png");
            }
            else if(bmi>35 && bmi<40)
            {
                label6.Text = "Ожирение";
                pictHealth.Image = Image.FromFile("C:\\Users\\STORM\\Desktop\\BMI calc\\bmi-obese-icon.png");
            
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           

            
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
            pictureBox2.BackColor = Color.Gray;
            n = 110;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.White;
            n = 100;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
