using Application.Features.Mediator.Queries.AboutQueries;
using Application.Features.Mediator.Queries.AuthorQueries;
using Application.Features.Mediator.Results.AboutResults;
using Application.Features.Mediator.Results.AuthorResults;
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
    public class GetAboutByIdQueryHandler :IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAboutByIdQueryResult
            {
               AboutID = request.Id,
               Description= values.Description,
               Title= values.Title,

            };
        }
    }
}
