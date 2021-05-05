using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore2.Modelos
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage="El Nombre es obligatorio.")]
        public string Nombre { get; set; }

        public string Direccion { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria.")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El Pais es obligatorio.")]
        public string Pais { get; set; }
    }
}
