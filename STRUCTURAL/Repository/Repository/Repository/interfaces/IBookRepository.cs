using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repository.interfaces
{
    public interface IBookRepository
    {
        List<Book> Get();
        Book Get(int Id);
    }
}
