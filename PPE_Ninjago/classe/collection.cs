using PPE3_Ninjago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Ninjago.classe
{
    class collection
    {
        string Nom;
        DateTime datecreation;
        List<Carte> colleCartes;

        public void recupTest()
        {
            /*adfhjvyjuhfvkj*/
        }

        public collection(string nom, DateTime datecreation, List<Carte> collection)
        {
            Nom = nom;
            this.datecreation = datecreation;
            this.colleCartes = new List<Carte>();
        }


       
    }
}
