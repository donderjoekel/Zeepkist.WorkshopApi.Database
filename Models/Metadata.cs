using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.WorkshopApi.Database.Models;

public partial class Metadata : IIdentifiable, IIdentifiable<int>
{
    [Attr] public string Hash { get; set; } = null!;
    [Attr] public bool Valid { get; set; }
    [Attr] public int Checkpoints { get; set; }
    [Attr] public string Blocks { get; set; } = null!;
    [Attr] public float Validation { get; set; }
    [Attr] public float Gold { get; set; }
    [Attr] public float Silver { get; set; }
    [Attr] public float Bronze { get; set; }
    [Attr] public int Ground { get; set; }
    [Attr] public int Skybox { get; set; }
    [Attr] public int Id { get; set; }
    [HasMany] public virtual ICollection<Level> Levels { get; set; } = new List<Level>();

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
