using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Ninjago.classe
{
    class Plateau
    {
        int idPlateau;
        int formatP;

        public Plateau(int idPlateau, int formatP)
        {
            this.idPlateau = idPlateau;
            this.formatP = formatP;

        }

        public int IdPlateau
        {
            get
            {
                return idPlateau;
            }

            set
            {
                idPlateau = value;
            }
        }

        public int FormatP
        {
            get
            {
                return formatP;
            }

            set
            {
                formatP = value;
            }
        }
        public void poseCarte()
        {

        }
        public void combat()
        {

        }
        public void selctionCombat()
        {
            /* for (i = (case.caseJ-1); i < (case.caseJ+1); i++)
{
   for ( t = (case.caseI-1); t < (case.caseI+1); t++)
   {
    if ()
   }
}  */

        }
        public void retournerCarte()
        {

        }

        public void compteCarte()
        {

        }

        public void option()
        {

        }

    }
}
