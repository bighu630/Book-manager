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
    public partial class Form_学生 : Form
    {
        public string id;
        public Form_学生()
        {
            InitializeComponent();
        }

        private void Form_学生_Load(object sender, EventArgs e)
        {
            Dao uname = new Dao();
            uname.Connection();
            string sql = $"select user_name from user where user_id='{id}'";
            IDataReader reader = uname.ReadSql(sql);
            string name="";
            while (reader.Read())
            {
                name = reader[0].ToString();
            }
            Load_data();
        }
        private void Load_data()
        {
            dataGridView1.Rows.Clear();
            Dao load = new Dao();
            load.Connection();
            string sql = $"select book_id,book_name,start_time,end_time from record where user_id='{id}'";
            IDataReader reader = load.ReadSql(sql);
            string a0, a1, a2, a3;
            while(reader.Read())
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dao uptime = new Dao();
            uptime.Connection();
            string book_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = $"update record set end_time=DATE_ADD(end_time,INTERVAL 30 DAY) where book_id='{book_id}'";
            uptime.Updata(sql);
            Load_data();
        }

        private void button_还书_Click(object sender, EventArgs e)
        {

                Dao Return_book = new Dao();
                Return_book.Connection();
                string book_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string sqlAdd = $"update book set in_stark=in_stark+1 where book_id='{book_id}'";
                Return_book.Updata(sqlAdd);
                string sqlDel = $"delete from record where book_id='{book_id}'";
                Return_book.Updata(sqlDel);
                Load_data();
        }

        private void button_借书_Click(object sender, EventArgs e)
        {
            Form_借书 borrow = new Form_借书();
            borrow.id = id;
            borrow.Show();
        }

        private void button_刷新_Click(object sender, EventArgs e)
        {
            Load_data();
        }
    }
}
