using Application.Features.Mediator.Commands.AuthorCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandler
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, Unit>
    {
        private readonly IRepository<Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AuthorID);
            values.AuthorDescription = request.AuthorDescription;
            values.AuthorName = request.AuthorName;
            values.AuthorSignature = request.AuthorSignature;
            values.AuthorCity = request.AuthorCity;
            values.AuthorRole = request.AuthorRole;
            values.BigImageUrl = request.BigImageUrl;
            await _repository.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
