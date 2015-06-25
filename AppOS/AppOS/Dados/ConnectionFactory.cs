using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Dados
{
    class ConnectionFactory
    {
        public static SqlConnection CreatConnection()
        {
            //string driver = @"SQL Server";
            string servidor = @"SERGIO_PC";
            string baseDeDados = @"AppOS";
            //string usuario = "sa";
            //string senha = "sa";

            StringBuilder cnn = new StringBuilder();
            //cnn.Append("driver=");
            //cnn.Append(driver);
            cnn.Append(";server=");
            cnn.Append(servidor);
            cnn.Append(";database=");
            cnn.Append(baseDeDados);
            cnn.Append(";Trusted_Connection=yes");
            //cnn.Append(usuario);
            //cnn.Append(";pwd=");
            //cnn.Append(senha);

            SqlConnection SqlCon = new SqlConnection(cnn.ToString());
            SqlCon.Open();

            return SqlCon;
        }
    }
}
