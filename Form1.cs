using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontrol
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double salary = 0, vat = 0, salaryvat = 0, total = 0, discout = 0;


        //ลองโค้ดเคลี่อนย้าย

        int mov;
        int movX;
        int movY;




        public object MyTabControl { get; private set; }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            panel4.Height = button7.Height;
            panel4.Top = button7.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g1;
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g2;
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g3;
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g4;
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g5;
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g6;
            panel4.Height = button8.Height;
            panel4.Top = button8.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g1;
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //กลุ่มที่1

            discout = 0;
            int baby = 0;
            int pikan = 0;
            
            if (radioButton1.Checked) discout += 60000;
            if (radioButton3.Checked) discout += 70000;
            if (radioButton2.Checked) discout += 60000;
            if (radioButton5.Checked) discout += 30000;
            if (radioButton4.Checked)
            {
                pikan = 60000 * (int)numericUpDown1.Value;
                discout += pikan;
            }

            

            if (radioButton8.Checked)
                baby = 60000 * (int)numericUpDown2.Value - 30000 + int.Parse(textBox3.Text);
                discout += baby;
            if (radioButton9.Checked)
                baby = 30000 * (int)numericUpDown2.Value + int.Parse(textBox3.Text) ;
                discout += baby;
            
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ภาษีเงินได้

            salary = double.Parse(textBox2.Text);
            if (salary > 5000000)
            {
                vat = salary * 35 / 100;
            }

            else if (salary > 2000000)
            {
                vat = salary * 30 / 100;
            }
            else if (salary > 1000000)
            {
                vat = salary * 25/ 100;
            }
            else if (salary > 750000)
            {
                vat = salary * 20 / 100;
            }
            else if (salary > 500000)
            {
                vat = salary * 15 / 100 ;
            }
            else if (salary > 300000)
            {
                vat = salary * 10 / 100;
            }
            else if (salary > 150000)
            {
                vat = salary * 5 / 100;
            }
            else
            {
                vat = 0;
            }

            salaryvat = salary-vat;
            textBox28.Text = salaryvat.ToString("#,##.00");
            total = salary- salaryvat + discout;
            textBox27.Text = total.ToString("#,##.00");

            //กลุ่มที่2

            if (int.Parse(textBox4.Text) < 9000) ;
            discout = +int.Parse(textBox4.Text);
            
            if (int.Parse(textBox5.Text) < 100000) ;
            discout = +int.Parse(textBox5.Text);
          
            if(int.Parse(textBox6.Text)  < 15000) ;
            discout = +int.Parse(textBox6.Text);
            
            if (int.Parse(textBox7.Text) < 10000) ;
            discout = +int.Parse(textBox7.Text);
            
            if (int.Parse(textBox8.Text) < 200000) ;
            discout = +int.Parse(textBox8.Text);
            
            if (int.Parse(textBox19.Text) < 15/100*salary ) ;
            discout = +int.Parse(textBox9.Text);
            
            if (int.Parse(textBox10.Text) < 13200) ;
            discout = +int.Parse(textBox10.Text);
            
            
            if (int.Parse(textBox11.Text) < 15 / 100 * salary) ;
            discout = +int.Parse(textBox11.Text);

            if (int.Parse(textBox12.Text) < 15 / 100 * salary) ;
            discout = +int.Parse(textBox12.Text);

            //กลุ่มที่3

            if (int.Parse(textBox13.Text) < 100000) ;
            discout = +int.Parse(textBox13.Text);
            if (int.Parse(textBox14.Text) < 15 / 100 * int.Parse(textBox14.Text)) ;
            discout = +int.Parse(textBox14.Text);
            if (int.Parse(textBox15.Text) < 200000) ;
            discout = +int.Parse(textBox15.Text);

            //กลุ่มที่4
            if (int.Parse(textBox19.Text) < 10000) ;
            discout = +int.Parse(textBox19.Text);






            //กลุ่มที่5

            if (int.Parse(textBox20.Text) < 100000) ;
            discout = +int.Parse(textBox20.Text);
            if (int.Parse(textBox21.Text) < 20000) ;
            discout = +int.Parse(textBox21.Text);
            
            if (int.Parse(textBox23.Text) < 100000) ;
            discout = +int.Parse(textBox23.Text);
            if (int.Parse(textBox24.Text) < 30000) ;
            discout = +int.Parse(textBox24.Text);
            if (int.Parse(textBox25.Text) < 100000) ;
            discout = +int.Parse(textBox25.Text);
            if (int.Parse(textBox26.Text) < 30000) ;
            discout = +int.Parse(textBox26.Text);


        }
    }
}
