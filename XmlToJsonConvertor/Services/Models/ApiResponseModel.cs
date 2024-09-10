using System.Xml.Serialization;

namespace XmlToJsonConvertor.Services.Models
{
    public class ApiResponseModel
    {
        public string TimeStamp { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        public XmlDataDetailsResponse? Body { get; set; }
    }

    [Serializable]
    [XmlRoot(ElementName = "INFORMATION")]
    public class XmlDataDetailsResponse
    {
        [XmlElement("ADDITIONAL_FIELDS")]
        public List<XmlDataDetails> xmlDetails { get; set; }
    }

    //[Serializable]
    //[XmlRoot(ElementName = "ADDITIONAL_FIELDS")]
    public class XmlDataDetails
    {
        [XmlElement(ElementName = "ZPRDTYP")]
        public string Payment_method { get; set; } = string.Empty;

        [XmlElement(ElementName = "RSTERM")]
        public string RiskTerm { get; set; } = string.Empty;

        [XmlElement(ElementName = "PMTERM")]
        public string PremiumTerm { get; set; } = string.Empty;

        [XmlElement(ElementName = "PAYMMETH")]
        public string PaymentMethod { get; set; } = string.Empty;

        [XmlElement(ElementName = "PAYFREQ")]
        public string PaymentFreq { get; set; } = string.Empty;

        [XmlElement(ElementName = "RCDDATE")]
        public string RiskCommencementDate { get; set; } = string.Empty;

        [XmlElement(ElementName = "LASEX")]
        public string LifeAssuredGender { get; set; } = string.Empty;

        [XmlElement(ElementName = "LADOB")]
        public string LifeAssuredDateOfBirth { get; set; } = string.Empty;

        [XmlElement(ElementName = "LACRTBL")]
        public string LifeAssuredComponentCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "LAINSPR")]
        public string LifeAssuredInstallmentPremium { get; set; } = string.Empty;

    }

}
