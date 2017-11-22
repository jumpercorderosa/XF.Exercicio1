using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Models
{
    class Dados
    {
        string email;
        bool flag_email;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public bool FlagEmail
        {

            get
            {
                return flag_email;
            }

            set
            {
                flag_email = value;
            }
        }
    }

}

