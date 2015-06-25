using AppOS.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Dados
{
    class BancoFuncionario
    {

        public int addFuncionario(CFuncionario f)
        {
            string sql = @"INSERT INTO funcionario (nome,telefone,cpf,email,endereco) VALUES ('" + f.nome + "', '" + f.telefone + "', '" + f.cpf + "', '" + f.email + "', '" + f.endereço + "')";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para alterar no banco de dados
        public int alterarFuncionario(CFuncionario f)
        {
            string sql = @"UPDATE funcionario SET nome='" + f.nome + "', telefone='" + f.telefone + "',cpf='" + f.cpf + "', email='" + f.email + "', endereco='" + f.endereço + "' WHERE id_funcionario=" + f.idfun;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para excluir no banco de dados
        public int excluirFuncionario(CFuncionario f)
        {
            string sql = @"DELETE FROM funcionario WHERE id_funcionario=" + f.idfun;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
    }
}
