namespace XmlToJsonConvertor.Services.Models
{
    public class XmlDataModel
    {
        public int Id { get; set; }

        public string XmlData { get; set; } = null!;

        public string ConfigCode { get; set; } = null!;

        public string createdUser { get; set; } = string.Empty;

        public string? modifiedUser { get; set; }

        public bool isDeleted { get; set; }

    }
}
