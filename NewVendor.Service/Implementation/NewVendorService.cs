using NewVendor.Entity;
using NewVendor.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace NewVendor.Service.Implementation
{
    public class NewVendorService : INewVendorServices
    {
        private readonly ApplicationDBContext _context;
        public NewVendorService(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(VendorRequest req)
        {
            await _context.VendorRequest.AddAsync(req);
            await _context.SaveChangesAsync();
          
        }

        public async Task Delete(int Id)
        {
            var reqs = GetById(Id);
            _context.Remove(reqs);
            await _context.SaveChangesAsync();
        
        }

        public IEnumerable<VendorRequest> GetAll() => _context.VendorRequest;
       
        public VendorRequest GetById(int Id) => _context.VendorRequest.Where(m => m.Id == Id).FirstOrDefault();
       

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
