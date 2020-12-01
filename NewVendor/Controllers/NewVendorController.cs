using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewVendor.Persistence;
using NewVendor.Service;
using NewVendor.Models;
using NewVendor.Entity;

namespace NewVendor.Controllers
{
    public class NewVendorController : Controller
    {
        private readonly ApplicationDBContext _appContext;
        private readonly IRequestTypeService _reqType;
        private readonly INewVendorServices _newVendorServices;

        public NewVendorController(ApplicationDBContext context, IRequestTypeService requestTypeService, INewVendorServices newVendorServices)
        {
            _appContext = context;
            _reqType = requestTypeService;
            _newVendorServices = newVendorServices;
        }

        public IActionResult Index()
        {
            //var allReqs = _newVendorServices.GetAll().Select(reqs => new NewVendorViewModel
            //{
            //    Id = reqs.Id,
            //    Requester = reqs.Requester,
            //    //Location
            //    Folder = reqs.Folder,
            //    Role_Title = reqs.Role_Title,
            //    Description = reqs.Description,
            //    Owner_Manager = reqs.Owner_Manager,
            //    Business_Justification = reqs.Business_Justification
              
            //}).ToList();

            //return View(allReqs);
            var allreqs = (from vendReqs in _appContext.VendorRequest
                           //join desig in this._appContext.RequestType on vendReqs.RequestTypeId equals desig.RequestTypeId
                           //join loc in this._appContext.Location on vendReqs.LocationId equals loc.LocationId
                           select new NewVendorViewModel
                             {
                                 Id = vendReqs.Id,
                                 Requester = vendReqs.Requester,
                                 //RequestTypeId = vendReqs.RequestTypeId,
                                 //ServiceAreaId = vendReqs.ServiceAreaId,
                                 //BusinessUnitId = vendReqs.BusinessUnitId,
                                 Folder = vendReqs.Folder,
                                 RoleTitle = vendReqs.RoleTitle,
                                 Description = vendReqs.Description,
                             }).ToList();

            return View(allreqs);
        }

        [HttpGet]
        public IActionResult Create()
        {
          
            var reqTypes = _reqType.GetType();

            if (reqTypes != null)
            {

                ViewBag.RequestTypenames = reqTypes;
            }
        

            var model = new NewVendorViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //Prevents cross-site Request Forgery Attacks
        public async Task<IActionResult> Create(NewVendorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newVendorequest = new VendorRequest
                {
                    Id = model.Id,
                    Requester = model.Requester,
                    RequestTypeId = model.LocationId,
                    ServiceAreaId = model.ServiceAreaId,
                    BusinessUnitId = model.BusinessUnitId,
                    RegionId = model.RegionId,
                    Folder = model.Folder,
                    RoleTitle = model.RoleTitle,
                    Description = model.Description,
                    OwnerManager = model.Owner_Manager,
                    CurrencyId = model.CurrencyId,
                    BusinessJustification = model.BusinessJustification,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    ContractLengthId = model.ContractLengthId,
                    Created = DateTime.Now                };
                await _newVendorServices.CreateAsync(newVendorequest);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
