using NewVendor.Entity;
using NewVendor.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewVendor.Service.Implementation
{
    public class NewVendorService : INewVendorServices
    {
        private readonly ApplicationDBContext _context;
        public NewVendorService(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task CreateAsync(VendorRequest req)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int req)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendorRequest> GetAll()
        {
            throw new NotImplementedException();
        }

        public VendorRequest GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(VendorRequest req)
        {
            throw new NotImplementedException();
        }
    }
}
