using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformatico.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }=string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefonos { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public int? LocalidadId { get; set; }
        public Localidad? Localidad { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
