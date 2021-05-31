﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Projekat2Deo_Verzija1.Entiteti;
using FluentNHibernate.Conventions.Helpers;

namespace Projekat2Deo_Verzija1.Mapiranja
{
    public class IgracMapiranja : ClassMap<Igrac>
    {
        public IgracMapiranja()
        {
            Table("IGRAČ");

            Id(i => i.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(i => i.Nadimak);
            Map(i => i.Lozinka);
            Map(i => i.Ime, "Ime");
            Map(i => i.Prezime);
            Map(i => i.Pol);
            Map(i => i.Uzrast);
            Map(i => i.VremePovezivanja, "Vreme_povezivanja");
            Map(i => i.VremeOdjavljivanja, "Vreme_odjavljivanja");
            Map(i => i.BrojPoenaUSesiji, "Broj_poena_u_sesiji");
            Map(i => i.KolicinaZlataUSesiji, "Količina_zlata_u_sesiji");

            //mapiranje veze 1:N Igrac - Server
            //LazyLoad() i da nije naveden postojace
            //Not.LazyLoad() ovim gasimo LazyLoad
            References(i => i.PovezanNaServer).Column("Id_Servera").LazyLoad();
            References(i => i.PripadaAlijansi).Column("Naziv_alijanse").LazyLoad();

            //mapiranje 1:1
            //HasOne(i => i.KontroliseLika).PropertyRef(i => i.Id).LazyLoad(); /*ne funkcionise iz nekog razloga*/
            References(i => i.KontroliseLika).Column("Id_Lika").LazyLoad();

            HasMany(i => i.IndividualniZadaci).KeyColumn("Id_zadatka").LazyLoad().Cascade.All().Inverse();
        }
    }
}
