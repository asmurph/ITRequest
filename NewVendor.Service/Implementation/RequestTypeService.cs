using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewVendor.Entity;
using NewVendor.Persistence;
using NewVendor.Service;

namespace NewVendor.Service.Implementation
{
    public class RequestTypeService : IRequestTypeService
    {
        private readonly ApplicationDBContext _context;
        public RequestTypeService(ApplicationDBContext context)
        {
            _context = context;
        }
        public List<RequestType> GetRt()
        {
            var reqTypes = _context.RequestTypes.ToList();
            return reqTypes;
        }
    }
}
