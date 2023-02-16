using System.ComponentModel.DataAnnotations;

namespace RazorPagesEFCoreFilterDemo.Models;

public abstract class Reptile : Animal
{
    [Range(1, 10)]
    public int ScaleHardness { get; set; }

    public int EggColorId { get; set; }
    public Color EggColor { get; set; } = default!;
}
