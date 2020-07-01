using infrastructure.Data;
using Infrastructure.IRepository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    public class UnitOfWOrk : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IProductRepository Products { get; private set; }

        public UnitOfWOrk(ApplicationDbContext context)
        {
            _context = context;
            Products = new ProductRepository(context);
        }

        public async Task CompleteAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
