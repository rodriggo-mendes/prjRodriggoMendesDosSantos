using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjRodriggoMendesDosSantos.forms.classes
{
    class clsRodriggoMendesDosSantos_CC
    {
        private int[] numeros = new int[16];
        private int result = 0;

        public bool verificacao(string numero)
        {
            for (int i = 0; i < 16; i++)
            {
                numeros[i] = int.Parse(numero.Substring(i, 1));

                if ((i+1) % 2 == 0)
                {
                    result += numeros[i] * 1;
                }

                else
                {
                    if (numeros[i] * 2 > 9)
                    {
                        result += (numeros[i] * 2) - 9;
                    }

                    else
                    {
                        result += numeros[i] * 2;
                    }
                }
            }

            if (result % 10 == 0)
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


   
