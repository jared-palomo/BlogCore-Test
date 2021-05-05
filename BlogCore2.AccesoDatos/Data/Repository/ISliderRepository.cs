using BlogCore2.Modelos;

namespace BlogCore2.AccesoDatos.Data.Repository
{
    public interface ISliderRepository : IRepository<Slider>
    {
        void Update(Slider slider);
    }
}
