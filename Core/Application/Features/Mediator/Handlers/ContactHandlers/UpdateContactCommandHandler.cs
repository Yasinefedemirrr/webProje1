using Application.Features.Mediator.Commands.ContactCommands;
using Application.interfaces;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, Unit>
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ContactID);
            values.Email = request.Email;
            values.Message = request.Message;
            values.Name = request.Name;

            await _repository.UpdateAsync(values);  
            return Unit.Value;
        }
    }
}
