using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebKUR.Dtos;

namespace WebKUR.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Custome, CustomerDto>();
        }
    }
}