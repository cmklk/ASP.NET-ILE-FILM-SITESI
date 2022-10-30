using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace filmSitesi.Models.siniflar
{
    public class yorum
    {
        [Key]
        public int ID { get; set; }
        public string kullaniciAdi { get; set; }
        public string email { get; set; }
        public string kullaniciYorum { get; set; }
        public int blogid { get; set; }
        public virtual film film { get; set; }
    }
}