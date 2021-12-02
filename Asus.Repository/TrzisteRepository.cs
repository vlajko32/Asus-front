using Asus.CoreBusiness.Model;
using Asus.CoreBusiness.Service;
using Asus.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository
{
    public class TrzisteRepository : ITrzisteRepository
    {
        public List<Trziste> VratiTrzista()
        {
            return ApiService.GetTrzista();
        }
    }
}
