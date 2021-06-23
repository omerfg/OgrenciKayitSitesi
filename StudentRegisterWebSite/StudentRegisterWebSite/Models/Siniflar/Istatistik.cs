using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisterWebSite.Models.Siniflar
{
    public class Istatistik
    {
        [Key]
        public int ID { get; set; }
        public string OgretmenSayisi { get; set; }
        public string SinifOdaSayisi { get; set; }
        public string OkulOtobüsSayısı { get; set; }
    }
}