using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjRodriggoMendesDosSantos.forms.classes
{
    class clsRodriggoMendesDosSantos_PISPASEP
    {
        #region Variáveis

        public string textoOBS { get; set; }
        string pedaço = "", numeroPISPASEP = "";
        int algarismo, resultado, digito;

        #endregion

        #region Função de Geração de Dígito

        public void gerarDigito(string valPISPASEP)
        {
            numeroPISPASEP = valPISPASEP;
            valPISPASEP = valPISPASEP.Replace("-", "").Replace(".", "");

            #region Cálculo do Dígito

            for (int i = 0; i < 10; i++)
            {
                pedaço = valPISPASEP.Substring(i, 1);
                algarismo = int.Parse(pedaço);

                if (i == 0 | i == 8)
                {
                    resultado += algarismo * 3;
                }

                if (i == 1 | i == 9)
                {
                    resultado += algarismo * 2;
                }

                if (i == 2)
                {
                    resultado += algarismo * 9;
                }

                if (i == 3)
                {
                    resultado += algarismo * 8;
                }

                if (i == 4)
                {
                    resultado += algarismo * 7;
                }

                if (i == 5)
                {
                    resultado += algarismo * 6;
                }

                if (i == 6)
                {
                    resultado += algarismo * 5;
                }

                if (i == 7)
                {
                    resultado += algarismo * 4;
                }

            }

            #endregion

            #region Dígito Final

            digito = 11 - (resultado % 11);
            if (digito == 11 | digito == 10)
            {
                digito = 0; ;
            }
            #endregion

            textoOBS = "O PIS/PASEP com o dígito é: \n" + numeroPISPASEP + "-" + digito.ToString(); ;

        }

        #endregion
    }
}
