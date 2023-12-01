
namespace Carbook.Application.Features.CQRS.Commands.CarCommands
{
    public class RemoveCarCommand
    {
        public RemoveCarCommand(int carId)
        {
            CarId = carId;
        }

        public int CarId { get; set; }
       
    }
}
