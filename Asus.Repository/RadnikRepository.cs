using Asus.CoreBusiness.Model;
using Asus.CoreBusiness.Service;
using Asus.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository
{
    public class RadnikRepository : IRadnikRepository
    {
        public bool IzmeniRadnika(Radnik radnik, int id)
        {
            return ApiService.IzmeniRadnika(radnik, id);
        }

        public bool KreirajRadnika(Radnik Radnik)
        {
            return ApiService.KreirajRadnik(Radnik);
        }

        public bool ObrisiRadnika(int id)
        {
            return ApiService.ObrisiRadnika(id);
        }

        public Radnik PronadjiRadnika(int id)
        {
            return ApiService.PronadjiRadnika(id);
        }
    }
}
