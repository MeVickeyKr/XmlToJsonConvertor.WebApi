using AutoMapper;
using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Immutable;
using System.Xml.Linq;
using XmlToJsonConvertor.Services.Interface;
using XmlToJsonConvertor.Services.Models;
using XmlToJsonConvertor.UserDetailsDb.Repository.Interface;
using XmlToJsonConvertor.UserDetailsDb.Repository.Implementations;
using Microsoft.VisualBasic;
using System.Xml.Serialization;
using XmlToJsonConvertor.ExtensionMethods;

namespace XmlToJsonConvertor.Services.Implementations
{
    public class XmlToJsonServices : IXmlToJsonServices
    {
        private readonly IXmlDataRepository _details;
        private readonly IMapper _mapper;
        public XmlToJsonServices(IXmlDataRepository details, IMapper mapper)
        {
            _details = details;
            _mapper = mapper;
        }
        public async Task<ApiResponseModel> GetConvertedJsonData(string ConfigCode)
        {
            var result = await _details.GetXmlDataAsync(ConfigCode);
            if (result == null)
                return new ApiResponseModel()
                {
                    TimeStamp = DateTime.UtcNow.ToString("o"),
                    Message = "NotFound",
                    Code = "404",
                    Body = null

                };

            var xmlDataModelList = _mapper.Map<XmlDataModel>(result);
            return new ApiResponseModel()
            {
                TimeStamp = DateTime.UtcNow.ToString("o"),
                Message = "success",
                Code = "200",
                Body = XmlToJsonConvertorExtenions<XmlDataDetailsResponse>.ConvertToJson(xmlDataModelList.XmlData)

            };

        }
       // private XmlDataDetailsResponse ConvertToJson<T>(string xmlData) where T : XmlDataDetailsResponse
        //{
        //    T result = DeserializeXml<T>(xmlData);

        //    if (result == null)
        //    {
        //        throw new Exception("Deserialization failed.");
        //    }

        //    // Convert the result to JSON and return the result
        //    string json = JsonConvert.SerializeObject(result, Formatting.Indented);

        //    return result as XmlDataDetailsResponse;
        //}

        // Deserialize the XML string to the object of type T
        //private T DeserializeXml<T>(string xmlData) where T : class
        //{
        //    T obj;
        //    using (StringReader stringReader = new StringReader(xmlData))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(T));
        //        obj = (T)serializer.Deserialize(stringReader);
        //    }
        //    return obj;
        //}
    }
}

