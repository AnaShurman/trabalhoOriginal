using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho.dal
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"server=localhost;user id=maysa;database=tcc;persistsecurityinfo=False";
        }

        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
