using System;
using System.Collections.Generic;


namespace XmlToJsonConvertor.UserDetailsDb.Entities;

public  class XmlDataEntity
{
    public int Id { get; set; }

    public string XmlData { get; set; } = null!;

    public string ConfigCode { get; set; } = null!;

    public string CreatedUser   { get; set; } = string.Empty;

    public string ModifiedUser { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
