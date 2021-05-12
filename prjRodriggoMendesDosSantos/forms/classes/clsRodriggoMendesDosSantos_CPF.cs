using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjRodriggoMendesDosSantos.forms.classes
{
    class clsRodriggoMendesDosSantos_CPF
    {
        public int auxValidacao1 = 10;
        public int auxValidacao2 = 11;
        public int[] arrayCPF = new int[11];
        public int digito1;
        public int digito2;
        public int auxDigito2;

        public bool validaCPF(string CPF)
        {
            for (int i = 0; i < 11; i++)
            {
                arrayCPF[i] = int.Parse(CPF.Substring(i, 1));
            }

            for (int i = 0; i < 9; i++)
            {
                digito1 = digito1 + arrayCPF[i] * auxValidacao1;
                digito2 = digito2 + arrayCPF[i] * auxValidacao2;
                auxValidacao1--;
                auxValidacao2--;
            }

            digito1 = 11 - (digito1 % 11);
            auxDigito2 = digito1 * auxValidacao2;
            digito2 = digito2 + auxDigito2;
            digito2 = 11 - (digito2 % 11);

            if ((digito1 == arrayCPF[9]) && (digito2 == arrayCPF[10]))
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
