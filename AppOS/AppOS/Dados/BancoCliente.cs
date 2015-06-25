using AppOS.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Dados
{
    class BancoCliente
    {
        public int addCliente(CCliente c)
        {
            string sql = @"INSERT INTO cliente (nome,telefone,cpf,email,endereco) VALUES ('" + c.nome + "', '" + c.telefone + "', '" + c.cpf + "', '" + c.email + "', '" + c.endereço + "')";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para alterar no banco de dados
        public int alterarCliente(CCliente c)
        {
            string sql = @"UPDATE cliente SET nome='" + c.nome + "', telefone='" + c.telefone + "',cpf='" + c.cpf + "', email='" + c.email + "', endereco='" + c.endereço + "' WHERE id_cliente=" + c.idcli;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para excluir no banco de dados
        public int excluirCliente(CCliente c)
        {
            string sql = @"DELETE FROM cliente WHERE id_cliente=" + c.idcli;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
    }
}
