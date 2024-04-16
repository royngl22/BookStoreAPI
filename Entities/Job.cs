using System;
using System.Collections.Generic;

namespace BookStoreAPI.Entities;

public partial class Job
{
    public short JobId { get; set; }

    public string JobDesc { get; set; } = null!;
}
