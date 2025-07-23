using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.interfaces
{
    public interface IBookRepository
    {
        List<Book> GetLast5BooksWithAuthor();
        List<Book> GetBooksWithAuthor();
        Book GetBookDetailWithAuthor(int id);
    }
}
