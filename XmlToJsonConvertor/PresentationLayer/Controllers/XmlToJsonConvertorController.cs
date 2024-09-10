using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XmlToJsonConvertor.Services.Implementations;
using XmlToJsonConvertor.Services.Interface;
using XmlToJsonConvertor.Services.Models;

namespace XmlToJsonConvertor.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlToJsonConvertorController : ControllerBase
    {
        private readonly IXmlToJsonServices _iuserServices;

        public XmlToJsonConvertorController(IXmlToJsonServices iuserServicescs)
        {
            _iuserServices = iuserServicescs;
        }
        [HttpGet]
        public async Task<IActionResult> GetByConfigCodeAsync(string configCode)
        {
            return Ok(await _iuserServices.GetConvertedJsonData(configCode));
        }

    }
}
