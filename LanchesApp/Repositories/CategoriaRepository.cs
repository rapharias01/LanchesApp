using LanchesApp.Context;
using LanchesApp.Models;
using LanchesApp.Repositories.Interfaces;

namespace LanchesApp.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context; 
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
