using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.CoreBusiness.Model
{
    public class StavkaPorudzbenice
    {
        public int stavkaPorudzbenicceID { get; set; }

        public int porudzbenicaID { get; set; }

        public int kolicina { get; set; }

        public int SifraProizvoda { get; set; }

        public string NazivModela { get; set; }

        public string status { get; set; }


        public int rbStavke { get; set; }


    }
}
