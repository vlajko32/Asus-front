using Asus.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases.iUseCases
{
    public interface iPorudzbenicaUseCase
    {
        bool kreirajPorudzbenicu(Porudzbenica porudzbenica);

        Porudzbenica vratiPorudzbenicu(int sifraPorudzbenice);

        bool izmeniPorudzbenicu(Porudzbenica porudzbenica, int id);

        bool obrisiPorudzbenicu(int id);
    }
}
