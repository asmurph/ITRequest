using NewVendor.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewVendor.Service
{
  public  interface IRequestTypeService
    {
        public List<RequestType> GetRt();
    }
}
