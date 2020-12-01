using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NewVendor.Entity;

namespace NewVendor.Persistence
{
   public  class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<VendorRequest> VendorRequest { get; set; }
        public DbSet<AssignabilityClause> AssignabilityClause{ get; set; }
        public DbSet<AutoRenew> AutoRenew { get; set; }
        public DbSet<BuildingAccess> BuildingAccesse { get; set; }
        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<ContractLength> ContractLength { get; set; }
        public DbSet<ContractScope> ContractScope { get; set; }
        public DbSet<ContractSigned> ContractSigned { get; set; }
        public DbSet<ContractType> ContractType { get; set; }
        public DbSet<Currency> Currencie { get; set; }
      //  public DbSet<Entity> Entities { get; set; }
        public DbSet<FacilitiesType> FacilitiesType { get; set; }
        public DbSet<IsBudgeted> IsBudgeted { get; set; }
        public DbSet<LegalReviewNeeded> LegalReviewNeeded { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<ServiceArea> Service { get; set; }
        public DbSet<SupplierType> SupplierType { get; set; }
        public DbSet<SystemNetworkAccess> SystemNetworkAccess { get; set; }
        public DbSet<TerminationClause> TerminationClause { get; set; }
        public DbSet<Tier> Tier { get; set; }
        public DbSet<UserDataAccess> UserDataAccesse { get; set; }
        public DbSet<RequestType> RequestType { get; set; }
    }
}
