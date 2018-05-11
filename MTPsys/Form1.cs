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
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！！");
                }

            }
            else if(textBox1.Text != "")
            {
                //游客登陆
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
