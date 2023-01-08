using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.interfaces
{
    public interface IBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
}
