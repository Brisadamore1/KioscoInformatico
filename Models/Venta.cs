using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformatico.Models
{
    public class Venta
    {
        public int Id { get; set; }
        [Required]
        public string FormaPago { get; set; } = string.Empty;
        public decimal Iva { get; set; } = decimal.Zero;
        public decimal Total { get; set; } = decimal.Zero;
    }
}
