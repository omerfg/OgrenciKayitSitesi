using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegisterWebSite.Models.Siniflar
{
    public class Galeri
    {
        [Key]
        public int ID { get; set; }
        public string ResimUrl { get; set; }
        public string Aciklama { get; set; }
    }
}