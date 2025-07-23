using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.AuthorCommands
{
    public class UpdateAuthorCommand : IRequest
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorRole { get; set; }
        public string AuthorCity { get; set; }
        public string AuthorSignature { get; set; }
        public string AuthorDescription { get; set; }
        public string BigImageUrl { get; set; }
    }
}
