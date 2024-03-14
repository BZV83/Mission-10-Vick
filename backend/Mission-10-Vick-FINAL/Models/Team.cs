using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission_10_Vick_FINAL.Models;

public partial class Team
{
    [Key]
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }
}
