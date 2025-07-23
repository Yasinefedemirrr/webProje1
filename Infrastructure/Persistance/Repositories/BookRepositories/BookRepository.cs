using Application.interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.BookRepositories
{
    public class BookRepository : IBookRepository
    {
        private readonly WebProjeContext _context;

        public BookRepository(WebProjeContext context)
        {
            _context = context;
        }

        public List<Book> GetLast5BooksWithAuthor()
        {
            return _context.Books
                .Include(x => x.Author)
                .OrderByDescending(x => x.CreatedDate)
                .Take(5)
                .ToList();
        }

        public List<Book> GetBooksWithAuthor()
        {
            return _context.Books
                .Include(x => x.Author)
                .OrderByDescending(x => x.Id)
                .ToList();
        }

        public Book GetBookDetailWithAuthor(int id)
        {
            return _context.Books
                .Include(x => x.Author)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
