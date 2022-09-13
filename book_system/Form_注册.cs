using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_system
{
    public partial class Form_注册 : Form
    {
        private string NewId;
        public Form_注册()
        {
            InitializeComponent();
        }

        private void Form_注册_Load(object sender, EventArgs e)
        {
            MakeId();
        }
        private void MakeId()
        {
            List<string> listId = new List<string>();
            Dao id = new Dao();
            id.Connection();
            string sql = "select user_id from user";
            IDataReader reader = id.ReadSql(sql);
            while(reader.Read())
            {
                listId.Add(reader[0].ToString());
            }
            System.Random ran = new Random();
            NewId = ran.Next(10000, 99999).ToString();
            for (int i = 0; i < listId.Count(); i++)
            {
                if (listId[i]==NewId)
                {
                    NewId = ran.Next(10000, 99999).ToString();
                    continue;
                }
                break;
            }
            label1.Text = $"你的账号是:{NewId}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao sinup = new Dao();
            sinup.Connection();
            string sql = $"insert into user values('{NewId}','{textboxpor1.Text}','{textboxpor2.Text}')";
            sinup.Updata(sql);
            sinup.CloseSql();
            MessageBox.Show($"注册成功，你的ID是：{NewId}");
        }
    }
}
