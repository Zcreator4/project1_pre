using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hello_cs_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Why did you click me.");
            MessageBox.Show("You cant escape.");
            MessageBox.Show("You cant escape.");
            MessageBox.Show("You cant escape.");
            MessageBox.Show("Whatty Do Flight Crew. FTC, Flight team stand up!");
            MessageBox.Show("Whatty Do Flight Crew. FTC, Flight team stand up!");
            MessageBox.Show("Whatty Do Flight Crew. FTC, Flight team stand up!");
            MessageBox.Show("Whatty Do Flight Crew. FTC, Flight team stand up!");
            MessageBox.Show("You cant escape.");
            MessageBox.Show("fine.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The C# button is annoying isnt it.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DeepSkyBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Empty;
            this.BackColor = Color.Empty;
            ForeColor = Color.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Aqua;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Lol you thought something bad was about to happen.";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to continue?", "Finish", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("c:\\Users\\Zander\\barrack.jpg");
            this.panel1.BackgroundImage= Image.FromFile("c:\\Users\\Zander\\barrack.jpg");
            this.tabPage5.BackgroundImage= Image.FromFile("c:\\Users\\Zander\\barrack.jpg");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string msg;
            msg = textBox4.Text + " ";
            MessageBox.Show("Hi " + msg + "welcome back");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int a1;
            int a2;
            Int32.TryParse(this.textBox5.Text, out a1);
            Int32.TryParse(this.textBox6.Text, out a2);
            int a3; 
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            int a1;
            int a2;
            Int32.TryParse(this.textBox6.Text, out a1);
            Int32.TryParse(this.textBox5.Text, out a2);
            int a3;
            a3 = a1 - a2;
            MessageBox.Show(a3.ToString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            float a1;
            float a2;
            float.TryParse(this.textBox5.Text, out a1);
            float.TryParse(this.textBox6.Text, out a2);
            float a3;
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            long a1;
            long a2;
            long.TryParse(this.textBox5.Text, out a1);
            long.TryParse(this.textBox6.Text, out a2);
            long a3;
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double a1;
            double a2;
            double.TryParse(this.textBox5.Text, out a1);
            double.TryParse(this.textBox6.Text, out a2);
            double a3;
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            decimal a1;
            decimal a2;
            decimal.TryParse(this.textBox5.Text, out a1);
            decimal.TryParse(this.textBox6.Text, out a2);
            decimal a3;
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string path;
            path = "C:\\Windows\\System32\\calc.exe";
            this.process1.StartInfo.FileName = path;
            this.process1.Start();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int uyb;
            int age;
            int current;
            current = DateTime.Now.Year;
            int.TryParse(this.textBox7.Text, out uyb);
            age = current - uyb;
            if(age>14)
            {
                MessageBox.Show("You are older than me!");
            }
            if(age < 13)
            {
                MessageBox.Show("You are younger than me!");
            }
            if (age == 14)
            {
                MessageBox.Show("You are the same age as me!");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int uyb;
            int age;
            int current;
            current = DateTime.Now.Year;
            int.TryParse(this.textBox8.Text, out uyb);
            age = current - uyb;
            MessageBox.Show(age.ToString());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int z;
            for (z=0; z<100; z++)
            {
                comboBox1.Items.Add("ooga");
            }
            if (comboBox1.Items.Count == 100)
            {
                MessageBox.Show("There are now 100 oogas in the combo box lol");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int mn;
            int.TryParse(this.textBox9.Text, out mn);
            string month;
            month = "uknown";
            if (mn == 1)
            {
                month = "January";
            }
            if (mn == 2)
            {
                month = "Febuary";
            }
            if (mn == 3)
            {
                month = "March";
            }
            if (mn == 4)
            {
                month = "April";
            }
            if (mn == 5)
            {
                month = "May";
            }
            if (mn == 6)
            {
                month = "June";
            }
            if (mn == 7)
            {
                month = "July";
            }
            if (mn == 8)
            {
                month = "August";
            }
            if (mn == 9)
            {
                month = "September";
            }
            if (mn == 10)
            {
                month = "October";
            }
            if (mn == 11)
            {
                month = "November";
            }
            if (mn == 12)
            {
                month = "December";
            }
            MessageBox.Show(month.ToString());
        }
    }
}
