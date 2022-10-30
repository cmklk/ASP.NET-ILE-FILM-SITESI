using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace filmSitesi.Models.siniflar
{
    public class film
    {
        [Key]
        public int ID { get; set; }
        public string filmAd { get; set; }
        public string yonetmen { get; set; }
        public string oyuncular { get; set; }
        public decimal imdp { get; set; }
        public string konu { get; set; }
        public int yapimYil { get; set; }
        public string tur { get; set; }
        public string imgUrl { get; set; }
        public ICollection<yorum> yorums { get; set; }
    }
}