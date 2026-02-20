using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_KM_Milhas
{
    class ConverteMilha
    {
        private String valorKm;

        public void setvalorKm(String _valorKm) { valorKm = _valorKm; }
        public String getvalorKm() { return valorKm; }

        public String getConverteMilha()
        {
            return ((float.Parse(valorKm) / 1.609344)).ToString();
        }
    }
}
