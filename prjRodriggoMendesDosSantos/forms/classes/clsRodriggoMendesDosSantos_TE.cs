using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjRodriggoMendesDosSantos.forms.classes
{
    class clsRodriggoMendesDosSantos_TE
    {
        #region Variáveis
        public string numero { get; set; }
        public string textoRetorno { get; set; }
        public string pedaco = "";
        public int alg, result, resto, dv1, dv2, y1, y2;
        public bool controle;
        #endregion

        #region Função "Gerar"
        public void calcular(string A)
        {
            controle = true;

            #region Geração dos Dígitos
            for (int i = 0; i < 8; i++)
            {
                pedaco = A.Substring(i, 1);
                alg = int.Parse(pedaco);

                if (i == 0)
                {
                    result = alg * 2;
                }

                if (i == 1)
                {
                    result = alg * 9;
                }

                if (i == 2)
                {
                    result = alg * 8;
                }

                if (i == 3)
                {
                    result = alg * 7;
                }

                if (i == 4)
                {
                    result = alg * 6;
                }

                if (i == 5)
                {
                    result = alg * 5;
                }

                if (i == 6)
                {
                    result = alg * 4;
                }

                if (i == 7)
                {
                    result = alg * 3;
                }

                if (i == 8)
                {
                    result = alg * 2;
                }
            }
            #endregion

            #region Cálculo y1 e y2
            pedaco = A.Substring(9, 1);
            y1 = int.Parse(pedaco);

            pedaco = A.Substring(10, 1);
            y2 = int.Parse(pedaco);
            #endregion

            #region Dígito 1
            resto = result % 11;

            if (resto == 1)
            {
                dv1 = 0;
            }

            if (resto == 0)
            {
                if (y1 == 1 | y1 == 2 | y2 == 1 | y2 == 2)
                {
                    dv1 = 1;
                }

                dv1 = 0;
            }

            else
            {
                dv1 = 11 - resto;
            }
            #endregion

            #region Dígito 2

            resto = (((y1 * 4) + (y2 * 3) + (dv1 * 2)) % 11);

            if (resto == 1)
            {
                dv2 = 0;
            }

            else
            {
                if (resto == 0)
                {
                    if (y1 == 1 | y1 == 2 | y2 == 1 | y2 == 2)
                    {
                        dv2 = 1;
                    }
                }

                else
                {
                    dv2 = 11 - resto;
                }
            }

            textoRetorno = "Os dígitos do seu título de eleitor são, respectivamente, " + dv1.ToString() + " e " + dv2.ToString();
            #endregion
        }
        #endregion
    }
}
