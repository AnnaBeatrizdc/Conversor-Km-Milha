using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_KM_Milhas
{
    class ConverterMilhaBLL
    {
        public static void validaDados(ConverteMilha valor)
        {
            Erro.setErro(false);
            if (valor.getvalorKm().Length == 0)
            {
                Erro.setErro("O campo valor é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(valor.getvalorKm());
                }
                catch
                {
                    Erro.setErro("O campo Nota 1 deve ser numérico...");
                    return;
                }
                if (float.Parse(valor.getvalorKm()) <= 0)
                {
                    Erro.setErro("O campo Nota 1 deve ser maior que zero.");
                    return;
                }
            }
        }
    }
}
