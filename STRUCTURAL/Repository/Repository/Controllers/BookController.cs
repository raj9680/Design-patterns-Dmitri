using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Repository.interfaces;
using System.Collections.Generic;

namespace Repository.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookRepository.Get();
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookRepository.Get(id);
        }
    }
}
