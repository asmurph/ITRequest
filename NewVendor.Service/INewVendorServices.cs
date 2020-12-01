using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewVendor.Entity;
namespace NewVendor.Service
{
   public  interface INewVendorServices
    {
        Task CreateAsync(VendorRequest req);
        VendorRequest GetById(int Id);
        Task UpdateAsync(int id);
        Task UpdateAsync(VendorRequest req);
        Task Delete(int req);
        IEnumerable<VendorRequest> GetAll();
    }
}
