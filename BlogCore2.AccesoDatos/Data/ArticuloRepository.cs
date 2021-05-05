using BlogCore2.AccesoDatos.Data.Repository;
using BlogCore2.Modelos;
using System.Linq;

namespace BlogCore2.AccesoDatos.Data
{
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
        private readonly ApplicationDbContext _db;
        public ArticuloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Articulo articulo)
        {
            var objetoDesdeDb = _db.Articulo.FirstOrDefault(s => s.Id == articulo.Id);
            objetoDesdeDb.Nombre = articulo.Nombre;
            objetoDesdeDb.Descripcion = articulo.Descripcion;
            objetoDesdeDb.UrlImagen = articulo.UrlImagen;
            objetoDesdeDb.CategoriaId = articulo.CategoriaId;

            //El guardado será desde el controller
            //_db.SaveChanges();
        }
    }
}
