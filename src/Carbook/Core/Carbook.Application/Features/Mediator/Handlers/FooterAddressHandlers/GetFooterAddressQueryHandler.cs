using Carbook.Application.Features.Mediator.Queries.FooterAddressQueries;
using Carbook.Application.Features.Mediator.Results.FooterAddressResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAdress> _repository;
        public GetFooterAddressQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                FooterAdressId=x.FooterAdressId,
                Adress= x.Adress,
                Description= x.Description,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();
        }
    }
}
