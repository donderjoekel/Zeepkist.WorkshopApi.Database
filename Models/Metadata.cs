using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.WorkshopApi.Database.Models;

public partial class Metadata : IIdentifiable, IIdentifiable<string>
{
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

    public string? StringId
    {
        get => Hash;
        set
        {
            // Left empty on purpose
        }
    }

    public string? LocalId
    {
        get => Hash;
        set
        {
            // Left empty on purpose
        }
    }

    public string Id
    {
        get=> Hash;
        set
        {
            // Left empty on purpose
        }
    }
}
