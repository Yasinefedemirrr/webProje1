using Application.Features.Mediator.Commands.BookCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BookMediator
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Unit>
    {
        private readonly IRepository<Book> _repository;

        public CreateBookCommandHandler(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Book
            {
               CoverImageUrl = request.CoverImageUrl,
               Title = request.Title,   
               AuthorId = request.AuthorId,
               CreatedDate = request.CreatedDate,
               FullDescription = request.FullDescription,
               ShortDescription = request.ShortDescription,
               IsPopular = request.IsPopular,
               Rating = request.Rating,
               
            });

            return Unit.Value;
        }
    }
    
    
}
