using System.ComponentModel.DataAnnotations.Schema;

public class PostalAddress
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string Building { get; set; }
    public string City { get; set; }
    public string CountyRegion { get; set; }
    public string PostCode { get; set; }
    public string Province { get; set; }
}