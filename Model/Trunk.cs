using System;
using System.ComponentModel.DataAnnotations.Schema;

public class Trunk
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public DateTime PurchaseDate { get; set; }
    public PostalAddress RecipientAddress { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string Message { get; set; }
}