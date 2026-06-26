using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class KysdfsAksiyonlartablosu
{
    public int? Id { get; set; }

    public string? Wfid { get; set; }

    public string? Alinacakaksiyon { get; set; }

    public string? Aksiyonsorumlusu { get; set; }

    public string? Aksiyontipi { get; set; }

    public string? Termintarihi { get; set; }

    public string? Kapatmatarihi { get; set; }

    public string? Durum { get; set; }

    public string? Yorum { get; set; }

    public string? Aksiyonsurecdurumu { get; set; }

    public string? Departman { get; set; }

    public string? Folderid { get; set; }

    public string? Aksiyondurumu { get; set; }
}
