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
    public partial class Form_借书 : Form
    {
        public string id;
        public Form_借书()
        {
            InitializeComponent();
        }
        private void Form_借书_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        private void button_查询_Click(object sender, EventArgs e)      //更新数据显示为所查到的内容
        {
            Load_data();
        }
        private void Load_data()
        {
            Dao load = new Dao();
            load.Connection();          //与数据库建立连接
            string sql;
            if (textboxpor_查询.Text != "")               //如果查询框不为空则显示搜索到的内容
            {
                sql = $"select book_id,book_name,author,in_stark from book where book_name REGEXP '{textboxpor_查询.Text}' or author REGEXP '{textboxpor_查询.Text}'";
            }
            else       //如果为空则显示全部
            {
                sql = "select book_id,book_name,author,in_stark from book";
            }
            IDataReader reader = load.ReadSql(sql);
            dataGridView1.Rows.Clear();
            string a0, a1, a2, a3;
            while (reader.Read())           //读取数据到dataGridView1中
            {
                a0 = reader[0].ToString();
                a1 = reader[1].ToString();
                a2 = reader[2].ToString();
                a3 = reader[3].ToString();
                string[] table = { a0, a1, a2, a3 };
                dataGridView1.Rows.Add(table);
            }
            load.CloseSql();
        }

        private void button_借书_Click(object sender, EventArgs e)
        {
            if (textboxpor_借书.Text == "")       //如果借书框为空直接退出
            {
                return;
            }
            Dao borrow = new Dao();
            borrow.Connection();
            string sqlBookStock = $"select in_stark,book_name from book where book_id='{textboxpor_借书.Text}'";
            IDataReader readStock = borrow.ReadSql(sqlBookStock);
            if (!readStock.Read())              //没有查到
            {
                MessageBox.Show("查无此书！");
            }
            else if (readStock[0].ToString() == "0")                //没有库存
            {
                MessageBox.Show("此书已被全部借出！");
            }
            else
            {
                string bname = readStock[1].ToString();
                borrow.CloseSql();          //重新连接数据库
                borrow.Connection();
                string sql = $"select count(*) from record where book_id='{textboxpor_借书.Text}'";
                IDataReader read = borrow.ReadSql(sql);
                while (read.Read())
                {
                    if (read[0].ToString() != "0")
                    {
                        MessageBox.Show("你已借阅此书，不可再借");
                        return;
                    }
                }
                
                borrow.CloseSql();          //重新连接数据库
                borrow.Connection();
                try
                {
                    string sqlAdd = $"update book set in_stark=in_stark-1 where book_id='{textboxpor_借书.Text}'";
                    borrow.Updata(sqlAdd);
                    string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string end_time = DateTime.Now.AddDays(30).ToString("yyyy-MM-dd HH:mm:ss");
                    string sqlTime = $"insert into record values('{id}','{textboxpor_借书.Text}','{bname}','{now}','{end_time}')";
                    borrow.Updata(sqlTime);
                    MessageBox.Show("借书成功，记得刷新");
                    Load_data();
                }
                catch
                {
                    MessageBox.Show("借书失败");
                }
            }
            borrow.CloseSql();
        }
    }
}
