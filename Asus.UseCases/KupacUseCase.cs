using Asus.CoreBusiness.Model;
using Asus.Repository;
using Asus.Repository.iRepo;
using Asus.UseCases.iUseCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases
{
    public class KupacUseCase : iKupacUseCase
    {
        private readonly iKupacRepository KupacRepository;

        public KupacUseCase(iKupacRepository KupacRepository)
        {
            this.KupacRepository = KupacRepository;
        }
        public Kupac pronadjiKupca(string PiB)
        {
            return KupacRepository.PronadjiKupca(PiB);
        }
    }
}
