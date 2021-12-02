using Asus.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository.iRepo
{
    public interface iPorudzbenicaRepository
    {
        bool KreirajPorudzbenicu(Porudzbenica porudzbenica);

        Porudzbenica VratiPorudzbenicu(int sifraPorudzbenice);

        bool IzmeniPorudzbenicu(Porudzbenica porudzbenica, int id);

        bool ObrisiPorudzbenicu(int id);
    }

    
}
