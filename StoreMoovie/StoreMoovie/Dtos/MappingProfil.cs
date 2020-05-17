using AutoMapper;
using StoreMoovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.Dtos
{
    public class MappingProfil : Profile
    {
        public MappingProfil()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            CreateMap<Adhesion, AdhesionDto>();
            CreateMap<AdhesionDto, Adhesion>();

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();

          

            CreateMap<Genres, GenresDto>();
            CreateMap<GenresDto, Genres>();





        }
        
    }
}
