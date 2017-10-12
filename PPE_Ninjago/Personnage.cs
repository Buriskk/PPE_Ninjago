using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Ninjago
{
    class Personnage : Carte
    {
        int Att;
        int Def;
        int Vitt;
        int Force;

        public int Att1
        {
            get
            {
                return Att;
            }

            set
            {
                Att = value;
            }
        }

        public int Def1
        {
            get
            {
                return Def;
            }

            set
            {
                Def = value;
            }
        }

        public int Vitt1
        {
            get
            {
                return Vitt;
            }

            set
            {
                Vitt = value;
            }
        }

        public int Force1
        {
            get
            {
                return Force;
            }

            set
            {
                Force = value;
            }
        }

        public Personnage(int idcarte, string numero, string nom, string type, int att, int def, int vitt, int force):base(idcarte,nom,numero,type)
        {
            this.Att = att;
            this.Def = def;
            this.Vitt = vitt;
            this.Force = force;
        }
    }

}
