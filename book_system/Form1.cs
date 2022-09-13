using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace book_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Dao Login = new Dao();
                Login.Connection();
                string sql = $"select pwd from user where user_id='{textbox_账号.Text}'";
                IDataReader pwd = Login.ReadSql(sql);
                while (pwd.Read())
                {
                    if (pwd[0].ToString() == textbox_密码.Text)
                    {
                        Form_学生 form_xs = new Form_学生();
                        form_xs.id = textbox_账号.Text;
                        form_xs.Show();
                    }
                    else
                    {
                        MessageBox.Show("账号/密码错误！");
                    }
                }
                Login.CloseSql();
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            Form_注册 fNew = new Form_注册();
            fNew.Show();
        }
    }
}
