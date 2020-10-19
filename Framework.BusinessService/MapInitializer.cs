using AutoMapper;
using Framework.Domain;
using Framework.BusinessService;
using System;
using System.Collections.Generic;
using System.Text;
using Framework.DTO;

namespace Framework.BusinessService
{
    public class MapInitializer : Profile
    {
        public MapInitializer()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CustomerEntity, Customer>();
        }
    }
}
