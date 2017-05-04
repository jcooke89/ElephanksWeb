
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ProductName { get; set; }
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public List<Trunk> Trunks { get; set; }
}