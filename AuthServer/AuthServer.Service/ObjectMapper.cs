using AutoMapper;
using System;

namespace AuthServer.Service
{
    public static class ObjectMapper
    {
        static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
       {
           var config = new MapperConfiguration(cfg => cfg.AddProfile<DtoMapper>());

           return config.CreateMapper();
       });

        public static IMapper Mapper => Lazy.Value;
    }
}
