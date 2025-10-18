using AutoMapper;
using ApiTest.Src.Customer;
using ApiTest.Src.Customer.Dto;
using ApiTest.Src.Vehicle.Dto;
using ApiTest.Src.Vehicle;
using ApiTest.Src.InspectionType.Dto;
using ApiTest.Src.InspectionType;
using ApiTest.Src.Owners.Dto;
using ApiTest.Src.Inspector;

namespace ApiTest.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerDto, CustomerModel>();
            CreateMap<UpdateCustomerDto, CustomerModel>();
            CreateMap<CreateVehicleDto, VehicleModel>();
            CreateMap<UpdateVehicleDto, VehicleModel>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcValue) => srcValue != null));
            CreateMap<CreateInspectionTypeDto, InspectionTypeModel>();
            CreateMap<UpdateInspectionTypeDto, InspectionTypeModel>();
            CreateMap<CreateInspectorDto, InspectorModel>();
            CreateMap<UpdateInspectorDto, InspectorModel>();

        }
    }
}
