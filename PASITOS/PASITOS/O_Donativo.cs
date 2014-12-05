using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PASITOS
{
    class O_Donativo
    {
        
        public int ID_Donante { get; set; }
        public int ID_Tipo_Donativo { get; set; }
        public string Fecha_inicio { get; set; }
        public string Periodicidad { get; set; }
        public float Don_monetario { get; set; }
        public string Forma_pago { get; set; }
        public int ID_beneficiario { get; set; }
        public string UsoDon { get; set; }
        public string Estado { get; set; }

    }
}
