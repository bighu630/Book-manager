using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace book_system
{
    class Dao
    {
        MySqlConnection connect = new MySqlConnection();
        public MySqlConnection Connection()
        {
            string mysql = "server=39.103.230.97; port = 3306; user = bighu; password = hutendalao; database = hbut_book_system; ";
            connect =new MySqlConnection(mysql);
            connect.Open();
            return connect;
        }
        public MySqlDataReader ReadSql(string sql)
        {
            MySqlCommand com = new MySqlCommand(sql,connect);
            return com.ExecuteReader();
        }
        public int Updata(string sql)
        {
            int num = 0;
            MySqlCommand com = new MySqlCommand(sql, connect);
            num = com.ExecuteNonQuery();
            return num;
        }
    
        public void CloseSql()
        {
            connect.Close();
        }
    }
}
