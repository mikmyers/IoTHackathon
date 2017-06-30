using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.Data.Entities;

namespace Hackathon.Data
{
  public class HSEContext : IdentityDbContext
  {
    private IConfigurationRoot _config;

    public HSEContext(DbContextOptions options, IConfigurationRoot config)
      : base(options)
    {
      _config = config;
    }

    public DbSet<DentalPractice> DentalPractices { get; set; }
    public DbSet<GPPractice> GPPractices { get; set; }
    public DbSet<HealthCentre> HealthCentres { get; set; }
    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<NursingHome> NursingHomes { get; set; }
    public DbSet<Pharmacie> Pharmacies { get; set; }
    public DbSet<PrimaryCareCentre> PrimaryCareCentres { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);

      optionsBuilder.UseSqlServer(_config["Data:ConnectionString"]);
    }
  }
}
