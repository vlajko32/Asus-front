using Asus.CoreBusiness.Model;
using Asus.Repository.iRepo;
using Asus.UseCases.iUseCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases
{
    public class ProizvodUseCase : iProizvodUseCase
    {
        private readonly iProizvodRepository ProizvodRepository;

        public ProizvodUseCase(iProizvodRepository ProizvodRepository)
        {
            this.ProizvodRepository = ProizvodRepository;
        }

        public Proizvod vratiProizvod(int sifraProizvoda)
        {
            return ProizvodRepository.VratiProizvod(sifraProizvoda);
        }
    }
}
