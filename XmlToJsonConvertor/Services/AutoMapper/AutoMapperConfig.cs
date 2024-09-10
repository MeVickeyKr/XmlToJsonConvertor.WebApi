using AutoMapper;
using XmlToJsonConvertor.Services.Models;
using XmlToJsonConvertor.UserDetailsDb.Entities;

namespace XmlToJsonConvertor.Services.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<XmlDataEntity, XmlDataModel>();
        }
    }
}
