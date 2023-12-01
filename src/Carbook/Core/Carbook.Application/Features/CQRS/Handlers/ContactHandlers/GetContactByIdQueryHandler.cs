using Carbook.Application.Features.CQRS.Queries.ContactQueries;
using Carbook.Application.Features.CQRS.Results.ContactResult;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;


namespace Carbook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.ContactId);
            return new GetContactByIdQueryResult
            {
                ContactId= values.ContactId,
                Name = values.Name,
                Email = values.Email,
                Subject = values.Subject,
                Message = values.Message,
                SendDate = values.SendDate
            };
        }
    }
}
