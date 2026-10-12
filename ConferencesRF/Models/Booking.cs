using System;
using System.Collections.Generic;

namespace ConferencesRF.Models;

public partial class Booking
{
    public int Id { get; set; }

    public string ConferenceName { get; set; } = null!;

    public int RoomId { get; set; }

    public DateTime Date { get; set; }

    public int PaymentTypeId { get; set; }

    public int BookingStatusId { get; set; }

    public int UserId { get; set; }

    public virtual BookingStatus BookingStatus { get; set; } = null!;

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual PaymentType PaymentType { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
