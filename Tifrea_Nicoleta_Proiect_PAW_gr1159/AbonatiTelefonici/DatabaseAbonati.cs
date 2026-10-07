using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public class DatabaseAbonati : DbContext
    {
       
        public DatabaseAbonati() : base("name=AbonatiConnectionString")
        {
            Database.SetInitializer<DatabaseAbonati>(new DropCreateDatabaseIfModelChanges<DatabaseAbonati>());
        }

        //tabelele din baza de date
        public DbSet<AbonatTelefonic> Abonati { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<TipAbonament> Abonamente { get; set; }
        public DbSet<ExtraOptiuni> ExtraOptiuni { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<AbonatTelefonic>().HasKey(a => a.IdAbonament);
            modelBuilder.Entity<Client>().HasKey(c => c.IdClient);
            modelBuilder.Entity<TipAbonament>().HasKey(t => t.IdTip);
            modelBuilder.Entity<ExtraOptiuni>().HasKey(e => e.IdOptiune);

            base.OnModelCreating(modelBuilder);
        }
    }
}
