﻿using Asus.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asus.Repository.iRepo
{
    public interface iKupacRepository
    {
        Kupac PronadjiKupca(string PiB);
    }
}
