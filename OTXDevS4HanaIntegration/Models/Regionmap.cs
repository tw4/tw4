using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Regionmap
{
    public long? Searchmanagerid { get; set; }

    public string Name { get; set; } = null!;

    public string Displayname { get; set; } = null!;

    public byte? Queryable { get; set; }

    public byte? Displayable { get; set; }

    public byte? Searchbydefault { get; set; }

    public byte? Sortable { get; set; }

    public byte? Facet { get; set; }

    public string? Rwram { get; set; }

    public string? Uoram { get; set; }

    public byte? Purged { get; set; }

    public string? Rdram { get; set; }

    public string? Facettype { get; set; }
}
