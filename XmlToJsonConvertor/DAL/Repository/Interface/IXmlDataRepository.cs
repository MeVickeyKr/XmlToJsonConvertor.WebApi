

using Microsoft.EntityFrameworkCore;
using XmlToJsonConvertor.UserDetailsDb.Entities;

namespace XmlToJsonConvertor.UserDetailsDb.Repository.Interface
{
    public interface IXmlDataRepository
    {
        public   Task<XmlDataEntity>GetXmlDataAsync( string ConfigCode);
    }
}
