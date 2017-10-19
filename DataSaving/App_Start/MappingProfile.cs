using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataSaving.Models;

namespace DataSaving.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<UserData, LogDTO>();
        }
    }
}
