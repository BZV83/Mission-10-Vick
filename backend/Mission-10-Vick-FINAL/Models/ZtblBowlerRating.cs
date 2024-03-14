using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission_10_Vick_FINAL.Models;

public partial class ZtblBowlerRating
{
    [Key]
    public string BowlerRating { get; set; } = null!;

    public short? BowlerLowAvg { get; set; }

    public short? BowlerHighAvg { get; set; }
}
