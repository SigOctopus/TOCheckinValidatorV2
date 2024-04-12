using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Allegati> Allegatis { get; set; }

    public virtual DbSet<Anagrafiche> Anagrafiches { get; set; }

    public virtual DbSet<Articoli> Articolis { get; set; }

    public virtual DbSet<ArticoliTipivar> ArticoliTipivars { get; set; }

    public virtual DbSet<Attivazioni> Attivazionis { get; set; }

    public virtual DbSet<Checkout> Checkouts { get; set; }

    public virtual DbSet<Cntcodstru> Cntcodstrus { get; set; }

    public virtual DbSet<Cntfatt> Cntfatts { get; set; }

    public virtual DbSet<Comande> Comandes { get; set; }

    public virtual DbSet<Comuni> Comunis { get; set; }

    public virtual DbSet<Conti> Contis { get; set; }

    public virtual DbSet<CoordrisorseX> Coordrisorsexes { get; set; }

    public virtual DbSet<CoordrisorseY> CoordrisorseYs { get; set; }

    public virtual DbSet<Coords0281O> Coords0281Os { get; set; }

    public virtual DbSet<CoordsDelfino1> CoordsDelfino1s { get; set; }

    public virtual DbSet<CoordsDelfino2> CoordsDelfino2s { get; set; }

    public virtual DbSet<CoordsDelfino3> CoordsDelfino3s { get; set; }

    public virtual DbSet<CoordsDiana1> CoordsDiana1s { get; set; }

    public virtual DbSet<CoordsDiana2> CoordsDiana2s { get; set; }

    public virtual DbSet<CoordsSolarium1> CoordsSolarium1s { get; set; }

    public virtual DbSet<CoordsSolarium2> CoordsSolarium2s { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<Couponemessi> Couponemessis { get; set; }

    public virtual DbSet<Datifatt> Datifatts { get; set; }

    public virtual DbSet<Dispoweb> Dispowebs { get; set; }

    public virtual DbSet<Ditte> Dittes { get; set; }

    public virtual DbSet<Dizionari> Dizionaris { get; set; }

    public virtual DbSet<GiorniNo> GiorniNos { get; set; }

    public virtual DbSet<Grtipologie> Grtipologies { get; set; }

    public virtual DbSet<Impostazioni> Impostazionis { get; set; }

    public virtual DbSet<Jaddress> Jaddresses { get; set; }

    public virtual DbSet<Jcard> Jcards { get; set; }

    public virtual DbSet<Jcharge> Jcharges { get; set; }

    public virtual DbSet<Jcustomer> Jcustomers { get; set; }

    public virtual DbSet<Joption> Joptions { get; set; }

    public virtual DbSet<Liste> Listes { get; set; }

    public virtual DbSet<Logbooking> Logbookings { get; set; }

    public virtual DbSet<Mappe> Mappes { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuServ> MenuServs { get; set; }

    public virtual DbSet<Menucombi> Menucombis { get; set; }

    public virtual DbSet<Nazioni> Nazionis { get; set; }

    public virtual DbSet<Nolettisdrai> Nolettisdrais { get; set; }

    public virtual DbSet<Operatori> Operatoris { get; set; }

    public virtual DbSet<Orariapertura> Orariaperturas { get; set; }

    public virtual DbSet<Ordini> Ordinis { get; set; }

    public virtual DbSet<Pagamenti> Pagamentis { get; set; }

    public virtual DbSet<PagamentiStripe> PagamentiStripes { get; set; }

    public virtual DbSet<Pagamentiol> Pagamentiols { get; set; }

    public virtual DbSet<Parametri> Parametris { get; set; }

    public virtual DbSet<ParametriApplicazione> ParametriApplicaziones { get; set; }

    public virtual DbSet<PeriodiNo> PeriodiNos { get; set; }

    public virtual DbSet<Prencli> Prenclis { get; set; }

    public virtual DbSet<Prenotazioni> Prenotazionis { get; set; }

    public virtual DbSet<Prenotazioniweb> Prenotazioniwebs { get; set; }

    public virtual DbSet<Prezziba> Prezzibas { get; set; }

    public virtual DbSet<Prezzibaori> Prezzibaoris { get; set; }

    public virtual DbSet<Prodottiordini> Prodottiordinis { get; set; }

    public virtual DbSet<Profilazioni> Profilazionis { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Restlog> Restlogs { get; set; }

    public virtual DbSet<RichiestaSaldo> RichiestaSaldos { get; set; }

    public virtual DbSet<Richiestaxto> Richiestaxtos { get; set; }

    public virtual DbSet<Riposiz> Riposizs { get; set; }

    public virtual DbSet<Risorse> Risorses { get; set; }

    public virtual DbSet<RisorseBkp> RisorseBkps { get; set; }

    public virtual DbSet<RisorseSolarium> RisorseSolaria { get; set; }

    public virtual DbSet<Rubrica> Rubricas { get; set; }

    public virtual DbSet<Scontimagg> Scontimaggs { get; set; }

    public virtual DbSet<Semaforo> Semaforos { get; set; }

    public virtual DbSet<Servizi> Servizis { get; set; }

    public virtual DbSet<Servizipren> Serviziprens { get; set; }

    public virtual DbSet<Stagioni> Stagionis { get; set; }

    public virtual DbSet<Strutture> Struttures { get; set; }

    public virtual DbSet<Strutturelc> Strutturelcs { get; set; }

    public virtual DbSet<Tavoli> Tavolis { get; set; }

    public virtual DbSet<Termattivi> Termattivis { get; set; }

    public virtual DbSet<Termoreg> Termoregs { get; set; }

    public virtual DbSet<Tipocabombr> Tipocabombrs { get; set; }

    public virtual DbSet<TipologiaPar> TipologiaPars { get; set; }

    public virtual DbSet<Tipologie> Tipologies { get; set; }

    public virtual DbSet<TipologieBooking> TipologieBookings { get; set; }

    public virtual DbSet<Traduzioni> Traduzionis { get; set; }

    public virtual DbSet<Trgcomande> Trgcomandes { get; set; }

    public virtual DbSet<Utenti> Utentis { get; set; }

    public virtual DbSet<Vincoli> Vincolis { get; set; }

    public virtual DbSet<ZzObject> ZzObjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.LogTo(Console.WriteLine);
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=tourdb; User Id=instantuser; Password=inde2019; TrustServerCertificate=true;");
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Allegati>(entity =>
        {
            entity.HasKey(e => new { e.Idanagrafica, e.Tipo, e.Codopz }).HasName("Allegati_PK");

            entity.ToTable("Allegati");

            entity.Property(e => e.Idanagrafica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_BIN")
                .HasColumnName("IDAnagrafica");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codopz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Inserisci alcuni esempi separati dal punto e virgo");
            entity.Property(e => e.Blob).HasColumnType("image");
            entity.Property(e => e.Download).HasColumnType("datetime");
            entity.Property(e => e.Nomefile)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdanagraficaNavigation).WithMany(p => p.Allegatis)
                .HasForeignKey(d => d.Idanagrafica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ANAGRAALLEGA");
        });

        modelBuilder.Entity<Anagrafiche>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ANAGRAFICHE_PK");

            entity.ToTable("ANAGRAFICHE");

            entity.HasIndex(e => new { e.CodStr, e.Modificato }, "ANAGRAFICHE_CODSTR_MOD");

            entity.HasIndex(e => e.FirebaseId, "Firebaseid");

            entity.HasIndex(e => e.Guidx, "Guidx");

            entity.HasIndex(e => new { e.CodStr, e.Codcli }, "NonClusteredIndex-20210512-185310");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_BIN")
                .HasColumnName("ID");
            entity.Property(e => e.Cap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAP");
            entity.Property(e => e.Cellulare)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.CodStr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cognome)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Comune)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Datains).HasColumnType("datetime");
            entity.Property(e => e.Datanasc).HasColumnType("datetime");
            entity.Property(e => e.Dataprivacyvista).HasColumnType("datetime");
            entity.Property(e => e.Datarilascio).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Fido)
                .HasDefaultValue(0.0)
                .HasColumnName("FIDO");
            entity.Property(e => e.FirebaseId)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("FirebaseID");
            entity.Property(e => e.Gruppo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Guidx)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Indip)
                .HasDefaultValue(0)
                .HasColumnName("INDIP");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Lastpren).HasColumnType("datetime");
            entity.Property(e => e.Luogonasc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Notex)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Numdoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Passwordx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passwordx");
            entity.Property(e => e.Pi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Push).HasColumnName("PUSH");
            entity.Property(e => e.PvNascita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Regione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sesso)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatoResidenza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CodStrNavigation).WithMany(p => p.Anagrafiches)
                .HasForeignKey(d => d.CodStr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTANAGRA");
        });

        modelBuilder.Entity<Articoli>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("Articoli_PK");

            entity.ToTable("Articoli");

            entity.HasIndex(e => new { e.CodArt, e.Codstr }, "IXUNIARTICOL").IsUnique();

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.CodArt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_ART");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descriz)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIZ");
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.PrCon)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PR_CON");
            entity.Property(e => e.PrPoco)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PR_POCO");
            entity.Property(e => e.PrSenza)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PR_SENZA");
            entity.Property(e => e.PrTanto)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PR_TANTO");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Articolis)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTARTICO");
        });

        modelBuilder.Entity<ArticoliTipivar>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("Articoli_tipivar_PK");

            entity.ToTable("Articoli_tipivar");

            entity.HasIndex(e => new { e.CodArt, e.Codstr, e.Tipo }, "IXUNIARTITIP").IsUnique();

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.CodArt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_ART");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.ArticoliTipivars)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUARTITIPO");
        });

        modelBuilder.Entity<Attivazioni>(entity =>
        {
            entity.HasKey(e => e.Idattivazion);

            entity.ToTable("Attivazioni");

            entity.Property(e => e.Idattivazion).HasColumnName("IDATTIVAZION");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Lettoattivaz).HasColumnName("LETTOATTIVAZ");
            entity.Property(e => e.Risposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RISPOSTA");
            entity.Property(e => e.Servizio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tessera)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TESSERA");

            entity.HasOne(d => d.Termoreg).WithMany(p => p.Attivazionis)
                .HasForeignKey(d => new { d.Codstr, d.Numpiazz })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TERMORATTIVA");

            entity.HasOne(d => d.Utenti).WithMany(p => p.Attivazionis)
                .HasForeignKey(d => new { d.Idutente, d.Codstr })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UTENTEATTIVA");
        });

        modelBuilder.Entity<Checkout>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Codblocco }).HasName("CHECKOUT_PK");

            entity.ToTable("CHECKOUT");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Codblocco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Idanagrafica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_BIN")
                .HasColumnName("idanagrafica");
            entity.Property(e => e.Modo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotivoPagamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pagato)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cntcodstru>(entity =>
        {
            entity.HasKey(e => new { e.Idcntcs, e.Codice }).HasName("PK__CNTCODST__0BFC2DFA23AD034E");

            entity.ToTable("CNTCODSTRU");

            entity.Property(e => e.Idcntcs).HasColumnName("IDCNTCS");
            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codice");
        });

        modelBuilder.Entity<Cntfatt>(entity =>
        {
            entity.HasKey(e => e.Idcnt).HasName("PK__CNTFATT__91A88673D66F0F5D");

            entity.ToTable("CNTFATT");

            entity.Property(e => e.Idcnt).HasColumnName("IDCNT");
            entity.Property(e => e.Barracnt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BARRACNT");
            entity.Property(e => e.Contatore).HasColumnName("CONTATORE");
            entity.Property(e => e.Nomecnt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMECNT");
        });

        modelBuilder.Entity<Comande>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Comande_PK");

            entity.ToTable("Comande", tb => tb.HasTrigger("TRIGCOMANDE"));

            entity.HasIndex(e => new { e.Data, e.Ora }, "Index-Data-Ora");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_BIN")
                .HasColumnName("ID");
            entity.Property(e => e.Cancellato).HasColumnName("CANCELLATO");
            entity.Property(e => e.CodArt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_ART");
            entity.Property(e => e.CodCli).HasColumnName("COD_CLI");
            entity.Property(e => e.CodStru)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_STRU");
            entity.Property(e => e.CodTess)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("COD_TESS");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Collegato).HasColumnName("COLLEGATO");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("DATA");
            entity.Property(e => e.Descriz)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIZ");
            entity.Property(e => e.Finito).HasColumnName("FINITO");
            entity.Property(e => e.Idpalm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDPALM");
            entity.Property(e => e.Menu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MENU");
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.NoteCons)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("NOTE_CONS");
            entity.Property(e => e.Numrig)
                .HasDefaultValue(0)
                .HasColumnName("numrig");
            entity.Property(e => e.Ora)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ORA");
            entity.Property(e => e.Origine)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparato).HasColumnName("PREPARATO");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO");
            entity.Property(e => e.Priorita).HasColumnName("PRIORITA");
            entity.Property(e => e.Qta).HasColumnName("QTA");
            entity.Property(e => e.Stampante).HasColumnName("STAMPANTE");
            entity.Property(e => e.Stampato).HasColumnName("STAMPATO");
            entity.Property(e => e.Tavolo).HasColumnName("TAVOLO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.VariaCod)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("VARIA_COD");
            entity.Property(e => e.Variante)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("VARIANTE");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Comandes)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTCOMAND");
        });

        modelBuilder.Entity<Comuni>(entity =>
        {
            entity.HasKey(e => e.Comune).HasName("comuni_PK");

            entity.ToTable("comuni");

            entity.Property(e => e.Comune)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cap");
            entity.Property(e => e.CapCitta).HasColumnName("cap_citta");
            entity.Property(e => e.Cf)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cf");
            entity.Property(e => e.Codice).HasColumnName("codice");
            entity.Property(e => e.ProvIstat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("prov_istat");
            entity.Property(e => e.Provincia)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Conti>(entity =>
        {
            entity.HasKey(e => new { e.Idrichiesta, e.Idconto }).HasName("PK__conti__B01CC9E7E43AD4B2");

            entity.ToTable("conti");

            entity.Property(e => e.Idrichiesta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("idrichiesta");
            entity.Property(e => e.Idconto).HasColumnName("idconto");
            entity.Property(e => e.Causale)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("causale");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Quanto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("quanto");
        });

        modelBuilder.Entity<CoordrisorseX>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordrisorseX");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeesteso");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordrisorseY>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordrisorseY");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomeEsteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<Coords0281O>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Coords0281O");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeesteso");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordsDelfino1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordsDelfino1");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordsDelfino2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordsDelfino2");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordsDelfino3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordsDelfino3");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordsDiana1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordsDiana1");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordsDiana2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordsDiana2");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordsSolarium1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordsSolarium1");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<CoordsSolarium2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coordsSolarium2");

            entity.Property(e => e.C)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("win");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Nomelist, e.Nomestag }).HasName("PK__COUPONS__2B52DE841A7422A9");

            entity.ToTable("COUPONS");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Nomelist)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NOMELIST");
            entity.Property(e => e.Nomestag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMESTAG");
            entity.Property(e => e.MaxSpesa)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("MAX_SPESA");
            entity.Property(e => e.MinSpesa)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("MIN_SPESA");
            entity.Property(e => e.Qta).HasColumnName("QTA");
            entity.Property(e => e.ScCorpo)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("SC_CORPO");
            entity.Property(e => e.ScPerc)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("SC_PERC");

            entity.HasOne(d => d.StrcodiceNavigation).WithMany(p => p.Coupons)
                .HasForeignKey(d => d.Strcodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTCOUPON");
        });

        modelBuilder.Entity<Couponemessi>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Coupon }).HasName("PK__COUPONEM__DE696A126FA32338");

            entity.ToTable("COUPONEMESSI");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Coupon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COUPON");
            entity.Property(e => e.Burned).HasColumnName("BURNED");
            entity.Property(e => e.Nomelist)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NOMELIST");
            entity.Property(e => e.Nomestag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMESTAG");
        });

        modelBuilder.Entity<Datifatt>(entity =>
        {
            entity.HasKey(e => e.Pi).HasName("DATIFATT_PK");

            entity.ToTable("DATIFATT");

            entity.Property(e => e.Pi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI");
            entity.Property(e => e.Cap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Inserisci")
                .HasColumnName("CAP");
            entity.Property(e => e.Cf)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.Codopz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("1234567890123456");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comune)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Abano Terme");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Nazione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Afghanistan");
            entity.Property(e => e.Notex)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Pec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PEC");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("AG");
            entity.Property(e => e.Ragsoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDI");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Datifatts)
                .HasForeignKey(d => d.Codstr)
                .HasConstraintName("STRUDATIFATT");
        });

        modelBuilder.Entity<Dispoweb>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Giorno, e.Tipologia, e.Capienza, e.Listino });

            entity.ToTable("DISPOWEB");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STRCODICE");
            entity.Property(e => e.Giorno)
                .HasColumnType("datetime")
                .HasColumnName("GIORNO");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOLOGIA");
            entity.Property(e => e.Capienza).HasColumnName("CAPIENZA");
            entity.Property(e => e.Listino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LISTINO");
            entity.Property(e => e.Bb).HasColumnName("BB");
            entity.Property(e => e.Caparraf)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("CAPARRAF");
            entity.Property(e => e.Caparrap)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("CAPARRAP");
            entity.Property(e => e.Chiuso).HasColumnName("CHIUSO");
            entity.Property(e => e.Difbooking).HasColumnName("DIFBOOKING");
            entity.Property(e => e.Diffbb)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DIFFBB");
            entity.Property(e => e.Difffb)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DIFFFB");
            entity.Property(e => e.Diffhb)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DIFFHB");
            entity.Property(e => e.Diffsp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DIFFSP");
            entity.Property(e => e.Dispreale).HasColumnName("DISPREALE");
            entity.Property(e => e.Fb).HasColumnName("FB");
            entity.Property(e => e.Hb).HasColumnName("HB");
            entity.Property(e => e.Minstay).HasColumnName("MINSTAY");
            entity.Property(e => e.Noarrival).HasColumnName("NOARRIVAL");
            entity.Property(e => e.Nodepart).HasColumnName("NODEPART");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO");
            entity.Property(e => e.Prezzo2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO2");
            entity.Property(e => e.Prezzo3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO3");
            entity.Property(e => e.Prezzo4)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO4");
            entity.Property(e => e.Prezzo5)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO5");
            entity.Property(e => e.Prezzo6)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO6");
            entity.Property(e => e.Prezzo7)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO7");
            entity.Property(e => e.Prezzo8)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO8");
            entity.Property(e => e.Prezzobb)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZOBB");
            entity.Property(e => e.Prezzoota)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZOOTA");
            entity.Property(e => e.Prezzootp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZOOTP");
            entity.Property(e => e.Prezzop)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZOP");
            entity.Property(e => e.Qta).HasColumnName("QTA");
            entity.Property(e => e.Sp).HasColumnName("SP");
        });

        modelBuilder.Entity<Ditte>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Codditta }).HasName("PK__Ditte__2AECDE3E71AA5DE2");

            entity.ToTable("Ditte");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Codditta).HasColumnName("codditta");
            entity.Property(e => e.Allotment).HasColumnName("allotment");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Ragsoc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ragsoc");

            entity.HasOne(d => d.StrcodiceNavigation).WithMany(p => p.Dittes)
                .HasForeignKey(d => d.Strcodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTDITTA");
        });

        modelBuilder.Entity<Dizionari>(entity =>
        {
            entity.HasKey(e => e.Italiano).HasName("DIZIONARI_PK");

            entity.ToTable("DIZIONARI");

            entity.Property(e => e.Italiano)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("italiano");
            entity.Property(e => e.Francese)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("francese");
            entity.Property(e => e.Inglese)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("inglese");
            entity.Property(e => e.Notex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("notex");
            entity.Property(e => e.Spagnolo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("spagnolo");
            entity.Property(e => e.Tedesco)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tedesco");
        });

        modelBuilder.Entity<GiorniNo>(entity =>
        {
            entity.HasKey(e => e.Idgn).HasName("PK__GiorniNo__B87DE22C03B01AF8");

            entity.ToTable("GiorniNo");

            entity.Property(e => e.Idgn).HasColumnName("IDGN");
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Dal).HasColumnName("DAL");
            entity.Property(e => e.Giorni)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CodiceNavigation).WithMany(p => p.GiorniNos)
                .HasForeignKey(d => d.Codice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTGIORNINO");
        });

        modelBuilder.Entity<Grtipologie>(entity =>
        {
            entity.HasKey(e => new { e.Gruppo, e.Strcodice }).HasName("grtipologie_PK");

            entity.ToTable("grtipologie");

            entity.Property(e => e.Gruppo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gruppo");
            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Estensione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estensione");
            entity.Property(e => e.Img).HasColumnType("image");
            entity.Property(e => e.Imggray)
                .HasColumnType("image")
                .HasColumnName("imggray");
            entity.Property(e => e.Imgorange)
                .HasColumnType("image")
                .HasColumnName("imgorange");
            entity.Property(e => e.Imgred).HasColumnType("image");
        });

        modelBuilder.Entity<Impostazioni>(entity =>
        {
            entity.HasKey(e => e.Keyimpostazi).HasName("IMPOSTAZIONI_PK");

            entity.ToTable("IMPOSTAZIONI");

            entity.Property(e => e.Keyimpostazi)
                .ValueGeneratedNever()
                .HasColumnName("KEYIMPOSTAZI");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codstr");
            entity.Property(e => e.Syncseimpost)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SYNCSEIMPOST");
        });

        modelBuilder.Entity<Jaddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("jaddress");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Bologna");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("BO");
            entity.Property(e => e.Line1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Via lanzichenecchi, 123");
            entity.Property(e => e.Line2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("40127");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Italy");
        });

        modelBuilder.Entity<Jcard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("jcard");

            entity.Property(e => e.AddressCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("IT");
            entity.Property(e => e.Cvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("808");
            entity.Property(e => e.ExpMonth).HasDefaultValue(12);
            entity.Property(e => e.ExpYear).HasDefaultValue(2021);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("giovanni poidomani");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("5555 5555 5555 4444");
        });

        modelBuilder.Entity<Jcharge>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("JCHARGE_PK");

            entity.ToTable("JCHARGE");

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.Amountjcharg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMOUNTJCHARG");
            entity.Property(e => e.Balatraidjch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BALATRAIDJCH");
            entity.Property(e => e.Capturjcharg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAPTURJCHARG");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Datajcharge)
                .HasColumnType("datetime")
                .HasColumnName("DATAJCHARGE");
            entity.Property(e => e.Descrijcharg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIJCHARG");
            entity.Property(e => e.Failcodejcha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAILCODEJCHA");
            entity.Property(e => e.Failmessjcha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAILMESSJCHA");
            entity.Property(e => e.Paidjcharge)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAIDJCHARGE");
            entity.Property(e => e.Statusjcharg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUSJCHARG");

            entity.HasOne(d => d.CodiceNavigation).WithMany(p => p.Jcharges)
                .HasForeignKey(d => d.Codice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTJCHARG");
        });

        modelBuilder.Entity<Jcustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("jcustomer");

            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("giopoi@hotmail.it");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("giopoi");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("555/1234567");
        });

        modelBuilder.Entity<Joption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("joptions");

            entity.Property(e => e.Amount).HasDefaultValue(50);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("mascherine chirurgiche");
            entity.Property(e => e.Importo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("EUR");
            entity.Property(e => e.ReceptEmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("giopoi@hotmail.it");
        });

        modelBuilder.Entity<Liste>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("Liste_PK");

            entity.ToTable("Liste");

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.Codice).HasColumnName("CODICE");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODSTR");
            entity.Property(e => e.Elemento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ELEMENTO");
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.Tipolislista)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOLISLISTA");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Listes)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTULISTA");
        });

        modelBuilder.Entity<Logbooking>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Nrig }).HasName("LOGBOOKING_PK");

            entity.ToTable("LOGBOOKING");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nrig).HasColumnName("NRig");
            entity.Property(e => e.TestoLog)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mappe>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("Mappe_PK");

            entity.ToTable("Mappe");

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.Blob).HasColumnType("image");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descrizmappa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIZMAPPA");
            entity.Property(e => e.Estensione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estensione");
            entity.Property(e => e.Hmappa).HasColumnName("HMAPPA");
            entity.Property(e => e.Nomefile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nomefile");
            entity.Property(e => e.RiduciSuMobile)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("S")
                .IsFixedLength();
            entity.Property(e => e.TestoHtml)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("TestoHTML");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("M")
                .HasColumnName("tipo");
            entity.Property(e => e.TipoSt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TipoST");
            entity.Property(e => e.Wmappa).HasColumnName("WMAPPA");

            entity.HasOne(d => d.CodiceNavigation).WithMany(p => p.Mappes)
                .HasForeignKey(d => d.Codice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTUMAPPA");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("Menu_PK");

            entity.ToTable("Menu");

            entity.HasIndex(e => new { e.Codstr, e.Tipomenu, e.CodDescr }, "IXUNIMENU").IsUnique();

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.CodDescr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_DESCR");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Combinato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMBINATO");
            entity.Property(e => e.Descriz)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIZ");
            entity.Property(e => e.GCritica).HasColumnName("G_CRITICA");
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.PercMezza).HasColumnName("PERC_MEZZA");
            entity.Property(e => e.Prezzo).HasColumnName("PREZZO");
            entity.Property(e => e.Priorita).HasColumnName("PRIORITA");
            entity.Property(e => e.Rapidomenu)
                .HasDefaultValue(0)
                .HasColumnName("RAPIDOMENU");
            entity.Property(e => e.Reparto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("REPARTO");
            entity.Property(e => e.Specifiche)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SPECIFICHE");
            entity.Property(e => e.Stampante).HasColumnName("STAMPANTE");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Tipomenu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOMENU");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Menus)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTURMENU");
        });

        modelBuilder.Entity<MenuServ>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Tipomenu, e.CodDescr }).HasName("PK__MenuServ__987B8AB65CD6CB2B");

            entity.ToTable("MenuServ");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Tipomenu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPOMENU");
            entity.Property(e => e.CodDescr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_DESCR");
            entity.Property(e => e.Descriz)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIZ");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.NonDisp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NON_DISP");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("PREZZO");
            entity.Property(e => e.Reparto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("REPARTO");
            entity.Property(e => e.Richqta).HasColumnName("RICHQTA");
            entity.Property(e => e.Specifiche)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Xgiorno).HasColumnName("XGIORNO");
            entity.Property(e => e.Xpersona).HasColumnName("XPERSONA");

            entity.HasOne(d => d.StrcodiceNavigation).WithMany(p => p.MenuServs)
                .HasForeignKey(d => d.Strcodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTSERVIZ");
        });

        modelBuilder.Entity<Menucombi>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("Menucombi_PK");

            entity.ToTable("Menucombi");

            entity.HasIndex(e => new { e.CodCombi, e.Codstr, e.Tipo, e.CodDescr }, "IXUNIMENUCOM").IsUnique();

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.CodCombi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_COMBI");
            entity.Property(e => e.CodDescr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_DESCR");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Menucombis)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTMENUCO");
        });

        modelBuilder.Entity<Nazioni>(entity =>
        {
            entity.HasKey(e => e.Nazione).HasName("nazioni_PK");

            entity.ToTable("nazioni");

            entity.Property(e => e.Nazione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cf)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("cf");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Codiceps)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("codiceps");
            entity.Property(e => e.GrpIstat)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("grp_istat");
            entity.Property(e => e.Iso3166)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("iso_3166");
            entity.Property(e => e.Lingua)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lingua");
            entity.Property(e => e.NomeIstat)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("nome_istat");
            entity.Property(e => e.OrdIstat).HasColumnName("ord_istat");
            entity.Property(e => e.Uic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("uic");
        });

        modelBuilder.Entity<Nolettisdrai>(entity =>
        {
            entity.HasKey(e => new { e.Codice, e.Tipologinols }).HasName("PK__NOLETTIS__45F42964A8C49A3A");

            entity.ToTable("NOLETTISDRAI");

            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Tipologinols)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPOLOGINOLS");
            entity.Property(e => e.Nolettinols).HasColumnName("NOLETTINOLS");
            entity.Property(e => e.Nosdraiols).HasColumnName("NOSDRAIOLS");
        });

        modelBuilder.Entity<Operatori>(entity =>
        {
            entity.HasKey(e => e.Op).HasName("OPERATORI_PK");

            entity.ToTable("OPERATORI");

            entity.Property(e => e.Op).HasColumnName("OP");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pro)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Operatoris)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTOPERAT");
        });

        modelBuilder.Entity<Orariapertura>(entity =>
        {
            entity.HasKey(e => e.Idorario).HasName("PK__ORARIAPE__8A2CF91E656C112C");

            entity.ToTable("ORARIAPERTURA");

            entity.Property(e => e.Idorario).HasColumnName("IDORARIO");
            entity.Property(e => e.Alleorario).HasColumnName("ALLEORARIO");
            entity.Property(e => e.Alorario).HasColumnName("ALORARIO");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Dalleorario).HasColumnName("DALLEORARIO");
            entity.Property(e => e.Dalorario).HasColumnName("DALORARIO");
            entity.Property(e => e.Giorniorario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GIORNIORARIO");
            entity.Property(e => e.Per).HasColumnName("PER");

            entity.HasOne(d => d.CodiceNavigation).WithMany(p => p.Orariaperturas)
                .HasForeignKey(d => d.Codice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTORARIO");
        });

        modelBuilder.Entity<Ordini>(entity =>
        {
            entity.HasKey(e => e.IdOrdine).HasName("ORDINI_PK");

            entity.ToTable("ORDINI");

            entity.Property(e => e.IdOrdine)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("idOrdine");
            entity.Property(e => e.DataAcquisto)
                .HasColumnType("datetime")
                .HasColumnName("dataAcquisto");
            entity.Property(e => e.IdPagamento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idPagamento");
            entity.Property(e => e.IdUtente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idUtente");
            entity.Property(e => e.MetodoFatturazione)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("metodoFatturazione");
            entity.Property(e => e.NoteCliente)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("noteCliente");
            entity.Property(e => e.NoteInterne)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("noteInterne");
            entity.Property(e => e.Prezzo).HasColumnName("prezzo");
            entity.Property(e => e.SistemaPagamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sistemaPagamento");
            entity.Property(e => e.Stato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stato");
            entity.Property(e => e.Struttura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("struttura");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
        });

        modelBuilder.Entity<Pagamenti>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Codblocco }).HasName("PK__Pagamenti");

            entity.ToTable("Pagamenti");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STRCODICE");
            entity.Property(e => e.Codblocco)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CODBLOCCO");
            entity.Property(e => e.Acconto).HasColumnName("ACCONTO");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Idpagamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDPAGAMENTO");
            entity.Property(e => e.Imponibile)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("IMPONIBILE");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.Nfatt).HasColumnName("NFATT");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("PREZZO");
            entity.Property(e => e.Tipopag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOPAG");
        });

        modelBuilder.Entity<PagamentiStripe>(entity =>
        {
            entity.HasKey(e => e.CodPi);

            entity.ToTable("PagamentiStripe");

            entity.Property(e => e.CodPi)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("COD_PI");
        });

        modelBuilder.Entity<Pagamentiol>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("PAGAMENTIOL_PK");

            entity.ToTable("PAGAMENTIOL");

            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Esito)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Jaddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Jcard)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Jcustom)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Joptions)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptUrl)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Strcod)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Parametri>(entity =>
        {
            entity.HasKey(e => e.Idprm).HasName("PARAMETRI_PK");

            entity.ToTable("PARAMETRI");

            entity.Property(e => e.Idprm)
                .ValueGeneratedNever()
                .HasColumnName("IDPRM");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Serverprm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVERPRM");
        });

        modelBuilder.Entity<ParametriApplicazione>(entity =>
        {
            entity.HasKey(e => new { e.Serie, e.Codice, e.Codstr }).HasName("ParametriApplicazione_PK");

            entity.ToTable("ParametriApplicazione");

            entity.Property(e => e.Serie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Codice).HasColumnName("codice");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CgpDescrizione)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("cgp_descrizione");
            entity.Property(e => e.Descestesa)
                .HasColumnType("text")
                .HasColumnName("descestesa");
            entity.Property(e => e.FlagTipo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flagTipo");
            entity.Property(e => e.Sequenza).HasColumnName("sequenza");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength()
                .HasColumnName("tipo_dato");
            entity.Property(e => e.Valore)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("valore");
        });

        modelBuilder.Entity<PeriodiNo>(entity =>
        {
            entity.HasKey(e => e.Idperiodo).HasName("PK__PeriodiN__A7A013496FB1F99D");

            entity.ToTable("PeriodiNo");

            entity.Property(e => e.Idperiodo).HasColumnName("IDPERIODO");
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Dal).HasColumnName("DAL");

            entity.HasOne(d => d.CodiceNavigation).WithMany(p => p.PeriodiNos)
                .HasForeignKey(d => d.Codice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTPERIODONO");
        });

        modelBuilder.Entity<Prencli>(entity =>
        {
            entity.HasKey(e => new { e.Codstr, e.Codopz, e.Codcli, e.Idcliente }).HasName("Prencli_PK");

            entity.ToTable("Prencli");

            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codopz)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Presente).HasColumnName("PRESENTE");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Prenclis)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTPRENCL");
        });

        modelBuilder.Entity<Prenotazioni>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRENOTAZIONI_PK");

            entity.ToTable("PRENOTAZIONI");

            entity.HasIndex(e => new { e.Codstr, e.Codopz }, "IXKEYUNPRENO").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_BIN")
                .HasColumnName("ID");
            entity.Property(e => e.Altririd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Checkin).HasColumnType("datetime");
            entity.Property(e => e.Checkout).HasColumnType("datetime");
            entity.Property(e => e.Codopz)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Datamodifica).HasColumnType("datetime");
            entity.Property(e => e.Guidx)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idanagrafica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_BIN")
                .HasColumnName("IDAnagrafica");
            entity.Property(e => e.Lingua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("italiano");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Targauto)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Tipopren)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Prenotazionis)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTPRENOT");

            entity.HasOne(d => d.IdanagraficaNavigation).WithMany(p => p.Prenotazionis)
                .HasForeignKey(d => d.Idanagrafica)
                .HasConstraintName("ANAGRAPRENOT");
        });

        modelBuilder.Entity<Prenotazioniweb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__prenotaz__3213E83F3E52440B");

            entity.ToTable("prenotazioniweb");

            entity.HasIndex(e => e.CodAllotm, "AllotmentIndex-20210720-130822");

            entity.HasIndex(e => e.Impegno, "Impegno_Index");

            entity.HasIndex(e => e.Padre, "pren_Padre");

            entity.HasIndex(e => new { e.Prezzo, e.Padre }, "pren_Prezzo");

            entity.HasIndex(e => e.A, "pren_a");

            entity.HasIndex(e => new { e.Da, e.A }, "pren_da");

            entity.HasIndex(e => e.Eliminata, "pren_eliminata");

            entity.HasIndex(e => e.Opzione, "pren_opzione");

            entity.HasIndex(e => e.Scade, "pren_scade");

            entity.HasIndex(e => e.StrCodice, "pren_str_codice");

            entity.HasIndex(e => e.StrCodice, "prenotazioni_FI_1");

            entity.HasIndex(e => e.RisCodice, "prenotazioni_FI_2");

            entity.HasIndex(e => new { e.StrCodice, e.RisCodice }, "str_codice_ris_codice");

            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.A).HasColumnName("a");
            entity.Property(e => e.CodAllotm).HasColumnName("cod_allotm");
            entity.Property(e => e.Coupon)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Da).HasColumnName("da");
            entity.Property(e => e.DaEliminare)
                .HasDefaultValue(0)
                .HasColumnName("da_eliminare");
            entity.Property(e => e.Esportata).HasColumnName("esportata");
            entity.Property(e => e.Idanagrafica)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDAnagrafica");
            entity.Property(e => e.Impegno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("impegno");
            entity.Property(e => e.Nopaga).HasColumnName("NOPAGA");
            entity.Property(e => e.Origine)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Padre)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.PagId)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Prezzo).HasColumnType("decimal(19, 6)");
            entity.Property(e => e.RisCodice)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ris_codice");
            entity.Property(e => e.Scade).HasColumnType("datetime");
            entity.Property(e => e.StrCodice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("str_codice");
        });

        modelBuilder.Entity<Prezziba>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Tipotarif, e.Dal, e.Al, e.Numg, e.Nomestag, e.Tipocab, e.Tipoombr, e.Incluse, e.Lettini, e.Sdraio }).HasName("PK__prezziba__5C864BDCD730DB9A");

            entity.ToTable("prezziba");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("strcodice");
            entity.Property(e => e.Tipotarif)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIPOTARIF");
            entity.Property(e => e.Dal).HasColumnName("DAL");
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Numg).HasColumnName("NUMG");
            entity.Property(e => e.Nomestag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NOMESTAG");
            entity.Property(e => e.Tipocab)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIPOCAB");
            entity.Property(e => e.Tipoombr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOOMBR");
            entity.Property(e => e.Incluse).HasColumnName("INCLUSE");
            entity.Property(e => e.Lettini).HasColumnName("LETTINI");
            entity.Property(e => e.Sdraio).HasColumnName("SDRAIO");
            entity.Property(e => e.Altrepers)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("ALTREPERS");
            entity.Property(e => e.Ammessa).HasColumnName("AMMESSA");
            entity.Property(e => e.Lettiniagg)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("LETTINIAGG");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("PREZZO");
            entity.Property(e => e.RidBamb)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("RID_BAMB");
            entity.Property(e => e.Sdraioagg)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("SDRAIOAGG");
            entity.Property(e => e.SedieAgg).HasColumnType("decimal(9, 2)");

            entity.HasOne(d => d.StrcodiceNavigation).WithMany(p => p.Prezzibas)
                .HasForeignKey(d => d.Strcodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pba_strutt2");
        });

        modelBuilder.Entity<Prezzibaori>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Dal, e.Al, e.Numg, e.Nomestag, e.Tipocab, e.Tipoombr, e.Incluse, e.Lettini, e.Sdraio }).HasName("PK__prezziba__F1F1AFD796D175CB");

            entity.ToTable("prezzibaori");

            entity.HasIndex(e => new { e.Nomestag, e.Tipocab, e.Tipoombr, e.Sdraio, e.Lettini, e.Ammessa, e.Strcodice, e.Incluse }, "NonClusteredIndex-20220628-130704");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("strcodice");
            entity.Property(e => e.Dal).HasColumnName("DAL");
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Numg).HasColumnName("NUMG");
            entity.Property(e => e.Nomestag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NOMESTAG");
            entity.Property(e => e.Tipocab)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIPOCAB");
            entity.Property(e => e.Tipoombr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOOMBR");
            entity.Property(e => e.Incluse).HasColumnName("INCLUSE");
            entity.Property(e => e.Lettini).HasColumnName("LETTINI");
            entity.Property(e => e.Sdraio).HasColumnName("SDRAIO");
            entity.Property(e => e.Altrepers)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("ALTREPERS");
            entity.Property(e => e.Ammessa).HasColumnName("AMMESSA");
            entity.Property(e => e.Lettiniagg)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("LETTINIAGG");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("PREZZO");
            entity.Property(e => e.RidBamb)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("RID_BAMB");
            entity.Property(e => e.Sdraioagg)
                .HasColumnType("decimal(19, 6)")
                .HasColumnName("SDRAIOAGG");
            entity.Property(e => e.SedieAgg).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Tipotarif)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIPOTARIF");

            entity.HasOne(d => d.StrcodiceNavigation).WithMany(p => p.Prezzibaoris)
                .HasForeignKey(d => d.Strcodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pba_strutt");
        });

        modelBuilder.Entity<Prodottiordini>(entity =>
        {
            entity.HasKey(e => new { e.IdOrdine, e.IdProdotto }).HasName("PRODOTTIORDINI_PK");

            entity.ToTable("PRODOTTIORDINI");

            entity.Property(e => e.IdOrdine)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("idOrdine");
            entity.Property(e => e.IdProdotto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idProdotto");
            entity.Property(e => e.NoteAggiuntive)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("noteAggiuntive");
            entity.Property(e => e.TipoProdotto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipoProdotto");
        });

        modelBuilder.Entity<Profilazioni>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("profilazioni_PK");

            entity.ToTable("profilazioni");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodCli).HasColumnName("codCli");
            entity.Property(e => e.CodStr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codStr");
            entity.Property(e => e.DataMod)
                .HasColumnType("datetime")
                .HasColumnName("dataMod");
            entity.Property(e => e.Profilo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("profilo");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.Sigla).HasName("province_PK");

            entity.ToTable("province");

            entity.Property(e => e.Sigla)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Restlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__restlog__3214EC276E58F92C");

            entity.ToTable("restlog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dataora)
                .HasColumnType("datetime")
                .HasColumnName("DATAORA");
            entity.Property(e => e.Params)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PARAMS");
            entity.Property(e => e.Richiesta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RICHIESTA");
        });

        modelBuilder.Entity<RichiestaSaldo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Richiest__3213E83F6E01572D");

            entity.ToTable("RichiestaSaldo");

            entity.HasIndex(e => e.StrCodice, "pren_id");

            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Cap).HasColumnName("cap");
            entity.Property(e => e.Cf)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("cf");
            entity.Property(e => e.Citta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("citta");
            entity.Property(e => e.Cognome)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gestita).HasColumnName("gestita");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("motivo");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Pagato).HasColumnName("pagato");
            entity.Property(e => e.PrenId)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("pren_id");
            entity.Property(e => e.Provincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("provincia");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.StrCodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("str_codice");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipologia");

            entity.HasOne(d => d.StrCodiceNavigation).WithMany(p => p.RichiestaSaldos)
                .HasForeignKey(d => d.StrCodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RichSaldo_FK_1");
        });

        modelBuilder.Entity<Richiestaxto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RichiesTO");

            entity.ToTable("RICHIESTAXTO");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gestita).HasColumnName("gestita");
            entity.Property(e => e.Risorse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rispobool).HasColumnName("rispobool");
            entity.Property(e => e.StrCodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("str_codice");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipologia");

            entity.HasOne(d => d.StrCodiceNavigation).WithMany(p => p.Richiestaxtos)
                .HasForeignKey(d => d.StrCodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RichTO_FK");
        });

        modelBuilder.Entity<Riposiz>(entity =>
        {
            entity.HasKey(e => e.Idrip).HasName("PK__RIPOSIZ__A686A16572C60C4A");

            entity.ToTable("RIPOSIZ");

            entity.Property(e => e.Idrip).HasColumnName("IDRIP");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Ordinerip).HasColumnName("ORDINERIP");
            entity.Property(e => e.Tiporip).HasColumnName("TIPORIP");

            entity.HasOne(d => d.CodiceNavigation).WithMany(p => p.Riposizs)
                .HasForeignKey(d => d.Codice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTRIPOSIZ");
        });

        modelBuilder.Entity<Risorse>(entity =>
        {
            entity.HasKey(e => new { e.Codice, e.Pgs, e.Strcodice }).HasName("risorse_PK");

            entity.ToTable("risorse");

            entity.HasIndex(e => new { e.Strcodice, e.Ordine }, "iOrdine");

            entity.HasIndex(e => e.Attivo, "risorse_attivo");

            entity.HasIndex(e => e.Pgs, "risorse_pgs");

            entity.HasIndex(e => e.Strcodice, "risorse_strcodice");

            entity.Property(e => e.Codice)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Pgs)
                .HasDefaultValue(1)
                .HasColumnName("PGS");
            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Attivo).HasColumnName("ATTIVO");
            entity.Property(e => e.Blu).HasColumnName("blu");
            entity.Property(e => e.Codopzione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codopzione");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descrizione");
            entity.Property(e => e.Green)
                .HasDefaultValue(197)
                .HasColumnName("green");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Img)
                .HasColumnType("image")
                .HasColumnName("img");
            entity.Property(e => e.Inmappa).HasColumnName("INMAPPA");
            entity.Property(e => e.Leftcl).HasColumnName("leftcl");
            entity.Property(e => e.Leftx).HasColumnName("leftx");
            entity.Property(e => e.Linkmappa).HasColumnName("linkmappa");
            entity.Property(e => e.MappaTo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mappaTO");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeesteso");
            entity.Property(e => e.Nomeicona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeicona");
            entity.Property(e => e.Ordine).HasColumnName("ORDINE");
            entity.Property(e => e.Prenotrisors)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRENOTRISORS");
            entity.Property(e => e.Prezzo)
                .HasColumnType("money")
                .HasColumnName("prezzo");
            entity.Property(e => e.Qta)
                .HasDefaultValue(1)
                .HasColumnName("qta");
            entity.Property(e => e.Red)
                .HasDefaultValue(254)
                .HasColumnName("red");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Generica")
                .HasColumnName("tipologia");
            entity.Property(e => e.Tiposervizio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tiposervizio");
            entity.Property(e => e.TopTo).HasColumnName("TopTO");
            entity.Property(e => e.Topcl).HasColumnName("topcl");
            entity.Property(e => e.Topx).HasColumnName("topx");
            entity.Property(e => e.Ultmodifica)
                .HasColumnType("datetime")
                .HasColumnName("ultmodifica");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<RisorseBkp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("risorseBkp");

            entity.Property(e => e.Attivo).HasColumnName("ATTIVO");
            entity.Property(e => e.Codice)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Codopzione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codopzione");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descrizione");
            entity.Property(e => e.Leftx).HasColumnName("leftx");
            entity.Property(e => e.Linkmappa).HasColumnName("linkmappa");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeesteso");
            entity.Property(e => e.Ordine).HasColumnName("ORDINE");
            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.Prezzo)
                .HasColumnType("money")
                .HasColumnName("prezzo");
            entity.Property(e => e.Qta).HasColumnName("qta");
            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Tiposervizio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tiposervizio");
            entity.Property(e => e.Topx).HasColumnName("topx");
        });

        modelBuilder.Entity<RisorseSolarium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("risorseSolarium");

            entity.Property(e => e.Attivo).HasColumnName("ATTIVO");
            entity.Property(e => e.Blu).HasColumnName("blu");
            entity.Property(e => e.Codice)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Codopzione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codopzione");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descrizione");
            entity.Property(e => e.Green).HasColumnName("green");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Img)
                .HasColumnType("image")
                .HasColumnName("img");
            entity.Property(e => e.Leftx).HasColumnName("leftx");
            entity.Property(e => e.Linkmappa).HasColumnName("linkmappa");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeesteso");
            entity.Property(e => e.Nomeicona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomeicona");
            entity.Property(e => e.Ordine).HasColumnName("ORDINE");
            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.Prezzo)
                .HasColumnType("money")
                .HasColumnName("prezzo");
            entity.Property(e => e.Qta).HasColumnName("qta");
            entity.Property(e => e.Red).HasColumnName("red");
            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Tiposervizio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tiposervizio");
            entity.Property(e => e.Topx).HasColumnName("topx");
            entity.Property(e => e.Ultmodifica)
                .HasPrecision(3)
                .HasColumnName("ultmodifica");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<Rubrica>(entity =>
        {
            entity.HasKey(e => e.Idrubrica).HasName("RUBRICA_PK");

            entity.ToTable("RUBRICA");

            entity.Property(e => e.Idrubrica).HasColumnName("IDRUBRICA");
            entity.Property(e => e.Cap).HasColumnName("CAP");
            entity.Property(e => e.Cognome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Comune)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Sigla)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Scontimagg>(entity =>
        {
            entity.HasKey(e => e.Idscmagg).HasName("PK__SCONTIMA__7947A72E778AC167");

            entity.ToTable("SCONTIMAGG");

            entity.Property(e => e.Idscmagg).HasColumnName("IDSCMAGG");
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Algiorno).HasColumnName("ALGIORNO");
            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Dal).HasColumnName("DAL");
            entity.Property(e => e.Scontomagg)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("SCONTOMAGG");
            entity.Property(e => e.Tipoblocco)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPOBLOCCO");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.CodiceNavigation).WithMany(p => p.Scontimaggs)
                .HasForeignKey(d => d.Codice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTSCMAGG");
        });

        modelBuilder.Entity<Semaforo>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.StrCodice }).HasName("PK__semaforo__E41ED835C9779C7E");

            entity.ToTable("semaforo");

            entity.Property(e => e.StrCodice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPren)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Servizi>(entity =>
        {
            entity.HasKey(e => new { e.Codstr, e.Numpiazz, e.Idutente, e.Codserv }).HasName("SERVIZI_PK");

            entity.ToTable("SERVIZI");

            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Servizio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.HasOne(d => d.Termoreg).WithMany(p => p.Servizis)
                .HasForeignKey(d => new { d.Codstr, d.Numpiazz })
                .HasConstraintName("TERMORSERVIZ");

            entity.HasOne(d => d.Utenti).WithMany(p => p.Servizis)
                .HasForeignKey(d => new { d.Idutente, d.Codstr })
                .HasConstraintName("UTENTESERVIZ");
        });

        modelBuilder.Entity<Servizipren>(entity =>
        {
            entity.HasKey(e => new { e.Strcodice, e.Tipomenu, e.CodDescr, e.Idpren }).HasName("PK__SERVIZIP__869F602205D8E0BE");

            entity.ToTable("SERVIZIPREN");

            entity.Property(e => e.Strcodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strcodice");
            entity.Property(e => e.Tipomenu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPOMENU");
            entity.Property(e => e.CodDescr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_DESCR");
            entity.Property(e => e.Idpren)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("idpren");
            entity.Property(e => e.Qta).HasColumnName("qta");

            entity.HasOne(d => d.MenuServ).WithMany(p => p.Serviziprens)
                .HasForeignKey(d => new { d.Strcodice, d.Tipomenu, d.CodDescr })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FromMenuSERV");
        });

        modelBuilder.Entity<Stagioni>(entity =>
        {
            entity.HasKey(e => new { e.Codice, e.Prodotto, e.Nomelist, e.Nomestag, e.Dal, e.Al, e.Giorno }).HasName("PK__stagioni__6270B34394909AAC");

            entity.ToTable("stagioni");

            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("codice");
            entity.Property(e => e.Prodotto)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PRODOTTO");
            entity.Property(e => e.Nomelist)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NOMELIST");
            entity.Property(e => e.Nomestag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NOMESTAG");
            entity.Property(e => e.Dal).HasColumnName("DAL");
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Ordine).HasColumnName("ORDINE");
        });

        modelBuilder.Entity<Strutture>(entity =>
        {
            entity.HasKey(e => e.Codice).HasName("STRUTTURE_PK");

            entity.ToTable("STRUTTURE");

            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Acconto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("acconto");
            entity.Property(e => e.Apertura).HasColumnName("apertura");
            entity.Property(e => e.AppOmbre).HasColumnName("APP_OMBRE");
            entity.Property(e => e.Appcomande).HasColumnName("APPCOMANDE");
            entity.Property(e => e.Camponote).HasColumnName("CAMPONOTE");
            entity.Property(e => e.Cap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAP");
            entity.Property(e => e.Chkauto).HasColumnType("datetime");
            entity.Property(e => e.Chkol).HasColumnType("datetime");
            entity.Property(e => e.CodiceMappa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commissione)
                .HasDefaultValue(200m)
                .HasColumnType("money");
            entity.Property(e => e.Commpercstru).HasColumnName("COMMPERCSTRU");
            entity.Property(e => e.Comune)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Conmappa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("C")
                .IsFixedLength();
            entity.Property(e => e.Conmappamobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Continofat).HasColumnName("continofat");
            entity.Property(e => e.CopiaFattIn)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("copia_fatt_in");
            entity.Property(e => e.Ctrgiac)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Disattiva).HasColumnName("disattiva");
            entity.Property(e => e.Disstagcumul).HasColumnName("DISSTAGCUMUL");
            entity.Property(e => e.Dxsx).HasColumnName("dxsx");
            entity.Property(e => e.Efattura).HasColumnName("efattura");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Endcomande)
                .HasDefaultValueSql("('19991231')")
                .HasColumnType("datetime")
                .HasColumnName("endcomande");
            entity.Property(e => e.Endservizi).HasColumnType("datetime");
            entity.Property(e => e.Estensione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estensioneimg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Finestraini).HasColumnName("FINESTRAINI");
            entity.Property(e => e.Gestextra).HasColumnName("GESTEXTRA");
            entity.Property(e => e.Ggacconto).HasColumnName("GGACCONTO");
            entity.Property(e => e.Homepage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImmagineStr).HasColumnType("image");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Informazioni)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Limite78).HasColumnName("limite78");
            entity.Property(e => e.ListinoWeb)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Log).HasColumnName("log");
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.Maxggpren).HasColumnName("maxggpren");
            entity.Property(e => e.Maxservizi).HasColumnName("maxservizi");
            entity.Property(e => e.MezzaGg).HasColumnName("MezzaGG");
            entity.Property(e => e.Mobilerapportoheight).HasColumnName("mobilerapportoheight");
            entity.Property(e => e.Mobilerapportomappa).HasColumnName("mobilerapportomappa");
            entity.Property(e => e.Mobilerapportowidth).HasColumnName("mobilerapportowidth");
            entity.Property(e => e.Mostrabank).HasColumnName("MOSTRABANK");
            entity.Property(e => e.NcCfCtrl).HasColumnName("nc_cf_ctrl");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Norisorsa).HasColumnName("norisorsa");
            entity.Property(e => e.Noteanag).HasColumnName("NOTEANAG");
            entity.Property(e => e.Numservizi).HasDefaultValue(0);
            entity.Property(e => e.Oggipren).HasColumnName("oggipren");
            entity.Property(e => e.Opzdasaldare).HasColumnName("opzdasaldare");
            entity.Property(e => e.Orafinmobile)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("orafinmobile");
            entity.Property(e => e.Ordrisasc).HasColumnName("ORDRISASC");
            entity.Property(e => e.Prenpark).HasColumnName("prenpark");
            entity.Property(e => e.Prevol).HasColumnType("datetime");
            entity.Property(e => e.PrivacyIt)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PrivacyIt2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Privacyde)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Privacyen)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Privacyfr)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Przacconto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRZACCONTO");
            entity.Property(e => e.Riposiziona).HasColumnName("riposiziona");
            entity.Property(e => e.Saldoattivo).HasColumnName("SALDOATTIVO");
            entity.Property(e => e.Scridincluso).HasColumnName("SCRIDINCLUSO");
            entity.Property(e => e.StripeTestKey)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Stripeapikey)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("stripeapikey");
            entity.Property(e => e.Tiparrotondam).HasColumnName("tiparrotondam");
            entity.Property(e => e.Tipostr).HasColumnName("TIPOSTR");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Urlregola)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLREGOLA");
            entity.Property(e => e.Verificasrv).HasColumnName("verificasrv");
        });

        modelBuilder.Entity<Strutturelc>(entity =>
        {
            entity.HasKey(e => e.Codice).HasName("PK__strutturelc");

            entity.ToTable("strutturelc");

            entity.Property(e => e.Codice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.LastChiamata)
                .HasColumnType("datetime")
                .HasColumnName("last_chiamata");
        });

        modelBuilder.Entity<Tavoli>(entity =>
        {
            entity.HasKey(e => e.Pgs).HasName("Tavoli_PK");

            entity.ToTable("Tavoli");

            entity.HasIndex(e => new { e.Tavolo, e.CodStru, e.Codstr }, "IXUNITAVOLO").IsUnique();

            entity.Property(e => e.Pgs).HasColumnName("PGS");
            entity.Property(e => e.CodCli).HasColumnName("COD_CLI");
            entity.Property(e => e.CodStru)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_STRU");
            entity.Property(e => e.CodTess)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("COD_TESS");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Collegato).HasColumnName("COLLEGATO");
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.Nomeesteso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMEESTESO");
            entity.Property(e => e.Nominativo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMINATIVO");
            entity.Property(e => e.Priprossimo).HasColumnName("priprossimo");
            entity.Property(e => e.Stato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATO");
            entity.Property(e => e.Tavolo).HasColumnName("TAVOLO");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Tavolis)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTTAVOLO");
        });

        modelBuilder.Entity<Termattivi>(entity =>
        {
            entity.HasKey(e => e.Deviceid).HasName("TERMATTIVI_PK");

            entity.ToTable("TERMATTIVI");

            entity.Property(e => e.Deviceid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idtel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ultrichiesta).HasColumnType("datetime");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Termattivis)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTERMATTI");
        });

        modelBuilder.Entity<Termoreg>(entity =>
        {
            entity.HasKey(e => new { e.Codstr, e.NumPiazz }).HasName("TERMOREG_PK");

            entity.ToTable("TERMOREG");

            entity.HasIndex(e => new { e.Codstr, e.Modificato }, "Indice_codstr_modificato");

            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttivaDal).HasColumnType("datetime");
            entity.Property(e => e.AttivaFinoAl).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ZonaClima1)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.ZonaClima2)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.ZonaClima3)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.ZonaClima4)
                .HasMaxLength(35)
                .IsUnicode(false);

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Termoregs)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTTERMOR");
        });

        modelBuilder.Entity<Tipocabombr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TIPOCABOMBR");

            entity.Property(e => e.Strcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STRCOD");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOLOGIA");
        });

        modelBuilder.Entity<TipologiaPar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipologi__3213E83F4C7A2C5A");

            entity.ToTable("tipologiaPar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Maxlettini).HasColumnName("maxlettini");
            entity.Property(e => e.Maxsdraio).HasColumnName("maxsdraio");
            entity.Property(e => e.Minlettini).HasColumnName("MINLETTINI");
            entity.Property(e => e.Minsdraio).HasColumnName("MINSDRAIO");
            entity.Property(e => e.StrCodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("str_codice");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tipologia");
        });

        modelBuilder.Entity<Tipologie>(entity =>
        {
            entity.HasKey(e => new { e.Tipologia, e.Codstr }).HasName("tipologie_PK");

            entity.ToTable("tipologie");

            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("9999");
            entity.Property(e => e.Attivo)
                .HasDefaultValue(1)
                .HasColumnName("ATTIVO");
            entity.Property(e => e.Codtipo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Estensione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estensione");
            entity.Property(e => e.Etaadulta).HasColumnName("ETAADULTA");
            entity.Property(e => e.Etaraga).HasColumnName("etaraga");
            entity.Property(e => e.EtichRaga)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Etichadulti)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ETICHADULTI");
            entity.Property(e => e.Etichbamb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ETICHBAMB");
            entity.Property(e => e.Etichnopaga)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ETICHNOPAGA");
            entity.Property(e => e.Img).HasColumnType("image");
            entity.Property(e => e.Imggray)
                .HasColumnType("image")
                .HasColumnName("imggray");
            entity.Property(e => e.Imgred).HasColumnType("image");
            entity.Property(e => e.Maxadulti).HasColumnName("MAXADULTI");
            entity.Property(e => e.Maxbambini).HasColumnName("MAXBAMBINI");
            entity.Property(e => e.Maxlettini).HasColumnName("MAXLETTINI");
            entity.Property(e => e.Maxraga).HasColumnName("maxraga");
            entity.Property(e => e.Maxsdraio).HasColumnName("MAXSDRAIO");
            entity.Property(e => e.Maxumani).HasColumnName("maxumani");
            entity.Property(e => e.Minlettini).HasColumnName("MINLETTINI");
            entity.Property(e => e.Minsdraio).HasColumnName("MINSDRAIO");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Tipologies)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTTIPOLO");
        });

        modelBuilder.Entity<TipologieBooking>(entity =>
        {
            entity.HasKey(e => new { e.StrCodice, e.Tipologia }).HasName("PK__tipologi__28039AF318CB293D");

            entity.ToTable("tipologieBooking");

            entity.Property(e => e.StrCodice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("str_codice");
            entity.Property(e => e.Tipologia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Codtipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CODTIPO");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Etaadulta).HasColumnName("etaadulta");
            entity.Property(e => e.Etaraga).HasColumnName("etaraga");
            entity.Property(e => e.EtichRaga)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Etichadulti)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ETICHADULTI");
            entity.Property(e => e.Etichbamb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ETICHBAMB");
            entity.Property(e => e.Etichnopaga)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ETICHNOPAGA");
            entity.Property(e => e.Maxadulti).HasColumnName("maxadulti");
            entity.Property(e => e.Maxbambini).HasColumnName("maxbambini");
            entity.Property(e => e.Maxlettini).HasColumnName("maxlettini");
            entity.Property(e => e.Maxraga).HasColumnName("maxraga");
            entity.Property(e => e.Maxsdraio).HasColumnName("maxsdraio");
            entity.Property(e => e.Maxumani).HasColumnName("maxumani");
            entity.Property(e => e.Minlettini).HasColumnName("MINLETTINI");
            entity.Property(e => e.Minsdraio).HasColumnName("MINSDRAIO");

            entity.HasOne(d => d.StrCodiceNavigation).WithMany(p => p.TipologieBookings)
                .HasForeignKey(d => d.StrCodice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tipologie_FK_1");
        });

        modelBuilder.Entity<Traduzioni>(entity =>
        {
            entity.HasKey(e => e.Italiano).HasName("TRADUZIONI_PK");

            entity.ToTable("TRADUZIONI");

            entity.Property(e => e.Italiano)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Francese)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Inglese)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Tedesco)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Trgcomande>(entity =>
        {
            entity.HasKey(e => e.Pgstric).HasName("TRGCOMANDE_PK");

            entity.ToTable("TRGCOMANDE");

            entity.HasIndex(e => e.Id, "TRGCOMANDE_ID");

            entity.Property(e => e.Pgstric).HasColumnName("PGSTRIC");
            entity.Property(e => e.Cancellato).HasColumnName("CANCELLATO");
            entity.Property(e => e.CodArt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_ART");
            entity.Property(e => e.CodStru)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COD_STRU");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Collegato).HasColumnName("COLLEGATO");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("DATA");
            entity.Property(e => e.Descriz)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIZ");
            entity.Property(e => e.Finito).HasColumnName("FINITO");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_BIN")
                .HasColumnName("ID");
            entity.Property(e => e.Idpalm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDPALM");
            entity.Property(e => e.Modificato).HasColumnName("MODIFICATO");
            entity.Property(e => e.Op)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OP");
            entity.Property(e => e.Ora)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ORA");
            entity.Property(e => e.Origine)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Preparato).HasColumnName("PREPARATO");
            entity.Property(e => e.Prezzo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PREZZO");
            entity.Property(e => e.Priorita).HasColumnName("PRIORITA");
            entity.Property(e => e.Qta).HasColumnName("QTA");
            entity.Property(e => e.Stampato).HasColumnName("STAMPATO");
            entity.Property(e => e.Tavolo).HasColumnName("TAVOLO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.VariaCod)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("VARIA_COD");
            entity.Property(e => e.Variante)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("VARIANTE");
        });

        modelBuilder.Entity<Utenti>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Codstr }).HasName("UTENTI_PK");

            entity.ToTable("UTENTI");

            entity.HasIndex(e => new { e.Nome, e.Codstr }, "IDXUNIVOUTEN").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gruppo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Passw)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PasswordCriptata)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Ruoloutente).HasColumnName("RUOLOUTENTE");
            entity.Property(e => e.Tipoutente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("U")
                .IsFixedLength()
                .HasColumnName("TIPOUTENTE");
        });

        modelBuilder.Entity<Vincoli>(entity =>
        {
            entity.HasKey(e => new { e.Tipologia, e.Codstr, e.Adulti, e.Ragazzi, e.Bambini }).HasName("vincoli_PK");

            entity.ToTable("Vincoli");

            entity.Property(e => e.Tipologia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipologia");
            entity.Property(e => e.Codstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("9999");
            entity.Property(e => e.Adulti).HasColumnName("ADULTI");
            entity.Property(e => e.Ragazzi).HasColumnName("RAGAZZI");
            entity.Property(e => e.Bambini).HasColumnName("BAMBINI");
            entity.Property(e => e.Lettini).HasColumnName("LETTINI");
            entity.Property(e => e.Sdraio).HasColumnName("SDRAIO");
            entity.Property(e => e.Sedie).HasColumnName("SEDIE");

            entity.HasOne(d => d.CodstrNavigation).WithMany(p => p.Vincolis)
                .HasForeignKey(d => d.Codstr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("STRUTTVINCOL");
        });

        modelBuilder.Entity<ZzObject>(entity =>
        {
            entity.HasKey(e => e.IObject).HasName("PK__ZZ_OBJEC__E6766E4333F4BFE0");

            entity.ToTable("ZZ_OBJECTS");

            entity.Property(e => e.IObject)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("I_OBJECT");
            entity.Property(e => e.Attrib)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ATTRIB");
            entity.Property(e => e.Ident)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("IDENT");
            entity.Property(e => e.PObject)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("P_OBJECT");
            entity.Property(e => e.RObject)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("R_OBJECT");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
