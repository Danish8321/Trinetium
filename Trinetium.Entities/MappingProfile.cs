using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trinetium.Entities.DTO;
using Trinetium.Entities.Models;

namespace Trinetium.Entities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductListCustDto>()
                .ForMember(v => v.Description, opt => opt.MapFrom(src => src.Category.Description))
                .ForMember(v => v.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(v => v.Picture, opt => opt.MapFrom(src => src.Category.Picture))
                .ForMember(v => v.UnitsInStock, opt => opt.Condition(c => c.UnitsInStock > 0))
                .ForMember(v => v.Discontinued, opt => opt.Condition(c => c.Discontinued == false));

            CreateMap<Customers, UserDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CompanyName))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CustomerId));


            CreateMap<Employees, UserDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.EmployeeId));



            //CreateMap<Orders, OrderListCustDto>()
            //    .ForMember(v => v.Description, opt => opt.MapFrom(src => src.OrderDetails.FirstOrDefault().Product.Category.Description))
            //    .ForMember(v => v.Picture, opt => opt.MapFrom(src => src.OrderDetails.FirstOrDefault().Product.Category.Picture))
            //    .ForMember(v => v.Picture, opt => opt.MapFrom(src => src.OrderDetails.FirstOrDefault().Product.ProductName))
            //    .ForMember(v => v.Picture, opt => opt.MapFrom(src => src.OrderDetails.FirstOrDefault().Product.UnitPrice))
            //    .ForMember(v => v.Picture, opt => opt.MapFrom(src => src.OrderDetails.FirstOrDefault().Quantity));

        }
    }
}
