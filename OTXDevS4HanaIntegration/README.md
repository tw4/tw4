# OpenText ECM – SAP HANA EF Core Entegrasyon Projesi

Bu doküman, OpenText Extended Content Management (ECM) sisteminin SAP HANA 2 veritabanına .NET 8 Web API ve Entity Framework Core kullanarak nasıl bağlandığını, şemaların nasıl çekildiğini ve veritabanı analizinin nasıl yapıldığını adım adım açıklamaktadır.

---

## İçindekiler

1. [Sistem Bilgileri](#1-sistem-bilgileri)
2. [Ön Koşullar](#2-ön-koşullar)
3. [SAP HANA Client SDK Kurulumu](#3-sap-hana-client-sdk-kurulumu)
4. [Proje Oluşturma](#4-proje-oluşturma)
5. [NuGet Paketleri](#5-nuget-paketleri)
6. [EF Core HANA Provider Kurulumu](#6-ef-core-hana-provider-kurulumu)
7. [Bağlantı Ayarları](#7-bağlantı-ayarları)
8. [EF Core Scaffolding (Şema Çekme)](#8-ef-core-scaffolding-şema-çekme)
9. [Karşılaşılan Sorunlar ve Çözümler](#9-karşılaşılan-sorunlar-ve-çözümler)
10. [HasNoKey Sorunu ve Toplu Düzeltme](#10-hasnokey-sorunu-ve-toplu-düzeltme)
11. [PowerShell ile HANA Sorguları](#11-powershell-ile-hana-sorguları)
12. [OTCS Şema Yapısı](#12-otcs-şema-yapısı)
13. [SEQ Kolonu Hakkında](#13-seq-kolonu-hakkında)
14. [Tablo İlişkileri Analizi](#14-tablo-ilişkileri-analizi)
15. [Dikkat Edilmesi Gerekenler](#15-dikkat-edilmesi-gerekenler)

---

## 1. Sistem Bilgileri

| Özellik | Değer |
|---|---|
| Veritabanı | SAP HANA 2.00.057.00.1629894416 (FA/HANA2SP05) |
| Deployment | On-premise sunucu |
| Uygulama | OpenText Extended Content Management (ECM) |
| HANA Şeması | `OTCS` |
| Sunucu IP | 10.1.3.13 |
| Port | 30013 (System DB / Tenant yönlendirme) |
| Tenant DB | OTCS |
| .NET Versiyonu | .NET 8 |
| EF Core Versiyonu | 8.x |

> ⚠️ **Bu canlı bir production veritabanıdır. Herhangi bir şeyi silmeden veya değiştirmeden önce mutlaka dikkatli olun.**

---

## 2. Ön Koşullar

- .NET 8 SDK
- SAP HANA Client SDK (kurulum aşağıda anlatılıyor)
- Visual Studio 2022 veya VS Code
- PowerShell 7+

---

## 3. SAP HANA Client SDK Kurulumu

### 3.1 SDK'yı Nereden Aldık

SAP HANA Client SDK zaten sunucuya kuruluydu:

```
C:\Program Files\SAP\hdbclient\
```

Bu klasörde iki önemli dizin bulunur:

```
C:\Program Files\SAP\hdbclient\dotnetcore\v8.0\
    ├── Sap.Data.Hana.Net.v8.0.dll        ← ADO.NET driver (NuGet'te de var)
    └── Sap.EntityFrameworkCore.Hana.v8.0.dll  ← EF Core provider (sadece SDK'da)
```

### 3.2 EF Core Provider Hakkında Önemli Not

`Sap.EntityFrameworkCore.Hana.v8.0.dll` **NuGet'te yok**, sadece SAP HANA Client SDK ile birlikte geliyor. Bu DLL'i projeye local referans olarak eklemek gerekiyor:

```bash
# DLL'i proje dizinine kopyala
mkdir lib
copy "C:\Program Files\SAP\hdbclient\dotnetcore\v8.0\Sap.EntityFrameworkCore.Hana.v8.0.dll" lib\
```

### 3.3 Method ve Namespace Tespiti

EF Core provider'ın hangi method adını ve namespace'i kullandığını bulmak için DLL içeriğini binary olarak tarayan PowerShell kodu kullandık:

```powershell
$dllPath = "C:\Program Files\SAP\hdbclient\dotnetcore\v8.0\Sap.EntityFrameworkCore.Hana.v8.0.dll"
$bytes = [System.IO.File]::ReadAllBytes($dllPath)
$text = [System.Text.Encoding]::UTF8.GetString($bytes)

# Method adını bul
$text | Select-String -Pattern "UseHana|UseSapHana|UseHanaDb" -AllMatches
```

**Sonuç:**
- Method adı: `UseHana()`
- Namespace: `Sap.EntityFrameworkCore.Hana`

---

## 4. Proje Oluşturma

```bash
dotnet new webapi -n S4HanaIntegration --framework net8.0
cd S4HanaIntegration
```

---

## 5. NuGet Paketleri

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.*
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 8.0.*
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.*
dotnet add package Sap.Data.Hana.Net.v8.0 --version 2.29.23
dotnet add package Swashbuckle.AspNetCore --version 6.*
```

> **Not:** `Microsoft.EntityFrameworkCore.Relational` paketi scaffolding sonrası `HasColumnName()` metodunun tanınması için zorunludur. Eksik olursa binlerce derleme hatası alınır.

---

## 6. EF Core HANA Provider Kurulumu

### 6.1 .csproj Dosyası

```xml
<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.*" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.*">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Relational" Version="8.0.*" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.*">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Sap.Data.Hana.Net.v8.0" Version="2.29.23" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.*" />
  </ItemGroup>

  <!-- SDK'dan kopyalanan local DLL referansı -->
  <ItemGroup>
    <Reference Include="Sap.EntityFrameworkCore.Hana.v8.0">
      <HintPath>lib\Sap.EntityFrameworkCore.Hana.v8.0.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

### 6.2 Program.cs

```csharp
using Sap.EntityFrameworkCore.Hana;
using S4HanaIntegration.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HanaDbContext>(options =>
    options.UseHana(builder.Configuration.GetConnectionString("HanaConnection")!));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
```

---

## 7. Bağlantı Ayarları

### 7.1 Connection String Formatı

SAP HANA multi-tenant yapısı için özel format:

```
Server=HOST:PORT;UserName=KULLANICI;Password=SIFRE;DATABASENAME=TENANT;
```

### 7.2 HANA Port Yapısı

| Port | Açıklama |
|---|---|
| 30013 | System DB (tenant yönlendirme portu) |
| 30015 | Doğrudan tenant bağlantısı (bu projede kapalıydı) |

`DATABASENAME=OTCS` parametresi ile 30013 üzerinden OTCS tenant'ına yönlendirme yapılır.

### 7.3 appsettings.json (commit edilebilir, placeholder)

```json
{
  "ConnectionStrings": {
    "HanaConnection": "Server=HANA_HOST:30015;UserName=DB_USER;Password=DB_PASSWORD;"
  }
}
```

### 7.4 appsettings.Development.json (gerçek credentials — git'e gönderilmez)

```json
{
  "ConnectionStrings": {
    "HanaConnection": "Server=10.1.3.13:30013;UserName=OTCS;Password=***;DATABASENAME=OTCS;"
  }
}
```

### 7.5 .gitignore

```
appsettings.Development.json
bin/
obj/
```

---

## 8. EF Core Scaffolding (Şema Çekme)

Scaffolding = veritabanındaki mevcut tabloları okuyup C# sınıfları ve DbContext oluşturma işlemi. **Veritabanına hiçbir şey yazmaz, sadece okur.**

### 8.1 Scaffolding Komutu

```bash
dotnet ef dbcontext scaffold \
  "Server=10.1.3.13:30013;UserName=OTCS;Password=***;DATABASENAME=OTCS;" \
  Sap.EntityFrameworkCore.Hana \
  --output-dir Models \
  --context-dir Data \
  --context HanaDbContext \
  --schema OTCS \
  --no-onconfiguring \
  --force
```

### 8.2 Scaffold Sonuçları

- **841 tablo/view** OTCS şemasından çekildi
- `Models/` klasörüne 841 adet `.cs` dosyası oluşturuldu
- `Data/HanaDbContext.cs` dosyası ~22.000 satır olarak oluşturuldu

### 8.3 Scaffold Sırasında Karşılaşılan Sorunlar

| Sorun | Sebep | Çözüm |
|---|---|---|
| "Connection refused" | Port 30015 açık değil | Port 30013 kullanıldı |
| "Authentication failed" | SYSTEM user'ı tenant'a bağlanamıyor | `DATABASENAME=OTCS` parametresi eklendi |
| Hiç tablo gelmedi | SYSTEM user'ı System DB'ye bağlanıyor | OTCS user'ı + `DATABASENAME=OTCS` |
| `Object` sınıfı çakışması | OpenText'te `OBJECT` adlı bir tablo var, C#'ta `object` ile çakışıyor | `Models.Object` olarak tam yol belirtildi |

### 8.4 DbContext Güvenlik Ayarı

Canlı veritabanına kazara write yapılmasın diye constructor'a eklendi:

```csharp
public HanaDbContext(DbContextOptions<HanaDbContext> options)
    : base(options)
{
    ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    ChangeTracker.AutoDetectChangesEnabled = false;
}
```

---

## 9. Karşılaşılan Sorunlar ve Çözümler

### 9.1 `UseHana()` Metodu Bulunamıyor

**Hata:** `UseHana` metodu derleyici tarafından tanınmıyor.

**Sebep:** Namespace import eksik.

**Çözüm:**
```csharp
using Sap.EntityFrameworkCore.Hana;
```

### 9.2 `HasColumnName` 7849 Derleme Hatası

**Hata:** `'PropertyBuilder<long>' does not contain a definition for 'HasColumnName'`

**Sebep:** `Microsoft.EntityFrameworkCore.Relational` paketi eksik.

**Çözüm:**
```bash
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 8.0.*
```

### 9.3 `AddOpenApi()` Bulunamıyor

**Hata:** `AddOpenApi` metodu tanınmıyor.

**Sebep:** Bu metot ASP.NET Core 9'a ait, projede .NET 8 kullanılıyor.

**Çözüm:** Swashbuckle kullanıldı:
```csharp
builder.Services.AddSwaggerGen();
// ...
app.UseSwaggerUI();
```

### 9.4 `Object` Sınıfı CS0104 Belirsizlik Hatası

**Hata:** `'Object' is an ambiguous reference between 'S4HanaIntegration.Models.Object' and 'object'`

**Sebep:** OpenText'te `OBJECT` adlı bir tablo var. Scaffold bu tabloyu `Object` sınıfı olarak üretiyor, C#'ın yerleşik `object` tipiyle çakışıyor.

**Çözüm:** `HanaDbContext.cs` içinde tam yol kullanıldı:
```csharp
// DbSet tanımı
public virtual DbSet<Models.Object> Objects { get; set; }

// OnModelCreating içinde
modelBuilder.Entity<Models.Object>(entity => { ... });
```

---

## 10. HasNoKey Sorunu ve Toplu Düzeltme

### 10.1 Sorun

EF Core scaffolding'i 841 tablonun 778'ine `.HasNoKey()` atadı. Bu durum `Add`, `Update`, `Delete` işlemlerini engeller — sadece okuma yapılabilir.

**Sebebi:** SAP HANA EF Core scaffolder, HANA'daki `INVERTED VALUE` tipindeki index'leri primary key olarak tanımıyor.

### 10.2 Çözüm Yaklaşımı

HANA sistem tablosu `SYS.INDEX_COLUMNS`'dan her tablonun key kolonları çekildi ve `HasKey(...)` ile atandı.

### 10.3 Key Bilgisi Çekme (PowerShell)

```powershell
Add-Type -Path "C:\Program Files\SAP\hdbclient\dotnetcore\v8.0\Sap.Data.Hana.Net.v8.0.dll"
$conn = New-Object Sap.Data.Hana.HanaConnection("Server=10.1.3.13:30013;uid=OTCS;pwd=***;DATABASENAME=OTCS;")
$conn.Open()

$cmd = New-Object Sap.Data.Hana.HanaCommand(@"
SELECT TABLE_NAME, INDEX_NAME, COLUMN_NAME, POSITION
FROM SYS.INDEX_COLUMNS
WHERE SCHEMA_NAME = 'OTCS'
ORDER BY TABLE_NAME, INDEX_NAME, POSITION
"@, $conn)
```

### 10.4 HanaDbContext.cs Parse (Kolon → Property Adı Eşleştirme)

`HanaDbContext.cs` dosyasındaki `.HasColumnName("KOLON_ADI")` satırları parse edilerek her tablonun `HANA_KOLON → C#_Property` haritası çıkarıldı. Bu sayede Türkçe karakter sorunları (örn: `I → ı` dönüşümü) olmadan gerçek property adları kullanıldı.

### 10.5 Toplu Değiştirme

Scaffold'un ürettiği format:
```csharp
entity
    .HasNoKey()
    .ToTable("TABLO_ADI");
```

Değiştirilen format:
```csharp
entity.HasKey(e => new { e.Kolon1, e.Kolon2 });
entity.ToTable("TABLO_ADI");
```

### 10.6 Sonuçlar

| Durum | Tablo Sayısı |
|---|---|
| HasKey ile düzeltildi | **645** |
| Key verisi yok (HasNoKey kaldı) | 91 |
| View (`.ToView()`) — HasNoKey doğru | 41 |
| Property map eksik | 1 (DFACETCACHECORE) |
| Scaffold'dan zaten HasKey geldi | 63 |
| **Toplam** | **841** |

---

## 11. PowerShell ile HANA Sorguları

PowerShell'den doğrudan HANA'ya bağlanmak için `Sap.Data.Hana.Net.v8.0.dll` kullanılır.

### 11.1 Bağlantı Kurma

```powershell
Add-Type -Path "C:\Program Files\SAP\hdbclient\dotnetcore\v8.0\Sap.Data.Hana.Net.v8.0.dll"

$conn = New-Object Sap.Data.Hana.HanaConnection(
    "Server=10.1.3.13:30013;uid=OTCS;pwd=***;DATABASENAME=OTCS;"
)
$conn.Open()
```

### 11.2 Sorgu Çalıştırma

```powershell
$cmd = New-Object Sap.Data.Hana.HanaCommand("SELECT * FROM OTCS.TABLO LIMIT 10", $conn)
$reader = $cmd.ExecuteReader()
while ($reader.Read()) {
    Write-Host "$($reader['KOLON_ADI'])"
}
$reader.Close()
$conn.Close()
```

### 11.3 Scalar Değer Alma

```powershell
$cmd = New-Object Sap.Data.Hana.HanaCommand("SELECT COUNT(*) FROM OTCS.TABLO", $conn)
$count = $cmd.ExecuteScalar()
Write-Host "Toplam: $count"
```

### 11.4 Faydalı Sistem Sorguları

#### Tüm tabloları listele
```sql
SELECT TABLE_NAME FROM SYS.TABLES WHERE SCHEMA_NAME = 'OTCS' ORDER BY TABLE_NAME
```

#### Bir tablonun kolon yapısı
```sql
SELECT COLUMN_NAME, DATA_TYPE_NAME, LENGTH, IS_NULLABLE, DEFAULT_VALUE
FROM SYS.TABLE_COLUMNS
WHERE SCHEMA_NAME = 'OTCS' AND TABLE_NAME = 'TABLO_ADI'
ORDER BY POSITION
```

#### Index ve key bilgisi
```sql
SELECT INDEX_NAME, COLUMN_NAME, POSITION
FROM SYS.INDEX_COLUMNS
WHERE SCHEMA_NAME = 'OTCS' AND TABLE_NAME = 'TABLO_ADI'
ORDER BY INDEX_NAME, POSITION
```

#### Index tipi (UNIQUE mi değil mi?)
```sql
SELECT INDEX_NAME, INDEX_TYPE, CONSTRAINT
FROM SYS.INDEXES
WHERE SCHEMA_NAME = 'OTCS' AND TABLE_NAME = 'TABLO_ADI'
```

#### Foreign key constraint'ları
```sql
-- Bu tablonun dışarıya FK'ları
SELECT CONSTRAINT_NAME, COLUMN_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME
FROM SYS.REFERENTIAL_CONSTRAINTS
WHERE SCHEMA_NAME = 'OTCS' AND TABLE_NAME = 'TABLO_ADI'

-- Bu tabloya gelen FK'lar
SELECT CONSTRAINT_NAME, TABLE_NAME, COLUMN_NAME, REFERENCED_COLUMN_NAME
FROM SYS.REFERENTIAL_CONSTRAINTS
WHERE SCHEMA_NAME = 'OTCS' AND REFERENCED_TABLE_NAME = 'TABLO_ADI'
```

#### Primary Key constraint var mı?
```sql
SELECT CONSTRAINT_NAME, COLUMN_NAME, POSITION
FROM SYS.CONSTRAINTS
WHERE SCHEMA_NAME = 'OTCS' AND TABLE_NAME = 'TABLO_ADI'
```

#### Tenant listesi (System DB üzerinden)
```sql
SELECT DATABASE_NAME, ACTIVE_STATUS FROM M_DATABASES
```

---

## 12. OTCS Şema Yapısı

### 12.1 Temel Tablolar

| Tablo | Açıklama |
|---|---|
| `DTREE` | Ana node tablosu. Her doküman, klasör, workspace bir satır. |
| `KUAF` | Kullanıcı ve grup tablosu (`TYPE=0` kullanıcı, `TYPE=1` grup) |
| `DTREENOTIFY` | Bildirim ayarları |
| `DVERSDATA` | Versiyon verileri |

### 12.2 Önemli Kolonlar

| Kolon | Açıklama |
|---|---|
| `DATAID` | Her node'un benzersiz ID'si (OpenText'in primary identifier'ı) |
| `VOLUMEID` | Volume container ID'si (sistemde `-16503`) |
| `VERSIONNUM` | Versiyon numarası (genellikle `0`) |
| `SUBTYPE` | Node tipi (0=Klasör, 144=Kullanıcı, 130=Grup, 136=Doküman...) |

### 12.3 Custom Attribute Tabloları

`ZOTX_` ve `ZOT_` prefix'li tablolar bu sisteme özgü custom attribute tablolarıdır:

| Tablo | Açıklama |
|---|---|
| `ZOTX_KYS_DOKUMANTURU` | Doküman türü atamaları |
| `ZOT_DOKUMANBAKIM` | İzin verilen döküman türleri listesi |
| `KYSDYS_SABLONBAKIM` | DYS şablon tanımları |
| `KYSDYS_ONAYCILARBAKIM` | Onay akışı konfigürasyonu |

---

## 13. SEQ Kolonu Hakkında

Custom attribute tablolarının çoğunda `(VOLUMEID, DATAID, VERSIONNUM, SEQ)` composite key yapısı görülür.

### 13.1 SEQ Nedir?

SEQ, aynı doküman (`DATAID`) için birden fazla satır bulunabildiğinde satırları birbirinden ayırt eden bir **sıra numarasıdır**.

Örneğin `ZOT_DOKUMANBAKIM` tablosunda aynı `DATAID=35157` altında 65 farklı döküman türü tanımı bulunur ve her biri farklı bir SEQ ile ayrılır.

### 13.2 SEQ Nasıl Dolar?

- **HANA sequence objesi kullanılmaz** (kontrol edildi, yok)
- **Identity/autoincrement değil**
- **OpenText uygulama katmanı** yönetir: `MAX(SEQ) + 1` mantığıyla çalışır
- Silinen satırın SEQ değeri geri gelmez, boşluk oluşur (bu normaldir)

### 13.3 EF Core ile Insert Yaparken

```csharp
// Mevcut max SEQ'yi sorgula
var maxSeq = await context.ZotDokumanbakims
    .Where(x => x.Dataid == dataid && x.Volumeid == -16503 && x.Versionnum == 0)
    .MaxAsync(x => (long?)x.Seq) ?? 0;

// Yeni satır ekle
var yeni = new ZotDokumanbakim
{
    Volumeid     = -16503,
    Dataid       = dataid,
    Versionnum   = 0,
    Seq          = maxSeq + 1,
    Dokumantur   = "Yeni Tür",
    Dokumangrup  = "Kalite Yönetimi",
    Rowseqnum    = 1,
    Iterationnum = 1,
};
context.ZotDokumanbakims.Add(yeni);
await context.SaveChangesAsync();
```

### 13.4 SEQ Boşluğu Sorunsaldır

Silinmiş bir satırın SEQ'si kaybolur ve `MAX+1` o değeri tekrar kullanabilir. Bu **sorun değildir** çünkü:
- Bu tablolarda DB seviyesinde FK constraint yok
- Eski satır zaten silinmiş olduğundan çakışma olmaz
- OpenText'in kendisi de aynı yaklaşımı kullanıyor (tablolarda gözlemlendi)

### 13.5 SEQ Race Condition — Gerçek Vaka

**Ne oldu:**

`ZOT_DOKUMANBAKIM` tablosuna aynı anda iki farklı kaynaktan insert yapıldı:

```
DB (doğrudan):  MAX(SEQ)=66 gördü → SEQ=67 ile insert etti  ✓
OpenText UI:    MAX(SEQ)=66 gördü → SEQ=67 ile insert etti  ✓ (DB'deki 67'yi görmedi)
Sonuç:          SEQ=67 iki farklı satırda oluştu (duplicate)
```

HANA'da bu tablo için PK constraint olmadığından DB her iki insert'i de kabul etti.

**Nasıl düzeltildi:**

```sql
-- Benim eklediğim satırın SEQ'si 68'e güncellendi
UPDATE OTCS.ZOT_DOKUMANBAKIM
SET SEQ = 68
WHERE VOLUMEID = -16503
  AND DATAID = 35157
  AND VERSIONNUM = 0
  AND SEQ = 67
  AND DOKUMANTUR = N'İş Talimatı'
  AND DOKUMANGRUP = N'Bilgi İşlem'
```

**Sonraki test:** OpenText UI'dan yeni kayıt eklendi → MAX(SEQ)=68 görüp SEQ=69 verdi → çakışma olmadı.

**Kural:**

> Doğrudan DB'ye insert yaparken OpenText aynı anda aynı tabloya yazıyorsa race condition kaçınılmazdır. Bu tablolara insert ya OpenText UI/API üzerinden yapılmalı, ya da sistem sakin olduğunda (gece/bakım penceresi) yapılmalıdır.

---

## 14. Tablo İlişkileri Analizi

### 14.1 DB Seviyesinde FK Durumu

OTCS şemasındaki custom tablolarda (`ZOTX_`, `ZOT_`, `KYSDYS_`) resmi FK constraint'lar **yoktur**. İlişkiler uygulama katmanında yönetilir.

Bunu doğrulamak için:

```powershell
$cmd = New-Object Sap.Data.Hana.HanaCommand(@"
SELECT CONSTRAINT_NAME, COLUMN_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME
FROM SYS.REFERENTIAL_CONSTRAINTS
WHERE SCHEMA_NAME = 'OTCS' AND TABLE_NAME = 'KYSDYS_ONAYCILARBAKIM'
"@, $conn)
```

### 14.2 Mantıksal İlişkiler

Resmi FK olmasa da kolonların içeriğine bakarak ilişkiler bulunabilir. Örneğin `KYSDYS_ONAYCILARBAKIM` tablosunda:

| Kolon | Referans | Tablo |
|---|---|---|
| `DEPARTMAN` | Grup ID'si | `KUAF` (TYPE=1) |
| `DEPARTMANBIRIMI` | Grup ID'si | `KUAF` (TYPE=1) |
| `KONTROLEDEN` | Kullanıcı/Grup ID'si | `KUAF` |
| `ONAYCI1` | Kullanıcı ID'si | `KUAF` (TYPE=0) |
| `ONAYCI2` | Kullanıcı ID'si | `KUAF` (TYPE=0) |
| `ONAYCI3` | Kullanıcı ID'si | `KUAF` (TYPE=0) |

### 14.3 BIGINT Kolonu Nereden Geliyor?

Bir tablodaki BIGINT kolonunun hangi tabloya referans verdiğini anlamak için:

```powershell
# 1. DTREE'de var mı? (node ID mi?)
$cmd = New-Object Sap.Data.Hana.HanaCommand(
    "SELECT DATAID, NAME, SUBTYPE FROM OTCS.DTREE WHERE DATAID IN (772623, 772046)",
    $conn
)

# 2. KUAF'ta var mı? (kullanıcı/grup ID mi?)
$cmd = New-Object Sap.Data.Hana.HanaCommand(
    "SELECT ID, NAME, TYPE FROM OTCS.KUAF WHERE ID IN (772623, 772046)",
    $conn
)
```

---

## 15. Dikkat Edilmesi Gerekenler

### ⚠️ Canlı Veritabanı

Bu sistem **canlı production veritabanıdır**. Tüm işlemler yapılırken:

- Herhangi bir DDL komutu çalıştırma (`CREATE`, `DROP`, `ALTER`)
- Test amaçlı bile olsa `DELETE` veya `UPDATE` çalıştırma
- Scaffolding işlemini production zamanında yapma (sadece okur ama yük bindirebilir)

### ⚠️ EF Core Write İşlemleri

`SaveChangesAsync()` çağrısı gerçek veri yazar. Kullanmadan önce:

1. Doğru tabloyu hedeflediğinden emin ol
2. Key değerlerini (özellikle SEQ) doğru hesapla
3. NOT NULL kolonları doldurmayı unutma (`ROWSEQNUM`, `ITERATIONNUM` genellikle default `1`)
4. Insert öncesi aynı kombinasyonun zaten var olup olmadığını kontrol et (duplicate önleme)

### ⚠️ Eş Zamanlı Insert — Race Condition

Doğrudan DB'ye insert yazmak sorunsuz çalışır. Sorun yalnızca **aynı anda** iki farklı kaynak aynı tabloya yazarsa oluşur:

| Durum | Sonuç |
|---|---|
| Sadece sen (DB veya EF Core) yazıyorsun | ✅ Güvenli |
| Sadece OpenText UI kullanılıyor | ✅ Güvenli |
| Sen yazarken biri UI'dan aynı tabloya aynı anda yazıyor | ⚠️ SEQ duplicate riski |

**Insert öncesi duplicate kontrolü örneği:**

```csharp
// Aynı kombinasyon var mı?
var exists = await context.ZotDokumanbakims
    .AnyAsync(x => x.Dataid == dataid
                && x.Dokumantur == dokumanTur
                && x.Dokumangrup == dokumanGrup);

if (!exists)
{
    var maxSeq = await context.ZotDokumanbakims
        .Where(x => x.Dataid == dataid && x.Volumeid == -16503)
        .MaxAsync(x => (long?)x.Seq) ?? 0;

    context.ZotDokumanbakims.Add(new ZotDokumanbakim
    {
        Volumeid     = -16503,
        Dataid       = dataid,
        Versionnum   = 0,
        Seq          = maxSeq + 1,
        Dokumantur   = dokumanTur,
        Dokumangrup  = dokumanGrup,
        Gecerli      = 1,
        Dysdokumani  = 1,
        Kod          = kod,
        Rowseqnum    = 1,
        Iterationnum = 1,
    });
    await context.SaveChangesAsync();
}
```

### ⚠️ HasNoKey Kalan Tablolar

91 tablo hâlâ `HasNoKey` durumunda (index bilgisi bulunamadı). Bu tablolara `Add/Update/Delete` yapılırsa EF Core runtime hatası verir. Sadece okuma (`Select`) yapılabilir.

### ⚠️ Credentials

`appsettings.Development.json` dosyası `.gitignore`'a eklenmiştir ve gerçek DB şifresi içerir. Bu dosyayı asla commit etme.

---

## Proje Dosya Yapısı

```
S4HanaIntegration/
├── lib/
│   └── Sap.EntityFrameworkCore.Hana.v8.0.dll   ← SDK'dan kopyalandı
├── Data/
│   ├── HanaDbContext.cs                          ← 841 DbSet, ~22.000 satır
│   └── HanaDbContext.cs.bak                      ← HasNoKey düzeltmesi öncesi yedek
├── Models/
│   └── *.cs                                      ← 841 adet entity sınıfı
├── appsettings.json                              ← Placeholder (commit edilebilir)
├── appsettings.Development.json                  ← Gerçek credentials (git'e gönderilmez!)
├── Program.cs
├── S4HanaIntegration.csproj
├── HANA-SETUP.txt                               ← Scaffold komutları notları
├── .gitignore
└── README.md                                    ← Bu dosya
```
