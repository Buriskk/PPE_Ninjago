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

       
    }
}
