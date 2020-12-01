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

        public DbSet<VendorRequest> VendorRequests { get; set; }
        public DbSet<AssignabilityClause> AssignabilityClauses { get; set; }
        public DbSet<AutoRenew> AutoRenews { get; set; }
        public DbSet<BuildingAccess> BuildingAccesses { get; set; }
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<ContractLength> ContractLengths { get; set; }
        public DbSet<ContractScope> ContractScopes { get; set; }
        public DbSet<ContractSigned> ContractSigneds { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
      //  public DbSet<Entity> Entities { get; set; }
        public DbSet<FacilitiesType> FacilitiesTypes { get; set; }
        public DbSet<IsBudgeted> IsBudgeteds { get; set; }
        public DbSet<LegalReviewNeeded> LegalReviewNeededs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ServiceArea> Services { get; set; }
        public DbSet<SupplierType> SupplierTypes { get; set; }
        public DbSet<SystemNetworkAccess> SystemNetworkAccesses { get; set; }
        public DbSet<TerminationClause> TerminationClauses { get; set; }
        public DbSet<Tier> Tiers { get; set; }
        public DbSet<UserDataAccess> UserDataAccesses { get; set; }
    }
}
