﻿namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetGeographicComplementary ;
using Domain.Allergies;
using Domain.Goals;
using Domain.ProductService;
using Domain.ProductService.GeographicInfo;

    public class ResponseGetAllReferential
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static ICollection<ResponseGetAllReferential> MapResponse(ICollection<Country> countries)
        {
            return new List<ResponseGetAllReferential>(countries.Select(x => new ResponseGetAllReferential
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }

        public static ICollection<ResponseGetAllReferential> MapResponse(ICollection<City> cities)
        {
            return new List<ResponseGetAllReferential>(cities.Select(x => new ResponseGetAllReferential
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }

        public static ICollection<ResponseGetAllReferential> MapResponse(ICollection<State> states)
        {
            return new List<ResponseGetAllReferential>(states.Select(x => new ResponseGetAllReferential
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }

        public static ICollection<ResponseGetAllReferential> MapResponse(ICollection<TypeOfNutrition> typeOfNutrition)
        {
            return new List<ResponseGetAllReferential>(typeOfNutrition.Select(x => new ResponseGetAllReferential
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }

        public static ICollection<ResponseGetAllReferential> MapResponse(ICollection<NutritionalAllergy> nutritionalAllergies)
        {
            return new List<ResponseGetAllReferential>(nutritionalAllergies.Select(x => new ResponseGetAllReferential
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }

        public static ICollection<ResponseGetAllReferential> MapResponse(ICollection<Goal> goals)
        {
            return new List<ResponseGetAllReferential>(goals.Select(x => new ResponseGetAllReferential
            {
                Id = x.Id,
                Name = x.Name.ToString()
            }));
        }
    }
