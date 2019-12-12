using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M3.Models;
using M3.Dtos;
using AutoMapper;

namespace M3.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
           
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            


            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}