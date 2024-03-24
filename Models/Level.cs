using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.WorkshopApi.Database.Models;

public partial class Level : IIdentifiable, IIdentifiable<int>
{
    [Attr] public int Id { get; set; }
    [Attr] public string Name { get; set; } = null!;
    [Attr] public string ImageUrl { get; set; } = null!;
    [Attr] public DateTime CreatedAt { get; set; }
    [Attr] public DateTime UpdatedAt { get; set; }
    [Attr] public decimal WorkshopId { get; set; }
    [Attr] public decimal AuthorId { get; set; }
    [Attr] public string FileHash { get; set; } = null!;
    [Attr] public string FileUrl { get; set; } = null!;
    [Attr] public string FileAuthor { get; set; } = null!;
    [Attr] public string FileUid { get; set; } = null!;
    [Attr] public int? ReplacedBy { get; set; }
    [Attr] public bool Deleted { get; set; }
    [Attr] public int MetadataId { get; set; }
    [HasOne(PublicName = "metadata")] public virtual Metadata Metadata { get; set; } = null!;

    string? IIdentifiable.StringId
    {
        get => Id.ToString();
        set
        {
            // Left empty on purpose
        }
    }

    string? IIdentifiable.LocalId
    {
        get => Id.ToString();
        set
        {
            // Left empty on purpose
        }
    }
}
