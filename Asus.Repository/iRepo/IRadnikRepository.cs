using Asus.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository.iRepo
{
    public interface IRadnikRepository
    {
        bool KreirajRadnika(Radnik Radnik);

        Radnik PronadjiRadnika(int id);

        bool ObrisiRadnika(int id);

        bool IzmeniRadnika(Radnik radnik, int id);
    }
}
