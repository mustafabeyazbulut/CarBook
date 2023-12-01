
namespace Carbook.Application.Features.CQRS.Commands.BrandCommands
{
    public class RemoveBrandCommand
    {
        public RemoveBrandCommand(int brandId)
        {
            BrandId = brandId;
        }

        public int BrandId { get; set; }
       
    }
}
