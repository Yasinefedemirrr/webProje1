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
    public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand, Unit>
    {
        private readonly IRepository<Book> _repository;

        public RemoveBookCommandHandler(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RemoveBookCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
            return Unit.Value;
        }
    }
    
    }

