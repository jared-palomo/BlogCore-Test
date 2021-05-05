using System.ComponentModel.DataAnnotations;

namespace BlogCore2.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio."),
         Display(Name = "Nombre Categoría")]
        public string Nombre { get; set; }

        [Required, Display(Name = "Orden de visualización")]
        public int Orden { get; set; }
    }
}
