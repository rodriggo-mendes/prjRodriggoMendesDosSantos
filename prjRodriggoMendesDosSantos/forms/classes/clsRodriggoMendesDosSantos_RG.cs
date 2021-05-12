using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjRodriggoMendesDosSantos.forms.classes
{
    class clsRodriggoMendesDosSantos_RG
    {
        public int[,] numerosVerif = new int[3, 8];
        public int soma = 0;
        public int digito = 0;

        public bool verificaRG(string valRG)
        {
            for (int i = 0; i < 8; i++)
            {
                numerosVerif[0, i] = int.Parse(valRG.Substring(i, 1));
            }

            numerosVerif[1, 0] = 2;
            numerosVerif[1, 1] = 3;
            numerosVerif[1, 2] = 4;
            numerosVerif[1, 3] = 5;
            numerosVerif[1, 4] = 6;
            numerosVerif[1, 5] = 7;
            numerosVerif[1, 6] = 8;
            numerosVerif[1, 7] = 9;

            for (int i = 0; i < 8; i++)
            {
                numerosVerif[2, i] = numerosVerif[0, i] * numerosVerif[1, i];
            }

            for (int i = 0; i < 8; i++)
            {
                soma += numerosVerif[2, i];
            }

            digito = 11 - (soma % 11);

            if (int.Parse(valRG.Substring(8, 1)) == digito)
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
