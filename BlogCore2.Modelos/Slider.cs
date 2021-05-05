using System.ComponentModel.DataAnnotations;

namespace BlogCore2.Modelos
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio."), Display(Name = "Nombre del slider")]
        public string Nombre { get; set; }

        [Required, Display(Name = "Estado")]
        public bool Estado { get; set; }

        [DataType(DataType.ImageUrl), Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
    }
}
