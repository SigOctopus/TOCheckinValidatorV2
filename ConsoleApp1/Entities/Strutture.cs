using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities;

public partial class Strutture
{
    public string Codice { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string? Url { get; set; }

    public DateTime DataModifica { get; set; }

    public string? Email { get; set; }

    public string? CodiceMappa { get; set; }

    public int? Maxservizi { get; set; }

    public string? PrivacyIt { get; set; }

    public string? Privacyde { get; set; }

    public string? Privacyen { get; set; }

    public string? Privacyfr { get; set; }

    public string? Homepage { get; set; }

    public string? Stripeapikey { get; set; }

    public double? Mobilerapportowidth { get; set; }

    public double? Mobilerapportoheight { get; set; }

    public double? Mobilerapportomappa { get; set; }

    public byte[]? Logo { get; set; }

    public string? Estensione { get; set; }

    public int? Etaadulta { get; set; }

    public DateTime? Chkol { get; set; }

    public DateTime? Chkauto { get; set; }

    public DateTime? Prevol { get; set; }

    public int? Numservizi { get; set; }

    public DateTime? Endservizi { get; set; }

    public decimal Commissione { get; set; }

    public string Conmappa { get; set; } = null!;

    public string? PrivacyIt2 { get; set; }

    public string? StripeTestKey { get; set; }

    public double Commpercstru { get; set; }

    public DateTime? Endcomande { get; set; }

    public int? Pgsminiatura { get; set; }

    public string? Conmappamobile { get; set; }

    public string? Ctrgiac { get; set; }

    public string? Indirizzo { get; set; }

    public string? Comune { get; set; }

    public string? Cap { get; set; }

    public string? Provincia { get; set; }

    public byte[]? ImmagineStr { get; set; }

    public string? Estensioneimg { get; set; }

    public string? Nome { get; set; }

    public string? Informazioni { get; set; }

    public int? Dxsx { get; set; }

    public int Limite78 { get; set; }

    public int? Disattiva { get; set; }

    public int Maxggpren { get; set; }

    public int Prenpark { get; set; }

    public int Norisorsa { get; set; }

    public int Verificasrv { get; set; }

    public int Ordrisasc { get; set; }

    public int? Riposiziona { get; set; }

    public int? Oggipren { get; set; }

    public int? Tiparrotondam { get; set; }

    public int? Saldoattivo { get; set; }

    public string? CopiaFattIn { get; set; }

    public int? Efattura { get; set; }

    public int? NcCfCtrl { get; set; }

    public int? AppOmbre { get; set; }

    public int? Log { get; set; }

    public int? Tipostr { get; set; }

    public int? Finestra { get; set; }

    public int? Continofat { get; set; }

    public int? Opzdasaldare { get; set; }

    public DateOnly? Apertura { get; set; }

    public DateOnly? Chiusura { get; set; }

    public decimal? Acconto { get; set; }

    public short? Ggacconto { get; set; }

    public decimal? Przacconto { get; set; }

    public short? Fattura { get; set; }

    public short? Scontrino { get; set; }

    public short? Gestextra { get; set; }

    public short? Camponote { get; set; }

    public short? Noteanag { get; set; }

    public short? Finestraini { get; set; }

    public string? Orafinmobile { get; set; }

    public string? Urlregola { get; set; }

    public short? Disstagcumul { get; set; }

    public short? Appcomande { get; set; }

    public string? ListinoWeb { get; set; }

    public short? Mostrabank { get; set; }

    public short? MezzaGg { get; set; }

    public short? Scridincluso { get; set; }

    public virtual ICollection<Anagrafiche> Anagrafiches { get; set; } = new List<Anagrafiche>();

    public virtual ICollection<ArticoliTipivar> ArticoliTipivars { get; set; } = new List<ArticoliTipivar>();

    public virtual ICollection<Articoli> Articolis { get; set; } = new List<Articoli>();

    public virtual ICollection<Comande> Comandes { get; set; } = new List<Comande>();

    public virtual ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();

    public virtual ICollection<Datifatt> Datifatts { get; set; } = new List<Datifatt>();

    public virtual ICollection<Ditte> Dittes { get; set; } = new List<Ditte>();

    public virtual ICollection<GiorniNo> GiorniNos { get; set; } = new List<GiorniNo>();

    public virtual ICollection<Jcharge> Jcharges { get; set; } = new List<Jcharge>();

    public virtual ICollection<Liste> Listes { get; set; } = new List<Liste>();

    public virtual ICollection<Mappe> Mappes { get; set; } = new List<Mappe>();

    public virtual ICollection<MenuServ> MenuServs { get; set; } = new List<MenuServ>();

    public virtual ICollection<Menucombi> Menucombis { get; set; } = new List<Menucombi>();

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

    public virtual ICollection<Operatori> Operatoris { get; set; } = new List<Operatori>();

    public virtual ICollection<Orariapertura> Orariaperturas { get; set; } = new List<Orariapertura>();

    public virtual ICollection<PeriodiNo> PeriodiNos { get; set; } = new List<PeriodiNo>();

    public virtual ICollection<Prencli> Prenclis { get; set; } = new List<Prencli>();

    public virtual ICollection<Prenotazioni> Prenotazionis { get; set; } = new List<Prenotazioni>();

    public virtual ICollection<Prezzibaori> Prezzibaoris { get; set; } = new List<Prezzibaori>();

    public virtual ICollection<Prezziba> Prezzibas { get; set; } = new List<Prezziba>();

    public virtual ICollection<RichiestaSaldo> RichiestaSaldos { get; set; } = new List<RichiestaSaldo>();

    public virtual ICollection<Richiestaxto> Richiestaxtos { get; set; } = new List<Richiestaxto>();

    public virtual ICollection<Riposiz> Riposizs { get; set; } = new List<Riposiz>();

    public virtual ICollection<Scontimagg> Scontimaggs { get; set; } = new List<Scontimagg>();

    public virtual ICollection<Tavoli> Tavolis { get; set; } = new List<Tavoli>();

    public virtual ICollection<Termattivi> Termattivis { get; set; } = new List<Termattivi>();

    public virtual ICollection<Termoreg> Termoregs { get; set; } = new List<Termoreg>();

    public virtual ICollection<TipologieBooking> TipologieBookings { get; set; } = new List<TipologieBooking>();

    public virtual ICollection<Tipologie> Tipologies { get; set; } = new List<Tipologie>();

    public virtual ICollection<Vincoli> Vincolis { get; set; } = new List<Vincoli>();
}
