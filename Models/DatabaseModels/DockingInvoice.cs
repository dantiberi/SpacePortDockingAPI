using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpacePortDockingAPI.Models.DatabaseModels;

public partial class DockingInvoice
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int InvoiceId { get; set; }

    [Required]
    public Starship Starship { get; set; }

    [Required]
    public Captain Captain { get; set; }
    
    public float DockingFee { get; set; }

    [Required]
    public DateTime ArrivalDate { get; set; }

    public DateTime DepartureDate { get; set; }

    public int NumberPassengers { get; set; }
}
