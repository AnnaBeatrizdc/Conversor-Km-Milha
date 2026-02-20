using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_KM_Milhas
{
    class ConverterKMBLL
    {
        public static void validaDados(ConverteKM valor )
        {
            Erro.setErro(false);
            if (valor.getvalorMi().Length == 0)
            {
                Erro.setErro("O campo valor é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(valor.getvalorMi());
                }
                catch
                {
                    Erro.setErro("O campo Nota 1 deve ser numérico...");
                    return;
                }
                if (float.Parse(valor.getvalorMi()) <= 0)
                {
                    Erro.setErro("O campo Nota 1 deve ser maior que zero.");
                    return;
                }
            }
        }
    }
}
