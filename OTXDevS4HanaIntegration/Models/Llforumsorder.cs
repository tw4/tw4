using System;
using System.Collections.Generic;

namespace S4HanaIntegration.Models;

public partial class Llforumsorder
{
    public long? Forumid { get; set; }

    public long? Topicid { get; set; }

    public string Orderstring { get; set; } = null!;

    public short? Topiclevel { get; set; }

    public short? Topicstatus { get; set; }

    public long? Ownerid { get; set; }

    public DateTime? Modifydate { get; set; }

    public short? Priority { get; set; }

    public long? Userid { get; set; }
}
