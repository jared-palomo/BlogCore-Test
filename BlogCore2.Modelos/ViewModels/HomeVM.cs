using System.Collections.Generic;

namespace BlogCore2.Modelos.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Slider { get; set; }

        public IEnumerable<Articulo> Articulo { get; set; }
    }
}
