﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieStop.Models;
using MovieStop.Dtos;

namespace MovieStop.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to DTO
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();
            
            // DTO to Domain
            Mapper.CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Movie, MovieDto>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}