using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformatico.Enum
{
    internal class FormaDePagoEnum
    {
        public int Efectivo { get; set; }
        public int Credito { get; set; }
        public int Debito { get; set; }
        public int Trasferencia { get; set; }
        public FormaDePagoEnum() 
        {
            Efectivo = 1;
            Credito = 2;
            Debito = 3;
            Trasferencia = 4;
        }
    }
}
