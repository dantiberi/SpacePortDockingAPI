using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpacePortDockingAPI.Models.DatabaseModels;

public partial class Faction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FactionId { get; set; }


    [Required]
    public string Name { get; set; }


    [Required]
    public bool IsBanned { get; set; }
}
