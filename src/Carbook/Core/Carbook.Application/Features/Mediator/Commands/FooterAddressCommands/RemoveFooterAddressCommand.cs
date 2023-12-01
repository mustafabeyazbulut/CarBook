using MediatR;

namespace Carbook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class RemoveFooterAddressCommand : IRequest
    {
        public int FooterAdressId { get; set; }
        public RemoveFooterAddressCommand(int footerAdressId)
        {
            FooterAdressId = footerAdressId;
        }
    }
}
