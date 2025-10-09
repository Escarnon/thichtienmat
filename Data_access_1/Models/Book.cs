using System;
using System.Collections.Generic;

namespace Data_access_1.Models;

public partial class Book
{
    public string BookId { get; set; } = null!;

    public string? BookName { get; set; }

    public double? Price { get; set; }

    public DateTime? Release { get; set; }

    public string? Picture { get; set; }

    public int? PublisherId { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Publisher? Publisher { get; set; }
}
