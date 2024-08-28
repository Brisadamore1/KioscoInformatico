using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformatico.Models
{
    public class DetalleCompra
    {
        public int Id { get; set; }
        public int ProductosId { get; set; }
        public Producto? Producto { get; set; }
        public decimal PrecioUnitario { get; set; } = decimal.Zero;
        public int Cantidad { get; set; } = 0;
        public int CompraId { get; set; }
    }
}
