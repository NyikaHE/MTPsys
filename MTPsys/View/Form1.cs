using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTPsys
{
    public partial class Form1 : Form
    {
        Point mouseOff;//鼠标移动位置变量    
        bool leftFlag;//标签是否为左键    
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.ForeColor = '';
            textBox2.Visible = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked&& textBox1.Text!=""&& textBox2.Text!="")
            {//用户登陆，验证是否填入了用户名和密码
                DataBase db = new DataBase();
                if (db.GetUser(textBox1.Text, textBox2.Text))
                {
                    this.Close();
                    new Main(true).Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！！");
                }

            }
            else if(textBox1.Text != "")
            {
                //游客登陆
                this.Close();
                new Main(false).Show();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值    
                leftFlag = true;
                //点击左键按下时标注为true;    
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                if (leftFlag)
                {
                    Point mouseSet = Control.MousePosition;
                    mouseSet.Offset(mouseOff.X, mouseOff.Y);
                    //设置移动后的位置    
                    Location = mouseSet;
                }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;    
            }
        }
    }
}
