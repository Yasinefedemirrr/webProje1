using Application.Features.Mediator.Commands.AboutCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand, Unit>
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutID);
            values.AboutID = request.AboutID;
            values.Description = request.Description;
            values.Title = request.Title;
            await _repository.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
