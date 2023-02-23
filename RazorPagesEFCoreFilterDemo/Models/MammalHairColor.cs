namespace RazorPagesEFCoreFilterDemo.Models;

public class MammalHairColor
{
    public int MammalId { get; set; }

    public Mammal Mammal { get; set; } = default!;

    public int ColorId { get; set; }

    public Color Color { get; set; } = default!;
}
