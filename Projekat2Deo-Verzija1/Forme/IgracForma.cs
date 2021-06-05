﻿using Projekat2Deo_Verzija1.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat2Deo_Verzija1.Forme
{
    public partial class IgracForma : Form
    {
        public IgracForma()
        {
            InitializeComponent();
        }

        public IgracForma(Igrac i)
        {
            InitializeComponent();
            UcitajPodatke(i);
        }

        private void UcitajPodatke(Igrac i)
        {
            lblIme.Text = i.Ime;
            lblPrezime.Text = i.Prezime;
            lblPol.Text = i.Pol.ToString();
            lblUzrast.Text = i.Uzrast.ToString();
            lblNadimakServer.Text = $"{i.Nadimak}@{i.PovezanNaServer.Naziv}";


            lblRasa.Text = i.KontroliseLika.GetType().Name;
            lblZlato.Text = i.KontroliseLika.KolicinaZlata.ToString();
            lblIskustvo.Text = i.KontroliseLika.Iskustvo.ToString();
            lblZdravlje.Text = i.KontroliseLika.Zdravlje.ToString();
            lblZamor.Text = i.KontroliseLika.StepenZamora.ToString();
            if (lblRasa.Text == "Čovek")
                lblSpecAtr.Text = i.KontroliseLika.VestinaSkrivanja.ToString();
            else if(lblRasa.Text == "Patuljak" || lblRasa.Text == "Ork")
                lblSpecAtr.Text = i.KontroliseLika.TipOruzja.ToString();
            else
                lblSpecAtr.Text = i.KontroliseLika.Mana.ToString();

            if (i.PripadaAlijansi != null)
                lblAlijansa.Text = i.PripadaAlijansi.Naziv;

            if(i.KontroliseLika.Segrti.Count > 0)
            {
                foreach(Segrt s in i.KontroliseLika.Segrti)
                {
                    listTrenutniSegrti.Items.Add(s);
                }
            }

            if(i.KontroliseLika.Oprema.Count > 0)
            {
                foreach(Oprema o in i.KontroliseLika.Oprema)
                {
                    listInventar.Items.Add(o);
                }
            }

            if(i.IndividualniZadaci.Count > 0)
            {
                foreach(IndividualniZadaci iz in i.IndividualniZadaci)
                {
                    listIndividualniZadaci.Items.Add(iz);
                }
            }

            List<DTOs.SegrtBasic> segrti = DTOManager.VratiSegrte();
            foreach(DTOs.SegrtBasic seg in segrti)
            {
                listSegrti.Items.Add(seg);
            }

            List<DTOs.AlijansaBasic> alijanse = DTOManager.VratiAlijanse();
            foreach(DTOs.AlijansaBasic a in alijanse)
            {
                listAlijanse.Items.Add(a);
            }
            
        }

        private void IgracForma_Load(object sender, EventArgs e)
        {

        }

        
    }
}
