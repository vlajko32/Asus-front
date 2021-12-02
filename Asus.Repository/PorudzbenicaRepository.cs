using Asus.CoreBusiness.Model;
using Asus.CoreBusiness.Service;
using Asus.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository
{
    public class PorudzbenicaRepository : iPorudzbenicaRepository
    {
        public bool IzmeniPorudzbenicu(Porudzbenica porudzbenica, int id)
        {
            return ApiService.IzmeniPorudzbenicu(porudzbenica, id);
        }

        public bool KreirajPorudzbenicu(Porudzbenica porudzbenica)
        {
            return ApiService.KreirajPorudzbenicu(porudzbenica);
        }

        public bool ObrisiPorudzbenicu(int id)
        {
            return ApiService.ObrisiPorudzbenicu(id);
        }

        public Porudzbenica VratiPorudzbenicu(int sifraPorudzbenice)
        {
            return ApiService.VratiPorudzbenicu(sifraPorudzbenice);
        }
    }
}
