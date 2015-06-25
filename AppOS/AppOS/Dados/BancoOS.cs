using AppOS.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Dados
{
    class BancoOS
    {
        public int addOS(COS o)
        {
            string sql = @"INSERT INTO os (nomecli,telefonecli,cpfcli,emailcli,enderecocli,nomefun,telefonefun,datacri,datafinal,marca,modelo,descrica_os,itens,fotos,valor_os,statos) VALUES ('" + o.nomecli + "', '" + o.telefonecli + "', '" + o.cpfcli + "', '" + o.emailcli + "', '" + o.endereçocli + "','" + o.nomefun + "','" + o.telefonefun + "','" + o.datacri + "','" + o.datafinal + "','" + o.marca + "','" + o.modelo + "','" + o.descricao + "','" + o.itens + "','" + o.foto + "','" + o.valoros + "','" + o.statusos + "')";

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
        //Metodo para alterar no banco de dados
        public int alterarOS(COS o)
        {
            string sql = @"UPDATE os SET nomecli='" + o.nomecli + "', telefonecli='" + o.telefonecli + "',cpfcli='" + o.cpfcli + "', emailcli='" + o.emailcli + "', enderecocli='" + o.endereçocli + "', nomefun='" + o.nomefun + "', telefonefun='" + o.telefonefun + "', datacri='" + o.datacri + "', datafinal='" + o.datafinal + "', marca='" + o.marca + "', modelo='" + o.modelo + "', descrica_os='" + o.descricao + "', itens='" + o.itens + "', fotos='" + o.foto + "', valor_os='" + o.valoros + "', statos='" + o.statusos + "' WHERE id_os ="+ o.idos;

            SqlCommand comando = new SqlCommand(sql, ConnectionFactory.CreatConnection());
            return comando.ExecuteNonQuery();
        }
    }
}
