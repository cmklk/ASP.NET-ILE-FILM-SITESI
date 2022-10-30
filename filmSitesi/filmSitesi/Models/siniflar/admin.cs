using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace filmSitesi.Models.siniflar
{
    public class admin
    {
        [Key]
        public int ID { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}