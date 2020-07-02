using AutoMapper;
using Core.Models;
using MasterBasketApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterBasketApi.Helpers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(p => p.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(p => p.ProductType, o => o.MapFrom(s => s.ProductType.Name));
        }
    }
}
