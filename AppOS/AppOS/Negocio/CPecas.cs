using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Negocio
{
    class CPecas
    {
        private int _iditem;
        public int iditem
        {
            get
            {
                return this._iditem;
            }
            set
            {
                if (value != 0)
                {
                    this._iditem = value;
                }
            }
        }

        private string _nomepe;
        public string nomepe
        {
            get
            {
                return this._nomepe;
            }
            set
            {
                if (value != "")
                {
                    this._nomepe = value;
                }
            }
        }

        private string _valor;
        public string valor
        {
            get
            {
                return this._valor;
            }
            set
            {
                if (value != "")
                {
                    this._valor = value;
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
    }
}
