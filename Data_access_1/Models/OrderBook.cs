using System;
using System.Collections.Generic;

namespace Data_access_1.Models;

public partial class OrderBook
{
    public string OrderId { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? AccountId { get; set; }

    public string? ReceiverAddress { get; set; }

    public string? ReceiverPhone { get; set; }

    public DateTime? OrderReceive { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
