namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetGeographicComplementary ;
using Domain.ProductService.GeographicInfo;

    public class ResponseGetAllGeographic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static ICollection<ResponseGetAllGeographic> MapResponse(ICollection<Country> countries)
        {
            return new List<ResponseGetAllGeographic>(countries.Select(x => new ResponseGetAllGeographic
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }

        public static ICollection<ResponseGetAllGeographic> MapResponse(ICollection<City> cities)
        {
            return new List<ResponseGetAllGeographic>(cities.Select(x => new ResponseGetAllGeographic
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }

        public static ICollection<ResponseGetAllGeographic> MapResponse(ICollection<State> states)
        {
            return new List<ResponseGetAllGeographic>(states.Select(x => new ResponseGetAllGeographic
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }
    }
