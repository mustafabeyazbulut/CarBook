using Carbook.Application.Features.Mediator.Queries.AuthorQueries;
using Carbook.Application.Features.Mediator.Results.AuthorResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler:IRequestHandler<GetAuthorByIdQuery,GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;
        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var value= await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                AuthorId = value.AuthorId,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Name=value.Name,
            };
        }
    }
}
