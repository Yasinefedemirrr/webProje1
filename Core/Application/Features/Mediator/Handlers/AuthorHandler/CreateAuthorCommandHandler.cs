﻿using Application.Features.Mediator.Commands.AuthorCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandler
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, Unit>
    {
        private readonly IRepository<Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author
            {
                AuthorCity = request.AuthorCity,
                AuthorName = request.AuthorName,
                AuthorDescription = request.AuthorDescription,
                AuthorSignature = request.AuthorSignature,
                AuthorRole = request.AuthorRole,
                BigImageUrl = request.BigImageUrl
            });

            return Unit.Value; 
        }
    }
}
