using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorRole { get; set; }
        public string AuthorCity { get; set; }
        public string AuthorSignature { get; set; }
        public string AuthorDescription { get; set; }
        public string BigImageUrl { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
