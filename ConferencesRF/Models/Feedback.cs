using System;
using System.Collections.Generic;

namespace ConferencesRF.Models;

public partial class Feedback
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public int BookingId { get; set; }

    public virtual Booking Booking { get; set; } = null!;
}
