using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.BookCommands
{
    public class CreateBookCommand : IRequest
    {
       
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
