using KioscoInformatico.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformatico.Models
{
    public class Compra
    {
        public int ID { get; set; }
        public FormaDePagoEnum FormaDePago { get; set; }
        public int Iva { get; set; }
        public int Total { get; set; }
        public DateTime Fecha { get; set; }
        public int? ProveedorID { get; set; }
        public Proveedor? Proveedor { get; set; }
    }
}
