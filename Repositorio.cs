using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{   //Classe responsavel por toda a transação com o banco de dados
    class Repositorio
    {   //Metodo para adicionar no banco de dados
        public int addFuncionario(Funcionario f)
        {
            string sql = @"INSERT INTO funcionario (nome,telefone,cpf,email,endereco) VALUES ('" + f.nome + "', '" + f.telefone + "', '" + f.cpf + "', '" + f.email + "', '" + f.endereço + "')";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para alterar no banco de dados
        public int alterarFuncionario(Funcionario f)
        {
            string sql = @"UPDATE funcionario SET nome='" + f.nome + "', telefone='" + f.telefone + "',cpf='" + f.cpf + "', email='" + f.email + "', endereco='" + f.endereço + "' WHERE id_funcionario=" + f.idfun;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para excluir no banco de dados
        public int excluirFuncionario(Funcionario f)
        {
            string sql = @"DELETE FROM funcionario WHERE id_funcionario=" + f.idfun;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
    }
}
