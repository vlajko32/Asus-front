using Asus.CoreBusiness.Model;
using Asus.CoreBusiness.Service;
using Asus.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository
{
    public class ProizvodRepository : iProizvodRepository
    {
        public Proizvod VratiProizvod(int sifraProizvoda)
        {
            return ApiService.VratiProizvod(sifraProizvoda);
        }
    }
}
