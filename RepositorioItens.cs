using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace CadastroItens
{
    class RepositorioItens
    {
        public int AddItens(Itens i)
        {
            string sql = @"INSERT INTO itens (Nome, Descricao, Valor) VALUES (?, ?, ?)";

            OdbcCommand cmd = new OdbcCommand(sql, Connection.CreatConnection());

            cmd.Parameters.AddWithValue("@Nome", i.Nome);
            cmd.Parameters.AddWithValue("@Descricao", i.Descricao);
            cmd.Parameters.AddWithValue("@Valor", i.Valor);
            
            return cmd.ExecuteNonQuery();

        }

    }
}
