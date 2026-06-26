using System;
using System.Collections.Generic;

namespace OTXProdIntegration.Models;

public partial class Agentconfig
{
    public long? Configid { get; set; }

    public byte? Enabled { get; set; }

    public DateTime? Lasttime { get; set; }

    public string? Url { get; set; }

    public string? Smtpserver { get; set; }

    public int? Smtpport { get; set; }

    public byte? Smtpssl { get; set; }

    public byte? Smtpauth { get; set; }

    public string? Smtpusername { get; set; }

    public string? Smtppassword { get; set; }

    public long? Smtptimeout { get; set; }

    public string? Smtphelohostname { get; set; }

    public string? Mapiprofile { get; set; }

    public string? Mapipassword { get; set; }

    public long? Dftreportid { get; set; }

    public int? Dftreportoptions { get; set; }

    public long? Dfttransportid { get; set; }

    public long? Dftmsgtype { get; set; }

    public string? Dftmsgsubject { get; set; }

    public string? Dftmsghtmlfilename { get; set; }

    public string? Dftmsgdatabasename { get; set; }

    public string? Dftmsgfromaddress { get; set; }

    public string? Dftmsgreplyto { get; set; }

    public string? Dftsched1name { get; set; }

    public int? Dftsched1monthmask { get; set; }

    public int? Dftsched1daymask { get; set; }

    public int? Dftsched1hourmask { get; set; }

    public int? Dftsched1minutemask { get; set; }

    public string? Dftsched2name { get; set; }

    public int? Dftsched2monthmask { get; set; }

    public int? Dftsched2daymask { get; set; }

    public int? Dftsched2hourmask { get; set; }

    public int? Dftsched2minutemask { get; set; }

    public string? Dftsched3name { get; set; }

    public int? Dftsched3monthmask { get; set; }

    public int? Dftsched3daymask { get; set; }

    public int? Dftsched3hourmask { get; set; }

    public int? Dftsched3minutemask { get; set; }

    public long? Onerrtransportid { get; set; }

    public string? Onerrsubject { get; set; }

    public string? Onerraddress { get; set; }

    public int? Testing { get; set; }

    public int? Sqltracing { get; set; }

    public string? Smtpencryptionmethod { get; set; }

    public byte? Smtpauthmethod { get; set; }
}
