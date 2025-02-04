﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2Deo_Verzija1.Entiteti
{
    public class IndividualniZadaci
    {
        public virtual int Id { get; protected set; }
        public virtual Igrac IgracKojiResava { get; set; }
        public virtual Zadatak ZadatakKojiSeResava { get; set; }
        public virtual String VremeResavanja { get; set; }

        public override string ToString()
        {
            return $"{ZadatakKojiSeResava.BonusIskustva} {VremeResavanja}";
        }
    }
}
