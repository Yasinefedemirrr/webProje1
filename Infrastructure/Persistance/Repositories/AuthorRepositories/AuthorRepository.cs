using Application.interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.AuthorRepositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly WebProjeContext _context;

        public AuthorRepository(WebProjeContext context)
        {
            _context = context;
        }

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthorWithBooks(int id)
        {
            return _context.Authors
                .Include(a => a.Books)
                .FirstOrDefault(a => a.AuthorID == id);
        }

        public List<Author> GetTop3AuthorsByBookCount()
        {
            return _context.Authors
                .Include(a => a.Books)
                .OrderByDescending(a => a.Books.Count)
                .Take(3)
                .ToList();
        }
    }
}
