using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System.Xml.Serialization;
using XmlToJsonConvertor.Services.Models;

namespace XmlToJsonConvertor.ExtensionMethods
{
    public class XmlToJsonConvertorExtenions<T> where T : class
    {

        public static T ConvertToJson(string xmlData)
        {
            T result = DeserializeXml(xmlData);

            if (result == null)
            {
                throw new Exception("Deserialization failed.");
            }

            // Convert the result to JSON and return the result
            string json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return result as T;

            // Deserialize the XML string to the object of type T
            static T DeserializeXml(string xmlData)
            {
                T obj;
                using (StringReader stringReader = new StringReader(xmlData))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    obj = (T)serializer.Deserialize(stringReader);
                }
                return obj;
            }
        }
    }
}

