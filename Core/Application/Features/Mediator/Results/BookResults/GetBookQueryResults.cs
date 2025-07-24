using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.BookResults
{
    public class GetBookQueryResults
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string CoverImageUrl { get; set; }
       
        public double? Rating { get; set; }
        public bool IsPopular { get; set; }
        public DateTime CreatedDate { get; set; }

        public int AuthorId { get; set; }
    }
}
