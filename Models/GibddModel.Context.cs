//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gibdd.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GibddEntities : DbContext
    {
        public GibddEntities()
            : base("name=GibddEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Car_Colors> Car_Colors { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Engine_Types> Engine_Types { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<License_Categories> License_Categories { get; set; }
        public virtual DbSet<Region_Codes> Region_Codes { get; set; }
        public virtual DbSet<Status_History> Status_History { get; set; }
    }
}
