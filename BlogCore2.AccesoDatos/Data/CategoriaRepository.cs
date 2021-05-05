using BlogCore2.AccesoDatos.Data.Repository;
using BlogCore2.Modelos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace BlogCore2.AccesoDatos.Data
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            return _db.Categoria.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.Id.ToString()
            });
        }

        public void Update(Categoria categoria)
        {
            var objetoDesdeDb = _db.Categoria.FirstOrDefault(s => s.Id == categoria.Id);
            objetoDesdeDb.Nombre = categoria.Nombre;
            objetoDesdeDb.Orden = categoria.Orden;

            _db.SaveChanges();
        }
    }
}
