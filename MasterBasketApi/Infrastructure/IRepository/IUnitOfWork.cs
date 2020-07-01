using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        Task CompleteAsync();
    }
}
