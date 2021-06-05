﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekat2Deo_Verzija1.Entiteti;

namespace Projekat2Deo_Verzija1
{
    public class DTOs
    {
        #region Alijansa

        #region Pregled
        public class AlijansaPregled
        {
            public String Naziv;
            public int MaxIgraca;
            public int MinIgraca;
            public int BonusIskustvo;
            public int BonusZdravlje;

            public AlijansaPregled()
            {

            }

            public AlijansaPregled(String Naziv, int MaxIgraca, int MinIgraca, int BonusIskustvo, int BonusZdravlje)
            {
                this.Naziv = Naziv;
                this.MaxIgraca = MaxIgraca;
                this.MinIgraca = MinIgraca;
                this.BonusIskustvo = BonusIskustvo;
                this.BonusZdravlje = BonusZdravlje;
            }
        }

        #endregion

        #region Basic
        public class AlijansaBasic
        {
            public String Naziv;
            public int MaxIgraca;
            public int MinIgraca;
            public int BonusIskustvo;
            public int BonusZdravlje;

            public virtual IList<IgracBasic> Igraci { get; set; }
            public virtual IList<GrupniZadaciBasic> GrupniZadaci { get; set; }
            public virtual IList<SavezAlijansiBasic> AlijanseUSavezu { get; set; }

            public AlijansaBasic()
            {
                Igraci = new List<IgracBasic>();
                GrupniZadaci = new List<GrupniZadaciBasic>();
                AlijanseUSavezu = new List<SavezAlijansiBasic>();
            }

            public AlijansaBasic(String Naziv, int MaxIgraca, int MinIgraca, int BonusIskustvo, int BonusZdravlje)
            {
                this.Naziv = Naziv;
                this.MaxIgraca = MaxIgraca;
                this.MinIgraca = MinIgraca;
                this.BonusIskustvo = BonusIskustvo;
                this.BonusZdravlje = BonusZdravlje;
            }

            public override string ToString()
            {
                return $"{Naziv}  {MaxIgraca}  {MinIgraca}  {BonusIskustvo}  {BonusZdravlje}";
            }
        }
        #endregion

        #endregion

        #region Server

        #region Pregled
        public class ServerPregled
        {
            public int Id;
            public String Naziv;

            public ServerPregled()
            {

            }

            public ServerPregled(int id, String naziv)
            {
                this.Id = id;
                this.Naziv = naziv;
            }
        }
        #endregion

        #region Basic

        public class ServerBasic
        {
            public int Id;
            public String Naziv;

            public virtual IList<IgracBasic> Igraci { get; set; }

            public ServerBasic()
            {
                Igraci = new List<IgracBasic>();
            }

            public ServerBasic(int id, String naziv)
            {
                this.Id = id;
                this.Naziv = naziv;
                Igraci = new List<IgracBasic>();
            }

            public override string ToString()
            {
                return $"{this.Id}  {this.Naziv}";
            }
        }
        #endregion

        #endregion

        #region Igrac

        #region Pregled
        public class IgracPregled
        {
            public int Id;
            public String Nadimak;
            public String Lozinka;
            public String Ime;
            public String Prezime;
            public Char Pol;
            public int Uzrast;
            public DateTime VremePovezivanja;
            public DateTime VremeOdjavljivanja;
            public int BrojPoenaUSesiji;
            public int KolicinaZlataUSesiji;

            public IgracPregled()
            {

            }

            public IgracPregled(int id, String nadimak, String lozinka, String ime, String prezime, Char pol, int uzrast,
                DateTime vremePovezivanja, DateTime vremeOdjavljivanja, int brojPoenaUSesiji, int kolicinaZlataUSesiji)
            {
                this.Id = id;
                this.Nadimak = nadimak;
                this.Lozinka = lozinka;
                this.Ime = ime;
                this.Prezime = prezime;
                this.Pol = pol;
                this.Uzrast = uzrast;
                this.VremePovezivanja = vremePovezivanja;
                this.VremeOdjavljivanja = vremeOdjavljivanja;
                this.BrojPoenaUSesiji = brojPoenaUSesiji;
                this.KolicinaZlataUSesiji = kolicinaZlataUSesiji;
            }
        }
        #endregion

        #region Basic

        public class IgracBasic
        {
            public int Id;
            public String Nadimak;
            public String Lozinka;
            public String Ime;
            public String Prezime;
            public Char Pol;
            public int Uzrast;
            public DateTime VremePovezivanja;
            public DateTime VremeOdjavljivanja;
            public int BrojPoenaUSesiji;
            public int KolicinaZlataUSesiji;
            public ServerBasic PovezanNaServer;
            public AlijansaBasic PripadaAlijansi;
            public LikBasic KontroliseLika;

            public virtual IList<IndividualniZadaciBasic> IndividualniZadaci { get; set; }

            public IgracBasic()
            {
                IndividualniZadaci = new List<IndividualniZadaciBasic>();
            }

            public IgracBasic(int id, String nadimak, String lozinka, String ime, String prezime, Char pol, int uzrast,
                DateTime vremePovezivanja, DateTime vremeOdjavljivanja, int brojPoenaUSesiji, int kolicinaZlataUSesiji,
                ServerBasic server, AlijansaBasic alijansa, LikBasic lik)
            {
                this.Id = id;
                this.Nadimak = nadimak;
                this.Lozinka = lozinka;
                this.Ime = ime;
                this.Prezime = prezime;
                this.Pol = pol;
                this.Uzrast = uzrast;
                this.VremePovezivanja = vremePovezivanja;
                this.VremeOdjavljivanja = vremeOdjavljivanja;
                this.BrojPoenaUSesiji = brojPoenaUSesiji;
                this.KolicinaZlataUSesiji = kolicinaZlataUSesiji;
                this.PovezanNaServer = server;
                this.PripadaAlijansi = alijansa;
                this.KontroliseLika = lik;
            }

        }

        #endregion

        #endregion

        #region Lik

        #region Pregled
        public class LikPregled
        {
            public int Id;
            public int Iskustvo;
            public int StepenZamora;
            public int Zdravlje;
            public int KolicinaZlata;

            public LikPregled()
            {

            }

            public LikPregled(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata)
            {
                this.Id = id;
                this.Iskustvo = iskustvo;
                this.StepenZamora = stepenZamora;
                this.Zdravlje = zdravlje;
                this.KolicinaZlata = kolicinaZlata;
            }

            public class ČoverPregled : LikPregled
            {
                public int VestinaSkrivanja;

                public ČoverPregled(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata, 
                    int vestinaSkrivanja)
                    :base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.VestinaSkrivanja = vestinaSkrivanja;
                }
            }

            public class PatuljakPregled : LikPregled
            {
                public String TipOruzja;

                public PatuljakPregled(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    String tipOruzja)
                    :base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.TipOruzja = tipOruzja;
                }
            }

            public class OrkPregled : LikPregled
            {
                public String TipOruzja;

                public OrkPregled(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    String tipOruzja)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.TipOruzja = tipOruzja;
                }
            }

            public class VilenjakPregled : LikPregled
            {
                public int Mana;

                public VilenjakPregled(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    int mana)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.Mana = mana;
                }
            }

            public class DemonPregled : LikPregled
            {
                public int Mana;

                public DemonPregled(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    int mana)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.Mana = mana;
                }
            }
        }
        #endregion

        #region Basic

        public class LikBasic
        {
            public int Id;
            public int Iskustvo;
            public int StepenZamora;
            public int Zdravlje;
            public int KolicinaZlata;

            public virtual IList<SegrtBasic> Segrti { get; set; }

            public LikBasic()
            {
                Segrti = new List<SegrtBasic>();
            }

            public LikBasic(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata)
            {
                this.Id = id;
                this.Iskustvo = iskustvo;
                this.StepenZamora = stepenZamora;
                this.Zdravlje = zdravlje;
                this.KolicinaZlata = kolicinaZlata;
            }

            public override string ToString()
            {
                return $"{Id}  {Iskustvo}  {StepenZamora}  {Zdravlje}  {KolicinaZlata}";
            }

            public class ČoverBasic : LikBasic
            {
                public int VestinaSkrivanja;

                public ČoverBasic(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    int vestinaSkrivanja)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.VestinaSkrivanja = vestinaSkrivanja;
                }

                public override string ToString()
                 
                {
                    return $" {VestinaSkrivanja}";
                }
            }

            public class PatuljakBasic : LikBasic
            {
                public String TipOruzja;

                public PatuljakBasic(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    String tipOruzja)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.TipOruzja = tipOruzja;
                }

                public override string ToString()
                {
                    return $" {TipOruzja}";
                }
            }

            public class OrkBasic : LikBasic
            {
                public String TipOruzja;

                public OrkBasic(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    String tipOruzja)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.TipOruzja = tipOruzja;
                }
                public override string ToString()
                {
                    return $" {TipOruzja}";
                }
            }

            public class VilenjakBasic : LikBasic
            {
                public int Mana;

                public VilenjakBasic(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    int mana)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.Mana = mana;
                }
                public override string ToString()
                {
                    return $" {Mana}";
                }
            }

            public class DemonBasic : LikBasic
            {
                public int Mana;

                public DemonBasic(int id, int iskustvo, int stepenZamora, int zdravlje, int kolicinaZlata,
                    int mana)
                    : base(id, iskustvo, stepenZamora, zdravlje, kolicinaZlata)
                {
                    this.Mana = mana;
                }
                public override string ToString()
                {
                    return $" {Mana}";
                }
            }
        }

        #endregion

        #endregion

        #region Oprema

        #region Pregled

        public class OpremaPregled
        {
            public int Id;
            public ZadatakBasic Zadatak;

            public OpremaPregled()
            {

            }

            public OpremaPregled(int id, ZadatakBasic zadatak)
            {
                this.Id = id;
                this.Zadatak = zadatak;
            }
        }

        #endregion

        #region Basic

        public class OpremaBasic
        {
            public int Id;
            public ZadatakBasic Zadatak;

            public OpremaBasic()
            {

            }

            public OpremaBasic(int id, ZadatakBasic zadatak)
            {
                this.Id = id;
                this.Zadatak = zadatak;
            }
        }

        #endregion

        #endregion

        #region BonusPredmetiIOruzija

        #region Pregled

        public class BonusPredmetiIOruzijaPregled : OpremaPregled
        {
            public int BrojIskustvenihPoena;
            public String Rasa;
            public Char PPredmet;

            public BonusPredmetiIOruzijaPregled()
            {

            }

            public BonusPredmetiIOruzijaPregled(int brojIskustvenihPoena, String rasa, Char ppredmet)
            {
                this.BrojIskustvenihPoena = brojIskustvenihPoena;
                this.Rasa = rasa;
                this.PPredmet = ppredmet;
            }
        }

        #endregion

        #region Basic

        public class BonusPredmetiIOruzijaBasic : OpremaBasic
        {
            public int BrojIskustvenihPoena;
            public String Rasa;
            public Char PPredmet;

            public BonusPredmetiIOruzijaBasic()
            {

            }

            public BonusPredmetiIOruzijaBasic(int brojIskustvenihPoena, String rasa, Char ppredmet)
            {
                this.BrojIskustvenihPoena = brojIskustvenihPoena;
                this.Rasa = rasa;
                this.PPredmet = ppredmet;
            }

        }

        #endregion

        #endregion

        #region KljucniPredmeti

        #region Pregled

        public class KljucniPredmetiPregled : OpremaPregled
        {
            public String Naziv;
            public String Opis;
            public String NadimakVlasnika;

            public KljucniPredmetiPregled()
            {

            }

            public KljucniPredmetiPregled(String naziv, String opis, String nadimakVlasnika)
            {
                this.Naziv = naziv;
                this.Opis = opis;
                this.NadimakVlasnika = nadimakVlasnika;
            }
        }

        #endregion

        #region Basic

        public class KljucniPredmetiBasic : OpremaBasic
        {
            public String Naziv;
            public String Opis;
            public String NadimakVlasnika;

            public KljucniPredmetiBasic()
            {

            }

            public KljucniPredmetiBasic(String naziv, String opis, String nadimakVlasnika)
            {
                this.Naziv = naziv;
                this.Opis = opis;
                this.NadimakVlasnika = nadimakVlasnika;
            }
        }


        #endregion

        #endregion

        #region GrupniZadaci

        #region Pregled

        public class GrupniZadaciPregled
        {
            public int Id;
            public AlijansaPregled AlijansaKojaResava;
            public ZadatakPregled ZadatakKojiSeResava;
            public String VremeResavanja;

            public GrupniZadaciPregled()
            {

            }

            public GrupniZadaciPregled(int id, AlijansaPregled alijansa, ZadatakPregled zadatak, String vreme)
            {
                this.Id = id;
                this.AlijansaKojaResava = alijansa;
                this.ZadatakKojiSeResava = zadatak;
                this.VremeResavanja = vreme;
            }
        }

        #endregion

        #region Basic

        public class GrupniZadaciBasic
        {
            public int Id;
            public AlijansaBasic AlijansaKojaResava;
            public ZadatakBasic ZadatakKojiSeResava;
            public String VremeResavanja;

            public GrupniZadaciBasic()
            {

            }

            public GrupniZadaciBasic(int id, AlijansaBasic alijansa, ZadatakBasic zadatak, String vreme)
            {
                this.Id = id;
                this.AlijansaKojaResava = alijansa;
                this.ZadatakKojiSeResava = zadatak;
                this.VremeResavanja = vreme;
            }
        }

        #endregion

        #endregion

        #region IndividualniZadaci

        #region Pregled

        public class IndividualniZadaciPregled
        {
            public int Id;
            public IgracPregled IgracKojiResava;
            public ZadatakPregled ZadatakKojiSeResava;
            public String VremeResavanja;

            public IndividualniZadaciPregled()
            {

            }

            public IndividualniZadaciPregled(int id, IgracPregled igrac, ZadatakPregled zadatak, String vreme)
            {
                this.Id = id;
                this.IgracKojiResava = igrac;
                this.ZadatakKojiSeResava = zadatak;
                this.VremeResavanja = vreme;
            }
        }

        #endregion

        #region Basic

        public class IndividualniZadaciBasic
        {
            public int Id;
            public IgracBasic IgracKojiResava;
            public ZadatakBasic ZadatakKojiSeResava;
            public String VremeResavanja;

            public IndividualniZadaciBasic()
            {

            }

            public IndividualniZadaciBasic(int id, IgracBasic igrac, ZadatakBasic zadatak, String vreme)
            {
                this.Id = id;
                this.IgracKojiResava = igrac;
                this.ZadatakKojiSeResava = zadatak;
                this.VremeResavanja = vreme;
            }
        }

        #endregion

        #endregion

        #region SavezAlijansi

        #region Pregled

        public class SavezAlijansiPregled
        {
            public SavezAlijansiId Kljuc;

            public SavezAlijansiPregled()
            {

            }

            public SavezAlijansiPregled(SavezAlijansiId kljuc)
            {
                this.Kljuc = kljuc;
            }
        }

        #endregion

        #region Basic

        public class SavezAlijansiBasic
        {
            public SavezAlijansiIdBasic Kljuc;

            public SavezAlijansiBasic()
            {

            }

            public SavezAlijansiBasic(SavezAlijansiIdBasic kljuc)
            {
                this.Kljuc = kljuc;
            }
        }

        public class SavezAlijansiIdBasic
        {
            public AlijansaBasic NazivPrve { get; set; }
            public AlijansaBasic NazivDruge { get; set; }

            public SavezAlijansiIdBasic()
            {

            }
        }

        #endregion

        #endregion

        #region Segrt

        #region Pregled

        public class SegrtPregled
        {
            public SegrtId Id;
            public String Rasa;
            public int BonusUSkrivanju;

            public SegrtPregled()
            {

            }

            public SegrtPregled(SegrtId id, String rasa, int bonusUSkrivanju)
            {
                this.Id = id;
                this.Rasa = rasa;
                this.BonusUSkrivanju = bonusUSkrivanju;
            }
        }
        #endregion

        #region Basic

        public class SegrtBasic
        {
            public SegrtIdBasic Id;
            public String Rasa;
            public int BonusUSkrivanju;

            public SegrtBasic()
            {

            }

            public SegrtBasic(SegrtIdBasic id, String rasa, int bonusUSkrivanju)
            {
                this.Id = id;
                this.Rasa = rasa;
                this.BonusUSkrivanju = bonusUSkrivanju;
            }

            public override string ToString()
            {
                return $"{this.Id} {this.Rasa} {this.BonusUSkrivanju}";
            }
        }

        public class SegrtIdBasic
        {
            public LikBasic Gazda { get; set; }
            public String Ime;

            public SegrtIdBasic(LikBasic gazda, String imee)
            {
                Gazda = gazda;
                Ime = imee;
            }

            public override string ToString()
            {
                return $"{this.Gazda.Id} {this.Ime}";
            }
        }

        #endregion

        #endregion

        #region Zadatak

        #region Pregled

        public class ZadatakPregled
        {
            public int Id;
            public int BonusIskustva;

            public ZadatakPregled()
            {

            }

            public ZadatakPregled(int id, int bonus)
            {
                this.Id = id;
                this.BonusIskustva = bonus;
            }
        }

        #endregion

        #region Basic

        public class ZadatakBasic
        {
            public int Id;
            public int BonusIskustva;

            public virtual IList<GrupniZadaciBasic> Alijanse { get; set; }
            public virtual IList<IndividualniZadaciBasic> Igraci { get; set; }

            public ZadatakBasic()
            {
                Alijanse = new List<GrupniZadaciBasic>();
                Igraci = new List<IndividualniZadaciBasic>();
            }

            public ZadatakBasic(int id, int bonus)
            {
                this.Id = id;
                this.BonusIskustva = bonus;
            }
        }

        #endregion

        #endregion

    }
}
