using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EkstraMap());
            modelBuilder.Configurations.Add(new HizmetliMap());
            modelBuilder.Configurations.Add(new MisafirMap());
            modelBuilder.Configurations.Add(new OdaMap());
            modelBuilder.Configurations.Add(new ResepsiyonistMap());
            modelBuilder.Configurations.Add(new RezervasyonMap());
            modelBuilder.Configurations.Add(new SiparisMap());
            modelBuilder.Configurations.Add(new HizmetliOdaMap());
            modelBuilder.Configurations.Add(new ResepsiyonistProfilMap());
            modelBuilder.Configurations.Add(new OdaEkstraMap());

        }

        public DbSet<Ekstra> Ekstras { get; set; }
        public DbSet<Hizmetli> Hizmetlis { get; set; }
        public DbSet<Misafir> Misafirs { get; set; }
        public DbSet<Oda> Odas { get; set; }
        public DbSet<Resepsiyonist> Resepsiyonists { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<HizmetliOda> HizmetliOdas { get; set; }
        public DbSet<ResepsiyonistProfil> ResepsiyonistProfils { get; set; }
        public DbSet<OdaEkstra> OdaEkstras { get; set; }



    }
}
}
