using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpacePortDockingAPI.Models.DatabaseModels;

public partial class Starship
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StarshipId { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string Callsign { get; set; }


    [Required]
    public Captain Captain { get; set; }


    [Required]
    public ShipClass ShipClass { get; set; }
    
    public Faction Faction { get; set; }
}
