using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpacePortDockingAPI.Models.DatabaseModels;

public partial class ShipClass
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ShipClassId { get; set; }

    public string ClassName { get; set; }
}
