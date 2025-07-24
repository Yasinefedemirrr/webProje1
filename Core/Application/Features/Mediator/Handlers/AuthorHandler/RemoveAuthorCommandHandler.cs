using Application.Features.Mediator.Commands.AuthorCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandler
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand, Unit>
    {
        private readonly IRepository<Author> _repository;

        public RemoveAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
            return Unit.Value;
        }
    }
}
