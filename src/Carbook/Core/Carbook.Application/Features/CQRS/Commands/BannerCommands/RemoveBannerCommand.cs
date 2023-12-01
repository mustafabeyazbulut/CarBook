
namespace Carbook.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBannerCommand
    {
        public RemoveBannerCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
