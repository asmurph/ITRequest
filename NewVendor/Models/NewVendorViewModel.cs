using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewVendor.Models
{
    public class NewVendorViewModel
    {
        public int Id { get; set; }
        public string Requester { get; set; }
        public string ServiceOwner { get; set; }
        public string Folder { get; set; }
        public string Email { get; set; }
        public string NoticeEmail { get; set; }
        public string RoleTitle { get; set; }
        public string Product_Service { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Owner_Manager { get; set; }
        public string TotalCost { get; set; }
        public string AnnualCost { get; set; }
        public string PO { get; set; }
        public string CostCenter { get; set; }
        public string BusinessJustification { get; set; }
        public string ContractTitle { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ContractLength { get; set; }
        public Nullable<System.DateTime> RenewalDateNotice { get; set; }
        public string TerminationNoticeDays { get; set; }
        public string LawLocation { get; set; }
        public string Notes { get; set; }
        public string ITTicket { get; set; }
        public string Comments { get; set; }
        public string AssetManager { get; set; }
        public Nullable<System.DateTime> AssetManagerApprovedOn { get; set; }
        public string DesktopArch { get; set; }
        public Nullable<System.DateTime> DesktopArchApprovedOn { get; set; }
        public string Facilities { get; set; }
        public Nullable<System.DateTime> FacilitiesApprovedOn { get; set; }
        public string Finance { get; set; }
        public Nullable<System.DateTime> FinanceApprovedOn { get; set; }
        public string InfoSec { get; set; }
        public Nullable<System.DateTime> InfoSecApprovedOn { get; set; }
        public string Legal { get; set; }
        public Nullable<System.DateTime> LegalApprovedOn { get; set; }
        public string Compliance { get; set; }
        public Nullable<System.DateTime> ComplianceApprovedOn { get; set; }
        public string Sourcing { get; set; }
        public Nullable<System.DateTime> SourcingApprovedOn { get; set; }
        public string ConfidentialInfo { get; set; }
        public Nullable<System.DateTime> OwnerManagerDate { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> AutoRenewId { get; set; }
        public Nullable<int> BusinessUnitId { get; set; }
        public Nullable<int> AssignabilityClauseId { get; set; }
        public Nullable<int> RequestTypeId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> FacilitiesTypeId { get; set; }
        public Nullable<int> SupplierTypeId { get; set; }
        public Nullable<int> ServiceAreaId { get; set; }
        public Nullable<int> TierId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> IsBudgetedId { get; set; }
        public Nullable<int> ContractLengthMoreThan1yrId { get; set; }
        public Nullable<int> ContractTypeId { get; set; }
        public Nullable<int> RenewalNoticeId { get; set; }
        public Nullable<int> EntityId { get; set; }
        public Nullable<int> ContractScopeId { get; set; }
        public Nullable<int> ContractSignedId { get; set; }
        public Nullable<int> TerminationClauseId { get; set; }
        public Nullable<int> LegalReviewNeededId { get; set; }
        public Nullable<int> SystemNetworkAccessId { get; set; }
        public Nullable<int> UserDataAccessId { get; set; }
        public Nullable<int> BuildingAccessId { get; set; }
        public Nullable<int> DecisionId { get; set; }
        public Nullable<int> NonEmployeeLaborTypeId { get; set; }
        public Nullable<int> HardwareNeededId { get; set; }
        public Nullable<int> PhysicalSystemAccessId { get; set; }
        public Nullable<int> HardwareSoftwareIssuedId { get; set; }
        public Nullable<int> InfoSecTrainingCompletedId { get; set; }
        public Nullable<int> TravelRequiredId { get; set; }
        public Nullable<int> ComplianceRiskId { get; set; }
        public Nullable<int> MSAId { get; set; }
        public Nullable<int> SOWId { get; set; }
        public Nullable<int> NewSupplierPacketId { get; set; }
        public Nullable<int> BackgroundCheckCompletedId { get; set; }
        public Nullable<int> PriorityId { get; set; }
        public Nullable<int> ContractLengthId { get; set; }
        public string Choice { get; set; }
    }
}
