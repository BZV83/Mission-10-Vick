using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission_10_Vick_FINAL.Models;

public partial class Tournament
{
    [Key]
    public int TouneyId { get; set; }
    public DateTime TourneyDate { get; set; }
    public string?   TourneyLocation { get; set; }
}
