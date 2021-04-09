using AutoMapper;
using week1.DTOs;
using week1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week1.Models.Store;
using week1.DTOs.Store;

namespace week1
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>()
                .ForMember(x => x.RoleName, x => x.MapFrom(x => x.Name));


            CreateMap<RoleDtoAdd, Role>()
                .ForMember(x => x.Name, x => x.MapFrom(x => x.RoleName)); ;


            CreateMap<UserRole, UserRoleDto>();
            
            CreateMap<Customer, CustomerDTO_ToReturn>().ReverseMap();
            CreateMap<Room, RoomDTO_ToReturn>().ReverseMap();

            
            CreateMap<Employee, EmployeeDTO_ToReturn>().ReverseMap();
            CreateMap<Person, PersonDTO_ToReturn>().ReverseMap();

            CreateMap<ProductGroup, ProductGroupDTO_ToReturn>().ReverseMap();
            CreateMap<Product,ProductDTO_ToReturn>().ReverseMap();
            
            CreateMap<ProductGroup, ProductGroupDTO_ToReturn_Product>().ReverseMap();
            CreateMap<Order, OrderDTO_ToReturn>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDTO_ToReturn>().ReverseMap();
       
        }
        
    }
}