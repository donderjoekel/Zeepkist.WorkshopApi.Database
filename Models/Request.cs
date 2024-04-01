namespace TNRD.Zeepkist.WorkshopApi.Database.Models;

public partial class Request
{
    public int Id { get; set; }

    public decimal WorkshopId { get; set; }

    public string? Uid { get; set; }

    public string? Hash { get; set; }

    public DateTime DateCreated { get; set; }
}
