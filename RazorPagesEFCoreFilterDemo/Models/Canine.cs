using System.ComponentModel.DataAnnotations;

namespace RazorPagesEFCoreFilterDemo.Models;

public class Canine : Mammal
{
    [Range(0, int.MaxValue)]
    public int HowlVolume { get; set; }

    public int CanineTypeId { get; set; }

    public CanineType CanineType { get; set; } = default!;
}
