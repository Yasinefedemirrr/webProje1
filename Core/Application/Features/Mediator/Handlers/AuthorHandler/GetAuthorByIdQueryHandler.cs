using Application.Features.Mediator.Queries.AuthorQueries;
using Application.Features.Mediator.Results.AuthorResults;
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
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                AuthorID = request.Id,
               BigImageUrl = values.BigImageUrl,
               AuthorRole = values.AuthorRole,
               AuthorCity = values.AuthorCity,
               AuthorSignature = values.AuthorSignature,
               AuthorDescription = values.AuthorDescription,
               AuthorName  = values.AuthorName,
               
            };
        }
    }
}
