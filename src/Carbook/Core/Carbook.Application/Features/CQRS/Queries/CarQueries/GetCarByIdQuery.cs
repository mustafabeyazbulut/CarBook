
namespace Carbook.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public GetCarByIdQuery(int carId)
        {
            CarId = carId;
        }

        public int CarId { get; set; }
    }
}
