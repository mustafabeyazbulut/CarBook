using Carbook.Application.Features.Mediator.Queries.FooterAddressQueries;
using Carbook.Application.Features.Mediator.Results.FooterAddressResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAdress> _repository;
        public GetFooterAddressByIdQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }
        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResult
            {
                FooterAdressId = values.FooterAdressId,
                Adress= values.Adress,
                Description= values.Description,
                Phone = values.Phone,
                Email = values.Email
            };
        }
    }
}
