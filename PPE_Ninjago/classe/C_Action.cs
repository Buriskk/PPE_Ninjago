using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Ninjago
{
    class Action : Carte
    {
        string effet;

        public Action(int idcarte, string numero, string nom, string type,string effet):base (idcarte,numero,nom,type)
        {
            this.effet = effet;
        }

        public string Effet
        {
            get
            {
                return effet;
            }

            set
            {
                effet = value;
            }
        }

        public string GetAction ()
        {
            return ("L'action : " + this.nom + this.effet);
        }

        
        }
    }

}
