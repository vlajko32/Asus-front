using Asus.CoreBusiness.Model;
using Asus.Repository.iRepo;
using Asus.UseCases.iUseCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases
{
    public class TrzisteUseCase : iTrzisteUseCase
    {
        private readonly ITrzisteRepository trzisteRepository;

        public TrzisteUseCase(ITrzisteRepository trzisteRepository)
        {
            this.trzisteRepository = trzisteRepository;
        }
        public List<Trziste> vratiTrzista()
        {
            return trzisteRepository.VratiTrzista();
        }
    }
}
