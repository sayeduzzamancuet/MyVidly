using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyVidly.Dtos;
using MyVidly.Models;

namespace MyVidly.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Customer, CustomerDto>().ForMember(m => m.Id, opt => opt.Ignore());


            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Movie, MovieDto>().ForMember(m => m.Id, opt => opt.Ignore());

        } 
    }
}