using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.WorkshopApi.Database.Models;

public partial class Metadata : IIdentifiable, IIdentifiable<int>
{
    [Attr] public int Id { get; set; }
    [Attr] public string Hash { get; set; } = null!;
    [Attr] public int Checkpoints { get; set; }
    [Attr] public string Blocks { get; set; } = null!;
    [Attr] public bool Valid { get; set; }
    [Attr] public float Validation { get; set; }
    [Attr] public float Gold { get; set; }
    [Attr] public float Silver { get; set; }
    [Attr] public float Bronze { get; set; }
    [Attr] public int Ground { get; set; }
    [Attr] public int Skybox { get; set; }
    
    [HasOne(PublicName = "level")] public virtual Level LevelNavigation { get; set; } = null!;

    string? IIdentifiable.StringId
    {
        get => Hash;
        set
        {
            // Left empty on purpose
        }
    }

    string? IIdentifiable.LocalId
    {
        get => Hash;
        set
        {
            // Left empty on purpose
        }
    }
}
