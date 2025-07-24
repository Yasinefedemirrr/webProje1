using Application.Features.Mediator.Queries.ContactQueries;
using Application.Features.Mediator.Results.ContactResults;
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
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetContactByIdQueryResult
            {
              ContactID = values.ContactID,
              Name = values.Name,
              Message = values.Message,
              Email = values.Email, 

            };
        }
    }
}
