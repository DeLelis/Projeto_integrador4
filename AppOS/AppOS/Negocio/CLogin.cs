using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOS.Negocio
{
    class CLogin
    {
        private int _idlogin;
        public int idfun
        {
            get
            {
                return this._idlogin;
            }
            set
            {
                if (value != 0)
                {
                    this._idlogin = value;
                }
            }
        }


        private string _login;
        public string login
        {
            get
            {
                return this._login;
            }
            set
            {
                if (value != "")
                {
                    this._login = value;
                }
            }
        }


        private string _senha;
        public string senha
        {
            get
            {
                return this._senha;
            }
            set
            {
                if (value != "")
                {
                    this._senha = value;
                }
            }
        }
    }
}
