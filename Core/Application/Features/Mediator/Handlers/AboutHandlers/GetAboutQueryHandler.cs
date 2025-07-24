﻿using Application.Features.Mediator.Queries.AboutQueries;
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
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery,List<GetAboutQueryResult>>
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
               AboutID = x.AboutID, 
               Description = x.Description,
               Title= x.Title,

            }).ToList();
        }
    }
}
