using XmlToJsonConvertor.UserDetailsDb.Repository.Interface;
using XmlToJsonConvertor.UserDetailsDb.Entities;


using XmlToJsonConvertor.UserDetailsDb;
using Microsoft.EntityFrameworkCore;

namespace XmlToJsonConvertor.UserDetailsDb.Repository.Implementations
{
    public class XmlDataRepository : IXmlDataRepository
    {
        private readonly  XMLToJsonConversionDbContext _context;
        public XmlDataRepository(XMLToJsonConversionDbContext context)
        {
            _context = context;
        }
        public async Task<XmlDataEntity>GetXmlDataAsync(string configCode)
        {
             return await _context.Userdata.FirstOrDefaultAsync(u => u.ConfigCode == configCode);
        }
          
    }
}
