/*************************************************************************************************************
*																			
*	Name:-					DbContext: EntityContext 
*   Type:-					Class
*	Date:-					23 January 2013														
*	Author:-				Zion Designer v1.0
*	Cloud Designer Author:-	Mike Myers													
*	Comments:-				DbContext class useds by the Entity Framework for Database linkage
*																			
*************************************************************************************************************/

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Hackathon.Entities;

namespace Hackathon.Repository
{
    public class EntityContext : DbContext
    {


        public DbSet<DentalPractice> DentalPractices { get; set; }
        public DbSet<GPPractice> GPPractices { get; set; }
        public DbSet<HealthCentre> HealthCentres { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<NursingHome> NursingHomes { get; set; }
        public DbSet<Pharmacie> Pharmacies { get; set; }
        public DbSet<PrimaryCareCentre> PrimaryCareCentres { get; set; }

        /// <summary>
        /// This overrides the default behaviour of the entity model, and stops it from 
        /// checking the HASH of the DB  against the model 
        /// i.e. it prevents the automatic change detection
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <remarks>
        /// When context creates a model it computes a hash from this model and compares it 
        /// with value stored in EdmMetadata table (table is created first time the EF creates the database).
        /// If the value loaded from database is different EF either starts database recreation (if initializer is configured) 
        /// or throws the exception you see. Manually changing the database will not modify hash stored 
        /// in EdmMetadata so the model will still think that the database is unchanged. Enable this function is needed
        /// </remarks>
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        //}
    }
}