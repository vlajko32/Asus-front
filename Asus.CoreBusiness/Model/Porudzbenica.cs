using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.CoreBusiness.Model
{
    public class Porudzbenica
    {

        public int porudzbenicaID { get; set; }

        public DateTime datumPor { get; set; }

        public string PiB { get; set; }

        public int sifraRadnika { get; set; }

        public List<StavkaPorudzbenice> stavkePorudzbenice { get; set; }

    }
}
