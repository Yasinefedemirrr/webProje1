
using Application.Features.Mediator.Commands.BookCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BookHandlers
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, Unit>
    {
        private readonly IRepository<Book> _repository;

        public UpdateBookCommandHandler(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            values.FullDescription = request.FullDescription;
            values.Title = request.Title;
            values.ShortDescription = request.ShortDescription;
            values.CreatedDate = request.CreatedDate;
            values.AuthorId = request.AuthorId;
            values.IsPopular = request.IsPopular;
            values.CoverImageUrl = request.CoverImageUrl;
           values.Rating=request.Rating;
            await _repository.UpdateAsync(values);
            return Unit.Value;
        }
    }
    
   
}
