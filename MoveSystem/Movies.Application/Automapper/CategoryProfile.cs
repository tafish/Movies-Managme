using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Repository;
using Movies.Domain.Entity;



namespace Ecommerce.Application.Automapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() 
        {
            CreateMap<DTOCategory, Category>();


            CreateMap<DTOUpdateCategory, Category>().ReverseMap();


        }
    }
}
