using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_KM_Milhas
{
    class ConverteKM
    {
        private String valorMilha;

        public void setvalorMi(String _valorMilha) { valorMilha = _valorMilha; }
        public String getvalorMi() { return valorMilha; }

        public String getConverteKM()
        {
            return ((float.Parse(valorMilha) * 1.609344)).ToString();
        }
    }
}
