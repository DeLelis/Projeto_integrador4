using AppOS.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Dados
{
    class BancoPecas
    {
        public int addPecas(CPecas p)        {
            string sql = @"INSERT INTO itens (nome,valor,descricao) VALUES ('" + p.nomepe + "', '" + p.valor + "', '" + p.descricao + "')";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para alterar no banco de dados
        public int alterarPecas(CPecas p)
        {
            string sql = @"UPDATE itens SET nome='" + p.nomepe + "', valor='" + p.valor + "', descricao='" + p.descricao + "' WHERE id_itens=" + p.iditem;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para excluir no banco de dados
        public int excluirPecas(CPecas p)
        {
            string sql = @"DELETE FROM itens WHERE id_itens=" + p.iditem;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
    }
}
