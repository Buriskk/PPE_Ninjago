using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Ninjago.classe
{
    class Case
    {
        int caseI;
        int CaseJ;

        public Case(int caseI, int caseJ)
        {
            this.caseI = caseI;
            CaseJ = caseJ;
        }

        public int CaseI
        {
            get
            {
                return caseI;
            }

            set
            {
                caseI = value;
            }
        }

        public int CaseJ1
        {
            get
            {
                return CaseJ;
            }

            set
            {
                CaseJ = value;
            }
        }
    }
    }

