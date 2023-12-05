
namespace Carbook.Dto.CarDtos
{
    public class ResultLast5CarsWithBrandDto
    {
            public int carId { get; set; }
            public int brandId { get; set; }
            public string brandName { get; set; }
            public string model { get; set; }
            public string coverImageUrl { get; set; }
            public int km { get; set; }
            public string transmission { get; set; }
            public byte seat { get; set; }
            public byte luggage { get; set; }
            public string fuel { get; set; }
            public string bigImageUrl { get; set; }
    }
}
