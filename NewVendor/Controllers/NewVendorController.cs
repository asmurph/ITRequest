using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewVendor.Persistence;
using NewVendor.Service;

namespace NewVendor.Controllers
{
    public class NewVendorController : Controller
    {
        private readonly ApplicationDBContext _appContext;
        private readonly IRequestTypeService _reqType;

        public NewVendorController(ApplicationDBContext context, IRequestTypeService requestTypeService)
        {
            _appContext = context;
            _reqType = requestTypeService;
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
