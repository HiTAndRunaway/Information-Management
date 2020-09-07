using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=yzq;Integrated Security=True");
          conn.Open();
            SqlCommand cmd = new SqlCommand("select * from student where sno='" + textBox1.Text.Trim()+"'and postcode='"+textBox2.Text.Trim()+"'", conn);
            SqlDataReader sdr = cmd.ExecuteReader(); 
            sdr.Read(); 
             if (sdr.HasRows)  
             {
                 MessageBox.Show("登陆成功", "提示?"); 
                 Form2 form=new Form2();
                 form.Show();
                 this.Hide();
             }
             else
             {
             MessageBox.Show("提示：学生用户名或密码错误!","警告");
                 conn.Close();
             }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        }
    }

