using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjRodriggoMendesDosSantos.forms.classes
{
    class clsRodriggoMendesDosSantos_CNPJ
    {
        public int[] arrayAuxilio = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        public int[] arrayCNPJ = new int[14];
        public int[] arrayMultiplicacao = new int[13];
        public int digito1 = 0;
        public int digito2 = 0;

        public bool validaCNPJ(string CNPJ)
        {
            for (int i = 0; i < 14; i++)
            {
                arrayCNPJ[i] = int.Parse(CNPJ.Substring(i, 1));
            }

            for (int i = 0; i < 12; i++)
            {
                arrayMultiplicacao[i] = arrayCNPJ[i] * arrayAuxilio[i+1];
                digito1 += arrayMultiplicacao[i];
            }

            for (int i = 0; i < 13; i++)
            {
                arrayMultiplicacao[i] = arrayCNPJ[i] * arrayAuxilio[i];
                digito2 += arrayMultiplicacao[i];
            }

            if ((digito1 % 11) < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - (digito1 % 11);
            }

            if ((digito2 % 11) < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - (digito2 % 11);
            }

            if ((digito1 == arrayCNPJ[12]) && (digito2 == arrayCNPJ[13]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
