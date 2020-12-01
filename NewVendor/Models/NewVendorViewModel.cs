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
        public string Role_Title { get; set; }
        public string Product_Service { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Owner_Manager { get; set; }
        public string TotalCost { get; set; }
        public string AnnualCost { get; set; }
        public string PO_ { get; set; }
        public string Cost_Center { get; set; }
        public string Business_Justification { get; set; }
        public string Contract_Title { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Contract_Length { get; set; }
        public Nullable<System.DateTime> Renewal_Date_Notice { get; set; }
        public string Termination_Notice__Days_ { get; set; }
        public string Law_Location { get; set; }
        public string Notes { get; set; }
        public string IT_Ticket_ { get; set; }
        public string Comments { get; set; }
        public string Asset_Manager { get; set; }
        public Nullable<System.DateTime> Asset_Manager_Approved_On { get; set; }
        public string Desktop_Arch { get; set; }
        public Nullable<System.DateTime> Desktop_Arch_Approved_On { get; set; }
        public string Facilities { get; set; }
        public Nullable<System.DateTime> Facilities_Approved_On { get; set; }
        public string Finance { get; set; }
        public Nullable<System.DateTime> Finance_Approved_On { get; set; }
        public string InfoSec { get; set; }
        public Nullable<System.DateTime> InfoSec_Approved_On { get; set; }
        public string Legal { get; set; }
        public Nullable<System.DateTime> Legal_Approved_On { get; set; }
        public string Compliance { get; set; }
        public Nullable<System.DateTime> Compliance_Approved_On { get; set; }
        public string Sourcing { get; set; }
        public Nullable<System.DateTime> Sourcing_Approved_On { get; set; }
        public string Confidential_Info { get; set; }
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
    }
}
