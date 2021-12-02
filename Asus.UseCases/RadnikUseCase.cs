using Asus.CoreBusiness.Model;
using Asus.Repository.iRepo;
using Asus.UseCases.iUseCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases
{
    public class RadnikUseCase : iRadnikUseCase
    {
        private readonly IRadnikRepository RadnikRepository;

        public RadnikUseCase(IRadnikRepository RadnikRepository)
        {
            this.RadnikRepository = RadnikRepository;
        }
        public bool izmeniRadnik(Radnik radnik, int id)
        {
            return RadnikRepository.IzmeniRadnika(radnik, id);
        }

        public bool kreirajRadnik(Radnik Radnik)
        {
            return RadnikRepository.KreirajRadnika(Radnik);
        }

        public bool obrisiRadnika(int id)
        {
            return RadnikRepository.ObrisiRadnika(id);
        }

        public Radnik PronadjiRadnika(int id)
        {
            return RadnikRepository.PronadjiRadnika(id);
        }
    }
}
