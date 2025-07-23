using Application.Features.Mediator.Commands.AuthorCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandler
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author
            {
               AuthorCity = request.AuthorCity,
               AuthorName = request.AuthorName,
               AuthorDescription = request.AuthorDescription,
               AuthorSignature = request.AuthorSignature,
               AuthorRole = request.AuthorRole,
               BigImageUrl = request.BigImageUrl,
               

            });
        }
    }
}
