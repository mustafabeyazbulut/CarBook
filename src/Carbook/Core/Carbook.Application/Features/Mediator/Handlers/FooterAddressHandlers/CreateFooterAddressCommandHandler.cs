using Carbook.Application.Features.Mediator.Commands.FooterAddressCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;
        public CreateFooterAddressCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAdress
            {
                Adress = request.Adress,
                Description = request.Description,
                Email= request.Email,
                Phone = request.Phone
            });
        }
    }
}
