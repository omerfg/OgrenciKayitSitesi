using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisterWebSite.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string ImageUrl { get; set; }
    }
}