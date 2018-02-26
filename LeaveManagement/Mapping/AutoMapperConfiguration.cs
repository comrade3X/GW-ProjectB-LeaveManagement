using AutoMapper;
using LeaveManagement.Entity;
using LeaveManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManagement.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }

    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Company, CompanyViewModel>();
        }
    }

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CompanyViewModel, Company>()
                     .ForMember(g => g.Name, map => map.MapFrom(vm => vm.Name))
                     .ForMember(g => g.Id, map => map.MapFrom(vm => vm.Id))
                     .ForMember(g => g.Contact, map => map.MapFrom(vm => vm.Contact));
        }
    }
}