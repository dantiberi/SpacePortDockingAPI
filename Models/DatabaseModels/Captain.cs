using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpacePortDockingAPI.Models.DatabaseModels;

public partial class Captain
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CaptainId { get; set; }
    
    [Required]
    public string Name { get; set; }

    [Required]
    public bool Iswanted { get; set; }

    public string ChainCode { get; set; }
}
