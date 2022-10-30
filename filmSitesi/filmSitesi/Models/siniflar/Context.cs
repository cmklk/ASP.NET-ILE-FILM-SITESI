using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace filmSitesi.Models.siniflar
{
    public class Context:DbContext
    {
        public DbSet<film> films { get; set; }
        public DbSet<admin> admins { get; set; }
        public DbSet<yorum> yorums { get; set; }
    }
}