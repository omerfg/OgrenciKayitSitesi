using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisterWebSite.Models.Siniflar
{
    public class Kurslar
    {
        [Key]
        public int ID { get; set; }
        public string KursAdi { get; set; }
        public string Aciklama { get; set; }
        public string ImageUrl { get; set; }
    }
}