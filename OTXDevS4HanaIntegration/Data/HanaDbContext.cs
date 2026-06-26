using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using S4HanaIntegration.Models;

namespace S4HanaIntegration.Data;

public partial class HanaDbContext : DbContext
{
    public HanaDbContext(DbContextOptions<HanaDbContext> options)
        : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        ChangeTracker.AutoDetectChangesEnabled = false;
    }

    public virtual DbSet<Accession> Accessions { get; set; }

    public virtual DbSet<Activeviewoverride> Activeviewoverrides { get; set; }

    public virtual DbSet<Activeviewpreselect> Activeviewpreselects { get; set; }

    public virtual DbSet<Agentconfig> Agentconfigs { get; set; }

    public virtual DbSet<Agentschedule> Agentschedules { get; set; }

    public virtual DbSet<Agenttodolist> Agenttodolists { get; set; }

    public virtual DbSet<Aicontainer> Aicontainers { get; set; }

    public virtual DbSet<Alfilter> Alfilters { get; set; }

    public virtual DbSet<Archivedwork> Archivedworks { get; set; }

    public virtual DbSet<Archivedworkbase> Archivedworkbases { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Assignee> Assignees { get; set; }

    public virtual DbSet<Auditcollectionsitem> Auditcollectionsitems { get; set; }

    public virtual DbSet<BarcodeDatum> BarcodeData { get; set; }

    public virtual DbSet<BarcodeSeqnr> BarcodeSeqnrs { get; set; }

    public virtual DbSet<Bestbetsdatum> Bestbetsdata { get; set; }

    public virtual DbSet<Bestbetssearch> Bestbetssearches { get; set; }

    public virtual DbSet<Blobdatum> Blobdata { get; set; }

    public virtual DbSet<Blobresdatum> Blobresdata { get; set; }

    public virtual DbSet<Bravaredactreason> Bravaredactreasons { get; set; }

    public virtual DbSet<Bravathumb> Bravathumbs { get; set; }

    public virtual DbSet<Bravauser> Bravausers { get; set; }

    public virtual DbSet<Bravaversdatum> Bravaversdata { get; set; }

    public virtual DbSet<CasebaseSeqnr> CasebaseSeqnrs { get; set; }

    public virtual DbSet<Catregionmap> Catregionmaps { get; set; }

    public virtual DbSet<Ccm> Ccms { get; set; }

    public virtual DbSet<CcmLog> CcmLogs { get; set; }

    public virtual DbSet<CcmNumara> CcmNumaras { get; set; }

    public virtual DbSet<CcmTeminatcinsibakim> CcmTeminatcinsibakims { get; set; }

    public virtual DbSet<CcmTempDepartmanbakim> CcmTempDepartmanbakims { get; set; }

    public virtual DbSet<CcmTempHaricikullanicibakim> CcmTempHaricikullanicibakims { get; set; }

    public virtual DbSet<CcmTempHiyerarsibakim> CcmTempHiyerarsibakims { get; set; }

    public virtual DbSet<CcmTempHukuksorumlusubakim> CcmTempHukuksorumlusubakims { get; set; }

    public virtual DbSet<CcmTempKararbakim> CcmTempKararbakims { get; set; }

    public virtual DbSet<CcmTempKategoribakim> CcmTempKategoribakims { get; set; }

    public virtual DbSet<CcmTempKontratdurumbakim> CcmTempKontratdurumbakims { get; set; }

    public virtual DbSet<CcmTempKontratgecerliliksuresibakim> CcmTempKontratgecerliliksuresibakims { get; set; }

    public virtual DbSet<CcmTempKontratsorumlusubakim> CcmTempKontratsorumlusubakims { get; set; }

    public virtual DbSet<CcmTempKontratsurectipibakim> CcmTempKontratsurectipibakims { get; set; }

    public virtual DbSet<CcmTempKontratturubakim> CcmTempKontratturubakims { get; set; }

    public virtual DbSet<CcmTempOdemeseklibakim> CcmTempOdemeseklibakims { get; set; }

    public virtual DbSet<CcmTempOncelikbakim> CcmTempOncelikbakims { get; set; }

    public virtual DbSet<CcmTempOtomatikyenilemesuresibakim> CcmTempOtomatikyenilemesuresibakims { get; set; }

    public virtual DbSet<CcmTempParabirimibakim> CcmTempParabirimibakims { get; set; }

    public virtual DbSet<CcmTempSablonbakim> CcmTempSablonbakims { get; set; }

    public virtual DbSet<CcmTempSirketbakim> CcmTempSirketbakims { get; set; }

    public virtual DbSet<CcmTempSorulistesibakim> CcmTempSorulistesibakims { get; set; }

    public virtual DbSet<CcmTempSurecformbakim> CcmTempSurecformbakims { get; set; }

    public virtual DbSet<CcmTempWfdurumbakim> CcmTempWfdurumbakims { get; set; }

    public virtual DbSet<CcmV> CcmVs { get; set; }

    public virtual DbSet<CcmsendMailAttachTable> CcmsendMailAttachTables { get; set; }

    public virtual DbSet<CcmsendMailTable> CcmsendMailTables { get; set; }

    public virtual DbSet<CmbaseDuration> CmbaseDurations { get; set; }

    public virtual DbSet<CmbaseUpgradelog> CmbaseUpgradelogs { get; set; }

    public virtual DbSet<Collection> Collections { get; set; }

    public virtual DbSet<Collectionsdatum> Collectionsdata { get; set; }

    public virtual DbSet<Commcalendar> Commcalendars { get; set; }

    public virtual DbSet<Commcalendarrole> Commcalendarroles { get; set; }

    public virtual DbSet<Commini> Comminis { get; set; }

    public virtual DbSet<Commmember> Commmembers { get; set; }

    public virtual DbSet<Commmemberreq> Commmemberreqs { get; set; }

    public virtual DbSet<Commmetric> Commmetrics { get; set; }

    public virtual DbSet<Componentsetting> Componentsettings { get; set; }

    public virtual DbSet<ControlledviewingPrinting> ControlledviewingPrintings { get; set; }

    public virtual DbSet<Convertqueue> Convertqueues { get; set; }

    public virtual DbSet<CpdbCompanygroup> CpdbCompanygroups { get; set; }

    public virtual DbSet<CpdbCountry> CpdbCountries { get; set; }

    public virtual DbSet<CpdbLepa> CpdbLepas { get; set; }

    public virtual DbSet<CpdbSeqnr> CpdbSeqnrs { get; set; }

    public virtual DbSet<CpdbStateprovince> CpdbStateprovinces { get; set; }

    public virtual DbSet<Csappsstat> Csappsstats { get; set; }

    public virtual DbSet<Custodiansite> Custodiansites { get; set; }

    public virtual DbSet<CwscoreshareInstancecatattr> CwscoreshareInstancecatattrs { get; set; }

    public virtual DbSet<CwscoreshareInstancemapping> CwscoreshareInstancemappings { get; set; }

    public virtual DbSet<CwscoreshareTemplatecatattr> CwscoreshareTemplatecatattrs { get; set; }

    public virtual DbSet<CwscoreshareTemplatemapping> CwscoreshareTemplatemappings { get; set; }

    public virtual DbSet<Cwsteamshareinstancemapping> Cwsteamshareinstancemappings { get; set; }

    public virtual DbSet<Cwsteamsharetemplatemapping> Cwsteamsharetemplatemappings { get; set; }

    public virtual DbSet<CzmNumber> CzmNumbers { get; set; }

    public virtual DbSet<Dancestorschildcount> Dancestorschildcounts { get; set; }

    public virtual DbSet<Dancestorsmovenode> Dancestorsmovenodes { get; set; }

    public virtual DbSet<Dattribute> Dattributes { get; set; }

    public virtual DbSet<Dauditmore> Dauditmores { get; set; }

    public virtual DbSet<Dauditmorearchive> Dauditmorearchives { get; set; }

    public virtual DbSet<Dauditmorecore> Dauditmorecores { get; set; }

    public virtual DbSet<Dauditnew> Dauditnews { get; set; }

    public virtual DbSet<Dauditnewarchive> Dauditnewarchives { get; set; }

    public virtual DbSet<Dauditnewcore> Dauditnewcores { get; set; }

    public virtual DbSet<Dbrowseancestor> Dbrowseancestors { get; set; }

    public virtual DbSet<Dbrowseancestorscore> Dbrowseancestorscores { get; set; }

    public virtual DbSet<Dcatattr> Dcatattrs { get; set; }

    public virtual DbSet<Dcategory> Dcategories { get; set; }

    public virtual DbSet<Dcolumnlocation> Dcolumnlocations { get; set; }

    public virtual DbSet<Dcolumnsortlocation> Dcolumnsortlocations { get; set; }

    public virtual DbSet<DdeleteditemsnamesTrTr> DdeleteditemsnamesTrTrs { get; set; }

    public virtual DbSet<Ddeleteditemsnode> Ddeleteditemsnodes { get; set; }

    public virtual DbSet<Ddellist> Ddellists { get; set; }

    public virtual DbSet<Ddocumentclass> Ddocumentclasses { get; set; }

    public virtual DbSet<Ddocumentclasschild> Ddocumentclasschildren { get; set; }

    public virtual DbSet<Dextendedprofileinfo> Dextendedprofileinfos { get; set; }

    public virtual DbSet<DfacetAttr15792> DfacetAttr15792s { get; set; }

    public virtual DbSet<DfacetAttr15793> DfacetAttr15793s { get; set; }

    public virtual DbSet<DfacetDc1> DfacetDc1s { get; set; }

    public virtual DbSet<DfacetDc2> DfacetDc2s { get; set; }

    public virtual DbSet<DfacetDc3> DfacetDc3s { get; set; }

    public virtual DbSet<DfacetDc336> DfacetDc336s { get; set; }

    public virtual DbSet<DfacetDc4> DfacetDc4s { get; set; }

    public virtual DbSet<DfacetDc5> DfacetDc5s { get; set; }

    public virtual DbSet<DfacetFilingstatus> DfacetFilingstatuses { get; set; }

    public virtual DbSet<DfacetModifydate> DfacetModifydates { get; set; }

    public virtual DbSet<DfacetObjecttype> DfacetObjecttypes { get; set; }

    public virtual DbSet<DfacetOwner> DfacetOwners { get; set; }

    public virtual DbSet<Dfacetcache> Dfacetcaches { get; set; }

    public virtual DbSet<Dfacetcachecore> Dfacetcachecores { get; set; }

    public virtual DbSet<Dfacetkey> Dfacetkeys { get; set; }

    public virtual DbSet<Dfacettracking> Dfacettrackings { get; set; }

    public virtual DbSet<Dfavorite> Dfavorites { get; set; }

    public virtual DbSet<Dfavoritestab> Dfavoritestabs { get; set; }

    public virtual DbSet<Discussionid> Discussionids { get; set; }

    public virtual DbSet<Disposition> Dispositions { get; set; }

    public virtual DbSet<Dispositionhold> Dispositionholds { get; set; }

    public virtual DbSet<Dmetadatastate> Dmetadatastates { get; set; }

    public virtual DbSet<Dmultipartcontent> Dmultipartcontents { get; set; }

    public virtual DbSet<Dmultipartmetadatum> Dmultipartmetadata { get; set; }

    public virtual DbSet<Dobjectrank> Dobjectranks { get; set; }

    public virtual DbSet<Docxreftyp> Docxreftyps { get; set; }

    public virtual DbSet<Dperspective> Dperspectives { get; set; }

    public virtual DbSet<Dperspectivescore> Dperspectivescores { get; set; }

    public virtual DbSet<Dpsinsertableproperty> Dpsinsertableproperties { get; set; }

    public virtual DbSet<Dreadlist> Dreadlists { get; set; }

    public virtual DbSet<Dreserverequest> Dreserverequests { get; set; }

    public virtual DbSet<Dreserverequestsnotification> Dreserverequestsnotifications { get; set; }

    public virtual DbSet<Dshareancestor> Dshareancestors { get; set; }

    public virtual DbSet<Dsharecoordinator> Dsharecoordinators { get; set; }

    public virtual DbSet<Dsharecredential> Dsharecredentials { get; set; }

    public virtual DbSet<Dshareitem> Dshareitems { get; set; }

    public virtual DbSet<Dshareitemreference> Dshareitemreferences { get; set; }

    public virtual DbSet<Dshareitemstateindicator> Dshareitemstateindicators { get; set; }

    public virtual DbSet<Dsharesyncerror> Dsharesyncerrors { get; set; }

    public virtual DbSet<Dsharesyncevent> Dsharesyncevents { get; set; }

    public virtual DbSet<Dsharesyncitem> Dsharesyncitems { get; set; }

    public virtual DbSet<Dsignature> Dsignatures { get; set; }

    public virtual DbSet<Dsignaturerequest> Dsignaturerequests { get; set; }

    public virtual DbSet<Dsignaturerequestitem> Dsignaturerequestitems { get; set; }

    public virtual DbSet<Dsocialfeedevent> Dsocialfeedevents { get; set; }

    public virtual DbSet<Dsocialfollower> Dsocialfollowers { get; set; }

    public virtual DbSet<Dsocialitemcount> Dsocialitemcounts { get; set; }

    public virtual DbSet<Dsociallike> Dsociallikes { get; set; }

    public virtual DbSet<Dsocialmention> Dsocialmentions { get; set; }

    public virtual DbSet<Dsocialobjectsdisposition> Dsocialobjectsdispositions { get; set; }

    public virtual DbSet<Dsocialobjectsetting> Dsocialobjectsettings { get; set; }

    public virtual DbSet<Dsocialpreference> Dsocialpreferences { get; set; }

    public virtual DbSet<Dstagingimport> Dstagingimports { get; set; }

    public virtual DbSet<Dsuggestexception> Dsuggestexceptions { get; set; }

    public virtual DbSet<Dsuggestword> Dsuggestwords { get; set; }

    public virtual DbSet<Dsuggestwordshash> Dsuggestwordshashes { get; set; }

    public virtual DbSet<Dsuggestwordspending> Dsuggestwordspendings { get; set; }

    public virtual DbSet<Dtopicitem> Dtopicitems { get; set; }

    public virtual DbSet<Dtree> Dtrees { get; set; }

    public virtual DbSet<Dtreeacl> Dtreeacls { get; set; }

    public virtual DbSet<Dtreeancestor> Dtreeancestors { get; set; }

    public virtual DbSet<Dtreeancestorsleafnode> Dtreeancestorsleafnodes { get; set; }

    public virtual DbSet<Dtreeaspectsnotify> Dtreeaspectsnotifies { get; set; }

    public virtual DbSet<Dtreecore> Dtreecores { get; set; }

    public virtual DbSet<Dtreecoreexternaldatum> Dtreecoreexternaldata { get; set; }

    public virtual DbSet<Dtreecoreexternalsource> Dtreecoreexternalsources { get; set; }

    public virtual DbSet<Dtreedeleted> Dtreedeleteds { get; set; }

    public virtual DbSet<Dtreeextractorverify> Dtreeextractorverifies { get; set; }

    public virtual DbSet<Dtreemultilingual> Dtreemultilinguals { get; set; }

    public virtual DbSet<Dtreenotify> Dtreenotifies { get; set; }

    public virtual DbSet<Dtreenotifyrecover> Dtreenotifyrecovers { get; set; }

    public virtual DbSet<Dtreeparentevent> Dtreeparentevents { get; set; }

    public virtual DbSet<Dtreerule> Dtreerules { get; set; }

    public virtual DbSet<Dtreesubtypeorderref> Dtreesubtypeorderrefs { get; set; }

    public virtual DbSet<Dtreesyncdatum> Dtreesyncdata { get; set; }

    public virtual DbSet<Dtreesyncevent> Dtreesyncevents { get; set; }

    public virtual DbSet<Dtreesyncextradatum> Dtreesyncextradata { get; set; }

    public virtual DbSet<Dtreesyncinterest> Dtreesyncinterests { get; set; }

    public virtual DbSet<Dtreesyncmessage> Dtreesyncmessages { get; set; }

    public virtual DbSet<Dtreesyncqdsuser> Dtreesyncqdsusers { get; set; }

    public virtual DbSet<Dtreesyncqueue> Dtreesyncqueues { get; set; }

    public virtual DbSet<Dtreesyncsnf> Dtreesyncsnfs { get; set; }

    public virtual DbSet<Dtreevectornotify> Dtreevectornotifies { get; set; }

    public virtual DbSet<Dversdatavideoannotate> Dversdatavideoannotates { get; set; }

    public virtual DbSet<Dversdatavideotranscode> Dversdatavideotranscodes { get; set; }

    public virtual DbSet<Dversdatum> Dversdata { get; set; }

    public virtual DbSet<Dversextradatum> Dversextradata { get; set; }

    public virtual DbSet<Dworkbench> Dworkbenches { get; set; }

    public virtual DbSet<EcmlinkConfigAll> EcmlinkConfigAlls { get; set; }

    public virtual DbSet<EcmlinkWkspLinked> EcmlinkWkspLinkeds { get; set; }

    public virtual DbSet<EcmlinkWkspUnion> EcmlinkWkspUnions { get; set; }

    public virtual DbSet<Elinkalias> Elinkaliases { get; set; }

    public virtual DbSet<Elinkmessage> Elinkmessages { get; set; }

    public virtual DbSet<Elinkmessagelog> Elinkmessagelogs { get; set; }

    public virtual DbSet<Elinksubscription> Elinksubscriptions { get; set; }

    public virtual DbSet<Elinkunhandledevent> Elinkunhandledevents { get; set; }

    public virtual DbSet<EssRecord> EssRecords { get; set; }

    public virtual DbSet<ExtendedUserInfo> ExtendedUserInfos { get; set; }

    public virtual DbSet<Facility> Facilities { get; set; }

    public virtual DbSet<Fdahead> Fdaheads { get; set; }

    public virtual DbSet<Fieldinfo> Fieldinfos { get; set; }

    public virtual DbSet<FileStatus> FileStatuses { get; set; }

    public virtual DbSet<Filecache> Filecaches { get; set; }

    public virtual DbSet<FollowupSeqnr> FollowupSeqnrs { get; set; }

    public virtual DbSet<Formdatum> Formdata { get; set; }

    public virtual DbSet<Formssequence> Formssequences { get; set; }

    public virtual DbSet<Holdtype> Holdtypes { get; set; }

    public virtual DbSet<Iconbardisplay> Iconbardisplays { get; set; }

    public virtual DbSet<IkBolumturleri> IkBolumturleris { get; set; }

    public virtual DbSet<IkEgitimturleri> IkEgitimturleris { get; set; }

    public virtual DbSet<IkPersonelturleri> IkPersonelturleris { get; set; }

    public virtual DbSet<IkPersonelview> IkPersonelviews { get; set; }

    public virtual DbSet<IkPozisyonturleri> IkPozisyonturleris { get; set; }

    public virtual DbSet<IkSehirlistesi> IkSehirlistesis { get; set; }

    public virtual DbSet<IkUniversitebolumlistesi> IkUniversitebolumlistesis { get; set; }

    public virtual DbSet<IkUniversitelistesi> IkUniversitelistesis { get; set; }

    public virtual DbSet<IkUyruklistesi> IkUyruklistesis { get; set; }

    public virtual DbSet<IkYabancidillistesi> IkYabancidillistesis { get; set; }

    public virtual DbSet<Indextracerdatum> Indextracerdata { get; set; }

    public virtual DbSet<InterviewFetched> InterviewFetcheds { get; set; }

    public virtual DbSet<InterviewGenerated> InterviewGenerateds { get; set; }

    public virtual DbSet<InterviewProcess> InterviewProcesses { get; set; }

    public virtual DbSet<Itemrefdatum> Itemrefdata { get; set; }

    public virtual DbSet<Itemrefinfo> Itemrefinfos { get; set; }

    public virtual DbSet<Jurisdcode> Jurisdcodes { get; set; }

    public virtual DbSet<Justification> Justifications { get; set; }

    public virtual DbSet<Kactivitystorage> Kactivitystorages { get; set; }

    public virtual DbSet<Kactivityworkload> Kactivityworkloads { get; set; }

    public virtual DbSet<Kactivityworkloadsummary> Kactivityworkloadsummaries { get; set; }

    public virtual DbSet<Kdual> Kduals { get; set; }

    public virtual DbSet<Kerrorfault> Kerrorfaults { get; set; }

    public virtual DbSet<Kid> Kids { get; set; }

    public virtual DbSet<Kini> Kinis { get; set; }

    public virtual DbSet<Klong> Klongs { get; set; }

    public virtual DbSet<Kmessage> Kmessages { get; set; }

    public virtual DbSet<Kmessageaggregate> Kmessageaggregates { get; set; }

    public virtual DbSet<Kmessagebody> Kmessagebodies { get; set; }

    public virtual DbSet<Kmessagecount> Kmessagecounts { get; set; }

    public virtual DbSet<Kmessageemail> Kmessageemails { get; set; }

    public virtual DbSet<Kmessageheader> Kmessageheaders { get; set; }

    public virtual DbSet<Kmessageparam> Kmessageparams { get; set; }

    public virtual DbSet<Kmessagescore> Kmessagescores { get; set; }

    public virtual DbSet<Kmessageteam> Kmessageteams { get; set; }

    public virtual DbSet<Kmessagethread> Kmessagethreads { get; set; }

    public virtual DbSet<Kmutex> Kmutexes { get; set; }

    public virtual DbSet<Kobjreftracking> Kobjreftrackings { get; set; }

    public virtual DbSet<Ksecret> Ksecrets { get; set; }

    public virtual DbSet<Kstate> Kstates { get; set; }

    public virtual DbSet<Ksystemhealthresult> Ksystemhealthresults { get; set; }

    public virtual DbSet<Kuaf> Kuafs { get; set; }

    public virtual DbSet<Kuafchild> Kuafchildren { get; set; }

    public virtual DbSet<Kuafidentity> Kuafidentities { get; set; }

    public virtual DbSet<Kuafidentitytype> Kuafidentitytypes { get; set; }

    public virtual DbSet<Kuafpref> Kuafprefs { get; set; }

    public virtual DbSet<Kuafprivilegebasedright> Kuafprivilegebasedrights { get; set; }

    public virtual DbSet<Kuafproxy> Kuafproxies { get; set; }

    public virtual DbSet<Kuafrightslist> Kuafrightslists { get; set; }

    public virtual DbSet<Kuafrightslistnew> Kuafrightslistnews { get; set; }

    public virtual DbSet<Kuafrightslistnewcore> Kuafrightslistnewcores { get; set; }

    public virtual DbSet<Kuafrightslistworkflow> Kuafrightslistworkflows { get; set; }

    public virtual DbSet<Kuafusage> Kuafusages { get; set; }

    public virtual DbSet<Kuafusagesummary> Kuafusagesummaries { get; set; }

    public virtual DbSet<Kuafuserproxy> Kuafuserproxies { get; set; }

    public virtual DbSet<Kworklist> Kworklists { get; set; }

    public virtual DbSet<Kworklistcore> Kworklistcores { get; set; }

    public virtual DbSet<KysNumara> KysNumaras { get; set; }

    public virtual DbSet<Kysa> Kysas { get; set; }

    public virtual DbSet<KysasAksiyonkaynagibakim> KysasAksiyonkaynagibakims { get; set; }

    public virtual DbSet<KysasAksiyonsorumlusudepartmanbakim> KysasAksiyonsorumlusudepartmanbakims { get; set; }

    public virtual DbSet<KysasBirimbakim> KysasBirimbakims { get; set; }

    public virtual DbSet<KysasIlgilisistembakim> KysasIlgilisistembakims { get; set; }

    public virtual DbSet<KysasKaynakbakim> KysasKaynakbakims { get; set; }

    public virtual DbSet<KysasSurecsorumlularibakim> KysasSurecsorumlularibakims { get; set; }

    public virtual DbSet<KysasWfdurumbakim> KysasWfdurumbakims { get; set; }

    public virtual DbSet<KysasWfformbakim> KysasWfformbakims { get; set; }

    public virtual DbSet<KysasWfkararbakim> KysasWfkararbakims { get; set; }

    public virtual DbSet<Kysdf> Kysdfs { get; set; }

    public virtual DbSet<KysdfsAksiyonkaynagibakim> KysdfsAksiyonkaynagibakims { get; set; }

    public virtual DbSet<KysdfsAksiyonlartablosu> KysdfsAksiyonlartablosus { get; set; }

    public virtual DbSet<KysdfsDepartmanbakim> KysdfsDepartmanbakims { get; set; }

    public virtual DbSet<KysdfsDfkaynagibakim> KysdfsDfkaynagibakims { get; set; }

    public virtual DbSet<KysdfsDfsablontipibakim> KysdfsDfsablontipibakims { get; set; }

    public virtual DbSet<KysdfsDurumbakim> KysdfsDurumbakims { get; set; }

    public virtual DbSet<KysdfsFaaliyettipibakim> KysdfsFaaliyettipibakims { get; set; }

    public virtual DbSet<KysdfsGecikengorevbakim> KysdfsGecikengorevbakims { get; set; }

    public virtual DbSet<KysdfsHatabolumbakim> KysdfsHatabolumbakims { get; set; }

    public virtual DbSet<KysdfsHatatespitlokasyonbakim> KysdfsHatatespitlokasyonbakims { get; set; }

    public virtual DbSet<KysdfsIlgiliyonetimsistemibakim> KysdfsIlgiliyonetimsistemibakims { get; set; }

    public virtual DbSet<KysdfsSistemsorumlularibakim> KysdfsSistemsorumlularibakims { get; set; }

    public virtual DbSet<KysdfsSurecsorumlularibakim> KysdfsSurecsorumlularibakims { get; set; }

    public virtual DbSet<KysdfsUygunsuzlukturubakim> KysdfsUygunsuzlukturubakims { get; set; }

    public virtual DbSet<KysdfsWfdurumbakim> KysdfsWfdurumbakims { get; set; }

    public virtual DbSet<KysdfsWfformbakim> KysdfsWfformbakims { get; set; }

    public virtual DbSet<KysdfsWfkararbakim> KysdfsWfkararbakims { get; set; }

    public virtual DbSet<Kysdnt> Kysdnts { get; set; }

    public virtual DbSet<KysdntBulgulartablosu> KysdntBulgulartablosus { get; set; }

    public virtual DbSet<KysdntBulgutipibakim> KysdntBulgutipibakims { get; set; }

    public virtual DbSet<KysdntDenetimplanlari> KysdntDenetimplanlaris { get; set; }

    public virtual DbSet<KysdntDenetimrolbakim> KysdntDenetimrolbakims { get; set; }

    public virtual DbSet<KysdntDenetimverisibakim> KysdntDenetimverisibakims { get; set; }

    public virtual DbSet<KysdntDenetlenecekdepartmanbakim> KysdntDenetlenecekdepartmanbakims { get; set; }

    public virtual DbSet<KysdntDisdenetimtipibakim> KysdntDisdenetimtipibakims { get; set; }

    public virtual DbSet<KysdntDurumbakim> KysdntDurumbakims { get; set; }

    public virtual DbSet<KysdntGecikengorevbakim> KysdntGecikengorevbakims { get; set; }

    public virtual DbSet<KysdntPlandurumubakim> KysdntPlandurumubakims { get; set; }

    public virtual DbSet<KysdntSablonbakim> KysdntSablonbakims { get; set; }

    public virtual DbSet<KysdntSorulistesibakim> KysdntSorulistesibakims { get; set; }

    public virtual DbSet<KysdntSorulistesitablosu> KysdntSorulistesitablosus { get; set; }

    public virtual DbSet<KysdntSorulistesitipibakim> KysdntSorulistesitipibakims { get; set; }

    public virtual DbSet<KysdntStandartnobakim> KysdntStandartnobakims { get; set; }

    public virtual DbSet<KysdntSurecsorumlularibakim> KysdntSurecsorumlularibakims { get; set; }

    public virtual DbSet<KysdntTespittipibakim> KysdntTespittipibakims { get; set; }

    public virtual DbSet<KysdntWfdurumbakim> KysdntWfdurumbakims { get; set; }

    public virtual DbSet<KysdntWfformbakim> KysdntWfformbakims { get; set; }

    public virtual DbSet<KysdntWfkararbakim> KysdntWfkararbakims { get; set; }

    public virtual DbSet<Kysdy> Kysdys { get; set; }

    public virtual DbSet<KysdysCatgozdengecirmedurumu> KysdysCatgozdengecirmedurumus { get; set; }

    public virtual DbSet<KysdysCatkullanimdurumubakim> KysdysCatkullanimdurumubakims { get; set; }

    public virtual DbSet<KysdysDepartmanbirimbakim> KysdysDepartmanbirimbakims { get; set; }

    public virtual DbSet<KysdysGecikengorevbakim> KysdysGecikengorevbakims { get; set; }

    public virtual DbSet<KysdysGizlilikseviyesibakim> KysdysGizlilikseviyesibakims { get; set; }

    public virtual DbSet<KysdysGozdengecirmeperiyotbakim> KysdysGozdengecirmeperiyotbakims { get; set; }

    public virtual DbSet<KysdysOnaycilarbakim> KysdysOnaycilarbakims { get; set; }

    public virtual DbSet<KysdysSablonbakim> KysdysSablonbakims { get; set; }

    public virtual DbSet<KysdysSurectipibakim> KysdysSurectipibakims { get; set; }

    public virtual DbSet<KysdysWfdurumbakim> KysdysWfdurumbakims { get; set; }

    public virtual DbSet<KysdysWfformbakim> KysdysWfformbakims { get; set; }

    public virtual DbSet<KysdysWfkararbakim> KysdysWfkararbakims { get; set; }

    public virtual DbSet<KysdysYonetimsistemibakim> KysdysYonetimsistemibakims { get; set; }

    public virtual DbSet<Kyskry> Kyskries { get; set; }

    public virtual DbSet<KyskryAltsurecbakim> KyskryAltsurecbakims { get; set; }

    public virtual DbSet<KyskryBaglamsinifibakim> KyskryBaglamsinifibakims { get; set; }

    public virtual DbSet<KyskryBaglamtanimibakim> KyskryBaglamtanimibakims { get; set; }

    public virtual DbSet<KyskryBaglamturubakim> KyskryBaglamturubakims { get; set; }

    public virtual DbSet<KyskryDepartmanbakim> KyskryDepartmanbakims { get; set; }

    public virtual DbSet<KyskryFirsatboyutubakim> KyskryFirsatboyutubakims { get; set; }

    public virtual DbSet<KyskryOlasilikbakim> KyskryOlasilikbakims { get; set; }

    public virtual DbSet<KyskryPeriyotbakim> KyskryPeriyotbakims { get; set; }

    public virtual DbSet<KyskryPuantablosu> KyskryPuantablosus { get; set; }

    public virtual DbSet<KyskryRiskbakim> KyskryRiskbakims { get; set; }

    public virtual DbSet<KyskryRiskfirsatbakim> KyskryRiskfirsatbakims { get; set; }

    public virtual DbSet<KyskrySurecbakim> KyskrySurecbakims { get; set; }

    public virtual DbSet<KyskrySurecbasamagibakim> KyskrySurecbasamagibakims { get; set; }

    public virtual DbSet<KyskrySurecsorumlularibakim> KyskrySurecsorumlularibakims { get; set; }

    public virtual DbSet<KyskryWfdurumbakim> KyskryWfdurumbakims { get; set; }

    public virtual DbSet<KyskryWfformbakim> KyskryWfformbakims { get; set; }

    public virtual DbSet<KyskryWfkararbakim> KyskryWfkararbakims { get; set; }

    public virtual DbSet<Kysoby> Kysobies { get; set; }

    public virtual DbSet<KysobyDepartmanbakim> KysobyDepartmanbakims { get; set; }

    public virtual DbSet<KysobyDurumbakim> KysobyDurumbakims { get; set; }

    public virtual DbSet<KysobyFrmGorusalbakim> KysobyFrmGorusalbakims { get; set; }

    public virtual DbSet<KysobyKomisyontablosu> KysobyKomisyontablosus { get; set; }

    public virtual DbSet<KysobySurecsorumlularibakim> KysobySurecsorumlularibakims { get; set; }

    public virtual DbSet<KysobySurectipibakim> KysobySurectipibakims { get; set; }

    public virtual DbSet<KysobyWfdurumbakim> KysobyWfdurumbakims { get; set; }

    public virtual DbSet<KysobyWfformbakim> KysobyWfformbakims { get; set; }

    public virtual DbSet<KysobyWfkararbakim> KysobyWfkararbakims { get; set; }

    public virtual DbSet<Kysygg> Kysyggs { get; set; }

    public virtual DbSet<KysyggBirimbakim> KysyggBirimbakims { get; set; }

    public virtual DbSet<KysyggDepartmanbakim> KysyggDepartmanbakims { get; set; }

    public virtual DbSet<KysyggGysbirimibakim> KysyggGysbirimibakims { get; set; }

    public virtual DbSet<KysyggGysunsurlaribakim> KysyggGysunsurlaribakims { get; set; }

    public virtual DbSet<KysyggIlgilisistembakim> KysyggIlgilisistembakims { get; set; }

    public virtual DbSet<KysyggRaporturubakim> KysyggRaporturubakims { get; set; }

    public virtual DbSet<KysyggSablonbakim> KysyggSablonbakims { get; set; }

    public virtual DbSet<KysyggToplantikonusubakim> KysyggToplantikonusubakims { get; set; }

    public virtual DbSet<KysyggToplantiturubakim> KysyggToplantiturubakims { get; set; }

    public virtual DbSet<KysyggWfdurumbakim> KysyggWfdurumbakims { get; set; }

    public virtual DbSet<KysyggWfformbakim> KysyggWfformbakims { get; set; }

    public virtual DbSet<KysyggWfkararbakim> KysyggWfkararbakims { get; set; }

    public virtual DbSet<KysyggYerbakim> KysyggYerbakims { get; set; }

    public virtual DbSet<Labeldefinition> Labeldefinitions { get; set; }

    public virtual DbSet<Labeldefspec> Labeldefspecs { get; set; }

    public virtual DbSet<Labelqueue> Labelqueues { get; set; }

    public virtual DbSet<Labelstock> Labelstocks { get; set; }

    public virtual DbSet<Licaccess> Licaccesses { get; set; }

    public virtual DbSet<Liccountmethod> Liccountmethods { get; set; }

    public virtual DbSet<Licecosystem> Licecosystems { get; set; }

    public virtual DbSet<Liclevel> Liclevels { get; set; }

    public virtual DbSet<Liclevelchild> Liclevelchildren { get; set; }

    public virtual DbSet<Licmember> Licmembers { get; set; }

    public virtual DbSet<Llattrblobdatum> Llattrblobdata { get; set; }

    public virtual DbSet<Llattrdatum> Llattrdata { get; set; }

    public virtual DbSet<Llcache> Llcaches { get; set; }

    public virtual DbSet<Llcachesecure> Llcachesecures { get; set; }

    public virtual DbSet<Llclassify> Llclassifies { get; set; }

    public virtual DbSet<Llcomment> Llcomments { get; set; }

    public virtual DbSet<Llcommnotification> Llcommnotifications { get; set; }

    public virtual DbSet<Llcommregistry> Llcommregistries { get; set; }

    public virtual DbSet<Lldirectory> Lldirectories { get; set; }

    public virtual DbSet<Lleventancestor> Lleventancestors { get; set; }

    public virtual DbSet<Lleventqueue> Lleventqueues { get; set; }

    public virtual DbSet<Llforum> Llforums { get; set; }

    public virtual DbSet<Llforumsdirectory> Llforumsdirectories { get; set; }

    public virtual DbSet<Llforumsorder> Llforumsorders { get; set; }

    public virtual DbSet<Llmultivolumeregistry> Llmultivolumeregistries { get; set; }

    public virtual DbSet<Llpolling> Llpollings { get; set; }

    public virtual DbSet<Llprospector> Llprospectors { get; set; }

    public virtual DbSet<Llprospectordatum> Llprospectordata { get; set; }

    public virtual DbSet<Llprospectorregistry> Llprospectorregistries { get; set; }

    public virtual DbSet<Llproxiesmapping> Llproxiesmappings { get; set; }

    public virtual DbSet<Llproxy> Llproxies { get; set; }

    public virtual DbSet<Llquestion> Llquestions { get; set; }

    public virtual DbSet<Llsystemdatum> Llsystemdata { get; set; }

    public virtual DbSet<Lluserdatum> Lluserdata { get; set; }

    public virtual DbSet<Llwebsessioncache> Llwebsessioncaches { get; set; }

    public virtual DbSet<Llwebsessioncachecore> Llwebsessioncachecores { get; set; }

    public virtual DbSet<Llwebsessionlog> Llwebsessionlogs { get; set; }

    public virtual DbSet<Locatorlabel> Locatorlabels { get; set; }

    public virtual DbSet<Locatortype> Locatortypes { get; set; }

    public virtual DbSet<Loclocatortype> Loclocatortypes { get; set; }

    public virtual DbSet<Logininfo> Logininfos { get; set; }

    public virtual DbSet<Mediatype> Mediatypes { get; set; }

    public virtual DbSet<Metadatalanguage> Metadatalanguages { get; set; }

    public virtual DbSet<NgdKini> NgdKinis { get; set; }

    public virtual DbSet<NgdNewitemhist> NgdNewitemhists { get; set; }

    public virtual DbSet<Nickname> Nicknames { get; set; }

    public virtual DbSet<Notifyevent> Notifyevents { get; set; }

    public virtual DbSet<Notifyinterests2> Notifyinterests2s { get; set; }

    public virtual DbSet<Notifymessage> Notifymessages { get; set; }

    public virtual DbSet<O365GroupAssoc> O365GroupAssocs { get; set; }

    public virtual DbSet<O365TeamshareChange> O365TeamshareChanges { get; set; }

    public virtual DbSet<O365TeamshareChangescan> O365TeamshareChangescans { get; set; }

    public virtual DbSet<O365TeamshareVersion> O365TeamshareVersions { get; set; }

    public virtual DbSet<O365groupcreationqueue> O365groupcreationqueues { get; set; }

    public virtual DbSet<O365teamshareitemmap> O365teamshareitemmaps { get; set; }

    public virtual DbSet<O365teamsharemessage> O365teamsharemessages { get; set; }

    public virtual DbSet<Models.Object> Objects { get; set; }

    public virtual DbSet<OiStatus> OiStatuses { get; set; }

    public virtual DbSet<Oldpassword> Oldpasswords { get; set; }

    public virtual DbSet<Otdocumenthold> Otdocumentholds { get; set; }

    public virtual DbSet<Otemailbody> Otemailbodies { get; set; }

    public virtual DbSet<Otemailconversationid> Otemailconversationids { get; set; }

    public virtual DbSet<Otemailcustomproperty> Otemailcustomproperties { get; set; }

    public virtual DbSet<Otemaillocationmessageid> Otemaillocationmessageids { get; set; }

    public virtual DbSet<Otemaillocationmessageidsex> Otemaillocationmessageidsexes { get; set; }

    public virtual DbSet<Otemailmessageid> Otemailmessageids { get; set; }

    public virtual DbSet<Otemailparticipant> Otemailparticipants { get; set; }

    public virtual DbSet<Otemailproperty> Otemailproperties { get; set; }

    public virtual DbSet<OthcmActLog> OthcmActLogs { get; set; }

    public virtual DbSet<OthcmCmisDeletedDoc> OthcmCmisDeletedDocs { get; set; }

    public virtual DbSet<OthcmCustomization> OthcmCustomizations { get; set; }

    public virtual DbSet<OthcmCustomizationsExtn> OthcmCustomizationsExtns { get; set; }

    public virtual DbSet<OthcmDocumentType> OthcmDocumentTypes { get; set; }

    public virtual DbSet<OthcmGroup> OthcmGroups { get; set; }

    public virtual DbSet<OthcmGroupUser> OthcmGroupUsers { get; set; }

    public virtual DbSet<OthcmHrFuncRightNodeid> OthcmHrFuncRightNodeids { get; set; }

    public virtual DbSet<OthcmHrFuncRole> OthcmHrFuncRoles { get; set; }

    public virtual DbSet<OthcmInbox> OthcmInboxes { get; set; }

    public virtual DbSet<OthcmInboxLog> OthcmInboxLogs { get; set; }

    public virtual DbSet<OthcmJobRelationship> OthcmJobRelationships { get; set; }

    public virtual DbSet<OthcmMissingUser> OthcmMissingUsers { get; set; }

    public virtual DbSet<OthcmModifiedEntity> OthcmModifiedEntities { get; set; }

    public virtual DbSet<OthcmProxyUserAudit> OthcmProxyUserAudits { get; set; }

    public virtual DbSet<OthcmRegionCountryMapping> OthcmRegionCountryMappings { get; set; }

    public virtual DbSet<OthcmRegionDocTempMapping> OthcmRegionDocTempMappings { get; set; }

    public virtual DbSet<OthcmRule> OthcmRules { get; set; }

    public virtual DbSet<OthcmRulesGpGroup> OthcmRulesGpGroups { get; set; }

    public virtual DbSet<OthcmRulesTpGroup> OthcmRulesTpGroups { get; set; }

    public virtual DbSet<OthcmTemplateMapping> OthcmTemplateMappings { get; set; }

    public virtual DbSet<OthcmUserManager> OthcmUserManagers { get; set; }

    public virtual DbSet<OthcmUserMyfilter> OthcmUserMyfilters { get; set; }

    public virtual DbSet<Othcminactiveworkspaceinfo> Othcminactiveworkspaceinfos { get; set; }

    public virtual DbSet<OtsapAttributeSchema> OtsapAttributeSchemas { get; set; }

    public virtual DbSet<OtsapBoType> OtsapBoTypes { get; set; }

    public virtual DbSet<OtsapBoTypesCbSetting> OtsapBoTypesCbSettings { get; set; }

    public virtual DbSet<OtsapBoTypesCore> OtsapBoTypesCores { get; set; }

    public virtual DbSet<OtsapBoTypesDocType> OtsapBoTypesDocTypes { get; set; }

    public virtual DbSet<OtsapBoTypesMultilingual> OtsapBoTypesMultilinguals { get; set; }

    public virtual DbSet<OtsapBoTypesPropMap> OtsapBoTypesPropMaps { get; set; }

    public virtual DbSet<OtsapBoTypesPropgroup> OtsapBoTypesPropgroups { get; set; }

    public virtual DbSet<OtsapBoTypesPropgroupMap> OtsapBoTypesPropgroupMaps { get; set; }

    public virtual DbSet<OtsapCbMultiValue> OtsapCbMultiValues { get; set; }

    public virtual DbSet<OtsapEventRecord> OtsapEventRecords { get; set; }

    public virtual DbSet<OtsapEventSubscription> OtsapEventSubscriptions { get; set; }

    public virtual DbSet<OtsapExtSystem> OtsapExtSystems { get; set; }

    public virtual DbSet<OtsapExtSystemsMultilingual> OtsapExtSystemsMultilinguals { get; set; }

    public virtual DbSet<OtsapIndexableSubtype> OtsapIndexableSubtypes { get; set; }

    public virtual DbSet<OtsapManagedObjectType> OtsapManagedObjectTypes { get; set; }

    public virtual DbSet<OtsapPoliciesUsr> OtsapPoliciesUsrs { get; set; }

    public virtual DbSet<OtsapPolicy> OtsapPolicies { get; set; }

    public virtual DbSet<OtsapRefType> OtsapRefTypes { get; set; }

    public virtual DbSet<OtsapRefTypesCbSetting> OtsapRefTypesCbSettings { get; set; }

    public virtual DbSet<OtsapRefTypesMultilingual> OtsapRefTypesMultilinguals { get; set; }

    public virtual DbSet<OtsapReferenceType> OtsapReferenceTypes { get; set; }

    public virtual DbSet<OtsapSotType> OtsapSotTypes { get; set; }

    public virtual DbSet<OtsapUniqueName> OtsapUniqueNames { get; set; }

    public virtual DbSet<OtsapWkspAllRelation> OtsapWkspAllRelations { get; set; }

    public virtual DbSet<OtsapWkspChildRelation> OtsapWkspChildRelations { get; set; }

    public virtual DbSet<OtsapWkspParentRelation> OtsapWkspParentRelations { get; set; }

    public virtual DbSet<OtsapWkspRelation> OtsapWkspRelations { get; set; }

    public virtual DbSet<OtsapactSystem> OtsapactSystems { get; set; }

    public virtual DbSet<OtsapactSystemsEnabled> OtsapactSystemsEnableds { get; set; }

    public virtual DbSet<OtsapcmisLink> OtsapcmisLinks { get; set; }

    public virtual DbSet<OtsapwkspBoChildRelation> OtsapwkspBoChildRelations { get; set; }

    public virtual DbSet<OtsapwkspBoParentRelation> OtsapwkspBoParentRelations { get; set; }

    public virtual DbSet<OtsapwkspChildClassify> OtsapwkspChildClassifies { get; set; }

    public virtual DbSet<OtsapwkspInstRoleMapping> OtsapwkspInstRoleMappings { get; set; }

    public virtual DbSet<OtsapwkspMigrationMapping> OtsapwkspMigrationMappings { get; set; }

    public virtual DbSet<OtsapwkspMigrationTracking> OtsapwkspMigrationTrackings { get; set; }

    public virtual DbSet<OtsapwkspRoleMapping> OtsapwkspRoleMappings { get; set; }

    public virtual DbSet<OtsapxecmPermissionpropagation> OtsapxecmPermissionpropagations { get; set; }

    public virtual DbSet<OtsapxecmRefLink> OtsapxecmRefLinks { get; set; }

    public virtual DbSet<OtsapxecmSeqnr> OtsapxecmSeqnrs { get; set; }

    public virtual DbSet<OtsapxecmWkspCao> OtsapxecmWkspCaos { get; set; }

    public virtual DbSet<OtsapxecmWkspInfo> OtsapxecmWkspInfos { get; set; }

    public virtual DbSet<OtsapxecmWkspLink> OtsapxecmWkspLinks { get; set; }

    public virtual DbSet<OtsapxecmWkspNolink> OtsapxecmWkspNolinks { get; set; }

    public virtual DbSet<OtsapxecmWkspSlink> OtsapxecmWkspSlinks { get; set; }

    public virtual DbSet<Personelbilgisiview> Personelbilgisiviews { get; set; }

    public virtual DbSet<Physitemco> Physitemcos { get; set; }

    public virtual DbSet<Physitemdatum> Physitemdata { get; set; }

    public virtual DbSet<Physitemext> Physitemexts { get; set; }

    public virtual DbSet<Physitemhistory> Physitemhistories { get; set; }

    public virtual DbSet<Physitemmicro> Physitemmicros { get; set; }

    public virtual DbSet<Physitemrequest> Physitemrequests { get; set; }

    public virtual DbSet<Physobjclient> Physobjclients { get; set; }

    public virtual DbSet<Physobjfuncaccess> Physobjfuncaccesses { get; set; }

    public virtual DbSet<Physobjkeyword> Physobjkeywords { get; set; }

    public virtual DbSet<Physobjkini> Physobjkinis { get; set; }

    public virtual DbSet<Physobjlocation> Physobjlocations { get; set; }

    public virtual DbSet<PowfClearance> PowfClearances { get; set; }

    public virtual DbSet<PowfCreateitem> PowfCreateitems { get; set; }

    public virtual DbSet<PowfDatadef> PowfDatadefs { get; set; }

    public virtual DbSet<PowfItemext> PowfItemexts { get; set; }

    public virtual DbSet<PowfSuppmark> PowfSuppmarks { get; set; }

    public virtual DbSet<Processstat> Processstats { get; set; }

    public virtual DbSet<Projectoverviewsetting> Projectoverviewsettings { get; set; }

    public virtual DbSet<Provenancetype> Provenancetypes { get; set; }

    public virtual DbSet<Providerconfirmmove> Providerconfirmmoves { get; set; }

    public virtual DbSet<Providerdatum> Providerdata { get; set; }

    public virtual DbSet<Providerretry> Providerretries { get; set; }

    public virtual DbSet<Pwd> Pwds { get; set; }

    public virtual DbSet<RecdAdminconfig> RecdAdminconfigs { get; set; }

    public virtual DbSet<RecdHistory> RecdHistories { get; set; }

    public virtual DbSet<RecdHot> RecdHots { get; set; }

    public virtual DbSet<RecdOperationsummary> RecdOperationsummaries { get; set; }

    public virtual DbSet<RecdOperationtracking> RecdOperationtrackings { get; set; }

    public virtual DbSet<RecdOpinionsummary> RecdOpinionsummaries { get; set; }

    public virtual DbSet<RecdOpiniontracking> RecdOpiniontrackings { get; set; }

    public virtual DbSet<RecdSystemstatssummary> RecdSystemstatssummaries { get; set; }

    public virtual DbSet<Recurrence> Recurrences { get; set; }

    public virtual DbSet<Refrate> Refrates { get; set; }

    public virtual DbSet<Regionmap> Regionmaps { get; set; }

    public virtual DbSet<Relattype> Relattypes { get; set; }

    public virtual DbSet<Renditionfolder> Renditionfolders { get; set; }

    public virtual DbSet<Renditionmimetyperule> Renditionmimetyperules { get; set; }

    public virtual DbSet<Renditionnodemimetyperule> Renditionnodemimetyperules { get; set; }

    public virtual DbSet<Renditionnoderule> Renditionnoderules { get; set; }

    public virtual DbSet<Renditionqueue> Renditionqueues { get; set; }

    public virtual DbSet<Requesttype> Requesttypes { get; set; }

    public virtual DbSet<Resubmission> Resubmissions { get; set; }

    public virtual DbSet<Resubrecipient> Resubrecipients { get; set; }

    public virtual DbSet<Resubtype> Resubtypes { get; set; }

    public virtual DbSet<Retcode> Retcodes { get; set; }

    public virtual DbSet<Retentionupdatefailed> Retentionupdatefaileds { get; set; }

    public virtual DbSet<Retentionupdatelog> Retentionupdatelogs { get; set; }

    public virtual DbSet<Retentionupdateorder> Retentionupdateorders { get; set; }

    public virtual DbSet<Retentionupdateretry> Retentionupdateretries { get; set; }

    public virtual DbSet<Retstage> Retstages { get; set; }

    public virtual DbSet<Rimskeyworded> Rimskeywordeds { get; set; }

    public virtual DbSet<Rimsnodeclassification> Rimsnodeclassifications { get; set; }

    public virtual DbSet<Rimstable> Rimstables { get; set; }

    public virtual DbSet<RmAddright> RmAddrights { get; set; }

    public virtual DbSet<RmAssignedfunction> RmAssignedfunctions { get; set; }

    public virtual DbSet<RmClassification> RmClassifications { get; set; }

    public virtual DbSet<RmClassjustify> RmClassjustifies { get; set; }

    public virtual DbSet<RmDeleteaudit> RmDeleteaudits { get; set; }

    public virtual DbSet<RmDeleteauditmetadatum> RmDeleteauditmetadata { get; set; }

    public virtual DbSet<RmDisposition> RmDispositions { get; set; }

    public virtual DbSet<RmDispositionactionerror> RmDispositionactionerrors { get; set; }

    public virtual DbSet<RmDispresult> RmDispresults { get; set; }

    public virtual DbSet<RmDispresultsver> RmDispresultsvers { get; set; }

    public virtual DbSet<RmDispreviewcomment> RmDispreviewcomments { get; set; }

    public virtual DbSet<RmDispreviewer> RmDispreviewers { get; set; }

    public virtual DbSet<RmDispsetting> RmDispsettings { get; set; }

    public virtual DbSet<RmDispsnapshot> RmDispsnapshots { get; set; }

    public virtual DbSet<RmDocrectype> RmDocrectypes { get; set; }

    public virtual DbSet<RmDocxref> RmDocxrefs { get; set; }

    public virtual DbSet<RmFixedret> RmFixedrets { get; set; }

    public virtual DbSet<RmFunction> RmFunctions { get; set; }

    public virtual DbSet<RmHoldquery> RmHoldqueries { get; set; }

    public virtual DbSet<RmHoldqueryhistory> RmHoldqueryhistories { get; set; }

    public virtual DbSet<RmKini> RmKinis { get; set; }

    public virtual DbSet<RmLinkr> RmLinkrs { get; set; }

    public virtual DbSet<RmLinkrr> RmLinkrrs { get; set; }

    public virtual DbSet<RmMulticlass> RmMulticlasses { get; set; }

    public virtual DbSet<RmObjecthold> RmObjectholds { get; set; }

    public virtual DbSet<RmPartrecord> RmPartrecords { get; set; }

    public virtual DbSet<RmPicklist> RmPicklists { get; set; }

    public virtual DbSet<RmProvenance> RmProvenances { get; set; }

    public virtual DbSet<RmProvenancehistory> RmProvenancehistories { get; set; }

    public virtual DbSet<RmRecordsmanager> RmRecordsmanagers { get; set; }

    public virtual DbSet<RmRecordsofficer> RmRecordsofficers { get; set; }

    public virtual DbSet<RmRecordtypedatum> RmRecordtypedata { get; set; }

    public virtual DbSet<RmStat> RmStats { get; set; }

    public virtual DbSet<RmStatusacl> RmStatusacls { get; set; }

    public virtual DbSet<RmTempdatum> RmTempdata { get; set; }

    public virtual DbSet<RmUseraudit> RmUseraudits { get; set; }

    public virtual DbSet<RmUserhold> RmUserholds { get; set; }

    public virtual DbSet<RmUserholdcriterion> RmUserholdcriteria { get; set; }

    public virtual DbSet<RmsecClearance> RmsecClearances { get; set; }

    public virtual DbSet<RmsecDefinedrule> RmsecDefinedrules { get; set; }

    public virtual DbSet<RmsecDocclearance> RmsecDocclearances { get; set; }

    public virtual DbSet<RmsecDocoption> RmsecDocoptions { get; set; }

    public virtual DbSet<RmsecDocsuppmark> RmsecDocsuppmarks { get; set; }

    public virtual DbSet<RmsecSecurity> RmsecSecurities { get; set; }

    public virtual DbSet<RmsecSecurityguide> RmsecSecurityguides { get; set; }

    public virtual DbSet<RmsecSessioncode> RmsecSessioncodes { get; set; }

    public virtual DbSet<RmsecSessionmarking> RmsecSessionmarkings { get; set; }

    public virtual DbSet<RmsecStat> RmsecStats { get; set; }

    public virtual DbSet<RmsecSuppmark> RmsecSuppmarks { get; set; }

    public virtual DbSet<RmsecTempdatum> RmsecTempdata { get; set; }

    public virtual DbSet<RmsecUsersuppmark> RmsecUsersuppmarks { get; set; }

    public virtual DbSet<Rsi> Rsis { get; set; }

    public virtual DbSet<Rsiapproval> Rsiapprovals { get; set; }

    public virtual DbSet<Rsiapprovalhistory> Rsiapprovalhistories { get; set; }

    public virtual DbSet<Rsieventsched> Rsieventscheds { get; set; }

    public virtual DbSet<Rsijustify> Rsijustifies { get; set; }

    public virtual DbSet<Rsikeyword> Rsikeywords { get; set; }

    public virtual DbSet<Rsirulecode> Rsirulecodes { get; set; }

    public virtual DbSet<Rsistatus> Rsistatuses { get; set; }

    public virtual DbSet<SearchstatsComponent> SearchstatsComponents { get; set; }

    public virtual DbSet<SearchstatsQuery> SearchstatsQueries { get; set; }

    public virtual DbSet<SearchstatsSlice> SearchstatsSlices { get; set; }

    public virtual DbSet<SearchstatsStopcondition> SearchstatsStopconditions { get; set; }

    public virtual DbSet<SearchstatsTerm> SearchstatsTerms { get; set; }

    public virtual DbSet<Serverstatus> Serverstatuses { get; set; }

    public virtual DbSet<Signcount> Signcounts { get; set; }

    public virtual DbSet<Signinguser> Signingusers { get; set; }

    public virtual DbSet<Signtrail> Signtrails { get; set; }

    public virtual DbSet<Sovcontrolrule> Sovcontrolrules { get; set; }

    public virtual DbSet<Sovmgmtmsg> Sovmgmtmsgs { get; set; }

    public virtual DbSet<Spcjob> Spcjobs { get; set; }

    public virtual DbSet<Spcrequest> Spcrequests { get; set; }

    public virtual DbSet<Spcschedule> Spcschedules { get; set; }

    public virtual DbSet<Spcstatistic> Spcstatistics { get; set; }

    public virtual DbSet<SpecialCharacter> SpecialCharacters { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<Storagelocator> Storagelocators { get; set; }

    public virtual DbSet<Supportassetagent> Supportassetagents { get; set; }

    public virtual DbSet<Supportassetdatum> Supportassetdata { get; set; }

    public virtual DbSet<Supportassetfailedorder> Supportassetfailedorders { get; set; }

    public virtual DbSet<Supportassetorder> Supportassetorders { get; set; }

    public virtual DbSet<Systemlanguage> Systemlanguages { get; set; }

    public virtual DbSet<TempAll> TempAlls { get; set; }

    public virtual DbSet<TempDiffParent> TempDiffParents { get; set; }

    public virtual DbSet<TempDiffPerm> TempDiffPerms { get; set; }

    public virtual DbSet<TempExact> TempExacts { get; set; }

    public virtual DbSet<Termlevel> Termlevels { get; set; }

    public virtual DbSet<TestTable> TestTables { get; set; }

    public virtual DbSet<Theshistory> Theshistories { get; set; }

    public virtual DbSet<Thesrelation> Thesrelations { get; set; }

    public virtual DbSet<Thesterm> Thesterms { get; set; }

    public virtual DbSet<Timedue> Timedues { get; set; }

    public virtual DbSet<Timeoutgroup> Timeoutgroups { get; set; }

    public virtual DbSet<Todo> Todos { get; set; }

    public virtual DbSet<Todo2> Todo2s { get; set; }

    public virtual DbSet<Todo201> Todo201s { get; set; }

    public virtual DbSet<Todobase> Todobases { get; set; }

    public virtual DbSet<Transfer> Transfers { get; set; }

    public virtual DbSet<Ualarchive> Ualarchives { get; set; }

    public virtual DbSet<Ualarchivecertificate> Ualarchivecertificates { get; set; }

    public virtual DbSet<Ualarchivecomponent> Ualarchivecomponents { get; set; }

    public virtual DbSet<Ualarchivemode> Ualarchivemodes { get; set; }

    public virtual DbSet<Ualdocattribute> Ualdocattributes { get; set; }

    public virtual DbSet<Ualsapsystem> Ualsapsystems { get; set; }

    public virtual DbSet<Ualscanhost> Ualscanhosts { get; set; }

    public virtual DbSet<Ualscanhostarchivemode> Ualscanhostarchivemodes { get; set; }

    public virtual DbSet<UapiexplodeDynamicResultBase> UapiexplodeDynamicResultBases { get; set; }

    public virtual DbSet<UapiexplodeDynamicResultId> UapiexplodeDynamicResultIds { get; set; }

    public virtual DbSet<Ugenerator> Ugenerators { get; set; }

    public virtual DbSet<Undolabelinfo> Undolabelinfos { get; set; }

    public virtual DbSet<Updateagent> Updateagents { get; set; }

    public virtual DbSet<Updateagenthistory> Updateagenthistories { get; set; }

    public virtual DbSet<Userlabel> Userlabels { get; set; }

    public virtual DbSet<Usernickname> Usernicknames { get; set; }

    public virtual DbSet<Usertabright> Usertabrights { get; set; }

    public virtual DbSet<Viewxoption> Viewxoptions { get; set; }

    public virtual DbSet<Viewxpublication> Viewxpublications { get; set; }

    public virtual DbSet<Waudittrail> Waudittrails { get; set; }

    public virtual DbSet<Wdatum> Wdata { get; set; }

    public virtual DbSet<Webactivework> Webactiveworks { get; set; }

    public virtual DbSet<Webactiveworkbase> Webactiveworkbases { get; set; }

    public virtual DbSet<Webeditlock> Webeditlocks { get; set; }

    public virtual DbSet<Webeditlockunreserve> Webeditlockunreserves { get; set; }

    public virtual DbSet<Webnode> Webnodes { get; set; }

    public virtual DbSet<WebnodesTrTr> WebnodesTrTrs { get; set; }

    public virtual DbSet<WebnodesbrowseTrTr> WebnodesbrowseTrTrs { get; set; }

    public virtual DbSet<Webnodescatalog> Webnodescatalogs { get; set; }

    public virtual DbSet<WebnodescatalogsTrTr> WebnodescatalogsTrTrs { get; set; }

    public virtual DbSet<WebnodesdeletedTrTr> WebnodesdeletedTrTrs { get; set; }

    public virtual DbSet<Webnodesdisplay> Webnodesdisplays { get; set; }

    public virtual DbSet<Webnodesfilter> Webnodesfilters { get; set; }

    public virtual DbSet<WebnodesmetaTrTr> WebnodesmetaTrTrs { get; set; }

    public virtual DbSet<Webreport> Webreports { get; set; }

    public virtual DbSet<Webreportstat> Webreportstats { get; set; }

    public virtual DbSet<Webreporttrigger> Webreporttriggers { get; set; }

    public virtual DbSet<Webreportugtrigger> Webreportugtriggers { get; set; }

    public virtual DbSet<Wfassignmentsconfiguration> Wfassignmentsconfigurations { get; set; }

    public virtual DbSet<Wfattrdataversion> Wfattrdataversions { get; set; }

    public virtual DbSet<Wfattrdatum> Wfattrdata { get; set; }

    public virtual DbSet<Wfcomment> Wfcomments { get; set; }

    public virtual DbSet<Wfdisposition> Wfdispositions { get; set; }

    public virtual DbSet<Wfform> Wfforms { get; set; }

    public virtual DbSet<Wfformslock> Wfformslocks { get; set; }

    public virtual DbSet<Wfformsversion> Wfformsversions { get; set; }

    public virtual DbSet<Wikilink> Wikilinks { get; set; }

    public virtual DbSet<Wikiredirect> Wikiredirects { get; set; }

    public virtual DbSet<Windexnotify> Windexnotifies { get; set; }

    public virtual DbSet<Wlock> Wlocks { get; set; }

    public virtual DbSet<Wmap> Wmaps { get; set; }

    public virtual DbSet<Wmaptask> Wmaptasks { get; set; }

    public virtual DbSet<Wopifailedsession> Wopifailedsessions { get; set; }

    public virtual DbSet<Wopisession> Wopisessions { get; set; }

    public virtual DbSet<Wopiticket> Wopitickets { get; set; }

    public virtual DbSet<Wopiuserinfo> Wopiuserinfos { get; set; }

    public virtual DbSet<Wopiusernotify> Wopiusernotifies { get; set; }

    public virtual DbSet<Workerpackage> Workerpackages { get; set; }

    public virtual DbSet<Workerqueue> Workerqueues { get; set; }

    public virtual DbSet<Workerqueuechild> Workerqueuechildren { get; set; }

    public virtual DbSet<Workerqueuecomplete> Workerqueuecompletes { get; set; }

    public virtual DbSet<Workerqueuecurrent> Workerqueuecurrents { get; set; }

    public virtual DbSet<Workerqueueerror> Workerqueueerrors { get; set; }

    public virtual DbSet<Workerqueuepending> Workerqueuependings { get; set; }

    public virtual DbSet<Workerqueuetracking> Workerqueuetrackings { get; set; }

    public virtual DbSet<Workerstatus> Workerstatuses { get; set; }

    public virtual DbSet<Wsubwork> Wsubworks { get; set; }

    public virtual DbSet<Wsubworktask> Wsubworktasks { get; set; }

    public virtual DbSet<Wsubworktaskdatesummary> Wsubworktaskdatesummaries { get; set; }

    public virtual DbSet<Wwork> Wworks { get; set; }

    public virtual DbSet<Wworkacl> Wworkacls { get; set; }

    public virtual DbSet<Wworkaudit> Wworkaudits { get; set; }

    public virtual DbSet<XecmgovAssignment> XecmgovAssignments { get; set; }

    public virtual DbSet<XecmgovAssignmentrecipient> XecmgovAssignmentrecipients { get; set; }

    public virtual DbSet<XecmgovAssignmentstatus> XecmgovAssignmentstatuses { get; set; }

    public virtual DbSet<XecmgovAssignmentstatusmultilingual> XecmgovAssignmentstatusmultilinguals { get; set; }

    public virtual DbSet<XecmgovClassificationsrecursiontype> XecmgovClassificationsrecursiontypes { get; set; }

    public virtual DbSet<XecmgovCloseditem> XecmgovCloseditems { get; set; }

    public virtual DbSet<XecmgovDeleteAudit> XecmgovDeleteAudits { get; set; }

    public virtual DbSet<XecmgovDynwfactivitytaskevent> XecmgovDynwfactivitytaskevents { get; set; }

    public virtual DbSet<XecmgovForward> XecmgovForwards { get; set; }

    public virtual DbSet<XecmgovForwarddirective> XecmgovForwarddirectives { get; set; }

    public virtual DbSet<XecmgovForwarddirectivesmultilingual> XecmgovForwarddirectivesmultilinguals { get; set; }

    public virtual DbSet<XecmgovForwarditem> XecmgovForwarditems { get; set; }

    public virtual DbSet<XecmgovForwardrecipient> XecmgovForwardrecipients { get; set; }

    public virtual DbSet<XecmgovInboxfolder> XecmgovInboxfolders { get; set; }

    public virtual DbSet<XecmgovOutboxevent> XecmgovOutboxevents { get; set; }

    public virtual DbSet<XecmgovxdomeaJob> XecmgovxdomeaJobs { get; set; }

    public virtual DbSet<XecmgovxdomeaJobprocess> XecmgovxdomeaJobprocesses { get; set; }

    public virtual DbSet<XecmgovxdomeaSelectiondatum> XecmgovxdomeaSelectiondata { get; set; }

    public virtual DbSet<XecmpfAppintgnActInfo> XecmpfAppintgnActInfos { get; set; }

    public virtual DbSet<XecmpfAppintgnActTaskinfo> XecmpfAppintgnActTaskinfos { get; set; }

    public virtual DbSet<XecmpfAppintgnDoctypeClassification> XecmpfAppintgnDoctypeClassifications { get; set; }

    public virtual DbSet<XecmpfAppintgnDoctypeClasspermission> XecmpfAppintgnDoctypeClasspermissions { get; set; }

    public virtual DbSet<XecmpfAppintgnDpermission> XecmpfAppintgnDpermissions { get; set; }

    public virtual DbSet<XecmpfAppintgnStructuredtemplatesconfig> XecmpfAppintgnStructuredtemplatesconfigs { get; set; }

    public virtual DbSet<XecmpfAppintgnTaskActInfo> XecmpfAppintgnTaskActInfos { get; set; }

    public virtual DbSet<XecmpfMultilingualCfg> XecmpfMultilingualCfgs { get; set; }

    public virtual DbSet<XecmpfPdAttrdatum> XecmpfPdAttrdata { get; set; }

    public virtual DbSet<XecmpfPulseLink> XecmpfPulseLinks { get; set; }

    public virtual DbSet<XecmpfPulseMetadatum> XecmpfPulseMetadata { get; set; }

    public virtual DbSet<XecmpfPulseRawMetadatum> XecmpfPulseRawMetadata { get; set; }

    public virtual DbSet<XecmpfbulkJobDefinition> XecmpfbulkJobDefinitions { get; set; }

    public virtual DbSet<XecmpfbulkJobHistory> XecmpfbulkJobHistories { get; set; }

    public virtual DbSet<XecmpfbulkSubTask> XecmpfbulkSubTasks { get; set; }

    public virtual DbSet<XecmpfccDocvalRole> XecmpfccDocvalRoles { get; set; }

    public virtual DbSet<XecmpfccDocvalRolesBkup> XecmpfccDocvalRolesBkups { get; set; }

    public virtual DbSet<XecmpfccDocvalRule> XecmpfccDocvalRules { get; set; }

    public virtual DbSet<Xecmpfccreviewticket> Xecmpfccreviewtickets { get; set; }

    public virtual DbSet<Xecmpfcompletenessinfo> Xecmpfcompletenessinfos { get; set; }

    public virtual DbSet<Xecmpfcompletenessjobqueue> Xecmpfcompletenessjobqueues { get; set; }

    public virtual DbSet<XecmpfeacActionAttrMap> XecmpfeacActionAttrMaps { get; set; }

    public virtual DbSet<XecmpfeacActionCfg> XecmpfeacActionCfgs { get; set; }

    public virtual DbSet<XecmpfeacEvent> XecmpfeacEvents { get; set; }

    public virtual DbSet<XecmpfeacEventdefProperty> XecmpfeacEventdefProperties { get; set; }

    public virtual DbSet<XecmpfeacRule> XecmpfeacRules { get; set; }

    public virtual DbSet<XecmpfeacRuleCnd> XecmpfeacRuleCnds { get; set; }

    public virtual DbSet<XecmpfeacSeqnr> XecmpfeacSeqnrs { get; set; }

    public virtual DbSet<XecmpfnaAttDecDefinition> XecmpfnaAttDecDefinitions { get; set; }

    public virtual DbSet<XecmpfnaDocument> XecmpfnaDocuments { get; set; }

    public virtual DbSet<XecmpfnaSeqnr> XecmpfnaSeqnrs { get; set; }

    public virtual DbSet<XecmpfxoDelMessage> XecmpfxoDelMessages { get; set; }

    public virtual DbSet<XecmpfxoProvDatum> XecmpfxoProvData { get; set; }

    public virtual DbSet<XecmpfxoRecord> XecmpfxoRecords { get; set; }

    public virtual DbSet<XecmpfxoVersion> XecmpfxoVersions { get; set; }

    public virtual DbSet<Xengadnid> Xengadnids { get; set; }

    public virtual DbSet<Xengadnidstartseq> Xengadnidstartseqs { get; set; }

    public virtual DbSet<Xengadnref> Xengadnrefs { get; set; }

    public virtual DbSet<XengcadAttribute> XengcadAttributes { get; set; }

    public virtual DbSet<XengcadRegionAttribute> XengcadRegionAttributes { get; set; }

    public virtual DbSet<XengcadRelation> XengcadRelations { get; set; }

    public virtual DbSet<XengcadRelationshipType> XengcadRelationshipTypes { get; set; }

    public virtual DbSet<XengcadStructuredAttribute> XengcadStructuredAttributes { get; set; }

    public virtual DbSet<XengcrtArchivedRevision> XengcrtArchivedRevisions { get; set; }

    public virtual DbSet<XengcrtProjectWorkspace> XengcrtProjectWorkspaces { get; set; }

    public virtual DbSet<XengcrtRevCtrlDoctype> XengcrtRevCtrlDoctypes { get; set; }

    public virtual DbSet<XengcrtRevCtrlSetting> XengcrtRevCtrlSettings { get; set; }

    public virtual DbSet<XengcrtRevCtrlWfMapping> XengcrtRevCtrlWfMappings { get; set; }

    public virtual DbSet<XengcrtRevCtrlWorkspace> XengcrtRevCtrlWorkspaces { get; set; }

    public virtual DbSet<XengcrtRevision> XengcrtRevisions { get; set; }

    public virtual DbSet<XengcrtRevisionScheme> XengcrtRevisionSchemes { get; set; }

    public virtual DbSet<XengcrtRevisionStatus> XengcrtRevisionStatuses { get; set; }

    public virtual DbSet<XengseDeliverable> XengseDeliverables { get; set; }

    public virtual DbSet<XengseWkspEntityMapping> XengseWkspEntityMappings { get; set; }

    public virtual DbSet<XengseWorkspace> XengseWorkspaces { get; set; }

    public virtual DbSet<Xengseinstancemap> Xengseinstancemaps { get; set; }

    public virtual DbSet<Xengsemapping> Xengsemappings { get; set; }

    public virtual DbSet<Xengserecipientmap> Xengserecipientmaps { get; set; }

    public virtual DbSet<Xengsesharemap> Xengsesharemaps { get; set; }

    public virtual DbSet<Xengsesynctrigger> Xengsesynctriggers { get; set; }

    public virtual DbSet<XengsfmCatattrPerformer> XengsfmCatattrPerformers { get; set; }

    public virtual DbSet<XengsfmDdmRoleMap> XengsfmDdmRoleMaps { get; set; }

    public virtual DbSet<XengsfmDocumentDistMatrix> XengsfmDocumentDistMatrices { get; set; }

    public virtual DbSet<XengsfmPerformer> XengsfmPerformers { get; set; }

    public virtual DbSet<XengsfmPermission> XengsfmPermissions { get; set; }

    public virtual DbSet<XengsfmRoleMapping> XengsfmRoleMappings { get; set; }

    public virtual DbSet<XengsfmState> XengsfmStates { get; set; }

    public virtual DbSet<XengsfmStateFlow> XengsfmStateFlows { get; set; }

    public virtual DbSet<XengsfmStateFlowAudit> XengsfmStateFlowAudits { get; set; }

    public virtual DbSet<XengsfmStateFlowMapping> XengsfmStateFlowMappings { get; set; }

    public virtual DbSet<XengsfmStatusFlowAuditArchived> XengsfmStatusFlowAuditArchiveds { get; set; }

    public virtual DbSet<XengsfmTransition> XengsfmTransitions { get; set; }

    public virtual DbSet<Xengtmtag> Xengtmtags { get; set; }

    public virtual DbSet<Xengtmtagrelation> Xengtmtagrelations { get; set; }

    public virtual DbSet<XengtransDatum> XengtransData { get; set; }

    public virtual DbSet<XengtransDocumentDatum> XengtransDocumentData { get; set; }

    public virtual DbSet<XengtransEmailSetting> XengtransEmailSettings { get; set; }

    public virtual DbSet<XengtransInbUpdProcessing> XengtransInbUpdProcessings { get; set; }

    public virtual DbSet<XengtransInboundSetting> XengtransInboundSettings { get; set; }

    public virtual DbSet<XengtransInboundUpdate> XengtransInboundUpdates { get; set; }

    public virtual DbSet<XengtransRecipientDatum> XengtransRecipientData { get; set; }

    public virtual DbSet<XengtransSetting> XengtransSettings { get; set; }

    public virtual DbSet<Xengtransextuser> Xengtransextusers { get; set; }

    public virtual DbSet<Xengtransextusergroup> Xengtransextusergroups { get; set; }

    public virtual DbSet<Xengtranstemplate> Xengtranstemplates { get; set; }

    public virtual DbSet<ZotDokumanbakim> ZotDokumanbakims { get; set; }

    public virtual DbSet<ZotxKysDokumanturu> ZotxKysDokumanturus { get; set; }

    public virtual DbSet<ZotxKysgorevmailbakim> ZotxKysgorevmailbakims { get; set; }

    public virtual DbSet<ZotxSirketbakim> ZotxSirketbakims { get; set; }

    public virtual DbSet<ZzzTestTemplateSilinecek> ZzzTestTemplateSilineceks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accession>(entity =>
        {
            entity.HasKey(e => e.Accession1);
            entity.ToTable("ACCESSION");

            entity.Property(e => e.Accession1)
                .HasMaxLength(32)
                .HasColumnName("ACCESSION");
            entity.Property(e => e.AccessionDescE)
                .HasMaxLength(128)
                .HasColumnName("ACCESSION_DESC_E");
            entity.Property(e => e.AccessionDescF)
                .HasMaxLength(128)
                .HasColumnName("ACCESSION_DESC_F");
        });

        modelBuilder.Entity<Activeviewoverride>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("ACTIVEVIEWOVERRIDES");

            entity.Property(e => e.Activeviewtype)
                .HasMaxLength(128)
                .HasColumnName("ACTIVEVIEWTYPE");
            entity.Property(e => e.Avid).HasColumnName("AVID");
            entity.Property(e => e.Cascadevalue).HasColumnName("CASCADEVALUE");
            entity.Property(e => e.Expression)
                .HasColumnType("NCLOB")
                .HasColumnName("EXPRESSION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Overrideclass).HasColumnName("OVERRIDECLASS");
            entity.Property(e => e.Overrideinfo)
                .HasMaxLength(64)
                .HasColumnName("OVERRIDEINFO");
            entity.Property(e => e.Pmancompatible).HasColumnName("PMANCOMPATIBLE");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Ruledata)
                .HasColumnType("NCLOB")
                .HasColumnName("RULEDATA");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
        });

        modelBuilder.Entity<Activeviewpreselect>(entity =>
        {
            entity.HasKey(e => new { e.Appearanceid, e.Avselector });
            entity.ToTable("ACTIVEVIEWPRESELECT");

            entity.Property(e => e.Appearanceid)
                .HasMaxLength(32)
                .HasColumnName("APPEARANCEID");
            entity.Property(e => e.Avdata)
                .HasColumnType("NCLOB")
                .HasColumnName("AVDATA");
            entity.Property(e => e.Avselector)
                .HasMaxLength(32)
                .HasColumnName("AVSELECTOR");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
        });

        modelBuilder.Entity<Agentconfig>(entity =>
        {
            entity.HasKey(e => e.Configid);
            entity.ToTable("AGENTCONFIG");

            entity.Property(e => e.Configid).HasColumnName("CONFIGID");
            entity.Property(e => e.Dftmsgdatabasename)
                .HasMaxLength(64)
                .HasColumnName("DFTMSGDATABASENAME");
            entity.Property(e => e.Dftmsgfromaddress)
                .HasMaxLength(255)
                .HasColumnName("DFTMSGFROMADDRESS");
            entity.Property(e => e.Dftmsghtmlfilename)
                .HasMaxLength(64)
                .HasColumnName("DFTMSGHTMLFILENAME");
            entity.Property(e => e.Dftmsgreplyto)
                .HasMaxLength(255)
                .HasColumnName("DFTMSGREPLYTO");
            entity.Property(e => e.Dftmsgsubject)
                .HasMaxLength(255)
                .HasColumnName("DFTMSGSUBJECT");
            entity.Property(e => e.Dftmsgtype).HasColumnName("DFTMSGTYPE");
            entity.Property(e => e.Dftreportid).HasColumnName("DFTREPORTID");
            entity.Property(e => e.Dftreportoptions)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTREPORTOPTIONS");
            entity.Property(e => e.Dftsched1daymask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED1DAYMASK");
            entity.Property(e => e.Dftsched1hourmask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED1HOURMASK");
            entity.Property(e => e.Dftsched1minutemask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED1MINUTEMASK");
            entity.Property(e => e.Dftsched1monthmask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED1MONTHMASK");
            entity.Property(e => e.Dftsched1name)
                .HasMaxLength(64)
                .HasColumnName("DFTSCHED1NAME");
            entity.Property(e => e.Dftsched2daymask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED2DAYMASK");
            entity.Property(e => e.Dftsched2hourmask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED2HOURMASK");
            entity.Property(e => e.Dftsched2minutemask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED2MINUTEMASK");
            entity.Property(e => e.Dftsched2monthmask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED2MONTHMASK");
            entity.Property(e => e.Dftsched2name)
                .HasMaxLength(64)
                .HasColumnName("DFTSCHED2NAME");
            entity.Property(e => e.Dftsched3daymask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED3DAYMASK");
            entity.Property(e => e.Dftsched3hourmask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED3HOURMASK");
            entity.Property(e => e.Dftsched3minutemask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED3MINUTEMASK");
            entity.Property(e => e.Dftsched3monthmask)
                .HasColumnType("INTEGER")
                .HasColumnName("DFTSCHED3MONTHMASK");
            entity.Property(e => e.Dftsched3name)
                .HasMaxLength(64)
                .HasColumnName("DFTSCHED3NAME");
            entity.Property(e => e.Dfttransportid).HasColumnName("DFTTRANSPORTID");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Lasttime).HasColumnName("LASTTIME");
            entity.Property(e => e.Mapipassword)
                .HasMaxLength(32)
                .HasColumnName("MAPIPASSWORD");
            entity.Property(e => e.Mapiprofile)
                .HasMaxLength(64)
                .HasColumnName("MAPIPROFILE");
            entity.Property(e => e.Onerraddress)
                .HasMaxLength(255)
                .HasColumnName("ONERRADDRESS");
            entity.Property(e => e.Onerrsubject)
                .HasMaxLength(64)
                .HasColumnName("ONERRSUBJECT");
            entity.Property(e => e.Onerrtransportid).HasColumnName("ONERRTRANSPORTID");
            entity.Property(e => e.Smtpauth).HasColumnName("SMTPAUTH");
            entity.Property(e => e.Smtpauthmethod).HasColumnName("SMTPAUTHMETHOD");
            entity.Property(e => e.Smtpencryptionmethod)
                .HasMaxLength(255)
                .HasColumnName("SMTPENCRYPTIONMETHOD");
            entity.Property(e => e.Smtphelohostname)
                .HasMaxLength(64)
                .HasColumnName("SMTPHELOHOSTNAME");
            entity.Property(e => e.Smtppassword)
                .HasMaxLength(255)
                .HasColumnName("SMTPPASSWORD");
            entity.Property(e => e.Smtpport)
                .HasColumnType("INTEGER")
                .HasColumnName("SMTPPORT");
            entity.Property(e => e.Smtpserver)
                .HasMaxLength(255)
                .HasColumnName("SMTPSERVER");
            entity.Property(e => e.Smtpssl).HasColumnName("SMTPSSL");
            entity.Property(e => e.Smtptimeout).HasColumnName("SMTPTIMEOUT");
            entity.Property(e => e.Smtpusername)
                .HasMaxLength(255)
                .HasColumnName("SMTPUSERNAME");
            entity.Property(e => e.Sqltracing)
                .HasColumnType("INTEGER")
                .HasColumnName("SQLTRACING");
            entity.Property(e => e.Testing)
                .HasColumnType("INTEGER")
                .HasColumnName("TESTING");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Agentschedule>(entity =>
        {
            entity.HasKey(e => new { e.Nexttime, e.Agentid });
            entity.ToTable("AGENTSCHEDULE");

            entity.Property(e => e.Agentid)
                .HasColumnType("INTEGER")
                .HasColumnName("AGENTID");
            entity.Property(e => e.Agentname)
                .HasMaxLength(255)
                .HasColumnName("AGENTNAME");
            entity.Property(e => e.Daymask)
                .HasColumnType("INTEGER")
                .HasColumnName("DAYMASK");
            entity.Property(e => e.Enabled)
                .HasColumnType("INTEGER")
                .HasColumnName("ENABLED");
            entity.Property(e => e.Hourmask)
                .HasColumnType("INTEGER")
                .HasColumnName("HOURMASK");
            entity.Property(e => e.Lasttime).HasColumnName("LASTTIME");
            entity.Property(e => e.Minutemask)
                .HasColumnType("INTEGER")
                .HasColumnName("MINUTEMASK");
            entity.Property(e => e.Monthmask)
                .HasColumnType("INTEGER")
                .HasColumnName("MONTHMASK");
            entity.Property(e => e.Msgaddress)
                .HasMaxLength(255)
                .HasColumnName("MSGADDRESS");
            entity.Property(e => e.Msgtype)
                .HasColumnType("INTEGER")
                .HasColumnName("MSGTYPE");
            entity.Property(e => e.Nexttime).HasColumnName("NEXTTIME");
            entity.Property(e => e.Paramint1)
                .HasColumnType("INTEGER")
                .HasColumnName("PARAMINT1");
            entity.Property(e => e.Paramint2)
                .HasColumnType("INTEGER")
                .HasColumnName("PARAMINT2");
            entity.Property(e => e.Paramstr3)
                .HasMaxLength(255)
                .HasColumnName("PARAMSTR3");
            entity.Property(e => e.Paramstr4)
                .HasMaxLength(255)
                .HasColumnName("PARAMSTR4");
            entity.Property(e => e.Reportid).HasColumnName("REPORTID");
            entity.Property(e => e.Reportoptions)
                .HasColumnType("INTEGER")
                .HasColumnName("REPORTOPTIONS");
            entity.Property(e => e.Schedid).HasColumnName("SCHEDID");
            entity.Property(e => e.Timezoneoffset)
                .HasColumnType("INTEGER")
                .HasColumnName("TIMEZONEOFFSET");
            entity.Property(e => e.Transportid).HasColumnName("TRANSPORTID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Agenttodolist>(entity =>
        {
            entity.HasKey(e => new { e.Workid, e.Subworkid, e.Taskid, e.Tasktype });
            entity.ToTable("AGENTTODOLIST");

            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Tasktype)
                .HasColumnType("INTEGER")
                .HasColumnName("TASKTYPE");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Aicontainer>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("AICONTAINER");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Alfilter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ALFILTER");

            entity.Property(e => e.Hostname)
                .HasMaxLength(64)
                .HasColumnName("HOSTNAME");
            entity.Property(e => e.Port).HasColumnName("PORT");
        });

        modelBuilder.Entity<Archivedwork>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARCHIVEDWORK");

            entity.Property(e => e.MapMapid).HasColumnName("MAP_MAPID");
            entity.Property(e => e.MapMapobjid).HasColumnName("MAP_MAPOBJID");
            entity.Property(e => e.SubworkDateinitiated).HasColumnName("SUBWORK_DATEINITIATED");
            entity.Property(e => e.SubworkReturnsubworkid).HasColumnName("SUBWORK_RETURNSUBWORKID");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworkUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORK_USERDATA");
            entity.Property(e => e.WorkDatedueMax).HasColumnName("WORK_DATEDUE_MAX");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkManageridName)
                .HasMaxLength(255)
                .HasColumnName("WORK_MANAGERID_NAME");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Archivedworkbase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARCHIVEDWORKBASE");

            entity.Property(e => e.MapMapid).HasColumnName("MAP_MAPID");
            entity.Property(e => e.MapMapobjid).HasColumnName("MAP_MAPOBJID");
            entity.Property(e => e.SubworkDateinitiated).HasColumnName("SUBWORK_DATEINITIATED");
            entity.Property(e => e.SubworkReturnsubworkid).HasColumnName("SUBWORK_RETURNSUBWORKID");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworkUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORK_USERDATA");
            entity.Property(e => e.WorkDatedueMax).HasColumnName("WORK_DATEDUE_MAX");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => new { e.Facility, e.Area1 });
            entity.ToTable("AREA");

            entity.Property(e => e.Area1)
                .HasMaxLength(32)
                .HasColumnName("AREA");
            entity.Property(e => e.DescE)
                .HasMaxLength(128)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Facility)
                .HasMaxLength(32)
                .HasColumnName("FACILITY");
        });

        modelBuilder.Entity<Assignee>(entity =>
        {
            entity.HasKey(e => e.Assignedto);
            entity.ToTable("ASSIGNEES");

            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Auditcollectionsitem>(entity =>
        {
            entity.HasKey(e => e.Sequencenumber);
            entity.ToTable("AUDITCOLLECTIONSITEMS");

            entity.Property(e => e.Discoveryperm).HasColumnName("DISCOVERYPERM");
            entity.Property(e => e.Fromlocationid).HasColumnName("FROMLOCATIONID");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Operation)
                .HasMaxLength(255)
                .HasColumnName("OPERATION");
            entity.Property(e => e.Sequencenumber).HasColumnName("SEQUENCENUMBER");
            entity.Property(e => e.Status)
                .HasColumnType("NCLOB")
                .HasColumnName("STATUS");
            entity.Property(e => e.Tolocationid).HasColumnName("TOLOCATIONID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Userlocation)
                .HasMaxLength(64)
                .HasColumnName("USERLOCATION");
            entity.Property(e => e.Userlogin)
                .HasMaxLength(255)
                .HasColumnName("USERLOGIN");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<BarcodeDatum>(entity =>
        {
            entity.HasKey(e => e.Barcodeid);
            entity.ToTable("BARCODE_DATA");

            entity.Property(e => e.Barcodedate).HasColumnName("BARCODEDATE");
            entity.Property(e => e.Barcodeid).HasColumnName("BARCODEID");
            entity.Property(e => e.Creatorid).HasColumnName("CREATORID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Docname)
                .HasMaxLength(248)
                .HasColumnName("DOCNAME");
            entity.Property(e => e.Scandate).HasColumnName("SCANDATE");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
        });

        modelBuilder.Entity<BarcodeSeqnr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BARCODE_SEQNR");

            entity.Property(e => e.Lastused).HasColumnName("LASTUSED");
        });

        modelBuilder.Entity<Bestbetsdatum>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("BESTBETSDATA");

            entity.Property(e => e.Bestbet)
                .HasMaxLength(248)
                .HasColumnName("BESTBET");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Expiry).HasColumnName("EXPIRY");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
        });

        modelBuilder.Entity<Bestbetssearch>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("BESTBETSSEARCH");

            entity.Property(e => e.Bestbetsearch)
                .HasMaxLength(248)
                .HasColumnName("BESTBETSEARCH");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Expired).HasColumnName("EXPIRED");
        });

        modelBuilder.Entity<Blobdatum>(entity =>
        {
            entity.HasKey(e => new { e.Longid, e.Segmentid, e.Ownerid });
            entity.ToTable("BLOBDATA");

            entity.Property(e => e.Longid).HasColumnName("LONGID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Segment)
                .HasColumnType("BLOB")
                .HasColumnName("SEGMENT");
            entity.Property(e => e.Segmentid)
                .HasColumnType("INTEGER")
                .HasColumnName("SEGMENTID");
        });

        modelBuilder.Entity<Blobresdatum>(entity =>
        {
            entity.HasKey(e => new { e.Longid, e.Segmentid, e.Ownerid });
            entity.ToTable("BLOBRESDATA");

            entity.Property(e => e.Longid).HasColumnName("LONGID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Segment)
                .HasColumnType("BLOB")
                .HasColumnName("SEGMENT");
            entity.Property(e => e.Segmentid)
                .HasColumnType("INTEGER")
                .HasColumnName("SEGMENTID");
        });

        modelBuilder.Entity<Bravaredactreason>(entity =>
        {
            entity.HasKey(e => e.Redactreasonid);

            entity.ToTable("BRAVAREDACTREASONS");

            entity.Property(e => e.Redactreasonid)
                .ValueGeneratedNever()
                .HasColumnName("REDACTREASONID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Entrydate).HasColumnName("ENTRYDATE");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Originversionnum).HasColumnName("ORIGINVERSIONNUM");
            entity.Property(e => e.Reasoncount).HasColumnName("REASONCOUNT");
            entity.Property(e => e.Reasontext)
                .HasColumnType("NCLOB")
                .HasColumnName("REASONTEXT");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Bravathumb>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Versionnum, e.Thumbsize });

            entity.ToTable("BRAVATHUMBS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Thumbsize).HasColumnName("THUMBSIZE");
            entity.Property(e => e.Complete).HasColumnName("COMPLETE");
            entity.Property(e => e.Errmsg)
                .HasColumnType("NCLOB")
                .HasColumnName("ERRMSG");
            entity.Property(e => e.Numtries).HasColumnName("NUMTRIES");
            entity.Property(e => e.Reqtime).HasColumnName("REQTIME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<Bravauser>(entity =>
        {
            entity.HasKey(e => e.Privid);

            entity.ToTable("BRAVAUSERS");

            entity.Property(e => e.Privid)
                .ValueGeneratedNever()
                .HasColumnName("PRIVID");
            entity.Property(e => e.Dirty).HasColumnName("DIRTY");
            entity.Property(e => e.Newprivs).HasColumnName("NEWPRIVS");
            entity.Property(e => e.Privs).HasColumnName("PRIVS");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.Serverid).HasColumnName("SERVERID");
        });

        modelBuilder.Entity<Bravaversdatum>(entity =>
        {
            entity.HasKey(e => new { e.Versionid, e.Dataid, e.Versionnum });

            entity.ToTable("BRAVAVERSDATA");

            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Assocdata)
                .HasColumnType("NCLOB")
                .HasColumnName("ASSOCDATA");
        });

        modelBuilder.Entity<CasebaseSeqnr>(entity =>
        {
            entity.HasKey(e => e.Seqname);
            entity.ToTable("CASEBASE_SEQNR");

            entity.Property(e => e.Lastused).HasColumnName("LASTUSED");
            entity.Property(e => e.Seqname)
                .HasMaxLength(64)
                .HasColumnName("SEQNAME");
        });

        modelBuilder.Entity<Catregionmap>(entity =>
        {
            entity.HasKey(e => e.Regionname);
            entity.ToTable("CATREGIONMAP");

            entity.Property(e => e.Attrname)
                .HasMaxLength(248)
                .HasColumnName("ATTRNAME");
            entity.Property(e => e.Attrtype)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRTYPE");
            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Catname)
                .HasMaxLength(248)
                .HasColumnName("CATNAME");
            entity.Property(e => e.Regionname)
                .HasMaxLength(128)
                .HasColumnName("REGIONNAME");
            entity.Property(e => e.Reportinglevel)
                .HasDefaultValueSql("2")
                .HasColumnType("INTEGER")
                .HasColumnName("REPORTINGLEVEL");
            entity.Property(e => e.Setname)
                .HasMaxLength(248)
                .HasColumnName("SETNAME");
        });

        modelBuilder.Entity<Ccm>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Blokajkodu)
                .HasMaxLength(255)
                .HasColumnName("BLOKAJKODU");
            entity.Property(e => e.Blokajtanim)
                .HasMaxLength(255)
                .HasColumnName("BLOKAJTANIM");
            entity.Property(e => e.Damgavergisiaciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("DAMGAVERGISIACIKLAMA");
            entity.Property(e => e.Damgavergisitutari)
                .HasMaxLength(255)
                .HasColumnName("DAMGAVERGISITUTARI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dokid)
                .HasMaxLength(255)
                .HasColumnName("DOKID");
            entity.Property(e => e.Ek)
                .HasMaxLength(255)
                .HasColumnName("EK");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3)
                .HasMaxLength(255)
                .HasColumnName("EKALAN3");
            entity.Property(e => e.Ekprotokolnedeni)
                .HasColumnType("NCLOB")
                .HasColumnName("EKPROTOKOLNEDENI");
            entity.Property(e => e.Erpkodu)
                .HasMaxLength(255)
                .HasColumnName("ERPKODU");
            entity.Property(e => e.Gm).HasColumnName("GM");
            entity.Property(e => e.Gmonay)
                .HasColumnType("INTEGER")
                .HasColumnName("GMONAY");
            entity.Property(e => e.Gmy).HasColumnName("GMY");
            entity.Property(e => e.Hiyerarsikod)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSIKOD");
            entity.Property(e => e.Hiyerarsitanim)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSITANIM");
            entity.Property(e => e.Hukuksorumlusu).HasColumnName("HUKUKSORUMLUSU");
            entity.Property(e => e.Ilgiliavukat).HasColumnName("ILGILIAVUKAT");
            entity.Property(e => e.Ilgiliavukatatanmatarihi).HasColumnName("ILGILIAVUKATATANMATARIHI");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Imzalidokid)
                .HasMaxLength(255)
                .HasColumnName("IMZALIDOKID");
            entity.Property(e => e.Imzasirkusu)
                .HasMaxLength(255)
                .HasColumnName("IMZASIRKUSU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Kategori)
                .HasMaxLength(255)
                .HasColumnName("KATEGORI");
            entity.Property(e => e.Kepadresi)
                .HasMaxLength(255)
                .HasColumnName("KEPADRESI");
            entity.Property(e => e.Kid)
                .HasMaxLength(255)
                .HasColumnName("KID");
            entity.Property(e => e.Kontratadi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATADI");
            entity.Property(e => e.Kontratbaslangictarihi).HasColumnName("KONTRATBASLANGICTARIHI");
            entity.Property(e => e.Kontratbitistarihi).HasColumnName("KONTRATBITISTARIHI");
            entity.Property(e => e.Kontratgecerliliksuresi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATGECERLILIKSURESI");
            entity.Property(e => e.Kontratimzatarihi).HasColumnName("KONTRATIMZATARIHI");
            entity.Property(e => e.Kontratnumarasi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATNUMARASI");
            entity.Property(e => e.Kontratparabirimi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATPARABIRIMI");
            entity.Property(e => e.Kontratreferansnumarasi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATREFERANSNUMARASI");
            entity.Property(e => e.Kontratsablon)
                .HasMaxLength(255)
                .HasColumnName("KONTRATSABLON");
            entity.Property(e => e.Kontratsorumlusu).HasColumnName("KONTRATSORUMLUSU");
            entity.Property(e => e.Kontratsurectip)
                .HasMaxLength(255)
                .HasColumnName("KONTRATSURECTIP");
            entity.Property(e => e.Kontratturu)
                .HasMaxLength(255)
                .HasColumnName("KONTRATTURU");
            entity.Property(e => e.Kontrattutari)
                .HasMaxLength(255)
                .HasColumnName("KONTRATTUTARI");
            entity.Property(e => e.Kontrattutarkontrolu)
                .HasColumnType("INTEGER")
                .HasColumnName("KONTRATTUTARKONTROLU");
            entity.Property(e => e.Odemesekli)
                .HasMaxLength(255)
                .HasColumnName("ODEMESEKLI");
            entity.Property(e => e.Oncelik)
                .HasMaxLength(255)
                .HasColumnName("ONCELIK");
            entity.Property(e => e.Oncelikneden)
                .HasColumnType("NCLOB")
                .HasColumnName("ONCELIKNEDEN");
            entity.Property(e => e.Otomatikyenileme)
                .HasColumnType("INTEGER")
                .HasColumnName("OTOMATIKYENILEME");
            entity.Property(e => e.Otomatikyenilemesuresi)
                .HasMaxLength(255)
                .HasColumnName("OTOMATIKYENILEMESURESI");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Ret).HasColumnName("RET");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Sasno)
                .HasMaxLength(255)
                .HasColumnName("SASNO");
            entity.Property(e => e.Satinalmamuduru).HasColumnName("SATINALMAMUDURU");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Slcstatu)
                .HasMaxLength(255)
                .HasColumnName("SLCSTATU");
            entity.Property(e => e.Sorulistesi)
                .HasMaxLength(255)
                .HasColumnName("SORULISTESI");
            entity.Property(e => e.Sorulistesitercih)
                .HasColumnType("INTEGER")
                .HasColumnName("SORULISTESITERCIH");
            entity.Property(e => e.Talepeden).HasColumnName("TALEPEDEN");
            entity.Property(e => e.Talepedendepartman).HasColumnName("TALEPEDENDEPARTMAN");
            entity.Property(e => e.Talepedensirket).HasColumnName("TALEPEDENSIRKET");
            entity.Property(e => e.Taleptarihi).HasColumnName("TALEPTARIHI");
            entity.Property(e => e.Tedarikciadres)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIADRES");
            entity.Property(e => e.Tedarikcidokid)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIDOKID");
            entity.Property(e => e.Tedarikcifax)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIFAX");
            entity.Property(e => e.Tedarikciimzalidokid)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIIMZALIDOKID");
            entity.Property(e => e.Tedarikcikodu)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIKODU");
            entity.Property(e => e.Tedarikcikontakkisi)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIKONTAKKISI");
            entity.Property(e => e.Tedarikcimail)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIMAIL");
            entity.Property(e => e.Tedarikcimailkontrol)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIMAILKONTROL");
            entity.Property(e => e.Tedarikcitel)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCITEL");
            entity.Property(e => e.Tedarikciulke)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIULKE");
            entity.Property(e => e.Tedarikciunvan)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIUNVAN");
            entity.Property(e => e.Tedarikcivergidairesi)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIVERGIDAIRESI");
            entity.Property(e => e.Tedarikcivergikimlikno)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIVERGIKIMLIKNO");
            entity.Property(e => e.Tedarikciwebadres)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIWEBADRES");
            entity.Property(e => e.Teminatbaslangictarihi).HasColumnName("TEMINATBASLANGICTARIHI");
            entity.Property(e => e.Teminatbitistarihi).HasColumnName("TEMINATBITISTARIHI");
            entity.Property(e => e.Teminatcinsi)
                .HasMaxLength(255)
                .HasColumnName("TEMINATCINSI");
            entity.Property(e => e.Teminatmektubu)
                .HasMaxLength(255)
                .HasColumnName("TEMINATMEKTUBU");
            entity.Property(e => e.Teminattutari)
                .HasMaxLength(255)
                .HasColumnName("TEMINATTUTARI");
            entity.Property(e => e.Teminattutarkontrolu)
                .HasColumnType("INTEGER")
                .HasColumnName("TEMINATTUTARKONTROLU");
            entity.Property(e => e.Vergisorumlusu).HasColumnName("VERGISORUMLUSU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Wfmainid)
                .HasMaxLength(255)
                .HasColumnName("WFMAINID");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
            entity.Property(e => e.Yurticiyurtdisi)
                .HasMaxLength(255)
                .HasColumnName("YURTICIYURTDISI");
        });

        modelBuilder.Entity<CcmLog>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_LOG");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Damgavergisiaciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("DAMGAVERGISIACIKLAMA");
            entity.Property(e => e.Damgavergisitutari)
                .HasMaxLength(255)
                .HasColumnName("DAMGAVERGISITUTARI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dokid)
                .HasMaxLength(255)
                .HasColumnName("DOKID");
            entity.Property(e => e.Ek)
                .HasMaxLength(255)
                .HasColumnName("EK");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3)
                .HasMaxLength(255)
                .HasColumnName("EKALAN3");
            entity.Property(e => e.Ekprotokolnedeni)
                .HasColumnType("NCLOB")
                .HasColumnName("EKPROTOKOLNEDENI");
            entity.Property(e => e.Erpkodu)
                .HasMaxLength(255)
                .HasColumnName("ERPKODU");
            entity.Property(e => e.Gm).HasColumnName("GM");
            entity.Property(e => e.Gmonay)
                .HasColumnType("INTEGER")
                .HasColumnName("GMONAY");
            entity.Property(e => e.Gmy).HasColumnName("GMY");
            entity.Property(e => e.Hiyerarsikod)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSIKOD");
            entity.Property(e => e.Hiyerarsitanim)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSITANIM");
            entity.Property(e => e.Hukuksorumlusu).HasColumnName("HUKUKSORUMLUSU");
            entity.Property(e => e.Ilgiliavukat).HasColumnName("ILGILIAVUKAT");
            entity.Property(e => e.Ilgiliavukatatanmatarihi).HasColumnName("ILGILIAVUKATATANMATARIHI");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Imzalidokid)
                .HasMaxLength(255)
                .HasColumnName("IMZALIDOKID");
            entity.Property(e => e.Imzasirkusu)
                .HasMaxLength(255)
                .HasColumnName("IMZASIRKUSU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Kategori)
                .HasMaxLength(255)
                .HasColumnName("KATEGORI");
            entity.Property(e => e.Kid)
                .HasMaxLength(255)
                .HasColumnName("KID");
            entity.Property(e => e.Kontratadi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATADI");
            entity.Property(e => e.Kontratbaslangictarihi).HasColumnName("KONTRATBASLANGICTARIHI");
            entity.Property(e => e.Kontratbitistarihi).HasColumnName("KONTRATBITISTARIHI");
            entity.Property(e => e.Kontratgecerliliksuresi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATGECERLILIKSURESI");
            entity.Property(e => e.Kontratimzatarihi).HasColumnName("KONTRATIMZATARIHI");
            entity.Property(e => e.Kontratnumarasi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATNUMARASI");
            entity.Property(e => e.Kontratparabirimi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATPARABIRIMI");
            entity.Property(e => e.Kontratreferansnumarasi)
                .HasMaxLength(255)
                .HasColumnName("KONTRATREFERANSNUMARASI");
            entity.Property(e => e.Kontratsablon)
                .HasMaxLength(255)
                .HasColumnName("KONTRATSABLON");
            entity.Property(e => e.Kontratsorumlusu).HasColumnName("KONTRATSORUMLUSU");
            entity.Property(e => e.Kontratsurectip)
                .HasMaxLength(255)
                .HasColumnName("KONTRATSURECTIP");
            entity.Property(e => e.Kontratturu)
                .HasMaxLength(255)
                .HasColumnName("KONTRATTURU");
            entity.Property(e => e.Kontrattutari)
                .HasMaxLength(255)
                .HasColumnName("KONTRATTUTARI");
            entity.Property(e => e.Kontrattutarkontrolu)
                .HasColumnType("INTEGER")
                .HasColumnName("KONTRATTUTARKONTROLU");
            entity.Property(e => e.Odemesekli)
                .HasMaxLength(255)
                .HasColumnName("ODEMESEKLI");
            entity.Property(e => e.Oncelik)
                .HasMaxLength(255)
                .HasColumnName("ONCELIK");
            entity.Property(e => e.Oncelikneden)
                .HasColumnType("NCLOB")
                .HasColumnName("ONCELIKNEDEN");
            entity.Property(e => e.Otomatikyenileme)
                .HasColumnType("INTEGER")
                .HasColumnName("OTOMATIKYENILEME");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Ret).HasColumnName("RET");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Satinalmamuduru).HasColumnName("SATINALMAMUDURU");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Slcstatu)
                .HasMaxLength(255)
                .HasColumnName("SLCSTATU");
            entity.Property(e => e.Sorulistesi)
                .HasMaxLength(255)
                .HasColumnName("SORULISTESI");
            entity.Property(e => e.Sorulistesitercih)
                .HasColumnType("INTEGER")
                .HasColumnName("SORULISTESITERCIH");
            entity.Property(e => e.Talepeden).HasColumnName("TALEPEDEN");
            entity.Property(e => e.Talepedendepartman).HasColumnName("TALEPEDENDEPARTMAN");
            entity.Property(e => e.Talepedensirket).HasColumnName("TALEPEDENSIRKET");
            entity.Property(e => e.Taleptarihi).HasColumnName("TALEPTARIHI");
            entity.Property(e => e.Tedarikciadres)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIADRES");
            entity.Property(e => e.Tedarikcidokid)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIDOKID");
            entity.Property(e => e.Tedarikcifax)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIFAX");
            entity.Property(e => e.Tedarikciimzalidokid)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIIMZALIDOKID");
            entity.Property(e => e.Tedarikcikodu)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIKODU");
            entity.Property(e => e.Tedarikcikontakkisi)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIKONTAKKISI");
            entity.Property(e => e.Tedarikcimail)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIMAIL");
            entity.Property(e => e.Tedarikcimailkontrol)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIMAILKONTROL");
            entity.Property(e => e.Tedarikcitel)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCITEL");
            entity.Property(e => e.Tedarikciulke)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIULKE");
            entity.Property(e => e.Tedarikciunvan)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIUNVAN");
            entity.Property(e => e.Tedarikcivergidairesi)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIVERGIDAIRESI");
            entity.Property(e => e.Tedarikcivergikimlikno)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIVERGIKIMLIKNO");
            entity.Property(e => e.Tedarikciwebadres)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIWEBADRES");
            entity.Property(e => e.Teminatbaslangictarihi).HasColumnName("TEMINATBASLANGICTARIHI");
            entity.Property(e => e.Teminatbitistarihi).HasColumnName("TEMINATBITISTARIHI");
            entity.Property(e => e.Teminatmektubu)
                .HasMaxLength(255)
                .HasColumnName("TEMINATMEKTUBU");
            entity.Property(e => e.Teminattutari)
                .HasMaxLength(255)
                .HasColumnName("TEMINATTUTARI");
            entity.Property(e => e.Teminattutarkontrolu)
                .HasColumnType("INTEGER")
                .HasColumnName("TEMINATTUTARKONTROLU");
            entity.Property(e => e.Vergisorumlusu).HasColumnName("VERGISORUMLUSU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfatanmatarihi).HasColumnName("WFATANMATARIHI");
            entity.Property(e => e.Wfattachid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Wfmainid)
                .HasMaxLength(255)
                .HasColumnName("WFMAINID");
            entity.Property(e => e.Wfparentid)
                .HasMaxLength(255)
                .HasColumnName("WFPARENTID");
            entity.Property(e => e.Wftamamlanmatarihi).HasColumnName("WFTAMAMLANMATARIHI");
            entity.Property(e => e.Wftaskname)
                .HasMaxLength(255)
                .HasColumnName("WFTASKNAME");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
            entity.Property(e => e.Yurticiyurtdisi)
                .HasMaxLength(255)
                .HasColumnName("YURTICIYURTDISI");
        });

        modelBuilder.Entity<CcmNumara>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CCM_Numara");

            entity.Property(e => e.Numara).HasMaxLength(255);
            entity.Property(e => e.Sirket).HasMaxLength(255);
            entity.Property(e => e.Tip).HasMaxLength(255);
            entity.Property(e => e.Yil).HasMaxLength(255);
        });

        modelBuilder.Entity<CcmTeminatcinsibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMINATCINSIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Teminatcinsi)
                .HasMaxLength(255)
                .HasColumnName("TEMINATCINSI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempDepartmanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_DEPARTMANBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.DepartmanGrup).HasColumnName("DEPARTMAN_GRUP");
            entity.Property(e => e.DepartmanSorumlu).HasColumnName("DEPARTMAN_SORUMLU");
            entity.Property(e => e.DepartmanYonetici).HasColumnName("DEPARTMAN_YONETICI");
            entity.Property(e => e.Gm).HasColumnName("GM");
            entity.Property(e => e.Gmy).HasColumnName("GMY");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.MasrafYeri)
                .HasMaxLength(255)
                .HasColumnName("MASRAF_YERI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.SoruListesiHaric)
                .HasColumnType("INTEGER")
                .HasColumnName("SORU_LISTESI_HARIC");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempHaricikullanicibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_HARICIKULLANICIBAKIM");

            entity.Property(e => e.AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("AD_SOYAD");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kullanici).HasColumnName("KULLANICI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sicil)
                .HasMaxLength(255)
                .HasColumnName("SICIL");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempHiyerarsibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_HIYERARSIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Hiyerarsikod)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSIKOD");
            entity.Property(e => e.Hiyerarsitanim)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSITANIM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempHukuksorumlusubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_HUKUKSORUMLUSUBAKIM");

            entity.Property(e => e.AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("AD_SOYAD");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Cc1Yonetici)
                .HasMaxLength(255)
                .HasColumnName("CC1_YONETICI_");
            entity.Property(e => e.Cc2Yonetici)
                .HasMaxLength(255)
                .HasColumnName("CC2_YONETICI_");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Hukuksorumlusu)
                .HasColumnType("INTEGER")
                .HasColumnName("HUKUKSORUMLUSU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kullanici).HasColumnName("KULLANICI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("TITLE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.YurticiYurtdisi)
                .HasMaxLength(255)
                .HasColumnName("YURTICI_YURTDISI");
        });

        modelBuilder.Entity<CcmTempKararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_KARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempKategoribakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_KATEGORIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Hiyerarsikod)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSIKOD");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.KategoriId)
                .HasMaxLength(255)
                .HasColumnName("KATEGORI_ID");
            entity.Property(e => e.Kategoritanimi)
                .HasMaxLength(255)
                .HasColumnName("KATEGORITANIMI");
            entity.Property(e => e.Kontratturu)
                .HasMaxLength(255)
                .HasColumnName("KONTRATTURU");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.YurticiYurtdisi)
                .HasMaxLength(255)
                .HasColumnName("YURTICI_YURTDISI");
        });

        modelBuilder.Entity<CcmTempKontratdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_KONTRATDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.KontratDurum)
                .HasMaxLength(255)
                .HasColumnName("KONTRAT_DURUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempKontratgecerliliksuresibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_KONTRATGECERLILIKSURESIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Ay)
                .HasMaxLength(255)
                .HasColumnName("AY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempKontratsorumlusubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_KONTRATSORUMLUSUBAKIM");

            entity.Property(e => e.AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("AD_SOYAD");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kullanici).HasColumnName("KULLANICI");
            entity.Property(e => e.MasrafYeri)
                .HasMaxLength(255)
                .HasColumnName("MASRAF_YERI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sicil)
                .HasMaxLength(255)
                .HasColumnName("SICIL");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("TITLE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempKontratsurectipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_KONTRATSURECTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kontratsurectip)
                .HasMaxLength(255)
                .HasColumnName("KONTRATSURECTIP");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempKontratturubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_KONTRATTURUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kontratturu)
                .HasMaxLength(255)
                .HasColumnName("KONTRATTURU");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempOdemeseklibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_ODEMESEKLIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Odemesekli)
                .HasMaxLength(255)
                .HasColumnName("ODEMESEKLI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempOncelikbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_ONCELIKBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Oncelik)
                .HasMaxLength(255)
                .HasColumnName("ONCELIK");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempOtomatikyenilemesuresibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_OTOMATIKYENILEMESURESIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Ay)
                .HasMaxLength(255)
                .HasColumnName("AY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempParabirimibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_PARABIRIMIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(255)
                .HasColumnName("PARA_BIRIMI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempSablonbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_SABLONBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Sablonad)
                .HasMaxLength(255)
                .HasColumnName("SABLONAD");
            entity.Property(e => e.Sablonid)
                .HasMaxLength(255)
                .HasColumnName("SABLONID");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.SoruKategoriId)
                .HasMaxLength(255)
                .HasColumnName("SORU_KATEGORI_ID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempSirketbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_SIRKETBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketgrup).HasColumnName("SIRKETGRUP");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Sirkettanim)
                .HasMaxLength(255)
                .HasColumnName("SIRKETTANIM");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempSorulistesibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_SORULISTESIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Hiyerarsikod)
                .HasMaxLength(255)
                .HasColumnName("HIYERARSIKOD");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.SoruKategoriId)
                .HasMaxLength(255)
                .HasColumnName("SORU_KATEGORI_ID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempSurecformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_SURECFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Form)
                .HasMaxLength(255)
                .HasColumnName("FORM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<CcmTempWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("CCM_TEMP_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<CcmV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CCM_V");

            entity.Property(e => e.DamgaVergisiTutari).HasMaxLength(255);
            entity.Property(e => e.Gecerli).HasMaxLength(255);
            entity.Property(e => e.HiyerarsiKod).HasMaxLength(255);
            entity.Property(e => e.HiyerarsiTanim).HasMaxLength(255);
            entity.Property(e => e.KategoriId)
                .HasMaxLength(255)
                .HasColumnName("KategoriID");
            entity.Property(e => e.KontratCompoundAd).HasMaxLength(248);
            entity.Property(e => e.KontratCompoundId).HasColumnName("KontratCompoundID");
            entity.Property(e => e.KontratGecerlilikSure).HasMaxLength(255);
            entity.Property(e => e.KontratNumarasi).HasMaxLength(255);
            entity.Property(e => e.KontratRefNumarasi).HasMaxLength(255);
            entity.Property(e => e.KontratTuru).HasMaxLength(255);
            entity.Property(e => e.KontratTutari).HasMaxLength(255);
            entity.Property(e => e.OtomatikYenilemeSuresi).HasMaxLength(255);
            entity.Property(e => e.TalepEdenSirket).HasMaxLength(255);
            entity.Property(e => e.TedarikciKodu).HasMaxLength(255);
            entity.Property(e => e.TedarikciUnvan).HasMaxLength(255);
            entity.Property(e => e.YurtIcDis).HasMaxLength(255);
        });

        modelBuilder.Entity<CcmsendMailAttachTable>(entity =>
        {
            entity.ToTable("CCMSendMailAttachTable");

            entity.Property(e => e.Id)
                .HasColumnType("INTEGER")
                .HasColumnName("ID");
            entity.Property(e => e.DocumentIdArray).HasMaxLength(100);
            entity.Property(e => e.ProcessId).HasColumnType("INTEGER");
            entity.Property(e => e.SubProcessId).HasColumnType("INTEGER");
        });

        modelBuilder.Entity<CcmsendMailTable>(entity =>
        {
            entity.ToTable("CCMSendMailTable");

            entity.Property(e => e.Id)
                .HasColumnType("INTEGER")
                .HasColumnName("ID");
            entity.Property(e => e.Attachments).HasColumnType("BLOB");
            entity.Property(e => e.EmailBody).IsUnicode(false);
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.FromEmailAddress)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.IsHtml).HasColumnName("IsHTML");
            entity.Property(e => e.ProcessId).HasColumnType("INTEGER");
            entity.Property(e => e.SubProcessId).HasColumnType("INTEGER");
            entity.Property(e => e.ToEmailAddress)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CmbaseDuration>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Versiondate });
            entity.ToTable("CMBASE_DURATION");

            entity.Property(e => e.Currentver)
                .HasColumnType("INTEGER")
                .HasColumnName("CURRENTVER");
            entity.Property(e => e.Data)
                .HasColumnType("NCLOB")
                .HasColumnName("DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Earlyterm).HasColumnName("EARLYTERM");
            entity.Property(e => e.Effective).HasColumnName("EFFECTIVE");
            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Terminated)
                .HasColumnType("INTEGER")
                .HasColumnName("TERMINATED");
            entity.Property(e => e.Versiondate).HasColumnName("VERSIONDATE");
        });

        modelBuilder.Entity<CmbaseUpgradelog>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Action });

            entity.ToTable("CMBASE_UPGRADELOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(64)
                .HasColumnName("ACTION");
            entity.Property(e => e.Logmsg)
                .HasMaxLength(4000)
                .HasColumnName("LOGMSG");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Collection>(entity =>
        {
            entity.HasKey(e => new { e.Collectionid, e.Dataid, e.Version });
            entity.ToTable("COLLECTIONS");

            entity.Property(e => e.Collectionid).HasColumnName("COLLECTIONID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<Collectionsdatum>(entity =>
        {
            entity.HasKey(e => e.Collectionid);
            entity.ToTable("COLLECTIONSDATA");

            entity.Property(e => e.Collectionid).HasColumnName("COLLECTIONID");
            entity.Property(e => e.Searchable).HasColumnName("SEARCHABLE");
        });

        modelBuilder.Entity<Commcalendar>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Commid, e.Startdate });
            entity.ToTable("COMMCALENDAR");

            entity.Property(e => e.Commid).HasColumnName("COMMID");
            entity.Property(e => e.Details)
                .HasMaxLength(4000)
                .HasColumnName("DETAILS");
            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<Commcalendarrole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("COMMCALENDARROLES");

            entity.Property(e => e.Commcalendarid).HasColumnName("COMMCALENDARID");
            entity.Property(e => e.Roleid).HasColumnName("ROLEID");
        });

        modelBuilder.Entity<Commini>(entity =>
        {
            entity.HasKey(e => new { e.Inisection, e.Inikeyword });
            entity.ToTable("COMMINI");

            entity.Property(e => e.Inikeyword)
                .HasMaxLength(255)
                .HasColumnName("INIKEYWORD");
            entity.Property(e => e.Inisection)
                .HasMaxLength(255)
                .HasColumnName("INISECTION");
            entity.Property(e => e.Inivalue)
                .HasColumnType("NCLOB")
                .HasColumnName("INIVALUE");
        });

        modelBuilder.Entity<Commmember>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Userid });
            entity.ToTable("COMMMEMBER");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Lastondate).HasColumnName("LASTONDATE");
            entity.Property(e => e.Memberdate).HasColumnName("MEMBERDATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Userroleid).HasColumnName("USERROLEID");
            entity.Property(e => e.Userstatus)
                .HasMaxLength(255)
                .HasColumnName("USERSTATUS");
        });

        modelBuilder.Entity<Commmemberreq>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Userid, e.Roleid, e.Reqtype });
            entity.ToTable("COMMMEMBERREQ");

            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Msg)
                .HasMaxLength(4000)
                .HasColumnName("MSG");
            entity.Property(e => e.Reqtype).HasColumnName("REQTYPE");
            entity.Property(e => e.Roleid).HasColumnName("ROLEID");
            entity.Property(e => e.Sponsor)
                .HasMaxLength(255)
                .HasColumnName("SPONSOR");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Commmetric>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Userid, e.Actiondate, e.Actiontype });
            entity.ToTable("COMMMETRICS");

            entity.Property(e => e.Actiondate).HasColumnName("ACTIONDATE");
            entity.Property(e => e.Actiontype).HasColumnName("ACTIONTYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Extendeddata)
                .HasMaxLength(4000)
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Roleid).HasColumnName("ROLEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Componentsetting>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Componentname, e.Settingname });
            entity.ToTable("COMPONENTSETTINGS");

            entity.Property(e => e.Componentname)
                .HasMaxLength(255)
                .HasColumnName("COMPONENTNAME");
            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.Setting)
                .HasMaxLength(255)
                .HasColumnName("SETTING");
            entity.Property(e => e.Settingname)
                .HasMaxLength(255)
                .HasColumnName("SETTINGNAME");
        });

        modelBuilder.Entity<ControlledviewingPrinting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONTROLLEDVIEWING_PRINTING");

            entity.Property(e => e.Errmsg)
                .HasMaxLength(255)
                .HasColumnName("ERRMSG");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.PrintedNodeid).HasColumnName("PRINTED_NODEID");
            entity.Property(e => e.PrintedVersionid).HasColumnName("PRINTED_VERSIONID");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasColumnName("REASON");
            entity.Property(e => e.Requestdate).HasColumnName("REQUESTDATE");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
        });

        modelBuilder.Entity<Convertqueue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONVERTQUEUE");

            entity.Property(e => e.Attempt)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTEMPT");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dirused)
                .HasMaxLength(255)
                .HasColumnName("DIRUSED");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Queuedate).HasColumnName("QUEUEDATE");
            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<CpdbCompanygroup>(entity =>
        {
            entity.HasKey(e => e.Cgid);
            entity.ToTable("CPDB_COMPANYGROUP");

            entity.Property(e => e.Cgid).HasColumnName("CGID");
            entity.Property(e => e.Cpsection)
                .HasColumnType("INTEGER")
                .HasColumnName("CPSECTION");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<CpdbCountry>(entity =>
        {
            entity.HasKey(e => e.Iso2);
            entity.ToTable("CPDB_COUNTRY");

            entity.Property(e => e.Coid).HasColumnName("COID");
            entity.Property(e => e.Continent)
                .HasMaxLength(32)
                .HasColumnName("CONTINENT");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Iso2)
                .HasMaxLength(32)
                .HasColumnName("ISO2");
        });

        modelBuilder.Entity<CpdbLepa>(entity =>
        {
            entity.HasKey(e => new { e.Cpid, e.Version });
            entity.ToTable("CPDB_LEPA");

            entity.Property(e => e.Address1)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.Cgid).HasColumnName("CGID");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("CITY");
            entity.Property(e => e.Coid).HasColumnName("COID");
            entity.Property(e => e.Comments)
                .HasMaxLength(4000)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Cpextid)
                .HasMaxLength(64)
                .HasColumnName("CPEXTID");
            entity.Property(e => e.Cpid).HasColumnName("CPID");
            entity.Property(e => e.Cpsection)
                .HasColumnType("INTEGER")
                .HasColumnName("CPSECTION");
            entity.Property(e => e.Cptype)
                .HasColumnType("INTEGER")
                .HasColumnName("CPTYPE");
            entity.Property(e => e.Creationdate).HasColumnName("CREATIONDATE");
            entity.Property(e => e.Creator).HasColumnName("CREATOR");
            entity.Property(e => e.Currentver)
                .HasColumnType("INTEGER")
                .HasColumnName("CURRENTVER");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(32)
                .HasColumnName("FAX");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Logoid).HasColumnName("LOGOID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Npfirm).HasColumnName("NPFIRM");
            entity.Property(e => e.Phone)
                .HasMaxLength(32)
                .HasColumnName("PHONE");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.Syncdate).HasColumnName("SYNCDATE");
            entity.Property(e => e.Version)
                .HasColumnType("INTEGER")
                .HasColumnName("VERSION");
            entity.Property(e => e.Zippostalcode)
                .HasMaxLength(32)
                .HasColumnName("ZIPPOSTALCODE");
        });

        modelBuilder.Entity<CpdbSeqnr>(entity =>
        {
            entity.HasKey(e => e.Seqname);
            entity.ToTable("CPDB_SEQNR");

            entity.Property(e => e.Lastused).HasColumnName("LASTUSED");
            entity.Property(e => e.Seqname)
                .HasMaxLength(64)
                .HasColumnName("SEQNAME");
        });

        modelBuilder.Entity<CpdbStateprovince>(entity =>
        {
            entity.HasKey(e => e.Spid);
            entity.ToTable("CPDB_STATEPROVINCE");

            entity.Property(e => e.Coid).HasColumnName("COID");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Fipscode)
                .HasMaxLength(32)
                .HasColumnName("FIPSCODE");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.Stateprovince)
                .HasMaxLength(255)
                .HasColumnName("STATEPROVINCE");
        });

        modelBuilder.Entity<Csappsstat>(entity =>
        {
            entity.HasKey(e => e.Appname);
            entity.ToTable("CSAPPSSTATS");

            entity.Property(e => e.Action)
                .HasMaxLength(64)
                .HasColumnName("ACTION");
            entity.Property(e => e.Appname)
                .HasMaxLength(64)
                .HasColumnName("APPNAME");
            entity.Property(e => e.Datefirstaction).HasColumnName("DATEFIRSTACTION");
            entity.Property(e => e.Datelastaction).HasColumnName("DATELASTACTION");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Stats)
                .HasColumnType("NCLOB")
                .HasColumnName("STATS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Userstatus).HasColumnName("USERSTATUS");
        });

        modelBuilder.Entity<Custodiansite>(entity =>
        {
            entity.HasKey(e => e.Custodiansite1);
            entity.ToTable("CUSTODIANSITE");

            entity.Property(e => e.Custodiansite1)
                .HasMaxLength(32)
                .HasColumnName("CUSTODIANSITE");
            entity.Property(e => e.DescE)
                .HasMaxLength(128)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
        });

        modelBuilder.Entity<CwscoreshareInstancecatattr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CWSCORESHARE_INSTANCECATATTRS");

            entity.Property(e => e.Attrid).HasColumnName("ATTRID");
            entity.Property(e => e.Attrusagetype).HasColumnName("ATTRUSAGETYPE");
            entity.Property(e => e.Attrvalue)
                .HasMaxLength(4000)
                .HasColumnName("ATTRVALUE");
            entity.Property(e => e.Catattrid).HasColumnName("CATATTRID");
            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Instanceid).HasColumnName("INSTANCEID");
        });

        modelBuilder.Entity<CwscoreshareInstancemapping>(entity =>
        {
            entity.HasKey(e => e.Instanceid);
            entity.ToTable("CWSCORESHARE_INSTANCEMAPPINGS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Instanceid).HasColumnName("INSTANCEID");
            entity.Property(e => e.Mapid).HasColumnName("MAPID");
            entity.Property(e => e.Mapversion).HasColumnName("MAPVERSION");
            entity.Property(e => e.Processmessage)
                .HasMaxLength(4000)
                .HasColumnName("PROCESSMESSAGE");
            entity.Property(e => e.Processstatus).HasColumnName("PROCESSSTATUS");
            entity.Property(e => e.Shareditems)
                .HasMaxLength(4000)
                .HasColumnName("SHAREDITEMS");
        });

        modelBuilder.Entity<CwscoreshareTemplatecatattr>(entity =>
        {
            entity.HasKey(e => e.Catattrid);
            entity.ToTable("CWSCORESHARE_TEMPLATECATATTRS");

            entity.Property(e => e.Attrid).HasColumnName("ATTRID");
            entity.Property(e => e.Attrusagetype).HasColumnName("ATTRUSAGETYPE");
            entity.Property(e => e.Attrvalue)
                .HasMaxLength(4000)
                .HasColumnName("ATTRVALUE");
            entity.Property(e => e.Catattrid).HasColumnName("CATATTRID");
            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Mapid).HasColumnName("MAPID");
            entity.Property(e => e.Mapversion).HasColumnName("MAPVERSION");
        });

        modelBuilder.Entity<CwscoreshareTemplatemapping>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Version });
            entity.ToTable("CWSCORESHARE_TEMPLATEMAPPINGS");

            entity.Property(e => e.Coordinators)
                .HasMaxLength(4000)
                .HasColumnName("COORDINATORS");
            entity.Property(e => e.Coordinatortype).HasColumnName("COORDINATORTYPE");
            entity.Property(e => e.Createdby)
                .HasDefaultValueSql("1000")
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InitTrigger).HasColumnName("INIT_TRIGGER");
            entity.Property(e => e.Initiationattrexp)
                .HasMaxLength(4000)
                .HasColumnName("INITIATIONATTREXP");
            entity.Property(e => e.Initiationattrexpdata)
                .HasMaxLength(4000)
                .HasColumnName("INITIATIONATTREXPDATA");
            entity.Property(e => e.Modifiedby)
                .HasDefaultValueSql("1000")
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifieddate).HasColumnName("MODIFIEDDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Recipients)
                .HasMaxLength(4000)
                .HasColumnName("RECIPIENTS");
            entity.Property(e => e.Shareditems)
                .HasMaxLength(4000)
                .HasColumnName("SHAREDITEMS");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TermTrigger).HasColumnName("TERM_TRIGGER");
            entity.Property(e => e.Terminationattrexp)
                .HasMaxLength(4000)
                .HasColumnName("TERMINATIONATTREXP");
            entity.Property(e => e.Terminationattrexpdata)
                .HasMaxLength(4000)
                .HasColumnName("TERMINATIONATTREXPDATA");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<Cwsteamshareinstancemapping>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Shareditemid });
            entity.ToTable("CWSTEAMSHAREINSTANCEMAPPINGS");

            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifieddate).HasColumnName("MODIFIEDDATE");
            entity.Property(e => e.Shareditemid).HasColumnName("SHAREDITEMID");
            entity.Property(e => e.Sharetype).HasColumnName("SHARETYPE");
        });

        modelBuilder.Entity<Cwsteamsharetemplatemapping>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Shareditemid });
            entity.ToTable("CWSTEAMSHARETEMPLATEMAPPINGS");

            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifieddate).HasColumnName("MODIFIEDDATE");
            entity.Property(e => e.Shareditemid).HasColumnName("SHAREDITEMID");
            entity.Property(e => e.Sharetype).HasColumnName("SHARETYPE");
        });

        modelBuilder.Entity<CzmNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CZM_Number");

            entity.Property(e => e.Deger1).HasMaxLength(255);
            entity.Property(e => e.Deger2).HasMaxLength(255);
            entity.Property(e => e.Number).HasColumnType("INTEGER");
            entity.Property(e => e.Year).HasMaxLength(255);
        });

        modelBuilder.Entity<Dancestorschildcount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DANCESTORSCHILDCOUNT");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Dancestorsmovenode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DANCESTORSMOVENODE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Serverid)
                .HasMaxLength(255)
                .HasColumnName("SERVERID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<Dattribute>(entity =>
        {
            entity.HasKey(e => e.Attrname);
            entity.ToTable("DATTRIBUTES");

            entity.Property(e => e.Attrlen)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRLEN");
            entity.Property(e => e.Attrname)
                .HasMaxLength(128)
                .HasColumnName("ATTRNAME");
            entity.Property(e => e.Attrtype)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRTYPE");
            entity.Property(e => e.Defvalue)
                .HasMaxLength(255)
                .HasColumnName("DEFVALUE");
            entity.Property(e => e.Dispname)
                .HasMaxLength(255)
                .HasColumnName("DISPNAME");
            entity.Property(e => e.Disptype)
                .HasMaxLength(32)
                .HasColumnName("DISPTYPE");
            entity.Property(e => e.Validvals)
                .HasMaxLength(255)
                .HasColumnName("VALIDVALS");
        });

        modelBuilder.Entity<Dauditmore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DAUDITMORE");

            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Keystr)
                .HasMaxLength(255)
                .HasColumnName("KEYSTR");
            entity.Property(e => e.Valuestr)
                .HasMaxLength(4000)
                .HasColumnName("VALUESTR");
        });

        modelBuilder.Entity<Dauditmorearchive>(entity =>
        {
            entity.HasKey(e => e.Eventid);
            entity.ToTable("DAUDITMOREARCHIVE");

            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Keystr)
                .HasMaxLength(255)
                .HasColumnName("KEYSTR");
            entity.Property(e => e.Valuestr)
                .HasMaxLength(4000)
                .HasColumnName("VALUESTR");
        });

        modelBuilder.Entity<Dauditmorecore>(entity =>
        {
            entity.HasKey(e => e.Eventid);
            entity.ToTable("DAUDITMORECORE");

            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Keystr)
                .HasMaxLength(255)
                .HasColumnName("KEYSTR");
            entity.Property(e => e.Valuestr)
                .HasMaxLength(4000)
                .HasColumnName("VALUESTR");
        });

        modelBuilder.Entity<Dauditnew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DAUDITNEW");

            entity.Property(e => e.Agentid).HasColumnName("AGENTID");
            entity.Property(e => e.Applicationid)
                .HasMaxLength(255)
                .HasColumnName("APPLICATIONID");
            entity.Property(e => e.Auditdate).HasColumnName("AUDITDATE");
            entity.Property(e => e.Auditid)
                .HasColumnType("INTEGER")
                .HasColumnName("AUDITID");
            entity.Property(e => e.Auditstr)
                .HasMaxLength(32)
                .HasColumnName("AUDITSTR");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
            entity.Property(e => e.Performerid).HasColumnName("PERFORMERID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Targetuserid).HasColumnName("TARGETUSERID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value1)
                .HasMaxLength(4000)
                .HasColumnName("VALUE1");
            entity.Property(e => e.Value2)
                .HasMaxLength(4000)
                .HasColumnName("VALUE2");
            entity.Property(e => e.Valuekey)
                .HasMaxLength(255)
                .HasColumnName("VALUEKEY");
        });

        modelBuilder.Entity<Dauditnewarchive>(entity =>
        {
            entity.HasKey(e => e.Performerid);
            entity.ToTable("DAUDITNEWARCHIVE");

            entity.Property(e => e.Agentid).HasColumnName("AGENTID");
            entity.Property(e => e.Applicationid)
                .HasMaxLength(255)
                .HasColumnName("APPLICATIONID");
            entity.Property(e => e.Auditdate).HasColumnName("AUDITDATE");
            entity.Property(e => e.Auditid)
                .HasColumnType("INTEGER")
                .HasColumnName("AUDITID");
            entity.Property(e => e.Auditstr)
                .HasMaxLength(32)
                .HasColumnName("AUDITSTR");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
            entity.Property(e => e.Performerid).HasColumnName("PERFORMERID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value1)
                .HasMaxLength(4000)
                .HasColumnName("VALUE1");
            entity.Property(e => e.Value2)
                .HasMaxLength(4000)
                .HasColumnName("VALUE2");
            entity.Property(e => e.Valuekey)
                .HasMaxLength(255)
                .HasColumnName("VALUEKEY");
        });

        modelBuilder.Entity<Dauditnewcore>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DAUDITNEWCORE");

            entity.Property(e => e.Agentid).HasColumnName("AGENTID");
            entity.Property(e => e.Applicationid)
                .HasMaxLength(255)
                .HasColumnName("APPLICATIONID");
            entity.Property(e => e.Auditdate).HasColumnName("AUDITDATE");
            entity.Property(e => e.Auditid)
                .HasColumnType("INTEGER")
                .HasColumnName("AUDITID");
            entity.Property(e => e.Auditstr)
                .HasMaxLength(32)
                .HasColumnName("AUDITSTR");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
            entity.Property(e => e.Performerid).HasColumnName("PERFORMERID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Targetuserid).HasColumnName("TARGETUSERID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value1)
                .HasMaxLength(4000)
                .HasColumnName("VALUE1");
            entity.Property(e => e.Value2)
                .HasMaxLength(4000)
                .HasColumnName("VALUE2");
            entity.Property(e => e.Valuekey)
                .HasMaxLength(255)
                .HasColumnName("VALUEKEY");
        });

        modelBuilder.Entity<Dbrowseancestor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DBROWSEANCESTORS");

            entity.Property(e => e.Ancestorid).HasColumnName("ANCESTORID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Dbrowseancestorscore>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Ancestorid });
            entity.ToTable("DBROWSEANCESTORSCORE");

            entity.Property(e => e.Ancestorid).HasColumnName("ANCESTORID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
        });

        modelBuilder.Entity<Dcatattr>(entity =>
        {
            entity.HasKey(e => new { e.Catname, e.Attrname });
            entity.ToTable("DCATATTRS");

            entity.Property(e => e.Attrname)
                .HasMaxLength(128)
                .HasColumnName("ATTRNAME");
            entity.Property(e => e.Catname)
                .HasMaxLength(128)
                .HasColumnName("CATNAME");
            entity.Property(e => e.Required).HasColumnName("REQUIRED");
        });

        modelBuilder.Entity<Dcategory>(entity =>
        {
            entity.HasKey(e => e.Catname);
            entity.ToTable("DCATEGORIES");

            entity.Property(e => e.Catname)
                .HasMaxLength(128)
                .HasColumnName("CATNAME");
            entity.Property(e => e.Dispname)
                .HasMaxLength(255)
                .HasColumnName("DISPNAME");
            entity.Property(e => e.Tablename)
                .HasMaxLength(255)
                .HasColumnName("TABLENAME");
        });

        modelBuilder.Entity<Dcolumnlocation>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Columnid });
            entity.ToTable("DCOLUMNLOCATION");

            entity.Property(e => e.Columnid).HasColumnName("COLUMNID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Displaycascade).HasColumnName("DISPLAYCASCADE");
            entity.Property(e => e.Displayorder).HasColumnName("DISPLAYORDER");
        });

        modelBuilder.Entity<Dcolumnsortlocation>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DCOLUMNSORTLOCATION");

            entity.Property(e => e.Columnid).HasColumnName("COLUMNID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Sortkey)
                .HasMaxLength(64)
                .HasColumnName("SORTKEY");
        });

        modelBuilder.Entity<DdeleteditemsnamesTrTr>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DDELETEDITEMSNAMES_TR_TR");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Ddeleteditemsnode>(entity =>
        {
            entity.HasKey(e => new { e.Purgedate, e.Dataid });
            entity.ToTable("DDELETEDITEMSNODES");

            entity.Property(e => e.Context)
                .HasMaxLength(512)
                .HasColumnName("CONTEXT");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Deletedate).HasColumnName("DELETEDATE");
            entity.Property(e => e.Deleteduser).HasColumnName("DELETEDUSER");
            entity.Property(e => e.Deleteinfo)
                .HasMaxLength(4000)
                .HasColumnName("DELETEINFO");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Purgedate).HasColumnName("PURGEDATE");
        });

        modelBuilder.Entity<Ddellist>(entity =>
        {
            entity.HasKey(e => e.Ownerid);
            entity.ToTable("DDELLIST");

            entity.Property(e => e.Deletedlist)
                .HasColumnType("NCLOB")
                .HasColumnName("DELETEDLIST");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
        });

        modelBuilder.Entity<Ddocumentclass>(entity =>
        {
            entity.HasKey(e => e.Nid);
            entity.ToTable("DDOCUMENTCLASS");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Type)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<Ddocumentclasschild>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Childid });
            entity.ToTable("DDOCUMENTCLASSCHILDREN");

            entity.Property(e => e.Childid).HasColumnName("CHILDID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Dextendedprofileinfo>(entity =>
        {
            entity.HasKey(e => e.Userid);

            entity.ToTable("DEXTENDEDPROFILEINFO");

            entity.Property(e => e.Userid)
                .ValueGeneratedNever()
                .HasColumnName("USERID");
            entity.Property(e => e.Fieldinfo)
                .HasColumnType("NCLOB")
                .HasColumnName("FIELDINFO");
            entity.Property(e => e.Reporttoid).HasColumnName("REPORTTOID");
        });

        modelBuilder.Entity<DfacetAttr15792>(entity =>
        {
            entity.HasKey(e => new { e.Facet, e.Dataid });
            entity.ToTable("DFACET_ATTR_1579_2");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet)
                .HasMaxLength(64)
                .HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetAttr15793>(entity =>
        {
            entity.HasKey(e => new { e.Facet, e.Dataid });
            entity.ToTable("DFACET_ATTR_1579_3");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet)
                .HasMaxLength(64)
                .HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetDc1>(entity =>
        {
            entity.HasKey(e => new { e.Facet, e.Dataid });
            entity.ToTable("DFACET_DC_1");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetDc2>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_DC_2");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetDc3>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_DC_3");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetDc336>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_DC_336");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetDc4>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_DC_4");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetDc5>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_DC_5");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetFilingstatus>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_FILINGSTATUS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetModifydate>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_MODIFYDATE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet)
                .HasColumnType("INTEGER")
                .HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetObjecttype>(entity =>
        {
            entity.HasKey(e => new { e.Facet, e.Dataid });
            entity.ToTable("DFACET_OBJECTTYPE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet)
                .HasColumnType("INTEGER")
                .HasColumnName("FACET");
        });

        modelBuilder.Entity<DfacetOwner>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Facet });
            entity.ToTable("DFACET_OWNER");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Facet).HasColumnName("FACET");
        });

        modelBuilder.Entity<Dfacetcache>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DFACETCACHE");

            entity.Property(e => e.Data)
                .HasColumnType("NCLOB")
                .HasColumnName("DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dateadded).HasColumnName("DATEADDED");
            entity.Property(e => e.Descendantcount).HasColumnName("DESCENDANTCOUNT");
        });

        modelBuilder.Entity<Dfacetcachecore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DFACETCACHECORE");

            entity.Property(e => e.Data)
                .HasColumnType("NCLOB")
                .HasColumnName("DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dateadded).HasColumnName("DATEADDED");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Descendantcount).HasColumnName("DESCENDANTCOUNT");
        });

        modelBuilder.Entity<Dfacetkey>(entity =>
        {
            entity.HasKey(e => new { e.Hashstr, e.Id });
            entity.ToTable("DFACETKEYS");

            entity.Property(e => e.Hashstr)
                .HasMaxLength(64)
                .HasColumnName("HASHSTR");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Keystr)
                .HasMaxLength(255)
                .HasColumnName("KEYSTR");
        });

        modelBuilder.Entity<Dfacettracking>(entity =>
        {
            entity.HasKey(e => new { e.Rowidnum, e.Taskdatestamp });
            entity.ToTable("DFACETTRACKING");

            entity.Property(e => e.Algorithm)
                .HasMaxLength(255)
                .HasColumnName("ALGORITHM");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Keys)
                .HasMaxLength(4000)
                .HasColumnName("KEYS");
            entity.Property(e => e.Log)
                .HasColumnType("NCLOB")
                .HasColumnName("LOG");
            entity.Property(e => e.Rowidnum).HasColumnName("ROWIDNUM");
            entity.Property(e => e.Spawned)
                .HasMaxLength(4000)
                .HasColumnName("SPAWNED");
            entity.Property(e => e.Systemref)
                .HasMaxLength(255)
                .HasColumnName("SYSTEMREF");
            entity.Property(e => e.Taskdatestamp).HasColumnName("TASKDATESTAMP");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Timeinms).HasColumnName("TIMEINMS");
            entity.Property(e => e.Triggerstr)
                .HasMaxLength(255)
                .HasColumnName("TRIGGERSTR");
        });

        modelBuilder.Entity<Dfavorite>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Dataid });
            entity.ToTable("DFAVORITES");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Tabid).HasColumnName("TABID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dfavoritestab>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Ordering });
            entity.ToTable("DFAVORITESTABS");

            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Tabid).HasColumnName("TABID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Discussionid>(entity =>
        {
            entity.HasKey(e => e.Ownerid);
            entity.ToTable("DISCUSSIONID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
        });

        modelBuilder.Entity<Disposition>(entity =>
        {
            entity.HasKey(e => e.Disposition1);
            entity.ToTable("DISPOSITION");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Disposition1)
                .HasMaxLength(32)
                .HasColumnName("DISPOSITION");
            entity.Property(e => e.DispositionDescE)
                .HasMaxLength(128)
                .HasColumnName("DISPOSITION_DESC_E");
            entity.Property(e => e.DispositionDescF)
                .HasMaxLength(128)
                .HasColumnName("DISPOSITION_DESC_F");
        });

        modelBuilder.Entity<Dispositionhold>(entity =>
        {
            entity.HasKey(e => e.Holdid);
            entity.ToTable("DISPOSITIONHOLD");

            entity.Property(e => e.Activehold).HasColumnName("ACTIVEHOLD");
            entity.Property(e => e.Alternateholdid)
                .HasMaxLength(64)
                .HasColumnName("ALTERNATEHOLDID");
            entity.Property(e => e.Applypatron)
                .HasMaxLength(255)
                .HasColumnName("APPLYPATRON");
            entity.Property(e => e.Dateapplied).HasColumnName("DATEAPPLIED");
            entity.Property(e => e.Dateremoved).HasColumnName("DATEREMOVED");
            entity.Property(e => e.Datetoremove).HasColumnName("DATETOREMOVE");
            entity.Property(e => e.Editdate).HasColumnName("EDITDATE");
            entity.Property(e => e.Editpatron)
                .HasMaxLength(255)
                .HasColumnName("EDITPATRON");
            entity.Property(e => e.Holdcomment)
                .HasMaxLength(4000)
                .HasColumnName("HOLDCOMMENT");
            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Holdname)
                .HasMaxLength(255)
                .HasColumnName("HOLDNAME");
            entity.Property(e => e.Holdtype)
                .HasMaxLength(32)
                .HasColumnName("HOLDTYPE");
            entity.Property(e => e.Object)
                .HasMaxLength(32)
                .HasColumnName("OBJECT");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Removalcomment)
                .HasMaxLength(255)
                .HasColumnName("REMOVALCOMMENT");
            entity.Property(e => e.Removalpatron)
                .HasMaxLength(255)
                .HasColumnName("REMOVALPATRON");
        });

        modelBuilder.Entity<Dmetadatastate>(entity =>
        {
            entity.HasKey(e => e.Modifydate);
            entity.ToTable("DMETADATASTATE");

            entity.Property(e => e.Keystr)
                .HasMaxLength(255)
                .HasColumnName("KEYSTR");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Tokenstr)
                .HasMaxLength(64)
                .HasColumnName("TOKENSTR");
        });

        modelBuilder.Entity<Dmultipartcontent>(entity =>
        {
            entity.HasKey(e => new { e.Uploadkey, e.Blockid });
            entity.ToTable("DMULTIPARTCONTENT");

            entity.Property(e => e.Arrivaltime).HasColumnName("ARRIVALTIME");
            entity.Property(e => e.Blockid).HasColumnName("BLOCKID");
            entity.Property(e => e.Contentsize).HasColumnName("CONTENTSIZE");
            entity.Property(e => e.Outputfile)
                .HasMaxLength(255)
                .HasColumnName("OUTPUTFILE");
            entity.Property(e => e.Uploadkey)
                .HasMaxLength(255)
                .HasColumnName("UPLOADKEY");
        });

        modelBuilder.Entity<Dmultipartmetadatum>(entity =>
        {
            entity.HasKey(e => e.Uploadkey);
            entity.ToTable("DMULTIPARTMETADATA");

            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filesize).HasColumnName("FILESIZE");
            entity.Property(e => e.Firsttime).HasColumnName("FIRSTTIME");
            entity.Property(e => e.Lasttime).HasColumnName("LASTTIME");
            entity.Property(e => e.Maxcontentsize).HasColumnName("MAXCONTENTSIZE");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Numblocks).HasColumnName("NUMBLOCKS");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Tempdir)
                .HasMaxLength(255)
                .HasColumnName("TEMPDIR");
            entity.Property(e => e.Tempfile)
                .HasMaxLength(255)
                .HasColumnName("TEMPFILE");
            entity.Property(e => e.Uploadkey)
                .HasMaxLength(255)
                .HasColumnName("UPLOADKEY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dobjectrank>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DOBJECTRANK");

            entity.Property(e => e.A0).HasDefaultValueSql("0");
            entity.Property(e => e.A1).HasDefaultValueSql("0");
            entity.Property(e => e.A10).HasDefaultValueSql("0");
            entity.Property(e => e.A11).HasDefaultValueSql("0");
            entity.Property(e => e.A12).HasDefaultValueSql("0");
            entity.Property(e => e.A13).HasDefaultValueSql("0");
            entity.Property(e => e.A14).HasDefaultValueSql("0");
            entity.Property(e => e.A2).HasDefaultValueSql("0");
            entity.Property(e => e.A3).HasDefaultValueSql("0");
            entity.Property(e => e.A4).HasDefaultValueSql("0");
            entity.Property(e => e.A5).HasDefaultValueSql("0");
            entity.Property(e => e.A6).HasDefaultValueSql("0");
            entity.Property(e => e.A7).HasDefaultValueSql("0");
            entity.Property(e => e.A8).HasDefaultValueSql("0");
            entity.Property(e => e.A9).HasDefaultValueSql("0");
            entity.Property(e => e.Accesses)
                .HasDefaultValueSql("0.0")
                .HasColumnType("DECIMAL")
                .HasColumnName("ACCESSES");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Favorites)
                .HasDefaultValueSql("0")
                .HasColumnName("FAVORITES");
            entity.Property(e => e.Favoritesnorm)
                .HasDefaultValueSql("0.0")
                .HasColumnType("DECIMAL")
                .HasColumnName("FAVORITESNORM");
            entity.Property(e => e.Rangedscore1)
                .HasDefaultValueSql("0.0")
                .HasColumnType("DECIMAL")
                .HasColumnName("RANGEDSCORE1");
            entity.Property(e => e.Rangedscore2)
                .HasDefaultValueSql("0.0")
                .HasColumnType("DECIMAL")
                .HasColumnName("RANGEDSCORE2");
            entity.Property(e => e.Shortcuts)
                .HasDefaultValueSql("0")
                .HasColumnType("DECIMAL")
                .HasColumnName("SHORTCUTS");
        });

        modelBuilder.Entity<Docxreftyp>(entity =>
        {
            entity.HasKey(e => e.Docxreftyp1);
            entity.ToTable("DOCXREFTYP");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Docxreftyp1)
                .HasMaxLength(32)
                .HasColumnName("DOCXREFTYP");
            entity.Property(e => e.DocxreftypDescE)
                .HasMaxLength(128)
                .HasColumnName("DOCXREFTYP_DESC_E");
            entity.Property(e => e.DocxreftypDescF)
                .HasMaxLength(128)
                .HasColumnName("DOCXREFTYP_DESC_F");
            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Relatedcode)
                .HasMaxLength(32)
                .HasColumnName("RELATEDCODE");
        });

        modelBuilder.Entity<Dperspective>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DPERSPECTIVES");

            entity.Property(e => e.Appliestoid).HasColumnName("APPLIESTOID");
            entity.Property(e => e.Assetcontainerid).HasColumnName("ASSETCONTAINERID");
            entity.Property(e => e.Cascadevalue).HasColumnName("CASCADEVALUE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Perspectiveinfo)
                .HasColumnType("NCLOB")
                .HasColumnName("PERSPECTIVEINFO");
            entity.Property(e => e.Perspectivetype)
                .HasMaxLength(128)
                .HasColumnName("PERSPECTIVETYPE");
            entity.Property(e => e.Ruleid).HasColumnName("RULEID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dperspectivescore>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DPERSPECTIVESCORE");

            entity.Property(e => e.Appliestoid).HasColumnName("APPLIESTOID");
            entity.Property(e => e.Assetcontainerid).HasColumnName("ASSETCONTAINERID");
            entity.Property(e => e.Cascadevalue).HasColumnName("CASCADEVALUE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Perspectiveinfo)
                .HasColumnType("NCLOB")
                .HasColumnName("PERSPECTIVEINFO");
            entity.Property(e => e.Perspectivetype)
                .HasMaxLength(128)
                .HasColumnName("PERSPECTIVETYPE");
        });

        modelBuilder.Entity<Dpsinsertableproperty>(entity =>
        {
            entity.HasKey(e => e.Insertpropid);
            entity.ToTable("DPSINSERTABLEPROPERTIES");

            entity.Property(e => e.Conversion)
                .HasMaxLength(255)
                .HasColumnName("CONVERSION");
            entity.Property(e => e.Csattributetype).HasColumnName("CSATTRIBUTETYPE");
            entity.Property(e => e.Displayname)
                .HasMaxLength(4000)
                .HasColumnName("DISPLAYNAME");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Fileproperty)
                .HasMaxLength(4000)
                .HasColumnName("FILEPROPERTY");
            entity.Property(e => e.Insertpropid).HasColumnName("INSERTPROPID");
            entity.Property(e => e.Keyname)
                .HasMaxLength(255)
                .HasColumnName("KEYNAME");
            entity.Property(e => e.Synchronized).HasColumnName("SYNCHRONIZED");
        });

        modelBuilder.Entity<Dreadlist>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Ownerid });
            entity.ToTable("DREADLIST");

            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Readlist)
                .HasColumnType("NCLOB")
                .HasColumnName("READLIST");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dreserverequest>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Dataid });
            entity.ToTable("DRESERVEREQUESTS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Reservedate).HasColumnName("RESERVEDATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dreserverequestsnotification>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Dataid });
            entity.ToTable("DRESERVEREQUESTSNOTIFICATION");

            entity.Property(e => e.Attempt).HasColumnName("ATTEMPT");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Notifydate).HasColumnName("NOTIFYDATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dshareancestor>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Ancestorid });
            entity.ToTable("DSHAREANCESTORS");

            entity.Property(e => e.Ancestorid).HasColumnName("ANCESTORID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Dsharecoordinator>(entity =>
        {
            entity.HasKey(e => new { e.Shareid, e.Sharecoordinatorid });
            entity.ToTable("DSHARECOORDINATORS");

            entity.Property(e => e.Sharecoordinatorid).HasColumnName("SHARECOORDINATORID");
            entity.Property(e => e.Shareid).HasColumnName("SHAREID");
        });

        modelBuilder.Entity<Dsharecredential>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Providername });
            entity.ToTable("DSHARECREDENTIALS");

            entity.Property(e => e.Accesstoken)
                .HasMaxLength(4000)
                .HasColumnName("ACCESSTOKEN");
            entity.Property(e => e.Expirytime).HasColumnName("EXPIRYTIME");
            entity.Property(e => e.Providername)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERNAME");
            entity.Property(e => e.Provideruserid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERUSERID");
            entity.Property(e => e.Refreshtoken)
                .HasMaxLength(4000)
                .HasColumnName("REFRESHTOKEN");
            entity.Property(e => e.Tokentype)
                .HasMaxLength(255)
                .HasColumnName("TOKENTYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dshareitem>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Provideritemid });
            entity.ToTable("DSHAREITEMS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Expiredate).HasColumnName("EXPIREDATE");
            entity.Property(e => e.Provideritemid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERITEMID");
            entity.Property(e => e.Providertype).HasColumnName("PROVIDERTYPE");
            entity.Property(e => e.Providerversionid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERVERSIONID");
            entity.Property(e => e.Sharedby).HasColumnName("SHAREDBY");
            entity.Property(e => e.Sharedon).HasColumnName("SHAREDON");
            entity.Property(e => e.Sharedownertype).HasColumnName("SHAREDOWNERTYPE");
            entity.Property(e => e.Sharedversion).HasColumnName("SHAREDVERSION");
            entity.Property(e => e.Sharedversionid).HasColumnName("SHAREDVERSIONID");
        });

        modelBuilder.Entity<Dshareitemreference>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DSHAREITEMREFERENCE");

            entity.Property(e => e.Csitemid).HasColumnName("CSITEMID");
            entity.Property(e => e.Cssubitemid)
                .HasMaxLength(255)
                .HasColumnName("CSSUBITEMID");
            entity.Property(e => e.Csversionid).HasColumnName("CSVERSIONID");
            entity.Property(e => e.Itemtype).HasColumnName("ITEMTYPE");
            entity.Property(e => e.Provideritemid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERITEMID");
            entity.Property(e => e.Providersubitemid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERSUBITEMID");
            entity.Property(e => e.Providertype).HasColumnName("PROVIDERTYPE");
            entity.Property(e => e.Providerversionid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERVERSIONID");
        });

        modelBuilder.Entity<Dshareitemstateindicator>(entity =>
        {
            entity.HasKey(e => e.Affecteddataid);
            entity.ToTable("DSHAREITEMSTATEINDICATOR");

            entity.Property(e => e.Affecteddataid).HasColumnName("AFFECTEDDATAID");
            entity.Property(e => e.Csitemid).HasColumnName("CSITEMID");
            entity.Property(e => e.Synceventid).HasColumnName("SYNCEVENTID");
            entity.Property(e => e.Syncstate).HasColumnName("SYNCSTATE");
        });

        modelBuilder.Entity<Dsharesyncerror>(entity =>
        {
            entity.HasKey(e => new { e.Providertype, e.Provideritemid, e.Csitemid });
            entity.ToTable("DSHARESYNCERROR");

            entity.Property(e => e.Csitemid).HasColumnName("CSITEMID");
            entity.Property(e => e.Errordiagnostics)
                .HasMaxLength(4000)
                .HasColumnName("ERRORDIAGNOSTICS");
            entity.Property(e => e.Erroroperation).HasColumnName("ERROROPERATION");
            entity.Property(e => e.Errorstatus).HasColumnName("ERRORSTATUS");
            entity.Property(e => e.Errortime).HasColumnName("ERRORTIME");
            entity.Property(e => e.Provideritemid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERITEMID");
            entity.Property(e => e.Providertype).HasColumnName("PROVIDERTYPE");
        });

        modelBuilder.Entity<Dsharesyncevent>(entity =>
        {
            entity.HasKey(e => e.Eventtime);
            entity.ToTable("DSHARESYNCEVENT");

            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Eventparam)
                .HasMaxLength(4000)
                .HasColumnName("EVENTPARAM");
            entity.Property(e => e.Eventtime).HasColumnName("EVENTTIME");
            entity.Property(e => e.Eventtype).HasColumnName("EVENTTYPE");
            entity.Property(e => e.Eventuserid)
                .HasMaxLength(255)
                .HasColumnName("EVENTUSERID");
            entity.Property(e => e.Provideritemid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERITEMID");
            entity.Property(e => e.Providertype).HasColumnName("PROVIDERTYPE");
            entity.Property(e => e.Providerversionid)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERVERSIONID");
            entity.Property(e => e.Synctaskid)
                .HasMaxLength(255)
                .HasColumnName("SYNCTASKID");
        });

        modelBuilder.Entity<Dsharesyncitem>(entity =>
        {
            entity.HasKey(e => e.Csparentid);
            entity.ToTable("DSHARESYNCITEMS");

            entity.Property(e => e.Csitemid).HasColumnName("CSITEMID");
            entity.Property(e => e.Csparentid).HasColumnName("CSPARENTID");
            entity.Property(e => e.Cssubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("CSSUBTYPE");
            entity.Property(e => e.Partialsyncstate).HasColumnName("PARTIALSYNCSTATE");
            entity.Property(e => e.Sharedon).HasColumnName("SHAREDON");
            entity.Property(e => e.Shareid).HasColumnName("SHAREID");
        });

        modelBuilder.Entity<Dsignature>(entity =>
        {
            entity.HasKey(e => new { e.Workid, e.Dataid });
            entity.ToTable("DSIGNATURE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Signtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SIGNTYPE");
            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Vers).HasColumnName("VERS");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Dsignaturerequest>(entity =>
        {
            entity.HasKey(e => new { e.Providerrequestkey, e.Providername });
            entity.ToTable("DSIGNATUREREQUESTS");

            entity.Property(e => e.Created).HasColumnName("CREATED");
            entity.Property(e => e.Datastring)
                .HasColumnType("NCLOB")
                .HasColumnName("DATASTRING");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.Providername)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERNAME");
            entity.Property(e => e.Providerrequestkey)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERREQUESTKEY");
            entity.Property(e => e.Providerusername)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERUSERNAME");
            entity.Property(e => e.Requestid).HasColumnName("REQUESTID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dsignaturerequestitem>(entity =>
        {
            entity.HasKey(e => new { e.Requestid, e.Csitemid });
            entity.ToTable("DSIGNATUREREQUESTITEMS");

            entity.Property(e => e.Csitemid).HasColumnName("CSITEMID");
            entity.Property(e => e.Csversionnum).HasColumnName("CSVERSIONNUM");
            entity.Property(e => e.Requestid).HasColumnName("REQUESTID");
        });

        modelBuilder.Entity<Dsocialfeedevent>(entity =>
        {
            entity.HasKey(e => new { e.Nid, e.Dataid, e.Userid });

            entity.ToTable("DSOCIALFEEDEVENTS");

            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Conversationid).HasColumnName("CONVERSATIONID");
            entity.Property(e => e.Eventinfo)
                .HasColumnType("NCLOB")
                .HasColumnName("EVENTINFO");
            entity.Property(e => e.Eventtype).HasColumnName("EVENTTYPE");
            entity.Property(e => e.Modifieddate).HasColumnName("MODIFIEDDATE");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");
            entity.Property(e => e.Sgmdataid).HasColumnName("SGMDATAID");
            entity.Property(e => e.Visible).HasColumnName("VISIBLE");
            entity.Property(e => e.Visibletofollowers).HasColumnName("VISIBLETOFOLLOWERS");
        });

        modelBuilder.Entity<Dsocialfollower>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Followid, e.Followdate });
            entity.ToTable("DSOCIALFOLLOWERS");

            entity.Property(e => e.Followdate).HasColumnName("FOLLOWDATE");
            entity.Property(e => e.Followid).HasColumnName("FOLLOWID");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dsocialitemcount>(entity =>
        {
            entity.HasKey(e => e.Userid);

            entity.ToTable("DSOCIALITEMCOUNT");

            entity.Property(e => e.Userid)
                .ValueGeneratedNever()
                .HasColumnName("USERID");
            entity.Property(e => e.Followers)
                .HasColumnType("INTEGER")
                .HasColumnName("FOLLOWERS");
            entity.Property(e => e.Following)
                .HasColumnType("INTEGER")
                .HasColumnName("FOLLOWING");
            entity.Property(e => e.Mentions)
                .HasColumnType("INTEGER")
                .HasColumnName("MENTIONS");
            entity.Property(e => e.Privatemessages)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIVATEMESSAGES");
        });

        modelBuilder.Entity<Dsociallike>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Itemid });

            entity.ToTable("DSOCIALLIKE");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Itemid).HasColumnName("ITEMID");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Ratingtype).HasColumnName("RATINGTYPE");
        });

        modelBuilder.Entity<Dsocialmention>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Postid });

            entity.ToTable("DSOCIALMENTIONS");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Postid).HasColumnName("POSTID");
        });

        modelBuilder.Entity<Dsocialobjectsdisposition>(entity =>
        {
            entity.HasKey(e => new { e.Dispodate, e.Action, e.Dataid, e.Appid });

            entity.ToTable("DSOCIALOBJECTSDISPOSITION");

            entity.Property(e => e.Dispodate).HasColumnName("DISPODATE");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("ACTION");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Appid)
                .HasMaxLength(255)
                .HasColumnName("APPID");
            entity.Property(e => e.Remoteid)
                .HasMaxLength(255)
                .HasColumnName("REMOTEID");
        });

        modelBuilder.Entity<Dsocialobjectsetting>(entity =>
        {
            entity.HasKey(e => e.Dataid);

            entity.ToTable("DSOCIALOBJECTSETTINGS");

            entity.Property(e => e.Dataid)
                .ValueGeneratedNever()
                .HasColumnName("DATAID");
            entity.Property(e => e.Attachments).HasColumnName("ATTACHMENTS");
            entity.Property(e => e.Comments).HasColumnName("COMMENTS");
            entity.Property(e => e.Commentsopen).HasColumnName("COMMENTSOPEN");
            entity.Property(e => e.Likes).HasColumnName("LIKES");
            entity.Property(e => e.Replies).HasColumnName("REPLIES");
            entity.Property(e => e.Shortcuts).HasColumnName("SHORTCUTS");
            entity.Property(e => e.Tags).HasColumnName("TAGS");
        });

        modelBuilder.Entity<Dsocialpreference>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Prefid, e.Prefvalue });

            entity.ToTable("DSOCIALPREFERENCES");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Prefid).HasColumnName("PREFID");
            entity.Property(e => e.Prefvalue).HasColumnName("PREFVALUE");
        });

        modelBuilder.Entity<Dstagingimport>(entity =>
        {
            entity.HasKey(e => new { e.Tagname, e.Nid });
            entity.ToTable("DSTAGINGIMPORT");

            entity.Property(e => e.Chardata)
                .HasMaxLength(255)
                .HasColumnName("CHARDATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Segment)
                .HasColumnType("NCLOB")
                .HasColumnName("SEGMENT");
            entity.Property(e => e.Segmentid).HasColumnName("SEGMENTID");
            entity.Property(e => e.Tagname)
                .HasMaxLength(128)
                .HasColumnName("TAGNAME");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
        });

        modelBuilder.Entity<Dsuggestexception>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DSUGGESTEXCEPTIONS");

            entity.Property(e => e.Allow)
                .HasColumnType("INTEGER")
                .HasColumnName("ALLOW");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("TOKEN");
        });

        modelBuilder.Entity<Dsuggestword>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.Namespace, e.Token });
            entity.ToTable("DSUGGESTWORDS");

            entity.Property(e => e.Namespace)
                .HasMaxLength(64)
                .HasColumnName("NAMESPACE");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Occcount).HasColumnName("OCCCOUNT");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("TOKEN");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Dsuggestwordshash>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("DSUGGESTWORDSHASH");

            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasColumnName("HASH");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Penalty)
                .HasColumnType("INTEGER")
                .HasColumnName("PENALTY");
        });

        modelBuilder.Entity<Dsuggestwordspending>(entity =>
        {
            entity.HasKey(e => e.Nid);
            entity.ToTable("DSUGGESTWORDSPENDING");

            entity.Property(e => e.Namespace)
                .HasMaxLength(64)
                .HasColumnName("NAMESPACE");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Occcount)
                .HasColumnType("INTEGER")
                .HasColumnName("OCCCOUNT");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("TOKEN");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Dtopicitem>(entity =>
        {
            entity.HasKey(e => new { e.Discussionid, e.Topicid });
            entity.ToTable("DTOPICITEMS");

            entity.Property(e => e.Discussionid).HasColumnName("DISCUSSIONID");
            entity.Property(e => e.Itemid).HasColumnName("ITEMID");
            entity.Property(e => e.Topicid).HasColumnName("TOPICID");
        });

        modelBuilder.Entity<Dtree>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DTREE");

            entity.Property(e => e.Aclcount)
                .HasColumnType("INTEGER")
                .HasColumnName("ACLCOUNT");
            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Cacheexpiration)
                .HasColumnType("INTEGER")
                .HasColumnName("CACHEEXPIRATION");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dateassigned).HasColumnName("DATEASSIGNED");
            entity.Property(e => e.Datecompleted).HasColumnName("DATECOMPLETED");
            entity.Property(e => e.Datedue).HasColumnName("DATEDUE");
            entity.Property(e => e.Dateeffective).HasColumnName("DATEEFFECTIVE");
            entity.Property(e => e.Dateexpiration).HasColumnName("DATEEXPIRATION");
            entity.Property(e => e.Datestarted).HasColumnName("DATESTARTED");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Exatt2)
                .HasMaxLength(255)
                .HasColumnName("EXATT2");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Guid)
                .HasMaxLength(16)
                .HasDefaultValueSql("1")
                .HasColumnName("GUID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Maxvers)
                .HasColumnType("INTEGER")
                .HasColumnName("MAXVERS");
            entity.Property(e => e.Minor).HasColumnName("MINOR");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Originownerid).HasColumnName("ORIGINOWNERID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Releaseref).HasColumnName("RELEASEREF");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<Dtreeacl>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DTREEACL");

            entity.Property(e => e.Acltype).HasColumnName("ACLTYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permissions)
                .HasColumnType("INTEGER")
                .HasColumnName("PERMISSIONS");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.See).HasColumnName("SEE");
        });

        modelBuilder.Entity<Dtreeancestor>(entity =>
        {
            entity.HasKey(e => new { e.Ancestorid, e.Dataid });
            entity.ToTable("DTREEANCESTORS");

            entity.Property(e => e.Ancestorid).HasColumnName("ANCESTORID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Dtreeancestorsleafnode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DTREEANCESTORSLEAFNODES");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Dtreeaspectsnotify>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Nid });
            entity.ToTable("DTREEASPECTSNOTIFY");

            entity.Property(e => e.Atype).HasColumnName("ATYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dtreecore>(entity =>
        {
            entity.HasKey(e => new { e.Createdate, e.Dataid });
            entity.ToTable("DTREECORE");

            entity.Property(e => e.Aclcount)
                .HasColumnType("INTEGER")
                .HasColumnName("ACLCOUNT");
            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Cacheexpiration)
                .HasColumnType("INTEGER")
                .HasColumnName("CACHEEXPIRATION");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dateassigned).HasColumnName("DATEASSIGNED");
            entity.Property(e => e.Datecompleted).HasColumnName("DATECOMPLETED");
            entity.Property(e => e.Datedue).HasColumnName("DATEDUE");
            entity.Property(e => e.Dateeffective).HasColumnName("DATEEFFECTIVE");
            entity.Property(e => e.Dateexpiration).HasColumnName("DATEEXPIRATION");
            entity.Property(e => e.Datestarted).HasColumnName("DATESTARTED");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Exatt2)
                .HasMaxLength(255)
                .HasColumnName("EXATT2");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Guid)
                .HasMaxLength(16)
                .HasDefaultValueSql("1")
                .HasColumnName("GUID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Maxvers)
                .HasColumnType("INTEGER")
                .HasColumnName("MAXVERS");
            entity.Property(e => e.Minor).HasColumnName("MINOR");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Originownerid).HasColumnName("ORIGINOWNERID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Releaseref).HasColumnName("RELEASEREF");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<Dtreecoreexternaldatum>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Versionnum });
            entity.ToTable("DTREECOREEXTERNALDATA");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Externalcreatorid).HasColumnName("EXTERNALCREATORID");
            entity.Property(e => e.Externalmodifydate).HasColumnName("EXTERNALMODIFYDATE");
            entity.Property(e => e.Externalsourceid).HasColumnName("EXTERNALSOURCEID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");

            entity.HasOne(d => d.Externalcreator).WithMany()
                .HasForeignKey(d => d.Externalcreatorid)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Externalsource).WithMany()
                .HasForeignKey(d => d.Externalsourceid)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Dtreecoreexternalsource>(entity =>
        {
            entity.ToTable("DTREECOREEXTERNALSOURCE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Display)
                .HasColumnType("NCLOB")
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Dtreedeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DTREEDELETED");

            entity.Property(e => e.Aclcount)
                .HasColumnType("INTEGER")
                .HasColumnName("ACLCOUNT");
            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Cacheexpiration)
                .HasColumnType("INTEGER")
                .HasColumnName("CACHEEXPIRATION");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dateassigned).HasColumnName("DATEASSIGNED");
            entity.Property(e => e.Datecompleted).HasColumnName("DATECOMPLETED");
            entity.Property(e => e.Datedue).HasColumnName("DATEDUE");
            entity.Property(e => e.Dateeffective).HasColumnName("DATEEFFECTIVE");
            entity.Property(e => e.Dateexpiration).HasColumnName("DATEEXPIRATION");
            entity.Property(e => e.Datestarted).HasColumnName("DATESTARTED");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Exatt2)
                .HasMaxLength(255)
                .HasColumnName("EXATT2");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Guid)
                .HasMaxLength(16)
                .HasDefaultValueSql("1")
                .HasColumnName("GUID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Maxvers)
                .HasColumnType("INTEGER")
                .HasColumnName("MAXVERS");
            entity.Property(e => e.Minor).HasColumnName("MINOR");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Originownerid).HasColumnName("ORIGINOWNERID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Releaseref).HasColumnName("RELEASEREF");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<Dtreeextractorverify>(entity =>
        {
            entity.HasKey(e => new { e.Status, e.Retries });
            entity.ToTable("DTREEEXTRACTORVERIFY");

            entity.Property(e => e.Contentstatus).HasColumnName("CONTENTSTATUS");
            entity.Property(e => e.Correctionattempted).HasColumnName("CORRECTIONATTEMPTED");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Integrityerror).HasColumnName("INTEGRITYERROR");
            entity.Property(e => e.Lastretry).HasColumnName("LASTRETRY");
            entity.Property(e => e.Metadataerrors).HasColumnName("METADATAERRORS");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasColumnType("NCLOB")
                .HasColumnName("NAME");
            entity.Property(e => e.New).HasColumnName("NEW");
            entity.Property(e => e.Otobject)
                .HasColumnType("NCLOB")
                .HasColumnName("OTOBJECT");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Partitionmode)
                .HasColumnType("NCLOB")
                .HasColumnName("PARTITIONMODE");
            entity.Property(e => e.Partitionname)
                .HasColumnType("NCLOB")
                .HasColumnName("PARTITIONNAME");
            entity.Property(e => e.Retries).HasColumnName("RETRIES");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dtreemultilingual>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Languagecode });
            entity.ToTable("DTREEMULTILINGUAL");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Dtreenotify>(entity =>
        {
            entity.HasKey(e => e.Nid);
            entity.ToTable("DTREENOTIFY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Ntype).HasColumnName("NTYPE");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dtreenotifyrecover>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Versionnum });
            entity.ToTable("DTREENOTIFYRECOVER");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Lastretry).HasColumnName("LASTRETRY");
            entity.Property(e => e.Ntype)
                .HasColumnType("INTEGER")
                .HasColumnName("NTYPE");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Retries)
                .HasColumnType("INTEGER")
                .HasColumnName("RETRIES");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dtreeparentevent>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DTREEPARENTEVENT");

            entity.Property(e => e.Adjustment)
                .HasColumnType("INTEGER")
                .HasColumnName("ADJUSTMENT");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
        });

        modelBuilder.Entity<Dtreerule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DTREERULES");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ruleid).HasColumnName("RULEID");
        });

        modelBuilder.Entity<Dtreesubtypeorderref>(entity =>
        {
            entity.HasKey(e => new { e.Subtype, e.Orderref });
            entity.ToTable("DTREESUBTYPEORDERREF");

            entity.Property(e => e.Orderref).HasColumnName("ORDERREF");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
        });

        modelBuilder.Entity<Dtreesyncdatum>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DTREESYNCDATA");

            entity.Property(e => e.Clonetime).HasColumnName("CLONETIME");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Dtreesyncevent>(entity =>
        {
            entity.HasKey(e => e.Eventseqno);
            entity.ToTable("DTREESYNCEVENTS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Eventid)
                .HasColumnType("INTEGER")
                .HasColumnName("EVENTID");
            entity.Property(e => e.Eventseqno).HasColumnName("EVENTSEQNO");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Params)
                .HasMaxLength(4000)
                .HasColumnName("PARAMS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dtreesyncextradatum>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Configkeyword });
            entity.ToTable("DTREESYNCEXTRADATA");

            entity.Property(e => e.Configkeyword)
                .HasMaxLength(128)
                .HasColumnName("CONFIGKEYWORD");
            entity.Property(e => e.Configvalue)
                .HasColumnType("NCLOB")
                .HasColumnName("CONFIGVALUE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Dtreesyncinterest>(entity =>
        {
            entity.HasKey(e => new { e.Siteid, e.Dataid });
            entity.ToTable("DTREESYNCINTERESTS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Siteid).HasColumnName("SITEID");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("-1")
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Dtreesyncmessage>(entity =>
        {
            entity.HasKey(e => e.Messageid);
            entity.ToTable("DTREESYNCMESSAGES");

            entity.Property(e => e.Flags).HasColumnName("FLAGS");
            entity.Property(e => e.Info)
                .HasMaxLength(4000)
                .HasColumnName("INFO");
            entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");
            entity.Property(e => e.TimeStamp).HasColumnName("TIME_STAMP");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Dtreesyncqdsuser>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Siteid });
            entity.ToTable("DTREESYNCQDSUSERS");

            entity.Property(e => e.Siteid).HasColumnName("SITEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Dtreesyncqueue>(entity =>
        {
            entity.HasKey(e => e.Eventseqno);
            entity.ToTable("DTREESYNCQUEUE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Eventid)
                .HasColumnType("INTEGER")
                .HasColumnName("EVENTID");
            entity.Property(e => e.Eventseqno).HasColumnName("EVENTSEQNO");
            entity.Property(e => e.Exdata)
                .HasMaxLength(4000)
                .HasColumnName("EXDATA");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Remark).HasColumnName("REMARK");
            entity.Property(e => e.Siteid).HasColumnName("SITEID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dtreesyncsnf>(entity =>
        {
            entity.HasKey(e => new { e.Siteid, e.Dataid, e.Versionnum, e.Renditiontype });
            entity.ToTable("DTREESYNCSNF");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Remark).HasColumnName("REMARK");
            entity.Property(e => e.Renditiontype)
                .HasMaxLength(255)
                .HasColumnName("RENDITIONTYPE");
            entity.Property(e => e.Siteid).HasColumnName("SITEID");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dtreevectornotify>(entity =>
        {
            entity.HasKey(e => e.Nid);
            entity.ToTable("DTREEVECTORNOTIFY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Ntype).HasColumnName("NTYPE");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Dversdatavideoannotate>(entity =>
        {
            entity.HasKey(e => new { e.Versionid, e.Commentid });
            entity.ToTable("DVERSDATAVIDEOANNOTATE");

            entity.Property(e => e.Annotation)
                .HasMaxLength(4000)
                .HasColumnName("ANNOTATION");
            entity.Property(e => e.Commentdate).HasColumnName("COMMENTDATE");
            entity.Property(e => e.Commentdesc)
                .HasMaxLength(1024)
                .HasColumnName("COMMENTDESC");
            entity.Property(e => e.Commentid).HasColumnName("COMMENTID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
        });

        modelBuilder.Entity<Dversdatavideotranscode>(entity =>
        {
            entity.HasKey(e => e.Versionid);
            entity.ToTable("DVERSDATAVIDEOTRANSCODE");

            entity.Property(e => e.Filename)
                .HasMaxLength(1024)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Retrynum).HasColumnName("RETRYNUM");
            entity.Property(e => e.Transcodedate).HasColumnName("TRANSCODEDATE");
            entity.Property(e => e.Transcodekey)
                .HasMaxLength(128)
                .HasColumnName("TRANSCODEKEY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
        });

        modelBuilder.Entity<Dversdatum>(entity =>
        {
            entity.HasKey(e => e.Versionid);
            entity.ToTable("DVERSDATA");

            entity.Property(e => e.Datasize).HasColumnName("DATASIZE");
            entity.Property(e => e.Docid).HasColumnName("DOCID");
            entity.Property(e => e.Filecdate).HasColumnName("FILECDATE");
            entity.Property(e => e.Filecreator)
                .HasMaxLength(255)
                .HasColumnName("FILECREATOR");
            entity.Property(e => e.Filemdate).HasColumnName("FILEMDATE");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filetype)
                .HasMaxLength(255)
                .HasColumnName("FILETYPE");
            entity.Property(e => e.Finderflags)
                .HasColumnType("INTEGER")
                .HasColumnName("FINDERFLAGS");
            entity.Property(e => e.Guid)
                .HasMaxLength(16)
                .HasDefaultValueSql("1")
                .HasColumnName("GUID");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .HasColumnName("ICON");
            entity.Property(e => e.Indexed).HasColumnName("INDEXED");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Lockedby).HasColumnName("LOCKEDBY");
            entity.Property(e => e.Lockeddate).HasColumnName("LOCKEDDATE");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Owner).HasColumnName("OWNER");
            entity.Property(e => e.Pagenum)
                .HasColumnType("INTEGER")
                .HasColumnName("PAGENUM");
            entity.Property(e => e.Platform).HasColumnName("PLATFORM");
            entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");
            entity.Property(e => e.Ressize).HasColumnName("RESSIZE");
            entity.Property(e => e.Transient).HasColumnName("TRANSIENT");
            entity.Property(e => e.Vercdate).HasColumnName("VERCDATE");
            entity.Property(e => e.Vercomment)
                .HasMaxLength(255)
                .HasColumnName("VERCOMMENT");
            entity.Property(e => e.Vermajor).HasColumnName("VERMAJOR");
            entity.Property(e => e.Vermdate).HasColumnName("VERMDATE");
            entity.Property(e => e.Verminor).HasColumnName("VERMINOR");
            entity.Property(e => e.Version).HasColumnName("VERSION");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
            entity.Property(e => e.Versionname)
                .HasMaxLength(128)
                .HasColumnName("VERSIONNAME");
            entity.Property(e => e.Vertype)
                .HasMaxLength(255)
                .HasColumnName("VERTYPE");

            entity.HasOne(d => d.Provider).WithMany()
                .HasForeignKey(d => d.Providerid)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Dversextradatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DVERSEXTRADATA");

            entity.Property(e => e.Datastring)
                .HasColumnType("NCLOB")
                .HasColumnName("DATASTRING");
            entity.Property(e => e.Textstr)
                .HasMaxLength(64)
                .HasColumnName("TEXTSTR");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
        });

        modelBuilder.Entity<Dworkbench>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("DWORKBENCH");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Objectguid)
                .HasMaxLength(16)
                .HasColumnName("OBJECTGUID");
            entity.Property(e => e.Readydate).HasColumnName("READYDATE");
            entity.Property(e => e.Versionguid)
                .HasMaxLength(16)
                .HasColumnName("VERSIONGUID");
        });

        modelBuilder.Entity<EcmlinkConfigAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ECMLINK_CONFIG_ALL");

            entity.Property(e => e.AutoKeydef)
                .HasMaxLength(248)
                .HasColumnName("AUTO_KEYDEF");
            entity.Property(e => e.BadiBeforeAdd)
                .HasColumnType("INTEGER")
                .HasColumnName("BADI_BEFORE_ADD");
            entity.Property(e => e.BadiBeforeDel)
                .HasColumnType("INTEGER")
                .HasColumnName("BADI_BEFORE_DEL");
            entity.Property(e => e.BoTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("BO_TYPE_DELETED");
            entity.Property(e => e.BoTypeName)
                .HasMaxLength(248)
                .HasColumnName("BO_TYPE_NAME");
            entity.Property(e => e.BoTypeNodeId).HasColumnName("BO_TYPE_NODE_ID");
            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.BusrefName)
                .HasMaxLength(248)
                .HasColumnName("BUSREF_NAME");
            entity.Property(e => e.ConnType)
                .HasMaxLength(32)
                .HasColumnName("CONN_TYPE");
            entity.Property(e => e.DisplayUrl)
                .HasColumnType("NCLOB")
                .HasColumnName("DISPLAY_URL");
            entity.Property(e => e.EnableAutoAddBo)
                .HasColumnType("INTEGER")
                .HasColumnName("ENABLE_AUTO_ADD_BO");
            entity.Property(e => e.ExtSystemEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("EXT_SYSTEM_ENABLED");
            entity.Property(e => e.GenerateNameEarly)
                .HasColumnType("INTEGER")
                .HasColumnName("GENERATE_NAME_EARLY");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.IdWkspType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_WKSP_TYPE");
            entity.Property(e => e.IndexingEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("INDEXING_ENABLED");
            entity.Property(e => e.IsDefaultDisplay)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_DISPLAY");
            entity.Property(e => e.IsDefaultSearch)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_SEARCH");
            entity.Property(e => e.MetaDataMapping)
                .HasColumnType("INTEGER")
                .HasColumnName("META_DATA_MAPPING");
            entity.Property(e => e.TriggerAttr)
                .HasColumnType("INTEGER")
                .HasColumnName("TRIGGER_ATTR");
            entity.Property(e => e.TriggerCat).HasColumnName("TRIGGER_CAT");
            entity.Property(e => e.UseForBusref)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_FOR_BUSREF");
            entity.Property(e => e.UseForBuswksp)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_FOR_BUSWKSP");
            entity.Property(e => e.UseLocationManual)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_LOCATION_MANUAL");
            entity.Property(e => e.WkspIcon)
                .HasMaxLength(248)
                .HasColumnName("WKSP_ICON");
            entity.Property(e => e.WkspPolEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("WKSP_POL_ENABLED");
            entity.Property(e => e.WkspTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("WKSP_TYPE_DELETED");
            entity.Property(e => e.WkspTypeName)
                .HasMaxLength(248)
                .HasColumnName("WKSP_TYPE_NAME");
            entity.Property(e => e.WkspTypeNodeId).HasColumnName("WKSP_TYPE_NODE_ID");
        });

        modelBuilder.Entity<EcmlinkWkspLinked>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ECMLINK_WKSP_LINKED");

            entity.Property(e => e.BoTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("BO_TYPE_DELETED");
            entity.Property(e => e.BoTypeName)
                .HasMaxLength(248)
                .HasColumnName("BO_TYPE_NAME");
            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.IdBo)
                .HasMaxLength(128)
                .HasColumnName("ID_BO");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");
            entity.Property(e => e.IsDefaultDisplay)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_DISPLAY");
            entity.Property(e => e.IsDefaultSearch)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_SEARCH");
            entity.Property(e => e.WkspTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("WKSP_TYPE_DELETED");
            entity.Property(e => e.WkspTypeName)
                .HasMaxLength(248)
                .HasColumnName("WKSP_TYPE_NAME");
        });

        modelBuilder.Entity<EcmlinkWkspUnion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ECMLINK_WKSP_UNION");

            entity.Property(e => e.BoTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("BO_TYPE_DELETED");
            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.IdBo)
                .HasMaxLength(128)
                .HasColumnName("ID_BO");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.IdWkspType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_WKSP_TYPE");
            entity.Property(e => e.IsDefaultDisplay)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_DISPLAY");
            entity.Property(e => e.WkspTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("WKSP_TYPE_DELETED");
            entity.Property(e => e.WkspTypeName)
                .HasMaxLength(248)
                .HasColumnName("WKSP_TYPE_NAME");
        });

        modelBuilder.Entity<Elinkalias>(entity =>
        {
            entity.HasKey(e => e.Objectid);
            entity.ToTable("ELINKALIAS");

            entity.Property(e => e.Emailalias)
                .HasMaxLength(255)
                .HasColumnName("EMAILALIAS");
            entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            entity.Property(e => e.Objectidtype)
                .HasColumnType("INTEGER")
                .HasColumnName("OBJECTIDTYPE");
        });

        modelBuilder.Entity<Elinkmessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ELINKMESSAGES");

            entity.Property(e => e.Attachment)
                .HasMaxLength(255)
                .HasColumnName("ATTACHMENT");
            entity.Property(e => e.Cc)
                .HasMaxLength(4000)
                .HasColumnName("CC");
            entity.Property(e => e.Fromfield)
                .HasMaxLength(255)
                .HasColumnName("FROMFIELD");
            entity.Property(e => e.Message)
                .HasColumnType("NCLOB")
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Msgid).HasColumnName("MSGID");
            entity.Property(e => e.Nodeattachment).HasColumnName("NODEATTACHMENT");
            entity.Property(e => e.Replyto)
                .HasMaxLength(255)
                .HasColumnName("REPLYTO");
            entity.Property(e => e.Sender)
                .HasMaxLength(255)
                .HasColumnName("SENDER");
            entity.Property(e => e.Subject)
                .HasMaxLength(128)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Tofield)
                .HasMaxLength(4000)
                .HasColumnName("TOFIELD");
            entity.Property(e => e.Xheaders)
                .HasMaxLength(255)
                .HasColumnName("XHEADERS");
        });

        modelBuilder.Entity<Elinkmessagelog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ELINKMESSAGELOG");

            entity.Property(e => e.Addedon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("ADDEDON");
            entity.Property(e => e.Headers)
                .HasColumnType("NCLOB")
                .HasColumnName("HEADERS");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<Elinksubscription>(entity =>
        {
            entity.HasKey(e => new { e.KuafId, e.Objectid });
            entity.ToTable("ELINKSUBSCRIPTION");

            entity.Property(e => e.KuafId).HasColumnName("KUAF_ID");
            entity.Property(e => e.NotifyeventsEventaction)
                .HasColumnType("INTEGER")
                .HasColumnName("NOTIFYEVENTS_EVENTACTION");
            entity.Property(e => e.NotifyeventsEventid).HasColumnName("NOTIFYEVENTS_EVENTID");
            entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            entity.Property(e => e.Objectidtype)
                .HasColumnType("INTEGER")
                .HasColumnName("OBJECTIDTYPE");
        });

        modelBuilder.Entity<Elinkunhandledevent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ELINKUNHANDLEDEVENT");

            entity.Property(e => e.Objectid)
                .HasColumnType("INTEGER")
                .HasColumnName("OBJECTID");
        });

        modelBuilder.Entity<EssRecord>(entity =>
        {
            entity.HasKey(e => e.EssRecords);
            entity.ToTable("ESS_RECORDS");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.EssRecords)
                .HasMaxLength(32)
                .HasColumnName("ESS_RECORDS");
            entity.Property(e => e.EssRecordsDescE)
                .HasMaxLength(64)
                .HasColumnName("ESS_RECORDS_DESC_E");
            entity.Property(e => e.EssRecordsDescF)
                .HasMaxLength(64)
                .HasColumnName("ESS_RECORDS_DESC_F");
        });

        modelBuilder.Entity<ExtendedUserInfo>(entity =>
        {
            entity.HasKey(e => e.SfUserId);
            entity.ToTable("EXTENDED_USER_INFO");

            entity.Property(e => e.CsUserId).HasColumnName("CS_USER_ID");
            entity.Property(e => e.SfUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_USER_ID");
            entity.Property(e => e.WsId).HasColumnName("WS_ID");
        });

        modelBuilder.Entity<Facility>(entity =>
        {
            entity.HasKey(e => e.Facility1);
            entity.ToTable("FACILITY");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Checkboxfit)
                .HasColumnType("INTEGER")
                .HasColumnName("CHECKBOXFIT");
            entity.Property(e => e.DescE)
                .HasMaxLength(128)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Facility1)
                .HasMaxLength(32)
                .HasColumnName("FACILITY");
            entity.Property(e => e.Managed).HasColumnName("MANAGED");
        });

        modelBuilder.Entity<Fdahead>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("FDAHEADS");

            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Fieldinfo>(entity =>
        {
            entity.HasKey(e => new { e.Workid, e.Fname });
            entity.ToTable("FIELDINFO");

            entity.Property(e => e.Fname)
                .HasMaxLength(32)
                .HasColumnName("FNAME");
            entity.Property(e => e.Leftpos)
                .HasColumnType("INTEGER")
                .HasColumnName("LEFTPOS");
            entity.Property(e => e.Toppos)
                .HasColumnType("INTEGER")
                .HasColumnName("TOPPOS");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<FileStatus>(entity =>
        {
            entity.HasKey(e => e.FileStatus1);
            entity.ToTable("FILE_STATUS");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Dispositionflag).HasColumnName("DISPOSITIONFLAG");
            entity.Property(e => e.FileStatus1)
                .HasMaxLength(32)
                .HasColumnName("FILE_STATUS");
            entity.Property(e => e.FileStatusDescE)
                .HasMaxLength(64)
                .HasColumnName("FILE_STATUS_DESC_E");
            entity.Property(e => e.FileStatusDescF)
                .HasMaxLength(64)
                .HasColumnName("FILE_STATUS_DESC_F");
            entity.Property(e => e.Folderholdflag)
                .HasMaxLength(32)
                .HasColumnName("FOLDERHOLDFLAG");
        });

        modelBuilder.Entity<Filecache>(entity =>
        {
            entity.HasKey(e => new { e.Seqnum, e.Uniqueid });
            entity.ToTable("FILECACHE");

            entity.Property(e => e.Adminserver)
                .HasMaxLength(64)
                .HasColumnName("ADMINSERVER");
            entity.Property(e => e.Lastaccessed).HasColumnName("LASTACCESSED");
            entity.Property(e => e.Seqnum).HasColumnName("SEQNUM");
            entity.Property(e => e.Uniqueid)
                .HasMaxLength(440)
                .HasColumnName("UNIQUEID");
        });

        modelBuilder.Entity<FollowupSeqnr>(entity =>
        {
            entity.HasKey(e => e.Seqname);
            entity.ToTable("FOLLOWUP_SEQNR");

            entity.Property(e => e.Lastused).HasColumnName("LASTUSED");
            entity.Property(e => e.Seqname)
                .HasMaxLength(64)
                .HasColumnName("SEQNAME");
        });

        modelBuilder.Entity<Formdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FORMDATA");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Formid).HasColumnName("FORMID");
            entity.Property(e => e.Lockflag)
                .HasColumnType("INTEGER")
                .HasColumnName("LOCKFLAG");
            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Formssequence>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum });
            entity.ToTable("FORMSSEQUENCE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<Holdtype>(entity =>
        {
            entity.HasKey(e => e.Holdtype1);
            entity.ToTable("HOLDTYPE");

            entity.Property(e => e.Defaultperiod).HasColumnName("DEFAULTPERIOD");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Holdtype1)
                .HasMaxLength(32)
                .HasColumnName("HOLDTYPE");
            entity.Property(e => e.HoldtypeDescE)
                .HasMaxLength(128)
                .HasColumnName("HOLDTYPE_DESC_E");
            entity.Property(e => e.HoldtypeDescF)
                .HasMaxLength(128)
                .HasColumnName("HOLDTYPE_DESC_F");
        });

        modelBuilder.Entity<Iconbardisplay>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("ICONBARDISPLAY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Settings)
                .HasColumnType("NCLOB")
                .HasColumnName("SETTINGS");
        });

        modelBuilder.Entity<IkBolumturleri>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_BOLUMTURLERI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bolum)
                .HasMaxLength(255)
                .HasColumnName("BOLUM");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkEgitimturleri>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_EGITIMTURLERI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Egitimturu)
                .HasMaxLength(255)
                .HasColumnName("EGITIMTURU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkPersonelturleri>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_PERSONELTURLERI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Personelturu)
                .HasMaxLength(255)
                .HasColumnName("PERSONELTURU");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkPersonelview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IK_PERSONELVIEW");

            entity.Property(e => e.Adsoyad)
                .HasMaxLength(255)
                .HasColumnName("ADSOYAD");
            entity.Property(e => e.Altgrup)
                .HasMaxLength(255)
                .HasColumnName("ALTGRUP");
            entity.Property(e => e.Altgruptanim)
                .HasMaxLength(255)
                .HasColumnName("ALTGRUPTANIM");
            entity.Property(e => e.Calisangrup)
                .HasMaxLength(255)
                .HasColumnName("CALISANGRUP");
            entity.Property(e => e.Calisangruptanim)
                .HasMaxLength(255)
                .HasColumnName("CALISANGRUPTANIM");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Orgbirim)
                .HasMaxLength(255)
                .HasColumnName("ORGBIRIM");
            entity.Property(e => e.Orgbirimtanim)
                .HasMaxLength(255)
                .HasColumnName("ORGBIRIMTANIM");
            entity.Property(e => e.Personelno)
                .HasMaxLength(255)
                .HasColumnName("PERSONELNO");
            entity.Property(e => e.Personelunvan)
                .HasMaxLength(255)
                .HasColumnName("PERSONELUNVAN");
            entity.Property(e => e.Pozisyon)
                .HasMaxLength(255)
                .HasColumnName("POZISYON");
            entity.Property(e => e.Pozisyontanim)
                .HasMaxLength(255)
                .HasColumnName("POZISYONTANIM");
            entity.Property(e => e.Tckn)
                .HasMaxLength(255)
                .HasColumnName("TCKN");
        });

        modelBuilder.Entity<IkPozisyonturleri>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_POZISYONTURLERI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Personelturu)
                .HasMaxLength(255)
                .HasColumnName("PERSONELTURU");
            entity.Property(e => e.Pozisyon)
                .HasMaxLength(255)
                .HasColumnName("POZISYON");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkSehirlistesi>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_SEHIRLISTESI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Sehir)
                .HasMaxLength(255)
                .HasColumnName("SEHIR");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkUniversitebolumlistesi>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_UNIVERSITEBOLUMLISTESI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bolumadi)
                .HasMaxLength(255)
                .HasColumnName("BOLUMADI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkUniversitelistesi>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_UNIVERSITELISTESI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Universiteadi)
                .HasMaxLength(255)
                .HasColumnName("UNIVERSITEADI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkUyruklistesi>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_UYRUKLISTESI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Ulkekodu)
                .HasMaxLength(255)
                .HasColumnName("ULKEKODU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<IkYabancidillistesi>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("IK_YABANCIDILLISTESI");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Yabancidil)
                .HasMaxLength(255)
                .HasColumnName("YABANCIDIL");
        });

        modelBuilder.Entity<Indextracerdatum>(entity =>
        {
            entity.HasKey(e => e.Createtime);
            entity.ToTable("INDEXTRACERDATA");

            entity.Property(e => e.Createtime).HasColumnName("CREATETIME");
            entity.Property(e => e.Dcsconversiontime).HasColumnName("DCSCONVERSIONTIME");
            entity.Property(e => e.Dcsid)
                .HasMaxLength(255)
                .HasColumnName("DCSID");
            entity.Property(e => e.Extractorid).HasColumnName("EXTRACTORID");
            entity.Property(e => e.Extracttime).HasColumnName("EXTRACTTIME");
            entity.Property(e => e.Indextime).HasColumnName("INDEXTIME");
            entity.Property(e => e.Iterator)
                .HasMaxLength(64)
                .HasColumnName("ITERATOR");
            entity.Property(e => e.Operation).HasColumnName("OPERATION");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Tracerid).HasColumnName("TRACERID");
        });

        modelBuilder.Entity<InterviewFetched>(entity =>
        {
            entity.HasKey(e => new { e.Locationid, e.Instanceid, e.Docid });
            entity.ToTable("INTERVIEW_FETCHED");

            entity.Property(e => e.Docid).HasColumnName("DOCID");
            entity.Property(e => e.Instanceid)
                .HasMaxLength(64)
                .HasColumnName("INSTANCEID");
            entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");
        });

        modelBuilder.Entity<InterviewGenerated>(entity =>
        {
            entity.HasKey(e => e.Instanceid);
            entity.ToTable("INTERVIEW_GENERATED");

            entity.Property(e => e.Docid).HasColumnName("DOCID");
            entity.Property(e => e.Instanceid)
                .HasMaxLength(64)
                .HasColumnName("INSTANCEID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
        });

        modelBuilder.Entity<InterviewProcess>(entity =>
        {
            entity.HasKey(e => e.Locationid);
            entity.ToTable("INTERVIEW_PROCESS");

            entity.Property(e => e.Destid).HasColumnName("DESTID");
            entity.Property(e => e.Instanceid)
                .HasMaxLength(64)
                .HasColumnName("INSTANCEID");
            entity.Property(e => e.Ivdate).HasColumnName("IVDATE");
            entity.Property(e => e.Les)
                .HasColumnType("INTEGER")
                .HasColumnName("LES");
            entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");
            entity.Property(e => e.Pf)
                .HasColumnType("INTEGER")
                .HasColumnName("PF");
            entity.Property(e => e.Processed)
                .HasColumnType("INTEGER")
                .HasColumnName("PROCESSED");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Itemrefdatum>(entity =>
        {
            entity.HasKey(e => new { e.Seqno, e.Docid });
            entity.ToTable("ITEMREFDATA");

            entity.Property(e => e.Docid).HasColumnName("DOCID");
            entity.Property(e => e.Reftype)
                .HasColumnType("INTEGER")
                .HasColumnName("REFTYPE");
            entity.Property(e => e.Seqno).HasColumnName("SEQNO");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Itemrefinfo>(entity =>
        {
            entity.HasKey(e => e.Seqno);
            entity.ToTable("ITEMREFINFO");

            entity.Property(e => e.Itemid)
                .HasColumnType("INTEGER")
                .HasColumnName("ITEMID");
            entity.Property(e => e.Itemrefid)
                .HasColumnType("INTEGER")
                .HasColumnName("ITEMREFID");
            entity.Property(e => e.Lockflag)
                .HasColumnType("INTEGER")
                .HasColumnName("LOCKFLAG");
            entity.Property(e => e.Seqno).HasColumnName("SEQNO");
            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Jurisdcode>(entity =>
        {
            entity.HasKey(e => e.Jurisdcode1);
            entity.ToTable("JURISDCODE");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Jurisdcode1)
                .HasMaxLength(32)
                .HasColumnName("JURISDCODE");
            entity.Property(e => e.JurisdcodeDescE)
                .HasMaxLength(128)
                .HasColumnName("JURISDCODE_DESC_E");
        });

        modelBuilder.Entity<Justification>(entity =>
        {
            entity.HasKey(e => e.Justificationid);
            entity.ToTable("JUSTIFICATION");

            entity.Property(e => e.Agency)
                .HasMaxLength(255)
                .HasColumnName("AGENCY");
            entity.Property(e => e.Citation)
                .HasMaxLength(4000)
                .HasColumnName("CITATION");
            entity.Property(e => e.Disposition)
                .HasMaxLength(32)
                .HasColumnName("DISPOSITION");
            entity.Property(e => e.Jurisdcode)
                .HasMaxLength(32)
                .HasColumnName("JURISDCODE");
            entity.Property(e => e.Justificationid).HasColumnName("JUSTIFICATIONID");
            entity.Property(e => e.JustifydescE)
                .HasMaxLength(255)
                .HasColumnName("JUSTIFYDESC_E");
            entity.Property(e => e.Legalref)
                .HasMaxLength(64)
                .HasColumnName("LEGALREF");
            entity.Property(e => e.Recaffected)
                .HasMaxLength(255)
                .HasColumnName("RECAFFECTED");
            entity.Property(e => e.Retcode)
                .HasMaxLength(32)
                .HasColumnName("RETCODE");
            entity.Property(e => e.Retperiod)
                .HasMaxLength(4000)
                .HasColumnName("RETPERIOD");
        });

        modelBuilder.Entity<Kactivitystorage>(entity =>
        {
            entity.HasKey(e => e.Profilekey);
            entity.ToTable("KACTIVITYSTORAGE");

            entity.Property(e => e.Eventdatenum).HasColumnName("EVENTDATENUM");
            entity.Property(e => e.Filesize).HasColumnName("FILESIZE");
            entity.Property(e => e.Maxtime).HasColumnName("MAXTIME");
            entity.Property(e => e.Mintime).HasColumnName("MINTIME");
            entity.Property(e => e.Operation)
                .HasMaxLength(255)
                .HasColumnName("OPERATION");
            entity.Property(e => e.Profilekey)
                .HasMaxLength(255)
                .HasColumnName("PROFILEKEY");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("PROVIDER");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("REFERENCE");
            entity.Property(e => e.Rownumid).HasColumnName("ROWNUMID");
            entity.Property(e => e.Totalcount).HasColumnName("TOTALCOUNT");
            entity.Property(e => e.Totaltime).HasColumnName("TOTALTIME");
        });

        modelBuilder.Entity<Kactivityworkload>(entity =>
        {
            entity.HasKey(e => e.Rowidnum);
            entity.ToTable("KACTIVITYWORKLOAD");

            entity.Property(e => e.Classname)
                .HasMaxLength(255)
                .HasColumnName("CLASSNAME");
            entity.Property(e => e.Maxtime).HasColumnName("MAXTIME");
            entity.Property(e => e.Mintime).HasColumnName("MINTIME");
            entity.Property(e => e.Operation)
                .HasMaxLength(255)
                .HasColumnName("OPERATION");
            entity.Property(e => e.Profilekey)
                .HasMaxLength(255)
                .HasColumnName("PROFILEKEY");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("REFERENCE");
            entity.Property(e => e.Rowidnum).HasColumnName("ROWIDNUM");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
            entity.Property(e => e.Totalcount).HasColumnName("TOTALCOUNT");
            entity.Property(e => e.Totaltime).HasColumnName("TOTALTIME");
        });

        modelBuilder.Entity<Kactivityworkloadsummary>(entity =>
        {
            entity.HasKey(e => e.Rowidnum);
            entity.ToTable("KACTIVITYWORKLOADSUMMARY");

            entity.Property(e => e.Classname)
                .HasMaxLength(255)
                .HasColumnName("CLASSNAME");
            entity.Property(e => e.Maxtime).HasColumnName("MAXTIME");
            entity.Property(e => e.Mintime).HasColumnName("MINTIME");
            entity.Property(e => e.Operation)
                .HasMaxLength(255)
                .HasColumnName("OPERATION");
            entity.Property(e => e.Profilekey)
                .HasMaxLength(255)
                .HasColumnName("PROFILEKEY");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("REFERENCE");
            entity.Property(e => e.Rowidnum).HasColumnName("ROWIDNUM");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
            entity.Property(e => e.Totalcount).HasColumnName("TOTALCOUNT");
            entity.Property(e => e.Totaltime).HasColumnName("TOTALTIME");
        });

        modelBuilder.Entity<Kdual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KDUAL");

            entity.Property(e => e.Onecolumn).HasColumnName("ONECOLUMN");
        });

        modelBuilder.Entity<Kerrorfault>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KERRORFAULT");

            entity.Property(e => e.Data)
                .HasColumnType("NCLOB")
                .HasColumnName("DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datestamp).HasColumnName("DATESTAMP");
            entity.Property(e => e.Faultid).HasColumnName("FAULTID");
            entity.Property(e => e.Instanceid)
                .HasMaxLength(255)
                .HasColumnName("INSTANCEID");
            entity.Property(e => e.Rowidnum).HasColumnName("ROWIDNUM");
            entity.Property(e => e.Severity).HasColumnName("SEVERITY");
            entity.Property(e => e.Threadindex).HasColumnName("THREADINDEX");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Kid>(entity =>
        {
            entity.HasKey(e => e.Idtype);
            entity.ToTable("KID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idtype)
                .HasColumnType("INTEGER")
                .HasColumnName("IDTYPE");
        });

        modelBuilder.Entity<Kini>(entity =>
        {
            entity.HasKey(e => new { e.Inisection, e.Inikeyword });
            entity.ToTable("KINI");

            entity.Property(e => e.Inikeyword)
                .HasMaxLength(128)
                .HasColumnName("INIKEYWORD");
            entity.Property(e => e.Inisection)
                .HasMaxLength(128)
                .HasColumnName("INISECTION");
            entity.Property(e => e.Inivalue)
                .HasColumnType("NCLOB")
                .HasColumnName("INIVALUE");
        });

        modelBuilder.Entity<Klong>(entity =>
        {
            entity.HasKey(e => e.Ownerid);
            entity.ToTable("KLONG");

            entity.Property(e => e.Longid).HasColumnName("LONGID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Segment)
                .HasColumnType("NCLOB")
                .HasColumnName("SEGMENT");
            entity.Property(e => e.Segmentid)
                .HasColumnType("INTEGER")
                .HasColumnName("SEGMENTID");
        });

        modelBuilder.Entity<Kmessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KMESSAGES");

            entity.Property(e => e.Aggregatekey)
                .HasMaxLength(255)
                .HasColumnName("AGGREGATEKEY");
            entity.Property(e => e.Bodyid).HasColumnName("BODYID");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Expireson).HasColumnName("EXPIRESON");
            entity.Property(e => e.Hashtoken)
                .HasMaxLength(64)
                .HasColumnName("HASHTOKEN");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Messagetype)
                .HasColumnType("INTEGER")
                .HasColumnName("MESSAGETYPE");
            entity.Property(e => e.Shortmessage)
                .HasMaxLength(255)
                .HasColumnName("SHORTMESSAGE");
            entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");
            entity.Property(e => e.State)
                .HasColumnType("INTEGER")
                .HasColumnName("STATE");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Subjectdecoration)
                .HasMaxLength(32)
                .HasColumnName("SUBJECTDECORATION");
            entity.Property(e => e.Threadid).HasColumnName("THREADID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Kmessageaggregate>(entity =>
        {
            entity.HasKey(e => new { e.Aggregatekey, e.Threadid });
            entity.ToTable("KMESSAGEAGGREGATES");

            entity.Property(e => e.Aggregatekey)
                .HasMaxLength(255)
                .HasColumnName("AGGREGATEKEY");
            entity.Property(e => e.Threadid).HasColumnName("THREADID");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<Kmessagebody>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Expireson, e.Sourceid });
            entity.ToTable("KMESSAGEBODY");

            entity.Property(e => e.Aggregatekey)
                .HasMaxLength(255)
                .HasColumnName("AGGREGATEKEY");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Expireson).HasColumnName("EXPIRESON");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Messagetoken)
                .HasMaxLength(255)
                .HasColumnName("MESSAGETOKEN");
            entity.Property(e => e.Messagetype)
                .HasColumnType("INTEGER")
                .HasColumnName("MESSAGETYPE");
            entity.Property(e => e.Shortmessage)
                .HasMaxLength(255)
                .HasColumnName("SHORTMESSAGE");
            entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Subjectdecoration)
                .HasMaxLength(32)
                .HasColumnName("SUBJECTDECORATION");
        });

        modelBuilder.Entity<Kmessagecount>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("KMESSAGECOUNTS");

            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.Notifysummary)
                .HasMaxLength(4000)
                .HasColumnName("NOTIFYSUMMARY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Kmessageemail>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Msgid });
            entity.ToTable("KMESSAGEEMAIL");

            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Deliverafter).HasColumnName("DELIVERAFTER");
            entity.Property(e => e.Messagetype)
                .HasColumnType("INTEGER")
                .HasColumnName("MESSAGETYPE");
            entity.Property(e => e.Msgid).HasColumnName("MSGID");
            entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");
            entity.Property(e => e.State)
                .HasColumnType("INTEGER")
                .HasColumnName("STATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Kmessageheader>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KMESSAGEHEADERS");

            entity.Property(e => e.Bodyid).HasColumnName("BODYID");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Expireson).HasColumnName("EXPIRESON");
            entity.Property(e => e.Hashtoken)
                .HasMaxLength(64)
                .HasColumnName("HASHTOKEN");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Messagetype)
                .HasColumnType("INTEGER")
                .HasColumnName("MESSAGETYPE");
            entity.Property(e => e.Shortmessage)
                .HasMaxLength(255)
                .HasColumnName("SHORTMESSAGE");
            entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");
            entity.Property(e => e.State)
                .HasColumnType("INTEGER")
                .HasColumnName("STATE");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Subjectdecoration)
                .HasMaxLength(32)
                .HasColumnName("SUBJECTDECORATION");
            entity.Property(e => e.Threadid).HasColumnName("THREADID");
            entity.Property(e => e.Unread).HasColumnName("UNREAD");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Kmessageparam>(entity =>
        {
            entity.HasKey(e => new { e.Paramkey, e.Bodyid, e.Command });
            entity.ToTable("KMESSAGEPARAMS");

            entity.Property(e => e.Bodyid).HasColumnName("BODYID");
            entity.Property(e => e.Command)
                .HasMaxLength(255)
                .HasColumnName("COMMAND");
            entity.Property(e => e.Paramkey)
                .HasMaxLength(64)
                .HasColumnName("PARAMKEY");
            entity.Property(e => e.Params)
                .HasMaxLength(4000)
                .HasColumnName("PARAMS");
        });

        modelBuilder.Entity<Kmessagescore>(entity =>
        {
            entity.HasKey(e => new { e.Threadid, e.Userid });
            entity.ToTable("KMESSAGESCORE");

            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Dirty).HasColumnName("DIRTY");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Expireson).HasColumnName("EXPIRESON");
            entity.Property(e => e.Hashtoken)
                .HasMaxLength(64)
                .HasColumnName("HASHTOKEN");
            entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");
            entity.Property(e => e.State)
                .HasColumnType("INTEGER")
                .HasColumnName("STATE");
            entity.Property(e => e.Threadid).HasColumnName("THREADID");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
            entity.Property(e => e.Unread).HasColumnName("UNREAD");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Kmessageteam>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Msgid });
            entity.ToTable("KMESSAGETEAMS");

            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Deliverystate)
                .HasColumnType("INTEGER")
                .HasColumnName("DELIVERYSTATE");
            entity.Property(e => e.Messagetype)
                .HasColumnType("INTEGER")
                .HasColumnName("MESSAGETYPE");
            entity.Property(e => e.Msgid).HasColumnName("MSGID");
            entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Kmessagethread>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KMESSAGETHREADS");

            entity.Property(e => e.Bodyid).HasColumnName("BODYID");
            entity.Property(e => e.Head)
                .HasColumnType("INTEGER")
                .HasColumnName("HEAD");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.State).HasColumnName("STATE");
        });

        modelBuilder.Entity<Kmutex>(entity =>
        {
            entity.HasKey(e => e.Section);
            entity.ToTable("KMUTEX");

            entity.Property(e => e.Section)
                .HasMaxLength(64)
                .HasColumnName("SECTION");
            entity.Property(e => e.Timeadded).HasColumnName("TIMEADDED");
        });

        modelBuilder.Entity<Kobjreftracking>(entity =>
        {
            entity.HasKey(e => e.Rowseqnum);
            entity.ToTable("KOBJREFTRACKING");

            entity.Property(e => e.Eventclassname)
                .HasMaxLength(255)
                .HasColumnName("EVENTCLASSNAME");
            entity.Property(e => e.Eventdatenum).HasColumnName("EVENTDATENUM");
            entity.Property(e => e.Eventtag)
                .HasMaxLength(255)
                .HasColumnName("EVENTTAG");
            entity.Property(e => e.Instance)
                .HasMaxLength(255)
                .HasColumnName("INSTANCE");
            entity.Property(e => e.Kosvaluename)
                .HasMaxLength(64)
                .HasColumnName("KOSVALUENAME");
            entity.Property(e => e.Maxval).HasColumnName("MAXVAL");
            entity.Property(e => e.Minval).HasColumnName("MINVAL");
            entity.Property(e => e.Profilekey)
                .HasMaxLength(255)
                .HasColumnName("PROFILEKEY");
            entity.Property(e => e.Reftype)
                .HasMaxLength(64)
                .HasColumnName("REFTYPE");
            entity.Property(e => e.Rowseqnum).HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Threadindex).HasColumnName("THREADINDEX");
            entity.Property(e => e.Totalcount).HasColumnName("TOTALCOUNT");
            entity.Property(e => e.Totalval).HasColumnName("TOTALVAL");
        });

        modelBuilder.Entity<Ksecret>(entity =>
        {
            entity.HasKey(e => new { e.Section, e.Keyword });
            entity.ToTable("KSECRETS");

            entity.Property(e => e.Keyword)
                .HasMaxLength(128)
                .HasColumnName("KEYWORD");
            entity.Property(e => e.Section)
                .HasMaxLength(128)
                .HasColumnName("SECTION");
            entity.Property(e => e.Value)
                .HasColumnType("NCLOB")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Kstate>(entity =>
        {
            entity.HasKey(e => e.Stateid);
            entity.ToTable("KSTATE");

            entity.Property(e => e.Stateid).HasColumnName("STATEID");
            entity.Property(e => e.Statenum).HasColumnName("STATENUM");
            entity.Property(e => e.Stateusernum).HasColumnName("STATEUSERNUM");
        });

        modelBuilder.Entity<Ksystemhealthresult>(entity =>
        {
            entity.HasKey(e => e.Rowidnum);
            entity.ToTable("KSYSTEMHEALTHRESULTS");

            entity.Property(e => e.Duration).HasColumnName("DURATION");
            entity.Property(e => e.Instance)
                .HasMaxLength(255)
                .HasColumnName("INSTANCE");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Operator)
                .HasMaxLength(255)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.Profilekey)
                .HasMaxLength(255)
                .HasColumnName("PROFILEKEY");
            entity.Property(e => e.Rowidnum).HasColumnName("ROWIDNUM");
            entity.Property(e => e.State)
                .HasColumnType("INTEGER")
                .HasColumnName("STATE");
            entity.Property(e => e.Subsystemkey)
                .HasMaxLength(255)
                .HasColumnName("SUBSYSTEMKEY");
            entity.Property(e => e.Testkey)
                .HasMaxLength(255)
                .HasColumnName("TESTKEY");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
        });

        modelBuilder.Entity<Kuaf>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.Spaceid, e.Deleted });
            entity.ToTable("KUAF");

            entity.Property(e => e.Birthday).HasColumnName("BIRTHDAY");
            entity.Property(e => e.Cellularphone)
                .HasMaxLength(64)
                .HasColumnName("CELLULARPHONE");
            entity.Property(e => e.Contact)
                .HasMaxLength(128)
                .HasColumnName("CONTACT");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Favorites1)
                .HasMaxLength(255)
                .HasColumnName("FAVORITES1");
            entity.Property(e => e.Favorites2)
                .HasMaxLength(255)
                .HasColumnName("FAVORITES2");
            entity.Property(e => e.Favorites3)
                .HasMaxLength(255)
                .HasColumnName("FAVORITES3");
            entity.Property(e => e.Fax)
                .HasMaxLength(64)
                .HasColumnName("FAX");
            entity.Property(e => e.Firstname)
                .HasMaxLength(64)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Gender).HasColumnName("GENDER");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Homeaddress1)
                .HasMaxLength(255)
                .HasColumnName("HOMEADDRESS1");
            entity.Property(e => e.Homeaddress2)
                .HasMaxLength(255)
                .HasColumnName("HOMEADDRESS2");
            entity.Property(e => e.Homefax)
                .HasMaxLength(64)
                .HasColumnName("HOMEFAX");
            entity.Property(e => e.Homepage)
                .HasMaxLength(255)
                .HasColumnName("HOMEPAGE");
            entity.Property(e => e.Homephone)
                .HasMaxLength(64)
                .HasColumnName("HOMEPHONE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Interests)
                .HasMaxLength(4000)
                .HasColumnName("INTERESTS");
            entity.Property(e => e.Lastname)
                .HasMaxLength(64)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Leaderid).HasColumnName("LEADERID");
            entity.Property(e => e.Mailaddress)
                .HasMaxLength(255)
                .HasColumnName("MAILADDRESS");
            entity.Property(e => e.Middlename)
                .HasMaxLength(32)
                .HasColumnName("MIDDLENAME");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Officelocation)
                .HasMaxLength(255)
                .HasColumnName("OFFICELOCATION");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Pager)
                .HasMaxLength(64)
                .HasColumnName("PAGER");
            entity.Property(e => e.Personalemail)
                .HasMaxLength(255)
                .HasColumnName("PERSONALEMAIL");
            entity.Property(e => e.Photoid).HasColumnName("PHOTOID");
            entity.Property(e => e.Pwdexpiredate).HasColumnName("PWDEXPIREDATE");
            entity.Property(e => e.Pwdexpiremode)
                .HasColumnType("INTEGER")
                .HasColumnName("PWDEXPIREMODE");
            entity.Property(e => e.Settingsnum).HasColumnName("SETTINGSNUM");
            entity.Property(e => e.Spaceid).HasColumnName("SPACEID");
            entity.Property(e => e.Timezone).HasColumnName("TIMEZONE");
            entity.Property(e => e.Title)
                .HasMaxLength(64)
                .HasColumnName("TITLE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.Userdata)
                .HasMaxLength(4000)
                .HasColumnName("USERDATA");
            entity.Property(e => e.Userprivileges)
                .HasColumnType("INTEGER")
                .HasColumnName("USERPRIVILEGES");
            entity.Property(e => e.Userpwd)
                .HasMaxLength(255)
                .HasColumnName("USERPWD");
        });

        modelBuilder.Entity<Kuafchild>(entity =>
        {
            entity.HasKey(e => e.Childid);
            entity.ToTable("KUAFCHILDREN");

            entity.Property(e => e.Childid).HasColumnName("CHILDID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Kuafidentity>(entity =>
        {
            entity.ToTable("KUAFIDENTITY");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Display)
                .HasColumnType("NCLOB")
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Typeid).HasColumnName("TYPEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Kuafidentitytype>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("KUAFIDENTITYTYPE");

            entity.Property(e => e.Display)
                .HasColumnType("NCLOB")
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Kuafpref>(entity =>
        {
            entity.HasKey(e => new { e.Prefsid, e.Prefskeyword });
            entity.ToTable("KUAFPREFS");

            entity.Property(e => e.Prefsid).HasColumnName("PREFSID");
            entity.Property(e => e.Prefskeyword)
                .HasMaxLength(128)
                .HasColumnName("PREFSKEYWORD");
            entity.Property(e => e.Prefsvalue)
                .HasColumnType("NCLOB")
                .HasColumnName("PREFSVALUE");
        });

        modelBuilder.Entity<Kuafprivilegebasedright>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KUAFPRIVILEGEBASEDRIGHT");

            entity.Property(e => e.Maskofrequireduserprivileges).HasColumnName("MASKOFREQUIREDUSERPRIVILEGES");
            entity.Property(e => e.Rlrightid).HasColumnName("RLRIGHTID");
        });

        modelBuilder.Entity<Kuafproxy>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Proxytype });
            entity.ToTable("KUAFPROXY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Proxyid).HasColumnName("PROXYID");
            entity.Property(e => e.Proxytype).HasColumnName("PROXYTYPE");
        });

        modelBuilder.Entity<Kuafrightslist>(entity =>
        {
            entity.HasKey(e => e.Rlid);
            entity.ToTable("KUAFRIGHTSLIST");

            entity.Property(e => e.Rlid).HasColumnName("RLID");
            entity.Property(e => e.Rlproxytype).HasColumnName("RLPROXYTYPE");
            entity.Property(e => e.Rlrightid).HasColumnName("RLRIGHTID");
        });

        modelBuilder.Entity<Kuafrightslistnew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KUAFRIGHTSLISTNEW");

            entity.Property(e => e.Rlid).HasColumnName("RLID");
            entity.Property(e => e.Rlproxytype).HasColumnName("RLPROXYTYPE");
            entity.Property(e => e.Rlrightid).HasColumnName("RLRIGHTID");
        });

        modelBuilder.Entity<Kuafrightslistnewcore>(entity =>
        {
            entity.HasKey(e => new { e.Groupid, e.Rightid });
            entity.ToTable("KUAFRIGHTSLISTNEWCORE");

            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
        });

        modelBuilder.Entity<Kuafrightslistworkflow>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KUAFRIGHTSLISTWORKFLOW");

            entity.Property(e => e.Rlid).HasColumnName("RLID");
            entity.Property(e => e.Rlproxytype).HasColumnName("RLPROXYTYPE");
            entity.Property(e => e.Rlrightid).HasColumnName("RLRIGHTID");
        });

        modelBuilder.Entity<Kuafusage>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Profilekey, e.Datestamp });
            entity.ToTable("KUAFUSAGE");

            entity.Property(e => e.Accesscount)
                .HasColumnType("INTEGER")
                .HasColumnName("ACCESSCOUNT");
            entity.Property(e => e.Datestamp)
                .HasColumnType("INTEGER")
                .HasColumnName("DATESTAMP");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nonreadcount)
                .HasColumnType("INTEGER")
                .HasColumnName("NONREADCOUNT");
            entity.Property(e => e.Operationcount)
                .HasColumnType("INTEGER")
                .HasColumnName("OPERATIONCOUNT");
            entity.Property(e => e.Profilekey)
                .HasMaxLength(255)
                .HasColumnName("PROFILEKEY");
            entity.Property(e => e.Writecount)
                .HasColumnType("INTEGER")
                .HasColumnName("WRITECOUNT");
        });

        modelBuilder.Entity<Kuafusagesummary>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Datestamp });
            entity.ToTable("KUAFUSAGESUMMARY");

            entity.Property(e => e.Accesscount)
                .HasColumnType("INTEGER")
                .HasColumnName("ACCESSCOUNT");
            entity.Property(e => e.Datestamp)
                .HasColumnType("INTEGER")
                .HasColumnName("DATESTAMP");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nonreadcount)
                .HasColumnType("INTEGER")
                .HasColumnName("NONREADCOUNT");
            entity.Property(e => e.Operationcount)
                .HasColumnType("INTEGER")
                .HasColumnName("OPERATIONCOUNT");
            entity.Property(e => e.Writecount)
                .HasColumnType("INTEGER")
                .HasColumnName("WRITECOUNT");
        });

        modelBuilder.Entity<Kuafuserproxy>(entity =>
        {
            entity.HasKey(e => new { e.Proxyid, e.Targetid });
            entity.ToTable("KUAFUSERPROXIES");

            entity.Property(e => e.Fromdate).HasColumnName("FROMDATE");
            entity.Property(e => e.Proxyid).HasColumnName("PROXYID");
            entity.Property(e => e.Targetid).HasColumnName("TARGETID");
            entity.Property(e => e.Todate).HasColumnName("TODATE");
        });

        modelBuilder.Entity<Kworklist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("KWORKLIST");

            entity.Property(e => e.Data)
                .HasColumnType("NCLOB")
                .HasColumnName("DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.Rowidnum).HasColumnName("ROWIDNUM");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Kworklistcore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KWORKLISTCORE");

            entity.Property(e => e.Data)
                .HasColumnType("NCLOB")
                .HasColumnName("DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.Rowidnum).HasColumnName("ROWIDNUM");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<KysNumara>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KYS_NUMARA");

            entity.Property(e => e.Numara)
                .HasMaxLength(255)
                .HasColumnName("NUMARA");
            entity.Property(e => e.Sirket)
                .HasMaxLength(255)
                .HasColumnName("SIRKET");
            entity.Property(e => e.Tip)
                .HasMaxLength(255)
                .HasColumnName("TIP");
            entity.Property(e => e.Yil)
                .HasMaxLength(255)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<Kysa>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aksiyondokumani)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONDOKUMANI");
            entity.Property(e => e.Aksiyonkaynagi)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONKAYNAGI");
            entity.Property(e => e.Aksiyonnumarasi)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONNUMARASI");
            entity.Property(e => e.Aksiyonperiyodu)
                .HasColumnType("INTEGER")
                .HasColumnName("AKSIYONPERIYODU");
            entity.Property(e => e.Aksiyonsorumlusu).HasColumnName("AKSIYONSORUMLUSU");
            entity.Property(e => e.Aksiyonsorumlusudepartman)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONSORUMLUSUDEPARTMAN");
            entity.Property(e => e.Aksiyontarihi).HasColumnName("AKSIYONTARIHI");
            entity.Property(e => e.Aksiyonyoneticisi).HasColumnName("AKSIYONYONETICISI");
            entity.Property(e => e.Alinacakaksiyon)
                .HasColumnType("NCLOB")
                .HasColumnName("ALINACAKAKSIYON");
            entity.Property(e => e.Altaksiyonnumarasi)
                .HasMaxLength(255)
                .HasColumnName("ALTAKSIYONNUMARASI");
            entity.Property(e => e.Anagundem)
                .HasMaxLength(255)
                .HasColumnName("ANAGUNDEM");
            entity.Property(e => e.Baslatandepartman).HasColumnName("BASLATANDEPARTMAN");
            entity.Property(e => e.Baslatankullanici).HasColumnName("BASLATANKULLANICI");
            entity.Property(e => e.Bwskid)
                .HasMaxLength(255)
                .HasColumnName("BWSKID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Direktoronayi)
                .HasColumnType("INTEGER")
                .HasColumnName("DIREKTORONAYI");
            entity.Property(e => e.Dyswfid)
                .HasMaxLength(255)
                .HasColumnName("DYSWFID");
            entity.Property(e => e.Egdfwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDFWFID");
            entity.Property(e => e.Egdgsmwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDGSMWFID");
            entity.Property(e => e.Egdntwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDNTWFID");
            entity.Property(e => e.Egisgwfid)
                .HasMaxLength(255)
                .HasColumnName("EGISGWFID");
            entity.Property(e => e.Egkrywfid)
                .HasMaxLength(255)
                .HasColumnName("EGKRYWFID");
            entity.Property(e => e.Egyggwfid)
                .HasMaxLength(255)
                .HasColumnName("EGYGGWFID");
            entity.Property(e => e.Egymuywfid)
                .HasMaxLength(255)
                .HasColumnName("EGYMUYWFID");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Eskiperformer).HasColumnName("ESKIPERFORMER");
            entity.Property(e => e.Gundem)
                .HasColumnType("NCLOB")
                .HasColumnName("GUNDEM");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Ilgilisistem)
                .HasMaxLength(255)
                .HasColumnName("ILGILISISTEM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Kaynak)
                .HasMaxLength(255)
                .HasColumnName("KAYNAK");
            entity.Property(e => e.Kid)
                .HasMaxLength(255)
                .HasColumnName("KID");
            entity.Property(e => e.Kyssorumlusu).HasColumnName("KYSSORUMLUSU");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Periyodiksurecnumarasi)
                .HasMaxLength(255)
                .HasColumnName("PERIYODIKSURECNUMARASI");
            entity.Property(e => e.Periyotsuresi)
                .HasMaxLength(255)
                .HasColumnName("PERIYOTSURESI");
            entity.Property(e => e.Referansnumarasi)
                .HasMaxLength(255)
                .HasColumnName("REFERANSNUMARASI");
            entity.Property(e => e.Riskid)
                .HasMaxLength(255)
                .HasColumnName("RISKID");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Sistemsorumlusu).HasColumnName("SISTEMSORUMLUSU");
            entity.Property(e => e.Surecbaslatmatarihi).HasColumnName("SURECBASLATMATARIHI");
            entity.Property(e => e.Terminotelemenedeni)
                .HasColumnType("NCLOB")
                .HasColumnName("TERMINOTELEMENEDENI");
            entity.Property(e => e.Terminotelemetarihi).HasColumnName("TERMINOTELEMETARIHI");
            entity.Property(e => e.Termintarihi).HasColumnName("TERMINTARIHI");
            entity.Property(e => e.Urungrubu)
                .HasMaxLength(255)
                .HasColumnName("URUNGRUBU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachkid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHKID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfeklerkid)
                .HasMaxLength(255)
                .HasColumnName("WFEKLERKID");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Yapilanis)
                .HasColumnType("NCLOB")
                .HasColumnName("YAPILANIS");
            entity.Property(e => e.Yggrapordokumani)
                .HasMaxLength(255)
                .HasColumnName("YGGRAPORDOKUMANI");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
        });

        modelBuilder.Entity<KysasAksiyonkaynagibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_AKSIYONKAYNAGIBAKIM");

            entity.Property(e => e.Aksiyonkaynagi)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONKAYNAGI");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysasAksiyonsorumlusudepartmanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_AKSIYONSORUMLUSUDEPARTMANBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysasBirimbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_BIRIMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Birim)
                .HasMaxLength(255)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysasIlgilisistembakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_ILGILISISTEMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ilgilisistem)
                .HasMaxLength(255)
                .HasColumnName("ILGILISISTEM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysasKaynakbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_KAYNAKBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kaynak)
                .HasMaxLength(255)
                .HasColumnName("KAYNAK");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysasSurecsorumlularibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_SURECSORUMLULARIBAKIM");

            entity.Property(e => e.Aksiyonsorumlusu).HasColumnName("AKSIYONSORUMLUSU");
            entity.Property(e => e.Aksiyonsorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKSIYONSORUMLUSUAKTIF");
            entity.Property(e => e.Aksiyonsorumlusudepartman)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONSORUMLUSUDEPARTMAN");
            entity.Property(e => e.Aksiyonyoneticisi).HasColumnName("AKSIYONYONETICISI");
            entity.Property(e => e.Aksiyonyoneticisiaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKSIYONYONETICISIAKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Departmangrup).HasColumnName("DEPARTMANGRUP");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Ilgilibirimsorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("ILGILIBIRIMSORUMLUSUAKTIF");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Sistemsorumlusu).HasColumnName("SISTEMSORUMLUSU");
            entity.Property(e => e.Sistemsorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("SISTEMSORUMLUSUAKTIF");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Yonetimtemsilcisi).HasColumnName("YONETIMTEMSILCISI");
            entity.Property(e => e.Yonetimtemsilcisiaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("YONETIMTEMSILCISIAKTIF");
        });

        modelBuilder.Entity<KysasWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<KysasWfformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_WFFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfform)
                .HasMaxLength(255)
                .HasColumnName("WFFORM");
        });

        modelBuilder.Entity<KysasWfkararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSAS_WFKARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfkarar)
                .HasMaxLength(255)
                .HasColumnName("WFKARAR");
        });

        modelBuilder.Entity<Kysdf>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslatandepartman).HasColumnName("BASLATANDEPARTMAN");
            entity.Property(e => e.Baslatankullanici).HasColumnName("BASLATANKULLANICI");
            entity.Property(e => e.Bulgudosyaid)
                .HasMaxLength(255)
                .HasColumnName("BULGUDOSYAID");
            entity.Property(e => e.Bulgutipi)
                .HasMaxLength(255)
                .HasColumnName("BULGUTIPI");
            entity.Property(e => e.Bwskid)
                .HasMaxLength(255)
                .HasColumnName("BWSKID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetci).HasColumnName("DENETCI");
            entity.Property(e => e.Denetimbulgumaddesi)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETIMBULGUMADDESI");
            entity.Property(e => e.Denetimsurecnumarasi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMSURECNUMARASI");
            entity.Property(e => e.Denetimtipi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMTIPI");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Dfkaynagi)
                .HasMaxLength(255)
                .HasColumnName("DFKAYNAGI");
            entity.Property(e => e.Dfnumarasi)
                .HasMaxLength(255)
                .HasColumnName("DFNUMARASI");
            entity.Property(e => e.Dfsablontipi)
                .HasMaxLength(255)
                .HasColumnName("DFSABLONTIPI");
            entity.Property(e => e.Dfskid)
                .HasMaxLength(255)
                .HasColumnName("DFSKID");
            entity.Property(e => e.Dfsorumludepartmani)
                .HasMaxLength(255)
                .HasColumnName("DFSORUMLUDEPARTMANI");
            entity.Property(e => e.Dfsorumlusu).HasColumnName("DFSORUMLUSU");
            entity.Property(e => e.Dogrulamatarihi).HasColumnName("DOGRULAMATARIHI");
            entity.Property(e => e.Egaswfid)
                .HasMaxLength(255)
                .HasColumnName("EGASWFID");
            entity.Property(e => e.Egdgsmwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDGSMWFID");
            entity.Property(e => e.Egdntwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDNTWFID");
            entity.Property(e => e.Egisgwfid)
                .HasMaxLength(255)
                .HasColumnName("EGISGWFID");
            entity.Property(e => e.Egkrywfid)
                .HasMaxLength(255)
                .HasColumnName("EGKRYWFID");
            entity.Property(e => e.Egtdrmkwfid)
                .HasMaxLength(255)
                .HasColumnName("EGTDRMKWFID");
            entity.Property(e => e.Egyggwfid)
                .HasMaxLength(255)
                .HasColumnName("EGYGGWFID");
            entity.Property(e => e.Egymuywfid)
                .HasMaxLength(255)
                .HasColumnName("EGYMUYWFID");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3).HasColumnName("EKALAN3");
            entity.Property(e => e.Eskiperformer).HasColumnName("ESKIPERFORMER");
            entity.Property(e => e.Faaliyettipi)
                .HasMaxLength(255)
                .HasColumnName("FAALIYETTIPI");
            entity.Property(e => e.Girdikalitekontrolsorumlusu).HasColumnName("GIRDIKALITEKONTROLSORUMLUSU");
            entity.Property(e => e.Girdikalitemuhendisi).HasColumnName("GIRDIKALITEMUHENDISI");
            entity.Property(e => e.Hafta)
                .HasMaxLength(255)
                .HasColumnName("HAFTA");
            entity.Property(e => e.Hatakaynagibolum)
                .HasMaxLength(255)
                .HasColumnName("HATAKAYNAGIBOLUM");
            entity.Property(e => e.Hatakaynagimakineekipman)
                .HasMaxLength(255)
                .HasColumnName("HATAKAYNAGIMAKINEEKIPMAN");
            entity.Property(e => e.Hataliadet)
                .HasMaxLength(255)
                .HasColumnName("HATALIADET");
            entity.Property(e => e.Hataliparcapartino)
                .HasMaxLength(255)
                .HasColumnName("HATALIPARCAPARTINO");
            entity.Property(e => e.Hataliparcauretimtarihi).HasColumnName("HATALIPARCAURETIMTARIHI");
            entity.Property(e => e.Hataliurunuretimyeri)
                .HasMaxLength(255)
                .HasColumnName("HATALIURUNURETIMYERI");
            entity.Property(e => e.Hataninkaynaklandigioperator)
                .HasMaxLength(255)
                .HasColumnName("HATANINKAYNAKLANDIGIOPERATOR");
            entity.Property(e => e.Hatanintanimi)
                .HasMaxLength(255)
                .HasColumnName("HATANINTANIMI");
            entity.Property(e => e.Hatatespitlokasyon)
                .HasMaxLength(255)
                .HasColumnName("HATATESPITLOKASYON");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Ilgiliyonetimsistemi)
                .HasMaxLength(255)
                .HasColumnName("ILGILIYONETIMSISTEMI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Koknedenanalizdokumani)
                .HasMaxLength(255)
                .HasColumnName("KOKNEDENANALIZDOKUMANI");
            entity.Property(e => e.Koknedenanalizi)
                .HasColumnType("NCLOB")
                .HasColumnName("KOKNEDENANALIZI");
            entity.Property(e => e.Kyssorumlusu).HasColumnName("KYSSORUMLUSU");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Processmuhendisi).HasColumnName("PROCESSMUHENDISI");
            entity.Property(e => e.Referansdfnumarasi)
                .HasMaxLength(255)
                .HasColumnName("REFERANSDFNUMARASI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Sekizdanalizdokumani)
                .HasMaxLength(255)
                .HasColumnName("SEKIZDANALIZDOKUMANI");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Standartno)
                .HasMaxLength(255)
                .HasColumnName("STANDARTNO");
            entity.Property(e => e.Surecbaslatmatarihi).HasColumnName("SURECBASLATMATARIHI");
            entity.Property(e => e.Surecnumarasi)
                .HasMaxLength(255)
                .HasColumnName("SURECNUMARASI");
            entity.Property(e => e.Termintarihi).HasColumnName("TERMINTARIHI");
            entity.Property(e => e.Urunkodu)
                .HasMaxLength(255)
                .HasColumnName("URUNKODU");
            entity.Property(e => e.Uruntanimi)
                .HasMaxLength(255)
                .HasColumnName("URUNTANIMI");
            entity.Property(e => e.Uygunsuzluk)
                .HasColumnType("NCLOB")
                .HasColumnName("UYGUNSUZLUK");
            entity.Property(e => e.Uygunsuzlukturu)
                .HasMaxLength(255)
                .HasColumnName("UYGUNSUZLUKTURU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachkid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHKID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfeklerkid)
                .HasMaxLength(255)
                .HasColumnName("WFEKLERKID");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Yonetimtemsilcisorumlusu).HasColumnName("YONETIMTEMSILCISORUMLUSU");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
        });

        modelBuilder.Entity<KysdfsAksiyonkaynagibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_AKSIYONKAYNAGIBAKIM");

            entity.Property(e => e.Aksiyonkaynagi)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONKAYNAGI");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsAksiyonlartablosu>(entity =>
        {
            entity.ToTable("KYSDFS_AKSIYONLARTABLOSU");

            entity.Property(e => e.Id)
                .HasColumnType("INTEGER")
                .HasColumnName("ID");
            entity.Property(e => e.Aksiyondurumu)
                .HasColumnType("NCLOB")
                .HasColumnName("AKSIYONDURUMU");
            entity.Property(e => e.Aksiyonsorumlusu)
                .HasColumnType("NCLOB")
                .HasColumnName("AKSIYONSORUMLUSU");
            entity.Property(e => e.Aksiyonsurecdurumu)
                .HasColumnType("NCLOB")
                .HasColumnName("AKSIYONSURECDURUMU");
            entity.Property(e => e.Aksiyontipi)
                .HasColumnType("NCLOB")
                .HasColumnName("AKSIYONTIPI");
            entity.Property(e => e.Alinacakaksiyon).HasColumnName("ALINACAKAKSIYON");
            entity.Property(e => e.Departman)
                .HasColumnType("NCLOB")
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Durum)
                .HasColumnType("NCLOB")
                .HasColumnName("DURUM");
            entity.Property(e => e.Folderid)
                .HasColumnType("NCLOB")
                .HasColumnName("FOLDERID");
            entity.Property(e => e.Kapatmatarihi)
                .HasColumnType("NCLOB")
                .HasColumnName("KAPATMATARIHI");
            entity.Property(e => e.Termintarihi)
                .HasColumnType("NCLOB")
                .HasColumnName("TERMINTARIHI");
            entity.Property(e => e.Wfid)
                .HasColumnType("NCLOB")
                .HasColumnName("WFID");
            entity.Property(e => e.Yorum).HasColumnName("YORUM");
        });

        modelBuilder.Entity<KysdfsDepartmanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_DEPARTMANBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsDfkaynagibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_DFKAYNAGIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetim)
                .HasColumnType("INTEGER")
                .HasColumnName("DENETIM");
            entity.Property(e => e.Dfakistipi)
                .HasMaxLength(255)
                .HasColumnName("DFAKISTIPI");
            entity.Property(e => e.Dfkaynagi)
                .HasMaxLength(255)
                .HasColumnName("DFKAYNAGI");
            entity.Property(e => e.Giriskalite)
                .HasColumnType("INTEGER")
                .HasColumnName("GIRISKALITE");
            entity.Property(e => e.Hata)
                .HasColumnType("INTEGER")
                .HasColumnName("HATA");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsDfsablontipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_DFSABLONTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Sablondokumanadi)
                .HasMaxLength(255)
                .HasColumnName("SABLONDOKUMANADI");
            entity.Property(e => e.Sablondokumanid)
                .HasMaxLength(255)
                .HasColumnName("SABLONDOKUMANID");
            entity.Property(e => e.Sablontipi)
                .HasMaxLength(255)
                .HasColumnName("SABLONTIPI");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsDurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_DURUMBAKIM");

            entity.Property(e => e.Aksiyondurumu)
                .HasMaxLength(255)
                .HasColumnName("AKSIYONDURUMU");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsFaaliyettipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_FAALIYETTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Faaliyettipi)
                .HasMaxLength(255)
                .HasColumnName("FAALIYETTIPI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsGecikengorevbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_GECIKENGOREVBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bilgilendirmemailadres)
                .HasMaxLength(255)
                .HasColumnName("BILGILENDIRMEMAILADRES");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gorevbeklemesuresi)
                .HasMaxLength(255)
                .HasColumnName("GOREVBEKLEMESURESI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
        });

        modelBuilder.Entity<KysdfsHatabolumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_HATABOLUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bolum)
                .HasMaxLength(255)
                .HasColumnName("BOLUM");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsHatatespitlokasyonbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_HATATESPITLOKASYONBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Lokasyon)
                .HasMaxLength(255)
                .HasColumnName("LOKASYON");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsIlgiliyonetimsistemibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_ILGILIYONETIMSISTEMIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ilgiliyonetimsistemi)
                .HasMaxLength(255)
                .HasColumnName("ILGILIYONETIMSISTEMI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sistemsorumlusu).HasColumnName("SISTEMSORUMLUSU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsSistemsorumlularibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_SISTEMSORUMLULARIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dfkaynagi)
                .HasMaxLength(255)
                .HasColumnName("DFKAYNAGI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sistemsorumlusu).HasColumnName("SISTEMSORUMLUSU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsSurecsorumlularibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_SURECSORUMLULARIBAKIM");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Dfkaynagi)
                .HasMaxLength(255)
                .HasColumnName("DFKAYNAGI");
            entity.Property(e => e.Girdikalitemuhendisi).HasColumnName("GIRDIKALITEMUHENDISI");
            entity.Property(e => e.Girdikalitemuhendisiaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("GIRDIKALITEMUHENDISIAKTIF");
            entity.Property(e => e.Gkksorumlusu).HasColumnName("GKKSORUMLUSU");
            entity.Property(e => e.Gkksorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("GKKSORUMLUSUAKTIF");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kyssorumlusu).HasColumnName("KYSSORUMLUSU");
            entity.Property(e => e.Kyssorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("KYSSORUMLUSUAKTIF");
            entity.Property(e => e.Processmuhendisi).HasColumnName("PROCESSMUHENDISI");
            entity.Property(e => e.Processmuhendisiaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("PROCESSMUHENDISIAKTIF");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsUygunsuzlukturubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_UYGUNSUZLUKTURUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Uygunsuzlukturu)
                .HasMaxLength(255)
                .HasColumnName("UYGUNSUZLUKTURU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdfsWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<KysdfsWfformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_WFFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfform)
                .HasMaxLength(255)
                .HasColumnName("WFFORM");
        });

        modelBuilder.Entity<KysdfsWfkararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDFS_WFKARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfkarar)
                .HasMaxLength(255)
                .HasColumnName("WFKARAR");
        });

        modelBuilder.Entity<Kysdnt>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslatandepartman).HasColumnName("BASLATANDEPARTMAN");
            entity.Property(e => e.Baslatankullanici).HasColumnName("BASLATANKULLANICI");
            entity.Property(e => e.Bulgusayisi)
                .HasMaxLength(255)
                .HasColumnName("BULGUSAYISI");
            entity.Property(e => e.Bwskid)
                .HasMaxLength(255)
                .HasColumnName("BWSKID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetimdepartmansorumlusu).HasColumnName("DENETIMDEPARTMANSORUMLUSU");
            entity.Property(e => e.Denetimekibi)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETIMEKIBI");
            entity.Property(e => e.Denetimekibinonotx)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETIMEKIBINONOTX");
            entity.Property(e => e.Denetimhedefi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMHEDEFI");
            entity.Property(e => e.Denetimiplanlayandepartman).HasColumnName("DENETIMIPLANLAYANDEPARTMAN");
            entity.Property(e => e.Denetimiplanlayankullanici).HasColumnName("DENETIMIPLANLAYANKULLANICI");
            entity.Property(e => e.Denetimkonusu)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETIMKONUSU");
            entity.Property(e => e.Denetimnumarasi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMNUMARASI");
            entity.Property(e => e.Denetimplaniertelemetarihi).HasColumnName("DENETIMPLANIERTELEMETARIHI");
            entity.Property(e => e.Denetimplanlanmatarihi).HasColumnName("DENETIMPLANLANMATARIHI");
            entity.Property(e => e.Denetimplanlistesi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMPLANLISTESI");
            entity.Property(e => e.Denetimpuan)
                .HasMaxLength(255)
                .HasColumnName("DENETIMPUAN");
            entity.Property(e => e.Denetimsaati)
                .HasMaxLength(255)
                .HasColumnName("DENETIMSAATI");
            entity.Property(e => e.Denetimsablondokumani)
                .HasMaxLength(255)
                .HasColumnName("DENETIMSABLONDOKUMANI");
            entity.Property(e => e.Denetimsonucu)
                .HasMaxLength(255)
                .HasColumnName("DENETIMSONUCU");
            entity.Property(e => e.Denetimsorusayisi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMSORUSAYISI");
            entity.Property(e => e.Denetimtarihi).HasColumnName("DENETIMTARIHI");
            entity.Property(e => e.Denetimtipi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMTIPI");
            entity.Property(e => e.Denetimturu)
                .HasMaxLength(255)
                .HasColumnName("DENETIMTURU");
            entity.Property(e => e.Denetlemesureci)
                .HasMaxLength(255)
                .HasColumnName("DENETLEMESURECI");
            entity.Property(e => e.Denetlenecekdepartman)
                .HasMaxLength(255)
                .HasColumnName("DENETLENECEKDEPARTMAN");
            entity.Property(e => e.Denetlenecektedarikci)
                .HasMaxLength(255)
                .HasColumnName("DENETLENECEKTEDARIKCI");
            entity.Property(e => e.Denetlenecekurungrubu)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETLENECEKURUNGRUBU");
            entity.Property(e => e.Disdenetci)
                .HasMaxLength(255)
                .HasColumnName("DISDENETCI");
            entity.Property(e => e.Disdenetimtipi)
                .HasMaxLength(255)
                .HasColumnName("DISDENETIMTIPI");
            entity.Property(e => e.Dokid)
                .HasMaxLength(255)
                .HasColumnName("DOKID");
            entity.Property(e => e.Egaswfid)
                .HasMaxLength(255)
                .HasColumnName("EGASWFID");
            entity.Property(e => e.Egdfwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDFWFID");
            entity.Property(e => e.Egdgsmwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDGSMWFID");
            entity.Property(e => e.Egisgwfid)
                .HasMaxLength(255)
                .HasColumnName("EGISGWFID");
            entity.Property(e => e.Egkrywfid)
                .HasMaxLength(255)
                .HasColumnName("EGKRYWFID");
            entity.Property(e => e.Egyggwfid)
                .HasMaxLength(255)
                .HasColumnName("EGYGGWFID");
            entity.Property(e => e.Egymuywfid)
                .HasMaxLength(255)
                .HasColumnName("EGYMUYWFID");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3).HasColumnName("EKALAN3");
            entity.Property(e => e.Ekiplideri).HasColumnName("EKIPLIDERI");
            entity.Property(e => e.Eskiperformer).HasColumnName("ESKIPERFORMER");
            entity.Property(e => e.Gerceklestirmetarihi).HasColumnName("GERCEKLESTIRMETARIHI");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Kid)
                .HasMaxLength(255)
                .HasColumnName("KID");
            entity.Property(e => e.Kysmuduru).HasColumnName("KYSMUDURU");
            entity.Property(e => e.Kyssorumlusu).HasColumnName("KYSSORUMLUSU");
            entity.Property(e => e.Musteriadi)
                .HasMaxLength(255)
                .HasColumnName("MUSTERIADI");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Periyot)
                .HasMaxLength(255)
                .HasColumnName("PERIYOT");
            entity.Property(e => e.Planbaslangictarihi)
                .HasMaxLength(255)
                .HasColumnName("PLANBASLANGICTARIHI");
            entity.Property(e => e.Planbitistarihi)
                .HasMaxLength(255)
                .HasColumnName("PLANBITISTARIHI");
            entity.Property(e => e.Planertele)
                .HasColumnType("INTEGER")
                .HasColumnName("PLANERTELE");
            entity.Property(e => e.Planno)
                .HasMaxLength(255)
                .HasColumnName("PLANNO");
            entity.Property(e => e.Plantanimi)
                .HasMaxLength(255)
                .HasColumnName("PLANTANIMI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Sorulistesitipi)
                .HasMaxLength(255)
                .HasColumnName("SORULISTESITIPI");
            entity.Property(e => e.Surecbaslatmatarihi).HasColumnName("SURECBASLATMATARIHI");
            entity.Property(e => e.Toplamdenetimsuresi)
                .HasMaxLength(255)
                .HasColumnName("TOPLAMDENETIMSURESI");
            entity.Property(e => e.Urunkodu)
                .HasColumnType("NCLOB")
                .HasColumnName("URUNKODU");
            entity.Property(e => e.Uruntanimi)
                .HasColumnType("NCLOB")
                .HasColumnName("URUNTANIMI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachkid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHKID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfeklerkid)
                .HasMaxLength(255)
                .HasColumnName("WFEKLERKID");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Yonetimtemsilcisorumlusu).HasColumnName("YONETIMTEMSILCISORUMLUSU");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
        });

        modelBuilder.Entity<KysdntBulgulartablosu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KYSDNT_BULGULARTABLOSU");

            entity.Property(e => e.Bulgutipi)
                .HasMaxLength(50)
                .HasColumnName("BULGUTIPI");
            entity.Property(e => e.Dosya)
                .HasMaxLength(50)
                .HasColumnName("DOSYA");
            entity.Property(e => e.Dosyaid)
                .HasMaxLength(50)
                .HasColumnName("DOSYAID");
            entity.Property(e => e.Madde).HasColumnName("MADDE");
            entity.Property(e => e.Puan)
                .HasMaxLength(20)
                .HasColumnName("PUAN");
            entity.Property(e => e.Standartno)
                .HasMaxLength(50)
                .HasColumnName("STANDARTNO");
            entity.Property(e => e.Uygunsuzluktanimi).HasColumnName("UYGUNSUZLUKTANIMI");
            entity.Property(e => e.Wfid)
                .HasMaxLength(50)
                .HasColumnName("WFID");
        });

        modelBuilder.Entity<KysdntBulgutipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_BULGUTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bulgutipi)
                .HasMaxLength(255)
                .HasColumnName("BULGUTIPI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntDenetimplanlari>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_DENETIMPLANLARI");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetci).HasColumnName("DENETCI");
            entity.Property(e => e.Denetcibilgilendirmesuresi)
                .HasMaxLength(255)
                .HasColumnName("DENETCIBILGILENDIRMESURESI");
            entity.Property(e => e.Denetimekibi)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETIMEKIBI");
            entity.Property(e => e.Denetimekibinonotx)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETIMEKIBINONOTX");
            entity.Property(e => e.Denetimhedefi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMHEDEFI");
            entity.Property(e => e.Denetimiplanlayandepartman).HasColumnName("DENETIMIPLANLAYANDEPARTMAN");
            entity.Property(e => e.Denetimiplanlayankullanici).HasColumnName("DENETIMIPLANLAYANKULLANICI");
            entity.Property(e => e.Denetimsablondokumani)
                .HasMaxLength(255)
                .HasColumnName("DENETIMSABLONDOKUMANI");
            entity.Property(e => e.Denetimtipi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMTIPI");
            entity.Property(e => e.Denetimturu)
                .HasMaxLength(255)
                .HasColumnName("DENETIMTURU");
            entity.Property(e => e.Denetlenecekdepartman)
                .HasMaxLength(255)
                .HasColumnName("DENETLENECEKDEPARTMAN");
            entity.Property(e => e.Denetlenecekdepartmansorumlusu).HasColumnName("DENETLENECEKDEPARTMANSORUMLUSU");
            entity.Property(e => e.Denetlenecekurungrubu)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETLENECEKURUNGRUBU");
            entity.Property(e => e.Denetlenenbilgilendirmesuresi)
                .HasMaxLength(255)
                .HasColumnName("DENETLENENBILGILENDIRMESURESI");
            entity.Property(e => e.Disdenetci)
                .HasMaxLength(255)
                .HasColumnName("DISDENETCI");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3).HasColumnName("EKALAN3");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kysmuduru).HasColumnName("KYSMUDURU");
            entity.Property(e => e.Periyot)
                .HasMaxLength(255)
                .HasColumnName("PERIYOT");
            entity.Property(e => e.Periyotgun)
                .HasMaxLength(255)
                .HasColumnName("PERIYOTGUN");
            entity.Property(e => e.Planbaslangictarihi).HasColumnName("PLANBASLANGICTARIHI");
            entity.Property(e => e.Planbilgilendirilecekuyeler)
                .HasColumnType("NCLOB")
                .HasColumnName("PLANBILGILENDIRILECEKUYELER");
            entity.Property(e => e.Planbitistarihi).HasColumnName("PLANBITISTARIHI");
            entity.Property(e => e.Plandurumu)
                .HasMaxLength(255)
                .HasColumnName("PLANDURUMU");
            entity.Property(e => e.Planno)
                .HasMaxLength(255)
                .HasColumnName("PLANNO");
            entity.Property(e => e.Plantanimi)
                .HasMaxLength(255)
                .HasColumnName("PLANTANIMI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Tedarikciadi)
                .HasMaxLength(255)
                .HasColumnName("TEDARIKCIADI");
            entity.Property(e => e.Toplamdenetimsuresi)
                .HasMaxLength(255)
                .HasColumnName("TOPLAMDENETIMSURESI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntDenetimrolbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_DENETIMROLBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kysmuduru).HasColumnName("KYSMUDURU");
            entity.Property(e => e.Kysmudurvekalet).HasColumnName("KYSMUDURVEKALET");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Vekaletaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("VEKALETAKTIF");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntDenetimverisibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_DENETIMVERISIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetimhedef)
                .HasColumnType("INTEGER")
                .HasColumnName("DENETIMHEDEF");
            entity.Property(e => e.Denetimtipi)
                .HasColumnType("INTEGER")
                .HasColumnName("DENETIMTIPI");
            entity.Property(e => e.Denetimturu)
                .HasColumnType("INTEGER")
                .HasColumnName("DENETIMTURU");
            entity.Property(e => e.Denetimverisi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMVERISI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntDenetlenecekdepartmanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_DENETLENECEKDEPARTMANBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetlenecekdepartman)
                .HasMaxLength(255)
                .HasColumnName("DENETLENECEKDEPARTMAN");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntDisdenetimtipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_DISDENETIMTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Disdenetimtipi)
                .HasMaxLength(255)
                .HasColumnName("DISDENETIMTIPI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntDurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_DURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetdurum)
                .HasMaxLength(255)
                .HasColumnName("DENETDURUM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntGecikengorevbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_GECIKENGOREVBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bilgilendirmemailadres)
                .HasMaxLength(255)
                .HasColumnName("BILGILENDIRMEMAILADRES");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gorevbeklemesuresi)
                .HasMaxLength(255)
                .HasColumnName("GOREVBEKLEMESURESI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
        });

        modelBuilder.Entity<KysdntPlandurumubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_PLANDURUMUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Plandurumu)
                .HasMaxLength(255)
                .HasColumnName("PLANDURUMU");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntSablonbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_SABLONBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetimtipi)
                .HasMaxLength(255)
                .HasColumnName("DENETIMTIPI");
            entity.Property(e => e.Denetimturu)
                .HasMaxLength(255)
                .HasColumnName("DENETIMTURU");
            entity.Property(e => e.Dntsablondokumanadi)
                .HasMaxLength(255)
                .HasColumnName("DNTSABLONDOKUMANADI");
            entity.Property(e => e.Dntsablondokumanid)
                .HasMaxLength(255)
                .HasColumnName("DNTSABLONDOKUMANID");
            entity.Property(e => e.Dntsablonkisaltmasi)
                .HasMaxLength(255)
                .HasColumnName("DNTSABLONKISALTMASI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntSorulistesibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_SORULISTESIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetimsorusu)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETIMSORUSU");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.No)
                .HasMaxLength(255)
                .HasColumnName("NO");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Soruaciklamasi)
                .HasColumnType("NCLOB")
                .HasColumnName("SORUACIKLAMASI");
            entity.Property(e => e.Sorulistesitipi)
                .HasMaxLength(255)
                .HasColumnName("SORULISTESITIPI");
            entity.Property(e => e.Standartadi1)
                .HasMaxLength(255)
                .HasColumnName("STANDARTADI1");
            entity.Property(e => e.Standartadi1baglam)
                .HasMaxLength(255)
                .HasColumnName("STANDARTADI1BAGLAM");
            entity.Property(e => e.Standartadi2)
                .HasMaxLength(255)
                .HasColumnName("STANDARTADI2");
            entity.Property(e => e.Standartadi2baglam)
                .HasMaxLength(255)
                .HasColumnName("STANDARTADI2BAGLAM");
            entity.Property(e => e.Standartadi3)
                .HasMaxLength(255)
                .HasColumnName("STANDARTADI3");
            entity.Property(e => e.Standartadi3baglam)
                .HasMaxLength(255)
                .HasColumnName("STANDARTADI3BAGLAM");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntSorulistesitablosu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KYSDNT_SORULISTESITABLOSU");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bulguaciklamasi)
                .HasColumnType("NCLOB")
                .HasColumnName("BULGUACIKLAMASI");
            entity.Property(e => e.Denetcisorusu)
                .HasColumnType("NCLOB")
                .HasColumnName("DENETCISORUSU");
            entity.Property(e => e.Dosya)
                .HasColumnType("NCLOB")
                .HasColumnName("DOSYA");
            entity.Property(e => e.Dosyaid)
                .HasColumnType("NCLOB")
                .HasColumnName("DOSYAID");
            entity.Property(e => e.Durum)
                .HasColumnType("NCLOB")
                .HasColumnName("DURUM");
            entity.Property(e => e.No)
                .HasColumnType("NCLOB")
                .HasColumnName("NO");
            entity.Property(e => e.Sorulistesi)
                .HasColumnType("NCLOB")
                .HasColumnName("SORULISTESI");
            entity.Property(e => e.Standartno)
                .HasColumnType("NCLOB")
                .HasColumnName("STANDARTNO");
            entity.Property(e => e.Standartno2)
                .HasColumnType("NCLOB")
                .HasColumnName("STANDARTNO2");
            entity.Property(e => e.Standartno3)
                .HasColumnType("NCLOB")
                .HasColumnName("STANDARTNO3");
            entity.Property(e => e.Tespittipi)
                .HasColumnType("NCLOB")
                .HasColumnName("TESPITTIPI");
            entity.Property(e => e.Wfid)
                .HasColumnType("NCLOB")
                .HasColumnName("WFID");
        });

        modelBuilder.Entity<KysdntSorulistesitipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_SORULISTESITIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sorulistesitipi)
                .HasMaxLength(255)
                .HasColumnName("SORULISTESITIPI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntStandartnobakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_STANDARTNOBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Standartno)
                .HasMaxLength(255)
                .HasColumnName("STANDARTNO");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntSurecsorumlularibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_SURECSORUMLULARIBAKIM");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Denetimdepartmansorumlusu).HasColumnName("DENETIMDEPARTMANSORUMLUSU");
            entity.Property(e => e.Denetimdepartmansorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("DENETIMDEPARTMANSORUMLUSUAKTIF");
            entity.Property(e => e.Denetlenecekdepartman)
                .HasMaxLength(255)
                .HasColumnName("DENETLENECEKDEPARTMAN");
            entity.Property(e => e.Denetlenecekdepartmanaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("DENETLENECEKDEPARTMANAKTIF");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Departmangrup).HasColumnName("DEPARTMANGRUP");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Ilgilibirimsorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("ILGILIBIRIMSORUMLUSUAKTIF");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kyssorumlusu).HasColumnName("KYSSORUMLUSU");
            entity.Property(e => e.Kyssorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("KYSSORUMLUSUAKTIF");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Yonetimtemsilcisorumlusu).HasColumnName("YONETIMTEMSILCISORUMLUSU");
            entity.Property(e => e.Yonetimtemsilcisorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("YONETIMTEMSILCISORUMLUSUAKTIF");
        });

        modelBuilder.Entity<KysdntTespittipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_TESPITTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Tespittipi)
                .HasMaxLength(255)
                .HasColumnName("TESPITTIPI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdntWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<KysdntWfformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_WFFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfform)
                .HasMaxLength(255)
                .HasColumnName("WFFORM");
        });

        modelBuilder.Entity<KysdntWfkararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDNT_WFKARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfkarar)
                .HasMaxLength(255)
                .HasColumnName("WFKARAR");
        });

        modelBuilder.Entity<Kysdy>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Backupid)
                .HasMaxLength(255)
                .HasColumnName("BACKUPID");
            entity.Property(e => e.Baslatandepartman).HasColumnName("BASLATANDEPARTMAN");
            entity.Property(e => e.Baslatankullanici).HasColumnName("BASLATANKULLANICI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departmankodu)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMANKODU");
            entity.Property(e => e.Dokumanonayci).HasColumnName("DOKUMANONAYCI");
            entity.Property(e => e.Dokumansorumlusu).HasColumnName("DOKUMANSORUMLUSU");
            entity.Property(e => e.Dokumantipi)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANTIPI");
            entity.Property(e => e.Dysbelgenumarasi)
                .HasMaxLength(255)
                .HasColumnName("DYSBELGENUMARASI");
            entity.Property(e => e.Dysdokid)
                .HasMaxLength(255)
                .HasColumnName("DYSDOKID");
            entity.Property(e => e.Dysdokumannumarasi)
                .HasMaxLength(255)
                .HasColumnName("DYSDOKUMANNUMARASI");
            entity.Property(e => e.Dysekid)
                .HasMaxLength(255)
                .HasColumnName("DYSEKID");
            entity.Property(e => e.Dyskid)
                .HasMaxLength(255)
                .HasColumnName("DYSKID");
            entity.Property(e => e.Dyssablonid)
                .HasMaxLength(255)
                .HasColumnName("DYSSABLONID");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekipmankodu)
                .HasMaxLength(255)
                .HasColumnName("EKIPMANKODU");
            entity.Property(e => e.Eskiperformer).HasColumnName("ESKIPERFORMER");
            entity.Property(e => e.Gecerliliktarihi).HasColumnName("GECERLILIKTARIHI");
            entity.Property(e => e.Gizlilikseviyesi)
                .HasMaxLength(255)
                .HasColumnName("GIZLILIKSEVIYESI");
            entity.Property(e => e.Ilgilibirim)
                .HasMaxLength(255)
                .HasColumnName("ILGILIBIRIM");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Ilgilidisiplin)
                .HasMaxLength(255)
                .HasColumnName("ILGILIDISIPLIN");
            entity.Property(e => e.Ilkyayintarihi).HasColumnName("ILKYAYINTARIHI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Konu)
                .HasMaxLength(255)
                .HasColumnName("KONU");
            entity.Property(e => e.Kyssorumlusu).HasColumnName("KYSSORUMLUSU");
            entity.Property(e => e.Malzemekodu)
                .HasMaxLength(255)
                .HasColumnName("MALZEMEKODU");
            entity.Property(e => e.Malzemekoducoklu)
                .HasColumnType("NCLOB")
                .HasColumnName("MALZEMEKODUCOKLU");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Revizyonnumarasi)
                .HasMaxLength(255)
                .HasColumnName("REVIZYONNUMARASI");
            entity.Property(e => e.Revizyontarihi).HasColumnName("REVIZYONTARIHI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Sablonrevizyonnumarasi)
                .HasMaxLength(255)
                .HasColumnName("SABLONREVIZYONNUMARASI");
            entity.Property(e => e.Sablonrevizyontarihi).HasColumnName("SABLONREVIZYONTARIHI");
            entity.Property(e => e.Sablonsurecnumarasi)
                .HasMaxLength(255)
                .HasColumnName("SABLONSURECNUMARASI");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Sononayci).HasColumnName("SONONAYCI");
            entity.Property(e => e.Surecbaslatmatarihi).HasColumnName("SURECBASLATMATARIHI");
            entity.Property(e => e.Surectipi)
                .HasMaxLength(255)
                .HasColumnName("SURECTIPI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachkid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHKID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfeklerkid)
                .HasMaxLength(255)
                .HasColumnName("WFEKLERKID");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Ydysdokid)
                .HasMaxLength(255)
                .HasColumnName("YDYSDOKID");
            entity.Property(e => e.Yoneticimailadres)
                .HasMaxLength(255)
                .HasColumnName("YONETICIMAILADRES");
            entity.Property(e => e.Yonetimsistemi)
                .HasMaxLength(255)
                .HasColumnName("YONETIMSISTEMI");
            entity.Property(e => e.Yonetimsistemiaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("YONETIMSISTEMIAKTIF");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
        });

        modelBuilder.Entity<KysdysCatgozdengecirmedurumu>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_CATGOZDENGECIRMEDURUMU");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Durum)
                .HasMaxLength(255)
                .HasColumnName("DURUM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdysCatkullanimdurumubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_CATKULLANIMDURUMUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kullanimdurumu)
                .HasMaxLength(255)
                .HasColumnName("KULLANIMDURUMU");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdysDepartmanbirimbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_DEPARTMANBIRIMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Birim).HasColumnName("BIRIM");
            entity.Property(e => e.Birimadi)
                .HasMaxLength(255)
                .HasColumnName("BIRIMADI");
            entity.Property(e => e.Birimaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("BIRIMAKTIF");
            entity.Property(e => e.Birimkodu)
                .HasMaxLength(255)
                .HasColumnName("BIRIMKODU");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman).HasColumnName("DEPARTMAN");
            entity.Property(e => e.Departmanadi)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMANADI");
            entity.Property(e => e.Departmankodu)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMANKODU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdysGecikengorevbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_GECIKENGOREVBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bilgilendirmemailadres)
                .HasMaxLength(255)
                .HasColumnName("BILGILENDIRMEMAILADRES");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gorevbeklemesuresi)
                .HasMaxLength(255)
                .HasColumnName("GOREVBEKLEMESURESI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
        });

        modelBuilder.Entity<KysdysGizlilikseviyesibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_GIZLILIKSEVIYESIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gizlilikseviyesi)
                .HasMaxLength(255)
                .HasColumnName("GIZLILIKSEVIYESI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdysGozdengecirmeperiyotbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_GOZDENGECIRMEPERIYOTBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dokumangrubu)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANGRUBU");
            entity.Property(e => e.Dokumantipi)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANTIPI");
            entity.Property(e => e.GozperiyotAy)
                .HasMaxLength(255)
                .HasColumnName("GOZPERIYOT_AY");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.PeriyotAy)
                .HasMaxLength(255)
                .HasColumnName("PERIYOT_AY");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sorumlu).HasColumnName("SORUMLU");
            entity.Property(e => e.Sorumluyoneticisi)
                .HasMaxLength(255)
                .HasColumnName("SORUMLUYONETICISI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdysOnaycilarbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_ONAYCILARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman).HasColumnName("DEPARTMAN");
            entity.Property(e => e.Departmanbirimi).HasColumnName("DEPARTMANBIRIMI");
            entity.Property(e => e.Dokumantipi)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANTIPI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kontroleden).HasColumnName("KONTROLEDEN");
            entity.Property(e => e.Mailadres)
                .HasMaxLength(255)
                .HasColumnName("MAILADRES");
            entity.Property(e => e.Mailaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("MAILAKTIF");
            entity.Property(e => e.Onayci1).HasColumnName("ONAYCI1");
            entity.Property(e => e.Onayci2).HasColumnName("ONAYCI2");
            entity.Property(e => e.Onayci3).HasColumnName("ONAYCI3");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Surectipi)
                .HasMaxLength(255)
                .HasColumnName("SURECTIPI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdysSablonbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_SABLONBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dokumangrubu)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANGRUBU");
            entity.Property(e => e.Dyssablondokumanadi)
                .HasMaxLength(255)
                .HasColumnName("DYSSABLONDOKUMANADI");
            entity.Property(e => e.Dyssablondokumanid)
                .HasMaxLength(255)
                .HasColumnName("DYSSABLONDOKUMANID");
            entity.Property(e => e.Dyssablonkisaltmasi)
                .HasMaxLength(255)
                .HasColumnName("DYSSABLONKISALTMASI");
            entity.Property(e => e.Dyssablontipi)
                .HasMaxLength(255)
                .HasColumnName("DYSSABLONTIPI");
            entity.Property(e => e.Ekipmankoduaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("EKIPMANKODUAKTIF");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Ortaksablon)
                .HasColumnType("INTEGER")
                .HasColumnName("ORTAKSABLON");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Urunkoduaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("URUNKODUAKTIF");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Yonetimsistemi)
                .HasColumnType("INTEGER")
                .HasColumnName("YONETIMSISTEMI");
        });

        modelBuilder.Entity<KysdysSurectipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_SURECTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Surectipi)
                .HasMaxLength(255)
                .HasColumnName("SURECTIPI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysdysWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<KysdysWfformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_WFFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfform)
                .HasMaxLength(255)
                .HasColumnName("WFFORM");
        });

        modelBuilder.Entity<KysdysWfkararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_WFKARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfkarar)
                .HasMaxLength(255)
                .HasColumnName("WFKARAR");
        });

        modelBuilder.Entity<KysdysYonetimsistemibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSDYS_YONETIMSISTEMIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Yonetimsistemi)
                .HasMaxLength(255)
                .HasColumnName("YONETIMSISTEMI");
        });

        modelBuilder.Entity<Kyskry>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslatandepartman).HasColumnName("BASLATANDEPARTMAN");
            entity.Property(e => e.Baslatankullanici).HasColumnName("BASLATANKULLANICI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Departmankullanicilari).HasColumnName("DEPARTMANKULLANICILARI");
            entity.Property(e => e.Departmansorumlusu).HasColumnName("DEPARTMANSORUMLUSU");
            entity.Property(e => e.Dokid)
                .HasMaxLength(255)
                .HasColumnName("DOKID");
            entity.Property(e => e.Egaswfid)
                .HasMaxLength(255)
                .HasColumnName("EGASWFID");
            entity.Property(e => e.Egdfwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDFWFID");
            entity.Property(e => e.Egdgsmwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDGSMWFID");
            entity.Property(e => e.Egisgwfid)
                .HasMaxLength(255)
                .HasColumnName("EGISGWFID");
            entity.Property(e => e.Egkrywfid)
                .HasMaxLength(255)
                .HasColumnName("EGKRYWFID");
            entity.Property(e => e.Egyggwfid)
                .HasMaxLength(255)
                .HasColumnName("EGYGGWFID");
            entity.Property(e => e.Egymuywfid)
                .HasMaxLength(255)
                .HasColumnName("EGYMUYWFID");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3).HasColumnName("EKALAN3");
            entity.Property(e => e.Eskiperformer).HasColumnName("ESKIPERFORMER");
            entity.Property(e => e.Gozdengecirmetarihi).HasColumnName("GOZDENGECIRMETARIHI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Kid)
                .HasMaxLength(255)
                .HasColumnName("KID");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Periyot)
                .HasMaxLength(255)
                .HasColumnName("PERIYOT");
            entity.Property(e => e.Planlanangozdengecirmetarihi).HasColumnName("PLANLANANGOZDENGECIRMETARIHI");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Surecbaslatmatarihi).HasColumnName("SURECBASLATMATARIHI");
            entity.Property(e => e.Surecnumarasi)
                .HasMaxLength(255)
                .HasColumnName("SURECNUMARASI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachkid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHKID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfeklerkid)
                .HasMaxLength(255)
                .HasColumnName("WFEKLERKID");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
        });

        modelBuilder.Entity<KyskryAltsurecbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_ALTSURECBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Altsurec)
                .HasMaxLength(255)
                .HasColumnName("ALTSUREC");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryBaglamsinifibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_BAGLAMSINIFIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Baglamsinifi)
                .HasMaxLength(255)
                .HasColumnName("BAGLAMSINIFI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryBaglamtanimibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_BAGLAMTANIMIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Baglamtanimi)
                .HasMaxLength(255)
                .HasColumnName("BAGLAMTANIMI");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryBaglamturubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_BAGLAMTURUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Baglamturu)
                .HasMaxLength(255)
                .HasColumnName("BAGLAMTURU");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryDepartmanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_DEPARTMANBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryFirsatboyutubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_FIRSATBOYUTUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Firsatboyutu)
                .HasMaxLength(255)
                .HasColumnName("FIRSATBOYUTU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryOlasilikbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_OLASILIKBAKIM");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Olasilik)
                .HasMaxLength(255)
                .HasColumnName("OLASILIK");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryPeriyotbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_PERIYOTBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Periyot)
                .HasMaxLength(255)
                .HasColumnName("PERIYOT");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryPuantablosu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KYSKRY_PUANTABLOSU");

            entity.Property(e => e.Aksiyonihtiyaci)
                .HasColumnType("NCLOB")
                .HasColumnName("AKSIYONIHTIYACI");
            entity.Property(e => e.Aksiyonplani)
                .HasColumnType("NCLOB")
                .HasColumnName("AKSIYONPLANI");
            entity.Property(e => e.Aksiyontarihplani)
                .HasColumnType("NCLOB")
                .HasColumnName("AKSIYONTARIHPLANI");
            entity.Property(e => e.Altsurec)
                .HasColumnType("NCLOB")
                .HasColumnName("ALTSUREC");
            entity.Property(e => e.Baglamsinifi)
                .HasColumnType("NCLOB")
                .HasColumnName("BAGLAMSINIFI");
            entity.Property(e => e.Baglamtanimi)
                .HasColumnType("NCLOB")
                .HasColumnName("BAGLAMTANIMI");
            entity.Property(e => e.Baglamturu)
                .HasColumnType("NCLOB")
                .HasColumnName("BAGLAMTURU");
            entity.Property(e => e.Firsatboyututanimi)
                .HasColumnType("NCLOB")
                .HasColumnName("FIRSATBOYUTUTANIMI");
            entity.Property(e => e.Id)
                .HasColumnType("NCLOB")
                .HasColumnName("ID");
            entity.Property(e => e.Mevcuttedbirler)
                .HasColumnType("NCLOB")
                .HasColumnName("MEVCUTTEDBIRLER");
            entity.Property(e => e.Olasilik)
                .HasColumnType("NCLOB")
                .HasColumnName("OLASILIK");
            entity.Property(e => e.Olay)
                .HasColumnType("NCLOB")
                .HasColumnName("OLAY");
            entity.Property(e => e.Riskfirsat)
                .HasColumnType("NCLOB")
                .HasColumnName("RISKFIRSAT");
            entity.Property(e => e.Riskfirsatboyutu)
                .HasColumnType("NCLOB")
                .HasColumnName("RISKFIRSATBOYUTU");
            entity.Property(e => e.Riskinsonucu)
                .HasColumnType("NCLOB")
                .HasColumnName("RISKINSONUCU");
            entity.Property(e => e.Riskintanimi)
                .HasColumnType("NCLOB")
                .HasColumnName("RISKINTANIMI");
            entity.Property(e => e.Siddet)
                .HasColumnType("NCLOB")
                .HasColumnName("SIDDET");
            entity.Property(e => e.Sorumlu)
                .HasColumnType("NCLOB")
                .HasColumnName("SORUMLU");
            entity.Property(e => e.Surec)
                .HasColumnType("NCLOB")
                .HasColumnName("SUREC");
            entity.Property(e => e.Surecbasamagi)
                .HasColumnType("NCLOB")
                .HasColumnName("SURECBASAMAGI");
            entity.Property(e => e.Wfid)
                .HasColumnType("NCLOB")
                .HasColumnName("WFID");
        });

        modelBuilder.Entity<KyskryRiskbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_RISKBAKIM");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Risk)
                .HasMaxLength(255)
                .HasColumnName("RISK");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryRiskfirsatbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_RISKFIRSATBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Riskfirsat)
                .HasMaxLength(255)
                .HasColumnName("RISKFIRSAT");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskrySurecbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_SURECBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Surec)
                .HasMaxLength(255)
                .HasColumnName("SUREC");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskrySurecbasamagibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_SURECBASAMAGIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Surecbasamagi)
                .HasMaxLength(255)
                .HasColumnName("SURECBASAMAGI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskrySurecsorumlularibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_SURECSORUMLULARIBAKIM");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Departmangrup).HasColumnName("DEPARTMANGRUP");
            entity.Property(e => e.Departmankullanicilari).HasColumnName("DEPARTMANKULLANICILARI");
            entity.Property(e => e.Departmankullanicilariaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("DEPARTMANKULLANICILARIAKTIF");
            entity.Property(e => e.Departmanlar)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMANLAR");
            entity.Property(e => e.Departmansorumlusu).HasColumnName("DEPARTMANSORUMLUSU");
            entity.Property(e => e.Departmansorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("DEPARTMANSORUMLUSUAKTIF");
            entity.Property(e => e.Ilgilibirimsorumlusu).HasColumnName("ILGILIBIRIMSORUMLUSU");
            entity.Property(e => e.Ilgilibirimsorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("ILGILIBIRIMSORUMLUSUAKTIF");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Surecibaslatankullanici).HasColumnName("SURECIBASLATANKULLANICI");
            entity.Property(e => e.Surecibaslatankullaniciaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("SURECIBASLATANKULLANICIAKTIF");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KyskryWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<KyskryWfformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_WFFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfform)
                .HasMaxLength(255)
                .HasColumnName("WFFORM");
        });

        modelBuilder.Entity<KyskryWfkararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSKRY_WFKARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfkarar)
                .HasMaxLength(255)
                .HasColumnName("WFKARAR");
        });

        modelBuilder.Entity<Kysoby>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Durum)
                .HasMaxLength(255)
                .HasColumnName("DURUM");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3).HasColumnName("EKALAN3");
            entity.Property(e => e.Eskiperformer).HasColumnName("ESKIPERFORMER");
            entity.Property(e => e.Gorusalinacakkullanici).HasColumnName("GORUSALINACAKKULLANICI");
            entity.Property(e => e.Iksorumlusu).HasColumnName("IKSORUMLUSU");
            entity.Property(e => e.Isgsorumlusu).HasColumnName("ISGSORUMLUSU");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Kid)
                .HasMaxLength(255)
                .HasColumnName("KID");
            entity.Property(e => e.Komisyonuyegrubu).HasColumnName("KOMISYONUYEGRUBU");
            entity.Property(e => e.Muduronay)
                .HasColumnType("INTEGER")
                .HasColumnName("MUDURONAY");
            entity.Property(e => e.Oneriamaci)
                .HasColumnType("NCLOB")
                .HasColumnName("ONERIAMACI");
            entity.Property(e => e.Oneridetayi)
                .HasColumnType("NCLOB")
                .HasColumnName("ONERIDETAYI");
            entity.Property(e => e.Onerisahibi)
                .HasMaxLength(255)
                .HasColumnName("ONERISAHIBI");
            entity.Property(e => e.Ortalamapuan)
                .HasMaxLength(255)
                .HasColumnName("ORTALAMAPUAN");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(255)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Surecnumarasi)
                .HasMaxLength(255)
                .HasColumnName("SURECNUMARASI");
            entity.Property(e => e.Surectipi)
                .HasMaxLength(255)
                .HasColumnName("SURECTIPI");
            entity.Property(e => e.Surectipikisaltmasi)
                .HasMaxLength(255)
                .HasColumnName("SURECTIPIKISALTMASI");
            entity.Property(e => e.Talepeden).HasColumnName("TALEPEDEN");
            entity.Property(e => e.Talepedendepartman).HasColumnName("TALEPEDENDEPARTMAN");
            entity.Property(e => e.Taleptarihi).HasColumnName("TALEPTARIHI");
            entity.Property(e => e.Uye1).HasColumnName("UYE1");
            entity.Property(e => e.Uye2).HasColumnName("UYE2");
            entity.Property(e => e.Uye3).HasColumnName("UYE3");
            entity.Property(e => e.Uye4).HasColumnName("UYE4");
            entity.Property(e => e.Uye5).HasColumnName("UYE5");
            entity.Property(e => e.Uye6).HasColumnName("UYE6");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachkid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHKID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfeklerkid)
                .HasMaxLength(255)
                .HasColumnName("WFEKLERKID");
            entity.Property(e => e.Wfgonderenform)
                .HasMaxLength(255)
                .HasColumnName("WFGONDERENFORM");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Yorum)
                .HasColumnType("NCLOB")
                .HasColumnName("YORUM");
        });

        modelBuilder.Entity<KysobyDepartmanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_DEPARTMANBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysobyDurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_DURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Durum)
                .HasMaxLength(255)
                .HasColumnName("DURUM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysobyFrmGorusalbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_FRM_GORUSALBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gorusalinacakkullanici).HasColumnName("GORUSALINACAKKULLANICI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysobyKomisyontablosu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KYSOBY_KOMISYONTABLOSU");

            entity.Property(e => e.Id)
                .HasColumnType("NCLOB")
                .HasColumnName("ID");
            entity.Property(e => e.Sonucpuan)
                .HasColumnType("NCLOB")
                .HasColumnName("SONUCPUAN");
            entity.Property(e => e.Uye1aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1ACIKLAMA");
            entity.Property(e => e.Uye1cevre)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1CEVRE");
            entity.Property(e => e.Uye1issagligi)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1ISSAGLIGI");
            entity.Property(e => e.Uye1oneri)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1ONERI");
            entity.Property(e => e.Uye1puan)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1PUAN");
            entity.Property(e => e.Uye1uygulanabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1UYGULANABILIRLIK");
            entity.Property(e => e.Uye1verimlilik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1VERIMLILIK");
            entity.Property(e => e.Uye1yayginlastirilabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE1YAYGINLASTIRILABILIRLIK");
            entity.Property(e => e.Uye2aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2ACIKLAMA");
            entity.Property(e => e.Uye2cevre)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2CEVRE");
            entity.Property(e => e.Uye2issagligi)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2ISSAGLIGI");
            entity.Property(e => e.Uye2oneri)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2ONERI");
            entity.Property(e => e.Uye2puan)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2PUAN");
            entity.Property(e => e.Uye2uygulanabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2UYGULANABILIRLIK");
            entity.Property(e => e.Uye2verimlilik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2VERIMLILIK");
            entity.Property(e => e.Uye2yayginlastirilabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE2YAYGINLASTIRILABILIRLIK");
            entity.Property(e => e.Uye3aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3ACIKLAMA");
            entity.Property(e => e.Uye3cevre)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3CEVRE");
            entity.Property(e => e.Uye3issagligi)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3ISSAGLIGI");
            entity.Property(e => e.Uye3oneri)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3ONERI");
            entity.Property(e => e.Uye3puan)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3PUAN");
            entity.Property(e => e.Uye3uygulanabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3UYGULANABILIRLIK");
            entity.Property(e => e.Uye3verimlilik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3VERIMLILIK");
            entity.Property(e => e.Uye3yayginlastirilabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE3YAYGINLASTIRILABILIRLIK");
            entity.Property(e => e.Uye4aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4ACIKLAMA");
            entity.Property(e => e.Uye4cevre)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4CEVRE");
            entity.Property(e => e.Uye4issagligi)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4ISSAGLIGI");
            entity.Property(e => e.Uye4oneri)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4ONERI");
            entity.Property(e => e.Uye4puan)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4PUAN");
            entity.Property(e => e.Uye4uygulanabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4UYGULANABILIRLIK");
            entity.Property(e => e.Uye4verimlilik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4VERIMLILIK");
            entity.Property(e => e.Uye4yayginlastirilabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE4YAYGINLASTIRILABILIRLIK");
            entity.Property(e => e.Uye5aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5ACIKLAMA");
            entity.Property(e => e.Uye5cevre)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5CEVRE");
            entity.Property(e => e.Uye5issagligi)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5ISSAGLIGI");
            entity.Property(e => e.Uye5oneri)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5ONERI");
            entity.Property(e => e.Uye5puan)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5PUAN");
            entity.Property(e => e.Uye5uygulanabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5UYGULANABILIRLIK");
            entity.Property(e => e.Uye5verimlilik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5VERIMLILIK");
            entity.Property(e => e.Uye5yayginlastirilabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE5YAYGINLASTIRILABILIRLIK");
            entity.Property(e => e.Uye6aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6ACIKLAMA");
            entity.Property(e => e.Uye6cevre)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6CEVRE");
            entity.Property(e => e.Uye6issagligi)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6ISSAGLIGI");
            entity.Property(e => e.Uye6oneri)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6ONERI");
            entity.Property(e => e.Uye6puan)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6PUAN");
            entity.Property(e => e.Uye6uygulanabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6UYGULANABILIRLIK");
            entity.Property(e => e.Uye6verimlilik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6VERIMLILIK");
            entity.Property(e => e.Uye6yayginlastirilabilirlik)
                .HasColumnType("NCLOB")
                .HasColumnName("UYE6YAYGINLASTIRILABILIRLIK");
            entity.Property(e => e.Wfid)
                .HasColumnType("NCLOB")
                .HasColumnName("WFID");
        });

        modelBuilder.Entity<KysobySurecsorumlularibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_SURECSORUMLULARIBAKIM");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Departmangrup).HasColumnName("DEPARTMANGRUP");
            entity.Property(e => e.Iksorumlusu).HasColumnName("IKSORUMLUSU");
            entity.Property(e => e.Iksorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("IKSORUMLUSUAKTIF");
            entity.Property(e => e.Isgsorumlusu).HasColumnName("ISGSORUMLUSU");
            entity.Property(e => e.Isgsorumlusuaktif)
                .HasColumnType("INTEGER")
                .HasColumnName("ISGSORUMLUSUAKTIF");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Uye1).HasColumnName("UYE1");
            entity.Property(e => e.Uye1aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("UYE1AKTIF");
            entity.Property(e => e.Uye2).HasColumnName("UYE2");
            entity.Property(e => e.Uye2aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("UYE2AKTIF");
            entity.Property(e => e.Uye3).HasColumnName("UYE3");
            entity.Property(e => e.Uye3aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("UYE3AKTIF");
            entity.Property(e => e.Uye4).HasColumnName("UYE4");
            entity.Property(e => e.Uye4aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("UYE4AKTIF");
            entity.Property(e => e.Uye5).HasColumnName("UYE5");
            entity.Property(e => e.Uye5aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("UYE5AKTIF");
            entity.Property(e => e.Uye6).HasColumnName("UYE6");
            entity.Property(e => e.Uye6aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("UYE6AKTIF");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysobySurectipibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_SURECTIPIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kisaltma)
                .HasMaxLength(255)
                .HasColumnName("KISALTMA");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Surectipi)
                .HasMaxLength(255)
                .HasColumnName("SURECTIPI");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysobyWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<KysobyWfformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_WFFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfform)
                .HasMaxLength(255)
                .HasColumnName("WFFORM");
        });

        modelBuilder.Entity<KysobyWfkararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSOBY_WFKARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfkarar)
                .HasMaxLength(255)
                .HasColumnName("WFKARAR");
        });

        modelBuilder.Entity<Kysygg>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG");

            entity.Property(e => e.Aciklama)
                .HasColumnType("NCLOB")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslatandepartman).HasColumnName("BASLATANDEPARTMAN");
            entity.Property(e => e.Baslatankullanici).HasColumnName("BASLATANKULLANICI");
            entity.Property(e => e.Birim)
                .HasMaxLength(255)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Egdfwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDFWFID");
            entity.Property(e => e.Egdgsmwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDGSMWFID");
            entity.Property(e => e.Egdntwfid)
                .HasMaxLength(255)
                .HasColumnName("EGDNTWFID");
            entity.Property(e => e.Egisgwfid)
                .HasMaxLength(255)
                .HasColumnName("EGISGWFID");
            entity.Property(e => e.Egkrywfid)
                .HasMaxLength(255)
                .HasColumnName("EGKRYWFID");
            entity.Property(e => e.Egyggwfid)
                .HasMaxLength(255)
                .HasColumnName("EGYGGWFID");
            entity.Property(e => e.Egymuywfid)
                .HasMaxLength(255)
                .HasColumnName("EGYMUYWFID");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Gysbirimi)
                .HasMaxLength(255)
                .HasColumnName("GYSBIRIMI");
            entity.Property(e => e.Gysunsurlari)
                .HasMaxLength(255)
                .HasColumnName("GYSUNSURLARI");
            entity.Property(e => e.Ilgilisistem)
                .HasMaxLength(255)
                .HasColumnName("ILGILISISTEM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Karar)
                .HasMaxLength(255)
                .HasColumnName("KARAR");
            entity.Property(e => e.Katilimcilar)
                .HasColumnType("NCLOB")
                .HasColumnName("KATILIMCILAR");
            entity.Property(e => e.Kid)
                .HasMaxLength(255)
                .HasColumnName("KID");
            entity.Property(e => e.Performer).HasColumnName("PERFORMER");
            entity.Property(e => e.Raportarihi).HasColumnName("RAPORTARIHI");
            entity.Property(e => e.Raporturu)
                .HasMaxLength(255)
                .HasColumnName("RAPORTURU");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Surecbaslatmatarihi).HasColumnName("SURECBASLATMATARIHI");
            entity.Property(e => e.Toplantikonusu)
                .HasMaxLength(255)
                .HasColumnName("TOPLANTIKONUSU");
            entity.Property(e => e.Toplantinumarasi)
                .HasMaxLength(255)
                .HasColumnName("TOPLANTINUMARASI");
            entity.Property(e => e.Toplantituru)
                .HasMaxLength(255)
                .HasColumnName("TOPLANTITURU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfattachkid)
                .HasMaxLength(255)
                .HasColumnName("WFATTACHKID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
            entity.Property(e => e.Wfeklerkid)
                .HasMaxLength(255)
                .HasColumnName("WFEKLERKID");
            entity.Property(e => e.Wfgorevform)
                .HasMaxLength(255)
                .HasColumnName("WFGOREVFORM");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Yer)
                .HasMaxLength(255)
                .HasColumnName("YER");
            entity.Property(e => e.Yggdokumaniid)
                .HasMaxLength(255)
                .HasColumnName("YGGDOKUMANIID");
        });

        modelBuilder.Entity<KysyggBirimbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_BIRIMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Birim)
                .HasMaxLength(255)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggDepartmanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_DEPARTMANBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggGysbirimibakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_GYSBIRIMIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gysbirimi)
                .HasMaxLength(255)
                .HasColumnName("GYSBIRIMI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggGysunsurlaribakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_GYSUNSURLARIBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gysunsurlari)
                .HasMaxLength(255)
                .HasColumnName("GYSUNSURLARI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggIlgilisistembakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_ILGILISISTEMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ilgilisistem)
                .HasMaxLength(255)
                .HasColumnName("ILGILISISTEM");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggRaporturubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_RAPORTURUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Raporturu)
                .HasMaxLength(255)
                .HasColumnName("RAPORTURU");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggSablonbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_SABLONBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dokumangrubu)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANGRUBU");
            entity.Property(e => e.Dokumantipi)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANTIPI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Sablondokumanadi)
                .HasMaxLength(255)
                .HasColumnName("SABLONDOKUMANADI");
            entity.Property(e => e.Sablondokumanid)
                .HasMaxLength(255)
                .HasColumnName("SABLONDOKUMANID");
            entity.Property(e => e.Sablonkisaltmasi)
                .HasMaxLength(255)
                .HasColumnName("SABLONKISALTMASI");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggToplantikonusubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_TOPLANTIKONUSUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Toplantikonusu)
                .HasMaxLength(255)
                .HasColumnName("TOPLANTIKONUSU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggToplantiturubakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_TOPLANTITURUBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Toplantituru)
                .HasMaxLength(255)
                .HasColumnName("TOPLANTITURU");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<KysyggWfdurumbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_WFDURUMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfdurum)
                .HasMaxLength(255)
                .HasColumnName("WFDURUM");
        });

        modelBuilder.Entity<KysyggWfformbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_WFFORMBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfform)
                .HasMaxLength(255)
                .HasColumnName("WFFORM");
        });

        modelBuilder.Entity<KysyggWfkararbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_WFKARARBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfkarar)
                .HasMaxLength(255)
                .HasColumnName("WFKARAR");
        });

        modelBuilder.Entity<KysyggYerbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("KYSYGG_YERBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Yer)
                .HasMaxLength(255)
                .HasColumnName("YER");
        });

        modelBuilder.Entity<Labeldefinition>(entity =>
        {
            entity.HasKey(e => e.Labeldefname);
            entity.ToTable("LABELDEFINITION");

            entity.Property(e => e.Labelcomment)
                .HasMaxLength(255)
                .HasColumnName("LABELCOMMENT");
            entity.Property(e => e.Labeldefname)
                .HasMaxLength(32)
                .HasColumnName("LABELDEFNAME");
            entity.Property(e => e.Labeldefxml)
                .HasColumnType("NCLOB")
                .HasColumnName("LABELDEFXML");
            entity.Property(e => e.Labeltype).HasColumnName("LABELTYPE");
            entity.Property(e => e.Stockname)
                .HasMaxLength(32)
                .HasColumnName("STOCKNAME");
        });

        modelBuilder.Entity<Labeldefspec>(entity =>
        {
            entity.HasKey(e => new { e.Defspecs, e.Labeldefname });
            entity.ToTable("LABELDEFSPECS");

            entity.Property(e => e.Columnstoselect)
                .HasMaxLength(4000)
                .HasColumnName("COLUMNSTOSELECT");
            entity.Property(e => e.Defspecs)
                .HasMaxLength(128)
                .HasColumnName("DEFSPECS");
            entity.Property(e => e.Labeldefname)
                .HasMaxLength(32)
                .HasColumnName("LABELDEFNAME");
            entity.Property(e => e.Tablename)
                .HasMaxLength(128)
                .HasColumnName("TABLENAME");
        });

        modelBuilder.Entity<Labelqueue>(entity =>
        {
            entity.HasKey(e => new { e.Nodeid, e.Labeldefname, e.Uniqueid });
            entity.ToTable("LABELQUEUE");

            entity.Property(e => e.Createdatetime).HasColumnName("CREATEDATETIME");
            entity.Property(e => e.Labelcontent)
                .HasColumnType("NCLOB")
                .HasColumnName("LABELCONTENT");
            entity.Property(e => e.Labeldefname)
                .HasMaxLength(32)
                .HasColumnName("LABELDEFNAME");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Noofcopies)
                .HasColumnType("INTEGER")
                .HasColumnName("NOOFCOPIES");
            entity.Property(e => e.Printflag).HasColumnName("PRINTFLAG");
            entity.Property(e => e.Uniqueid)
                .HasMaxLength(64)
                .HasColumnName("UNIQUEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Labelstock>(entity =>
        {
            entity.HasKey(e => e.Stockname);
            entity.ToTable("LABELSTOCK");

            entity.Property(e => e.Labelsperpage).HasColumnName("LABELSPERPAGE");
            entity.Property(e => e.Stockcomment)
                .HasMaxLength(255)
                .HasColumnName("STOCKCOMMENT");
            entity.Property(e => e.Stockdefxml)
                .HasColumnType("NCLOB")
                .HasColumnName("STOCKDEFXML");
            entity.Property(e => e.Stockname)
                .HasMaxLength(32)
                .HasColumnName("STOCKNAME");
        });

        modelBuilder.Entity<Licaccess>(entity =>
        {
            entity.HasKey(e => new { e.Audittype, e.Audititem, e.Memberid, e.Accessdate });
            entity.ToTable("LICACCESSES");

            entity.Property(e => e.Accessdate)
                .HasColumnType("INTEGER")
                .HasColumnName("ACCESSDATE");
            entity.Property(e => e.Audititem).HasColumnName("AUDITITEM");
            entity.Property(e => e.Audittype)
                .HasColumnType("INTEGER")
                .HasColumnName("AUDITTYPE");
            entity.Property(e => e.Memberid).HasColumnName("MEMBERID");
        });

        modelBuilder.Entity<Liccountmethod>(entity =>
        {
            entity.HasKey(e => new { e.Audittype, e.Audititem });
            entity.ToTable("LICCOUNTMETHODS");

            entity.Property(e => e.Audititem).HasColumnName("AUDITITEM");
            entity.Property(e => e.Audittype)
                .HasColumnType("INTEGER")
                .HasColumnName("AUDITTYPE");
            entity.Property(e => e.Ecosystemid).HasColumnName("ECOSYSTEMID");
        });

        modelBuilder.Entity<Licecosystem>(entity =>
        {
            entity.HasKey(e => e.Ecosystemid);
            entity.ToTable("LICECOSYSTEMS");

            entity.Property(e => e.Ecosystemid).HasColumnName("ECOSYSTEMID");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("NAME");
            entity.Property(e => e.Nameresid)
                .HasMaxLength(255)
                .HasColumnName("NAMERESID");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
        });

        modelBuilder.Entity<Liclevel>(entity =>
        {
            entity.HasKey(e => e.Name);
            entity.ToTable("LICLEVELS");

            entity.Property(e => e.Ecosystemid).HasColumnName("ECOSYSTEMID");
            entity.Property(e => e.Levelid).HasColumnName("LEVELID");
            entity.Property(e => e.Maxaccessdays)
                .HasColumnType("INTEGER")
                .HasColumnName("MAXACCESSDAYS");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("NAME");
            entity.Property(e => e.Nameresid)
                .HasMaxLength(255)
                .HasColumnName("NAMERESID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Seller)
                .HasMaxLength(32)
                .HasColumnName("SELLER");
        });

        modelBuilder.Entity<Liclevelchild>(entity =>
        {
            entity.HasKey(e => new { e.Levelid, e.Childid });
            entity.ToTable("LICLEVELCHILDREN");

            entity.Property(e => e.Childid).HasColumnName("CHILDID");
            entity.Property(e => e.Levelid).HasColumnName("LEVELID");
        });

        modelBuilder.Entity<Licmember>(entity =>
        {
            entity.HasKey(e => new { e.Memberid, e.Ecosystemid });
            entity.ToTable("LICMEMBERS");

            entity.Property(e => e.Ecosystemid).HasColumnName("ECOSYSTEMID");
            entity.Property(e => e.Levelid).HasColumnName("LEVELID");
            entity.Property(e => e.Memberid).HasColumnName("MEMBERID");
        });

        modelBuilder.Entity<Llattrblobdatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Vernum, e.Segmentid });
            entity.ToTable("LLATTRBLOBDATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Segmentblob)
                .HasColumnType("NCLOB")
                .HasColumnName("SEGMENTBLOB");
            entity.Property(e => e.Segmentid)
                .HasColumnType("INTEGER")
                .HasColumnName("SEGMENTID");
            entity.Property(e => e.Vernum).HasColumnName("VERNUM");
        });

        modelBuilder.Entity<Llattrdatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Vernum, e.Attrid });
            entity.ToTable("LLATTRDATA");

            entity.Property(e => e.Attrid)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRID");
            entity.Property(e => e.Attrtype)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRTYPE");
            entity.Property(e => e.Customid)
                .HasColumnType("INTEGER")
                .HasColumnName("CUSTOMID");
            entity.Property(e => e.Defid).HasColumnName("DEFID");
            entity.Property(e => e.Defvern).HasColumnName("DEFVERN");
            entity.Property(e => e.Entrynum)
                .HasColumnType("INTEGER")
                .HasColumnName("ENTRYNUM");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Keyid).HasColumnName("KEYID");
            entity.Property(e => e.Parentkeyid).HasColumnName("PARENTKEYID");
            entity.Property(e => e.Valdate).HasColumnName("VALDATE");
            entity.Property(e => e.Valint).HasColumnName("VALINT");
            entity.Property(e => e.Vallong)
                .HasColumnType("NCLOB")
                .HasColumnName("VALLONG");
            entity.Property(e => e.Valreal)
                .HasColumnType("DECIMAL")
                .HasColumnName("VALREAL");
            entity.Property(e => e.Valstr)
                .HasMaxLength(255)
                .HasColumnName("VALSTR");
            entity.Property(e => e.Vernum).HasColumnName("VERNUM");
        });

        modelBuilder.Entity<Llcache>(entity =>
        {
            entity.HasKey(e => e.Objectdate);
            entity.ToTable("LLCACHE");

            entity.Property(e => e.Objectdate).HasColumnName("OBJECTDATE");
            entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            entity.Property(e => e.Segmentblob)
                .HasColumnType("NCLOB")
                .HasColumnName("SEGMENTBLOB");
            entity.Property(e => e.Segmentid).HasColumnName("SEGMENTID");
        });

        modelBuilder.Entity<Llcachesecure>(entity =>
        {
            entity.HasKey(e => e.Cachekey);
            entity.ToTable("LLCACHESECURE");

            entity.Property(e => e.Cachekey)
                .HasMaxLength(255)
                .HasColumnName("CACHEKEY");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Expiresdate).HasColumnName("EXPIRESDATE");
            entity.Property(e => e.Lastupdatedate).HasColumnName("LASTUPDATEDATE");
            entity.Property(e => e.Segmentblob)
                .HasColumnType("NCLOB")
                .HasColumnName("SEGMENTBLOB");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llclassify>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("LLCLASSIFY");

            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Inheritflag).HasColumnName("INHERITFLAG");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.Status)
                .HasMaxLength(32)
                .HasColumnName("STATUS");
            entity.Property(e => e.Systemclassified)
                .HasMaxLength(32)
                .HasColumnName("SYSTEMCLASSIFIED");
            entity.Property(e => e.Userclassified)
                .HasMaxLength(32)
                .HasColumnName("USERCLASSIFIED");
        });

        modelBuilder.Entity<Llcomment>(entity =>
        {
            entity.HasKey(e => e.Orderstring);
            entity.ToTable("LLCOMMENTS");

            entity.Property(e => e.Comments)
                .HasColumnType("NCLOB")
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Commentsid).HasColumnName("COMMENTSID");
            entity.Property(e => e.Iconid).HasColumnName("ICONID");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Orderstring)
                .HasMaxLength(32)
                .HasColumnName("ORDERSTRING");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Subject)
                .HasMaxLength(4000)
                .HasColumnName("SUBJECT");
        });

        modelBuilder.Entity<Llcommnotification>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Cid });
            entity.ToTable("LLCOMMNOTIFICATION");

            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Subtypes)
                .HasMaxLength(4000)
                .HasColumnName("SUBTYPES");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llcommregistry>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Dataid });
            entity.ToTable("LLCOMMREGISTRY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Lldirectory>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("LLDIRECTORY");

            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cidsubtype).HasColumnName("CIDSUBTYPE");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<Lleventancestor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LLEVENTANCESTORS");

            entity.Property(e => e.Ancestorid).HasColumnName("ANCESTORID");
        });

        modelBuilder.Entity<Lleventqueue>(entity =>
        {
            entity.HasKey(e => e.Eventseqno);
            entity.ToTable("LLEVENTQUEUE");

            entity.Property(e => e.Eventaction).HasColumnName("EVENTACTION");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Eventhandlerid).HasColumnName("EVENTHANDLERID");
            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Eventint1).HasColumnName("EVENTINT1");
            entity.Property(e => e.Eventint2).HasColumnName("EVENTINT2");
            entity.Property(e => e.Eventint3).HasColumnName("EVENTINT3");
            entity.Property(e => e.Eventint4).HasColumnName("EVENTINT4");
            entity.Property(e => e.Eventseqno).HasColumnName("EVENTSEQNO");
            entity.Property(e => e.Eventsource).HasColumnName("EVENTSOURCE");
            entity.Property(e => e.Eventstr5)
                .HasMaxLength(255)
                .HasColumnName("EVENTSTR5");
            entity.Property(e => e.Eventstr6)
                .HasMaxLength(255)
                .HasColumnName("EVENTSTR6");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llforum>(entity =>
        {
            entity.HasKey(e => new { e.Parentid, e.Volumeid });
            entity.ToTable("LLFORUMS");

            entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<Llforumsdirectory>(entity =>
        {
            entity.HasKey(e => new { e.Directoryid, e.Forumid });
            entity.ToTable("LLFORUMSDIRECTORY");

            entity.Property(e => e.Directoryid).HasColumnName("DIRECTORYID");
            entity.Property(e => e.Forumid).HasColumnName("FORUMID");
        });

        modelBuilder.Entity<Llforumsorder>(entity =>
        {
            entity.HasKey(e => new { e.Forumid, e.Topiclevel });
            entity.ToTable("LLFORUMSORDER");

            entity.Property(e => e.Forumid).HasColumnName("FORUMID");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Orderstring)
                .HasMaxLength(255)
                .HasColumnName("ORDERSTRING");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Topicid).HasColumnName("TOPICID");
            entity.Property(e => e.Topiclevel).HasColumnName("TOPICLEVEL");
            entity.Property(e => e.Topicstatus).HasColumnName("TOPICSTATUS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llmultivolumeregistry>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Volumeid });
            entity.ToTable("LLMULTIVOLUMEREGISTRY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Defaultid).HasColumnName("DEFAULTID");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<Llpolling>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Userid });
            entity.ToTable("LLPOLLING");

            entity.Property(e => e.Commentnum)
                .HasColumnType("INTEGER")
                .HasColumnName("COMMENTNUM");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Polldata)
                .HasColumnType("NCLOB")
                .HasColumnName("POLLDATA");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llprospector>(entity =>
        {
            entity.HasKey(e => e.Prospectorid);
            entity.ToTable("LLPROSPECTOR");

            entity.Property(e => e.Filedate)
                .HasMaxLength(255)
                .HasColumnName("FILEDATE");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filesize)
                .HasMaxLength(255)
                .HasColumnName("FILESIZE");
            entity.Property(e => e.Filetime)
                .HasMaxLength(255)
                .HasColumnName("FILETIME");
            entity.Property(e => e.InfoSource).HasColumnName("INFO_SOURCE");
            entity.Property(e => e.MatchTime).HasColumnName("MATCH_TIME");
            entity.Property(e => e.Otdataid).HasColumnName("OTDATAID");
            entity.Property(e => e.Otfiltermimetype)
                .HasMaxLength(255)
                .HasColumnName("OTFILTERMIMETYPE");
            entity.Property(e => e.Otlocationlink)
                .HasMaxLength(4000)
                .HasColumnName("OTLOCATIONLINK");
            entity.Property(e => e.Otlocationtitle)
                .HasMaxLength(4000)
                .HasColumnName("OTLOCATIONTITLE");
            entity.Property(e => e.Otobject)
                .HasMaxLength(4000)
                .HasColumnName("OTOBJECT");
            entity.Property(e => e.Otscore).HasColumnName("OTSCORE");
            entity.Property(e => e.Otsummary)
                .HasColumnType("NCLOB")
                .HasColumnName("OTSUMMARY");
            entity.Property(e => e.Prospectorid).HasColumnName("PROSPECTORID");
            entity.Property(e => e.Resultid).HasColumnName("RESULTID");
            entity.Property(e => e.Status)
                .HasMaxLength(32)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Llprospectordatum>(entity =>
        {
            entity.HasKey(e => e.Prospectorid);
            entity.ToTable("LLPROSPECTORDATA");

            entity.Property(e => e.Prospectordata)
                .HasColumnType("NCLOB")
                .HasColumnName("PROSPECTORDATA");
            entity.Property(e => e.Prospectorid).HasColumnName("PROSPECTORID");
        });

        modelBuilder.Entity<Llprospectorregistry>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Userid });
            entity.ToTable("LLPROSPECTORREGISTRY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llproxiesmapping>(entity =>
        {
            entity.HasKey(e => new { e.Proxyid, e.Solutionname });
            entity.ToTable("LLPROXIESMAPPING");

            entity.Property(e => e.Proxyid).HasColumnName("PROXYID");
            entity.Property(e => e.Solutionname)
                .HasMaxLength(255)
                .HasColumnName("SOLUTIONNAME");
        });

        modelBuilder.Entity<Llproxy>(entity =>
        {
            entity.HasKey(e => e.Proxyid);
            entity.ToTable("LLPROXIES");

            entity.Property(e => e.Displayname)
                .HasMaxLength(255)
                .HasColumnName("DISPLAYNAME");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .HasColumnName("HOSTNAME");
            entity.Property(e => e.Port).HasColumnName("PORT");
            entity.Property(e => e.Proxyid).HasColumnName("PROXYID");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Llquestion>(entity =>
        {
            entity.HasKey(e => e.Expirationdate);
            entity.ToTable("LLQUESTIONS");

            entity.Property(e => e.Acceptednum).HasColumnName("ACCEPTEDNUM");
            entity.Property(e => e.Closed).HasColumnName("CLOSED");
            entity.Property(e => e.Closeddate).HasColumnName("CLOSEDDATE");
            entity.Property(e => e.Commentsnum).HasColumnName("COMMENTSNUM");
            entity.Property(e => e.Expirationdate).HasColumnName("EXPIRATIONDATE");
            entity.Property(e => e.Questionid).HasColumnName("QUESTIONID");
            entity.Property(e => e.Rejectednum).HasColumnName("REJECTEDNUM");
            entity.Property(e => e.Suggestednum).HasColumnName("SUGGESTEDNUM");
            entity.Property(e => e.Urgency).HasColumnName("URGENCY");
        });

        modelBuilder.Entity<Llsystemdatum>(entity =>
        {
            entity.HasKey(e => new { e.Section, e.Keyword });
            entity.ToTable("LLSYSTEMDATA");

            entity.Property(e => e.Keyword)
                .HasMaxLength(128)
                .HasColumnName("KEYWORD");
            entity.Property(e => e.Section)
                .HasMaxLength(128)
                .HasColumnName("SECTION");
            entity.Property(e => e.Value)
                .HasColumnType("NCLOB")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Lluserdatum>(entity =>
        {
            entity.HasKey(e => new { e.Prefsid, e.Prefskeyword });
            entity.ToTable("LLUSERDATA");

            entity.Property(e => e.Lastupdatedate).HasColumnName("LASTUPDATEDATE");
            entity.Property(e => e.Prefsid).HasColumnName("PREFSID");
            entity.Property(e => e.Prefskeyword)
                .HasMaxLength(128)
                .HasColumnName("PREFSKEYWORD");
            entity.Property(e => e.Prefsvalue)
                .HasMaxLength(4000)
                .HasColumnName("PREFSVALUE");
        });

        modelBuilder.Entity<Llwebsessioncache>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LLWEBSESSIONCACHE");

            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Expiresdate).HasColumnName("EXPIRESDATE");
            entity.Property(e => e.Lastupdatedate).HasColumnName("LASTUPDATEDATE");
            entity.Property(e => e.Remoteaddr)
                .HasMaxLength(255)
                .HasColumnName("REMOTEADDR");
            entity.Property(e => e.Segmentblob)
                .HasMaxLength(4000)
                .HasColumnName("SEGMENTBLOB");
            entity.Property(e => e.Sessionid)
                .HasMaxLength(255)
                .HasColumnName("SESSIONID");
            entity.Property(e => e.Useragent)
                .HasMaxLength(255)
                .HasColumnName("USERAGENT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llwebsessioncachecore>(entity =>
        {
            entity.HasKey(e => new { e.Sessionid, e.Deleted });
            entity.ToTable("LLWEBSESSIONCACHECORE");

            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Expiresdate).HasColumnName("EXPIRESDATE");
            entity.Property(e => e.Lastupdatedate).HasColumnName("LASTUPDATEDATE");
            entity.Property(e => e.Remoteaddr)
                .HasMaxLength(255)
                .HasColumnName("REMOTEADDR");
            entity.Property(e => e.Segmentblob)
                .HasMaxLength(4000)
                .HasColumnName("SEGMENTBLOB");
            entity.Property(e => e.Sessionid)
                .HasMaxLength(255)
                .HasColumnName("SESSIONID");
            entity.Property(e => e.Useragent)
                .HasMaxLength(255)
                .HasColumnName("USERAGENT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Llwebsessionlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LLWEBSESSIONLOG");

            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Eventtype).HasColumnName("EVENTTYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Locatorlabel>(entity =>
        {
            entity.HasKey(e => new { e.Facility, e.Area, e.Boxlocator, e.Labeldefname });
            entity.ToTable("LOCATORLABELS");

            entity.Property(e => e.Area)
                .HasMaxLength(32)
                .HasColumnName("AREA");
            entity.Property(e => e.Boxlocator)
                .HasMaxLength(32)
                .HasColumnName("BOXLOCATOR");
            entity.Property(e => e.Createdatetime).HasColumnName("CREATEDATETIME");
            entity.Property(e => e.Facility)
                .HasMaxLength(32)
                .HasColumnName("FACILITY");
            entity.Property(e => e.Labelcontent)
                .HasColumnType("NCLOB")
                .HasColumnName("LABELCONTENT");
            entity.Property(e => e.Labeldefname)
                .HasMaxLength(32)
                .HasColumnName("LABELDEFNAME");
            entity.Property(e => e.Noofcopies)
                .HasColumnType("INTEGER")
                .HasColumnName("NOOFCOPIES");
            entity.Property(e => e.Printflag).HasColumnName("PRINTFLAG");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Locatortype>(entity =>
        {
            entity.HasKey(e => e.Locatortype1);
            entity.ToTable("LOCATORTYPE");

            entity.Property(e => e.DescE)
                .HasMaxLength(128)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Locatortype1)
                .HasMaxLength(32)
                .HasColumnName("LOCATORTYPE");
            entity.Property(e => e.Locatortypedepth)
                .HasColumnType("DECIMAL")
                .HasColumnName("LOCATORTYPEDEPTH");
            entity.Property(e => e.Locatortypeheight)
                .HasColumnType("DECIMAL")
                .HasColumnName("LOCATORTYPEHEIGHT");
            entity.Property(e => e.Locatortypelength)
                .HasColumnType("DECIMAL")
                .HasColumnName("LOCATORTYPELENGTH");
            entity.Property(e => e.Locatortypetotal)
                .HasColumnType("DECIMAL")
                .HasColumnName("LOCATORTYPETOTAL");
        });

        modelBuilder.Entity<Loclocatortype>(entity =>
        {
            entity.HasKey(e => new { e.Facility, e.Area, e.Boxlocator, e.Locatortype });
            entity.ToTable("LOCLOCATORTYPE");

            entity.Property(e => e.Area)
                .HasMaxLength(32)
                .HasColumnName("AREA");
            entity.Property(e => e.Boxlocator)
                .HasMaxLength(32)
                .HasColumnName("BOXLOCATOR");
            entity.Property(e => e.Facility)
                .HasMaxLength(32)
                .HasColumnName("FACILITY");
            entity.Property(e => e.Locatortype)
                .HasMaxLength(32)
                .HasColumnName("LOCATORTYPE");
        });

        modelBuilder.Entity<Logininfo>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("LOGININFO");

            entity.Property(e => e.Expiredate).HasColumnName("EXPIREDATE");
            entity.Property(e => e.Numfailed)
                .HasDefaultValueSql("0")
                .HasColumnType("INTEGER")
                .HasColumnName("NUMFAILED");
            entity.Property(e => e.Spassword)
                .HasMaxLength(32)
                .HasColumnName("SPASSWORD");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Mediatype>(entity =>
        {
            entity.HasKey(e => new { e.Mediatypeid, e.Fieldnumber, e.Fieldname });
            entity.ToTable("MEDIATYPES");

            entity.Property(e => e.Defaultval)
                .HasMaxLength(128)
                .HasColumnName("DEFAULTVAL");
            entity.Property(e => e.Fielddisplay)
                .HasMaxLength(128)
                .HasColumnName("FIELDDISPLAY");
            entity.Property(e => e.Fieldname)
                .HasMaxLength(128)
                .HasColumnName("FIELDNAME");
            entity.Property(e => e.Fieldnumber)
                .HasColumnType("INTEGER")
                .HasColumnName("FIELDNUMBER");
            entity.Property(e => e.Fieldorder)
                .HasColumnType("INTEGER")
                .HasColumnName("FIELDORDER");
            entity.Property(e => e.Fieldrequired).HasColumnName("FIELDREQUIRED");
            entity.Property(e => e.Fieldsize)
                .HasColumnType("INTEGER")
                .HasColumnName("FIELDSIZE");
            entity.Property(e => e.Fieldtype).HasColumnName("FIELDTYPE");
            entity.Property(e => e.Mediatypeid).HasColumnName("MEDIATYPEID");
            entity.Property(e => e.Popupvals)
                .HasMaxLength(4000)
                .HasColumnName("POPUPVALS");
        });

        modelBuilder.Entity<Metadatalanguage>(entity =>
        {
            entity.HasKey(e => e.Languagecode);
            entity.ToTable("METADATALANGUAGES");

            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
        });

        modelBuilder.Entity<NgdKini>(entity =>
        {
            entity.HasKey(e => new { e.Inisection, e.Inikeyword });
            entity.ToTable("NGD_KINI");

            entity.Property(e => e.Inikeyword)
                .HasMaxLength(128)
                .HasColumnName("INIKEYWORD");
            entity.Property(e => e.Inisection)
                .HasMaxLength(128)
                .HasColumnName("INISECTION");
            entity.Property(e => e.Inivalue)
                .HasColumnType("NCLOB")
                .HasColumnName("INIVALUE");
        });

        modelBuilder.Entity<NgdNewitemhist>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Userid });
            entity.ToTable("NGD_NEWITEMHIST");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Itemsource)
                .HasMaxLength(4000)
                .HasColumnName("ITEMSOURCE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Nickname>(entity =>
        {
            entity.HasKey(e => new { e.Lowercasenickname, e.Domain });
            entity.ToTable("NICKNAME");

            entity.Property(e => e.Domain)
                .HasMaxLength(248)
                .HasColumnName("DOMAIN");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lowercasenickname)
                .HasMaxLength(248)
                .HasColumnName("LOWERCASENICKNAME");
            entity.Property(e => e.Nickname1)
                .HasMaxLength(248)
                .HasColumnName("NICKNAME");
        });

        modelBuilder.Entity<Notifyevent>(entity =>
        {
            entity.HasKey(e => new { e.Eventid, e.Eventint1, e.Eventint2, e.Eventint3, e.Eventint4 });
            entity.ToTable("NOTIFYEVENTS");

            entity.Property(e => e.Eventaction).HasColumnName("EVENTACTION");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Eventint1).HasColumnName("EVENTINT1");
            entity.Property(e => e.Eventint2).HasColumnName("EVENTINT2");
            entity.Property(e => e.Eventint3).HasColumnName("EVENTINT3");
            entity.Property(e => e.Eventint4).HasColumnName("EVENTINT4");
            entity.Property(e => e.Eventseqno).HasColumnName("EVENTSEQNO");
            entity.Property(e => e.Eventsource).HasColumnName("EVENTSOURCE");
            entity.Property(e => e.Eventstr5)
                .HasMaxLength(255)
                .HasColumnName("EVENTSTR5");
            entity.Property(e => e.Eventstr6)
                .HasMaxLength(255)
                .HasColumnName("EVENTSTR6");
        });

        modelBuilder.Entity<Notifyinterests2>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("NOTIFYINTERESTS2");

            entity.Property(e => e.Eventidmask).HasColumnName("EVENTIDMASK");
            entity.Property(e => e.Interestlevel).HasColumnName("INTERESTLEVEL");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Notifymessage>(entity =>
        {
            entity.HasKey(e => e.Eventdate);
            entity.ToTable("NOTIFYMESSAGES");

            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Eventint1).HasColumnName("EVENTINT1");
            entity.Property(e => e.Eventint2).HasColumnName("EVENTINT2");
            entity.Property(e => e.Eventsource).HasColumnName("EVENTSOURCE");
            entity.Property(e => e.Interestlevel).HasColumnName("INTERESTLEVEL");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Messageseqno).HasColumnName("MESSAGESEQNO");
            entity.Property(e => e.Sortint1).HasColumnName("SORTINT1");
            entity.Property(e => e.Sortint3).HasColumnName("SORTINT3");
            entity.Property(e => e.Sortstr2)
                .HasMaxLength(255)
                .HasColumnName("SORTSTR2");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<O365GroupAssoc>(entity =>
        {
            entity.HasKey(e => new { e.Objectid, e.O365ObjectId });

            entity.ToTable("O365_GROUP_ASSOC");

            entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            entity.Property(e => e.O365ObjectId)
                .HasMaxLength(128)
                .HasColumnName("O365_OBJECT_ID");
            entity.Property(e => e.ExtendedData)
                .HasMaxLength(4000)
                .HasColumnName("EXTENDED_DATA");
            entity.Property(e => e.O365GroupId)
                .HasMaxLength(128)
                .HasColumnName("O365_GROUP_ID");
            entity.Property(e => e.O365ObjectType)
                .HasMaxLength(128)
                .HasColumnName("O365_OBJECT_TYPE");
            entity.Property(e => e.Status)
                .HasMaxLength(32)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<O365TeamshareChange>(entity =>
        {
            entity.HasKey(e => new { e.Tenant, e.Driveid, e.Itemid, e.Timestamp, e.Changetype });

            entity.ToTable("O365_TEAMSHARE_CHANGES");

            entity.Property(e => e.Tenant)
                .HasMaxLength(255)
                .HasColumnName("TENANT");
            entity.Property(e => e.Driveid)
                .HasMaxLength(128)
                .HasColumnName("DRIVEID");
            entity.Property(e => e.Itemid)
                .HasMaxLength(128)
                .HasColumnName("ITEMID");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
            entity.Property(e => e.Changetype)
                .HasMaxLength(32)
                .HasColumnName("CHANGETYPE");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(128)
                .HasColumnName("HASHCODE");
            entity.Property(e => e.Itemname)
                .HasMaxLength(255)
                .HasColumnName("ITEMNAME");
            entity.Property(e => e.Itempath)
                .HasMaxLength(4000)
                .HasColumnName("ITEMPATH");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(32)
                .HasColumnName("ITEMTYPE");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Parentitemid)
                .HasMaxLength(128)
                .HasColumnName("PARENTITEMID");
            entity.Property(e => e.Verifystatus)
                .HasMaxLength(32)
                .HasColumnName("VERIFYSTATUS");
        });

        modelBuilder.Entity<O365TeamshareChangescan>(entity =>
        {
            entity.HasKey(e => new { e.Tenant, e.Driveid, e.Itemid });

            entity.ToTable("O365_TEAMSHARE_CHANGESCAN");

            entity.Property(e => e.Tenant)
                .HasMaxLength(255)
                .HasColumnName("TENANT");
            entity.Property(e => e.Driveid)
                .HasMaxLength(128)
                .HasColumnName("DRIVEID");
            entity.Property(e => e.Itemid)
                .HasMaxLength(128)
                .HasColumnName("ITEMID");
            entity.Property(e => e.Channelid)
                .HasMaxLength(128)
                .HasColumnName("CHANNELID");
            entity.Property(e => e.Csnodeid).HasColumnName("CSNODEID");
            entity.Property(e => e.Deltatoken)
                .HasMaxLength(255)
                .HasColumnName("DELTATOKEN");
            entity.Property(e => e.Extradata)
                .HasMaxLength(4000)
                .HasColumnName("EXTRADATA");
            entity.Property(e => e.Failurecount).HasColumnName("FAILURECOUNT");
            entity.Property(e => e.Lastmodified).HasColumnName("LASTMODIFIED");
            entity.Property(e => e.Scanstatus).HasColumnName("SCANSTATUS");
            entity.Property(e => e.Subscriptionid)
                .HasMaxLength(255)
                .HasColumnName("SUBSCRIPTIONID");
            entity.Property(e => e.Teamid)
                .HasMaxLength(128)
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<O365TeamshareVersion>(entity =>
        {
            entity.HasKey(e => new { e.Tenant, e.Driveid, e.Itemid, e.Versionid });

            entity.ToTable("O365_TEAMSHARE_VERSIONS");

            entity.Property(e => e.Tenant)
                .HasMaxLength(255)
                .HasColumnName("TENANT");
            entity.Property(e => e.Driveid)
                .HasMaxLength(128)
                .HasColumnName("DRIVEID");
            entity.Property(e => e.Itemid)
                .HasMaxLength(128)
                .HasColumnName("ITEMID");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(128)
                .HasColumnName("HASHCODE");
            entity.Property(e => e.Versionlabel)
                .HasMaxLength(32)
                .HasColumnName("VERSIONLABEL");
        });

        modelBuilder.Entity<O365groupcreationqueue>(entity =>
        {
            entity.HasKey(e => e.Jobid);

            entity.ToTable("O365GROUPCREATIONQUEUE");

            entity.Property(e => e.Jobid)
                .ValueGeneratedNever()
                .HasColumnName("JOBID");
            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Details)
                .HasColumnType("NCLOB")
                .HasColumnName("DETAILS");
            entity.Property(e => e.Jobtype)
                .HasMaxLength(128)
                .HasColumnName("JOBTYPE");
            entity.Property(e => e.Lastruntimestamp).HasColumnName("LASTRUNTIMESTAMP");
            entity.Property(e => e.Status)
                .HasMaxLength(128)
                .HasColumnName("STATUS");
            entity.Property(e => e.Taskdata)
                .HasColumnType("NCLOB")
                .HasColumnName("TASKDATA");
        });

        modelBuilder.Entity<O365teamshareitemmap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("O365TEAMSHAREITEMMAP");

            entity.Property(e => e.Driveitemkey)
                .HasMaxLength(128)
                .HasColumnName("DRIVEITEMKEY");
            entity.Property(e => e.Drivekey)
                .HasMaxLength(128)
                .HasColumnName("DRIVEKEY");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(128)
                .HasColumnName("ITEMTYPE");
            entity.Property(e => e.Listitemkey).HasColumnName("LISTITEMKEY");
            entity.Property(e => e.Listkey)
                .HasMaxLength(128)
                .HasColumnName("LISTKEY");
            entity.Property(e => e.Parentdriveitemkey)
                .HasMaxLength(128)
                .HasColumnName("PARENTDRIVEITEMKEY");
            entity.Property(e => e.Sitekey)
                .HasMaxLength(255)
                .HasColumnName("SITEKEY");
            entity.Property(e => e.Tenant)
                .HasMaxLength(255)
                .HasColumnName("TENANT");
        });

        modelBuilder.Entity<O365teamsharemessage>(entity =>
        {
            entity.HasKey(e => e.Messagekey);
            entity.ToTable("O365TEAMSHAREMESSAGES");

            entity.Property(e => e.Failurecount).HasColumnName("FAILURECOUNT");
            entity.Property(e => e.Inserteddate).HasColumnName("INSERTEDDATE");
            entity.Property(e => e.Messagekey)
                .HasMaxLength(128)
                .HasColumnName("MESSAGEKEY");
            entity.Property(e => e.Messagetext)
                .HasMaxLength(4000)
                .HasColumnName("MESSAGETEXT");
        });

        modelBuilder.Entity<Models.Object>(entity =>
        {
            entity.HasKey(e => e.Object1);
            entity.ToTable("OBJECT");

            entity.Property(e => e.Object1)
                .HasMaxLength(32)
                .HasColumnName("OBJECT");
            entity.Property(e => e.ObjectColumns)
                .HasMaxLength(255)
                .HasColumnName("OBJECT_COLUMNS");
            entity.Property(e => e.ObjectDescE)
                .HasMaxLength(128)
                .HasColumnName("OBJECT_DESC_E");
            entity.Property(e => e.ObjectDescF)
                .HasMaxLength(128)
                .HasColumnName("OBJECT_DESC_F");
            entity.Property(e => e.Rimsformname)
                .HasMaxLength(128)
                .HasColumnName("RIMSFORMNAME");
        });

        modelBuilder.Entity<OiStatus>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("OI_STATUS");

            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImportFile)
                .HasMaxLength(4000)
                .HasColumnName("IMPORT_FILE");
            entity.Property(e => e.LogFile)
                .HasMaxLength(4000)
                .HasColumnName("LOG_FILE");
            entity.Property(e => e.NodesRead).HasColumnName("NODES_READ");
            entity.Property(e => e.ServerId)
                .HasMaxLength(1024)
                .HasColumnName("SERVER_ID");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TotalNodes).HasColumnName("TOTAL_NODES");
        });

        modelBuilder.Entity<Oldpassword>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("OLDPASSWORDS");

            entity.Property(e => e.Datechanged).HasColumnName("DATECHANGED");
            entity.Property(e => e.Lastchanged).HasColumnName("LASTCHANGED");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Userpwd)
                .HasMaxLength(255)
                .HasColumnName("USERPWD");
        });

        modelBuilder.Entity<Otdocumenthold>(entity =>
        {
            entity.HasKey(e => new { e.Holdid, e.Otitemid, e.Otvolumeid });
            entity.ToTable("OTDOCUMENTHOLD");

            entity.Property(e => e.Activehold).HasColumnName("ACTIVEHOLD");
            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Otitemid)
                .HasMaxLength(32)
                .HasColumnName("OTITEMID");
            entity.Property(e => e.Otvolumeid)
                .HasMaxLength(32)
                .HasColumnName("OTVOLUMEID");
        });

        modelBuilder.Entity<Otemailbody>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("OTEMAILBODIES");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Segmentdata)
                .HasColumnType("NCLOB")
                .HasColumnName("SEGMENTDATA");
            entity.Property(e => e.Segmentid).HasColumnName("SEGMENTID");
        });

        modelBuilder.Entity<Otemailconversationid>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("OTEMAILCONVERSATIONIDS");

            entity.Property(e => e.Conversationid)
                .HasMaxLength(255)
                .HasColumnName("CONVERSATIONID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<Otemailcustomproperty>(entity =>
        {
            entity.HasKey(e => new { e.Nodeid, e.Propertyname });
            entity.ToTable("OTEMAILCUSTOMPROPERTIES");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Propertyname)
                .HasMaxLength(255)
                .HasColumnName("PROPERTYNAME");
            entity.Property(e => e.Propertytype).HasColumnName("PROPERTYTYPE");
            entity.Property(e => e.Propertyvalue)
                .HasMaxLength(4000)
                .HasColumnName("PROPERTYVALUE");
        });

        modelBuilder.Entity<Otemaillocationmessageid>(entity =>
        {
            entity.HasKey(e => new { e.Locationnodeid, e.Messageid });
            entity.ToTable("OTEMAILLOCATIONMESSAGEIDS");

            entity.Property(e => e.Locationnodeid).HasColumnName("LOCATIONNODEID");
            entity.Property(e => e.Messageid)
                .HasMaxLength(32)
                .HasColumnName("MESSAGEID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<Otemaillocationmessageidsex>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("OTEMAILLOCATIONMESSAGEIDSEX");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Originalmessageid)
                .HasMaxLength(32)
                .HasColumnName("ORIGINALMESSAGEID");
        });

        modelBuilder.Entity<Otemailmessageid>(entity =>
        {
            entity.HasKey(e => e.Messageid);
            entity.ToTable("OTEMAILMESSAGEIDS");

            entity.Property(e => e.Messageid)
                .HasMaxLength(128)
                .HasColumnName("MESSAGEID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<Otemailparticipant>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("OTEMAILPARTICIPANTS");

            entity.Property(e => e.Emailaddress)
                .HasMaxLength(255)
                .HasColumnName("EMAILADDRESS");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Participantrole).HasColumnName("PARTICIPANTROLE");
            entity.Property(e => e.Participanttype).HasColumnName("PARTICIPANTTYPE");
            entity.Property(e => e.Systemprovided).HasColumnName("SYSTEMPROVIDED");
        });

        modelBuilder.Entity<Otemailproperty>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("OTEMAILPROPERTIES");

            entity.Property(e => e.Bodyformat).HasColumnName("BODYFORMAT");
            entity.Property(e => e.Hasattachments).HasColumnName("HASATTACHMENTS");
            entity.Property(e => e.Inserttype).HasColumnName("INSERTTYPE");
            entity.Property(e => e.Messageid)
                .HasMaxLength(255)
                .HasColumnName("MESSAGEID");
            entity.Property(e => e.Messagetype).HasColumnName("MESSAGETYPE");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Otemailbcc)
                .HasMaxLength(4000)
                .HasColumnName("OTEMAILBCC");
            entity.Property(e => e.Otemailcc)
                .HasMaxLength(4000)
                .HasColumnName("OTEMAILCC");
            entity.Property(e => e.Otemailfrom)
                .HasMaxLength(255)
                .HasColumnName("OTEMAILFROM");
            entity.Property(e => e.Otemailonbehalfof)
                .HasMaxLength(255)
                .HasColumnName("OTEMAILONBEHALFOF");
            entity.Property(e => e.Otemailreceiveddate).HasColumnName("OTEMAILRECEIVEDDATE");
            entity.Property(e => e.Otemailsentdate).HasColumnName("OTEMAILSENTDATE");
            entity.Property(e => e.Otemailsubject)
                .HasMaxLength(255)
                .HasColumnName("OTEMAILSUBJECT");
            entity.Property(e => e.Otemailto)
                .HasMaxLength(4000)
                .HasColumnName("OTEMAILTO");
            entity.Property(e => e.Signedencrypted).HasColumnName("SIGNEDENCRYPTED");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<OthcmActLog>(entity =>
        {
            entity.HasKey(e => new { e.Bwsnodeid, e.Childnodeid });

            entity.ToTable("OTHCM_ACT_LOG");

            entity.Property(e => e.Bwsnodeid).HasColumnName("BWSNODEID");
            entity.Property(e => e.Childnodeid).HasColumnName("CHILDNODEID");
            entity.Property(e => e.Activitytype)
                .HasMaxLength(64)
                .HasColumnName("ACTIVITYTYPE");
            entity.Property(e => e.Classnodeid).HasColumnName("CLASSNODEID");
            entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");
            entity.Property(e => e.CreatedUser).HasColumnName("CREATED_USER");
            entity.Property(e => e.Deleted)
                .HasMaxLength(64)
                .HasColumnName("DELETED");
            entity.Property(e => e.Documentname)
                .HasMaxLength(248)
                .HasColumnName("DOCUMENTNAME");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.Tmpnodeid).HasColumnName("TMPNODEID");
            entity.Property(e => e.Workflownodeid).HasColumnName("WORKFLOWNODEID");
        });

        modelBuilder.Entity<OthcmCmisDeletedDoc>(entity =>
        {
            entity.HasKey(e => e.Dataid);

            entity.ToTable("OTHCM_CMIS_DELETED_DOCS");

            entity.Property(e => e.Dataid)
                .ValueGeneratedNever()
                .HasColumnName("DATAID");
            entity.Property(e => e.LinkTypeId)
                .HasColumnType("INTEGER")
                .HasColumnName("LINK_TYPE_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.RetryCount)
                .HasColumnType("INTEGER")
                .HasColumnName("RETRY_COUNT");
            entity.Property(e => e.SfsfLinkDeleted).HasColumnName("SFSF_LINK_DELETED");
            entity.Property(e => e.SrcId).HasColumnName("SRC_ID");
        });

        modelBuilder.Entity<OthcmCustomization>(entity =>
        {
            entity.HasKey(e => e.CustomizationType);

            entity.ToTable("OTHCM_CUSTOMIZATIONS");

            entity.Property(e => e.CustomizationType)
                .HasMaxLength(64)
                .HasColumnName("CUSTOMIZATION_TYPE");
            entity.Property(e => e.CustomizationValues)
                .HasMaxLength(1024)
                .HasColumnName("CUSTOMIZATION_VALUES");
        });

        modelBuilder.Entity<OthcmCustomizationsExtn>(entity =>
        {
            entity.HasKey(e => e.CustomizationType);

            entity.ToTable("OTHCM_CUSTOMIZATIONS_EXTN");

            entity.Property(e => e.CustomizationType)
                .HasMaxLength(64)
                .HasColumnName("CUSTOMIZATION_TYPE");
            entity.Property(e => e.CustomizationValues)
                .HasColumnType("NCLOB")
                .HasColumnName("CUSTOMIZATION_VALUES");
        });

        modelBuilder.Entity<OthcmDocumentType>(entity =>
        {
            entity.HasKey(e => new { e.Ddataid, e.Cdataid, e.Location });

            entity.ToTable("OTHCM_DOCUMENT_TYPES");

            entity.Property(e => e.Ddataid).HasColumnName("DDATAID");
            entity.Property(e => e.Cdataid).HasColumnName("CDATAID");
            entity.Property(e => e.Location)
                .HasMaxLength(1024)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Rstype).HasColumnName("RSTYPE");
            entity.Property(e => e.Trequired).HasColumnName("TREQUIRED");
            entity.Property(e => e.Valid).HasColumnName("VALID");
        });

        modelBuilder.Entity<OthcmGroup>(entity =>
        {
            entity.HasKey(e => e.SfGroupName);
            entity.ToTable("OTHCM_GROUP");

            entity.Property(e => e.SfGroupId).HasColumnName("SF_GROUP_ID");
            entity.Property(e => e.SfGroupName)
                .HasMaxLength(255)
                .HasColumnName("SF_GROUP_NAME");
        });

        modelBuilder.Entity<OthcmGroupUser>(entity =>
        {
            entity.HasKey(e => e.SfUserId);
            entity.ToTable("OTHCM_GROUP_USERS");

            entity.Property(e => e.SfGroupId).HasColumnName("SF_GROUP_ID");
            entity.Property(e => e.SfUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_USER_ID");
        });

        modelBuilder.Entity<OthcmHrFuncRightNodeid>(entity =>
        {
            entity.HasKey(e => e.RightId);

            entity.ToTable("OTHCM_HR_FUNC_RIGHT_NODEID");

            entity.Property(e => e.RightId)
                .HasMaxLength(248)
                .HasColumnName("RIGHT_ID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<OthcmHrFuncRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCM_HR_FUNC_ROLES");

            entity.Property(e => e.HrFuncNodeid).HasColumnName("HR_FUNC_NODEID");
            entity.Property(e => e.SfRoles)
                .HasMaxLength(248)
                .HasColumnName("SF_ROLES");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<OthcmInbox>(entity =>
        {
            entity.HasKey(e => e.Ticketno);
            entity.ToTable("OTHCM_INBOX");

            entity.Property(e => e.AssignedName)
                .HasMaxLength(64)
                .HasColumnName("ASSIGNED_NAME");
            entity.Property(e => e.AssignedTo)
                .HasMaxLength(64)
                .HasColumnName("ASSIGNED_TO");
            entity.Property(e => e.Bwsnodeid).HasColumnName("BWSNODEID");
            entity.Property(e => e.Channel)
                .HasMaxLength(64)
                .HasColumnName("CHANNEL");
            entity.Property(e => e.Classnodeid).HasColumnName("CLASSNODEID");
            entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");
            entity.Property(e => e.CreatedUser).HasColumnName("CREATED_USER");
            entity.Property(e => e.DateOfOrigin).HasColumnName("DATE_OF_ORIGIN");
            entity.Property(e => e.Docnodeid).HasColumnName("DOCNODEID");
            entity.Property(e => e.HrAdmin).HasColumnName("HR_ADMIN");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Tcomment)
                .HasMaxLength(1024)
                .HasColumnName("TCOMMENT");
            entity.Property(e => e.Ticketno).HasColumnName("TICKETNO");
            entity.Property(e => e.Tmpnodeid).HasColumnName("TMPNODEID");
        });

        modelBuilder.Entity<OthcmInboxLog>(entity =>
        {
            entity.HasKey(e => new { e.Ticketno, e.Seqno });

            entity.ToTable("OTHCM_INBOX_LOG");

            entity.Property(e => e.Ticketno).HasColumnName("TICKETNO");
            entity.Property(e => e.Seqno).HasColumnName("SEQNO");
            entity.Property(e => e.AssignedName)
                .HasMaxLength(64)
                .HasColumnName("ASSIGNED_NAME");
            entity.Property(e => e.AssignedTo)
                .HasMaxLength(64)
                .HasColumnName("ASSIGNED_TO");
            entity.Property(e => e.Classnodeid).HasColumnName("CLASSNODEID");
            entity.Property(e => e.HrAdmin).HasColumnName("HR_ADMIN");
            entity.Property(e => e.LoggedinUserId).HasColumnName("LOGGEDIN_USER_ID");
            entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.ModifiedUser).HasColumnName("MODIFIED_USER");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.Tcomment)
                .HasMaxLength(1024)
                .HasColumnName("TCOMMENT");
        });

        modelBuilder.Entity<OthcmJobRelationship>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCM_JOB_RELATIONSHIP");

            entity.Property(e => e.RelationRole)
                .HasMaxLength(64)
                .HasColumnName("RELATION_ROLE");
            entity.Property(e => e.SfMgrUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_MGR_USER_ID");
            entity.Property(e => e.SfUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_USER_ID");
        });

        modelBuilder.Entity<OthcmMissingUser>(entity =>
        {
            entity.HasKey(e => e.CsUserName);
            entity.ToTable("OTHCM_MISSING_USERS");

            entity.Property(e => e.CsUserName)
                .HasMaxLength(255)
                .HasColumnName("CS_USER_NAME");
            entity.Property(e => e.SfGroupName)
                .HasMaxLength(255)
                .HasColumnName("SF_GROUP_NAME");
            entity.Property(e => e.SfUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_USER_ID");
        });

        modelBuilder.Entity<OthcmModifiedEntity>(entity =>
        {
            entity.HasKey(e => new { e.EntityId, e.EntityType });

            entity.ToTable("OTHCM_MODIFIED_ENTITIES");

            entity.Property(e => e.EntityId)
                .HasMaxLength(255)
                .HasColumnName("ENTITY_ID");
            entity.Property(e => e.EntityType).HasColumnName("ENTITY_TYPE");
            entity.Property(e => e.ModifyDate).HasColumnName("MODIFY_DATE");
        });

        modelBuilder.Entity<OthcmProxyUserAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCM_PROXY_USER_AUDIT");

            entity.Property(e => e.EventId).HasColumnName("EVENT_ID");
            entity.Property(e => e.LoggedinUserId).HasColumnName("LOGGEDIN_USER_ID");
            entity.Property(e => e.ProxyUserId).HasColumnName("PROXY_USER_ID");
        });

        modelBuilder.Entity<OthcmRegionCountryMapping>(entity =>
        {
            entity.HasKey(e => new { e.RegionName, e.CountryName });

            entity.ToTable("OTHCM_REGION_COUNTRY_MAPPINGS");

            entity.Property(e => e.RegionName)
                .HasMaxLength(64)
                .HasColumnName("REGION_NAME");
            entity.Property(e => e.CountryName)
                .HasMaxLength(1024)
                .HasColumnName("COUNTRY_NAME");
        });

        modelBuilder.Entity<OthcmRegionDocTempMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCM_REGION_DOC_TEMP_MAPPINGS");

            entity.Property(e => e.BoObjType)
                .HasMaxLength(64)
                .HasColumnName("BO_OBJ_TYPE");
            entity.Property(e => e.DocTemplId).HasColumnName("DOC_TEMPL_ID");
            entity.Property(e => e.RegionName)
                .HasMaxLength(64)
                .HasColumnName("REGION_NAME");
        });

        modelBuilder.Entity<OthcmRule>(entity =>
        {
            entity.HasKey(e => new { e.RoleName, e.RuleId });

            entity.ToTable("OTHCM_RULES");

            entity.Property(e => e.RoleName)
                .HasMaxLength(64)
                .HasColumnName("ROLE_NAME");
            entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
            entity.Property(e => e.ExcludeSelf)
                .HasMaxLength(64)
                .HasColumnName("EXCLUDE_SELF");
            entity.Property(e => e.MyFilter)
                .HasMaxLength(64)
                .HasColumnName("MY_FILTER");
            entity.Property(e => e.RelationRole)
                .HasMaxLength(64)
                .HasColumnName("RELATION_ROLE");
            entity.Property(e => e.Status)
                .HasMaxLength(64)
                .HasColumnName("STATUS");
            entity.Property(e => e.TargetGroupLevel)
                .HasMaxLength(64)
                .HasColumnName("TARGET_GROUP_LEVEL");
        });

        modelBuilder.Entity<OthcmRulesGpGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCM_RULES_GP_GROUPS");

            entity.Property(e => e.GroupName)
                .HasMaxLength(4000)
                .HasColumnName("GROUP_NAME");
            entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
        });

        modelBuilder.Entity<OthcmRulesTpGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCM_RULES_TP_GROUPS");

            entity.Property(e => e.GroupName)
                .HasMaxLength(4000)
                .HasColumnName("GROUP_NAME");
            entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
        });

        modelBuilder.Entity<OthcmTemplateMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCM_TEMPLATE_MAPPING");

            entity.Property(e => e.DocTemplId).HasColumnName("DOC_TEMPL_ID");
            entity.Property(e => e.IdBoType).HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Ruledata)
                .HasColumnType("NCLOB")
                .HasColumnName("RULEDATA");
            entity.Property(e => e.Ruleexp)
                .HasColumnType("NCLOB")
                .HasColumnName("RULEEXP");
        });

        modelBuilder.Entity<OthcmUserManager>(entity =>
        {
            entity.HasKey(e => e.SfUserId);

            entity.ToTable("OTHCM_USER_MANAGER");

            entity.Property(e => e.SfUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_USER_ID");
            entity.Property(e => e.SfMgrUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_MGR_USER_ID");
            entity.Property(e => e.SfPersonId)
                .HasMaxLength(255)
                .HasColumnName("SF_PERSON_ID");
            entity.Property(e => e.SfPrimaryAccount).HasColumnName("SF_PRIMARY_ACCOUNT");
            entity.Property(e => e.SfUserName)
                .HasMaxLength(255)
                .HasColumnName("SF_USER_NAME");
            entity.Property(e => e.SfUserStatus)
                .HasMaxLength(32)
                .HasColumnName("SF_USER_STATUS");
        });

        modelBuilder.Entity<OthcmUserMyfilter>(entity =>
        {
            entity.HasKey(e => e.SfUserId);
            entity.ToTable("OTHCM_USER_MYFILTER");

            entity.Property(e => e.MyFilter)
                .HasMaxLength(255)
                .HasColumnName("MY_FILTER");
            entity.Property(e => e.SfUserId)
                .HasMaxLength(255)
                .HasColumnName("SF_USER_ID");
            entity.Property(e => e.Value)
                .HasMaxLength(4000)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Othcminactiveworkspaceinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTHCMINACTIVEWORKSPACEINFO");

            entity.Property(e => e.Processeddate).HasColumnName("PROCESSEDDATE");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<OtsapAttributeSchema>(entity =>
        {
            entity.HasKey(e => e.Idschema);
            entity.ToTable("OTSAP_ATTRIBUTE_SCHEMAS");

            entity.Property(e => e.Attrid)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRID");
            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Idschema)
                .HasMaxLength(248)
                .HasColumnName("IDSCHEMA");
            entity.Property(e => e.Maxcounter).HasColumnName("MAXCOUNTER");
            entity.Property(e => e.Wksptype)
                .HasColumnType("INTEGER")
                .HasColumnName("WKSPTYPE");
        });

        modelBuilder.Entity<OtsapBoType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OTSAP_BO_TYPES");

            entity.Property(e => e.AutoKeydef)
                .HasMaxLength(248)
                .HasColumnName("AUTO_KEYDEF");
            entity.Property(e => e.BadiBeforeAdd)
                .HasColumnType("INTEGER")
                .HasColumnName("BADI_BEFORE_ADD");
            entity.Property(e => e.BadiBeforeDel)
                .HasColumnType("INTEGER")
                .HasColumnName("BADI_BEFORE_DEL");
            entity.Property(e => e.BoTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("BO_TYPE_DELETED");
            entity.Property(e => e.BoTypeName)
                .HasMaxLength(248)
                .HasColumnName("BO_TYPE_NAME");
            entity.Property(e => e.BoTypeNodeId).HasColumnName("BO_TYPE_NODE_ID");
            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.BusrefName)
                .HasMaxLength(248)
                .HasColumnName("BUSREF_NAME");
            entity.Property(e => e.DisplayUrl)
                .HasColumnType("NCLOB")
                .HasColumnName("DISPLAY_URL");
            entity.Property(e => e.EnableAutoAddBo)
                .HasColumnType("INTEGER")
                .HasColumnName("ENABLE_AUTO_ADD_BO");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");
            entity.Property(e => e.IsDefaultDisplay)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_DISPLAY");
            entity.Property(e => e.IsDefaultSearch)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_SEARCH");
            entity.Property(e => e.MetaDataMapping)
                .HasColumnType("INTEGER")
                .HasColumnName("META_DATA_MAPPING");
            entity.Property(e => e.TriggerAttr)
                .HasColumnType("INTEGER")
                .HasColumnName("TRIGGER_ATTR");
            entity.Property(e => e.TriggerCat).HasColumnName("TRIGGER_CAT");
            entity.Property(e => e.UseForBusref)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_FOR_BUSREF");
            entity.Property(e => e.UseForBuswksp)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_FOR_BUSWKSP");
        });

        modelBuilder.Entity<OtsapBoTypesCbSetting>(entity =>
        {
            entity.HasKey(e => new { e.IdBoType, e.CbUsage });
            entity.ToTable("OTSAP_BO_TYPES_CB_SETTINGS");

            entity.Property(e => e.CbMultival).HasColumnName("CB_MULTIVAL");
            entity.Property(e => e.CbName)
                .HasMaxLength(64)
                .HasColumnName("CB_NAME");
            entity.Property(e => e.CbParm)
                .HasColumnType("NCLOB")
                .HasColumnName("CB_PARM");
            entity.Property(e => e.CbUsage)
                .HasMaxLength(64)
                .HasColumnName("CB_USAGE");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany()
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapBoTypesCore>(entity =>
        {
            entity.HasKey(e => e.IdBoType);

            entity.ToTable("OTSAP_BO_TYPES_CORE");

            entity.Property(e => e.IdBoType)
                .ValueGeneratedNever()
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.AutoKeydef)
                .HasMaxLength(248)
                .HasColumnName("AUTO_KEYDEF");
            entity.Property(e => e.BadiBeforeAdd)
                .HasColumnType("INTEGER")
                .HasColumnName("BADI_BEFORE_ADD");
            entity.Property(e => e.BadiBeforeDel)
                .HasColumnType("INTEGER")
                .HasColumnName("BADI_BEFORE_DEL");
            entity.Property(e => e.BoTypeDeleted)
                .HasColumnType("INTEGER")
                .HasColumnName("BO_TYPE_DELETED");
            entity.Property(e => e.BoTypeNodeId).HasColumnName("BO_TYPE_NODE_ID");
            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.BusrefName)
                .HasMaxLength(248)
                .HasColumnName("BUSREF_NAME");
            entity.Property(e => e.DisplayUrl)
                .HasColumnType("NCLOB")
                .HasColumnName("DISPLAY_URL");
            entity.Property(e => e.EnableAutoAddBo)
                .HasColumnType("INTEGER")
                .HasColumnName("ENABLE_AUTO_ADD_BO");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");
            entity.Property(e => e.IsDefaultDisplay)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_DISPLAY");
            entity.Property(e => e.IsDefaultSearch)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_DEFAULT_SEARCH");
            entity.Property(e => e.MetaDataMapping)
                .HasColumnType("INTEGER")
                .HasColumnName("META_DATA_MAPPING");
            entity.Property(e => e.TriggerAttr)
                .HasColumnType("INTEGER")
                .HasColumnName("TRIGGER_ATTR");
            entity.Property(e => e.TriggerCat).HasColumnName("TRIGGER_CAT");
            entity.Property(e => e.UseForBusref)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_FOR_BUSREF");
            entity.Property(e => e.UseForBuswksp)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_FOR_BUSWKSP");

            entity.HasOne(d => d.IdExtsystemNavigation).WithMany(p => p.OtsapBoTypesCores)
                .HasForeignKey(d => d.IdExtsystem)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.IdReferenceTypeNavigation).WithMany(p => p.OtsapBoTypesCores)
                .HasForeignKey(d => d.IdReferenceType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapBoTypesDocType>(entity =>
        {
            entity.HasKey(e => new { e.IdBoType, e.DocType });

            entity.ToTable("OTSAP_BO_TYPES_DOC_TYPES");

            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.DocType)
                .HasMaxLength(255)
                .HasColumnName("DOC_TYPE");
            entity.Property(e => e.IdDeclarationType).HasColumnName("ID_DECLARATION_TYPE");
            entity.Property(e => e.IsBusinessAttachment)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_BUSINESS_ATTACHMENT");
        });

        modelBuilder.Entity<OtsapBoTypesMultilingual>(entity =>
        {
            entity.HasKey(e => new { e.IdBoType, e.LangCode, e.PropType });
            entity.ToTable("OTSAP_BO_TYPES_MULTILINGUALS");

            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.LangCode)
                .HasMaxLength(6)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.PropType)
                .HasMaxLength(32)
                .HasColumnName("PROP_TYPE");
            entity.Property(e => e.PropValue)
                .HasMaxLength(1024)
                .HasColumnName("PROP_VALUE");
        });

        modelBuilder.Entity<OtsapBoTypesPropMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTSAP_BO_TYPES_PROP_MAPS");

            entity.Property(e => e.AttName)
                .HasMaxLength(64)
                .HasColumnName("ATT_NAME");
            entity.Property(e => e.BoPropName)
                .HasMaxLength(64)
                .HasColumnName("BO_PROP_NAME");
            entity.Property(e => e.CatCbName)
                .HasMaxLength(64)
                .HasColumnName("CAT_CB_NAME");
            entity.Property(e => e.CatCbParm)
                .HasColumnType("NCLOB")
                .HasColumnName("CAT_CB_PARM");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.SetName)
                .HasMaxLength(64)
                .HasColumnName("SET_NAME");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany()
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapBoTypesPropgroup>(entity =>
        {
            entity.HasKey(e => e.IdCfg);

            entity.ToTable("OTSAP_BO_TYPES_PROPGROUPS");

            entity.Property(e => e.IdCfg)
                .ValueGeneratedNever()
                .HasColumnType("INTEGER")
                .HasColumnName("ID_CFG");
            entity.Property(e => e.BoPropGroupName)
                .HasMaxLength(64)
                .HasColumnName("BO_PROP_GROUP_NAME");
            entity.Property(e => e.CatCbName)
                .HasMaxLength(64)
                .HasColumnName("CAT_CB_NAME");
            entity.Property(e => e.CatCbParm)
                .HasColumnType("NCLOB")
                .HasColumnName("CAT_CB_PARM");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.SetName)
                .HasMaxLength(64)
                .HasColumnName("SET_NAME");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany(p => p.OtsapBoTypesPropgroups)
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapBoTypesPropgroupMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTSAP_BO_TYPES_PROPGROUP_MAPS");

            entity.Property(e => e.AttName)
                .HasMaxLength(64)
                .HasColumnName("ATT_NAME");
            entity.Property(e => e.BoPropName)
                .HasMaxLength(64)
                .HasColumnName("BO_PROP_NAME");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.IdGroupCfg)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_GROUP_CFG");

            entity.HasOne(d => d.IdGroupCfgNavigation).WithMany()
                .HasForeignKey(d => d.IdGroupCfg)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapCbMultiValue>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Ordering });

            entity.ToTable("OTSAP_CB_MULTI_VALUES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Name)
                .HasColumnType("NCLOB")
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<OtsapEventRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTSAP_EVENT_RECORDS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.EventDate).HasColumnName("EVENT_DATE");
            entity.Property(e => e.EventType)
                .HasColumnType("INTEGER")
                .HasColumnName("EVENT_TYPE");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Subscriber)
                .HasMaxLength(128)
                .HasColumnName("SUBSCRIBER");
        });

        modelBuilder.Entity<OtsapEventSubscription>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Subscriber });
            entity.ToTable("OTSAP_EVENT_SUBSCRIPTIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Subscriber)
                .HasMaxLength(128)
                .HasColumnName("SUBSCRIBER");
        });

        modelBuilder.Entity<OtsapExtSystem>(entity =>
        {
            entity.HasKey(e => e.IdExtsystem);

            entity.ToTable("OTSAP_EXT_SYSTEMS");

            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.Asurl)
                .HasMaxLength(248)
                .HasColumnName("ASURL");
            entity.Property(e => e.AsurlV4)
                .HasMaxLength(248)
                .HasColumnName("ASURL_V4");
            entity.Property(e => e.AuthMethod)
                .HasMaxLength(32)
                .HasColumnName("AUTH_METHOD");
            entity.Property(e => e.Baseurl)
                .HasMaxLength(248)
                .HasColumnName("BASEURL");
            entity.Property(e => e.ClassName)
                .HasMaxLength(248)
                .HasColumnName("CLASS_NAME");
            entity.Property(e => e.ClientId)
                .HasMaxLength(248)
                .HasColumnName("CLIENT_ID");
            entity.Property(e => e.CmisRootFolder).HasColumnName("CMIS_ROOT_FOLDER");
            entity.Property(e => e.ConnType)
                .HasMaxLength(32)
                .HasColumnName("CONN_TYPE");
            entity.Property(e => e.Enabled)
                .HasColumnType("INTEGER")
                .HasColumnName("ENABLED");
            entity.Property(e => e.ExtsystemNodeId).HasColumnName("EXTSYSTEM_NODE_ID");
            entity.Property(e => e.SchemaVersion)
                .HasColumnType("INTEGER")
                .HasColumnName("SCHEMA_VERSION");
            entity.Property(e => e.SystemComment)
                .HasMaxLength(128)
                .HasColumnName("SYSTEM_COMMENT");
            entity.Property(e => e.TokenEndpoint)
                .HasMaxLength(248)
                .HasColumnName("TOKEN_ENDPOINT");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<OtsapExtSystemsMultilingual>(entity =>
        {
            entity.HasKey(e => new { e.IdExtsystem, e.LangCode, e.PropType });
            entity.ToTable("OTSAP_EXT_SYSTEMS_MULTILINGUAL");

            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.LangCode)
                .HasMaxLength(6)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.PropType)
                .HasMaxLength(32)
                .HasColumnName("PROP_TYPE");
            entity.Property(e => e.PropValue)
                .HasMaxLength(1024)
                .HasColumnName("PROP_VALUE");
        });

        modelBuilder.Entity<OtsapIndexableSubtype>(entity =>
        {
            entity.HasKey(e => new { e.Subtype, e.IdReferenceType });

            entity.ToTable("OTSAP_INDEXABLE_SUBTYPES");

            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");
        });

        modelBuilder.Entity<OtsapManagedObjectType>(entity =>
        {
            entity.HasKey(e => new { e.ManagedObjectTypeId, e.IdBoType });

            entity.ToTable("OTSAP_MANAGED_OBJECT_TYPES");

            entity.Property(e => e.ManagedObjectTypeId)
                .HasColumnType("INTEGER")
                .HasColumnName("MANAGED_OBJECT_TYPE_ID");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
        });

        modelBuilder.Entity<OtsapPoliciesUsr>(entity =>
        {
            entity.HasKey(e => new { e.PolicyId, e.Usr, e.ValidFrom, e.ValidTo });
            entity.ToTable("OTSAP_POLICIES_USR");

            entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");
            entity.Property(e => e.Usr).HasColumnName("USR");
            entity.Property(e => e.ValidFrom)
                .HasMaxLength(32)
                .HasColumnName("VALID_FROM");
            entity.Property(e => e.ValidTo)
                .HasMaxLength(32)
                .HasColumnName("VALID_TO");

            entity.HasOne(d => d.Policy).WithMany()
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapPolicy>(entity =>
        {
            entity.HasKey(e => e.Dataid);

            entity.ToTable("OTSAP_POLICIES");

            entity.Property(e => e.Dataid)
                .ValueGeneratedNever()
                .HasColumnName("DATAID");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.Profile)
                .HasMaxLength(32)
                .HasColumnName("PROFILE");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany(p => p.OtsapPolicies)
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapRefType>(entity =>
        {
            entity.HasKey(e => e.IdReferenceType);

            entity.ToTable("OTSAP_REF_TYPES");

            entity.Property(e => e.IdReferenceType)
                .ValueGeneratedNever()
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");
            entity.Property(e => e.AviatorEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("AVIATOR_ENABLED");
            entity.Property(e => e.ConfigNodeId).HasColumnName("CONFIG_NODE_ID");
            entity.Property(e => e.CopyDisabled)
                .HasColumnType("INTEGER")
                .HasColumnName("COPY_DISABLED");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.GenerateNameEarly)
                .HasColumnType("INTEGER")
                .HasColumnName("GENERATE_NAME_EARLY");
            entity.Property(e => e.IndexingEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("INDEXING_ENABLED");
            entity.Property(e => e.RmEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("RM_ENABLED");
            entity.Property(e => e.UseBulkapi)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_BULKAPI");
            entity.Property(e => e.UseLocationManual)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_LOCATION_MANUAL");
            entity.Property(e => e.WidgetImgDataid).HasColumnName("WIDGET_IMG_DATAID");
            entity.Property(e => e.WkspIcon)
                .HasMaxLength(248)
                .HasColumnName("WKSP_ICON");
            entity.Property(e => e.WkspPolEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("WKSP_POL_ENABLED");
        });

        modelBuilder.Entity<OtsapRefTypesCbSetting>(entity =>
        {
            entity.HasKey(e => new { e.IdReferenceType, e.CbUsage });
            entity.ToTable("OTSAP_REF_TYPES_CB_SETTINGS");

            entity.Property(e => e.CbName)
                .HasMaxLength(64)
                .HasColumnName("CB_NAME");
            entity.Property(e => e.CbParm)
                .HasColumnType("NCLOB")
                .HasColumnName("CB_PARM");
            entity.Property(e => e.CbUsage)
                .HasMaxLength(64)
                .HasColumnName("CB_USAGE");
            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");

            entity.HasOne(d => d.IdReferenceTypeNavigation).WithMany()
                .HasForeignKey(d => d.IdReferenceType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapRefTypesMultilingual>(entity =>
        {
            entity.HasKey(e => new { e.IdReferenceType, e.LangCode, e.PropType });
            entity.ToTable("OTSAP_REF_TYPES_MULTILINGUALS");

            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");
            entity.Property(e => e.LangCode)
                .HasMaxLength(6)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.PropType)
                .HasMaxLength(32)
                .HasColumnName("PROP_TYPE");
            entity.Property(e => e.PropValue)
                .HasMaxLength(1024)
                .HasColumnName("PROP_VALUE");
        });

        modelBuilder.Entity<OtsapReferenceType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OTSAP_REFERENCE_TYPES");

            entity.Property(e => e.AviatorEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("AVIATOR_ENABLED");
            entity.Property(e => e.ConfigNodeId).HasColumnName("CONFIG_NODE_ID");
            entity.Property(e => e.CopyDisabled)
                .HasColumnType("INTEGER")
                .HasColumnName("COPY_DISABLED");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.GenerateNameEarly)
                .HasColumnType("INTEGER")
                .HasColumnName("GENERATE_NAME_EARLY");
            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");
            entity.Property(e => e.IndexingEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("INDEXING_ENABLED");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.RmEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("RM_ENABLED");
            entity.Property(e => e.UseBulkapi)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_BULKAPI");
            entity.Property(e => e.UseLocationManual)
                .HasColumnType("INTEGER")
                .HasColumnName("USE_LOCATION_MANUAL");
            entity.Property(e => e.WkspIcon)
                .HasMaxLength(248)
                .HasColumnName("WKSP_ICON");
            entity.Property(e => e.WkspPolEnabled)
                .HasColumnType("INTEGER")
                .HasColumnName("WKSP_POL_ENABLED");
        });

        modelBuilder.Entity<OtsapSotType>(entity =>
        {
            entity.HasKey(e => e.IdBoType);

            entity.ToTable("OTSAP_SOT_TYPES");

            entity.Property(e => e.IdBoType)
                .ValueGeneratedNever()
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.SotType)
                .HasMaxLength(128)
                .HasColumnName("SOT_TYPE");
        });

        modelBuilder.Entity<OtsapUniqueName>(entity =>
        {
            entity.HasKey(e => e.UniqueName);

            entity.ToTable("OTSAP_UNIQUE_NAMES");

            entity.Property(e => e.UniqueName)
                .HasMaxLength(64)
                .HasColumnName("UNIQUE_NAME");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.UniqueNameNodeId).HasColumnName("UNIQUE_NAME_NODE_ID");
        });

        modelBuilder.Entity<OtsapWkspAllRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OTSAP_WKSP_ALL_RELATIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.RelatedDataId).HasColumnName("RELATED_DATA_ID");
            entity.Property(e => e.RelatedWkspTypeId).HasColumnName("RELATED_WKSP_TYPE_ID");
        });

        modelBuilder.Entity<OtsapWkspChildRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OTSAP_WKSP_CHILD_RELATIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.RelatedDataId).HasColumnName("RELATED_DATA_ID");
            entity.Property(e => e.RelatedWkspTypeId).HasColumnName("RELATED_WKSP_TYPE_ID");
        });

        modelBuilder.Entity<OtsapWkspParentRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OTSAP_WKSP_PARENT_RELATIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.RelatedDataId).HasColumnName("RELATED_DATA_ID");
            entity.Property(e => e.RelatedWkspTypeId).HasColumnName("RELATED_WKSP_TYPE_ID");
        });

        modelBuilder.Entity<OtsapWkspRelation>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.RelatedDataid });
            entity.ToTable("OTSAP_WKSP_RELATIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.IdWkspType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_WKSP_TYPE");
            entity.Property(e => e.RelatedDataid).HasColumnName("RELATED_DATAID");
            entity.Property(e => e.RelatedIdWkspType)
                .HasColumnType("INTEGER")
                .HasColumnName("RELATED_ID_WKSP_TYPE");

            entity.HasOne(d => d.IdWkspTypeNavigation).WithMany()
                .HasForeignKey(d => d.IdWkspType)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RelatedIdWkspTypeNavigation).WithMany()
                .HasForeignKey(d => d.RelatedIdWkspType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapactSystem>(entity =>
        {
            entity.HasKey(e => e.IdCfg);

            entity.ToTable("OTSAPACT_SYSTEMS");

            entity.Property(e => e.IdCfg)
                .HasMaxLength(32)
                .HasColumnName("ID_CFG");
            entity.Property(e => e.Ashost)
                .HasMaxLength(248)
                .HasColumnName("ASHOST");
            entity.Property(e => e.Baseurl)
                .HasMaxLength(248)
                .HasColumnName("BASEURL");
            entity.Property(e => e.Client)
                .HasMaxLength(32)
                .HasColumnName("CLIENT");
            entity.Property(e => e.Dest)
                .HasMaxLength(32)
                .HasColumnName("DEST");
            entity.Property(e => e.Groupname)
                .HasMaxLength(248)
                .HasColumnName("GROUPNAME");
            entity.Property(e => e.ModifyDate).HasColumnName("MODIFY_DATE");
            entity.Property(e => e.Mshost)
                .HasMaxLength(248)
                .HasColumnName("MSHOST");
            entity.Property(e => e.Sapsystemid)
                .HasMaxLength(32)
                .HasColumnName("SAPSYSTEMID");
            entity.Property(e => e.SncEnabled).HasColumnName("SNC_ENABLED");
            entity.Property(e => e.SncMyname)
                .HasMaxLength(248)
                .HasColumnName("SNC_MYNAME");
            entity.Property(e => e.SncPartnername)
                .HasMaxLength(248)
                .HasColumnName("SNC_PARTNERNAME");
            entity.Property(e => e.SncPse)
                .HasColumnType("NCLOB")
                .HasColumnName("SNC_PSE");
            entity.Property(e => e.Sysnr)
                .HasMaxLength(32)
                .HasColumnName("SYSNR");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("TYPE");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<OtsapactSystemsEnabled>(entity =>
        {
            entity.HasKey(e => new { e.Client, e.Sapsystemid });

            entity.ToTable("OTSAPACT_SYSTEMS_ENABLED");

            entity.Property(e => e.Client)
                .HasMaxLength(32)
                .HasColumnName("CLIENT");
            entity.Property(e => e.Sapsystemid)
                .HasMaxLength(32)
                .HasColumnName("SAPSYSTEMID");
            entity.Property(e => e.Dest)
                .HasMaxLength(32)
                .HasColumnName("DEST");
            entity.Property(e => e.IdCfg)
                .HasMaxLength(32)
                .HasColumnName("ID_CFG");

            entity.HasOne(d => d.IdCfgNavigation).WithMany(p => p.OtsapactSystemsEnableds).HasForeignKey(d => d.IdCfg);
        });

        modelBuilder.Entity<OtsapcmisLink>(entity =>
        {
            entity.HasKey(e => new { e.SrcId, e.LinkTypeId, e.DstId });
            entity.ToTable("OTSAPCMIS_LINKS");

            entity.Property(e => e.DstId).HasColumnName("DST_ID");
            entity.Property(e => e.LinkData)
                .HasMaxLength(4000)
                .HasColumnName("LINK_DATA");
            entity.Property(e => e.LinkTypeId)
                .HasColumnType("INTEGER")
                .HasColumnName("LINK_TYPE_ID");
            entity.Property(e => e.SrcId).HasColumnName("SRC_ID");
            entity.Property(e => e.SymDstId)
                .HasMaxLength(512)
                .HasColumnName("SYM_DST_ID");
        });

        modelBuilder.Entity<OtsapwkspBoChildRelation>(entity =>
        {
            entity.HasKey(e => new { e.RelatedIdBoType, e.RelatedIdBo, e.Dataid });
            entity.ToTable("OTSAPWKSP_BO_CHILD_RELATIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.IdBo)
                .HasMaxLength(128)
                .HasColumnName("ID_BO");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.RelatedIdBo)
                .HasMaxLength(128)
                .HasColumnName("RELATED_ID_BO");
            entity.Property(e => e.RelatedIdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("RELATED_ID_BO_TYPE");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany()
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RelatedIdBoTypeNavigation).WithMany()
                .HasForeignKey(d => d.RelatedIdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapwkspBoParentRelation>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.RelatedIdBoType, e.RelatedIdBo });
            entity.ToTable("OTSAPWKSP_BO_PARENT_RELATIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.IdBo)
                .HasMaxLength(128)
                .HasColumnName("ID_BO");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.RelatedIdBo)
                .HasMaxLength(128)
                .HasColumnName("RELATED_ID_BO");
            entity.Property(e => e.RelatedIdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("RELATED_ID_BO_TYPE");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany()
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.RelatedIdBoTypeNavigation).WithMany()
                .HasForeignKey(d => d.RelatedIdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapwkspChildClassify>(entity =>
        {
            entity.HasKey(e => new { e.ParentDataid, e.ChildClassid });

            entity.ToTable("OTSAPWKSP_CHILD_CLASSIFY");

            entity.Property(e => e.ParentDataid).HasColumnName("PARENT_DATAID");
            entity.Property(e => e.ChildClassid).HasColumnName("CHILD_CLASSID");
        });

        modelBuilder.Entity<OtsapwkspInstRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.InstanceDataid, e.InstanceRightid });

            entity.ToTable("OTSAPWKSP_INST_ROLE_MAPPINGS");

            entity.Property(e => e.InstanceDataid).HasColumnName("INSTANCE_DATAID");
            entity.Property(e => e.InstanceRightid).HasColumnName("INSTANCE_RIGHTID");
            entity.Property(e => e.IsLinkedRight)
                .HasColumnType("INTEGER")
                .HasColumnName("IS_LINKED_RIGHT");
            entity.Property(e => e.TemplateRightid).HasColumnName("TEMPLATE_RIGHTID");
        });

        modelBuilder.Entity<OtsapwkspMigrationMapping>(entity =>
        {
            entity.ToTable("OTSAPWKSP_MIGRATION_MAPPINGS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaDataid).HasColumnName("AREA_DATAID");
            entity.Property(e => e.BwsTemplateid).HasColumnName("BWS_TEMPLATEID");
            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Durationcatid).HasColumnName("DURATIONCATID");
            entity.Property(e => e.Filtercriteria)
                .HasMaxLength(32)
                .HasColumnName("FILTERCRITERIA");
            entity.Property(e => e.Filterword)
                .HasMaxLength(1024)
                .HasColumnName("FILTERWORD");
            entity.Property(e => e.PathDataid).HasColumnName("PATH_DATAID");
            entity.Property(e => e.Recursive)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("RECURSIVE");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
        });

        modelBuilder.Entity<OtsapwkspMigrationTracking>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Runid });

            entity.ToTable("OTSAPWKSP_MIGRATION_TRACKING");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Runid).HasColumnName("RUNID");
            entity.Property(e => e.Completed).HasColumnName("COMPLETED");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Errors)
                .HasColumnType("NCLOB")
                .HasColumnName("ERRORS");
            entity.Property(e => e.Inprogress).HasColumnName("INPROGRESS");
            entity.Property(e => e.Objids)
                .HasColumnType("NCLOB")
                .HasColumnName("OBJIDS");
            entity.Property(e => e.Total).HasColumnName("TOTAL");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.OtsapwkspMigrationTrackings)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapwkspRoleMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OTSAPWKSP_ROLE_MAPPINGS");

            entity.Property(e => e.ChildDataid).HasColumnName("CHILD_DATAID");
            entity.Property(e => e.ChildRightid).HasColumnName("CHILD_RIGHTID");
            entity.Property(e => e.ParentDataid).HasColumnName("PARENT_DATAID");
            entity.Property(e => e.ParentRightid).HasColumnName("PARENT_RIGHTID");
        });

        modelBuilder.Entity<OtsapxecmPermissionpropagation>(entity =>
        {
            entity.HasKey(e => new { e.Tdataid, e.Csgroup });
            entity.ToTable("OTSAPXECM_PERMISSIONPROPAGATION");

            entity.Property(e => e.Csgroup).HasColumnName("CSGROUP");
            entity.Property(e => e.Ruledata)
                .HasColumnType("NCLOB")
                .HasColumnName("RULEDATA");
            entity.Property(e => e.Ruleexp)
                .HasColumnType("NCLOB")
                .HasColumnName("RULEEXP");
            entity.Property(e => e.Tdataid).HasColumnName("TDATAID");
            entity.Property(e => e.Templategroup).HasColumnName("TEMPLATEGROUP");
        });

        modelBuilder.Entity<OtsapxecmRefLink>(entity =>
        {
            entity.HasKey(e => new { e.IdBoType, e.IdBo, e.Dataid });

            entity.ToTable("OTSAPXECM_REF_LINKS");

            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.IdBo)
                .HasMaxLength(128)
                .HasColumnName("ID_BO");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Comments)
                .HasMaxLength(248)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany(p => p.OtsapxecmRefLinks)
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapxecmSeqnr>(entity =>
        {
            entity.HasKey(e => e.Seqname);
            entity.ToTable("OTSAPXECM_SEQNR");

            entity.Property(e => e.Lastused)
                .HasColumnType("INTEGER")
                .HasColumnName("LASTUSED");
            entity.Property(e => e.Seqname)
                .HasMaxLength(64)
                .HasColumnName("SEQNAME");
        });

        modelBuilder.Entity<OtsapxecmWkspCao>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.IdBoType, e.RelOwnerId });
            entity.ToTable("OTSAPXECM_WKSP_CAO");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.RelOwnerId)
                .HasColumnType("INTEGER")
                .HasColumnName("REL_OWNER_ID");
        });

        modelBuilder.Entity<OtsapxecmWkspInfo>(entity =>
        {
            entity.HasKey(e => e.Dataid);

            entity.ToTable("OTSAPXECM_WKSP_INFO");

            entity.Property(e => e.Dataid)
                .ValueGeneratedNever()
                .HasColumnName("DATAID");
            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.WidgetImgDataid).HasColumnName("WIDGET_IMG_DATAID");
        });

        modelBuilder.Entity<OtsapxecmWkspLink>(entity =>
        {
            entity.HasKey(e => new { e.IdBoType, e.Dataid });

            entity.ToTable("OTSAPXECM_WKSP_LINKS");

            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.IdBo)
                .HasMaxLength(128)
                .HasColumnName("ID_BO");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany(p => p.OtsapxecmWkspLinks)
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapxecmWkspNolink>(entity =>
        {
            entity.HasKey(e => e.Dataid);

            entity.ToTable("OTSAPXECM_WKSP_NOLINK");

            entity.Property(e => e.Dataid)
                .ValueGeneratedNever()
                .HasColumnName("DATAID");
            entity.Property(e => e.IdReferenceType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_REFERENCE_TYPE");

            entity.HasOne(d => d.IdReferenceTypeNavigation).WithMany(p => p.OtsapxecmWkspNolinks)
                .HasForeignKey(d => d.IdReferenceType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OtsapxecmWkspSlink>(entity =>
        {
            entity.HasKey(e => new { e.SotIdBo, e.IdBoType });

            entity.ToTable("OTSAPXECM_WKSP_SLINKS");

            entity.Property(e => e.SotIdBo)
                .HasMaxLength(128)
                .HasColumnName("SOT_ID_BO");
            entity.Property(e => e.IdBoType)
                .HasColumnType("INTEGER")
                .HasColumnName("ID_BO_TYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");

            entity.HasOne(d => d.IdBoTypeNavigation).WithMany(p => p.OtsapxecmWkspSlinks)
                .HasForeignKey(d => d.IdBoType)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Personelbilgisiview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PERSONELBILGISIVIEW");

            entity.Property(e => e.Attrid)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRID");
            entity.Property(e => e.Attrtype)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRTYPE");
            entity.Property(e => e.Customid)
                .HasColumnType("INTEGER")
                .HasColumnName("CUSTOMID");
            entity.Property(e => e.Defid).HasColumnName("DEFID");
            entity.Property(e => e.Defvern).HasColumnName("DEFVERN");
            entity.Property(e => e.Entrynum)
                .HasColumnType("INTEGER")
                .HasColumnName("ENTRYNUM");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Keyid).HasColumnName("KEYID");
            entity.Property(e => e.Parentkeyid).HasColumnName("PARENTKEYID");
            entity.Property(e => e.Valdate).HasColumnName("VALDATE");
            entity.Property(e => e.Valint).HasColumnName("VALINT");
            entity.Property(e => e.Vallong)
                .HasColumnType("NCLOB")
                .HasColumnName("VALLONG");
            entity.Property(e => e.Valreal)
                .HasColumnType("DECIMAL")
                .HasColumnName("VALREAL");
            entity.Property(e => e.Valstr)
                .HasMaxLength(255)
                .HasColumnName("VALSTR");
            entity.Property(e => e.Vernum).HasColumnName("VERNUM");
        });

        modelBuilder.Entity<Physitemco>(entity =>
        {
            entity.HasKey(e => e.Uniqueid);
            entity.ToTable("PHYSITEMCO");

            entity.Property(e => e.Acknguid).HasColumnName("ACKNGUID");
            entity.Property(e => e.Acknowledge).HasColumnName("ACKNOWLEDGE");
            entity.Property(e => e.Actualborrowdate).HasColumnName("ACTUALBORROWDATE");
            entity.Property(e => e.Borrowcomment)
                .HasMaxLength(255)
                .HasColumnName("BORROWCOMMENT");
            entity.Property(e => e.Borrowperformerid).HasColumnName("BORROWPERFORMERID");
            entity.Property(e => e.Boxid).HasColumnName("BOXID");
            entity.Property(e => e.Chargedate).HasColumnName("CHARGEDATE");
            entity.Property(e => e.Chargedto)
                .HasMaxLength(64)
                .HasColumnName("CHARGEDTO");
            entity.Property(e => e.Copynumber)
                .HasColumnType("INTEGER")
                .HasColumnName("COPYNUMBER");
            entity.Property(e => e.Cparentid).HasColumnName("CPARENTID");
            entity.Property(e => e.Location)
                .HasMaxLength(64)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Numreminders)
                .HasColumnType("INTEGER")
                .HasColumnName("NUMREMINDERS");
            entity.Property(e => e.Obtainedby)
                .HasMaxLength(64)
                .HasColumnName("OBTAINEDBY");
            entity.Property(e => e.Obtainedbyid).HasColumnName("OBTAINEDBYID");
            entity.Property(e => e.Pickup).HasColumnName("PICKUP");
            entity.Property(e => e.Returnby).HasColumnName("RETURNBY");
            entity.Property(e => e.Securityoverride).HasColumnName("SECURITYOVERRIDE");
            entity.Property(e => e.Uniqueid)
                .HasMaxLength(64)
                .HasColumnName("UNIQUEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Physitemdatum>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("PHYSITEMDATA");

            entity.Property(e => e.Area)
                .HasMaxLength(32)
                .HasColumnName("AREA");
            entity.Property(e => e.Boxlocator)
                .HasMaxLength(32)
                .HasColumnName("BOXLOCATOR");
            entity.Property(e => e.Client)
                .HasMaxLength(64)
                .HasColumnName("CLIENT");
            entity.Property(e => e.Clientid).HasColumnName("CLIENTID");
            entity.Property(e => e.Containernumber)
                .HasColumnType("INTEGER")
                .HasColumnName("CONTAINERNUMBER");
            entity.Property(e => e.Datesent).HasColumnName("DATESENT");
            entity.Property(e => e.Defaultlocation)
                .HasMaxLength(64)
                .HasColumnName("DEFAULTLOCATION");
            entity.Property(e => e.Facility)
                .HasMaxLength(32)
                .HasColumnName("FACILITY");
            entity.Property(e => e.Fromdate).HasColumnName("FROMDATE");
            entity.Property(e => e.Locatortype)
                .HasMaxLength(32)
                .HasColumnName("LOCATORTYPE");
            entity.Property(e => e.Mediatypeid).HasColumnName("MEDIATYPEID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Offsitestorid)
                .HasMaxLength(32)
                .HasColumnName("OFFSITESTORID");
            entity.Property(e => e.Physitemkeywords)
                .HasMaxLength(4000)
                .HasColumnName("PHYSITEMKEYWORDS");
            entity.Property(e => e.Refrate)
                .HasMaxLength(32)
                .HasColumnName("REFRATE");
            entity.Property(e => e.Temporaryid)
                .HasMaxLength(32)
                .HasColumnName("TEMPORARYID");
            entity.Property(e => e.Todate).HasColumnName("TODATE");
            entity.Property(e => e.Transferid)
                .HasMaxLength(64)
                .HasColumnName("TRANSFERID");
            entity.Property(e => e.Transreceived).HasColumnName("TRANSRECEIVED");
        });

        modelBuilder.Entity<Physitemext>(entity =>
        {
            entity.HasKey(e => new { e.Nodeid, e.Fieldname });
            entity.ToTable("PHYSITEMEXT");

            entity.Property(e => e.Fieldname)
                .HasMaxLength(255)
                .HasColumnName("FIELDNAME");
            entity.Property(e => e.Fieldvalue)
                .HasMaxLength(255)
                .HasColumnName("FIELDVALUE");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<Physitemhistory>(entity =>
        {
            entity.HasKey(e => new { e.Hid, e.Nodeid });
            entity.ToTable("PHYSITEMHISTORY");

            entity.Property(e => e.Acknowledge).HasColumnName("ACKNOWLEDGE");
            entity.Property(e => e.Actualborrowdate).HasColumnName("ACTUALBORROWDATE");
            entity.Property(e => e.Actualreturndate).HasColumnName("ACTUALRETURNDATE");
            entity.Property(e => e.Borrowcomment)
                .HasMaxLength(255)
                .HasColumnName("BORROWCOMMENT");
            entity.Property(e => e.Borrowperformerid).HasColumnName("BORROWPERFORMERID");
            entity.Property(e => e.Chargedate).HasColumnName("CHARGEDATE");
            entity.Property(e => e.Chargedto)
                .HasMaxLength(64)
                .HasColumnName("CHARGEDTO");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Obtainedby)
                .HasMaxLength(64)
                .HasColumnName("OBTAINEDBY");
            entity.Property(e => e.Obtainedbyid).HasColumnName("OBTAINEDBYID");
            entity.Property(e => e.Returnby).HasColumnName("RETURNBY");
            entity.Property(e => e.Returncomment)
                .HasMaxLength(255)
                .HasColumnName("RETURNCOMMENT");
            entity.Property(e => e.Returndate).HasColumnName("RETURNDATE");
            entity.Property(e => e.Returnperformerid).HasColumnName("RETURNPERFORMERID");
            entity.Property(e => e.Securityoverride).HasColumnName("SECURITYOVERRIDE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Physitemmicro>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("PHYSITEMMICRO");

            entity.Property(e => e.Microdocnum)
                .HasColumnType("INTEGER")
                .HasColumnName("MICRODOCNUM");
            entity.Property(e => e.Micropagenum)
                .HasColumnType("INTEGER")
                .HasColumnName("MICROPAGENUM");
            entity.Property(e => e.Microrollnum)
                .HasColumnType("INTEGER")
                .HasColumnName("MICROROLLNUM");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<Physitemrequest>(entity =>
        {
            entity.HasKey(e => e.Requestid);
            entity.ToTable("PHYSITEMREQUEST");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Contactperson)
                .HasMaxLength(64)
                .HasColumnName("CONTACTPERSON");
            entity.Property(e => e.Dateofrequest).HasColumnName("DATEOFREQUEST");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(32)
                .HasColumnName("FAX");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Phone)
                .HasMaxLength(32)
                .HasColumnName("PHONE");
            entity.Property(e => e.Requestcomment)
                .HasMaxLength(255)
                .HasColumnName("REQUESTCOMMENT");
            entity.Property(e => e.Requestdate).HasColumnName("REQUESTDATE");
            entity.Property(e => e.Requestid).HasColumnName("REQUESTID");
            entity.Property(e => e.Requesttype)
                .HasMaxLength(32)
                .HasColumnName("REQUESTTYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Physobjclient>(entity =>
        {
            entity.HasKey(e => e.Physobjclient1);
            entity.ToTable("PHYSOBJCLIENT");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Clienttype).HasColumnName("CLIENTTYPE");
            entity.Property(e => e.DescE)
                .HasMaxLength(64)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Phone)
                .HasMaxLength(64)
                .HasColumnName("PHONE");
            entity.Property(e => e.Physobjclient1)
                .HasMaxLength(64)
                .HasColumnName("PHYSOBJCLIENT");
        });

        modelBuilder.Entity<Physobjfuncaccess>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Funcid });
            entity.ToTable("PHYSOBJFUNCACCESS");

            entity.Property(e => e.Funcid)
                .HasColumnType("INTEGER")
                .HasColumnName("FUNCID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idtype)
                .HasColumnType("INTEGER")
                .HasColumnName("IDTYPE");
        });

        modelBuilder.Entity<Physobjkeyword>(entity =>
        {
            entity.HasKey(e => new { e.Nodeid, e.Physobjkeyword1, e.Objectfield });
            entity.ToTable("PHYSOBJKEYWORDS");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Objectfield)
                .HasMaxLength(64)
                .HasColumnName("OBJECTFIELD");
            entity.Property(e => e.Physobjkeyword1)
                .HasMaxLength(64)
                .HasColumnName("PHYSOBJKEYWORD");
        });

        modelBuilder.Entity<Physobjkini>(entity =>
        {
            entity.HasKey(e => new { e.Inisection, e.Inikeyword });
            entity.ToTable("PHYSOBJKINI");

            entity.Property(e => e.Inikeyword)
                .HasMaxLength(128)
                .HasColumnName("INIKEYWORD");
            entity.Property(e => e.Inisection)
                .HasMaxLength(128)
                .HasColumnName("INISECTION");
            entity.Property(e => e.Inivalue)
                .HasMaxLength(255)
                .HasColumnName("INIVALUE");
        });

        modelBuilder.Entity<Physobjlocation>(entity =>
        {
            entity.HasKey(e => e.Physobjlocation1);
            entity.ToTable("PHYSOBJLOCATION");

            entity.Property(e => e.Custodiansite)
                .HasMaxLength(32)
                .HasColumnName("CUSTODIANSITE");
            entity.Property(e => e.DescE)
                .HasMaxLength(64)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Physobjlocation1)
                .HasMaxLength(64)
                .HasColumnName("PHYSOBJLOCATION");
        });

        modelBuilder.Entity<PowfClearance>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Parpos, e.Pos });
            entity.ToTable("POWF_CLEARANCE");

            entity.Property(e => e.Clearance)
                .HasMaxLength(32)
                .HasColumnName("CLEARANCE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Parpos).HasColumnName("PARPOS");
            entity.Property(e => e.Pos).HasColumnName("POS");
        });

        modelBuilder.Entity<PowfCreateitem>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Subtype, e.Reltype, e.Parpos, e.Pos });
            entity.ToTable("POWF_CREATEITEMS");

            entity.Property(e => e.Action)
                .HasMaxLength(32)
                .HasColumnName("ACTION");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(32)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.CategoryPath)
                .HasMaxLength(248)
                .HasColumnName("CATEGORY_PATH");
            entity.Property(e => e.ClassId)
                .HasMaxLength(32)
                .HasColumnName("CLASS_ID");
            entity.Property(e => e.ClassPath)
                .HasMaxLength(248)
                .HasColumnName("CLASS_PATH");
            entity.Property(e => e.ClientId)
                .HasMaxLength(32)
                .HasColumnName("CLIENT_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(32)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Fromdate).HasColumnName("FROMDATE");
            entity.Property(e => e.Generatelabel).HasColumnName("GENERATELABEL");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Keywords)
                .HasMaxLength(4000)
                .HasColumnName("KEYWORDS");
            entity.Property(e => e.Labeltype)
                .HasMaxLength(32)
                .HasColumnName("LABELTYPE");
            entity.Property(e => e.Location)
                .HasMaxLength(64)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Locatortype)
                .HasMaxLength(32)
                .HasColumnName("LOCATORTYPE");
            entity.Property(e => e.MapId).HasColumnName("MAP_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Numberofcopies).HasColumnName("NUMBEROFCOPIES");
            entity.Property(e => e.Numberofitems).HasColumnName("NUMBEROFITEMS");
            entity.Property(e => e.Numberoflabels).HasColumnName("NUMBEROFLABELS");
            entity.Property(e => e.Offsitestorid)
                .HasMaxLength(32)
                .HasColumnName("OFFSITESTORID");
            entity.Property(e => e.Parpos).HasColumnName("PARPOS");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.Refrate)
                .HasMaxLength(32)
                .HasColumnName("REFRATE");
            entity.Property(e => e.Reltype).HasColumnName("RELTYPE");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.TargetAttrselect)
                .HasMaxLength(32)
                .HasColumnName("TARGET_ATTRSELECT");
            entity.Property(e => e.TargetElem)
                .HasMaxLength(32)
                .HasColumnName("TARGET_ELEM");
            entity.Property(e => e.TargetId)
                .HasMaxLength(32)
                .HasColumnName("TARGET_ID");
            entity.Property(e => e.TargetPath)
                .HasMaxLength(248)
                .HasColumnName("TARGET_PATH");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Temporaryid)
                .HasMaxLength(32)
                .HasColumnName("TEMPORARYID");
            entity.Property(e => e.Todate).HasColumnName("TODATE");
            entity.Property(e => e.Uniqueid)
                .HasMaxLength(32)
                .HasColumnName("UNIQUEID");
        });

        modelBuilder.Entity<PowfDatadef>(entity =>
        {
            entity.HasKey(e => new { e.Mapid, e.Taskid, e.Name });
            entity.ToTable("POWF_DATADEF");

            entity.Property(e => e.Chitype).HasColumnName("CHITYPE");
            entity.Property(e => e.Guid)
                .HasMaxLength(16)
                .HasDefaultValueSql("1")
                .HasColumnName("GUID");
            entity.Property(e => e.Mapid).HasColumnName("MAPID");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Partype).HasColumnName("PARTYPE");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
        });

        modelBuilder.Entity<PowfItemext>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Parpos, e.Pos, e.Fieldname });
            entity.ToTable("POWF_ITEMEXT");

            entity.Property(e => e.Fieldname)
                .HasMaxLength(255)
                .HasColumnName("FIELDNAME");
            entity.Property(e => e.Fieldvalue)
                .HasMaxLength(255)
                .HasColumnName("FIELDVALUE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Parpos).HasColumnName("PARPOS");
            entity.Property(e => e.Pos).HasColumnName("POS");
        });

        modelBuilder.Entity<PowfSuppmark>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Parpos, e.Pos, e.Suppmark });
            entity.ToTable("POWF_SUPPMARK");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Parpos).HasColumnName("PARPOS");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.Suppmark)
                .HasMaxLength(32)
                .HasColumnName("SUPPMARK");
        });

        modelBuilder.Entity<Processstat>(entity =>
        {
            entity.HasKey(e => e.Enddate);
            entity.ToTable("PROCESSSTATS");

            entity.Property(e => e.Data)
                .HasColumnType("NCLOB")
                .HasColumnName("DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Format).HasColumnName("FORMAT");
            entity.Property(e => e.Processtype)
                .HasMaxLength(32)
                .HasColumnName("PROCESSTYPE");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
        });

        modelBuilder.Entity<Projectoverviewsetting>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("PROJECTOVERVIEWSETTINGS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Numtodisplay)
                .HasColumnType("INTEGER")
                .HasColumnName("NUMTODISPLAY");
            entity.Property(e => e.Sectionstoshow)
                .HasColumnType("NCLOB")
                .HasColumnName("SECTIONSTOSHOW");
        });

        modelBuilder.Entity<Provenancetype>(entity =>
        {
            entity.HasKey(e => e.Provenancetype1);
            entity.ToTable("PROVENANCETYPE");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Provenancetype1)
                .HasMaxLength(32)
                .HasColumnName("PROVENANCETYPE");
            entity.Property(e => e.ProvenancetypeDescAdd)
                .HasMaxLength(255)
                .HasColumnName("PROVENANCETYPE_DESC_ADD");
            entity.Property(e => e.ProvenancetypeDescE)
                .HasMaxLength(255)
                .HasColumnName("PROVENANCETYPE_DESC_E");
        });

        modelBuilder.Entity<Providerconfirmmove>(entity =>
        {
            entity.HasKey(e => e.Retryid);
            entity.ToTable("PROVIDERCONFIRMMOVE");

            entity.Property(e => e.Entrytype).HasColumnName("ENTRYTYPE");
            entity.Property(e => e.Extrainfo)
                .HasMaxLength(4000)
                .HasColumnName("EXTRAINFO");
            entity.Property(e => e.Newproviderid).HasColumnName("NEWPROVIDERID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Queuingdate).HasColumnName("QUEUINGDATE");
            entity.Property(e => e.Retryid).HasColumnName("RETRYID");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
            entity.Property(e => e.Versiontype)
                .HasMaxLength(32)
                .HasColumnName("VERSIONTYPE");
        });

        modelBuilder.Entity<Providerdatum>(entity =>
        {
            entity.HasKey(e => e.Providerid);

            entity.ToTable("PROVIDERDATA");

            entity.Property(e => e.Providerid)
                .ValueGeneratedNever()
                .HasColumnName("PROVIDERID");
            entity.Property(e => e.Providerdata)
                .HasColumnType("NCLOB")
                .HasColumnName("PROVIDERDATA");
            entity.Property(e => e.Providertype)
                .HasMaxLength(255)
                .HasColumnName("PROVIDERTYPE");
            entity.Property(e => e.Refcnt)
                .HasColumnType("INTEGER")
                .HasColumnName("REFCNT");
        });

        modelBuilder.Entity<Providerretry>(entity =>
        {
            entity.HasKey(e => e.Retryid);
            entity.ToTable("PROVIDERRETRY");

            entity.Property(e => e.Deleteerror)
                .HasMaxLength(4000)
                .HasColumnName("DELETEERROR");
            entity.Property(e => e.Entrytype).HasColumnName("ENTRYTYPE");
            entity.Property(e => e.Errortype).HasColumnName("ERRORTYPE");
            entity.Property(e => e.Extrainfo)
                .HasMaxLength(4000)
                .HasColumnName("EXTRAINFO");
            entity.Property(e => e.Hashstr)
                .HasMaxLength(64)
                .HasColumnName("HASHSTR");
            entity.Property(e => e.Providerdata)
                .HasColumnType("NCLOB")
                .HasColumnName("PROVIDERDATA");
            entity.Property(e => e.Providername)
                .HasMaxLength(128)
                .HasColumnName("PROVIDERNAME");
            entity.Property(e => e.Queuingdate).HasColumnName("QUEUINGDATE");
            entity.Property(e => e.Retentionexpirydate).HasColumnName("RETENTIONEXPIRYDATE");
            entity.Property(e => e.Retryid).HasColumnName("RETRYID");
        });

        modelBuilder.Entity<Pwd>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pwd1, e.Type, e.Createdate });
            entity.ToTable("PWDS");

            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pwd1)
                .HasMaxLength(255)
                .HasColumnName("PWD");
            entity.Property(e => e.Type)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<RecdAdminconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RECD_ADMINCONFIG");

            entity.Property(e => e.Config)
                .HasColumnType("NCLOB")
                .HasColumnName("CONFIG");
            entity.Property(e => e.Enabled)
                .HasMaxLength(32)
                .HasColumnName("ENABLED");
            entity.Property(e => e.Sectionid)
                .HasMaxLength(255)
                .HasColumnName("SECTIONID");
        });

        modelBuilder.Entity<RecdHistory>(entity =>
        {
            entity.HasKey(e => e.Eventdate);
            entity.ToTable("RECD_HISTORY");

            entity.Property(e => e.Class).HasColumnName("CLASS");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RecdHot>(entity =>
        {
            entity.HasKey(e => new { e.Orderiden, e.Sectionid, e.Subtype, e.Dataid });
            entity.ToTable("RECD_HOT");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Orderiden).HasColumnName("ORDERIDEN");
            entity.Property(e => e.Sectionid)
                .HasColumnType("INTEGER")
                .HasColumnName("SECTIONID");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
        });

        modelBuilder.Entity<RecdOperationsummary>(entity =>
        {
            entity.HasKey(e => e.Recentaccess);
            entity.ToTable("RECD_OPERATIONSUMMARY");

            entity.Property(e => e.Action)
                .HasMaxLength(64)
                .HasColumnName("ACTION");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Firstaccess).HasColumnName("FIRSTACCESS");
            entity.Property(e => e.Meandate)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANDATE");
            entity.Property(e => e.Meansqdate)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANSQDATE");
            entity.Property(e => e.Meansqtime)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANSQTIME");
            entity.Property(e => e.Meantime)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANTIME");
            entity.Property(e => e.Objtype).HasColumnName("OBJTYPE");
            entity.Property(e => e.Recentaccess).HasColumnName("RECENTACCESS");
            entity.Property(e => e.Refcount).HasColumnName("REFCOUNT");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RecdOperationtracking>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("RECD_OPERATIONTRACKING");

            entity.Property(e => e.Action)
                .HasMaxLength(64)
                .HasColumnName("ACTION");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Fromlocation)
                .HasMaxLength(64)
                .HasColumnName("FROMLOCATION");
            entity.Property(e => e.Objtype).HasColumnName("OBJTYPE");
            entity.Property(e => e.Operationdate).HasColumnName("OPERATIONDATE");
            entity.Property(e => e.Operationiden).HasColumnName("OPERATIONIDEN");
            entity.Property(e => e.Pathinfo)
                .HasMaxLength(4000)
                .HasColumnName("PATHINFO");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RecdOpinionsummary>(entity =>
        {
            entity.HasKey(e => new { e.Ratingavg, e.Dataid, e.Ratingnum });
            entity.ToTable("RECD_OPINIONSUMMARY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Opiniondatemax).HasColumnName("OPINIONDATEMAX");
            entity.Property(e => e.Ratingavg)
                .HasColumnType("DECIMAL")
                .HasColumnName("RATINGAVG");
            entity.Property(e => e.Ratingnum).HasColumnName("RATINGNUM");
            entity.Property(e => e.Ratingsum)
                .HasColumnType("DECIMAL")
                .HasColumnName("RATINGSUM");
        });

        modelBuilder.Entity<RecdOpiniontracking>(entity =>
        {
            entity.HasKey(e => e.Opiniondate);
            entity.ToTable("RECD_OPINIONTRACKING");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Opiniondate).HasColumnName("OPINIONDATE");
            entity.Property(e => e.Rating)
                .HasColumnType("DECIMAL")
                .HasColumnName("RATING");
            entity.Property(e => e.Usercomment)
                .HasMaxLength(64)
                .HasColumnName("USERCOMMENT");
            entity.Property(e => e.Userexplanation)
                .HasMaxLength(4000)
                .HasColumnName("USEREXPLANATION");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RecdSystemstatssummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RECD_SYSTEMSTATSSUMMARY");

            entity.Property(e => e.Meanclickssec)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANCLICKSSEC");
            entity.Property(e => e.Meandate)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANDATE");
            entity.Property(e => e.Meansqclickssec)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANSQCLICKSSEC");
            entity.Property(e => e.Meansqdate)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANSQDATE");
            entity.Property(e => e.Meansqtime)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANSQTIME");
            entity.Property(e => e.Meantime)
                .HasColumnType("DECIMAL")
                .HasColumnName("MEANTIME");
            entity.Property(e => e.Refcount).HasColumnName("REFCOUNT");
        });

        modelBuilder.Entity<Recurrence>(entity =>
        {
            entity.HasKey(e => e.Recurrence1);
            entity.ToTable("RECURRENCE");

            entity.Property(e => e.DescE)
                .HasMaxLength(128)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Numberofdays).HasColumnName("NUMBEROFDAYS");
            entity.Property(e => e.Recurrence1)
                .HasMaxLength(32)
                .HasColumnName("RECURRENCE");
        });

        modelBuilder.Entity<Refrate>(entity =>
        {
            entity.HasKey(e => e.Refrate1);
            entity.ToTable("REFRATE");

            entity.Property(e => e.DescE)
                .HasMaxLength(128)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Refrate1)
                .HasMaxLength(32)
                .HasColumnName("REFRATE");
        });

        modelBuilder.Entity<Regionmap>(entity =>
        {
            entity.HasKey(e => new { e.Searchmanagerid, e.Name });
            entity.ToTable("REGIONMAP");

            entity.Property(e => e.Displayable).HasColumnName("DISPLAYABLE");
            entity.Property(e => e.Displayname)
                .HasMaxLength(4000)
                .HasColumnName("DISPLAYNAME");
            entity.Property(e => e.Facet).HasColumnName("FACET");
            entity.Property(e => e.Facettype)
                .HasMaxLength(4)
                .HasColumnName("FACETTYPE");
            entity.Property(e => e.Name)
                .HasMaxLength(440)
                .HasColumnName("NAME");
            entity.Property(e => e.Purged).HasColumnName("PURGED");
            entity.Property(e => e.Queryable).HasColumnName("QUERYABLE");
            entity.Property(e => e.Rdram)
                .HasMaxLength(2)
                .HasColumnName("RDRAM");
            entity.Property(e => e.Rwram)
                .HasMaxLength(2)
                .HasColumnName("RWRAM");
            entity.Property(e => e.Searchbydefault).HasColumnName("SEARCHBYDEFAULT");
            entity.Property(e => e.Searchmanagerid).HasColumnName("SEARCHMANAGERID");
            entity.Property(e => e.Sortable).HasColumnName("SORTABLE");
            entity.Property(e => e.Uoram)
                .HasMaxLength(2)
                .HasColumnName("UORAM");
        });

        modelBuilder.Entity<Relattype>(entity =>
        {
            entity.HasKey(e => e.Relattype1);
            entity.ToTable("RELATTYPE");

            entity.Property(e => e.Reciprocal)
                .HasMaxLength(32)
                .HasColumnName("RECIPROCAL");
            entity.Property(e => e.Relattype1)
                .HasMaxLength(32)
                .HasColumnName("RELATTYPE");
            entity.Property(e => e.RelattypeDesc)
                .HasMaxLength(128)
                .HasColumnName("RELATTYPE_DESC");
        });

        modelBuilder.Entity<Renditionfolder>(entity =>
        {
            entity.HasKey(e => e.Folderid);
            entity.ToTable("RENDITIONFOLDERS");

            entity.Property(e => e.Directory)
                .HasMaxLength(255)
                .HasColumnName("DIRECTORY");
            entity.Property(e => e.Folderid).HasColumnName("FOLDERID");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Renditiontype)
                .HasMaxLength(255)
                .HasColumnName("RENDITIONTYPE");
        });

        modelBuilder.Entity<Renditionmimetyperule>(entity =>
        {
            entity.HasKey(e => e.Mimetyperuleid);
            entity.ToTable("RENDITIONMIMETYPERULES");

            entity.Property(e => e.Globalrendition).HasColumnName("GLOBALRENDITION");
            entity.Property(e => e.Mimetyperuleid).HasColumnName("MIMETYPERULEID");
            entity.Property(e => e.Mimetyperulename)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPERULENAME");
            entity.Property(e => e.Settings)
                .HasColumnType("NCLOB")
                .HasColumnName("SETTINGS");
        });

        modelBuilder.Entity<Renditionnodemimetyperule>(entity =>
        {
            entity.HasKey(e => e.Mimetyperuleid);
            entity.ToTable("RENDITIONNODEMIMETYPERULES");

            entity.Property(e => e.Mimetyperuleid).HasColumnName("MIMETYPERULEID");
            entity.Property(e => e.Noderuleid).HasColumnName("NODERULEID");
        });

        modelBuilder.Entity<Renditionnoderule>(entity =>
        {
            entity.HasKey(e => e.Noderuleid);
            entity.ToTable("RENDITIONNODERULES");

            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Includesubfolders).HasColumnName("INCLUDESUBFOLDERS");
            entity.Property(e => e.Noderuleid).HasColumnName("NODERULEID");
            entity.Property(e => e.Noderuletype)
                .HasMaxLength(64)
                .HasColumnName("NODERULETYPE");
        });

        modelBuilder.Entity<Renditionqueue>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Versionnum, e.Attempt });
            entity.ToTable("RENDITIONQUEUE");

            entity.Property(e => e.Attempt).HasColumnName("ATTEMPT");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dirused)
                .HasMaxLength(255)
                .HasColumnName("DIRUSED");
            entity.Property(e => e.Noderuleid).HasColumnName("NODERULEID");
            entity.Property(e => e.Queuedate).HasColumnName("QUEUEDATE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Versionseqno).HasColumnName("VERSIONSEQNO");
        });

        modelBuilder.Entity<Requesttype>(entity =>
        {
            entity.HasKey(e => e.Requesttype1);
            entity.ToTable("REQUESTTYPE");

            entity.Property(e => e.DescE)
                .HasMaxLength(128)
                .HasColumnName("DESC_E");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Requesttype1)
                .HasMaxLength(32)
                .HasColumnName("REQUESTTYPE");
        });

        modelBuilder.Entity<Resubmission>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("RESUBMISSION");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Lastmoddate).HasColumnName("LASTMODDATE");
            entity.Property(e => e.Lastmodifiedby).HasColumnName("LASTMODIFIEDBY");
            entity.Property(e => e.Moveprev)
                .HasColumnType("INTEGER")
                .HasColumnName("MOVEPREV");
            entity.Property(e => e.Rsactivation)
                .HasColumnType("INTEGER")
                .HasColumnName("RSACTIVATION");
            entity.Property(e => e.Rsactivationbday)
                .HasColumnType("INTEGER")
                .HasColumnName("RSACTIVATIONBDAY");
            entity.Property(e => e.Rsactivationdate).HasColumnName("RSACTIVATIONDATE");
            entity.Property(e => e.Rsactivationunit)
                .HasColumnType("INTEGER")
                .HasColumnName("RSACTIVATIONUNIT");
            entity.Property(e => e.Rscreatedate).HasColumnName("RSCREATEDATE");
            entity.Property(e => e.Rscreatorid).HasColumnName("RSCREATORID");
            entity.Property(e => e.Rsdate).HasColumnName("RSDATE");
            entity.Property(e => e.Rsdelivered)
                .HasColumnType("INTEGER")
                .HasColumnName("RSDELIVERED");
            entity.Property(e => e.Rsdescription)
                .HasMaxLength(4000)
                .HasColumnName("RSDESCRIPTION");
            entity.Property(e => e.Rshandler)
                .HasColumnType("INTEGER")
                .HasColumnName("RSHANDLER");
            entity.Property(e => e.Rshandlerdata).HasColumnName("RSHANDLERDATA");
            entity.Property(e => e.Rsid).HasColumnName("RSID");
            entity.Property(e => e.Rsparentid).HasColumnName("RSPARENTID");
            entity.Property(e => e.Rspriority)
                .HasDefaultValueSql("50")
                .HasColumnType("INTEGER")
                .HasColumnName("RSPRIORITY");
            entity.Property(e => e.Rsrule)
                .HasColumnType("INTEGER")
                .HasColumnName("RSRULE");
            entity.Property(e => e.Rsruleunit)
                .HasColumnType("INTEGER")
                .HasColumnName("RSRULEUNIT");
            entity.Property(e => e.Rsrulevalue)
                .HasColumnType("INTEGER")
                .HasColumnName("RSRULEVALUE");
            entity.Property(e => e.Rsseqenddate).HasColumnName("RSSEQENDDATE");
            entity.Property(e => e.Rsseqstartdate).HasColumnName("RSSEQSTARTDATE");
            entity.Property(e => e.Rssequencecode)
                .HasMaxLength(255)
                .HasColumnName("RSSEQUENCECODE");
            entity.Property(e => e.Rsstatus)
                .HasColumnType("INTEGER")
                .HasColumnName("RSSTATUS");
            entity.Property(e => e.Rsstatususerid).HasColumnName("RSSTATUSUSERID");
            entity.Property(e => e.Rstype)
                .HasColumnType("INTEGER")
                .HasColumnName("RSTYPE");
            entity.Property(e => e.Timezone)
                .HasColumnType("INTEGER")
                .HasColumnName("TIMEZONE");
        });

        modelBuilder.Entity<Resubrecipient>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("RESUBRECIPIENTS");

            entity.Property(e => e.Notification).HasColumnName("NOTIFICATION");
            entity.Property(e => e.Notified)
                .HasColumnType("INTEGER")
                .HasColumnName("NOTIFIED");
            entity.Property(e => e.Reciptype)
                .HasColumnType("INTEGER")
                .HasColumnName("RECIPTYPE");
            entity.Property(e => e.Rsid).HasColumnName("RSID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Resubtype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RESUBTYPES");

            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Escalation)
                .HasColumnType("INTEGER")
                .HasColumnName("ESCALATION");
            entity.Property(e => e.Escalbday)
                .HasColumnType("INTEGER")
                .HasColumnName("ESCALBDAY");
            entity.Property(e => e.Escalchange)
                .HasColumnType("INTEGER")
                .HasColumnName("ESCALCHANGE");
            entity.Property(e => e.Escalenabled)
                .HasColumnType("INTEGER")
                .HasColumnName("ESCALENABLED");
            entity.Property(e => e.Escalto).HasColumnName("ESCALTO");
            entity.Property(e => e.Escalunit)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ESCALUNIT");
            entity.Property(e => e.Rsactivation).HasColumnName("RSACTIVATION");
            entity.Property(e => e.Rsactivationunit)
                .HasColumnType("INTEGER")
                .HasColumnName("RSACTIVATIONUNIT");
            entity.Property(e => e.Rsclient).HasColumnName("RSCLIENT");
            entity.Property(e => e.Rspriority)
                .HasDefaultValueSql("50")
                .HasColumnType("INTEGER")
                .HasColumnName("RSPRIORITY");
            entity.Property(e => e.Rstype).HasColumnName("RSTYPE");
            entity.Property(e => e.Typename)
                .HasMaxLength(255)
                .HasColumnName("TYPENAME");
        });

        modelBuilder.Entity<Retcode>(entity =>
        {
            entity.HasKey(e => e.Retcode1);
            entity.ToTable("RETCODE");

            entity.Property(e => e.Retcode1)
                .HasMaxLength(32)
                .HasColumnName("RETCODE");
            entity.Property(e => e.RetcodeDescE)
                .HasMaxLength(128)
                .HasColumnName("RETCODE_DESC_E");
        });

        modelBuilder.Entity<Retentionupdatefailed>(entity =>
        {
            entity.HasKey(e => e.Nid);

            entity.ToTable("RETENTIONUPDATEFAILED");

            entity.Property(e => e.Nid)
                .ValueGeneratedNever()
                .HasColumnName("NID");
            entity.Property(e => e.Failuretime).HasColumnName("FAILURETIME");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Rmretention)
                .HasMaxLength(32)
                .HasColumnName("RMRETENTION");
        });

        modelBuilder.Entity<Retentionupdatelog>(entity =>
        {
            entity.HasKey(e => e.Nid);

            entity.ToTable("RETENTIONUPDATELOG");

            entity.Property(e => e.Nid)
                .ValueGeneratedNever()
                .HasColumnName("NID");
            entity.Property(e => e.Asarcid)
                .HasMaxLength(64)
                .HasColumnName("ASARCID");
            entity.Property(e => e.Asdocid)
                .HasMaxLength(64)
                .HasColumnName("ASDOCID");
            entity.Property(e => e.Asretention)
                .HasMaxLength(64)
                .HasColumnName("ASRETENTION");
            entity.Property(e => e.Errorid).HasColumnName("ERRORID");
            entity.Property(e => e.Errormsg)
                .HasColumnType("NCLOB")
                .HasColumnName("ERRORMSG");
            entity.Property(e => e.Exectime).HasColumnName("EXECTIME");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Retrycount).HasColumnName("RETRYCOUNT");
            entity.Property(e => e.Versionno).HasColumnName("VERSIONNO");
        });

        modelBuilder.Entity<Retentionupdateorder>(entity =>
        {
            entity.HasKey(e => e.Nid);

            entity.ToTable("RETENTIONUPDATEORDER");

            entity.Property(e => e.Nid)
                .ValueGeneratedNever()
                .HasColumnName("NID");
            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Retentionvalue)
                .HasMaxLength(32)
                .HasColumnName("RETENTIONVALUE");
        });

        modelBuilder.Entity<Retentionupdateretry>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("RETENTIONUPDATERETRY");

            entity.Property(e => e.Asarcid)
                .HasMaxLength(64)
                .HasColumnName("ASARCID");
            entity.Property(e => e.Asdocid)
                .HasMaxLength(64)
                .HasColumnName("ASDOCID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Retentionvalue)
                .HasMaxLength(32)
                .HasColumnName("RETENTIONVALUE");
            entity.Property(e => e.Versionno).HasColumnName("VERSIONNO");
        });

        modelBuilder.Entity<Retstage>(entity =>
        {
            entity.HasKey(e => e.Retstage1);
            entity.ToTable("RETSTAGE");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Retstage1)
                .HasMaxLength(32)
                .HasColumnName("RETSTAGE");
            entity.Property(e => e.RetstageDescE)
                .HasMaxLength(128)
                .HasColumnName("RETSTAGE_DESC_E");
            entity.Property(e => e.RetstageDescF)
                .HasMaxLength(128)
                .HasColumnName("RETSTAGE_DESC_F");
            entity.Property(e => e.Retstageorder).HasColumnName("RETSTAGEORDER");
        });

        modelBuilder.Entity<Rimskeyworded>(entity =>
        {
            entity.HasKey(e => new { e.Object, e.Objectfield });
            entity.ToTable("RIMSKEYWORDED");

            entity.Property(e => e.Object)
                .HasMaxLength(32)
                .HasColumnName("OBJECT");
            entity.Property(e => e.Objectfield)
                .HasMaxLength(64)
                .HasColumnName("OBJECTFIELD");
        });

        modelBuilder.Entity<Rimsnodeclassification>(entity =>
        {
            entity.HasKey(e => e.Classid);
            entity.ToTable("RIMSNODECLASSIFICATION");

            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Rimsaccession)
                .HasMaxLength(32)
                .HasColumnName("RIMSACCESSION");
            entity.Property(e => e.Rimsaddressee)
                .HasMaxLength(4000)
                .HasColumnName("RIMSADDRESSEE");
            entity.Property(e => e.Rimsclassification)
                .HasMaxLength(128)
                .HasColumnName("RIMSCLASSIFICATION");
            entity.Property(e => e.Rimscycleperiod).HasColumnName("RIMSCYCLEPERIOD");
            entity.Property(e => e.Rimsdocdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSDOCDATE");
            entity.Property(e => e.Rimsessential)
                .HasMaxLength(32)
                .HasColumnName("RIMSESSENTIAL");
            entity.Property(e => e.Rimsestablishment)
                .HasMaxLength(255)
                .HasColumnName("RIMSESTABLISHMENT");
            entity.Property(e => e.Rimslastreviewdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSLASTREVIEWDATE");
            entity.Property(e => e.Rimsmediatype)
                .HasMaxLength(32)
                .HasColumnName("RIMSMEDIATYPE");
            entity.Property(e => e.Rimsnextreviewdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSNEXTREVIEWDATE");
            entity.Property(e => e.Rimsofficial).HasColumnName("RIMSOFFICIAL");
            entity.Property(e => e.Rimsoriginator)
                .HasMaxLength(255)
                .HasColumnName("RIMSORIGINATOR");
            entity.Property(e => e.Rimsreceiveddate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSRECEIVEDDATE");
            entity.Property(e => e.Rimsretstage)
                .HasMaxLength(32)
                .HasColumnName("RIMSRETSTAGE");
            entity.Property(e => e.Rimsrsi)
                .HasMaxLength(32)
                .HasColumnName("RIMSRSI");
            entity.Property(e => e.Rimssentto)
                .HasMaxLength(4000)
                .HasColumnName("RIMSSENTTO");
            entity.Property(e => e.Rimsstagedate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSSTAGEDATE");
            entity.Property(e => e.Rimsstatus)
                .HasMaxLength(32)
                .HasColumnName("RIMSSTATUS");
            entity.Property(e => e.Rimsstatusdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSSTATUSDATE");
            entity.Property(e => e.Rimsstorage)
                .HasMaxLength(32)
                .HasColumnName("RIMSSTORAGE");
            entity.Property(e => e.Rimssubject)
                .HasMaxLength(255)
                .HasColumnName("RIMSSUBJECT");
        });

        modelBuilder.Entity<Rimstable>(entity =>
        {
            entity.HasKey(e => new { e.Tablename, e.Columnname });
            entity.ToTable("RIMSTABLES");

            entity.Property(e => e.Additionalsrchflag).HasColumnName("ADDITIONALSRCHFLAG");
            entity.Property(e => e.Advsrchflag).HasColumnName("ADVSRCHFLAG");
            entity.Property(e => e.Attribute).HasColumnName("ATTRIBUTE");
            entity.Property(e => e.Bitmap)
                .HasMaxLength(255)
                .HasColumnName("BITMAP");
            entity.Property(e => e.Coldatalength).HasColumnName("COLDATALENGTH");
            entity.Property(e => e.ColdescE)
                .HasMaxLength(128)
                .HasColumnName("COLDESC_E");
            entity.Property(e => e.ColdescF)
                .HasMaxLength(128)
                .HasColumnName("COLDESC_F");
            entity.Property(e => e.Colposition).HasColumnName("COLPOSITION");
            entity.Property(e => e.Coltype)
                .HasMaxLength(32)
                .HasColumnName("COLTYPE");
            entity.Property(e => e.Columnname)
                .HasMaxLength(128)
                .HasColumnName("COLUMNNAME");
            entity.Property(e => e.FieldDescE)
                .HasMaxLength(128)
                .HasColumnName("FIELD_DESC_E");
            entity.Property(e => e.FieldDescF)
                .HasMaxLength(128)
                .HasColumnName("FIELD_DESC_F");
            entity.Property(e => e.Lookupinfo)
                .HasMaxLength(255)
                .HasColumnName("LOOKUPINFO");
            entity.Property(e => e.Object)
                .HasMaxLength(32)
                .HasColumnName("OBJECT");
            entity.Property(e => e.Objectfield)
                .HasMaxLength(64)
                .HasColumnName("OBJECTFIELD");
            entity.Property(e => e.Quickfindflag).HasColumnName("QUICKFINDFLAG");
            entity.Property(e => e.Rimsconfigfilter).HasColumnName("RIMSCONFIGFILTER");
            entity.Property(e => e.TabledescE)
                .HasMaxLength(128)
                .HasColumnName("TABLEDESC_E");
            entity.Property(e => e.TabledescF)
                .HasMaxLength(128)
                .HasColumnName("TABLEDESC_F");
            entity.Property(e => e.Tablename)
                .HasMaxLength(128)
                .HasColumnName("TABLENAME");
        });

        modelBuilder.Entity<RmAddright>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.Privileged, e.Nodeid });
            entity.ToTable("RM_ADDRIGHTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Privileged).HasColumnName("PRIVILEGED");
            entity.Property(e => e.Type)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<RmAssignedfunction>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Funcid });
            entity.ToTable("RM_ASSIGNEDFUNCTIONS");

            entity.Property(e => e.Funcid)
                .HasColumnType("INTEGER")
                .HasColumnName("FUNCID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idtype)
                .HasColumnType("INTEGER")
                .HasColumnName("IDTYPE");
        });

        modelBuilder.Entity<RmClassification>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("RM_CLASSIFICATION");

            entity.Property(e => e.Allowrmsubfiles).HasColumnName("ALLOWRMSUBFILES");
            entity.Property(e => e.Allowrmvolumes).HasColumnName("ALLOWRMVOLUMES");
            entity.Property(e => e.Certmode).HasColumnName("CERTMODE");
            entity.Property(e => e.Closeddate)
                .HasColumnType("INTEGER")
                .HasColumnName("CLOSEDDATE");
            entity.Property(e => e.Closedflag).HasColumnName("CLOSEDFLAG");
            entity.Property(e => e.Createdate)
                .HasColumnType("INTEGER")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Cycleperiod).HasColumnName("CYCLEPERIOD");
            entity.Property(e => e.Dispauthority)
                .HasMaxLength(64)
                .HasColumnName("DISPAUTHORITY");
            entity.Property(e => e.Disposition)
                .HasMaxLength(32)
                .HasColumnName("DISPOSITION");
            entity.Property(e => e.Essential)
                .HasMaxLength(32)
                .HasColumnName("ESSENTIAL");
            entity.Property(e => e.FileStatus)
                .HasMaxLength(32)
                .HasColumnName("FILE_STATUS");
            entity.Property(e => e.FileStatusDate)
                .HasColumnType("INTEGER")
                .HasColumnName("FILE_STATUS_DATE");
            entity.Property(e => e.Filenumber)
                .HasMaxLength(64)
                .HasColumnName("FILENUMBER");
            entity.Property(e => e.Keywords)
                .HasMaxLength(4000)
                .HasColumnName("KEYWORDS");
            entity.Property(e => e.Lastadditiondate)
                .HasColumnType("INTEGER")
                .HasColumnName("LASTADDITIONDATE");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Storage)
                .HasMaxLength(32)
                .HasColumnName("STORAGE");
            entity.Property(e => e.Subject)
                .HasMaxLength(4000)
                .HasColumnName("SUBJECT");
        });

        modelBuilder.Entity<RmClassjustify>(entity =>
        {
            entity.HasKey(e => new { e.Classid, e.Justificationid });
            entity.ToTable("RM_CLASSJUSTIFY");

            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Justificationid).HasColumnName("JUSTIFICATIONID");
        });

        modelBuilder.Entity<RmDeleteaudit>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Versionnum });
            entity.ToTable("RM_DELETEAUDIT");

            entity.Property(e => e.Accession)
                .HasMaxLength(32)
                .HasColumnName("ACCESSION");
            entity.Property(e => e.Approveddate).HasColumnName("APPROVEDDATE");
            entity.Property(e => e.Approverid).HasColumnName("APPROVERID");
            entity.Property(e => e.Auditid).HasColumnName("AUDITID");
            entity.Property(e => e.Authcomment)
                .HasMaxLength(4000)
                .HasColumnName("AUTHCOMMENT");
            entity.Property(e => e.Authorityid).HasColumnName("AUTHORITYID");
            entity.Property(e => e.Authorizationdate).HasColumnName("AUTHORIZATIONDATE");
            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Classname)
                .HasMaxLength(255)
                .HasColumnName("CLASSNAME");
            entity.Property(e => e.Closeddate)
                .HasColumnType("INTEGER")
                .HasColumnName("CLOSEDDATE");
            entity.Property(e => e.Closedflag).HasColumnName("CLOSEDFLAG");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createid).HasColumnName("CREATEID");
            entity.Property(e => e.Cycleperiod).HasColumnName("CYCLEPERIOD");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dispauthority)
                .HasMaxLength(64)
                .HasColumnName("DISPAUTHORITY");
            entity.Property(e => e.Dispdestroy).HasColumnName("DISPDESTROY");
            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Essential)
                .HasMaxLength(32)
                .HasColumnName("ESSENTIAL");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filenumber)
                .HasMaxLength(64)
                .HasColumnName("FILENUMBER");
            entity.Property(e => e.Keywords)
                .HasMaxLength(4000)
                .HasColumnName("KEYWORDS");
            entity.Property(e => e.Lastadditiondate)
                .HasColumnType("INTEGER")
                .HasColumnName("LASTADDITIONDATE");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Officerdate).HasColumnName("OFFICERDATE");
            entity.Property(e => e.Officerid).HasColumnName("OFFICERID");
            entity.Property(e => e.Official).HasColumnName("OFFICIAL");
            entity.Property(e => e.Owner).HasColumnName("OWNER");
            entity.Property(e => e.Qdate).HasColumnName("QDATE");
            entity.Property(e => e.Requestdate).HasColumnName("REQUESTDATE");
            entity.Property(e => e.Requestid).HasColumnName("REQUESTID");
            entity.Property(e => e.Rimsaddressee)
                .HasMaxLength(4000)
                .HasColumnName("RIMSADDRESSEE");
            entity.Property(e => e.Rimsdocdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSDOCDATE");
            entity.Property(e => e.Rimsestablishment)
                .HasMaxLength(255)
                .HasColumnName("RIMSESTABLISHMENT");
            entity.Property(e => e.Rimslastreviewdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSLASTREVIEWDATE");
            entity.Property(e => e.Rimsnextreviewdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSNEXTREVIEWDATE");
            entity.Property(e => e.Rimsoriginator)
                .HasMaxLength(255)
                .HasColumnName("RIMSORIGINATOR");
            entity.Property(e => e.Rimsreceiveddate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSRECEIVEDDATE");
            entity.Property(e => e.Rimssentto)
                .HasMaxLength(4000)
                .HasColumnName("RIMSSENTTO");
            entity.Property(e => e.Rimsstatusdate)
                .HasColumnType("INTEGER")
                .HasColumnName("RIMSSTATUSDATE");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Status)
                .HasMaxLength(32)
                .HasColumnName("STATUS");
            entity.Property(e => e.Storage)
                .HasMaxLength(32)
                .HasColumnName("STORAGE");
            entity.Property(e => e.Subject)
                .HasMaxLength(4000)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Subtype).HasColumnName("SUBTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Workflowdelete).HasColumnName("WORKFLOWDELETE");
        });

        modelBuilder.Entity<RmDeleteauditmetadatum>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Versionnum });
            entity.ToTable("RM_DELETEAUDITMETADATA");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Tabmetadata)
                .HasMaxLength(4000)
                .HasColumnName("TABMETADATA");
            entity.Property(e => e.Tabtype)
                .HasMaxLength(255)
                .HasColumnName("TABTYPE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<RmDisposition>(entity =>
        {
            entity.HasKey(e => e.Rsi);
            entity.ToTable("RM_DISPOSITIONS");

            entity.Property(e => e.Accession)
                .HasMaxLength(32)
                .HasColumnName("ACCESSION");
            entity.Property(e => e.Action)
                .HasMaxLength(32)
                .HasColumnName("ACTION");
            entity.Property(e => e.Autoprocess).HasColumnName("AUTOPROCESS");
            entity.Property(e => e.Completeddate).HasColumnName("COMPLETEDDATE");
            entity.Property(e => e.Container).HasColumnName("CONTAINER");
            entity.Property(e => e.Defaultactioninfo)
                .HasMaxLength(32)
                .HasColumnName("DEFAULTACTIONINFO");
            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Effectivedate).HasColumnName("EFFECTIVEDATE");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Excludecontainer).HasColumnName("EXCLUDECONTAINER");
            entity.Property(e => e.Fromadvsearch).HasColumnName("FROMADVSEARCH");
            entity.Property(e => e.Fromdate).HasColumnName("FROMDATE");
            entity.Property(e => e.Makerendition).HasColumnName("MAKERENDITION");
            entity.Property(e => e.Maximumretention).HasColumnName("MAXIMUMRETENTION");
            entity.Property(e => e.Multisnapshots).HasColumnName("MULTISNAPSHOTS");
            entity.Property(e => e.Objecttype).HasColumnName("OBJECTTYPE");
            entity.Property(e => e.Objecttypes)
                .HasMaxLength(4000)
                .HasColumnName("OBJECTTYPES");
            entity.Property(e => e.Recordcount).HasColumnName("RECORDCOUNT");
            entity.Property(e => e.Retstage)
                .HasMaxLength(32)
                .HasColumnName("RETSTAGE");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Runstatus).HasColumnName("RUNSTATUS");
            entity.Property(e => e.Savedqueryid).HasColumnName("SAVEDQUERYID");
            entity.Property(e => e.Schedfloatdate)
                .HasMaxLength(32)
                .HasColumnName("SCHEDFLOATDATE");
            entity.Property(e => e.Schednextrun).HasColumnName("SCHEDNEXTRUN");
            entity.Property(e => e.Schedrecurtype)
                .HasMaxLength(32)
                .HasColumnName("SCHEDRECURTYPE");
            entity.Property(e => e.Schedtimeofday)
                .HasMaxLength(32)
                .HasColumnName("SCHEDTIMEOFDAY");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
            entity.Property(e => e.Todate).HasColumnName("TODATE");
        });

        modelBuilder.Entity<RmDispositionactionerror>(entity =>
        {
            entity.HasKey(e => new { e.Dispnodeid, e.Qdate });
            entity.ToTable("RM_DISPOSITIONACTIONERRORS");

            entity.Property(e => e.Action)
                .HasMaxLength(32)
                .HasColumnName("ACTION");
            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Errorcode)
                .HasColumnType("INTEGER")
                .HasColumnName("ERRORCODE");
            entity.Property(e => e.Errordate).HasColumnName("ERRORDATE");
            entity.Property(e => e.Errorstring)
                .HasMaxLength(255)
                .HasColumnName("ERRORSTRING");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Qdate).HasColumnName("QDATE");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Verfilename)
                .HasMaxLength(255)
                .HasColumnName("VERFILENAME");
        });

        modelBuilder.Entity<RmDispresult>(entity =>
        {
            entity.HasKey(e => e.Dispnodeid);
            entity.ToTable("RM_DISPRESULTS");

            entity.Property(e => e.Action)
                .HasMaxLength(32)
                .HasColumnName("ACTION");
            entity.Property(e => e.Actionperformed).HasColumnName("ACTIONPERFORMED");
            entity.Property(e => e.Advversioning).HasColumnName("ADVVERSIONING");
            entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");
            entity.Property(e => e.Approveddate).HasColumnName("APPROVEDDATE");
            entity.Property(e => e.Approverid).HasColumnName("APPROVERID");
            entity.Property(e => e.Calculateddate).HasColumnName("CALCULATEDDATE");
            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Defaultactioninfo)
                .HasMaxLength(32)
                .HasColumnName("DEFAULTACTIONINFO");
            entity.Property(e => e.Deletedchildkey).HasColumnName("DELETEDCHILDKEY");
            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Filenumber)
                .HasMaxLength(64)
                .HasColumnName("FILENUMBER");
            entity.Property(e => e.Makerendition).HasColumnName("MAKERENDITION");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Numverstokeep).HasColumnName("NUMVERSTOKEEP");
            entity.Property(e => e.Process).HasColumnName("PROCESS");
            entity.Property(e => e.Purgemajors).HasColumnName("PURGEMAJORS");
            entity.Property(e => e.Purgesuperseded).HasColumnName("PURGESUPERSEDED");
            entity.Property(e => e.Qdate).HasColumnName("QDATE");
            entity.Property(e => e.Reviewerid).HasColumnName("REVIEWERID");
            entity.Property(e => e.Reviewerid2).HasColumnName("REVIEWERID2");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Stagecount).HasColumnName("STAGECOUNT");
        });

        modelBuilder.Entity<RmDispresultsver>(entity =>
        {
            entity.HasKey(e => new { e.Dispnodeid, e.Nodeid, e.Qdate, e.Versionid });
            entity.ToTable("RM_DISPRESULTSVERS");

            entity.Property(e => e.Calculateddate).HasColumnName("CALCULATEDDATE");
            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Majorrel).HasColumnName("MAJORREL");
            entity.Property(e => e.Minor).HasColumnName("MINOR");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Qdate).HasColumnName("QDATE");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Version).HasColumnName("VERSION");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
        });

        modelBuilder.Entity<RmDispreviewcomment>(entity =>
        {
            entity.HasKey(e => new { e.Dispnodeid, e.Qdate });
            entity.ToTable("RM_DISPREVIEWCOMMENTS");

            entity.Property(e => e.Commentdate).HasColumnName("COMMENTDATE");
            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Qdate).HasColumnName("QDATE");
            entity.Property(e => e.Reviewcomment)
                .HasMaxLength(255)
                .HasColumnName("REVIEWCOMMENT");
            entity.Property(e => e.Stagecount).HasColumnName("STAGECOUNT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RmDispreviewer>(entity =>
        {
            entity.HasKey(e => new { e.Dispnodeid, e.Qdate });
            entity.ToTable("RM_DISPREVIEWERS");

            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Notificationdate).HasColumnName("NOTIFICATIONDATE");
            entity.Property(e => e.Overduecount).HasColumnName("OVERDUECOUNT");
            entity.Property(e => e.Overdueemaildate).HasColumnName("OVERDUEEMAILDATE");
            entity.Property(e => e.Qdate).HasColumnName("QDATE");
            entity.Property(e => e.Recordcount).HasColumnName("RECORDCOUNT");
            entity.Property(e => e.Reviewerid).HasColumnName("REVIEWERID");
            entity.Property(e => e.Reviewerstep).HasColumnName("REVIEWERSTEP");
            entity.Property(e => e.Reviewstatus).HasColumnName("REVIEWSTATUS");
        });

        modelBuilder.Entity<RmDispsetting>(entity =>
        {
            entity.HasKey(e => new { e.Dispnodeid, e.Settingkey });
            entity.ToTable("RM_DISPSETTINGS");

            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Settingkey)
                .HasMaxLength(255)
                .HasColumnName("SETTINGKEY");
            entity.Property(e => e.Settingvalue)
                .HasMaxLength(4000)
                .HasColumnName("SETTINGVALUE");
        });

        modelBuilder.Entity<RmDispsnapshot>(entity =>
        {
            entity.HasKey(e => new { e.Dispnodeid, e.Qdate });
            entity.ToTable("RM_DISPSNAPSHOTS");

            entity.Property(e => e.Cacheid).HasColumnName("CACHEID");
            entity.Property(e => e.Dispnodeid).HasColumnName("DISPNODEID");
            entity.Property(e => e.Qdate).HasColumnName("QDATE");
            entity.Property(e => e.Recordcount)
                .HasColumnType("INTEGER")
                .HasColumnName("RECORDCOUNT");
            entity.Property(e => e.Reviewerstep).HasColumnName("REVIEWERSTEP");
            entity.Property(e => e.Reviewstatus).HasColumnName("REVIEWSTATUS");
            entity.Property(e => e.Settings)
                .HasMaxLength(4000)
                .HasColumnName("SETTINGS");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<RmDocrectype>(entity =>
        {
            entity.HasKey(e => new { e.Recordtypeid, e.Dataid });
            entity.ToTable("RM_DOCRECTYPE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Recordtypeid).HasColumnName("RECORDTYPEID");
        });

        modelBuilder.Entity<RmDocxref>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Docxreftyp, e.Xdataid });
            entity.ToTable("RM_DOCXREF");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Docxrefcomment)
                .HasMaxLength(255)
                .HasColumnName("DOCXREFCOMMENT");
            entity.Property(e => e.Docxreftyp)
                .HasMaxLength(32)
                .HasColumnName("DOCXREFTYP");
            entity.Property(e => e.Origid).HasColumnName("ORIGID");
            entity.Property(e => e.Vernum).HasColumnName("VERNUM");
            entity.Property(e => e.Xdataid).HasColumnName("XDATAID");
        });

        modelBuilder.Entity<RmFixedret>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("RM_FIXEDRET");

            entity.Property(e => e.Currentret).HasColumnName("CURRENTRET");
            entity.Property(e => e.Infinite).HasColumnName("INFINITE");
            entity.Property(e => e.Initialret).HasColumnName("INITIALRET");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<RmFunction>(entity =>
        {
            entity.HasKey(e => e.Funcid);
            entity.ToTable("RM_FUNCTIONS");

            entity.Property(e => e.Custmodule).HasColumnName("CUSTMODULE");
            entity.Property(e => e.Funcid).HasColumnName("FUNCID");
            entity.Property(e => e.Functionname)
                .HasMaxLength(128)
                .HasColumnName("FUNCTIONNAME");
        });

        modelBuilder.Entity<RmHoldquery>(entity =>
        {
            entity.HasKey(e => new { e.Holdid, e.Queryid });
            entity.ToTable("RM_HOLDQUERY");

            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Queryid).HasColumnName("QUERYID");
            entity.Property(e => e.Runstatus).HasColumnName("RUNSTATUS");
        });

        modelBuilder.Entity<RmHoldqueryhistory>(entity =>
        {
            entity.HasKey(e => e.Eventid);
            entity.ToTable("RM_HOLDQUERYHISTORY");

            entity.Property(e => e.Action).HasColumnName("ACTION");
            entity.Property(e => e.Auditdate).HasColumnName("AUDITDATE");
            entity.Property(e => e.Audituser).HasColumnName("AUDITUSER");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Eventid).HasColumnName("EVENTID");
            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Querydetails)
                .HasColumnType("NCLOB")
                .HasColumnName("QUERYDETAILS");
            entity.Property(e => e.Queryid).HasColumnName("QUERYID");
            entity.Property(e => e.Queryname)
                .HasMaxLength(248)
                .HasColumnName("QUERYNAME");
            entity.Property(e => e.Updateno).HasColumnName("UPDATENO");
        });

        modelBuilder.Entity<RmKini>(entity =>
        {
            entity.HasKey(e => new { e.Inisection, e.Inikeyword });
            entity.ToTable("RM_KINI");

            entity.Property(e => e.Inikeyword)
                .HasMaxLength(128)
                .HasColumnName("INIKEYWORD");
            entity.Property(e => e.Inisection)
                .HasMaxLength(128)
                .HasColumnName("INISECTION");
            entity.Property(e => e.Inivalue)
                .HasMaxLength(255)
                .HasColumnName("INIVALUE");
        });

        modelBuilder.Entity<RmLinkr>(entity =>
        {
            entity.HasKey(e => e.Rscode);
            entity.ToTable("RM_LINKRS");

            entity.Property(e => e.RsaRrCode)
                .HasMaxLength(32)
                .HasColumnName("RSA_RR_CODE");
            entity.Property(e => e.RsaTotRet)
                .HasMaxLength(32)
                .HasColumnName("RSA_TOT_RET");
            entity.Property(e => e.RsaUnRet)
                .HasMaxLength(32)
                .HasColumnName("RSA_UN_RET");
            entity.Property(e => e.Rscode)
                .HasMaxLength(32)
                .HasColumnName("RSCODE");
            entity.Property(e => e.Rsdesc)
                .HasMaxLength(4000)
                .HasColumnName("RSDESC");
            entity.Property(e => e.Rsnote)
                .HasMaxLength(4000)
                .HasColumnName("RSNOTE");
            entity.Property(e => e.RsretoAlpha)
                .HasMaxLength(32)
                .HasColumnName("RSRETO_ALPHA");
            entity.Property(e => e.RsretoExp)
                .HasMaxLength(128)
                .HasColumnName("RSRETO_EXP");
            entity.Property(e => e.RsretoNumber)
                .HasMaxLength(32)
                .HasColumnName("RSRETO_NUMBER");
            entity.Property(e => e.RsretoPlus)
                .HasMaxLength(32)
                .HasColumnName("RSRETO_PLUS");
            entity.Property(e => e.RsretoType)
                .HasMaxLength(32)
                .HasColumnName("RSRETO_TYPE");
            entity.Property(e => e.RsretoUnits)
                .HasMaxLength(32)
                .HasColumnName("RSRETO_UNITS");
            entity.Property(e => e.RsretuAlpha)
                .HasMaxLength(32)
                .HasColumnName("RSRETU_ALPHA");
            entity.Property(e => e.RsretuNumber)
                .HasMaxLength(32)
                .HasColumnName("RSRETU_NUMBER");
            entity.Property(e => e.RsretuPlus)
                .HasMaxLength(32)
                .HasColumnName("RSRETU_PLUS");
            entity.Property(e => e.RsretuType)
                .HasMaxLength(32)
                .HasColumnName("RSRETU_TYPE");
            entity.Property(e => e.RsretuUnits)
                .HasMaxLength(32)
                .HasColumnName("RSRETU_UNITS");
            entity.Property(e => e.Rssubj1)
                .HasMaxLength(128)
                .HasColumnName("RSSUBJ1");
            entity.Property(e => e.Rssubj2)
                .HasMaxLength(128)
                .HasColumnName("RSSUBJ2");
            entity.Property(e => e.Rssubj3)
                .HasMaxLength(128)
                .HasColumnName("RSSUBJ3");
            entity.Property(e => e.Rssubj4)
                .HasMaxLength(128)
                .HasColumnName("RSSUBJ4");
            entity.Property(e => e.Rssubj5)
                .HasMaxLength(128)
                .HasColumnName("RSSUBJ5");
            entity.Property(e => e.Rstitle)
                .HasMaxLength(128)
                .HasColumnName("RSTITLE");
        });

        modelBuilder.Entity<RmLinkrr>(entity =>
        {
            entity.HasKey(e => e.Rrcode);
            entity.ToTable("RM_LINKRR");

            entity.Property(e => e.RraTotRet)
                .HasMaxLength(32)
                .HasColumnName("RRA_TOT_RET");
            entity.Property(e => e.RraUnRet)
                .HasMaxLength(32)
                .HasColumnName("RRA_UN_RET");
            entity.Property(e => e.Rrcode)
                .HasMaxLength(32)
                .HasColumnName("RRCODE");
            entity.Property(e => e.Rrdesc)
                .HasMaxLength(4000)
                .HasColumnName("RRDESC");
            entity.Property(e => e.Rrnote)
                .HasMaxLength(4000)
                .HasColumnName("RRNOTE");
            entity.Property(e => e.RrretoAlpha)
                .HasMaxLength(32)
                .HasColumnName("RRRETO_ALPHA");
            entity.Property(e => e.RrretoExp)
                .HasMaxLength(128)
                .HasColumnName("RRRETO_EXP");
            entity.Property(e => e.RrretoNumber)
                .HasMaxLength(32)
                .HasColumnName("RRRETO_NUMBER");
            entity.Property(e => e.RrretoPlus)
                .HasMaxLength(32)
                .HasColumnName("RRRETO_PLUS");
            entity.Property(e => e.RrretoType)
                .HasMaxLength(32)
                .HasColumnName("RRRETO_TYPE");
            entity.Property(e => e.RrretoUnits)
                .HasMaxLength(32)
                .HasColumnName("RRRETO_UNITS");
            entity.Property(e => e.RrretuAlpha)
                .HasMaxLength(32)
                .HasColumnName("RRRETU_ALPHA");
            entity.Property(e => e.RrretuNumber)
                .HasMaxLength(32)
                .HasColumnName("RRRETU_NUMBER");
            entity.Property(e => e.RrretuPlus)
                .HasMaxLength(32)
                .HasColumnName("RRRETU_PLUS");
            entity.Property(e => e.RrretuType)
                .HasMaxLength(32)
                .HasColumnName("RRRETU_TYPE");
            entity.Property(e => e.RrretuUnits)
                .HasMaxLength(32)
                .HasColumnName("RRRETU_UNITS");
            entity.Property(e => e.Rrsubj1)
                .HasMaxLength(128)
                .HasColumnName("RRSUBJ1");
            entity.Property(e => e.Rrsubj2)
                .HasMaxLength(128)
                .HasColumnName("RRSUBJ2");
            entity.Property(e => e.Rrsubj3)
                .HasMaxLength(128)
                .HasColumnName("RRSUBJ3");
            entity.Property(e => e.Rrsubj4)
                .HasMaxLength(128)
                .HasColumnName("RRSUBJ4");
            entity.Property(e => e.Rrsubj5)
                .HasMaxLength(128)
                .HasColumnName("RRSUBJ5");
            entity.Property(e => e.Rrtitle)
                .HasMaxLength(128)
                .HasColumnName("RRTITLE");
        });

        modelBuilder.Entity<RmMulticlass>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("RM_MULTICLASS");

            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Delelecflag).HasColumnName("DELELECFLAG");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
        });

        modelBuilder.Entity<RmObjecthold>(entity =>
        {
            entity.HasKey(e => new { e.Holdid, e.Userid });
            entity.ToTable("RM_OBJECTHOLD");

            entity.Property(e => e.Activehold).HasColumnName("ACTIVEHOLD");
            entity.Property(e => e.Applycomments)
                .HasMaxLength(255)
                .HasColumnName("APPLYCOMMENTS");
            entity.Property(e => e.Docxreftyp)
                .HasMaxLength(32)
                .HasColumnName("DOCXREFTYP");
            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Queryid).HasColumnName("QUERYID");
            entity.Property(e => e.Uniquerunid).HasColumnName("UNIQUERUNID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RmPartrecord>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Partid });
            entity.ToTable("RM_PARTRECORDS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Partid).HasColumnName("PARTID");
        });

        modelBuilder.Entity<RmPicklist>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Classid, e.Createdate });
            entity.ToTable("RM_PICKLIST");

            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RmProvenance>(entity =>
        {
            entity.HasKey(e => e.Nodeid);
            entity.ToTable("RM_PROVENANCE");

            entity.Property(e => e.Disableflag).HasColumnName("DISABLEFLAG");
            entity.Property(e => e.Editdate).HasColumnName("EDITDATE");
            entity.Property(e => e.Editpatron)
                .HasMaxLength(32)
                .HasColumnName("EDITPATRON");
            entity.Property(e => e.Lastadditiondate)
                .HasColumnType("INTEGER")
                .HasColumnName("LASTADDITIONDATE");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Previousparentid).HasColumnName("PREVIOUSPARENTID");
            entity.Property(e => e.Provalternatedesc)
                .HasMaxLength(4000)
                .HasColumnName("PROVALTERNATEDESC");
            entity.Property(e => e.Provalternatename)
                .HasMaxLength(248)
                .HasColumnName("PROVALTERNATENAME");
            entity.Property(e => e.Provenancetype)
                .HasMaxLength(32)
                .HasColumnName("PROVENANCETYPE");
            entity.Property(e => e.Provenddate).HasColumnName("PROVENDDATE");
            entity.Property(e => e.Provstartdate).HasColumnName("PROVSTARTDATE");
            entity.Property(e => e.Provtext)
                .HasMaxLength(4000)
                .HasColumnName("PROVTEXT");
        });

        modelBuilder.Entity<RmProvenancehistory>(entity =>
        {
            entity.HasKey(e => new { e.Nodeid, e.Editdate, e.Editpatron });
            entity.ToTable("RM_PROVENANCEHISTORY");

            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Disableflag).HasColumnName("DISABLEFLAG");
            entity.Property(e => e.Editdate).HasColumnName("EDITDATE");
            entity.Property(e => e.Editpatron)
                .HasMaxLength(32)
                .HasColumnName("EDITPATRON");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Provalternatedesc)
                .HasMaxLength(4000)
                .HasColumnName("PROVALTERNATEDESC");
            entity.Property(e => e.Provalternatename)
                .HasMaxLength(248)
                .HasColumnName("PROVALTERNATENAME");
            entity.Property(e => e.Provenancetype)
                .HasMaxLength(32)
                .HasColumnName("PROVENANCETYPE");
            entity.Property(e => e.Provenddate).HasColumnName("PROVENDDATE");
            entity.Property(e => e.Provstartdate).HasColumnName("PROVSTARTDATE");
            entity.Property(e => e.Provtext)
                .HasMaxLength(4000)
                .HasColumnName("PROVTEXT");
        });

        modelBuilder.Entity<RmRecordsmanager>(entity =>
        {
            entity.HasKey(e => new { e.Groupid, e.Recmangrid });
            entity.ToTable("RM_RECORDSMANAGERS");

            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Recmangrid).HasColumnName("RECMANGRID");
        });

        modelBuilder.Entity<RmRecordsofficer>(entity =>
        {
            entity.HasKey(e => new { e.Groupid, e.Recoffid });
            entity.ToTable("RM_RECORDSOFFICERS");

            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Primaryrecoff).HasColumnName("PRIMARYRECOFF");
            entity.Property(e => e.Recoffid).HasColumnName("RECOFFID");
        });

        modelBuilder.Entity<RmRecordtypedatum>(entity =>
        {
            entity.HasKey(e => e.Recordtypeid);
            entity.ToTable("RM_RECORDTYPEDATA");

            entity.Property(e => e.Defaulttype).HasColumnName("DEFAULTTYPE");
            entity.Property(e => e.Recordtypeid).HasColumnName("RECORDTYPEID");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
        });

        modelBuilder.Entity<RmStat>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.Dataid, e.Usergroupid, e.Serverthread, e.Valuekey, e.Valuekey1 });
            entity.ToTable("RM_STATS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Recordcount)
                .HasColumnType("INTEGER")
                .HasColumnName("RECORDCOUNT");
            entity.Property(e => e.Rundate).HasColumnName("RUNDATE");
            entity.Property(e => e.Serverthread)
                .HasMaxLength(255)
                .HasColumnName("SERVERTHREAD");
            entity.Property(e => e.Type)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPE");
            entity.Property(e => e.Usergroupid).HasColumnName("USERGROUPID");
            entity.Property(e => e.Valuekey)
                .HasMaxLength(255)
                .HasColumnName("VALUEKEY");
            entity.Property(e => e.Valuekey1)
                .HasMaxLength(255)
                .HasColumnName("VALUEKEY1");
        });

        modelBuilder.Entity<RmStatusacl>(entity =>
        {
            entity.HasKey(e => new { e.Status, e.Rightid });
            entity.ToTable("RM_STATUSACL");

            entity.Property(e => e.Acltype)
                .HasColumnType("INTEGER")
                .HasColumnName("ACLTYPE");
            entity.Property(e => e.Permissions).HasColumnName("PERMISSIONS");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.Status)
                .HasMaxLength(32)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<RmTempdatum>(entity =>
        {
            entity.HasKey(e => new { e.Tempkey, e.Nodeid, e.Userid });
            entity.ToTable("RM_TEMPDATA");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Permsmask)
                .HasColumnType("INTEGER")
                .HasColumnName("PERMSMASK");
            entity.Property(e => e.Tdate).HasColumnName("TDATE");
            entity.Property(e => e.Tempkey)
                .HasMaxLength(64)
                .HasColumnName("TEMPKEY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value1)
                .HasMaxLength(32)
                .HasColumnName("VALUE1");
        });

        modelBuilder.Entity<RmUseraudit>(entity =>
        {
            entity.HasKey(e => new { e.Auditid, e.Dataid, e.Userid });
            entity.ToTable("RM_USERAUDIT");

            entity.Property(e => e.Auditdate).HasColumnName("AUDITDATE");
            entity.Property(e => e.Auditid).HasColumnName("AUDITID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasColumnName("EVENT");
            entity.Property(e => e.Eventdesc)
                .HasMaxLength(255)
                .HasColumnName("EVENTDESC");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RmUserhold>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Holdid });
            entity.ToTable("RM_USERHOLD");

            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RmUserholdcriterion>(entity =>
        {
            entity.HasKey(e => e.Holdid);
            entity.ToTable("RM_USERHOLDCRITERIA");

            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Holdid).HasColumnName("HOLDID");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<RmsecClearance>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Clearance });
            entity.ToTable("RMSEC_CLEARANCE");

            entity.Property(e => e.Clearance)
                .HasColumnType("INTEGER")
                .HasColumnName("CLEARANCE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<RmsecDefinedrule>(entity =>
        {
            entity.HasKey(e => e.Ruledate);
            entity.ToTable("RMSEC_DEFINEDRULES");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Processed)
                .HasColumnType("INTEGER")
                .HasColumnName("PROCESSED");
            entity.Property(e => e.Ruleaction).HasColumnName("RULEACTION");
            entity.Property(e => e.Ruledate).HasColumnName("RULEDATE");
            entity.Property(e => e.Ruleid).HasColumnName("RULEID");
            entity.Property(e => e.Rulereason)
                .HasMaxLength(255)
                .HasColumnName("RULEREASON");
            entity.Property(e => e.Rulevalue)
                .HasMaxLength(32)
                .HasColumnName("RULEVALUE");
        });

        modelBuilder.Entity<RmsecDocclearance>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("RMSEC_DOCCLEARANCE");

            entity.Property(e => e.Classifiedby)
                .HasMaxLength(255)
                .HasColumnName("CLASSIFIEDBY");
            entity.Property(e => e.Classifyingagency)
                .HasMaxLength(255)
                .HasColumnName("CLASSIFYINGAGENCY");
            entity.Property(e => e.Currentsecurity)
                .HasColumnType("INTEGER")
                .HasColumnName("CURRENTSECURITY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datedirty).HasColumnName("DATEDIRTY");
            entity.Property(e => e.Declassifiedby)
                .HasMaxLength(255)
                .HasColumnName("DECLASSIFIEDBY");
            entity.Property(e => e.Declassifiedon).HasColumnName("DECLASSIFIEDON");
            entity.Property(e => e.Declassifydate).HasColumnName("DECLASSIFYDATE");
            entity.Property(e => e.Declassifyevent)
                .HasMaxLength(255)
                .HasColumnName("DECLASSIFYEVENT");
            entity.Property(e => e.Declassifytype).HasColumnName("DECLASSIFYTYPE");
            entity.Property(e => e.Derivedfrom)
                .HasMaxLength(255)
                .HasColumnName("DERIVEDFROM");
            entity.Property(e => e.Downgradedate).HasColumnName("DOWNGRADEDATE");
            entity.Property(e => e.Downgradedby)
                .HasMaxLength(255)
                .HasColumnName("DOWNGRADEDBY");
            entity.Property(e => e.Downgradedon).HasColumnName("DOWNGRADEDON");
            entity.Property(e => e.Downgradeevent)
                .HasMaxLength(255)
                .HasColumnName("DOWNGRADEEVENT");
            entity.Property(e => e.Downgradeinst)
                .HasMaxLength(255)
                .HasColumnName("DOWNGRADEINST");
            entity.Property(e => e.Downgradetype).HasColumnName("DOWNGRADETYPE");
            entity.Property(e => e.Exemptioncats)
                .HasMaxLength(255)
                .HasColumnName("EXEMPTIONCATS");
            entity.Property(e => e.Initialsecurity)
                .HasColumnType("INTEGER")
                .HasColumnName("INITIALSECURITY");
            entity.Property(e => e.Reasonsfor)
                .HasMaxLength(255)
                .HasColumnName("REASONSFOR");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(255)
                .HasColumnName("REVIEWEDBY");
            entity.Property(e => e.Reviewedon).HasColumnName("REVIEWEDON");
            entity.Property(e => e.Upgradedby)
                .HasMaxLength(255)
                .HasColumnName("UPGRADEDBY");
            entity.Property(e => e.Upgradedon).HasColumnName("UPGRADEDON");
            entity.Property(e => e.Upgradereasons)
                .HasMaxLength(255)
                .HasColumnName("UPGRADEREASONS");
        });

        modelBuilder.Entity<RmsecDocoption>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("RMSEC_DOCOPTIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Requiredlevelforsubitems)
                .HasColumnType("INTEGER")
                .HasColumnName("REQUIREDLEVELFORSUBITEMS");
            entity.Property(e => e.Requiredmarkingsforsubitems)
                .HasColumnType("INTEGER")
                .HasColumnName("REQUIREDMARKINGSFORSUBITEMS");
        });

        modelBuilder.Entity<RmsecDocsuppmark>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Suppmark });
            entity.ToTable("RMSEC_DOCSUPPMARK");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Suppmark)
                .HasMaxLength(32)
                .HasColumnName("SUPPMARK");
        });

        modelBuilder.Entity<RmsecSecurity>(entity =>
        {
            entity.HasKey(e => e.Securitylevel);
            entity.ToTable("RMSEC_SECURITY");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("NAME");
            entity.Property(e => e.Securitylevel)
                .HasColumnType("INTEGER")
                .HasColumnName("SECURITYLEVEL");
        });

        modelBuilder.Entity<RmsecSecurityguide>(entity =>
        {
            entity.HasKey(e => e.Securityguideid);
            entity.ToTable("RMSEC_SECURITYGUIDE");

            entity.Property(e => e.Declassifydate).HasColumnName("DECLASSIFYDATE");
            entity.Property(e => e.Declassifyevent)
                .HasMaxLength(255)
                .HasColumnName("DECLASSIFYEVENT");
            entity.Property(e => e.Declassifytype).HasColumnName("DECLASSIFYTYPE");
            entity.Property(e => e.Exemptioncats)
                .HasMaxLength(255)
                .HasColumnName("EXEMPTIONCATS");
            entity.Property(e => e.Guideremarks)
                .HasMaxLength(255)
                .HasColumnName("GUIDEREMARKS");
            entity.Property(e => e.Inforevealing)
                .HasMaxLength(255)
                .HasColumnName("INFOREVEALING");
            entity.Property(e => e.Reasonsfor)
                .HasMaxLength(255)
                .HasColumnName("REASONSFOR");
            entity.Property(e => e.Securityguideid).HasColumnName("SECURITYGUIDEID");
            entity.Property(e => e.Securitylevel)
                .HasColumnType("INTEGER")
                .HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.Supplementalmarkings)
                .HasMaxLength(255)
                .HasColumnName("SUPPLEMENTALMARKINGS");
        });

        modelBuilder.Entity<RmsecSessioncode>(entity =>
        {
            entity.HasKey(e => e.Sessioncode);
            entity.ToTable("RMSEC_SESSIONCODE");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Sessioncode)
                .HasMaxLength(32)
                .HasColumnName("SESSIONCODE");
        });

        modelBuilder.Entity<RmsecSessionmarking>(entity =>
        {
            entity.HasKey(e => new { e.Sessioncode, e.Suppmark });
            entity.ToTable("RMSEC_SESSIONMARKING");

            entity.Property(e => e.Sessioncode)
                .HasMaxLength(32)
                .HasColumnName("SESSIONCODE");
            entity.Property(e => e.Suppmark)
                .HasMaxLength(32)
                .HasColumnName("SUPPMARK");
        });

        modelBuilder.Entity<RmsecStat>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.Dataid, e.Usergroupid, e.Serverthread, e.Valuekey, e.Valuekey1, e.Rundate });
            entity.ToTable("RMSEC_STATS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Recordcount)
                .HasColumnType("INTEGER")
                .HasColumnName("RECORDCOUNT");
            entity.Property(e => e.Rundate).HasColumnName("RUNDATE");
            entity.Property(e => e.Serverthread)
                .HasMaxLength(255)
                .HasColumnName("SERVERTHREAD");
            entity.Property(e => e.Type)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPE");
            entity.Property(e => e.Usergroupid).HasColumnName("USERGROUPID");
            entity.Property(e => e.Valuekey)
                .HasMaxLength(255)
                .HasColumnName("VALUEKEY");
            entity.Property(e => e.Valuekey1)
                .HasMaxLength(255)
                .HasColumnName("VALUEKEY1");
        });

        modelBuilder.Entity<RmsecSuppmark>(entity =>
        {
            entity.HasKey(e => e.Suppmark);
            entity.ToTable("RMSEC_SUPPMARK");

            entity.Property(e => e.Bitmask)
                .HasColumnType("INTEGER")
                .HasColumnName("BITMASK");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Suppmark)
                .HasMaxLength(32)
                .HasColumnName("SUPPMARK");
        });

        modelBuilder.Entity<RmsecTempdatum>(entity =>
        {
            entity.HasKey(e => new { e.Tempkey, e.Nodeid, e.Userid });
            entity.ToTable("RMSEC_TEMPDATA");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Permsmask)
                .HasColumnType("INTEGER")
                .HasColumnName("PERMSMASK");
            entity.Property(e => e.Tdate).HasColumnName("TDATE");
            entity.Property(e => e.Tempkey)
                .HasMaxLength(32)
                .HasColumnName("TEMPKEY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value1)
                .HasMaxLength(32)
                .HasColumnName("VALUE1");
        });

        modelBuilder.Entity<RmsecUsersuppmark>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Suppmark });
            entity.ToTable("RMSEC_USERSUPPMARKS");

            entity.Property(e => e.Suppmark)
                .HasMaxLength(32)
                .HasColumnName("SUPPMARK");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Rsi>(entity =>
        {
            entity.HasKey(e => e.Rsi1);
            entity.ToTable("RSI");

            entity.Property(e => e.Active)
                .HasMaxLength(32)
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Activeper)
                .HasColumnType("DECIMAL")
                .HasColumnName("ACTIVEPER");
            entity.Property(e => e.Archcomment)
                .HasMaxLength(255)
                .HasColumnName("ARCHCOMMENT");
            entity.Property(e => e.Archivalflag).HasColumnName("ARCHIVALFLAG");
            entity.Property(e => e.Archiveflag).HasColumnName("ARCHIVEFLAG");
            entity.Property(e => e.Archstatus)
                .HasMaxLength(32)
                .HasColumnName("ARCHSTATUS");
            entity.Property(e => e.Archstatusdate).HasColumnName("ARCHSTATUSDATE");
            entity.Property(e => e.BatchIndexFlag)
                .HasMaxLength(32)
                .HasColumnName("BATCH_INDEX_FLAG");
            entity.Property(e => e.Completeddate).HasColumnName("COMPLETEDDATE");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Discontcomment)
                .HasMaxLength(255)
                .HasColumnName("DISCONTCOMMENT");
            entity.Property(e => e.Discontdate).HasColumnName("DISCONTDATE");
            entity.Property(e => e.Discontflag).HasColumnName("DISCONTFLAG");
            entity.Property(e => e.Dispcontrol).HasColumnName("DISPCONTROL");
            entity.Property(e => e.Disposition)
                .HasMaxLength(32)
                .HasColumnName("DISPOSITION");
            entity.Property(e => e.Dormant)
                .HasMaxLength(32)
                .HasColumnName("DORMANT");
            entity.Property(e => e.Dormantper)
                .HasColumnType("DECIMAL")
                .HasColumnName("DORMANTPER");
            entity.Property(e => e.Editdate).HasColumnName("EDITDATE");
            entity.Property(e => e.Editpatron)
                .HasMaxLength(32)
                .HasColumnName("EDITPATRON");
            entity.Property(e => e.Patron)
                .HasMaxLength(32)
                .HasColumnName("PATRON");
            entity.Property(e => e.Profileformcode)
                .HasMaxLength(32)
                .HasColumnName("PROFILEFORMCODE");
            entity.Property(e => e.Receiveddate).HasColumnName("RECEIVEDDATE");
            entity.Property(e => e.Refrate)
                .HasMaxLength(32)
                .HasColumnName("REFRATE");
            entity.Property(e => e.Requesteddate).HasColumnName("REQUESTEDDATE");
            entity.Property(e => e.Retentionid).HasColumnName("RETENTIONID");
            entity.Property(e => e.RmRsi).HasColumnName("RM_RSI");
            entity.Property(e => e.Rsi1)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.RsidescE)
                .HasMaxLength(4000)
                .HasColumnName("RSIDESC_E");
            entity.Property(e => e.RsidescF)
                .HasMaxLength(4000)
                .HasColumnName("RSIDESC_F");
            entity.Property(e => e.Rsinoteflag).HasColumnName("RSINOTEFLAG");
            entity.Property(e => e.Rsistatus)
                .HasMaxLength(32)
                .HasColumnName("RSISTATUS");
            entity.Property(e => e.RsisubjectE)
                .HasMaxLength(255)
                .HasColumnName("RSISUBJECT_E");
            entity.Property(e => e.RsisubjectF)
                .HasMaxLength(255)
                .HasColumnName("RSISUBJECT_F");
            entity.Property(e => e.RsititleE)
                .HasMaxLength(255)
                .HasColumnName("RSITITLE_E");
            entity.Property(e => e.RsititleF)
                .HasMaxLength(255)
                .HasColumnName("RSITITLE_F");
            entity.Property(e => e.Sortkey)
                .HasMaxLength(64)
                .HasColumnName("SORTKEY");
            entity.Property(e => e.Statusdate).HasColumnName("STATUSDATE");
            entity.Property(e => e.Totalperiod)
                .HasMaxLength(64)
                .HasColumnName("TOTALPERIOD");
            entity.Property(e => e.Uniqueid).HasColumnName("UNIQUEID");
            entity.Property(e => e.Vitalcode)
                .HasMaxLength(32)
                .HasColumnName("VITALCODE");
            entity.Property(e => e.Vitalstor)
                .HasMaxLength(32)
                .HasColumnName("VITALSTOR");
        });

        modelBuilder.Entity<Rsiapproval>(entity =>
        {
            entity.HasKey(e => new { e.Rsi, e.Rsischeduleid, e.Approvaleditdate });
            entity.ToTable("RSIAPPROVAL");

            entity.Property(e => e.Approvalcomment)
                .HasMaxLength(255)
                .HasColumnName("APPROVALCOMMENT");
            entity.Property(e => e.Approvaleditdate).HasColumnName("APPROVALEDITDATE");
            entity.Property(e => e.Approvaledituserid).HasColumnName("APPROVALEDITUSERID");
            entity.Property(e => e.Approvedbyuserid).HasColumnName("APPROVEDBYUSERID");
            entity.Property(e => e.Approveddate).HasColumnName("APPROVEDDATE");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Rsischeduleid).HasColumnName("RSISCHEDULEID");
        });

        modelBuilder.Entity<Rsiapprovalhistory>(entity =>
        {
            entity.HasKey(e => new { e.Rsi, e.Rsischeduleid, e.Approvaleditdate });
            entity.ToTable("RSIAPPROVALHISTORY");

            entity.Property(e => e.Approvalcomment)
                .HasMaxLength(255)
                .HasColumnName("APPROVALCOMMENT");
            entity.Property(e => e.Approvaleditdate).HasColumnName("APPROVALEDITDATE");
            entity.Property(e => e.Approvaledituserid).HasColumnName("APPROVALEDITUSERID");
            entity.Property(e => e.Approvedbyuserid).HasColumnName("APPROVEDBYUSERID");
            entity.Property(e => e.Approveddate).HasColumnName("APPROVEDDATE");
            entity.Property(e => e.Removaleditdate).HasColumnName("REMOVALEDITDATE");
            entity.Property(e => e.Removaledituserid).HasColumnName("REMOVALEDITUSERID");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Rsischeduleid).HasColumnName("RSISCHEDULEID");
        });

        modelBuilder.Entity<Rsieventsched>(entity =>
        {
            entity.HasKey(e => new { e.Rsi, e.Object, e.Retstage, e.Rsischeduleid });
            entity.ToTable("RSIEVENTSCHED");

            entity.Property(e => e.Actioncode)
                .HasMaxLength(32)
                .HasColumnName("ACTIONCODE");
            entity.Property(e => e.ActiondescE)
                .HasMaxLength(4000)
                .HasColumnName("ACTIONDESC_E");
            entity.Property(e => e.ActiondescF)
                .HasMaxLength(4000)
                .HasColumnName("ACTIONDESC_F");
            entity.Property(e => e.Approvalflag).HasColumnName("APPROVALFLAG");
            entity.Property(e => e.Catidattrid)
                .HasMaxLength(32)
                .HasColumnName("CATIDATTRID");
            entity.Property(e => e.Datetouse)
                .HasMaxLength(32)
                .HasColumnName("DATETOUSE");
            entity.Property(e => e.Disposition)
                .HasMaxLength(32)
                .HasColumnName("DISPOSITION");
            entity.Property(e => e.Editdate).HasColumnName("EDITDATE");
            entity.Property(e => e.Editpatron)
                .HasMaxLength(32)
                .HasColumnName("EDITPATRON");
            entity.Property(e => e.Eventcomment)
                .HasMaxLength(255)
                .HasColumnName("EVENTCOMMENT");
            entity.Property(e => e.Eventrule)
                .HasMaxLength(4000)
                .HasColumnName("EVENTRULE");
            entity.Property(e => e.Eventrulecomment)
                .HasMaxLength(255)
                .HasColumnName("EVENTRULECOMMENT");
            entity.Property(e => e.Eventruledate).HasColumnName("EVENTRULEDATE");
            entity.Property(e => e.Eventtype).HasColumnName("EVENTTYPE");
            entity.Property(e => e.Fixedret).HasColumnName("FIXEDRET");
            entity.Property(e => e.Makerendition).HasColumnName("MAKERENDITION");
            entity.Property(e => e.Maximumperiod)
                .HasColumnType("INTEGER")
                .HasColumnName("MAXIMUMPERIOD");
            entity.Property(e => e.Numverstokeep)
                .HasColumnType("INTEGER")
                .HasColumnName("NUMVERSTOKEEP");
            entity.Property(e => e.Object)
                .HasMaxLength(32)
                .HasColumnName("OBJECT");
            entity.Property(e => e.Purgemajors).HasColumnName("PURGEMAJORS");
            entity.Property(e => e.Purgesuperseded).HasColumnName("PURGESUPERSEDED");
            entity.Property(e => e.Recmdcomment)
                .HasMaxLength(255)
                .HasColumnName("RECMDCOMMENT");
            entity.Property(e => e.Recmddate).HasColumnName("RECMDDATE");
            entity.Property(e => e.Recmdoffice)
                .HasMaxLength(32)
                .HasColumnName("RECMDOFFICE");
            entity.Property(e => e.Recmdpatron)
                .HasMaxLength(32)
                .HasColumnName("RECMDPATRON");
            entity.Property(e => e.Recordtype).HasColumnName("RECORDTYPE");
            entity.Property(e => e.Retdays)
                .HasColumnType("INTEGER")
                .HasColumnName("RETDAYS");
            entity.Property(e => e.Retintervals).HasColumnName("RETINTERVALS");
            entity.Property(e => e.Retmonths)
                .HasColumnType("INTEGER")
                .HasColumnName("RETMONTHS");
            entity.Property(e => e.Retstage)
                .HasMaxLength(32)
                .HasColumnName("RETSTAGE");
            entity.Property(e => e.Retyears)
                .HasColumnType("INTEGER")
                .HasColumnName("RETYEARS");
            entity.Property(e => e.RmRrCode)
                .HasMaxLength(32)
                .HasColumnName("RM_RR_CODE");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Rsirulecode)
                .HasMaxLength(32)
                .HasColumnName("RSIRULECODE");
            entity.Property(e => e.Rsischeduleid).HasColumnName("RSISCHEDULEID");
            entity.Property(e => e.Stageaction)
                .HasMaxLength(255)
                .HasColumnName("STAGEACTION");
            entity.Property(e => e.Yearendday).HasColumnName("YEARENDDAY");
            entity.Property(e => e.Yearendmonth).HasColumnName("YEARENDMONTH");
        });

        modelBuilder.Entity<Rsijustify>(entity =>
        {
            entity.HasKey(e => new { e.Rsi, e.Justificationid });
            entity.ToTable("RSIJUSTIFY");

            entity.Property(e => e.Justificationid).HasColumnName("JUSTIFICATIONID");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
        });

        modelBuilder.Entity<Rsikeyword>(entity =>
        {
            entity.HasKey(e => new { e.Rsi, e.Objectfield, e.Rsikeyword1 });
            entity.ToTable("RSIKEYWORDS");

            entity.Property(e => e.Objectfield)
                .HasMaxLength(64)
                .HasColumnName("OBJECTFIELD");
            entity.Property(e => e.Rimssoundex)
                .HasMaxLength(32)
                .HasColumnName("RIMSSOUNDEX");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Rsikeyword1)
                .HasMaxLength(64)
                .HasColumnName("RSIKEYWORD");
        });

        modelBuilder.Entity<Rsirulecode>(entity =>
        {
            entity.HasKey(e => e.Rsirulecode1);
            entity.ToTable("RSIRULECODE");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Rsirulecode1)
                .HasMaxLength(32)
                .HasColumnName("RSIRULECODE");
            entity.Property(e => e.RsirulecodeDescE)
                .HasMaxLength(128)
                .HasColumnName("RSIRULECODE_DESC_E");
            entity.Property(e => e.RsirulecodeDescF)
                .HasMaxLength(128)
                .HasColumnName("RSIRULECODE_DESC_F");
        });

        modelBuilder.Entity<Rsistatus>(entity =>
        {
            entity.HasKey(e => e.Rsistatus1);
            entity.ToTable("RSISTATUS");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Rsistatus1)
                .HasMaxLength(32)
                .HasColumnName("RSISTATUS");
            entity.Property(e => e.RsistatusDescE)
                .HasMaxLength(128)
                .HasColumnName("RSISTATUS_DESC_E");
            entity.Property(e => e.RsistatusDescF)
                .HasMaxLength(128)
                .HasColumnName("RSISTATUS_DESC_F");
        });

        modelBuilder.Entity<SearchstatsComponent>(entity =>
        {
            entity.HasKey(e => e.Querynr);
            entity.ToTable("SEARCHSTATS_COMPONENT");

            entity.Property(e => e.Extradatai).HasColumnName("EXTRADATAI");
            entity.Property(e => e.Extradatas)
                .HasMaxLength(64)
                .HasColumnName("EXTRADATAS");
            entity.Property(e => e.Otsql)
                .HasMaxLength(4000)
                .HasColumnName("OTSQL");
            entity.Property(e => e.Querynr)
                .HasColumnType("DECIMAL")
                .HasColumnName("QUERYNR");
            entity.Property(e => e.Subquery)
                .HasMaxLength(64)
                .HasColumnName("SUBQUERY");
            entity.Property(e => e.Terms)
                .HasMaxLength(4000)
                .HasColumnName("TERMS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<SearchstatsQuery>(entity =>
        {
            entity.HasKey(e => e.Querytimeinms);
            entity.ToTable("SEARCHSTATS_QUERY");

            entity.Property(e => e.Hopcount).HasColumnName("HOPCOUNT");
            entity.Property(e => e.Maxdisplayed).HasColumnName("MAXDISPLAYED");
            entity.Property(e => e.Queryhash).HasColumnName("QUERYHASH");
            entity.Property(e => e.Queryhashgeneral).HasColumnName("QUERYHASHGENERAL");
            entity.Property(e => e.Queryhashnofacet).HasColumnName("QUERYHASHNOFACET");
            entity.Property(e => e.Querynr).HasColumnName("QUERYNR");
            entity.Property(e => e.Querytime).HasColumnName("QUERYTIME");
            entity.Property(e => e.Querytimeinms)
                .HasColumnType("DECIMAL")
                .HasColumnName("QUERYTIMEINMS");
            entity.Property(e => e.Rawresults).HasColumnName("RAWRESULTS");
            entity.Property(e => e.Searchtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SEARCHTYPE");
            entity.Property(e => e.Template).HasColumnName("TEMPLATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<SearchstatsSlice>(entity =>
        {
            entity.HasKey(e => e.Querynr);
            entity.ToTable("SEARCHSTATS_SLICE");

            entity.Property(e => e.Querynr)
                .HasColumnType("DECIMAL")
                .HasColumnName("QUERYNR");
            entity.Property(e => e.Slice).HasColumnName("SLICE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<SearchstatsStopcondition>(entity =>
        {
            entity.HasKey(e => e.Querynr);
            entity.ToTable("SEARCHSTATS_STOPCONDITIONS");

            entity.Property(e => e.Hitindex)
                .HasColumnType("INTEGER")
                .HasColumnName("HITINDEX");
            entity.Property(e => e.Operation)
                .HasMaxLength(64)
                .HasColumnName("OPERATION");
            entity.Property(e => e.Queryhashnofacet).HasColumnName("QUERYHASHNOFACET");
            entity.Property(e => e.Querynr).HasColumnName("QUERYNR");
            entity.Property(e => e.Stoptime).HasColumnName("STOPTIME");
        });

        modelBuilder.Entity<SearchstatsTerm>(entity =>
        {
            entity.HasKey(e => e.Termlower);
            entity.ToTable("SEARCHSTATS_TERMS");

            entity.Property(e => e.Querynr)
                .HasColumnType("DECIMAL")
                .HasColumnName("QUERYNR");
            entity.Property(e => e.Term)
                .HasMaxLength(255)
                .HasColumnName("TERM");
            entity.Property(e => e.Termlower)
                .HasMaxLength(255)
                .HasColumnName("TERMLOWER");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Serverstatus>(entity =>
        {
            entity.HasKey(e => e.Serverid);
            entity.ToTable("SERVERSTATUS");

            entity.Property(e => e.Serverid)
                .HasMaxLength(255)
                .HasColumnName("SERVERID");
            entity.Property(e => e.Servername)
                .HasMaxLength(64)
                .HasColumnName("SERVERNAME");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
        });

        modelBuilder.Entity<Signcount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SIGNCOUNT");

            entity.Property(e => e.Signedno)
                .HasColumnType("INTEGER")
                .HasColumnName("SIGNEDNO");
            entity.Property(e => e.Signopt)
                .HasColumnType("INTEGER")
                .HasColumnName("SIGNOPT");
            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Signinguser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SIGNINGUSERS");

            entity.Property(e => e.Childid).HasColumnName("CHILDID");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Spaceid).HasColumnName("SPACEID");
        });

        modelBuilder.Entity<Signtrail>(entity =>
        {
            entity.HasKey(e => e.Workid);
            entity.ToTable("SIGNTRAIL");

            entity.Property(e => e.Appendedpage)
                .HasColumnType("INTEGER")
                .HasColumnName("APPENDEDPAGE");
            entity.Property(e => e.Docid).HasColumnName("DOCID");
            entity.Property(e => e.Meaning)
                .HasMaxLength(255)
                .HasColumnName("MEANING");
            entity.Property(e => e.Signedby)
                .HasMaxLength(255)
                .HasColumnName("SIGNEDBY");
            entity.Property(e => e.Signeddate).HasColumnName("SIGNEDDATE");
            entity.Property(e => e.Srctrail)
                .HasColumnType("INTEGER")
                .HasColumnName("SRCTRAIL");
            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("TITLE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Workflowname)
                .HasMaxLength(255)
                .HasColumnName("WORKFLOWNAME");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Sovcontrolrule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SOVCONTROLRULES");

            entity.Property(e => e.Attr1type)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTR1TYPE");
            entity.Property(e => e.Attr2type)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTR2TYPE");
            entity.Property(e => e.Attr3type)
                .HasMaxLength(255)
                .HasColumnName("ATTR3TYPE");
            entity.Property(e => e.Attr4type)
                .HasMaxLength(255)
                .HasColumnName("ATTR4TYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Orderid)
                .HasColumnType("INTEGER")
                .HasColumnName("ORDERID");
            entity.Property(e => e.Ruleid)
                .HasColumnType("INTEGER")
                .HasColumnName("RULEID");
            entity.Property(e => e.Ruletype)
                .HasMaxLength(32)
                .HasColumnName("RULETYPE");
            entity.Property(e => e.Typeid)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPEID");
        });

        modelBuilder.Entity<Sovmgmtmsg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SOVMGMTMSGS");

            entity.Property(e => e.Bseen)
                .HasMaxLength(32)
                .HasColumnName("BSEEN");
            entity.Property(e => e.Cmpmsg)
                .HasMaxLength(4000)
                .HasColumnName("CMPMSG");
            entity.Property(e => e.Msg)
                .HasMaxLength(4000)
                .HasColumnName("MSG");
            entity.Property(e => e.Msgdate).HasColumnName("MSGDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Objtype)
                .HasMaxLength(32)
                .HasColumnName("OBJTYPE");
            entity.Property(e => e.Recipient)
                .HasMaxLength(255)
                .HasColumnName("RECIPIENT");
            entity.Property(e => e.Sigid)
                .HasMaxLength(32)
                .HasColumnName("SIGID");
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<Spcjob>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("SPCJOB");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.SpcActivity).HasColumnName("SPC_ACTIVITY");
            entity.Property(e => e.SpcConditiontype)
                .HasMaxLength(64)
                .HasColumnName("SPC_CONDITIONTYPE");
            entity.Property(e => e.SpcConditionvalue)
                .HasColumnType("NCLOB")
                .HasColumnName("SPC_CONDITIONVALUE");
            entity.Property(e => e.SpcEnddate).HasColumnName("SPC_ENDDATE");
            entity.Property(e => e.SpcErrormessage)
                .HasMaxLength(4000)
                .HasColumnName("SPC_ERRORMESSAGE");
            entity.Property(e => e.SpcLastendedat).HasColumnName("SPC_LASTENDEDAT");
            entity.Property(e => e.SpcLaststartedat).HasColumnName("SPC_LASTSTARTEDAT");
            entity.Property(e => e.SpcRecurrence).HasColumnName("SPC_RECURRENCE");
            entity.Property(e => e.SpcResumeinfo)
                .HasMaxLength(4000)
                .HasColumnName("SPC_RESUMEINFO");
            entity.Property(e => e.SpcRunstate).HasColumnName("SPC_RUNSTATE");
            entity.Property(e => e.SpcStartdate).HasColumnName("SPC_STARTDATE");
        });

        modelBuilder.Entity<Spcrequest>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.SpcRequesttype });
            entity.ToTable("SPCREQUEST");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.SpcOriginatortype)
                .HasMaxLength(64)
                .HasColumnName("SPC_ORIGINATORTYPE");
            entity.Property(e => e.SpcRequeststate).HasColumnName("SPC_REQUESTSTATE");
            entity.Property(e => e.SpcRequesttype).HasColumnName("SPC_REQUESTTYPE");
        });

        modelBuilder.Entity<Spcschedule>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.SpcDay, e.SpcTime, e.SpcDuration });
            entity.ToTable("SPCSCHEDULE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.SpcDay)
                .HasMaxLength(32)
                .HasColumnName("SPC_DAY");
            entity.Property(e => e.SpcDuration).HasColumnName("SPC_DURATION");
            entity.Property(e => e.SpcTime).HasColumnName("SPC_TIME");
        });

        modelBuilder.Entity<Spcstatistic>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.SpcStatRunstate, e.SpcStatStartdate });
            entity.ToTable("SPCSTATISTICS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.SpcStatEnddate).HasColumnName("SPC_STAT_ENDDATE");
            entity.Property(e => e.SpcStatEndstate).HasColumnName("SPC_STAT_ENDSTATE");
            entity.Property(e => e.SpcStatErrormessage)
                .HasMaxLength(4000)
                .HasColumnName("SPC_STAT_ERRORMESSAGE");
            entity.Property(e => e.SpcStatMovedbytes)
                .HasMaxLength(32)
                .HasColumnName("SPC_STAT_MOVEDBYTES");
            entity.Property(e => e.SpcStatMovedcount).HasColumnName("SPC_STAT_MOVEDCOUNT");
            entity.Property(e => e.SpcStatRunstate).HasColumnName("SPC_STAT_RUNSTATE");
            entity.Property(e => e.SpcStatStartdate).HasColumnName("SPC_STAT_STARTDATE");
            entity.Property(e => e.SpcStatTotalbytes)
                .HasMaxLength(32)
                .HasColumnName("SPC_STAT_TOTALBYTES");
            entity.Property(e => e.SpcStatTotalcount).HasColumnName("SPC_STAT_TOTALCOUNT");
        });

        modelBuilder.Entity<SpecialCharacter>(entity =>
        {
            entity.HasKey(e => e.SpecialChar);
            entity.ToTable("SPECIAL_CHARACTERS");

            entity.Property(e => e.SpecialChar)
                .HasMaxLength(32)
                .HasColumnName("SPECIAL_CHAR");
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.HasKey(e => e.Storage1);
            entity.ToTable("STORAGE");

            entity.Property(e => e.Disabledflag).HasColumnName("DISABLEDFLAG");
            entity.Property(e => e.Storage1)
                .HasMaxLength(32)
                .HasColumnName("STORAGE");
            entity.Property(e => e.StorageDescE)
                .HasMaxLength(64)
                .HasColumnName("STORAGE_DESC_E");
            entity.Property(e => e.StorageDescF)
                .HasMaxLength(64)
                .HasColumnName("STORAGE_DESC_F");
        });

        modelBuilder.Entity<Storagelocator>(entity =>
        {
            entity.HasKey(e => new { e.Facility, e.Area, e.Boxlocator });
            entity.ToTable("STORAGELOCATOR");

            entity.Property(e => e.Area)
                .HasMaxLength(32)
                .HasColumnName("AREA");
            entity.Property(e => e.Boxlocator)
                .HasMaxLength(32)
                .HasColumnName("BOXLOCATOR");
            entity.Property(e => e.Facility)
                .HasMaxLength(32)
                .HasColumnName("FACILITY");
            entity.Property(e => e.Freespace)
                .HasColumnType("DECIMAL")
                .HasColumnName("FREESPACE");
            entity.Property(e => e.Locatorsortkey)
                .HasMaxLength(128)
                .HasColumnName("LOCATORSORTKEY");
            entity.Property(e => e.Locatortype)
                .HasMaxLength(32)
                .HasColumnName("LOCATORTYPE");
            entity.Property(e => e.Refrate)
                .HasMaxLength(32)
                .HasColumnName("REFRATE");
            entity.Property(e => e.Storlocdepth)
                .HasColumnType("DECIMAL")
                .HasColumnName("STORLOCDEPTH");
            entity.Property(e => e.Storlocheight)
                .HasColumnType("DECIMAL")
                .HasColumnName("STORLOCHEIGHT");
            entity.Property(e => e.Storloclength)
                .HasColumnType("DECIMAL")
                .HasColumnName("STORLOCLENGTH");
            entity.Property(e => e.Totalspace)
                .HasColumnType("DECIMAL")
                .HasColumnName("TOTALSPACE");
        });

        modelBuilder.Entity<Supportassetagent>(entity =>
        {
            entity.HasKey(e => e.Agentid);

            entity.ToTable("SUPPORTASSETAGENT");

            entity.Property(e => e.Agentid)
                .ValueGeneratedNever()
                .HasColumnName("AGENTID");
            entity.Property(e => e.Deploydirectory)
                .HasMaxLength(4000)
                .HasColumnName("DEPLOYDIRECTORY");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(4000)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Supportassetdatum>(entity =>
        {
            entity.HasKey(e => new { e.Agentid, e.Parentid, e.Subtype });
            entity.ToTable("SUPPORTASSETDATA");

            entity.Property(e => e.Agentid).HasColumnName("AGENTID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Deploydate).HasColumnName("DEPLOYDATE");
            entity.Property(e => e.Deployurl)
                .HasMaxLength(4000)
                .HasColumnName("DEPLOYURL");
            entity.Property(e => e.Filepath)
                .HasMaxLength(4000)
                .HasColumnName("FILEPATH");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");

            entity.HasOne(d => d.Agent).WithMany()
                .HasForeignKey(d => d.Agentid)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Supportassetfailedorder>(entity =>
        {
            entity.HasKey(e => new { e.Agentid, e.Dataid });
            entity.ToTable("SUPPORTASSETFAILEDORDER");

            entity.Property(e => e.Agentid).HasColumnName("AGENTID");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Errordate).HasColumnName("ERRORDATE");
            entity.Property(e => e.Errormessage)
                .HasMaxLength(4000)
                .HasColumnName("ERRORMESSAGE");
            entity.Property(e => e.Orderid).HasColumnName("ORDERID");
            entity.Property(e => e.Ordertype)
                .HasColumnType("INTEGER")
                .HasColumnName("ORDERTYPE");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");

            entity.HasOne(d => d.Agent).WithMany()
                .HasForeignKey(d => d.Agentid)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Supportassetorder>(entity =>
        {
            entity.HasKey(e => new { e.Agentid, e.Dataid });
            entity.ToTable("SUPPORTASSETORDER");

            entity.Property(e => e.Agentid).HasColumnName("AGENTID");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Orderid).HasColumnName("ORDERID");
            entity.Property(e => e.Ordertype)
                .HasColumnType("INTEGER")
                .HasColumnName("ORDERTYPE");
            entity.Property(e => e.Retrycount)
                .HasColumnType("INTEGER")
                .HasColumnName("RETRYCOUNT");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");

            entity.HasOne(d => d.Agent).WithMany()
                .HasForeignKey(d => d.Agentid)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Systemlanguage>(entity =>
        {
            entity.HasKey(e => e.Languagecode);
            entity.ToTable("SYSTEMLANGUAGES");

            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
            entity.Property(e => e.Languagename)
                .HasMaxLength(255)
                .HasColumnName("LANGUAGENAME");
            entity.Property(e => e.Languagenamelocal)
                .HasMaxLength(255)
                .HasColumnName("LANGUAGENAMELOCAL");
        });

        modelBuilder.Entity<TempAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_ALL");

            entity.Property(e => e.Acltype).HasColumnName("ACLTYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permissions)
                .HasColumnType("INTEGER")
                .HasColumnName("PERMISSIONS");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.See).HasColumnName("SEE");
        });

        modelBuilder.Entity<TempDiffParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_DIFF_PARENTS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
        });

        modelBuilder.Entity<TempDiffPerm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_DIFF_PERMS");

            entity.Property(e => e.Acltype).HasColumnName("ACLTYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permissions)
                .HasColumnType("INTEGER")
                .HasColumnName("PERMISSIONS");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.See).HasColumnName("SEE");
        });

        modelBuilder.Entity<TempExact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_EXACTS");

            entity.Property(e => e.Acltype).HasColumnName("ACLTYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permissions)
                .HasColumnType("INTEGER")
                .HasColumnName("PERMISSIONS");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.See).HasColumnName("SEE");
        });

        modelBuilder.Entity<Termlevel>(entity =>
        {
            entity.HasKey(e => e.Termlevel1);
            entity.ToTable("TERMLEVEL");

            entity.Property(e => e.Termlevel1)
                .HasMaxLength(32)
                .HasColumnName("TERMLEVEL");
            entity.Property(e => e.TermlevelDesc)
                .HasMaxLength(128)
                .HasColumnName("TERMLEVEL_DESC");
            entity.Property(e => e.Termlevelnumber)
                .HasColumnType("INTEGER")
                .HasColumnName("TERMLEVELNUMBER");
            entity.Property(e => e.Termtype)
                .HasColumnType("INTEGER")
                .HasColumnName("TERMTYPE");
        });

        modelBuilder.Entity<TestTable>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("TEST_TABLE");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Alan1)
                .HasMaxLength(255)
                .HasColumnName("ALAN_1");
            entity.Property(e => e.Alan2).HasColumnName("ALAN_2");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Tarih).HasColumnName("TARIH");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<Theshistory>(entity =>
        {
            entity.HasKey(e => new { e.Termid, e.Editdate });
            entity.ToTable("THESHISTORY");

            entity.Property(e => e.Editdate).HasColumnName("EDITDATE");
            entity.Property(e => e.Editpatron).HasColumnName("EDITPATRON");
            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Filenumber)
                .HasMaxLength(32)
                .HasColumnName("FILENUMBER");
            entity.Property(e => e.Keyword)
                .HasMaxLength(64)
                .HasColumnName("KEYWORD");
            entity.Property(e => e.Language)
                .HasMaxLength(32)
                .HasColumnName("LANGUAGE");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Scopenote)
                .HasMaxLength(255)
                .HasColumnName("SCOPENOTE");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
            entity.Property(e => e.Term)
                .HasMaxLength(64)
                .HasColumnName("TERM");
            entity.Property(e => e.Termaction)
                .HasMaxLength(32)
                .HasColumnName("TERMACTION");
            entity.Property(e => e.Termcomments)
                .HasMaxLength(4000)
                .HasColumnName("TERMCOMMENTS");
            entity.Property(e => e.Termid).HasColumnName("TERMID");
            entity.Property(e => e.Termlevel)
                .HasMaxLength(32)
                .HasColumnName("TERMLEVEL");
            entity.Property(e => e.Termtype)
                .HasColumnType("INTEGER")
                .HasColumnName("TERMTYPE");
        });

        modelBuilder.Entity<Thesrelation>(entity =>
        {
            entity.HasKey(e => new { e.Termid1, e.Relattype, e.Termid2 });
            entity.ToTable("THESRELATIONS");

            entity.Property(e => e.Relattype)
                .HasMaxLength(32)
                .HasColumnName("RELATTYPE");
            entity.Property(e => e.Termid1).HasColumnName("TERMID1");
            entity.Property(e => e.Termid2).HasColumnName("TERMID2");
        });

        modelBuilder.Entity<Thesterm>(entity =>
        {
            entity.HasKey(e => e.Termid);
            entity.ToTable("THESTERMS");

            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Filenumber)
                .HasMaxLength(64)
                .HasColumnName("FILENUMBER");
            entity.Property(e => e.Keyword)
                .HasMaxLength(64)
                .HasColumnName("KEYWORD");
            entity.Property(e => e.Language)
                .HasMaxLength(32)
                .HasColumnName("LANGUAGE");
            entity.Property(e => e.Rsi)
                .HasMaxLength(32)
                .HasColumnName("RSI");
            entity.Property(e => e.Scopenote)
                .HasMaxLength(255)
                .HasColumnName("SCOPENOTE");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
            entity.Property(e => e.Term)
                .HasMaxLength(64)
                .HasColumnName("TERM");
            entity.Property(e => e.Termcomments)
                .HasMaxLength(4000)
                .HasColumnName("TERMCOMMENTS");
            entity.Property(e => e.Termid).HasColumnName("TERMID");
            entity.Property(e => e.Termlevel)
                .HasMaxLength(32)
                .HasColumnName("TERMLEVEL");
            entity.Property(e => e.Termsource)
                .HasMaxLength(32)
                .HasColumnName("TERMSOURCE");
            entity.Property(e => e.Termtype)
                .HasColumnType("INTEGER")
                .HasColumnName("TERMTYPE");
        });

        modelBuilder.Entity<Timedue>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("TIMEDUE");

            entity.Property(e => e.Expdate).HasColumnName("EXPDATE");
            entity.Property(e => e.Ip)
                .HasMaxLength(64)
                .HasColumnName("IP");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Timeoutgroup>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("TIMEOUTGROUPS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Timeout)
                .HasColumnType("INTEGER")
                .HasColumnName("TIMEOUT");
            entity.Property(e => e.Type)
                .HasColumnType("INTEGER")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<Todo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TODO");

            entity.Property(e => e.MaptaskPriority)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_PRIORITY");
            entity.Property(e => e.MaptaskStartdate).HasColumnName("MAPTASK_STARTDATE");
            entity.Property(e => e.MaptaskSubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_SUBTYPE");
            entity.Property(e => e.MaptaskType)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_TYPE");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworktaskDatedueMax).HasColumnName("SUBWORKTASK_DATEDUE_MAX");
            entity.Property(e => e.SubworktaskDatemilestone).HasColumnName("SUBWORKTASK_DATEMILESTONE");
            entity.Property(e => e.SubworktaskDateready).HasColumnName("SUBWORKTASK_DATEREADY");
            entity.Property(e => e.SubworktaskPerformerid).HasColumnName("SUBWORKTASK_PERFORMERID");
            entity.Property(e => e.SubworktaskPerformeridName)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_PERFORMERID_NAME");
            entity.Property(e => e.SubworktaskTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_TASKID");
            entity.Property(e => e.SubworktaskTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_TITLE");
            entity.Property(e => e.SubworktaskUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORKTASK_USERDATA");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkManageridName)
                .HasMaxLength(255)
                .HasColumnName("WORK_MANAGERID_NAME");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwneridName)
                .HasMaxLength(255)
                .HasColumnName("WORK_OWNERID_NAME");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Todo2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TODO2");

            entity.Property(e => e.MaptaskPriority)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_PRIORITY");
            entity.Property(e => e.MaptaskStartdate).HasColumnName("MAPTASK_STARTDATE");
            entity.Property(e => e.MaptaskSubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_SUBTYPE");
            entity.Property(e => e.MaptaskType)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_TYPE");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.StatusString)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("STATUS_STRING");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworktaskDatedueMax).HasColumnName("SUBWORKTASK_DATEDUE_MAX");
            entity.Property(e => e.SubworktaskDatemilestone).HasColumnName("SUBWORKTASK_DATEMILESTONE");
            entity.Property(e => e.SubworktaskDateready).HasColumnName("SUBWORKTASK_DATEREADY");
            entity.Property(e => e.SubworktaskPerformerid).HasColumnName("SUBWORKTASK_PERFORMERID");
            entity.Property(e => e.SubworktaskPerformeridName)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_PERFORMERID_NAME");
            entity.Property(e => e.SubworktaskTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_TASKID");
            entity.Property(e => e.SubworktaskTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_TITLE");
            entity.Property(e => e.SubworktaskUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORKTASK_USERDATA");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkManageridName)
                .HasMaxLength(255)
                .HasColumnName("WORK_MANAGERID_NAME");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwneridName)
                .HasMaxLength(255)
                .HasColumnName("WORK_OWNERID_NAME");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Todo201>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TODO201");

            entity.Property(e => e.DueDateSort).HasColumnName("DUE_DATE_SORT");
            entity.Property(e => e.MaptaskPriority)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_PRIORITY");
            entity.Property(e => e.MaptaskStartdate).HasColumnName("MAPTASK_STARTDATE");
            entity.Property(e => e.MaptaskSubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_SUBTYPE");
            entity.Property(e => e.MaptaskType)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_TYPE");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.StatusString)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("STATUS_STRING");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworktaskDatedueMax).HasColumnName("SUBWORKTASK_DATEDUE_MAX");
            entity.Property(e => e.SubworktaskDatemilestone).HasColumnName("SUBWORKTASK_DATEMILESTONE");
            entity.Property(e => e.SubworktaskDateready).HasColumnName("SUBWORKTASK_DATEREADY");
            entity.Property(e => e.SubworktaskPerformerid).HasColumnName("SUBWORKTASK_PERFORMERID");
            entity.Property(e => e.SubworktaskPerformeridName)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_PERFORMERID_NAME");
            entity.Property(e => e.SubworktaskTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_TASKID");
            entity.Property(e => e.SubworktaskTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_TITLE");
            entity.Property(e => e.SubworktaskUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORKTASK_USERDATA");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkManageridName)
                .HasMaxLength(255)
                .HasColumnName("WORK_MANAGERID_NAME");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwneridName)
                .HasMaxLength(255)
                .HasColumnName("WORK_OWNERID_NAME");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Todobase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TODOBASE");

            entity.Property(e => e.MaptaskPriority)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_PRIORITY");
            entity.Property(e => e.MaptaskStartdate).HasColumnName("MAPTASK_STARTDATE");
            entity.Property(e => e.MaptaskSubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_SUBTYPE");
            entity.Property(e => e.MaptaskType)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_TYPE");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworktaskDatedueMax).HasColumnName("SUBWORKTASK_DATEDUE_MAX");
            entity.Property(e => e.SubworktaskDatemilestone).HasColumnName("SUBWORKTASK_DATEMILESTONE");
            entity.Property(e => e.SubworktaskDateready).HasColumnName("SUBWORKTASK_DATEREADY");
            entity.Property(e => e.SubworktaskPerformerid).HasColumnName("SUBWORKTASK_PERFORMERID");
            entity.Property(e => e.SubworktaskTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_TASKID");
            entity.Property(e => e.SubworktaskTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_TITLE");
            entity.Property(e => e.SubworktaskUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORKTASK_USERDATA");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Transfer>(entity =>
        {
            entity.HasKey(e => e.Transferid);
            entity.ToTable("TRANSFERS");

            entity.Property(e => e.Transferid)
                .HasMaxLength(64)
                .HasColumnName("TRANSFERID");
            entity.Property(e => e.Transsortkey)
                .HasMaxLength(255)
                .HasColumnName("TRANSSORTKEY");
            entity.Property(e => e.Trsfcomment)
                .HasMaxLength(255)
                .HasColumnName("TRSFCOMMENT");
            entity.Property(e => e.Trsfcontent)
                .HasMaxLength(4000)
                .HasColumnName("TRSFCONTENT");
            entity.Property(e => e.Trsfcreate).HasColumnName("TRSFCREATE");
            entity.Property(e => e.Trsfdatefrom).HasColumnName("TRSFDATEFROM");
            entity.Property(e => e.Trsfdateto).HasColumnName("TRSFDATETO");
            entity.Property(e => e.Trsfestsize)
                .HasColumnType("DECIMAL")
                .HasColumnName("TRSFESTSIZE");
            entity.Property(e => e.Trsfrecd).HasColumnName("TRSFRECD");
            entity.Property(e => e.Trsfsent).HasColumnName("TRSFSENT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Ualarchive>(entity =>
        {
            entity.HasKey(e => e.Archivename);
            entity.ToTable("UALARCHIVES");

            entity.Property(e => e.Archivedataid).HasColumnName("ARCHIVEDATAID");
            entity.Property(e => e.Archivename)
                .HasMaxLength(255)
                .HasColumnName("ARCHIVENAME");
            entity.Property(e => e.Archiveport).HasColumnName("ARCHIVEPORT");
            entity.Property(e => e.Archivesslport).HasColumnName("ARCHIVESSLPORT");
            entity.Property(e => e.Archivetype)
                .HasMaxLength(32)
                .HasColumnName("ARCHIVETYPE");
            entity.Property(e => e.Protectionlevel).HasColumnName("PROTECTIONLEVEL");
            entity.Property(e => e.Retentiondays).HasColumnName("RETENTIONDAYS");
            entity.Property(e => e.Retentionmode)
                .HasMaxLength(32)
                .HasColumnName("RETENTIONMODE");
            entity.Property(e => e.Sslmode)
                .HasMaxLength(32)
                .HasColumnName("SSLMODE");
        });

        modelBuilder.Entity<Ualarchivecertificate>(entity =>
        {
            entity.HasKey(e => new { e.Archivedataid, e.Authcode });
            entity.ToTable("UALARCHIVECERTIFICATES");

            entity.Property(e => e.Archivedataid).HasColumnName("ARCHIVEDATAID");
            entity.Property(e => e.Authcode)
                .HasMaxLength(255)
                .HasColumnName("AUTHCODE");
            entity.Property(e => e.Certificatecontent)
                .HasColumnType("NCLOB")
                .HasColumnName("CERTIFICATECONTENT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Fingerprintcode)
                .HasMaxLength(255)
                .HasColumnName("FINGERPRINTCODE");
            entity.Property(e => e.Isenabled).HasColumnName("ISENABLED");
            entity.Property(e => e.Issuername)
                .HasMaxLength(255)
                .HasColumnName("ISSUERNAME");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Permissioncode).HasColumnName("PERMISSIONCODE");
            entity.Property(e => e.Serialcode)
                .HasMaxLength(255)
                .HasColumnName("SERIALCODE");
            entity.Property(e => e.Validfrom).HasColumnName("VALIDFROM");
            entity.Property(e => e.Validtill).HasColumnName("VALIDTILL");
        });

        modelBuilder.Entity<Ualarchivecomponent>(entity =>
        {
            entity.HasKey(e => new { e.Archivedataid, e.Documentcode, e.Componentname });
            entity.ToTable("UALARCHIVECOMPONENTS");

            entity.Property(e => e.Archivedataid).HasColumnName("ARCHIVEDATAID");
            entity.Property(e => e.Componentdataid).HasColumnName("COMPONENTDATAID");
            entity.Property(e => e.Componentname)
                .HasMaxLength(255)
                .HasColumnName("COMPONENTNAME");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Documentcode)
                .HasMaxLength(255)
                .HasColumnName("DOCUMENTCODE");
            entity.Property(e => e.Isaddon).HasColumnName("ISADDON");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Protectionlevel).HasColumnName("PROTECTIONLEVEL");
            entity.Property(e => e.Retentiondate).HasColumnName("RETENTIONDATE");
            entity.Property(e => e.Retentionmode)
                .HasMaxLength(32)
                .HasColumnName("RETENTIONMODE");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
        });

        modelBuilder.Entity<Ualarchivemode>(entity =>
        {
            entity.HasKey(e => e.Archivemodeid);
            entity.ToTable("UALARCHIVEMODES");

            entity.Property(e => e.Archivedataid).HasColumnName("ARCHIVEDATAID");
            entity.Property(e => e.Archivemodeid).HasColumnName("ARCHIVEMODEID");
            entity.Property(e => e.Archivemodename)
                .HasMaxLength(255)
                .HasColumnName("ARCHIVEMODENAME");
            entity.Property(e => e.Conditionjson)
                .HasMaxLength(4000)
                .HasColumnName("CONDITIONJSON");
            entity.Property(e => e.Dphost)
                .HasMaxLength(255)
                .HasColumnName("DPHOST");
            entity.Property(e => e.Dpport).HasColumnName("DPPORT");
            entity.Property(e => e.Dpprotocol)
                .HasMaxLength(32)
                .HasColumnName("DPPROTOCOL");
            entity.Property(e => e.Lasttouchdate).HasColumnName("LASTTOUCHDATE");
            entity.Property(e => e.Sapsystemid).HasColumnName("SAPSYSTEMID");
            entity.Property(e => e.Scenarioname)
                .HasMaxLength(128)
                .HasColumnName("SCENARIONAME");
        });

        modelBuilder.Entity<Ualdocattribute>(entity =>
        {
            entity.HasKey(e => new { e.Archivedataid, e.Documentcode, e.Attributename });
            entity.ToTable("UALDOCATTRIBUTES");

            entity.Property(e => e.Archivedataid).HasColumnName("ARCHIVEDATAID");
            entity.Property(e => e.Attributename)
                .HasMaxLength(128)
                .HasColumnName("ATTRIBUTENAME");
            entity.Property(e => e.Attributevalue)
                .HasColumnType("NCLOB")
                .HasColumnName("ATTRIBUTEVALUE");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Documentcode)
                .HasMaxLength(255)
                .HasColumnName("DOCUMENTCODE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
        });

        modelBuilder.Entity<Ualsapsystem>(entity =>
        {
            entity.HasKey(e => e.Sapsystemid);
            entity.ToTable("UALSAPSYSTEMS");

            entity.Property(e => e.Clientcode)
                .HasMaxLength(32)
                .HasColumnName("CLIENTCODE");
            entity.Property(e => e.Connectionname)
                .HasMaxLength(128)
                .HasColumnName("CONNECTIONNAME");
            entity.Property(e => e.Instancecode)
                .HasMaxLength(32)
                .HasColumnName("INSTANCECODE");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(128)
                .HasColumnName("LANGUAGECODE");
            entity.Property(e => e.Lasttouchdate).HasColumnName("LASTTOUCHDATE");
            entity.Property(e => e.Pagecode)
                .HasMaxLength(32)
                .HasColumnName("PAGECODE");
            entity.Property(e => e.Sapcomment)
                .HasMaxLength(4000)
                .HasColumnName("SAPCOMMENT");
            entity.Property(e => e.Saphostname)
                .HasMaxLength(128)
                .HasColumnName("SAPHOSTNAME");
            entity.Property(e => e.Sapsystemid).HasColumnName("SAPSYSTEMID");
            entity.Property(e => e.Username)
                .HasMaxLength(128)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Ualscanhost>(entity =>
        {
            entity.HasKey(e => e.Scanhostid);
            entity.ToTable("UALSCANHOSTS");

            entity.Property(e => e.Lasttouchdate).HasColumnName("LASTTOUCHDATE");
            entity.Property(e => e.Scanhostdesc)
                .HasMaxLength(255)
                .HasColumnName("SCANHOSTDESC");
            entity.Property(e => e.Scanhostid).HasColumnName("SCANHOSTID");
            entity.Property(e => e.Scanhostname)
                .HasMaxLength(255)
                .HasColumnName("SCANHOSTNAME");
            entity.Property(e => e.Scanhostsite)
                .HasMaxLength(255)
                .HasColumnName("SCANHOSTSITE");
        });

        modelBuilder.Entity<Ualscanhostarchivemode>(entity =>
        {
            entity.HasKey(e => new { e.Scanhostid, e.Archivemodeid });
            entity.ToTable("UALSCANHOSTARCHIVEMODE");

            entity.Property(e => e.Archivemodeid).HasColumnName("ARCHIVEMODEID");
            entity.Property(e => e.Defaultflag).HasColumnName("DEFAULTFLAG");
            entity.Property(e => e.Lasttouchdate).HasColumnName("LASTTOUCHDATE");
            entity.Property(e => e.Scanhostid).HasColumnName("SCANHOSTID");
        });

        modelBuilder.Entity<UapiexplodeDynamicResultBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UAPIEXPLODE_DYNAMIC_RESULT_BASE");

            entity.Property(e => e.Childid).HasColumnName("CHILDID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Path)
                .IsUnicode(false)
                .HasColumnName("PATH");
        });

        modelBuilder.Entity<UapiexplodeDynamicResultId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UAPIEXPLODE_DYNAMIC_RESULT_IDS");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Ugenerator>(entity =>
        {
            entity.HasKey(e => e.Uniqueval);
            entity.ToTable("UGENERATOR");

            entity.Property(e => e.Appltype)
                .HasMaxLength(255)
                .HasColumnName("APPLTYPE");
            entity.Property(e => e.Docprefix)
                .HasMaxLength(255)
                .HasColumnName("DOCPREFIX");
            entity.Property(e => e.Doctype)
                .HasMaxLength(255)
                .HasColumnName("DOCTYPE");
            entity.Property(e => e.Mainpart)
                .HasColumnType("INTEGER")
                .HasColumnName("MAINPART");
            entity.Property(e => e.Secondpart)
                .HasColumnType("INTEGER")
                .HasColumnName("SECONDPART");
            entity.Property(e => e.Uniqueval)
                .HasMaxLength(64)
                .HasColumnName("UNIQUEVAL");
        });

        modelBuilder.Entity<Undolabelinfo>(entity =>
        {
            entity.HasKey(e => new { e.Workid, e.Taskno });
            entity.ToTable("UNDOLABELINFO");

            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Taskno)
                .HasColumnType("INTEGER")
                .HasColumnName("TASKNO");
            entity.Property(e => e.Undolabel)
                .HasMaxLength(32)
                .HasColumnName("UNDOLABEL");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Updateagent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UPDATEAGENTS");

            entity.Property(e => e.AgentId)
                .HasMaxLength(255)
                .HasColumnName("AGENT_ID");
            entity.Property(e => e.CreateDatetime).HasColumnName("CREATE_DATETIME");
            entity.Property(e => e.HostIp)
                .HasMaxLength(64)
                .HasColumnName("HOST_IP");
            entity.Property(e => e.HostName)
                .HasMaxLength(255)
                .HasColumnName("HOST_NAME");
            entity.Property(e => e.HostOs)
                .HasMaxLength(255)
                .HasColumnName("HOST_OS");
            entity.Property(e => e.HostPort)
                .HasMaxLength(64)
                .HasColumnName("HOST_PORT");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.LastModifyDatetime).HasColumnName("LAST_MODIFY_DATETIME");
            entity.Property(e => e.Metadata)
                .HasColumnType("NCLOB")
                .HasColumnName("METADATA");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Updateagenthistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UPDATEAGENTHISTORY");

            entity.Property(e => e.AgentId)
                .HasMaxLength(255)
                .HasColumnName("AGENT_ID");
            entity.Property(e => e.EventDate).HasColumnName("EVENT_DATE");
            entity.Property(e => e.EventMetadata)
                .HasMaxLength(4000)
                .HasColumnName("EVENT_METADATA");
            entity.Property(e => e.EventResult)
                .HasMaxLength(255)
                .HasColumnName("EVENT_RESULT");
            entity.Property(e => e.EventSource)
                .HasMaxLength(255)
                .HasColumnName("EVENT_SOURCE");
            entity.Property(e => e.EventType).HasColumnName("EVENT_TYPE");
        });

        modelBuilder.Entity<Userlabel>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Labeldefname });
            entity.ToTable("USERLABELS");

            entity.Property(e => e.Createdatetime).HasColumnName("CREATEDATETIME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Labelcontent)
                .HasColumnType("NCLOB")
                .HasColumnName("LABELCONTENT");
            entity.Property(e => e.Labeldefname)
                .HasMaxLength(32)
                .HasColumnName("LABELDEFNAME");
            entity.Property(e => e.Noofcopies).HasColumnName("NOOFCOPIES");
            entity.Property(e => e.Printflag).HasColumnName("PRINTFLAG");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Usernickname>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Nickname });
            entity.ToTable("USERNICKNAME");

            entity.Property(e => e.Domain)
                .HasMaxLength(255)
                .HasColumnName("DOMAIN");
            entity.Property(e => e.Nickname)
                .HasMaxLength(255)
                .HasColumnName("NICKNAME");
            entity.Property(e => e.Pwpdataid).HasColumnName("PWPDATAID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Xsl).HasColumnName("XSL");
        });

        modelBuilder.Entity<Usertabright>(entity =>
        {
            entity.HasKey(e => e.Rightid);
            entity.ToTable("USERTABRIGHTS");

            entity.Property(e => e.Owneredit).HasColumnName("OWNEREDIT");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.Tabname)
                .HasMaxLength(64)
                .HasColumnName("TABNAME");
        });

        modelBuilder.Entity<Viewxoption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VIEWXOPTIONS");

            entity.Property(e => e.Puboption)
                .HasColumnType("NCLOB")
                .HasColumnName("PUBOPTION");
            entity.Property(e => e.Pubversion).HasColumnName("PUBVERSION");
            entity.Property(e => e.Rightid).HasColumnName("RIGHTID");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Viewxid).HasColumnName("VIEWXID");
        });

        modelBuilder.Entity<Viewxpublication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VIEWXPUBLICATIONS");

            entity.Property(e => e.Endtime).HasColumnName("ENDTIME");
            entity.Property(e => e.Iscomplete).HasColumnName("ISCOMPLETE");
            entity.Property(e => e.Keepcached).HasColumnName("KEEPCACHED");
            entity.Property(e => e.Lastviewed).HasColumnName("LASTVIEWED");
            entity.Property(e => e.Pollcount).HasColumnName("POLLCOUNT");
            entity.Property(e => e.Pollerrcount).HasColumnName("POLLERRCOUNT");
            entity.Property(e => e.Pubdata)
                .HasColumnType("NCLOB")
                .HasColumnName("PUBDATA");
            entity.Property(e => e.Pubkey)
                .HasMaxLength(64)
                .HasColumnName("PUBKEY");
            entity.Property(e => e.Pubtype)
                .HasMaxLength(64)
                .HasDefaultValueSql("SimpleView")
                .HasColumnName("PUBTYPE");
            entity.Property(e => e.Score).HasColumnName("SCORE");
            entity.Property(e => e.Starttime).HasColumnName("STARTTIME");
            entity.Property(e => e.State)
                .HasMaxLength(32)
                .HasColumnName("STATE");
            entity.Property(e => e.Statusmsg)
                .HasMaxLength(1024)
                .HasColumnName("STATUSMSG");
            entity.Property(e => e.Totalsize).HasColumnName("TOTALSIZE");
            entity.Property(e => e.Updatetime).HasColumnName("UPDATETIME");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
            entity.Property(e => e.Viewcount).HasColumnName("VIEWCOUNT");
            entity.Property(e => e.Viewxid).HasColumnName("VIEWXID");
            entity.Property(e => e.Xrefskey)
                .HasMaxLength(64)
                .HasColumnName("XREFSKEY");
        });

        modelBuilder.Entity<Waudittrail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WAUDITTRAIL");

            entity.Property(e => e.WorkauditAuditid).HasColumnName("WORKAUDIT_AUDITID");
            entity.Property(e => e.WorkauditDate).HasColumnName("WORKAUDIT_DATE");
            entity.Property(e => e.WorkauditPerformerid).HasColumnName("WORKAUDIT_PERFORMERID");
            entity.Property(e => e.WorkauditPerformeridName)
                .HasMaxLength(255)
                .HasColumnName("WORKAUDIT_PERFORMERID_NAME");
            entity.Property(e => e.WorkauditStatus)
                .HasColumnType("INTEGER")
                .HasColumnName("WORKAUDIT_STATUS");
            entity.Property(e => e.WorkauditSubworkid).HasColumnName("WORKAUDIT_SUBWORKID");
            entity.Property(e => e.WorkauditTaskTitle)
                .HasMaxLength(255)
                .HasColumnName("WORKAUDIT_TASK_TITLE");
            entity.Property(e => e.WorkauditTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("WORKAUDIT_TASKID");
            entity.Property(e => e.WorkauditTaskiternum)
                .HasColumnType("INTEGER")
                .HasColumnName("WORKAUDIT_TASKITERNUM");
            entity.Property(e => e.WorkauditUserdata)
                .HasColumnType("NCLOB")
                .HasColumnName("WORKAUDIT_USERDATA");
            entity.Property(e => e.WorkauditWorkid).HasColumnName("WORKAUDIT_WORKID");
        });

        modelBuilder.Entity<Wdatum>(entity =>
        {
            entity.HasKey(e => new { e.DataWorkid, e.DataSubworkid });
            entity.ToTable("WDATA");

            entity.Property(e => e.DataDescription)
                .HasMaxLength(4000)
                .HasColumnName("DATA_DESCRIPTION");
            entity.Property(e => e.DataSubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("DATA_SUBTYPE");
            entity.Property(e => e.DataSubworkid).HasColumnName("DATA_SUBWORKID");
            entity.Property(e => e.DataType)
                .HasColumnType("INTEGER")
                .HasColumnName("DATA_TYPE");
            entity.Property(e => e.DataUserdata)
                .HasMaxLength(4000)
                .HasColumnName("DATA_USERDATA");
            entity.Property(e => e.DataWorkid).HasColumnName("DATA_WORKID");
        });

        modelBuilder.Entity<Webactivework>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBACTIVEWORK");

            entity.Property(e => e.MapMapid).HasColumnName("MAP_MAPID");
            entity.Property(e => e.MapMapobjid).HasColumnName("MAP_MAPOBJID");
            entity.Property(e => e.SubworkDatedueMax).HasColumnName("SUBWORK_DATEDUE_MAX");
            entity.Property(e => e.SubworkDateinitiated).HasColumnName("SUBWORK_DATEINITIATED");
            entity.Property(e => e.SubworkReturnsubworkid).HasColumnName("SUBWORK_RETURNSUBWORKID");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworkUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORK_USERDATA");
            entity.Property(e => e.SubworktaskDatedueMax).HasColumnName("SUBWORKTASK_DATEDUE_MAX");
            entity.Property(e => e.SubworktaskDatemilestone).HasColumnName("SUBWORKTASK_DATEMILESTONE");
            entity.Property(e => e.WorkDatedueMax).HasColumnName("WORK_DATEDUE_MAX");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Webactiveworkbase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBACTIVEWORKBASE");

            entity.Property(e => e.MapMapid).HasColumnName("MAP_MAPID");
            entity.Property(e => e.MapMapobjid).HasColumnName("MAP_MAPOBJID");
            entity.Property(e => e.SubworkDatedueMax).HasColumnName("SUBWORK_DATEDUE_MAX");
            entity.Property(e => e.SubworkDateinitiated).HasColumnName("SUBWORK_DATEINITIATED");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworktaskDatedueMax).HasColumnName("SUBWORKTASK_DATEDUE_MAX");
            entity.Property(e => e.SubworktaskDatemilestone).HasColumnName("SUBWORKTASK_DATEMILESTONE");
            entity.Property(e => e.WorkDatedueMax).HasColumnName("WORK_DATEDUE_MAX");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Webeditlock>(entity =>
        {
            entity.HasKey(e => e.Expirydate);
            entity.ToTable("WEBEDITLOCK");

            entity.Property(e => e.Anchornid).HasColumnName("ANCHORNID");
            entity.Property(e => e.Expirydate).HasColumnName("EXPIRYDATE");
            entity.Property(e => e.Linkresdate).HasColumnName("LINKRESDATE");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
        });

        modelBuilder.Entity<Webeditlockunreserve>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBEDITLOCKUNRESERVE");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<Webnode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBNODES");

            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datasize).HasColumnName("DATASIZE");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Externalcreatorid).HasColumnName("EXTERNALCREATORID");
            entity.Property(e => e.Externalmodifydate).HasColumnName("EXTERNALMODIFYDATE");
            entity.Property(e => e.Externalsourceid).HasColumnName("EXTERNALSOURCEID");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filetype)
                .HasMaxLength(255)
                .HasColumnName("FILETYPE");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Ownername)
                .HasMaxLength(255)
                .HasColumnName("OWNERNAME");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Ressize).HasColumnName("RESSIZE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<WebnodesTrTr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBNODES_TR_TR");

            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datasize).HasColumnName("DATASIZE");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(255)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Externalcreatorid).HasColumnName("EXTERNALCREATORID");
            entity.Property(e => e.Externalmodifydate).HasColumnName("EXTERNALMODIFYDATE");
            entity.Property(e => e.Externalsourceid).HasColumnName("EXTERNALSOURCEID");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filetype)
                .HasMaxLength(255)
                .HasColumnName("FILETYPE");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Orderref).HasColumnName("ORDERREF");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Ressize).HasColumnName("RESSIZE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<WebnodesbrowseTrTr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBNODESBROWSE_TR_TR");

            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datasize).HasColumnName("DATASIZE");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(255)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Externalcreatorid).HasColumnName("EXTERNALCREATORID");
            entity.Property(e => e.Externalmodifydate).HasColumnName("EXTERNALMODIFYDATE");
            entity.Property(e => e.Externalsourceid).HasColumnName("EXTERNALSOURCEID");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filetype)
                .HasMaxLength(255)
                .HasColumnName("FILETYPE");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Ressize).HasColumnName("RESSIZE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.WndComments).HasColumnName("WND_COMMENTS");
            entity.Property(e => e.WndModifiedby).HasColumnName("WND_MODIFIEDBY");
            entity.Property(e => e.WnfAtt14z919)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_14Z9_19");
            entity.Property(e => e.WnfAtt17crk2)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_2");
            entity.Property(e => e.WnfAtt17crk3)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_3");
            entity.Property(e => e.WnfAtt17crkC)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_C");
            entity.Property(e => e.WnfAtt17crkF).HasColumnName("WNF_ATT_17CRK_F");
            entity.Property(e => e.WnfAtt17crkG).HasColumnName("WNF_ATT_17CRK_G");
            entity.Property(e => e.WnfAtt17kgdF)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17KGD_F");
            entity.Property(e => e.WnfAtt1gylt2)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_1GYLT_2");
            entity.Property(e => e.WnfBoTypeId).HasColumnName("WNF_BO_TYPE_ID");
            entity.Property(e => e.WnfReadydate).HasColumnName("WNF_READYDATE");
            entity.Property(e => e.WnfWkspNameTrTr)
                .HasMaxLength(255)
                .HasColumnName("WNF_WKSP_NAME_TR_TR");
            entity.Property(e => e.WnfWkspTypeId).HasColumnName("WNF_WKSP_TYPE_ID");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<Webnodescatalog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBNODESCATALOGS");

            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datasize).HasColumnName("DATASIZE");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(4000)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Externalcreatorid).HasColumnName("EXTERNALCREATORID");
            entity.Property(e => e.Externalmodifydate).HasColumnName("EXTERNALMODIFYDATE");
            entity.Property(e => e.Externalsourceid).HasColumnName("EXTERNALSOURCEID");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filetype)
                .HasMaxLength(255)
                .HasColumnName("FILETYPE");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Ressize).HasColumnName("RESSIZE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<WebnodescatalogsTrTr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBNODESCATALOGS_TR_TR");

            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datasize).HasColumnName("DATASIZE");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(255)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Externalcreatorid).HasColumnName("EXTERNALCREATORID");
            entity.Property(e => e.Externalmodifydate).HasColumnName("EXTERNALMODIFYDATE");
            entity.Property(e => e.Externalsourceid).HasColumnName("EXTERNALSOURCEID");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filetype)
                .HasMaxLength(255)
                .HasColumnName("FILETYPE");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Ressize).HasColumnName("RESSIZE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<WebnodesdeletedTrTr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WEBNODESDELETED_TR_TR");

            entity.Property(e => e.Assignedto).HasColumnName("ASSIGNEDTO");
            entity.Property(e => e.Catalog)
                .HasColumnType("INTEGER")
                .HasColumnName("CATALOG");
            entity.Property(e => e.Childcount).HasColumnName("CHILDCOUNT");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Datasize).HasColumnName("DATASIZE");
            entity.Property(e => e.Datatype).HasColumnName("DATATYPE");
            entity.Property(e => e.Dcategory)
                .HasMaxLength(255)
                .HasColumnName("DCATEGORY");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(255)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Exatt1)
                .HasMaxLength(255)
                .HasColumnName("EXATT1");
            entity.Property(e => e.Externalcreatedate).HasColumnName("EXTERNALCREATEDATE");
            entity.Property(e => e.Externalcreatorid).HasColumnName("EXTERNALCREATORID");
            entity.Property(e => e.Externalmodifydate).HasColumnName("EXTERNALMODIFYDATE");
            entity.Property(e => e.Externalsourceid).HasColumnName("EXTERNALSOURCEID");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Filetype)
                .HasMaxLength(255)
                .HasColumnName("FILETYPE");
            entity.Property(e => e.Gif)
                .HasMaxLength(255)
                .HasColumnName("GIF");
            entity.Property(e => e.Gpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("GPERMISSIONS");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Major).HasColumnName("MAJOR");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(255)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordering).HasColumnName("ORDERING");
            entity.Property(e => e.Orderref).HasColumnName("ORDERREF");
            entity.Property(e => e.Origindataid).HasColumnName("ORIGINDATAID");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Permid).HasColumnName("PERMID");
            entity.Property(e => e.Priority)
                .HasColumnType("INTEGER")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Reserved).HasColumnName("RESERVED");
            entity.Property(e => e.Reservedby).HasColumnName("RESERVEDBY");
            entity.Property(e => e.Reserveddate).HasColumnName("RESERVEDDATE");
            entity.Property(e => e.Ressize).HasColumnName("RESSIZE");
            entity.Property(e => e.Spermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("SPERMISSIONS");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtype)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.Upermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("UPERMISSIONS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.WndComments).HasColumnName("WND_COMMENTS");
            entity.Property(e => e.WndModifiedby).HasColumnName("WND_MODIFIEDBY");
            entity.Property(e => e.WnfAtt14z919)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_14Z9_19");
            entity.Property(e => e.WnfAtt17crk2)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_2");
            entity.Property(e => e.WnfAtt17crk3)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_3");
            entity.Property(e => e.WnfAtt17crkC)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_C");
            entity.Property(e => e.WnfAtt17crkF).HasColumnName("WNF_ATT_17CRK_F");
            entity.Property(e => e.WnfAtt17crkG).HasColumnName("WNF_ATT_17CRK_G");
            entity.Property(e => e.WnfAtt17kgdF)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17KGD_F");
            entity.Property(e => e.WnfAtt1gylt2)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_1GYLT_2");
            entity.Property(e => e.WnfBoTypeId).HasColumnName("WNF_BO_TYPE_ID");
            entity.Property(e => e.WnfReadydate).HasColumnName("WNF_READYDATE");
            entity.Property(e => e.WnfWkspNameTrTr)
                .HasMaxLength(255)
                .HasColumnName("WNF_WKSP_NAME_TR_TR");
            entity.Property(e => e.WnfWkspTypeId).HasColumnName("WNF_WKSP_TYPE_ID");
            entity.Property(e => e.Wpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WPERMISSIONS");
        });

        modelBuilder.Entity<Webnodesdisplay>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("WEBNODESDISPLAY");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.WndComments).HasColumnName("WND_COMMENTS");
            entity.Property(e => e.WndModifiedby).HasColumnName("WND_MODIFIEDBY");
        });

        modelBuilder.Entity<Webnodesfilter>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.WnfAtt17kgdF });
            entity.ToTable("WEBNODESFILTER");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.WnfAtt14z919)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_14Z9_19");
            entity.Property(e => e.WnfAtt17crk2)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_2");
            entity.Property(e => e.WnfAtt17crk3)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_3");
            entity.Property(e => e.WnfAtt17crkC)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17CRK_C");
            entity.Property(e => e.WnfAtt17crkF).HasColumnName("WNF_ATT_17CRK_F");
            entity.Property(e => e.WnfAtt17crkG).HasColumnName("WNF_ATT_17CRK_G");
            entity.Property(e => e.WnfAtt17kgdF)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_17KGD_F");
            entity.Property(e => e.WnfAtt1gylt2)
                .HasMaxLength(64)
                .HasColumnName("WNF_ATT_1GYLT_2");
            entity.Property(e => e.WnfBoTypeId).HasColumnName("WNF_BO_TYPE_ID");
            entity.Property(e => e.WnfReadydate).HasColumnName("WNF_READYDATE");
            entity.Property(e => e.WnfWkspNameTrTr)
                .HasMaxLength(255)
                .HasColumnName("WNF_WKSP_NAME_TR_TR");
            entity.Property(e => e.WnfWkspTypeId).HasColumnName("WNF_WKSP_TYPE_ID");
        });

        modelBuilder.Entity<WebnodesmetaTrTr>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("WEBNODESMETA_TR_TR");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dcomment)
                .HasMaxLength(255)
                .HasColumnName("DCOMMENT");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Webreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEBREPORTS");

            entity.Property(e => e.Nextrun).HasColumnName("NEXTRUN");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Repday).HasColumnName("REPDAY");
            entity.Property(e => e.Rephour).HasColumnName("REPHOUR");
            entity.Property(e => e.Repmin).HasColumnName("REPMIN");
            entity.Property(e => e.Repweek).HasColumnName("REPWEEK");
            entity.Property(e => e.Runcondition)
                .HasMaxLength(32)
                .HasColumnName("RUNCONDITION");
            entity.Property(e => e.Rundates)
                .HasColumnType("NCLOB")
                .HasColumnName("RUNDATES");
            entity.Property(e => e.Rundaysmonth)
                .HasColumnType("NCLOB")
                .HasColumnName("RUNDAYSMONTH");
            entity.Property(e => e.Rundaysweek)
                .HasColumnType("NCLOB")
                .HasColumnName("RUNDAYSWEEK");
            entity.Property(e => e.Runtimes).HasColumnName("RUNTIMES");
            entity.Property(e => e.Runweeks)
                .HasColumnType("NCLOB")
                .HasColumnName("RUNWEEKS");
            entity.Property(e => e.Schedenabled).HasColumnName("SCHEDENABLED");
            entity.Property(e => e.Seqno).HasColumnName("SEQNO");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Wrdata)
                .HasColumnType("NCLOB")
                .HasColumnName("WRDATA");
        });

        modelBuilder.Entity<Webreportstat>(entity =>
        {
            entity.HasKey(e => new { e.Datefirstaction, e.Userstatus });
            entity.ToTable("WEBREPORTSTATS");

            entity.Property(e => e.Action)
                .HasMaxLength(64)
                .HasColumnName("ACTION");
            entity.Property(e => e.Datefirstaction).HasColumnName("DATEFIRSTACTION");
            entity.Property(e => e.Datelastaction).HasColumnName("DATELASTACTION");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Stats)
                .HasColumnType("NCLOB")
                .HasColumnName("STATS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Userstatus).HasColumnName("USERSTATUS");
        });

        modelBuilder.Entity<Webreporttrigger>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("WEBREPORTTRIGGERS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Inherit).HasColumnName("INHERIT");
            entity.Property(e => e.Show).HasColumnName("SHOW");
            entity.Property(e => e.Triggers)
                .HasColumnType("NCLOB")
                .HasColumnName("TRIGGERS");
            entity.Property(e => e.Wrid).HasColumnName("WRID");
        });

        modelBuilder.Entity<Webreportugtrigger>(entity =>
        {
            entity.HasKey(e => e.Ugevent);
            entity.ToTable("WEBREPORTUGTRIGGERS");

            entity.Property(e => e.Global).HasColumnName("GLOBAL");
            entity.Property(e => e.Inherit).HasColumnName("INHERIT");
            entity.Property(e => e.Rowno).HasColumnName("ROWNO");
            entity.Property(e => e.Ugevent)
                .HasMaxLength(64)
                .HasColumnName("UGEVENT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Wrid).HasColumnName("WRID");
        });

        modelBuilder.Entity<Wfassignmentsconfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WFASSIGNMENTSCONFIGURATION");

            entity.Property(e => e.Configadditionaldata)
                .HasMaxLength(4000)
                .HasColumnName("CONFIGADDITIONALDATA");
            entity.Property(e => e.Configdisplayname)
                .HasMaxLength(128)
                .HasColumnName("CONFIGDISPLAYNAME");
            entity.Property(e => e.Configdisplaynamelocalized)
                .HasMaxLength(4000)
                .HasColumnName("CONFIGDISPLAYNAMELOCALIZED");
            entity.Property(e => e.Configurationid).HasColumnName("CONFIGURATIONID");
            entity.Property(e => e.Configurationuserdata)
                .HasMaxLength(4000)
                .HasColumnName("CONFIGURATIONUSERDATA");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifieddate).HasColumnName("MODIFIEDDATE");
            entity.Property(e => e.Purpose)
                .HasMaxLength(4000)
                .HasColumnName("PURPOSE");
            entity.Property(e => e.Statustype)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUSTYPE");
            entity.Property(e => e.Workflowmapid).HasColumnName("WORKFLOWMAPID");
        });

        modelBuilder.Entity<Wfattrdataversion>(entity =>
        {
            entity.HasKey(e => new { e.WfId, e.WfSubworkid, e.WfTaskid });
            entity.ToTable("WFATTRDATAVERSIONS");

            entity.Property(e => e.WfAttrid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_ATTRID");
            entity.Property(e => e.WfAttrtype)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_ATTRTYPE");
            entity.Property(e => e.WfEntrynum)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_ENTRYNUM");
            entity.Property(e => e.WfId).HasColumnName("WF_ID");
            entity.Property(e => e.WfSubworkid).HasColumnName("WF_SUBWORKID");
            entity.Property(e => e.WfTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_TASKID");
            entity.Property(e => e.WfTaskiternum)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_TASKITERNUM");
            entity.Property(e => e.WfValdate).HasColumnName("WF_VALDATE");
            entity.Property(e => e.WfValint).HasColumnName("WF_VALINT");
            entity.Property(e => e.WfVallong)
                .HasColumnType("NCLOB")
                .HasColumnName("WF_VALLONG");
            entity.Property(e => e.WfValreal)
                .HasColumnType("DECIMAL")
                .HasColumnName("WF_VALREAL");
            entity.Property(e => e.WfValstr)
                .HasMaxLength(248)
                .HasColumnName("WF_VALSTR");
        });

        modelBuilder.Entity<Wfattrdatum>(entity =>
        {
            entity.HasKey(e => new { e.WfId, e.WfAttrid, e.WfEntrynum });
            entity.ToTable("WFATTRDATA");

            entity.Property(e => e.WfAttrid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_ATTRID");
            entity.Property(e => e.WfAttrtype)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_ATTRTYPE");
            entity.Property(e => e.WfEntrynum)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_ENTRYNUM");
            entity.Property(e => e.WfId).HasColumnName("WF_ID");
            entity.Property(e => e.WfValdate).HasColumnName("WF_VALDATE");
            entity.Property(e => e.WfValint).HasColumnName("WF_VALINT");
            entity.Property(e => e.WfVallong)
                .HasColumnType("NCLOB")
                .HasColumnName("WF_VALLONG");
            entity.Property(e => e.WfValreal)
                .HasColumnType("DECIMAL")
                .HasColumnName("WF_VALREAL");
            entity.Property(e => e.WfValstr)
                .HasMaxLength(248)
                .HasColumnName("WF_VALSTR");
        });

        modelBuilder.Entity<Wfcomment>(entity =>
        {
            entity.HasKey(e => new { e.WfWorkflowid, e.WfTaskid });
            entity.ToTable("WFCOMMENTS");

            entity.Property(e => e.WfCommentid).HasColumnName("WF_COMMENTID");
            entity.Property(e => e.WfDatesaved).HasColumnName("WF_DATESAVED");
            entity.Property(e => e.WfPerformerid).HasColumnName("WF_PERFORMERID");
            entity.Property(e => e.WfSequence)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_SEQUENCE");
            entity.Property(e => e.WfTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_TASKID");
            entity.Property(e => e.WfValue)
                .HasColumnType("NCLOB")
                .HasColumnName("WF_VALUE");
            entity.Property(e => e.WfWorkflowid).HasColumnName("WF_WORKFLOWID");
        });

        modelBuilder.Entity<Wfdisposition>(entity =>
        {
            entity.HasKey(e => new { e.WfWorkflowid, e.WfTaskid });
            entity.ToTable("WFDISPOSITIONS");

            entity.Property(e => e.WfTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_TASKID");
            entity.Property(e => e.WfValue)
                .HasMaxLength(4000)
                .HasColumnName("WF_VALUE");
            entity.Property(e => e.WfWorkflowid).HasColumnName("WF_WORKFLOWID");
        });

        modelBuilder.Entity<Wfform>(entity =>
        {
            entity.HasKey(e => new { e.WfWorkflowid, e.WfFormid });
            entity.ToTable("WFFORMS");

            entity.Property(e => e.WfFormid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_FORMID");
            entity.Property(e => e.WfValue)
                .HasColumnType("NCLOB")
                .HasColumnName("WF_VALUE");
            entity.Property(e => e.WfWorkflowid).HasColumnName("WF_WORKFLOWID");
        });

        modelBuilder.Entity<Wfformslock>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("WFFORMSLOCK");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Wfformsversion>(entity =>
        {
            entity.HasKey(e => new { e.WfWorkflowid, e.WfTaskid });
            entity.ToTable("WFFORMSVERSIONS");

            entity.Property(e => e.WfFormid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_FORMID");
            entity.Property(e => e.WfSubworkid).HasColumnName("WF_SUBWORKID");
            entity.Property(e => e.WfTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("WF_TASKID");
            entity.Property(e => e.WfValue)
                .HasColumnType("NCLOB")
                .HasColumnName("WF_VALUE");
            entity.Property(e => e.WfWorkflowid).HasColumnName("WF_WORKFLOWID");
        });

        modelBuilder.Entity<Wikilink>(entity =>
        {
            entity.HasKey(e => new { e.Containerid, e.Sourceid, e.Targetid });
            entity.ToTable("WIKILINKS");

            entity.Property(e => e.Containerid).HasColumnName("CONTAINERID");
            entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");
            entity.Property(e => e.Targetid).HasColumnName("TARGETID");
        });

        modelBuilder.Entity<Wikiredirect>(entity =>
        {
            entity.HasKey(e => new { e.Containerid, e.Previousname, e.Id });
            entity.ToTable("WIKIREDIRECTS");

            entity.Property(e => e.Containerid).HasColumnName("CONTAINERID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Previousname)
                .HasMaxLength(255)
                .HasColumnName("PREVIOUSNAME");
        });

        modelBuilder.Entity<Windexnotify>(entity =>
        {
            entity.HasKey(e => new { e.Workid, e.Subworkid, e.Operation });
            entity.ToTable("WINDEXNOTIFY");

            entity.Property(e => e.Operation)
                .HasColumnType("INTEGER")
                .HasColumnName("OPERATION");
            entity.Property(e => e.Subworkid).HasColumnName("SUBWORKID");
            entity.Property(e => e.Workid).HasColumnName("WORKID");
        });

        modelBuilder.Entity<Wlock>(entity =>
        {
            entity.HasKey(e => e.WlockWorkid);
            entity.ToTable("WLOCK");

            entity.Property(e => e.WlockWorkid).HasColumnName("WLOCK_WORKID");
        });

        modelBuilder.Entity<Wmap>(entity =>
        {
            entity.HasKey(e => e.MapMapobjid);
            entity.ToTable("WMAP");

            entity.Property(e => e.MapArchivecb)
                .HasMaxLength(4000)
                .HasColumnName("MAP_ARCHIVECB");
            entity.Property(e => e.MapCompletecb)
                .HasMaxLength(4000)
                .HasColumnName("MAP_COMPLETECB");
            entity.Property(e => e.MapCustomdata)
                .HasMaxLength(4000)
                .HasColumnName("MAP_CUSTOMDATA");
            entity.Property(e => e.MapDeletecb)
                .HasMaxLength(4000)
                .HasColumnName("MAP_DELETECB");
            entity.Property(e => e.MapDescription)
                .HasMaxLength(4000)
                .HasColumnName("MAP_DESCRIPTION");
            entity.Property(e => e.MapDuedate).HasColumnName("MAP_DUEDATE");
            entity.Property(e => e.MapDueduration)
                .HasColumnType("INTEGER")
                .HasColumnName("MAP_DUEDURATION");
            entity.Property(e => e.MapDuetime)
                .HasColumnType("INTEGER")
                .HasColumnName("MAP_DUETIME");
            entity.Property(e => e.MapEndlinks)
                .HasMaxLength(255)
                .HasColumnName("MAP_ENDLINKS");
            entity.Property(e => e.MapFlags)
                .HasColumnType("INTEGER")
                .HasColumnName("MAP_FLAGS");
            entity.Property(e => e.MapInitiatecb)
                .HasMaxLength(4000)
                .HasColumnName("MAP_INITIATECB");
            entity.Property(e => e.MapInstructions)
                .HasMaxLength(4000)
                .HasColumnName("MAP_INSTRUCTIONS");
            entity.Property(e => e.MapManagerid).HasColumnName("MAP_MANAGERID");
            entity.Property(e => e.MapMapid).HasColumnName("MAP_MAPID");
            entity.Property(e => e.MapMapobjid).HasColumnName("MAP_MAPOBJID");
            entity.Property(e => e.MapOwnerid).HasColumnName("MAP_OWNERID");
            entity.Property(e => e.MapPainter)
                .HasMaxLength(4000)
                .HasColumnName("MAP_PAINTER");
            entity.Property(e => e.MapPriority)
                .HasColumnType("INTEGER")
                .HasColumnName("MAP_PRIORITY");
            entity.Property(e => e.MapProject)
                .HasMaxLength(255)
                .HasColumnName("MAP_PROJECT");
            entity.Property(e => e.MapResumecb)
                .HasMaxLength(4000)
                .HasColumnName("MAP_RESUMECB");
            entity.Property(e => e.MapStartdate).HasColumnName("MAP_STARTDATE");
            entity.Property(e => e.MapStartlinks)
                .HasMaxLength(255)
                .HasColumnName("MAP_STARTLINKS");
            entity.Property(e => e.MapStopcb)
                .HasMaxLength(4000)
                .HasColumnName("MAP_STOPCB");
            entity.Property(e => e.MapSubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("MAP_SUBTYPE");
            entity.Property(e => e.MapSuspendcb)
                .HasMaxLength(4000)
                .HasColumnName("MAP_SUSPENDCB");
            entity.Property(e => e.MapTitle)
                .HasMaxLength(255)
                .HasColumnName("MAP_TITLE");
            entity.Property(e => e.MapType)
                .HasColumnType("INTEGER")
                .HasColumnName("MAP_TYPE");
            entity.Property(e => e.MapUserdata)
                .HasMaxLength(4000)
                .HasColumnName("MAP_USERDATA");
        });

        modelBuilder.Entity<Wmaptask>(entity =>
        {
            entity.HasKey(e => e.MaptaskMapid);
            entity.ToTable("WMAPTASK");

            entity.Property(e => e.MaptaskBeforesendcb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_BEFORESENDCB");
            entity.Property(e => e.MaptaskCompletecb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_COMPLETECB");
            entity.Property(e => e.MaptaskCondition)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_CONDITION");
            entity.Property(e => e.MaptaskConditioncb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_CONDITIONCB");
            entity.Property(e => e.MaptaskCustomdata)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_CUSTOMDATA");
            entity.Property(e => e.MaptaskDescription)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_DESCRIPTION");
            entity.Property(e => e.MaptaskDonecb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_DONECB");
            entity.Property(e => e.MaptaskDuedate).HasColumnName("MAPTASK_DUEDATE");
            entity.Property(e => e.MaptaskDueduration)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_DUEDURATION");
            entity.Property(e => e.MaptaskDuetime)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_DUETIME");
            entity.Property(e => e.MaptaskFalselinks)
                .HasMaxLength(64)
                .HasColumnName("MAPTASK_FALSELINKS");
            entity.Property(e => e.MaptaskFlags)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_FLAGS");
            entity.Property(e => e.MaptaskForm)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_FORM");
            entity.Property(e => e.MaptaskInitiatecb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_INITIATECB");
            entity.Property(e => e.MaptaskInstructions)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_INSTRUCTIONS");
            entity.Property(e => e.MaptaskKillcb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_KILLCB");
            entity.Property(e => e.MaptaskLooplinks)
                .HasMaxLength(64)
                .HasColumnName("MAPTASK_LOOPLINKS");
            entity.Property(e => e.MaptaskMapid).HasColumnName("MAPTASK_MAPID");
            entity.Property(e => e.MaptaskPainter)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_PAINTER");
            entity.Property(e => e.MaptaskPerformercb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_PERFORMERCB");
            entity.Property(e => e.MaptaskPerformerid).HasColumnName("MAPTASK_PERFORMERID");
            entity.Property(e => e.MaptaskPreviouslinks)
                .HasMaxLength(64)
                .HasColumnName("MAPTASK_PREVIOUSLINKS");
            entity.Property(e => e.MaptaskPriority)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_PRIORITY");
            entity.Property(e => e.MaptaskReadycb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_READYCB");
            entity.Property(e => e.MaptaskResurrectcb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_RESURRECTCB");
            entity.Property(e => e.MaptaskStartdate).HasColumnName("MAPTASK_STARTDATE");
            entity.Property(e => e.MaptaskSubmapid).HasColumnName("MAPTASK_SUBMAPID");
            entity.Property(e => e.MaptaskSubmapidcb)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_SUBMAPIDCB");
            entity.Property(e => e.MaptaskSubtype)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_SUBTYPE");
            entity.Property(e => e.MaptaskTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_TASKID");
            entity.Property(e => e.MaptaskTitle)
                .HasMaxLength(255)
                .HasColumnName("MAPTASK_TITLE");
            entity.Property(e => e.MaptaskTruelinks)
                .HasMaxLength(64)
                .HasColumnName("MAPTASK_TRUELINKS");
            entity.Property(e => e.MaptaskType)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_TYPE");
            entity.Property(e => e.MaptaskUserdata)
                .HasMaxLength(4000)
                .HasColumnName("MAPTASK_USERDATA");
            entity.Property(e => e.MaptaskWaitcount)
                .HasColumnType("INTEGER")
                .HasColumnName("MAPTASK_WAITCOUNT");
        });

        modelBuilder.Entity<Wopifailedsession>(entity =>
        {
            entity.HasKey(e => e.Sessionid);
            entity.ToTable("WOPIFAILEDSESSIONS");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Originalparentid).HasColumnName("ORIGINALPARENTID");
            entity.Property(e => e.Originalverid).HasColumnName("ORIGINALVERID");
            entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");
        });

        modelBuilder.Entity<Wopisession>(entity =>
        {
            entity.HasKey(e => e.Sessionstart);
            entity.ToTable("WOPISESSIONS");

            entity.Property(e => e.Lockid)
                .HasMaxLength(1024)
                .HasColumnName("LOCKID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Originalverid).HasColumnName("ORIGINALVERID");
            entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");
            entity.Property(e => e.Sessionstart).HasColumnName("SESSIONSTART");
            entity.Property(e => e.Wopilockts).HasColumnName("WOPILOCKTS");
        });

        modelBuilder.Entity<Wopiticket>(entity =>
        {
            entity.HasKey(e => e.Ticket);
            entity.ToTable("WOPITICKETS");

            entity.Property(e => e.Exp).HasColumnName("EXP");
            entity.Property(e => e.Extendeddata)
                .HasMaxLength(1024)
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Rdm)
                .HasMaxLength(1024)
                .HasColumnName("RDM");
            entity.Property(e => e.Ticket)
                .HasMaxLength(1024)
                .HasColumnName("TICKET");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Wopiuserinfo>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("WOPIUSERINFO");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Userinfostring)
                .HasMaxLength(1024)
                .HasColumnName("USERINFOSTRING");
        });

        modelBuilder.Entity<Wopiusernotify>(entity =>
        {
            entity.HasKey(e => e.Userid);
            entity.ToTable("WOPIUSERNOTIFY");

            entity.Property(e => e.Promotedate).HasColumnName("PROMOTEDATE");
            entity.Property(e => e.Promotestatus)
                .HasColumnType("INTEGER")
                .HasColumnName("PROMOTESTATUS");
            entity.Property(e => e.Showlicensedate).HasColumnName("SHOWLICENSEDATE");
            entity.Property(e => e.Showlicensestatus)
                .HasColumnType("INTEGER")
                .HasColumnName("SHOWLICENSESTATUS");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Workerpackage>(entity =>
        {
            entity.HasKey(e => e.Taskid);
            entity.ToTable("WORKERPACKAGES");

            entity.Property(e => e.Blob)
                .HasColumnType("NCLOB")
                .HasColumnName("BLOB");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
        });

        modelBuilder.Entity<Workerqueue>(entity =>
        {
            entity.HasKey(e => e.Nid);
            entity.ToTable("WORKERQUEUE");

            entity.Property(e => e.Activationdate).HasColumnName("ACTIVATIONDATE");
            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Fingerprint)
                .HasMaxLength(255)
                .HasColumnName("FINGERPRINT");
            entity.Property(e => e.Handlerid)
                .HasMaxLength(128)
                .HasColumnName("HANDLERID");
            entity.Property(e => e.Nid).HasColumnName("NID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Queuetime).HasColumnName("QUEUETIME");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Workerqueuechild>(entity =>
        {
            entity.HasKey(e => new { e.Taskid, e.Childtaskid });

            entity.ToTable("WORKERQUEUECHILDREN");

            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Childtaskid).HasColumnName("CHILDTASKID");
        });

        modelBuilder.Entity<Workerqueuecomplete>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("WORKERQUEUECOMPLETE");

            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Fingerprint)
                .HasMaxLength(255)
                .HasColumnName("FINGERPRINT");
            entity.Property(e => e.Handlerid)
                .HasMaxLength(128)
                .HasColumnName("HANDLERID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Queuetime).HasColumnName("QUEUETIME");
            entity.Property(e => e.Result)
                .HasColumnType("NCLOB")
                .HasColumnName("RESULT");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Workerqueuecurrent>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("WORKERQUEUECURRENT");

            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Fingerprint)
                .HasMaxLength(255)
                .HasColumnName("FINGERPRINT");
            entity.Property(e => e.Handlerid)
                .HasMaxLength(128)
                .HasColumnName("HANDLERID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Queuetime).HasColumnName("QUEUETIME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.Workerid)
                .HasMaxLength(255)
                .HasColumnName("WORKERID");
            entity.Property(e => e.Workertime).HasColumnName("WORKERTIME");
        });

        modelBuilder.Entity<Workerqueueerror>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("WORKERQUEUEERROR");

            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Description)
                .HasColumnType("NCLOB")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Errortime).HasColumnName("ERRORTIME");
            entity.Property(e => e.Fingerprint)
                .HasMaxLength(255)
                .HasColumnName("FINGERPRINT");
            entity.Property(e => e.Handlerid)
                .HasMaxLength(128)
                .HasColumnName("HANDLERID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Queuetime).HasColumnName("QUEUETIME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Workerid)
                .HasMaxLength(255)
                .HasColumnName("WORKERID");
            entity.Property(e => e.Workertime).HasColumnName("WORKERTIME");
        });

        modelBuilder.Entity<Workerqueuepending>(entity =>
        {
            entity.HasKey(e => e.Handlerid);
            entity.ToTable("WORKERQUEUEPENDING");

            entity.Property(e => e.Attempts).HasColumnName("ATTEMPTS");
            entity.Property(e => e.Fingerprint)
                .HasMaxLength(255)
                .HasColumnName("FINGERPRINT");
            entity.Property(e => e.Handlerid)
                .HasMaxLength(128)
                .HasColumnName("HANDLERID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Queuetime).HasColumnName("QUEUETIME");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Workerqueuetracking>(entity =>
        {
            entity.HasKey(e => new { e.Checktime, e.Handlerid, e.Eventtype });
            entity.ToTable("WORKERQUEUETRACKING");

            entity.Property(e => e.Checktime)
                .HasColumnType("INTEGER")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Count)
                .HasColumnType("INTEGER")
                .HasColumnName("COUNT");
            entity.Property(e => e.Eventtype).HasColumnName("EVENTTYPE");
            entity.Property(e => e.Handlerid)
                .HasMaxLength(128)
                .HasColumnName("HANDLERID");
        });

        modelBuilder.Entity<Workerstatus>(entity =>
        {
            entity.HasKey(e => e.Workerid);
            entity.ToTable("WORKERSTATUS");

            entity.Property(e => e.Agenttype).HasColumnName("AGENTTYPE");
            entity.Property(e => e.Counter)
                .HasColumnType("INTEGER")
                .HasColumnName("COUNTER");
            entity.Property(e => e.Laststatus)
                .HasColumnType("INTEGER")
                .HasColumnName("LASTSTATUS");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.Statusstr)
                .HasMaxLength(255)
                .HasColumnName("STATUSSTR");
            entity.Property(e => e.Workerid)
                .HasMaxLength(255)
                .HasColumnName("WORKERID");
        });

        modelBuilder.Entity<Wsubwork>(entity =>
        {
            entity.HasKey(e => e.SubworkStatus);
            entity.ToTable("WSUBWORK");

            entity.Property(e => e.SubworkCustomdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORK_CUSTOMDATA");
            entity.Property(e => e.SubworkDatecompleted).HasColumnName("SUBWORK_DATECOMPLETED");
            entity.Property(e => e.SubworkDatedueMax).HasColumnName("SUBWORK_DATEDUE_MAX");
            entity.Property(e => e.SubworkDatedueMin).HasColumnName("SUBWORK_DATEDUE_MIN");
            entity.Property(e => e.SubworkDateinitiated).HasColumnName("SUBWORK_DATEINITIATED");
            entity.Property(e => e.SubworkFlags)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORK_FLAGS");
            entity.Property(e => e.SubworkMapid).HasColumnName("SUBWORK_MAPID");
            entity.Property(e => e.SubworkProject)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_PROJECT");
            entity.Property(e => e.SubworkReturnsubworkid).HasColumnName("SUBWORK_RETURNSUBWORKID");
            entity.Property(e => e.SubworkReturntaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORK_RETURNTASKID");
            entity.Property(e => e.SubworkStatus).HasColumnName("SUBWORK_STATUS");
            entity.Property(e => e.SubworkSubworkid).HasColumnName("SUBWORK_SUBWORKID");
            entity.Property(e => e.SubworkTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORK_TITLE");
            entity.Property(e => e.SubworkUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORK_USERDATA");
            entity.Property(e => e.SubworkWorkid).HasColumnName("SUBWORK_WORKID");
        });

        modelBuilder.Entity<Wsubworktask>(entity =>
        {
            entity.HasKey(e => new { e.SubworktaskWaitcount, e.SubworktaskWorkid, e.SubworktaskSubworkid, e.SubworktaskTaskid });
            entity.ToTable("WSUBWORKTASK");

            entity.Property(e => e.SubworktaskCustomdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORKTASK_CUSTOMDATA");
            entity.Property(e => e.SubworktaskDatedone).HasColumnName("SUBWORKTASK_DATEDONE");
            entity.Property(e => e.SubworktaskDatedueMax).HasColumnName("SUBWORKTASK_DATEDUE_MAX");
            entity.Property(e => e.SubworktaskDatedueMin).HasColumnName("SUBWORKTASK_DATEDUE_MIN");
            entity.Property(e => e.SubworktaskDatemilestone).HasColumnName("SUBWORKTASK_DATEMILESTONE");
            entity.Property(e => e.SubworktaskDateready).HasColumnName("SUBWORKTASK_DATEREADY");
            entity.Property(e => e.SubworktaskFlags)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_FLAGS");
            entity.Property(e => e.SubworktaskIternum)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_ITERNUM");
            entity.Property(e => e.SubworktaskPerformerid).HasColumnName("SUBWORKTASK_PERFORMERID");
            entity.Property(e => e.SubworktaskStatus).HasColumnName("SUBWORKTASK_STATUS");
            entity.Property(e => e.SubworktaskSubworkid).HasColumnName("SUBWORKTASK_SUBWORKID");
            entity.Property(e => e.SubworktaskTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_TASKID");
            entity.Property(e => e.SubworktaskTitle)
                .HasMaxLength(255)
                .HasColumnName("SUBWORKTASK_TITLE");
            entity.Property(e => e.SubworktaskType)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_TYPE");
            entity.Property(e => e.SubworktaskUserdata)
                .HasMaxLength(4000)
                .HasColumnName("SUBWORKTASK_USERDATA");
            entity.Property(e => e.SubworktaskWaitcount)
                .HasColumnType("INTEGER")
                .HasColumnName("SUBWORKTASK_WAITCOUNT");
            entity.Property(e => e.SubworktaskWorkid).HasColumnName("SUBWORKTASK_WORKID");
        });

        modelBuilder.Entity<Wsubworktaskdatesummary>(entity =>
        {
            entity.HasKey(e => new { e.SubworktasksummaryWorkid, e.SubworktasksummarySubworkid });
            entity.ToTable("WSUBWORKTASKDATESUMMARY");

            entity.Property(e => e.SubtaskscaldatesFlags).HasColumnName("SUBTASKSCALDATES_FLAGS");
            entity.Property(e => e.SubworktaskCalcdatedue).HasColumnName("SUBWORKTASK_CALCDATEDUE");
            entity.Property(e => e.SubworktaskCalcdatemilestone).HasColumnName("SUBWORKTASK_CALCDATEMILESTONE");
            entity.Property(e => e.SubworktasksummarySubworkid).HasColumnName("SUBWORKTASKSUMMARY_SUBWORKID");
            entity.Property(e => e.SubworktasksummaryWorkid).HasColumnName("SUBWORKTASKSUMMARY_WORKID");
        });

        modelBuilder.Entity<Wwork>(entity =>
        {
            entity.HasKey(e => e.WorkOwnerid);
            entity.ToTable("WWORK");

            entity.Property(e => e.WorkCustomdata)
                .HasMaxLength(4000)
                .HasColumnName("WORK_CUSTOMDATA");
            entity.Property(e => e.WorkDatecompleted).HasColumnName("WORK_DATECOMPLETED");
            entity.Property(e => e.WorkDatedueMax).HasColumnName("WORK_DATEDUE_MAX");
            entity.Property(e => e.WorkDatedueMin).HasColumnName("WORK_DATEDUE_MIN");
            entity.Property(e => e.WorkDateinitiated).HasColumnName("WORK_DATEINITIATED");
            entity.Property(e => e.WorkFlags)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_FLAGS");
            entity.Property(e => e.WorkManagerid).HasColumnName("WORK_MANAGERID");
            entity.Property(e => e.WorkOwnerid).HasColumnName("WORK_OWNERID");
            entity.Property(e => e.WorkOwnerperms)
                .HasColumnType("INTEGER")
                .HasColumnName("WORK_OWNERPERMS");
            entity.Property(e => e.WorkProject)
                .HasMaxLength(255)
                .HasColumnName("WORK_PROJECT");
            entity.Property(e => e.WorkStatus).HasColumnName("WORK_STATUS");
            entity.Property(e => e.WorkUserdata)
                .HasMaxLength(4000)
                .HasColumnName("WORK_USERDATA");
            entity.Property(e => e.WorkWorkid).HasColumnName("WORK_WORKID");
        });

        modelBuilder.Entity<Wworkacl>(entity =>
        {
            entity.HasKey(e => new { e.WorkaclWorkid, e.WorkaclRightid });
            entity.ToTable("WWORKACL");

            entity.Property(e => e.WorkaclPermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("WORKACL_PERMISSIONS");
            entity.Property(e => e.WorkaclRightid).HasColumnName("WORKACL_RIGHTID");
            entity.Property(e => e.WorkaclWorkid).HasColumnName("WORKACL_WORKID");
        });

        modelBuilder.Entity<Wworkaudit>(entity =>
        {
            entity.HasKey(e => new { e.WorkauditWorkid, e.WorkauditSubworkid });
            entity.ToTable("WWORKAUDIT");

            entity.Property(e => e.WorkauditAuditid).HasColumnName("WORKAUDIT_AUDITID");
            entity.Property(e => e.WorkauditDate).HasColumnName("WORKAUDIT_DATE");
            entity.Property(e => e.WorkauditPerformerid).HasColumnName("WORKAUDIT_PERFORMERID");
            entity.Property(e => e.WorkauditStatus)
                .HasColumnType("INTEGER")
                .HasColumnName("WORKAUDIT_STATUS");
            entity.Property(e => e.WorkauditSubworkid).HasColumnName("WORKAUDIT_SUBWORKID");
            entity.Property(e => e.WorkauditTaskid)
                .HasColumnType("INTEGER")
                .HasColumnName("WORKAUDIT_TASKID");
            entity.Property(e => e.WorkauditTaskiternum)
                .HasColumnType("INTEGER")
                .HasColumnName("WORKAUDIT_TASKITERNUM");
            entity.Property(e => e.WorkauditUserdata)
                .HasColumnType("NCLOB")
                .HasColumnName("WORKAUDIT_USERDATA");
            entity.Property(e => e.WorkauditWorkid).HasColumnName("WORKAUDIT_WORKID");
        });

        modelBuilder.Entity<XecmgovAssignment>(entity =>
        {
            entity.HasKey(e => new { e.Assignmentid, e.Assignmentname });
            entity.ToTable("XECMGOV_ASSIGNMENTS");

            entity.Property(e => e.Assignmentid).HasColumnName("ASSIGNMENTID");
            entity.Property(e => e.Assignmentname)
                .HasMaxLength(248)
                .HasColumnName("ASSIGNMENTNAME");
            entity.Property(e => e.Completed).HasColumnName("COMPLETED");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Creatorpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("CREATORPERMISSIONS");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Instruction)
                .HasColumnType("NCLOB")
                .HasColumnName("INSTRUCTION");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
        });

        modelBuilder.Entity<XecmgovAssignmentrecipient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMGOV_ASSIGNMENTRECIPIENTS");

            entity.Property(e => e.Adddate).HasColumnName("ADDDATE");
            entity.Property(e => e.Addedby).HasColumnName("ADDEDBY");
            entity.Property(e => e.Assignmentid).HasColumnName("ASSIGNMENTID");
            entity.Property(e => e.Completed).HasColumnName("COMPLETED");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Recipientgroupid).HasColumnName("RECIPIENTGROUPID");
            entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");
            entity.Property(e => e.Status)
                .HasMaxLength(64)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<XecmgovAssignmentstatus>(entity =>
        {
            entity.HasKey(e => e.Status);
            entity.ToTable("XECMGOV_ASSIGNMENTSTATUS");

            entity.Property(e => e.Defaultstatus).HasColumnName("DEFAULTSTATUS");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Deletedate).HasColumnName("DELETEDATE");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Status)
                .HasMaxLength(64)
                .HasColumnName("STATUS");
            entity.Property(e => e.Terminationstatus).HasColumnName("TERMINATIONSTATUS");
        });

        modelBuilder.Entity<XecmgovAssignmentstatusmultilingual>(entity =>
        {
            entity.HasKey(e => new { e.Languagecode, e.Status });
            entity.ToTable("XECMGOV_ASSIGNMENTSTATUSMULTILINGUAL");

            entity.Property(e => e.Display)
                .HasMaxLength(64)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
            entity.Property(e => e.Status)
                .HasMaxLength(64)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<XecmgovClassificationsrecursiontype>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XECMGOV_CLASSIFICATIONSRECURSIONTYPE");

            entity.Property(e => e.Allowrecursion).HasColumnName("ALLOWRECURSION");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
        });

        modelBuilder.Entity<XecmgovCloseditem>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XECMGOV_CLOSEDITEMS");

            entity.Property(e => e.Closedate).HasColumnName("CLOSEDATE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Newrmstatus)
                .HasMaxLength(32)
                .HasColumnName("NEWRMSTATUS");
            entity.Property(e => e.Oldrmstatus)
                .HasMaxLength(32)
                .HasColumnName("OLDRMSTATUS");
        });

        modelBuilder.Entity<XecmgovDeleteAudit>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XECMGOV_DELETE_AUDIT");

            entity.Property(e => e.Containerid).HasColumnName("CONTAINERID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<XecmgovDynwfactivitytaskevent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMGOV_DYNWFACTIVITYTASKEVENTS");

            entity.Property(e => e.Activitytaskevent)
                .HasMaxLength(255)
                .HasColumnName("ACTIVITYTASKEVENT");
            entity.Property(e => e.Eventtype).HasColumnName("EVENTTYPE");
        });

        modelBuilder.Entity<XecmgovForward>(entity =>
        {
            entity.HasKey(e => new { e.Completed, e.Forwardid, e.Name });
            entity.ToTable("XECMGOV_FORWARDS");

            entity.Property(e => e.Completed).HasColumnName("COMPLETED");
            entity.Property(e => e.Completedate).HasColumnName("COMPLETEDATE");
            entity.Property(e => e.Completedby).HasColumnName("COMPLETEDBY");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Forwardid).HasColumnName("FORWARDID");
            entity.Property(e => e.Name)
                .HasMaxLength(248)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<XecmgovForwarddirective>(entity =>
        {
            entity.HasKey(e => e.Directive);
            entity.ToTable("XECMGOV_FORWARDDIRECTIVES");

            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Deletedate).HasColumnName("DELETEDATE");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Directive)
                .HasMaxLength(64)
                .HasColumnName("DIRECTIVE");
        });

        modelBuilder.Entity<XecmgovForwarddirectivesmultilingual>(entity =>
        {
            entity.HasKey(e => new { e.Languagecode, e.Directive });
            entity.ToTable("XECMGOV_FORWARDDIRECTIVESMULTILINGUAL");

            entity.Property(e => e.Directive)
                .HasMaxLength(64)
                .HasColumnName("DIRECTIVE");
            entity.Property(e => e.Display)
                .HasMaxLength(248)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Languagecode)
                .HasMaxLength(6)
                .HasColumnName("LANGUAGECODE");
        });

        modelBuilder.Entity<XecmgovForwarditem>(entity =>
        {
            entity.HasKey(e => new { e.Forwardid, e.Dataid });
            entity.ToTable("XECMGOV_FORWARDITEMS");

            entity.Property(e => e.Creatorpermissions)
                .HasColumnType("INTEGER")
                .HasColumnName("CREATORPERMISSIONS");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Forwardid).HasColumnName("FORWARDID");
        });

        modelBuilder.Entity<XecmgovForwardrecipient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMGOV_FORWARDRECIPIENTS");

            entity.Property(e => e.Adddate).HasColumnName("ADDDATE");
            entity.Property(e => e.Addedby).HasColumnName("ADDEDBY");
            entity.Property(e => e.Completed).HasColumnName("COMPLETED");
            entity.Property(e => e.Completedate).HasColumnName("COMPLETEDATE");
            entity.Property(e => e.Completedby).HasColumnName("COMPLETEDBY");
            entity.Property(e => e.Directive)
                .HasMaxLength(64)
                .HasColumnName("DIRECTIVE");
            entity.Property(e => e.Forwardid).HasColumnName("FORWARDID");
            entity.Property(e => e.Notice)
                .HasColumnType("NCLOB")
                .HasColumnName("NOTICE");
            entity.Property(e => e.Recipientgroupid).HasColumnName("RECIPIENTGROUPID");
            entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");
        });

        modelBuilder.Entity<XecmgovInboxfolder>(entity =>
        {
            entity.HasKey(e => e.Kuafid);
            entity.ToTable("XECMGOV_INBOXFOLDERS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Kuafid).HasColumnName("KUAFID");
        });

        modelBuilder.Entity<XecmgovOutboxevent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMGOV_OUTBOXEVENTS");

            entity.Property(e => e.Assignmentid).HasColumnName("ASSIGNMENTID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Eventdate).HasColumnName("EVENTDATE");
            entity.Property(e => e.Eventtype).HasColumnName("EVENTTYPE");
            entity.Property(e => e.Fileddocname)
                .HasMaxLength(248)
                .HasColumnName("FILEDDOCNAME");
            entity.Property(e => e.Performerid).HasColumnName("PERFORMERID");
        });

        modelBuilder.Entity<XecmgovxdomeaJob>(entity =>
        {
            entity.HasKey(e => e.Jobid);
            entity.ToTable("XECMGOVXDOMEA_JOBS");

            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Currentprocess)
                .HasMaxLength(255)
                .HasColumnName("CURRENTPROCESS");
            entity.Property(e => e.Currentstatus).HasColumnName("CURRENTSTATUS");
            entity.Property(e => e.Errmsg)
                .HasColumnType("NCLOB")
                .HasColumnName("ERRMSG");
            entity.Property(e => e.Feedbackarchiveid)
                .HasMaxLength(64)
                .HasColumnName("FEEDBACKARCHIVEID");
            entity.Property(e => e.Feedbackarchivelabel)
                .HasMaxLength(64)
                .HasColumnName("FEEDBACKARCHIVELABEL");
            entity.Property(e => e.Jobguid)
                .HasMaxLength(255)
                .HasColumnName("JOBGUID");
            entity.Property(e => e.Jobid).HasColumnName("JOBID");
            entity.Property(e => e.Jobresultfolderid).HasColumnName("JOBRESULTFOLDERID");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Originalcollectionid).HasColumnName("ORIGINALCOLLECTIONID");
            entity.Property(e => e.Xdomeaversion)
                .HasMaxLength(255)
                .HasColumnName("XDOMEAVERSION");
        });

        modelBuilder.Entity<XecmgovxdomeaJobprocess>(entity =>
        {
            entity.HasKey(e => new { e.Jobid, e.Process });
            entity.ToTable("XECMGOVXDOMEA_JOBPROCESSES");

            entity.Property(e => e.Confirmationrequired).HasColumnName("CONFIRMATIONREQUIRED");
            entity.Property(e => e.Coverletterdataid).HasColumnName("COVERLETTERDATAID");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Exportxmlpath)
                .HasMaxLength(4000)
                .HasColumnName("EXPORTXMLPATH");
            entity.Property(e => e.Feedbackrequired).HasColumnName("FEEDBACKREQUIRED");
            entity.Property(e => e.Hint)
                .HasColumnType("NCLOB")
                .HasColumnName("HINT");
            entity.Property(e => e.Importfiledataid).HasColumnName("IMPORTFILEDATAID");
            entity.Property(e => e.Jobid).HasColumnName("JOBID");
            entity.Property(e => e.Logfiledataid).HasColumnName("LOGFILEDATAID");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Process)
                .HasMaxLength(255)
                .HasColumnName("PROCESS");
            entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");
            entity.Property(e => e.Senderid).HasColumnName("SENDERID");
            entity.Property(e => e.Zipfiledataid).HasColumnName("ZIPFILEDATAID");
        });

        modelBuilder.Entity<XecmgovxdomeaSelectiondatum>(entity =>
        {
            entity.HasKey(e => new { e.Jobid, e.Recguid });
            entity.ToTable("XECMGOVXDOMEA_SELECTIONDATA");

            entity.Property(e => e.Jobid).HasColumnName("JOBID");
            entity.Property(e => e.Recdataid).HasColumnName("RECDATAID");
            entity.Property(e => e.Recguid)
                .HasMaxLength(255)
                .HasColumnName("RECGUID");
            entity.Property(e => e.Selectiontype)
                .HasMaxLength(64)
                .HasColumnName("SELECTIONTYPE");
            entity.Property(e => e.Status)
                .HasMaxLength(64)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<XecmpfAppintgnActInfo>(entity =>
        {
            entity.HasKey(e => e.Activityinstanceid);
            entity.ToTable("XECMPF_APPINTGN_ACT_INFO");

            entity.Property(e => e.Activityflowtitle)
                .HasMaxLength(1024)
                .HasColumnName("ACTIVITYFLOWTITLE");
            entity.Property(e => e.Activityinstanceguid)
                .HasMaxLength(255)
                .HasColumnName("ACTIVITYINSTANCEGUID");
            entity.Property(e => e.Activityinstanceid).HasColumnName("ACTIVITYINSTANCEID");
            entity.Property(e => e.Activityuserdata)
                .HasMaxLength(4000)
                .HasColumnName("ACTIVITYUSERDATA");
            entity.Property(e => e.Actvityflowid).HasColumnName("ACTVITYFLOWID");
            entity.Property(e => e.Bwsdataid).HasColumnName("BWSDATAID");
            entity.Property(e => e.Initiatedby).HasColumnName("INITIATEDBY");
            entity.Property(e => e.Initiateddate).HasColumnName("INITIATEDDATE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Taskscount).HasColumnName("TASKSCOUNT");
            entity.Property(e => e.Terminatedby).HasColumnName("TERMINATEDBY");
            entity.Property(e => e.Terminateddate).HasColumnName("TERMINATEDDATE");
            entity.Property(e => e.Workflowtype).HasColumnName("WORKFLOWTYPE");
        });

        modelBuilder.Entity<XecmpfAppintgnActTaskinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPF_APPINTGN_ACT_TASKINFO");

            entity.Property(e => e.Activityinstanceid).HasColumnName("ACTIVITYINSTANCEID");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifieddate).HasColumnName("MODIFIEDDATE");
            entity.Property(e => e.Parenttaskid).HasColumnName("PARENTTASKID");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
            entity.Property(e => e.Target).HasColumnName("TARGET");
            entity.Property(e => e.Targettype).HasColumnName("TARGETTYPE");
            entity.Property(e => e.Taskassigneeid).HasColumnName("TASKASSIGNEEID");
            entity.Property(e => e.Taskguid)
                .HasMaxLength(255)
                .HasColumnName("TASKGUID");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
            entity.Property(e => e.Tasktitle)
                .HasMaxLength(1024)
                .HasColumnName("TASKTITLE");
            entity.Property(e => e.Taskuserdata)
                .HasMaxLength(4000)
                .HasColumnName("TASKUSERDATA");
        });

        modelBuilder.Entity<XecmpfAppintgnDoctypeClassification>(entity =>
        {
            entity.HasKey(e => e.Doctypename);
            entity.ToTable("XECMPF_APPINTGN_DOCTYPE_CLASSIFICATIONS");

            entity.Property(e => e.Classficationid).HasColumnName("CLASSFICATIONID");
            entity.Property(e => e.Classificationtype).HasColumnName("CLASSIFICATIONTYPE");
            entity.Property(e => e.Docclassid).HasColumnName("DOCCLASSID");
            entity.Property(e => e.Docclassuserdata)
                .HasMaxLength(4000)
                .HasColumnName("DOCCLASSUSERDATA");
            entity.Property(e => e.Doctypename)
                .HasMaxLength(512)
                .HasColumnName("DOCTYPENAME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<XecmpfAppintgnDoctypeClasspermission>(entity =>
        {
            entity.HasKey(e => new { e.Docclassid, e.Tasktypeid });
            entity.ToTable("XECMPF_APPINTGN_DOCTYPE_CLASSPERMISSIONS");

            entity.Property(e => e.Classpermissionid).HasColumnName("CLASSPERMISSIONID");
            entity.Property(e => e.Classpermissionuserdata)
                .HasMaxLength(4000)
                .HasColumnName("CLASSPERMISSIONUSERDATA");
            entity.Property(e => e.Docclassid).HasColumnName("DOCCLASSID");
            entity.Property(e => e.Permissiondata)
                .HasMaxLength(4000)
                .HasColumnName("PERMISSIONDATA");
            entity.Property(e => e.Permissionvalue).HasColumnName("PERMISSIONVALUE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Tasktypeid)
                .HasMaxLength(512)
                .HasColumnName("TASKTYPEID");
            entity.Property(e => e.Tasktypename)
                .HasMaxLength(512)
                .HasColumnName("TASKTYPENAME");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<XecmpfAppintgnDpermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPF_APPINTGN_DPERMISSIONS");

            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Permkey)
                .HasMaxLength(512)
                .HasColumnName("PERMKEY");
            entity.Property(e => e.Permsmask).HasColumnName("PERMSMASK");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<XecmpfAppintgnStructuredtemplatesconfig>(entity =>
        {
            entity.HasKey(e => new { e.Structuredwftemplateid, e.Templatedataid });
            entity.ToTable("XECMPF_APPINTGN_STRUCTUREDTEMPLATESCONFIG");

            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate).HasColumnName("CREATEDDATE");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Structuredwftemplateid)
                .HasMaxLength(255)
                .HasColumnName("STRUCTUREDWFTEMPLATEID");
            entity.Property(e => e.Swfuserdata)
                .HasMaxLength(4000)
                .HasColumnName("SWFUSERDATA");
            entity.Property(e => e.Templatedataid).HasColumnName("TEMPLATEDATAID");
        });

        modelBuilder.Entity<XecmpfAppintgnTaskActInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPF_APPINTGN_TASK_ACT_INFO");

            entity.Property(e => e.Activityinstanceid).HasColumnName("ACTIVITYINSTANCEID");
            entity.Property(e => e.Activitytaskevent)
                .HasMaxLength(512)
                .HasColumnName("ACTIVITYTASKEVENT");
            entity.Property(e => e.Eventmessage)
                .HasMaxLength(1024)
                .HasColumnName("EVENTMESSAGE");
            entity.Property(e => e.Performedby).HasColumnName("PERFORMEDBY");
            entity.Property(e => e.Performeddate).HasColumnName("PERFORMEDDATE");
            entity.Property(e => e.Taskeventuserdata)
                .HasColumnType("NCLOB")
                .HasColumnName("TASKEVENTUSERDATA");
            entity.Property(e => e.Taskid).HasColumnName("TASKID");
        });

        modelBuilder.Entity<XecmpfMultilingualCfg>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Namespace, e.LangCode });
            entity.ToTable("XECMPF_MULTILINGUAL_CFG");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.LangCode)
                .HasMaxLength(255)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.LangValue)
                .HasMaxLength(512)
                .HasColumnName("LANG_VALUE");
            entity.Property(e => e.Namespace)
                .HasMaxLength(255)
                .HasColumnName("NAMESPACE");
        });

        modelBuilder.Entity<XecmpfPdAttrdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPF_PD_ATTRDATA");

            entity.Property(e => e.Attrid)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRID");
            entity.Property(e => e.Attrname)
                .HasMaxLength(255)
                .HasColumnName("ATTRNAME");
            entity.Property(e => e.Attrrow).HasColumnName("ATTRROW");
            entity.Property(e => e.Attrtype)
                .HasColumnType("INTEGER")
                .HasColumnName("ATTRTYPE");
            entity.Property(e => e.Boid)
                .HasMaxLength(255)
                .HasColumnName("BOID");
            entity.Property(e => e.Boname)
                .HasMaxLength(255)
                .HasColumnName("BONAME");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Defid).HasColumnName("DEFID");
            entity.Property(e => e.Defname)
                .HasMaxLength(255)
                .HasColumnName("DEFNAME");
            entity.Property(e => e.Defvern).HasColumnName("DEFVERN");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Propid)
                .HasMaxLength(255)
                .HasColumnName("PROPID");
            entity.Property(e => e.Propname)
                .HasMaxLength(255)
                .HasColumnName("PROPNAME");
            entity.Property(e => e.Setid)
                .HasColumnType("INTEGER")
                .HasColumnName("SETID");
            entity.Property(e => e.Setname)
                .HasMaxLength(255)
                .HasColumnName("SETNAME");
            entity.Property(e => e.Setrow).HasColumnName("SETROW");
            entity.Property(e => e.Status)
                .HasColumnType("INTEGER")
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<XecmpfPulseLink>(entity =>
        {
            entity.HasKey(e => e.NodeId);
            entity.ToTable("XECMPF_PULSE_LINKS");

            entity.Property(e => e.ExtsystemFeedId)
                .HasMaxLength(128)
                .HasColumnName("EXTSYSTEM_FEED_ID");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.RootNodeId).HasColumnName("ROOT_NODE_ID");
        });

        modelBuilder.Entity<XecmpfPulseMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPF_PULSE_METADATA");

            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.Metadata)
                .HasColumnType("NCLOB")
                .HasColumnName("METADATA");
            entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.RootNodeId).HasColumnName("ROOT_NODE_ID");
        });

        modelBuilder.Entity<XecmpfPulseRawMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPF_PULSE_RAW_METADATA");

            entity.Property(e => e.Action)
                .HasMaxLength(32)
                .HasColumnName("ACTION");
            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.IdExtsystem)
                .HasMaxLength(32)
                .HasColumnName("ID_EXTSYSTEM");
            entity.Property(e => e.LsCommentOnObjectId)
                .HasMaxLength(32)
                .HasColumnName("LS_COMMENT_ON_OBJECT_ID");
            entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.RootNodeId).HasColumnName("ROOT_NODE_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(64)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<XecmpfbulkJobDefinition>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XECMPFBULK_JOB_DEFINITIONS");

            entity.Property(e => e.AgentId)
                .HasMaxLength(32)
                .HasColumnName("AGENT_ID");
            entity.Property(e => e.BusObjType)
                .HasMaxLength(32)
                .HasColumnName("BUS_OBJ_TYPE");
            entity.Property(e => e.Command).HasColumnName("COMMAND");
            entity.Property(e => e.ConfigData)
                .HasColumnType("NCLOB")
                .HasColumnName("CONFIG_DATA");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.ExtSysId)
                .HasMaxLength(32)
                .HasColumnName("EXT_SYS_ID");
            entity.Property(e => e.JobStatus)
                .HasColumnType("NCLOB")
                .HasColumnName("JOB_STATUS");
            entity.Property(e => e.JobType)
                .HasMaxLength(128)
                .HasColumnName("JOB_TYPE");
            entity.Property(e => e.ScheduleConfig)
                .HasColumnType("NCLOB")
                .HasColumnName("SCHEDULE_CONFIG");
            entity.Property(e => e.ScheduleNextTime).HasColumnName("SCHEDULE_NEXT_TIME");
        });

        modelBuilder.Entity<XecmpfbulkJobHistory>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Run });
            entity.ToTable("XECMPFBULK_JOB_HISTORY");

            entity.Property(e => e.CustomColumnValues)
                .HasColumnType("NCLOB")
                .HasColumnName("CUSTOM_COLUMN_VALUES");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.DurationExtractors).HasColumnName("DURATION_EXTRACTORS");
            entity.Property(e => e.ErrorItems).HasColumnName("ERROR_ITEMS");
            entity.Property(e => e.FinishedDate).HasColumnName("FINISHED_DATE");
            entity.Property(e => e.ProcessedItems).HasColumnName("PROCESSED_ITEMS");
            entity.Property(e => e.ResultCode).HasColumnName("RESULT_CODE");
            entity.Property(e => e.ResultErrItems)
                .HasColumnType("NCLOB")
                .HasColumnName("RESULT_ERR_ITEMS");
            entity.Property(e => e.ResultErrMsg)
                .HasColumnType("NCLOB")
                .HasColumnName("RESULT_ERR_MSG");
            entity.Property(e => e.Run).HasColumnName("RUN");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
        });

        modelBuilder.Entity<XecmpfbulkSubTask>(entity =>
        {
            entity.HasKey(e => new { e.JobDataid, e.StatusCode, e.SubtaskId });
            entity.ToTable("XECMPFBULK_SUB_TASKS");

            entity.Property(e => e.ErrMsg)
                .HasColumnType("NCLOB")
                .HasColumnName("ERR_MSG");
            entity.Property(e => e.Extractors).HasColumnName("EXTRACTORS");
            entity.Property(e => e.Items).HasColumnName("ITEMS");
            entity.Property(e => e.JobDataid).HasColumnName("JOB_DATAID");
            entity.Property(e => e.Run).HasColumnName("RUN");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(32)
                .HasColumnName("STATUS_CODE");
            entity.Property(e => e.Step).HasColumnName("STEP");
            entity.Property(e => e.SubtaskData)
                .HasColumnType("NCLOB")
                .HasColumnName("SUBTASK_DATA");
            entity.Property(e => e.SubtaskId).HasColumnName("SUBTASK_ID");
        });

        modelBuilder.Entity<XecmpfccDocvalRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPFCC_DOCVAL_ROLES");

            entity.Property(e => e.Cdataid).HasColumnName("CDATAID");
            entity.Property(e => e.Location)
                .HasMaxLength(1024)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Reviewwfmaprole)
                .HasMaxLength(1024)
                .HasColumnName("REVIEWWFMAPROLE");
            entity.Property(e => e.Role)
                .HasMaxLength(1024)
                .HasColumnName("ROLE");
            entity.Property(e => e.RoleType)
                .HasMaxLength(128)
                .HasColumnName("ROLE_TYPE");
            entity.Property(e => e.Roleid).HasColumnName("ROLEID");
            entity.Property(e => e.Ruleid).HasColumnName("RULEID");
            entity.Property(e => e.Tdataid).HasColumnName("TDATAID");
        });

        modelBuilder.Entity<XecmpfccDocvalRolesBkup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPFCC_DOCVAL_ROLES_BKUP");

            entity.Property(e => e.Cdataid).HasColumnName("CDATAID");
            entity.Property(e => e.Location)
                .HasMaxLength(1024)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Role)
                .HasMaxLength(1024)
                .HasColumnName("ROLE");
            entity.Property(e => e.Tdataid).HasColumnName("TDATAID");
        });

        modelBuilder.Entity<XecmpfccDocvalRule>(entity =>
        {
            entity.HasKey(e => new { e.Sdataid, e.Tdataid, e.Cdataid, e.Location });
            entity.ToTable("XECMPFCC_DOCVAL_RULES");

            entity.Property(e => e.BasedOnAttrId).HasColumnName("BASED_ON_ATTR_ID");
            entity.Property(e => e.BasedOnCatId).HasColumnName("BASED_ON_CAT_ID");
            entity.Property(e => e.Cdataid).HasColumnName("CDATAID");
            entity.Property(e => e.Docgen).HasColumnName("DOCGEN");
            entity.Property(e => e.Extendeddata)
                .HasColumnType("NCLOB")
                .HasColumnName("EXTENDEDDATA");
            entity.Property(e => e.Location)
                .HasMaxLength(1024)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("1")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Required).HasColumnName("REQUIRED");
            entity.Property(e => e.ReviewRequired).HasColumnName("REVIEW_REQUIRED");
            entity.Property(e => e.Roles)
                .HasMaxLength(1024)
                .HasColumnName("ROLES");
            entity.Property(e => e.Rstype).HasColumnName("RSTYPE");
            entity.Property(e => e.Ruledata)
                .HasColumnType("NCLOB")
                .HasColumnName("RULEDATA");
            entity.Property(e => e.Ruleexp)
                .HasColumnType("NCLOB")
                .HasColumnName("RULEEXP");
            entity.Property(e => e.Ruleid).HasColumnName("RULEID");
            entity.Property(e => e.Sdataid).HasColumnName("SDATAID");
            entity.Property(e => e.Tdataid).HasColumnName("TDATAID");
            entity.Property(e => e.Uploadreviewrequired).HasColumnName("UPLOADREVIEWREQUIRED");
            entity.Property(e => e.Uploadreviewwfmapid).HasColumnName("UPLOADREVIEWWFMAPID");
            entity.Property(e => e.Validity).HasColumnName("VALIDITY");
            entity.Property(e => e.ValidityRequired).HasColumnName("VALIDITY_REQUIRED");
        });

        modelBuilder.Entity<Xecmpfccreviewticket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPFCCREVIEWTICKETS");

            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Createdate).HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Docid).HasColumnName("DOCID");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifydate).HasColumnName("MODIFYDATE");
            entity.Property(e => e.Ticketid).HasColumnName("TICKETID");
            entity.Property(e => e.Ticketstatus).HasColumnName("TICKETSTATUS");
            entity.Property(e => e.Workflowid).HasColumnName("WORKFLOWID");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<Xecmpfcompletenessinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPFCOMPLETENESSINFO");

            entity.Property(e => e.Attrid).HasColumnName("ATTRID");
            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Docid).HasColumnName("DOCID");
            entity.Property(e => e.Doclocation)
                .HasColumnType("NCLOB")
                .HasColumnName("DOCLOCATION");
            entity.Property(e => e.Doclocationws)
                .HasMaxLength(1024)
                .HasColumnName("DOCLOCATIONWS");
            entity.Property(e => e.Documenttypeid).HasColumnName("DOCUMENTTYPEID");
            entity.Property(e => e.Expiredate).HasColumnName("EXPIREDATE");
            entity.Property(e => e.Required).HasColumnName("REQUIRED");
            entity.Property(e => e.Role)
                .HasMaxLength(1024)
                .HasColumnName("ROLE");
            entity.Property(e => e.Status)
                .HasMaxLength(32)
                .HasColumnName("STATUS");
            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.Validity).HasColumnName("VALIDITY");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<Xecmpfcompletenessjobqueue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XECMPFCOMPLETENESSJOBQUEUE");

            entity.Property(e => e.Cat1change).HasColumnName("CAT1CHANGE");
            entity.Property(e => e.Cat1metadata)
                .HasColumnType("NCLOB")
                .HasColumnName("CAT1METADATA");
            entity.Property(e => e.Cat2change).HasColumnName("CAT2CHANGE");
            entity.Property(e => e.Cat2metadata)
                .HasColumnType("NCLOB")
                .HasColumnName("CAT2METADATA");
            entity.Property(e => e.Debouncetime).HasColumnName("DEBOUNCETIME");
            entity.Property(e => e.Lastprocessedtime).HasColumnName("LASTPROCESSEDTIME");
            entity.Property(e => e.Status)
                .HasMaxLength(32)
                .HasDefaultValueSql("NEW")
                .HasColumnName("STATUS");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<XecmpfeacActionAttrMap>(entity =>
        {
            entity.HasKey(e => new { e.CfgId, e.AamPosition });
            entity.ToTable("XECMPFEAC_ACTION_ATTR_MAP");

            entity.Property(e => e.AamPosition).HasColumnName("AAM_POSITION");
            entity.Property(e => e.ActionAttrId).HasColumnName("ACTION_ATTR_ID");
            entity.Property(e => e.CfgId).HasColumnName("CFG_ID");
            entity.Property(e => e.MappingAttrName)
                .HasMaxLength(512)
                .HasColumnName("MAPPING_ATTR_NAME");
            entity.Property(e => e.MappingData)
                .HasMaxLength(512)
                .HasColumnName("MAPPING_DATA");
            entity.Property(e => e.MappingMethod)
                .HasMaxLength(512)
                .HasColumnName("MAPPING_METHOD");
        });

        modelBuilder.Entity<XecmpfeacActionCfg>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.CfgPosition });
            entity.ToTable("XECMPFEAC_ACTION_CFG");

            entity.Property(e => e.ActionKey)
                .HasMaxLength(512)
                .HasColumnName("ACTION_KEY");
            entity.Property(e => e.CfgId).HasColumnName("CFG_ID");
            entity.Property(e => e.CfgPosition).HasColumnName("CFG_POSITION");
            entity.Property(e => e.DependsOn).HasColumnName("DEPENDS_ON");
            entity.Property(e => e.PlanId).HasColumnName("PLAN_ID");
        });

        modelBuilder.Entity<XecmpfeacEvent>(entity =>
        {
            entity.HasKey(e => e.EventId);
            entity.ToTable("XECMPFEAC_EVENT");

            entity.Property(e => e.EventData)
                .HasMaxLength(4000)
                .HasColumnName("EVENT_DATA");
            entity.Property(e => e.EventId).HasColumnName("EVENT_ID");
            entity.Property(e => e.EventPosition).HasColumnName("EVENT_POSITION");
            entity.Property(e => e.PlanId).HasColumnName("PLAN_ID");
        });

        modelBuilder.Entity<XecmpfeacEventdefProperty>(entity =>
        {
            entity.HasKey(e => new { e.PropertyName, e.EventDefinitionId });
            entity.ToTable("XECMPFEAC_EVENTDEF_PROPERTIES");

            entity.Property(e => e.EventDefinitionId).HasColumnName("EVENT_DEFINITION_ID");
            entity.Property(e => e.PropertyDatatype)
                .HasMaxLength(255)
                .HasColumnName("PROPERTY_DATATYPE");
            entity.Property(e => e.PropertyId).HasColumnName("PROPERTY_ID");
            entity.Property(e => e.PropertyKey)
                .HasMaxLength(255)
                .HasColumnName("PROPERTY_KEY");
            entity.Property(e => e.PropertyName)
                .HasMaxLength(255)
                .HasColumnName("PROPERTY_NAME");
            entity.Property(e => e.PropertyValuesList)
                .HasColumnType("NCLOB")
                .HasColumnName("PROPERTY_VALUES_LIST");
        });

        modelBuilder.Entity<XecmpfeacRule>(entity =>
        {
            entity.HasKey(e => new { e.EventNamespace, e.EventType, e.RuleId });
            entity.ToTable("XECMPFEAC_RULE");

            entity.Property(e => e.EventName)
                .HasMaxLength(512)
                .HasColumnName("EVENT_NAME");
            entity.Property(e => e.EventNamespace)
                .HasMaxLength(255)
                .HasColumnName("EVENT_NAMESPACE");
            entity.Property(e => e.EventType)
                .HasMaxLength(512)
                .HasColumnName("EVENT_TYPE");
            entity.Property(e => e.PlanId).HasColumnName("PLAN_ID");
            entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
        });

        modelBuilder.Entity<XecmpfeacRuleCnd>(entity =>
        {
            entity.HasKey(e => new { e.RuleId, e.CndPosition });
            entity.ToTable("XECMPFEAC_RULE_CND");

            entity.Property(e => e.CndLogicalConnective)
                .HasMaxLength(128)
                .HasColumnName("CND_LOGICAL_CONNECTIVE");
            entity.Property(e => e.CndOperand)
                .HasMaxLength(512)
                .HasColumnName("CND_OPERAND");
            entity.Property(e => e.CndOperation)
                .HasMaxLength(128)
                .HasColumnName("CND_OPERATION");
            entity.Property(e => e.CndPosition).HasColumnName("CND_POSITION");
            entity.Property(e => e.CndValue)
                .HasMaxLength(512)
                .HasColumnName("CND_VALUE");
            entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
        });

        modelBuilder.Entity<XecmpfeacSeqnr>(entity =>
        {
            entity.HasKey(e => e.Seqname);
            entity.ToTable("XECMPFEAC_SEQNR");

            entity.Property(e => e.Lastused).HasColumnName("LASTUSED");
            entity.Property(e => e.Seqname)
                .HasMaxLength(64)
                .HasColumnName("SEQNAME");
        });

        modelBuilder.Entity<XecmpfnaAttDecDefinition>(entity =>
        {
            entity.HasKey(e => e.IdDeclarationType);
            entity.ToTable("XECMPFNA_ATT_DEC_DEFINITIONS");

            entity.Property(e => e.AttributeList)
                .HasColumnType("NCLOB")
                .HasColumnName("ATTRIBUTE_LIST");
            entity.Property(e => e.BusinessProperties)
                .HasColumnType("NCLOB")
                .HasColumnName("BUSINESS_PROPERTIES");
            entity.Property(e => e.BusinessPropertyGrps)
                .HasColumnType("NCLOB")
                .HasColumnName("BUSINESS_PROPERTY_GRPS");
            entity.Property(e => e.Classification)
                .HasMaxLength(255)
                .HasColumnName("CLASSIFICATION");
            entity.Property(e => e.DeclarationNodeId).HasColumnName("DECLARATION_NODE_ID");
            entity.Property(e => e.Deleted)
                .HasColumnType("INTEGER")
                .HasColumnName("DELETED");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DocNames)
                .HasMaxLength(255)
                .HasColumnName("DOC_NAMES");
            entity.Property(e => e.DocPropertyProvider)
                .HasMaxLength(32)
                .HasColumnName("DOC_PROPERTY_PROVIDER");
            entity.Property(e => e.ExternalSystem)
                .HasMaxLength(255)
                .HasColumnName("EXTERNAL_SYSTEM");
            entity.Property(e => e.IdDeclarationType).HasColumnName("ID_DECLARATION_TYPE");
            entity.Property(e => e.MarkOfficial)
                .HasMaxLength(255)
                .HasColumnName("MARK_OFFICIAL");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("NAME");
            entity.Property(e => e.RecordDate)
                .HasMaxLength(255)
                .HasColumnName("RECORD_DATE");
            entity.Property(e => e.RmClassification)
                .HasMaxLength(255)
                .HasColumnName("RM_CLASSIFICATION");
            entity.Property(e => e.RootFolder)
                .HasColumnType("NCLOB")
                .HasColumnName("ROOT_FOLDER");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.StatusDate)
                .HasMaxLength(255)
                .HasColumnName("STATUS_DATE");
            entity.Property(e => e.SubFolder)
                .HasMaxLength(255)
                .HasColumnName("SUB_FOLDER");
        });

        modelBuilder.Entity<XecmpfnaDocument>(entity =>
        {
            entity.HasKey(e => new { e.DocumentId, e.BusinessObjectType, e.BusinessObjectId, e.ExternalSystemId });
            entity.ToTable("XECMPFNA_DOCUMENTS");

            entity.Property(e => e.BusinessObjectId)
                .HasMaxLength(128)
                .HasColumnName("BUSINESS_OBJECT_ID");
            entity.Property(e => e.BusinessObjectType)
                .HasMaxLength(32)
                .HasColumnName("BUSINESS_OBJECT_TYPE");
            entity.Property(e => e.CsNodeId).HasColumnName("CS_NODE_ID");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(128)
                .HasColumnName("DOCUMENT_ID");
            entity.Property(e => e.DocumentType)
                .HasMaxLength(128)
                .HasColumnName("DOCUMENT_TYPE");
            entity.Property(e => e.ExternalSystemId)
                .HasMaxLength(255)
                .HasColumnName("EXTERNAL_SYSTEM_ID");
        });

        modelBuilder.Entity<XecmpfnaSeqnr>(entity =>
        {
            entity.HasKey(e => e.Seqname);
            entity.ToTable("XECMPFNA_SEQNR");

            entity.Property(e => e.Lastused)
                .HasColumnType("INTEGER")
                .HasColumnName("LASTUSED");
            entity.Property(e => e.Seqname)
                .HasMaxLength(64)
                .HasColumnName("SEQNAME");
        });

        modelBuilder.Entity<XecmpfxoDelMessage>(entity =>
        {
            entity.HasKey(e => e.Messageid);
            entity.ToTable("XECMPFXO_DEL_MESSAGES");

            entity.Property(e => e.Applicationid)
                .HasMaxLength(255)
                .HasColumnName("APPLICATIONID");
            entity.Property(e => e.Archiveid)
                .HasMaxLength(255)
                .HasColumnName("ARCHIVEID");
            entity.Property(e => e.Busobjid)
                .HasMaxLength(255)
                .HasColumnName("BUSOBJID");
            entity.Property(e => e.Busobjtype)
                .HasMaxLength(255)
                .HasColumnName("BUSOBJTYPE");
            entity.Property(e => e.Docid)
                .HasMaxLength(255)
                .HasColumnName("DOCID");
            entity.Property(e => e.Messagedate).HasColumnName("MESSAGEDATE");
            entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
        });

        modelBuilder.Entity<XecmpfxoProvDatum>(entity =>
        {
            entity.HasKey(e => e.Providerid);
            entity.ToTable("XECMPFXO_PROV_DATA");

            entity.Property(e => e.Externalid)
                .HasMaxLength(255)
                .HasColumnName("EXTERNALID");
            entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");
        });

        modelBuilder.Entity<XecmpfxoRecord>(entity =>
        {
            entity.HasKey(e => e.Externalid);
            entity.ToTable("XECMPFXO_RECORDS");

            entity.Property(e => e.Applicationid)
                .HasMaxLength(255)
                .HasColumnName("APPLICATIONID");
            entity.Property(e => e.Busobjid)
                .HasMaxLength(255)
                .HasColumnName("BUSOBJID");
            entity.Property(e => e.Busobjtype)
                .HasMaxLength(255)
                .HasColumnName("BUSOBJTYPE");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Externalid)
                .HasMaxLength(255)
                .HasColumnName("EXTERNALID");
        });

        modelBuilder.Entity<XecmpfxoVersion>(entity =>
        {
            entity.HasKey(e => e.Externalid);
            entity.ToTable("XECMPFXO_VERSIONS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Externalid)
                .HasMaxLength(255)
                .HasColumnName("EXTERNALID");
            entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");
            entity.Property(e => e.Versionid).HasColumnName("VERSIONID");
        });

        modelBuilder.Entity<Xengadnid>(entity =>
        {
            entity.HasKey(e => new { e.Wholeid, e.Adntype });
            entity.ToTable("XENGADNIDS");

            entity.Property(e => e.Adnid).HasColumnName("ADNID");
            entity.Property(e => e.Adnidpattern)
                .HasMaxLength(255)
                .HasColumnName("ADNIDPATTERN");
            entity.Property(e => e.Adntype).HasColumnName("ADNTYPE");
            entity.Property(e => e.Assignedby).HasColumnName("ASSIGNEDBY");
            entity.Property(e => e.Requestedby).HasColumnName("REQUESTEDBY");
            entity.Property(e => e.Seqid)
                .HasMaxLength(64)
                .HasColumnName("SEQID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Wholeid)
                .HasMaxLength(255)
                .HasColumnName("WHOLEID");
        });

        modelBuilder.Entity<Xengadnidstartseq>(entity =>
        {
            entity.HasKey(e => new { e.Documenttype, e.Adnidpattern });
            entity.ToTable("XENGADNIDSTARTSEQ");

            entity.Property(e => e.Adnidpattern)
                .HasMaxLength(255)
                .HasColumnName("ADNIDPATTERN");
            entity.Property(e => e.Documenttype).HasColumnName("DOCUMENTTYPE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InitialSeq).HasColumnName("INITIAL_SEQ");
        });

        modelBuilder.Entity<Xengadnref>(entity =>
        {
            entity.HasKey(e => new { e.Adnid, e.Dataid, e.Version });
            entity.ToTable("XENGADNREFS");

            entity.Property(e => e.Adnid).HasColumnName("ADNID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.NodeName)
                .HasMaxLength(255)
                .HasColumnName("NODE_NAME");
            entity.Property(e => e.Version)
                .HasDefaultValueSql("0")
                .HasColumnName("VERSION");
            entity.Property(e => e.VersionName)
                .HasMaxLength(255)
                .HasColumnName("VERSION_NAME");
        });

        modelBuilder.Entity<XengcadAttribute>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("XENGCAD_ATTRIBUTE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Nodeid).HasColumnName("NODEID");
            entity.Property(e => e.Orderprev).HasColumnName("ORDERPREV");
            entity.Property(e => e.Setid).HasColumnName("SETID");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<XengcadRegionAttribute>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("XENGCAD_REGION_ATTRIBUTE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LayoutFilter)
                .HasMaxLength(4000)
                .HasColumnName("LAYOUT_FILTER");
            entity.Property(e => e.ResolutionData)
                .HasMaxLength(4000)
                .HasColumnName("RESOLUTION_DATA");
            entity.Property(e => e.ResolutionType).HasColumnName("RESOLUTION_TYPE");
            entity.Property(e => e.Rtype).HasColumnName("RTYPE");
            entity.Property(e => e.Rtypedef)
                .HasMaxLength(4000)
                .HasColumnName("RTYPEDEF");
            entity.Property(e => e.TextFilter)
                .HasMaxLength(4000)
                .HasColumnName("TEXT_FILTER");
        });

        modelBuilder.Entity<XengcadRelation>(entity =>
        {
            entity.HasKey(e => new { e.Sourcedataid, e.Sourcedocversion, e.Relateddataid, e.Relateddocversion });
            entity.ToTable("XENGCAD_RELATIONS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Relateddataid).HasColumnName("RELATEDDATAID");
            entity.Property(e => e.Relateddocversion).HasColumnName("RELATEDDOCVERSION");
            entity.Property(e => e.RelationshipId).HasColumnName("RELATIONSHIP_ID");
            entity.Property(e => e.Sourcedataid).HasColumnName("SOURCEDATAID");
            entity.Property(e => e.Sourcedocversion).HasColumnName("SOURCEDOCVERSION");
        });

        modelBuilder.Entity<XengcadRelationshipType>(entity =>
        {
            entity.HasKey(e => e.RelationshipName);
            entity.ToTable("XENGCAD_RELATIONSHIP_TYPES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RelationshipName)
                .HasMaxLength(255)
                .HasColumnName("RELATIONSHIP_NAME");
            entity.Property(e => e.RelationshipType).HasColumnName("RELATIONSHIP_TYPE");
        });

        modelBuilder.Entity<XengcadStructuredAttribute>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("XENGCAD_STRUCTURED_ATTRIBUTE");

            entity.Property(e => e.GroupName)
                .HasMaxLength(512)
                .HasColumnName("GROUP_NAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SheetName)
                .HasMaxLength(512)
                .HasColumnName("SHEET_NAME");
            entity.Property(e => e.Tag)
                .HasMaxLength(512)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<XengcrtArchivedRevision>(entity =>
        {
            entity.HasKey(e => e.RevisionId);
            entity.ToTable("XENGCRT_ARCHIVED_REVISIONS");

            entity.Property(e => e.ApprovedDate).HasColumnName("APPROVED_DATE");
            entity.Property(e => e.ApprovedUser).HasColumnName("APPROVED_USER");
            entity.Property(e => e.Delimeter)
                .HasMaxLength(32)
                .HasColumnName("DELIMETER");
            entity.Property(e => e.DrawingId).HasColumnName("DRAWING_ID");
            entity.Property(e => e.IsParticipant).HasColumnName("IS_PARTICIPANT");
            entity.Property(e => e.MajorRevision)
                .HasMaxLength(32)
                .HasColumnName("MAJOR_REVISION");
            entity.Property(e => e.MinorRevision)
                .HasMaxLength(32)
                .HasColumnName("MINOR_REVISION");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.ProcessType)
                .HasColumnType("INTEGER")
                .HasColumnName("PROCESS_TYPE");
            entity.Property(e => e.ProjectRevision)
                .HasMaxLength(32)
                .HasColumnName("PROJECT_REVISION");
            entity.Property(e => e.ProjectWkspId).HasColumnName("PROJECT_WKSP_ID");
            entity.Property(e => e.RequestedDate).HasColumnName("REQUESTED_DATE");
            entity.Property(e => e.RequestedUser).HasColumnName("REQUESTED_USER");
            entity.Property(e => e.RevIndicator).HasColumnName("REV_INDICATOR");
            entity.Property(e => e.RevSchemeId).HasColumnName("REV_SCHEME_ID");
            entity.Property(e => e.RevStatusId).HasColumnName("REV_STATUS_ID");
            entity.Property(e => e.RevisionId).HasColumnName("REVISION_ID");
            entity.Property(e => e.RevisionNumber).HasColumnName("REVISION_NUMBER");
            entity.Property(e => e.RevsionNotes)
                .HasMaxLength(255)
                .HasColumnName("REVSION_NOTES");
            entity.Property(e => e.SourceRevisionId).HasColumnName("SOURCE_REVISION_ID");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<XengcrtProjectWorkspace>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGCRT_PROJECT_WORKSPACES");

            entity.Property(e => e.WorkspaceId).HasColumnName("WORKSPACE_ID");
            entity.Property(e => e.WorkspaceTemplateId).HasColumnName("WORKSPACE_TEMPLATE_ID");
        });

        modelBuilder.Entity<XengcrtRevCtrlDoctype>(entity =>
        {
            entity.HasKey(e => new { e.RevisionCtrlNode, e.DocumentTypeId });
            entity.ToTable("XENGCRT_REV_CTRL_DOCTYPES");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DOCUMENT_TYPE_ID");
            entity.Property(e => e.RevisionCtrlNode).HasColumnName("REVISION_CTRL_NODE");
        });

        modelBuilder.Entity<XengcrtRevCtrlSetting>(entity =>
        {
            entity.HasKey(e => e.RevisionCtrlNode);
            entity.ToTable("XENGCRT_REV_CTRL_SETTING");

            entity.Property(e => e.AllowActiveDocs).HasColumnName("ALLOW_ACTIVE_DOCS");
            entity.Property(e => e.AllowConcurrentRevision).HasColumnName("ALLOW_CONCURRENT_REVISION");
            entity.Property(e => e.DisplayCustomColumns).HasColumnName("DISPLAY_CUSTOM_COLUMNS");
            entity.Property(e => e.OtherRevSchemeId).HasColumnName("OTHER_REV_SCHEME_ID");
            entity.Property(e => e.RevisionCtrlNode).HasColumnName("REVISION_CTRL_NODE");
            entity.Property(e => e.SigninRevSchemeId).HasColumnName("SIGNIN_REV_SCHEME_ID");
        });

        modelBuilder.Entity<XengcrtRevCtrlWfMapping>(entity =>
        {
            entity.HasKey(e => new { e.RevisionCtrlNode, e.Action });
            entity.ToTable("XENGCRT_REV_CTRL_WF_MAPPING");

            entity.Property(e => e.Action).HasColumnName("ACTION");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.RevisionCtrlNode).HasColumnName("REVISION_CTRL_NODE");
        });

        modelBuilder.Entity<XengcrtRevCtrlWorkspace>(entity =>
        {
            entity.HasKey(e => new { e.RevisionCtrlNode, e.WorkspaceTemplateId, e.WorkspaceId });
            entity.ToTable("XENGCRT_REV_CTRL_WORKSPACES");

            entity.Property(e => e.RevisionCtrlNode).HasColumnName("REVISION_CTRL_NODE");
            entity.Property(e => e.WorkspaceId).HasColumnName("WORKSPACE_ID");
            entity.Property(e => e.WorkspaceTemplateId).HasColumnName("WORKSPACE_TEMPLATE_ID");
        });

        modelBuilder.Entity<XengcrtRevision>(entity =>
        {
            entity.HasKey(e => e.RevisionId);
            entity.ToTable("XENGCRT_REVISIONS");

            entity.Property(e => e.ApprovedDate).HasColumnName("APPROVED_DATE");
            entity.Property(e => e.ApprovedUser).HasColumnName("APPROVED_USER");
            entity.Property(e => e.Delimeter)
                .HasMaxLength(32)
                .HasColumnName("DELIMETER");
            entity.Property(e => e.DrawingId).HasColumnName("DRAWING_ID");
            entity.Property(e => e.IsParticipant).HasColumnName("IS_PARTICIPANT");
            entity.Property(e => e.MajorRevision)
                .HasMaxLength(32)
                .HasColumnName("MAJOR_REVISION");
            entity.Property(e => e.MinorRevision)
                .HasMaxLength(32)
                .HasColumnName("MINOR_REVISION");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.ProcessType)
                .HasColumnType("INTEGER")
                .HasColumnName("PROCESS_TYPE");
            entity.Property(e => e.ProjectRevision)
                .HasMaxLength(32)
                .HasColumnName("PROJECT_REVISION");
            entity.Property(e => e.ProjectWkspId).HasColumnName("PROJECT_WKSP_ID");
            entity.Property(e => e.RequestedDate).HasColumnName("REQUESTED_DATE");
            entity.Property(e => e.RequestedUser).HasColumnName("REQUESTED_USER");
            entity.Property(e => e.RevIndicator).HasColumnName("REV_INDICATOR");
            entity.Property(e => e.RevSchemeId).HasColumnName("REV_SCHEME_ID");
            entity.Property(e => e.RevStatusId).HasColumnName("REV_STATUS_ID");
            entity.Property(e => e.RevisionId).HasColumnName("REVISION_ID");
            entity.Property(e => e.RevisionNumber).HasColumnName("REVISION_NUMBER");
            entity.Property(e => e.RevsionNotes)
                .HasMaxLength(255)
                .HasColumnName("REVSION_NOTES");
            entity.Property(e => e.SourceRevisionId).HasColumnName("SOURCE_REVISION_ID");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<XengcrtRevisionScheme>(entity =>
        {
            entity.HasKey(e => e.RevSchemeId);
            entity.ToTable("XENGCRT_REVISION_SCHEMES");

            entity.Property(e => e.Delimeter)
                .HasMaxLength(32)
                .HasColumnName("DELIMETER");
            entity.Property(e => e.MajorAlphaRevValues)
                .HasMaxLength(4000)
                .HasColumnName("MAJOR_ALPHA_REV_VALUES");
            entity.Property(e => e.MajorDisplayFormat)
                .HasMaxLength(64)
                .HasColumnName("MAJOR_DISPLAY_FORMAT");
            entity.Property(e => e.MajorInitialNumericRev).HasColumnName("MAJOR_INITIAL_NUMERIC_REV");
            entity.Property(e => e.MajorRevSchemeType).HasColumnName("MAJOR_REV_SCHEME_TYPE");
            entity.Property(e => e.MajorRevisionLabel)
                .HasMaxLength(32)
                .HasColumnName("MAJOR_REVISION_LABEL");
            entity.Property(e => e.MinorAlphaRevValues)
                .HasMaxLength(4000)
                .HasColumnName("MINOR_ALPHA_REV_VALUES");
            entity.Property(e => e.MinorDisplayFormat)
                .HasMaxLength(64)
                .HasColumnName("MINOR_DISPLAY_FORMAT");
            entity.Property(e => e.MinorInitialNumericRev).HasColumnName("MINOR_INITIAL_NUMERIC_REV");
            entity.Property(e => e.MinorRevSchemeType).HasColumnName("MINOR_REV_SCHEME_TYPE");
            entity.Property(e => e.ProjectAlphaRevValues)
                .HasMaxLength(4000)
                .HasColumnName("PROJECT_ALPHA_REV_VALUES");
            entity.Property(e => e.ProjectRevSchemeType).HasColumnName("PROJECT_REV_SCHEME_TYPE");
            entity.Property(e => e.RevSchemeId).HasColumnName("REV_SCHEME_ID");
            entity.Property(e => e.RevSchemeType).HasColumnName("REV_SCHEME_TYPE");
        });

        modelBuilder.Entity<XengcrtRevisionStatus>(entity =>
        {
            entity.HasKey(e => e.RevStatusId);
            entity.ToTable("XENGCRT_REVISION_STATUS");

            entity.Property(e => e.CanSignIn).HasColumnName("CAN_SIGN_IN");
            entity.Property(e => e.CanSignOut).HasColumnName("CAN_SIGN_OUT");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsDisabled).HasColumnName("IS_DISABLED");
            entity.Property(e => e.RevStatusId).HasColumnName("REV_STATUS_ID");
            entity.Property(e => e.RevStatusName)
                .HasMaxLength(64)
                .HasColumnName("REV_STATUS_NAME");
            entity.Property(e => e.RevStatusOrder).HasColumnName("REV_STATUS_ORDER");
            entity.Property(e => e.RevisionCtrlNode).HasColumnName("REVISION_CTRL_NODE");
            entity.Property(e => e.SuccessorRevStatus)
                .HasMaxLength(4000)
                .HasColumnName("SUCCESSOR_REV_STATUS");
        });

        modelBuilder.Entity<XengseDeliverable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGSE_DELIVERABLES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SeDeliverableDocName)
                .HasMaxLength(255)
                .HasColumnName("SE_DELIVERABLE_DOC_NAME");
            entity.Property(e => e.SeDeliverableDocVersion)
                .HasMaxLength(255)
                .HasColumnName("SE_DELIVERABLE_DOC_VERSION");
            entity.Property(e => e.SeDeliverableId)
                .HasMaxLength(255)
                .HasColumnName("SE_DELIVERABLE_ID");
            entity.Property(e => e.SeDeliverableListId)
                .HasMaxLength(255)
                .HasColumnName("SE_DELIVERABLE_LIST_ID");
            entity.Property(e => e.SeDeliverableStatus)
                .HasMaxLength(32)
                .HasColumnName("SE_DELIVERABLE_STATUS");
        });

        modelBuilder.Entity<XengseWkspEntityMapping>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XENGSE_WKSP_ENTITY_MAPPING");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.SeContractId)
                .HasMaxLength(255)
                .HasColumnName("SE_CONTRACT_ID");
            entity.Property(e => e.SeDeliverableListId)
                .HasMaxLength(255)
                .HasColumnName("SE_DELIVERABLE_LIST_ID");
            entity.Property(e => e.SeProjectId)
                .HasMaxLength(255)
                .HasColumnName("SE_PROJECT_ID");
            entity.Property(e => e.SeTransmittalId)
                .HasMaxLength(255)
                .HasColumnName("SE_TRANSMITTAL_ID");
        });

        modelBuilder.Entity<XengseWorkspace>(entity =>
        {
            entity.HasKey(e => new { e.SeProjectId, e.Workspaceid });
            entity.ToTable("XENGSE_WORKSPACES");

            entity.Property(e => e.SeProjectId)
                .HasMaxLength(255)
                .HasColumnName("SE_PROJECT_ID");
            entity.Property(e => e.SeProjectName)
                .HasMaxLength(255)
                .HasColumnName("SE_PROJECT_NAME");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<Xengseinstancemap>(entity =>
        {
            entity.HasKey(e => e.Workspaceid);
            entity.ToTable("XENGSEINSTANCEMAP");

            entity.Property(e => e.Contractname)
                .HasMaxLength(255)
                .HasColumnName("CONTRACTNAME");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Mappingid).HasColumnName("MAPPINGID");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<Xengsemapping>(entity =>
        {
            entity.HasKey(e => e.Mappingid);
            entity.ToTable("XENGSEMAPPING");

            entity.Property(e => e.Contract)
                .HasMaxLength(255)
                .HasColumnName("CONTRACT");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Mappingid).HasColumnName("MAPPINGID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Workspacetemplate).HasColumnName("WORKSPACETEMPLATE");
        });

        modelBuilder.Entity<Xengserecipientmap>(entity =>
        {
            entity.HasKey(e => new { e.Mappingid, e.Recipientid, e.Recipienttype });
            entity.ToTable("XENGSERECIPIENTMAP");

            entity.Property(e => e.Mappingid).HasColumnName("MAPPINGID");
            entity.Property(e => e.Permission).HasColumnName("PERMISSION");
            entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");
            entity.Property(e => e.Recipienttype).HasColumnName("RECIPIENTTYPE");
        });

        modelBuilder.Entity<Xengsesharemap>(entity =>
        {
            entity.HasKey(e => new { e.Mappingid, e.Shareitemid, e.Shareitemtype });
            entity.ToTable("XENGSESHAREMAP");

            entity.Property(e => e.Mappingid).HasColumnName("MAPPINGID");
            entity.Property(e => e.Shareitemid).HasColumnName("SHAREITEMID");
            entity.Property(e => e.Shareitemtype).HasColumnName("SHAREITEMTYPE");
        });

        modelBuilder.Entity<Xengsesynctrigger>(entity =>
        {
            entity.HasKey(e => new { e.Mappingid, e.Triggertype });
            entity.ToTable("XENGSESYNCTRIGGERS");

            entity.Property(e => e.Mappingid).HasColumnName("MAPPINGID");
            entity.Property(e => e.Triggerdataid).HasColumnName("TRIGGERDATAID");
            entity.Property(e => e.Triggerevent).HasColumnName("TRIGGEREVENT");
            entity.Property(e => e.Triggertype).HasColumnName("TRIGGERTYPE");
        });

        modelBuilder.Entity<XengsfmCatattrPerformer>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.AttributeId });
            entity.ToTable("XENGSFM_CATATTR_PERFORMER");

            entity.Property(e => e.AttributeId).HasColumnName("ATTRIBUTE_ID");
            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<XengsfmDdmRoleMap>(entity =>
        {
            entity.HasKey(e => new { e.Dataid, e.Name });
            entity.ToTable("XENGSFM_DDM_ROLE_MAPS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<XengsfmDocumentDistMatrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGSFM_DOCUMENT_DIST_MATRIX");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.WorkspaceId).HasColumnName("WORKSPACE_ID");
        });

        modelBuilder.Entity<XengsfmPerformer>(entity =>
        {
            entity.HasKey(e => new { e.NodeId, e.PerformerId });
            entity.ToTable("XENGSFM_PERFORMERS");

            entity.Property(e => e.Assign).HasColumnName("ASSIGN");
            entity.Property(e => e.ClaimedFrom)
                .HasMaxLength(4000)
                .HasColumnName("CLAIMED_FROM");
            entity.Property(e => e.ExtendedPerms)
                .HasMaxLength(4000)
                .HasColumnName("EXTENDED_PERMS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsApproved).HasColumnName("IS_APPROVED");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.Override).HasColumnName("OVERRIDE");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.Transition).HasColumnName("TRANSITION");
            entity.Property(e => e.TransitionId).HasColumnName("TRANSITION_ID");
            entity.Property(e => e.Watch).HasColumnName("WATCH");
        });

        modelBuilder.Entity<XengsfmPermission>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("XENGSFM_PERMISSIONS");

            entity.Property(e => e.Assign)
                .HasDefaultValueSql("0")
                .HasColumnName("ASSIGN");
            entity.Property(e => e.ExtendedPerms)
                .HasMaxLength(4000)
                .HasColumnName("EXTENDED_PERMS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NodePermMask).HasColumnName("NODE_PERM_MASK");
            entity.Property(e => e.Override)
                .HasDefaultValueSql("0")
                .HasColumnName("OVERRIDE");
            entity.Property(e => e.PerformerId).HasColumnName("PERFORMER_ID");
            entity.Property(e => e.PerformerType).HasColumnName("PERFORMER_TYPE");
            entity.Property(e => e.StateId).HasColumnName("STATE_ID");
            entity.Property(e => e.Transition)
                .HasDefaultValueSql("0")
                .HasColumnName("TRANSITION");
            entity.Property(e => e.Watch)
                .HasDefaultValueSql("0")
                .HasColumnName("WATCH");
        });

        modelBuilder.Entity<XengsfmRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.RolemapId, e.DocumentTypeId, e.WorkspaceRoleId });
            entity.ToTable("XENGSFM_ROLE_MAPPINGS");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DOCUMENT_TYPE_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RolemapId).HasColumnName("ROLEMAP_ID");
            entity.Property(e => e.WorkspaceRoleId).HasColumnName("WORKSPACE_ROLE_ID");
        });

        modelBuilder.Entity<XengsfmState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGSFM_STATES");

            entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InheritPermission)
                .HasDefaultValueSql("0")
                .HasColumnName("INHERIT_PERMISSION");
            entity.Property(e => e.MinPerformersCount).HasColumnName("MIN_PERFORMERS_COUNT");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("NAME");
            entity.Property(e => e.StateEnterWr)
                .HasMaxLength(255)
                .HasColumnName("STATE_ENTER_WR");
            entity.Property(e => e.StateExitWr)
                .HasMaxLength(255)
                .HasColumnName("STATE_EXIT_WR");
            entity.Property(e => e.StateOrder).HasColumnName("STATE_ORDER");
            entity.Property(e => e.StateflowId).HasColumnName("STATEFLOW_ID");
            entity.Property(e => e.TurnAroundDays).HasColumnName("TURN_AROUND_DAYS");
        });

        modelBuilder.Entity<XengsfmStateFlow>(entity =>
        {
            entity.HasKey(e => e.NodeId);
            entity.ToTable("XENGSFM_STATE_FLOW");

            entity.Property(e => e.AssociatedDate).HasColumnName("ASSOCIATED_DATE");
            entity.Property(e => e.ForecastDate).HasColumnName("FORECAST_DATE");
            entity.Property(e => e.NextTransition).HasColumnName("NEXT_TRANSITION");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.PlannedEndDate).HasColumnName("PLANNED_END_DATE");
            entity.Property(e => e.StateFlowId).HasColumnName("STATE_FLOW_ID");
            entity.Property(e => e.StateId).HasColumnName("STATE_ID");
        });

        modelBuilder.Entity<XengsfmStateFlowAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGSFM_STATE_FLOW_AUDIT");

            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.EventDate).HasColumnName("EVENT_DATE");
            entity.Property(e => e.EventDetail).HasColumnName("EVENT_DETAIL");
            entity.Property(e => e.EventId).HasColumnName("EVENT_ID");
            entity.Property(e => e.EventType).HasColumnName("EVENT_TYPE");
            entity.Property(e => e.EventUser).HasColumnName("EVENT_USER");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.PerformedOnbehalfof)
                .HasMaxLength(4000)
                .HasColumnName("PERFORMED_ONBEHALFOF");
            entity.Property(e => e.StateFlowId).HasColumnName("STATE_FLOW_ID");
        });

        modelBuilder.Entity<XengsfmStateFlowMapping>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XENGSFM_STATE_FLOW_MAPPING");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ddmid).HasColumnName("DDMID");
            entity.Property(e => e.DisplayCustomColumns).HasColumnName("DISPLAY_CUSTOM_COLUMNS");
            entity.Property(e => e.StateflowAdmin).HasColumnName("STATEFLOW_ADMIN");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("1")
                .HasColumnName("STATUS");
            entity.Property(e => e.TurnAroundDays).HasColumnName("TURN_AROUND_DAYS");
            entity.Property(e => e.WorkspaceId).HasColumnName("WORKSPACE_ID");
        });

        modelBuilder.Entity<XengsfmStatusFlowAuditArchived>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGSFM_STATUS_FLOW_AUDIT_ARCHIVED");

            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.EventDate).HasColumnName("EVENT_DATE");
            entity.Property(e => e.EventDetail).HasColumnName("EVENT_DETAIL");
            entity.Property(e => e.EventId).HasColumnName("EVENT_ID");
            entity.Property(e => e.EventType).HasColumnName("EVENT_TYPE");
            entity.Property(e => e.EventUser).HasColumnName("EVENT_USER");
            entity.Property(e => e.NodeId).HasColumnName("NODE_ID");
            entity.Property(e => e.PerformedOnbehalfof)
                .HasMaxLength(4000)
                .HasColumnName("PERFORMED_ONBEHALFOF");
            entity.Property(e => e.StateFlowId).HasColumnName("STATE_FLOW_ID");
        });

        modelBuilder.Entity<XengsfmTransition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGSFM_TRANSITIONS");

            entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DestinationStateId).HasColumnName("DESTINATION_STATE_ID");
            entity.Property(e => e.Events)
                .HasMaxLength(4000)
                .HasColumnName("EVENTS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("NAME");
            entity.Property(e => e.SourceStateId).HasColumnName("SOURCE_STATE_ID");
            entity.Property(e => e.StateFlowId).HasColumnName("STATE_FLOW_ID");
        });

        modelBuilder.Entity<Xengtmtag>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XENGTMTAGS");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<Xengtmtagrelation>(entity =>
        {
            entity.HasKey(e => new { e.Sourcedataid, e.Relateddataid });
            entity.ToTable("XENGTMTAGRELATIONS");

            entity.Property(e => e.Relateddataid).HasColumnName("RELATEDDATAID");
            entity.Property(e => e.Sourcedataid).HasColumnName("SOURCEDATAID");
        });

        modelBuilder.Entity<XengtransDatum>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XENGTRANS_DATA");

            entity.Property(e => e.ActualDate).HasColumnName("ACTUAL_DATE");
            entity.Property(e => e.AdditionalDocFolderid).HasColumnName("ADDITIONAL_DOC_FOLDERID");
            entity.Property(e => e.Coversheetid).HasColumnName("COVERSHEETID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.DocumentFolderid).HasColumnName("DOCUMENT_FOLDERID");
            entity.Property(e => e.ForecastDate).HasColumnName("FORECAST_DATE");
            entity.Property(e => e.LoadsheetVersion).HasColumnName("LOADSHEET_VERSION");
            entity.Property(e => e.Loadsheetid).HasColumnName("LOADSHEETID");
            entity.Property(e => e.SentDate).HasColumnName("SENT_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(4000)
                .HasColumnName("STATUS_MESSAGE");
        });

        modelBuilder.Entity<XengtransDocumentDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGTRANS_DOCUMENT_DATA");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.DocumentMetadata)
                .HasMaxLength(4000)
                .HasColumnName("DOCUMENT_METADATA");
            entity.Property(e => e.DocumentOrder)
                .HasColumnType("INTEGER")
                .HasColumnName("DOCUMENT_ORDER");
            entity.Property(e => e.DocumentStatus).HasColumnName("DOCUMENT_STATUS");
            entity.Property(e => e.Documentid)
                .HasMaxLength(4000)
                .HasColumnName("DOCUMENTID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SourceDataid).HasColumnName("SOURCE_DATAID");
            entity.Property(e => e.SourceParentid).HasColumnName("SOURCE_PARENTID");
            entity.Property(e => e.SourceVersion).HasColumnName("SOURCE_VERSION");
            entity.Property(e => e.SourceVertype)
                .HasMaxLength(255)
                .HasColumnName("SOURCE_VERTYPE");
        });

        modelBuilder.Entity<XengtransEmailSetting>(entity =>
        {
            entity.HasKey(e => e.EmailConfigId);
            entity.ToTable("XENGTRANS_EMAIL_SETTING");

            entity.Property(e => e.EmailBodyTemplateId).HasColumnName("EMAIL_BODY_TEMPLATE_ID");
            entity.Property(e => e.EmailConfigId).HasColumnName("EMAIL_CONFIG_ID");
            entity.Property(e => e.SenderEmail)
                .HasMaxLength(255)
                .HasColumnName("SENDER_EMAIL");
            entity.Property(e => e.SenderEmailFlag)
                .HasDefaultValueSql("0")
                .HasColumnName("SENDER_EMAIL_FLAG");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("SUBJECT");
        });

        modelBuilder.Entity<XengtransInbUpdProcessing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGTRANS_INB_UPD_PROCESSING");

            entity.Property(e => e.Batchid).HasColumnName("BATCHID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.DocumentData)
                .HasMaxLength(4000)
                .HasColumnName("DOCUMENT_DATA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Loadsheetindex).HasColumnName("LOADSHEETINDEX");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(4000)
                .HasColumnName("STATUS_MESSAGE");
        });

        modelBuilder.Entity<XengtransInboundSetting>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XENGTRANS_INBOUND_SETTING");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.EnableInboundUpdates).HasColumnName("ENABLE_INBOUND_UPDATES");
            entity.Property(e => e.InboundActions)
                .HasMaxLength(255)
                .HasColumnName("INBOUND_ACTIONS");
            entity.Property(e => e.InboundDocumentData)
                .HasMaxLength(4000)
                .HasColumnName("INBOUND_DOCUMENT_DATA");
        });

        modelBuilder.Entity<XengtransInboundUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGTRANS_INBOUND_UPDATES");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.DocumentMetadata)
                .HasMaxLength(4000)
                .HasColumnName("DOCUMENT_METADATA");
            entity.Property(e => e.Documentid).HasColumnName("DOCUMENTID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MetadataExtractedVersion).HasColumnName("METADATA_EXTRACTED_VERSION");
            entity.Property(e => e.SeDeliverableId).HasColumnName("SE_DELIVERABLE_ID");
            entity.Property(e => e.SourceDataid).HasColumnName("SOURCE_DATAID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(4000)
                .HasColumnName("STATUS_MESSAGE");
            entity.Property(e => e.UpdatesReceived)
                .HasDefaultValueSql("1")
                .HasColumnName("UPDATES_RECEIVED");
        });

        modelBuilder.Entity<XengtransRecipientDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGTRANS_RECIPIENT_DATA");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.DeliveryMethod).HasColumnName("DELIVERY_METHOD");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RecipientMetadata)
                .HasMaxLength(4000)
                .HasColumnName("RECIPIENT_METADATA");
            entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");
            entity.Property(e => e.Recipienttype).HasColumnName("RECIPIENTTYPE");
            entity.Property(e => e.SentAttempt)
                .HasDefaultValueSql("0")
                .HasColumnName("SENT_ATTEMPT");
            entity.Property(e => e.SentTime).HasColumnName("SENT_TIME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(255)
                .HasColumnName("STATUS_MESSAGE");
        });

        modelBuilder.Entity<XengtransSetting>(entity =>
        {
            entity.HasKey(e => e.Dataid);
            entity.ToTable("XENGTRANS_SETTING");

            entity.Property(e => e.Coversheetid).HasColumnName("COVERSHEETID");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Ddmid).HasColumnName("DDMID");
            entity.Property(e => e.DocumentData)
                .HasMaxLength(4000)
                .HasColumnName("DOCUMENT_DATA");
            entity.Property(e => e.EmailConfigId).HasColumnName("EMAIL_CONFIG_ID");
            entity.Property(e => e.EnableOutboundUpdates).HasColumnName("ENABLE_OUTBOUND_UPDATES");
            entity.Property(e => e.HeaderData)
                .HasMaxLength(4000)
                .HasColumnName("HEADER_DATA");
            entity.Property(e => e.MakeRendition).HasColumnName("MAKE_RENDITION");
            entity.Property(e => e.RecipientData)
                .HasMaxLength(4000)
                .HasColumnName("RECIPIENT_DATA");
            entity.Property(e => e.RenditionType)
                .HasMaxLength(64)
                .HasColumnName("RENDITION_TYPE");
            entity.Property(e => e.SendExistingRenditions).HasColumnName("SEND_EXISTING_RENDITIONS");
            entity.Property(e => e.SendNativeDocument).HasColumnName("SEND_NATIVE_DOCUMENT");
            entity.Property(e => e.TurnAroundDays).HasColumnName("TURN_AROUND_DAYS");
        });

        modelBuilder.Entity<Xengtransextuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGTRANSEXTUSERS");

            entity.Property(e => e.Extuseremail)
                .HasMaxLength(255)
                .HasColumnName("EXTUSEREMAIL");
            entity.Property(e => e.Extuserid).HasColumnName("EXTUSERID");
            entity.Property(e => e.Extusername)
                .HasMaxLength(255)
                .HasColumnName("EXTUSERNAME");
            entity.Property(e => e.Extusertype).HasColumnName("EXTUSERTYPE");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<Xengtransextusergroup>(entity =>
        {
            entity.HasKey(e => new { e.Groupid, e.Userid });
            entity.ToTable("XENGTRANSEXTUSERGROUP");

            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Xengtranstemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XENGTRANSTEMPLATES");

            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.Workspaceid).HasColumnName("WORKSPACEID");
        });

        modelBuilder.Entity<ZotDokumanbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("ZOT_DOKUMANBAKIM");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dokumangrup)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANGRUP");
            entity.Property(e => e.Dokumantur)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANTUR");
            entity.Property(e => e.Dysdokumani)
                .HasColumnType("INTEGER")
                .HasColumnName("DYSDOKUMANI");
            entity.Property(e => e.Gecerli)
                .HasColumnType("INTEGER")
                .HasColumnName("GECERLI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<ZotxKysDokumanturu>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("ZOTX_KYS_DOKUMANTURU");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Dokumangrubu)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANGRUBU");
            entity.Property(e => e.Dokumantipi)
                .HasMaxLength(255)
                .HasColumnName("DOKUMANTIPI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rmid)
                .HasMaxLength(255)
                .HasColumnName("RMID");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<ZotxKysgorevmailbakim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOTX_KYSGOREVMAILBAKIM");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Gonderildi)
                .HasColumnType("INTEGER")
                .HasColumnName("GONDERILDI");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Performerid)
                .HasMaxLength(255)
                .HasColumnName("PERFORMERID");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Taskid)
                .HasMaxLength(255)
                .HasColumnName("TASKID");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
            entity.Property(e => e.Wfid)
                .HasMaxLength(255)
                .HasColumnName("WFID");
            entity.Property(e => e.Wfkisaltma)
                .HasMaxLength(255)
                .HasColumnName("WFKISALTMA");
        });

        modelBuilder.Entity<ZotxSirketbakim>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("ZOTX_SIRKETBAKIM");

            entity.Property(e => e.Aktif)
                .HasColumnType("INTEGER")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sirketgrup).HasColumnName("SIRKETGRUP");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(255)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Sirkettanim)
                .HasMaxLength(255)
                .HasColumnName("SIRKETTANIM");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        modelBuilder.Entity<ZzzTestTemplateSilinecek>(entity =>
        {
            entity.HasKey(e => new { e.Volumeid, e.Dataid, e.Versionnum, e.Seq });
            entity.ToTable("ZZZ_TEST_TEMPLATE_SILINECEK");

            entity.Property(e => e.Dataid).HasColumnName("DATAID");
            entity.Property(e => e.Iterationnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ITERATIONNUM");
            entity.Property(e => e.Rowseqnum)
                .HasDefaultValueSql("1")
                .HasColumnType("INTEGER")
                .HasColumnName("ROWSEQNUM");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.TestTextField)
                .HasMaxLength(255)
                .HasColumnName("TEST_TEXT_FIELD");
            entity.Property(e => e.Versionnum).HasColumnName("VERSIONNUM");
            entity.Property(e => e.Volumeid).HasColumnName("VOLUMEID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
