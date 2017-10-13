using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Ninjago
{
    class vehicule : Carte
    {
        string effet;

        public vehicule(int idcarte, string numero, string nom, string type, string effet) : base(idcarte, nom, numero, type)
        {
            this.Effet = effet;
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

        public string getvehicule(int id)
        {
            return ("Ce véhicule s'apelle : " + this.nom + " son effet :" + this.effet);
        }
    }
}
