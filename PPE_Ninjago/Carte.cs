using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Ninjago
{
    abstract class Carte
    {
        int idcarte;
        string numero;
        protected string nom;
        string type;

        public  Carte(int idcarte, string numero, string nom, string type)
        {
            this.idcarte = idcarte;
            this.numero = numero;
            this.nom = nom;
            this.type = type;

        }

        //abstract public string Afficher ()
        //{
        //    return ("id = " + this.idcarte + " ,numéro =" + this.numero + " , nom=" + this.numero + " , type=" + this.type);
        //}
        //public void setCarte()
        //{

        //}
    }
   
}
