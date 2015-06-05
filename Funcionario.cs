using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{   //Classe modelo
    class Funcionario
    {

        private int _idfun;
        public int idfun
        {
            get
            {
                return this._idfun;
            }
            set
            {
                if (value != 0)
                {
                    this._idfun = value;
                }
            }
        }

        private string _nome;
        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                if (value != "")
                {
                    this._nome = value;
                }
            }
        }

        private string _telefone;
        public string telefone
        {
            get
            {
                return this._telefone;
            }
            set
            {
                if (value != "")
                {
                    this._telefone = value;
                }
            }
        }

        private string _cpf;
        public string cpf
        {
            get
            {
                return this._cpf;
            }
            set
            {
                if (value != "")
                {
                    this._cpf = value;
                }
            }
        }

        private string _email;
        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                if (value != "")
                {
                    this._email = value;
                }
            }
        }

        private string _endereço;
        public string endereço
        {
            get 
            {
                return this._endereço;
            }
            set
            {
                if (value != "")
                {
                    this._endereço = value;
                }
            }
        }
    }
}
