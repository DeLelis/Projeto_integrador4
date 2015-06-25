using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Negocio
{
    class COS
    {
        private int _idos;
        public int idos
        {
            get
            {
                return this._idos;
            }
            set
            {
                if (value != 0)
                {
                    this._idos = value;
                }
            }
        }

        private string _nomecli;
        public string nomecli
        {
            get
            {
                return this._nomecli;
            }
            set
            {
                if (value != "")
                {
                    this._nomecli = value;
                }
            }
        }

        private string _telefonecli;
        public string telefonecli
        {
            get
            {
                return this._telefonecli;
            }
            set
            {
                if (value != "")
                {
                    this._telefonecli = value;
                }
            }
        }

        private string _cpfcli;
        public string cpfcli
        {
            get
            {
                return this._cpfcli;
            }
            set
            {
                if (value != "")
                {
                    this._cpfcli = value;
                }
            }
        }

        private string _emailcli;
        public string emailcli
        {
            get
            {
                return this._emailcli;
            }
            set
            {
                if (value != "")
                {
                    this._emailcli = value;
                }
            }
        }

        private string _endereçocli;
        public string endereçocli
        {
            get
            {
                return this._endereçocli;
            }
            set
            {
                if (value != "")
                {
                    this._endereçocli = value;
                }
            }
        }
        private string _nomefun;
        public string nomefun
        {
            get
            {
                return this._nomefun;
            }
            set
            {
                if (value != "")
                {
                    this._nomefun = value;
                }
            }
        }

        private string _telefonefun;
        public string telefonefun
        {
            get
            {
                return this._telefonefun;
            }
            set
            {
                if (value != "")
                {
                    this._telefonefun = value;
                }
            }
        }
        private string _datacri;
        public string datacri
        {
            get
            {
                return this._datacri;
            }
            set
            {
                if (value != "")
                {
                    this._datacri = value;
                }
            }
        }

        private string _datafinal;
        public string datafinal
        {
            get
            {
                return this._datafinal;
            }
            set
            {
                if (value != "")
                {
                    this._datafinal = value;
                }
            }
        }
        private string _marca;
        public string marca
        {
            get
            {
                return this._marca;
            }
            set
            {
                if (value != "")
                {
                    this._marca = value;
                }
            }
        }
        private string _modelo;
        public string modelo
        {
            get
            {
                return this._modelo;
            }
            set
            {
                if (value != "")
                {
                    this._modelo = value;
                }
            }
        }
        private string _descricao;
        public string descricao
        {
            get
            {
                return this._descricao;
            }
            set
            {
                if (value != "")
                {
                    this._descricao = value;
                }
            }
        }
        private string _itens;
        public string itens
        {
            get
            {
                return this._itens;
            }
            set
            {
                if (value == "")
                {
                    this._itens = "null";
                }
                if (value != "")
                {
                    this._itens = value;
                }
            }
        }
        private string _foto;
        public string foto
        {
            get
            {
                return this._foto;
            }
            set
            {
                if (value == "")
                {
                    this._foto = "Sem imagem";
                }
                if (value != "")
                {
                    this._foto = value;
                }
            }
        }
        private string _valoros;
        public string valoros
        {
            get
            {
                return this._valoros;
            }
            set
            {
                if (value != "")
                {
                    this._valoros = value;
                }
            }
        }
        private string _statusos;
        public string statusos
        {
            get
            {
                return this._statusos;
            }
            set
            {
                if (value != "")
                {
                    this._statusos = value;
                }
            }
        }
        
    }
}
