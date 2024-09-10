using XmlToJsonConvertor.Services.Models;

namespace XmlToJsonConvertor.Services.Interface
{
    public interface IXmlToJsonServices
    {
        public Task<ApiResponseModel> GetConvertedJsonData(string ConfigCode);
    }
}
