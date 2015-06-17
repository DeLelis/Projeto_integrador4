using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItens
{
    class Connection
    {
        public static OdbcConnection CreatConnection()
        {
            string driver = @"SQL Server";
            string servidor = @"EMYLLAINE";
            string baseDeDados = @"Itens";
            //string usuario = "sa";
            //string senha = "123";

            StringBuilder cnn = new StringBuilder();
            cnn.Append("driver=");
            cnn.Append(driver);
            cnn.Append(";server=");
            cnn.Append(servidor);
            cnn.Append(";database=");
            cnn.Append(baseDeDados);
            cnn.Append(";Trusted_Connection=yes");
            //cnn.Append(usuario);
            //cnn.Append(";pwd=");
            //cnn.Append(senha);

            OdbcConnection odbcCon = new OdbcConnection(cnn.ToString());
            odbcCon.Open();

            return odbcCon;
        }
    }
}
