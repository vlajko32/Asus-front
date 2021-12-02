using Asus.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases.iUseCases
{
    public interface iProizvodUseCase
    {
        Proizvod vratiProizvod(int sifraProizvoda);
    }
}
