using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformatico.Models
{
    public class Localidad
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }= string.Empty;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
