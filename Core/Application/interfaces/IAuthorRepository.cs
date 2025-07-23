using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAllAuthors();
        Author GetAuthorWithBooks(int id);
        List<Author> GetTop3AuthorsByBookCount();
    }
}
