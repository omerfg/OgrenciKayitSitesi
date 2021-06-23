using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

namespace StudentRegisterWebSite.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Galeri> Galeris { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Istatistik> Istatistiks { get; set; }
        public DbSet<Kurslar> Kurslars { get; set; }
        public DbSet<OgrenciKayitTalebi> OgrenciKayitTalebis { get; set; }
        public DbSet<Duyuru> Duyurus { get; set; }

    }
}