using Asus.CoreBusiness.Model;
using Asus.Repository.iRepo;
using Asus.UseCases.iUseCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.UseCases
{
    public class PorudzbenicaUseCase : iPorudzbenicaUseCase
    {
        private readonly iPorudzbenicaRepository porudzbenicaRepository;

        public PorudzbenicaUseCase(iPorudzbenicaRepository porudzbenicaRepository)
        {
            this.porudzbenicaRepository = porudzbenicaRepository;
        }

        public bool izmeniPorudzbenicu(Porudzbenica porudzbenica, int id)
        {
            return porudzbenicaRepository.IzmeniPorudzbenicu(porudzbenica, id);
        }

        public bool kreirajPorudzbenicu(Porudzbenica porudzbenica)
        {
            return porudzbenicaRepository.KreirajPorudzbenicu(porudzbenica);
        }

        public bool obrisiPorudzbenicu(int id)
        {
            return porudzbenicaRepository.ObrisiPorudzbenicu(id);
        }

        public Porudzbenica vratiPorudzbenicu(int sifraPorudzbenice)
        {
            return porudzbenicaRepository.VratiPorudzbenicu(sifraPorudzbenice);
        }
    }
}
