using AppOS.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Dados
{
    class BancoLogin
    {
        public int addLogin(CLogin l)
        {
            string sql = @"INSERT INTO login (login1,senha) VALUES ('" + l.login + "', '" + l.senha + "')";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
    }
}
