namespace RazorPagesEFCoreFilterDemo.Models;

public class Canine : Mammal
{
    public int HowlVolume { get; set; }

    public int CanineTypeId { get; set; }

    public CanineType CanineType { get; set; } = default!;
}
