using KioscoInformatico.Enum;
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
        public FormaDePagoEnum FormaPago { get; set; } = FormaDePagoEnum.Efectivo;
        [Required]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Iva { get; set; } = decimal.Zero;
        public decimal Total { get; set; } = decimal.Zero;
    }
}
