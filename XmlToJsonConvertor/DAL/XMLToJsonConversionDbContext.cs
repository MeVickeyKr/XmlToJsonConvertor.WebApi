using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using XmlToJsonConvertor.UserDetailsDb.Entities;

namespace XmlToJsonConvertor.UserDetailsDb;

public partial class XMLToJsonConversionDbContext : DbContext
{
    public XMLToJsonConversionDbContext()
    {
    }

    public XMLToJsonConversionDbContext(DbContextOptions<XMLToJsonConversionDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<XmlDataEntity> Userdata { get; set; }

  
}
