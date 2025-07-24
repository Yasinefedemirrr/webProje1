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
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, GetBookByIdQueryResult>
    {
        private readonly IRepository<Book> _repository;

        public GetBookByIdQueryHandler(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<GetBookByIdQueryResult> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBookByIdQueryResult
            {
                Id=values.Id,
                CoverImageUrl = values.CoverImageUrl,
                Title =values.Title,
                AuthorId = values.AuthorId,
                CreatedDate = values.CreatedDate,
                FullDescription = values.FullDescription,
                ShortDescription = values.ShortDescription,
                IsPopular = values.IsPopular,
                Rating = values.Rating

            };
        }
    }
}
