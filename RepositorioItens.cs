using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class RepositorioItens
    { //esta classe será responsável por a transação das as informações com o banco

        class Repositorio
        {   //metodo para adicionar informações no banco de dados
            public int addItens(itens i)
            {
                string sql = @"INSERT INTO intens (nome,descricao,valor) VALUES ('" + i.nome + "', '" + i.descricao + "', '" + i.valor + "')";

                SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
                return comando.ExecuteNonQuery();
            }
        }
    } 
}
