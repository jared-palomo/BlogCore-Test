using BlogCore2.Modelos;

namespace BlogCore2.AccesoDatos.Data.Repository
{
    public interface IArticuloRepository : IRepository<Articulo>
    {
        void Update(Articulo articulo);
    }
}
