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

        int salary = 0;
        int vat = 0;
        int salaryvat = 0;
        int total = 0;
        int discount = 0;
        int pay = 0;


        //ลองโค้ดเคลี่อนย้าย

        int mov;
        int movX;
        int movY;




        public object MyTabControl { get; private set; }
        public object FormWindowStat { get; private set; }

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

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g2;
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g3;
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g1;
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g3;
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g2;
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g4;
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g5;
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = g4;
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g6;
            panel4.Height = button8.Height;
            panel4.Top = button8.Top;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = g5;
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

            discount = 0;
            int baby = 0;
            int pikan = 0;
            int dadmom = 0;
            if (radioButton1.Checked)
            {
                discount += 60000;

            }
            if (radioButton3.Checked)
            {
                discount += 130000;
            }
            if (radioButton2.Checked)
            {
                discount += 60000;
            }
            if (radioButton4.Checked)
            {
                pikan = 60000 * (int)numericUpDown1.Value;
                discount += pikan;
            }
            if (radioButton5.Checked)
                dadmom = 30000 * (int)numericUpDown3.Value;
            discount += dadmom;

            if (radioButton6.Checked)
                discount+=int.Parse(textBox3.Text);
            else
                discount +=60000;

            

            if (radioButton8.Checked)
                baby = 60000 * (int)numericUpDown2.Value - 30000 + int.Parse(textBox3.Text);
                discount += baby;
            if (radioButton9.Checked)
                baby = 30000 * (int)numericUpDown2.Value + int.Parse(textBox3.Text) ;
                discount += baby;
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //กลุ่มที่2

            if (int.Parse(textBox4.Text) <= 9000)
                discount +=int.Parse(textBox4.Text);
            else
                discount += 9000;


            if (int.Parse(textBox5.Text) <= 100000) 
                discount +=int.Parse(textBox5.Text);
            else
                discount += 10000;

            if (int.Parse(textBox6.Text)  <= 15000) 
                discount +=int.Parse(textBox6.Text);
            else
                discount += 15000;

            if (int.Parse(textBox7.Text) <= 10000) 
                discount +=int.Parse(textBox7.Text);
            else
                discount += 10000;

            if (int.Parse(textBox8.Text) <= 200000) 
                discount +=int.Parse(textBox8.Text);
            else
                discount += 200000;

            if (int.Parse(textBox19.Text) <= 15 / 100 * salary)
                discount += int.Parse(textBox9.Text);
            else if (int.Parse(textBox19.Text) < 500000)
                discount += int.Parse(textBox9.Text);
            else
                discount += 500000;


            if (int.Parse(textBox10.Text) <= 13200)
                discount = +int.Parse(textBox10.Text);
            else
                discount += 13200;
            
            
            if (int.Parse(LTF11.Text) <= 15 / 100 * salary) 
                discount +=int.Parse(LTF11.Text);
            else if (int.Parse(LTF11.Text) <= 500000)
                discount += int.Parse(LTF11.Text);
            else
                discount += 500000;


            if (int.Parse(RMF12.Text) <= 15 / 100 * salary) 
                discount +=int.Parse(RMF12.Text);
            else if (int.Parse(RMF12.Text) <= 500000)
                discount += int.Parse(RMF12.Text);
            else
                discount += 500000;


            //กลุ่มที่3

            if (int.Parse(textBox13.Text) <= 100000)
                discount += int.Parse(textBox13.Text);
            else
                discount += 100000;
            if (int.Parse(textBox14.Text) <= 3000000)
                discount += int.Parse(textBox14.Text)*4/100;
            else
                discount += 4 / 100 * 3000000;

            if (int.Parse(textBox15.Text) <= 200000)
                discount += int.Parse(textBox15.Text);
            else
                discount += 200000;

            






            //กลุ่มที่5

            if (int.Parse(textBox20.Text) <= 15000)
                discount += int.Parse(textBox20.Text);
            else
                discount += 15000;

            if (int.Parse(textBox21.Text) <= 20000) 
                discount += +int.Parse(textBox21.Text);
            else
                discount += 20000;

            if (int.Parse(textBox23.Text) <= 100000) 
                discount +=int.Parse(textBox23.Text);
            else
                discount += 100000;

            if (int.Parse(textBox24.Text) <= 30000) 
                discount +=int.Parse(textBox24.Text);
            else
                discount += 30000;

            if (int.Parse(textBox25.Text) <= 100000) 
                discount +=int.Parse(textBox25.Text);
            else
                discount += 100000;

            if (int.Parse(textBox26.Text) <= 30000) 
                discount +=int.Parse(textBox26.Text);
            else
                discount += 30000;



            
            //ภาษีเงินได้

            salary = int.Parse(textBox2.Text) * 12;
            pay = int.Parse(textBox22.Text) * 12;

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
                vat = salary * 25 / 100;
            }
            else if (salary > 750000)
            {
                vat = salary * 20 / 100;
            }
            else if (salary > 500000)
            {
                vat = salary * 15 / 100;
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


            salaryvat = salary - vat;
            textBox28.Text = salaryvat.ToString("#,##.00");
            total = salary- discount;
            total = total - pay;
            

            //กลุ่มที่4
            if (int.Parse(textBox16.Text) <= 0.1*total)
                discount += int.Parse(textBox19.Text);
            else
                discount += 2* int.Parse(textBox19.Text);

            if (int.Parse(textBox17.Text) <= 0.1 * total)
                discount += int.Parse(textBox16.Text) * 2;
            else
                discount += 2 * int.Parse(textBox17.Text);

            if (int.Parse(textBox18.Text) <= 0.1 * total)
                discount += int.Parse(textBox18.Text) ;
            else
                discount += int.Parse(textBox18.Text);

            if (int.Parse(textBox19.Text) <=10000)
                discount += int.Parse(textBox19.Text);
            else
                discount += 10000;

            if (discount < 0)
                discount = 0;

            textBox27.Text = total.ToString("#,##.00");
            textBox29.Text = discount.ToString("#,##.00");
            textBox28.Text = salaryvat.ToString("#,##.00");
            textBox11.Text = vat.ToString("#,##.00");

        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
