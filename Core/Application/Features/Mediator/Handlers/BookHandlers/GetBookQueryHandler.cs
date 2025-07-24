using Application.Features.Mediator.Queries.BookQueries;
using Application.Features.Mediator.Results.BookResults;
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
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, List<GetBookQueryResult>>
    {
        private readonly IRepository<Book> _repository;

        public GetBookQueryHandler(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBookQueryResult>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBookQueryResult
            {
                Id= x.Id,
                CoverImageUrl = x.CoverImageUrl,
                Title = x.Title,
                AuthorId = x.AuthorId,
                CreatedDate = x.CreatedDate,
                FullDescription = x.FullDescription,
                ShortDescription = x.ShortDescription,
                IsPopular = x.IsPopular,
                Rating = x.Rating,

            }).ToList();
        }
    }
}
