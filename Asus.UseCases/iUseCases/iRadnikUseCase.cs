using Asus.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases.iUseCases
{
    public interface iRadnikUseCase
    {
        bool kreirajRadnik(Radnik Radnik);

        Radnik PronadjiRadnika(int id);

        bool izmeniRadnik(Radnik radnik, int id);

        bool obrisiRadnika(int id);
    }
}
