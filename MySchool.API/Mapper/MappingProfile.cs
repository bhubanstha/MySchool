using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySchool.Data.Entity;
using MySchool.Business.ViewModel;
using AutoMapper;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace MySchool.API.Mapper
{
    public  class MappingProfile: Profile
    {
        public  MapperConfiguration mapConfig;

        public MappingProfile()
        {
            CreateMap<SchoolVM, School>()
                .ForMember(dest => dest.Logo, act => act.MapFrom(src => src.Logo.FileName +
                 Guid.NewGuid().ToString("N") +
                 "." + Path.GetExtension(src.Logo.FileName)));
            CreateMap<School, SchoolVM>();

            // cfg.CreateMap<Source, Destination>()
            //mapConfig = new MapperConfiguration(cfg =>
            //{

            //    cfg.CreateMap<SchoolVM, School>()
            //    .ForMember(dest => dest.Logo, act => act.MapFrom(src => src.Logo.FileName +
            //     Guid.NewGuid().ToString("N") +
            //     "." + Path.GetExtension(src.Logo.FileName)));


            //});
        }
    }
}
