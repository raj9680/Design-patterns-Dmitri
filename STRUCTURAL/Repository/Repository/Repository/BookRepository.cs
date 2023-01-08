using Repository.Entities;
using Repository.Repository.interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    public class BookRepository : IBookRepository
    {
        List<Book> Books = new List<Book>()
        {
            new Book() {BookId =1, BookName="Data Sructures"},
            new Book() {BookId =2, BookName="Operating System"},
            new Book() {BookId =3, BookName="Computer Network"},
            new Book() {BookId =4, BookName="TOC"}
        };

        public List<Book> Get()
        {
            return Books;
        }

        public Book Get(int Id)
        {
            Book book = new Book();
            if(Id != 0 && Id > 0)
            {
                book = Books.Where(x => x.BookId == Id).FirstOrDefault(); 
            }
            return book;
        }
    }
}
