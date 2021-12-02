using Asus.CoreBusiness.Model;
using Asus.CoreBusiness.Service;
using Asus.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository
{
    public class KupacRepository : iKupacRepository
    {
        public Kupac PronadjiKupca(string PiB)
        {
            return ApiService.PronadjiKupca(PiB);
        }
    }
}
