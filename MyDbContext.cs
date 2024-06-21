using Microsoft.EntityFrameworkCore;

namespace VisioForge_SDK_Video_Capture_Demo.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<CPerson> dbPersons { get; set; }
        public DbSet<CImage> dbImages { get; set; }
        public DbSet<CVisit> dbVisits { get; set; }

        private string sSchema = "dbo";


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(sSchema);
            modelBuilder.Entity<CPerson>().ToTable("PERSON", sSchema);
            modelBuilder.Entity<CVisit>()
           .ToTable("VISIT", sSchema)
           .HasMany(v => v.Images)
           .WithOne(i => i.Visit)
           .HasForeignKey(i => i.VisitId);
            modelBuilder.Entity<CImage>().ToTable("IMAGE", sSchema);

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    System.Console.WriteLine("OnConfiguring!");
        //    optionsBuilder.UseNpgsql("Server=localhost;Database=colpovisits;User Id=sa;Password=as;Port=5432");
        //}
    }
}
