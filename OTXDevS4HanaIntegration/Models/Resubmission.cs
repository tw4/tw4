using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Resubmission
{
    public long? Rsid { get; set; }

    public long? Rsparentid { get; set; }

    public long? Dataid { get; set; }

    public int? Rstype { get; set; }

    public int? Rsrule { get; set; }

    public int? Rsstatus { get; set; }

    public long? Rscreatorid { get; set; }

    public DateTime? Rscreatedate { get; set; }

    public long? Lastmodifiedby { get; set; }

    public DateTime? Lastmoddate { get; set; }

    public int? Deleted { get; set; }

    public int? Rsdelivered { get; set; }

    public string? Rsdescription { get; set; }

    public DateTime? Rsdate { get; set; }

    public int? Rsruleunit { get; set; }

    public int? Rsrulevalue { get; set; }

    public string? Rssequencecode { get; set; }

    public DateTime? Rsseqstartdate { get; set; }

    public DateTime? Rsseqenddate { get; set; }

    public int? Moveprev { get; set; }

    public int? Timezone { get; set; }

    public long? Rsstatususerid { get; set; }

    public int? Rsactivation { get; set; }

    public int? Rsactivationunit { get; set; }

    public int? Rsactivationbday { get; set; }

    public DateTime? Rsactivationdate { get; set; }

    public int? Rshandler { get; set; }

    public long? Rshandlerdata { get; set; }

    public int? Rspriority { get; set; }
}
