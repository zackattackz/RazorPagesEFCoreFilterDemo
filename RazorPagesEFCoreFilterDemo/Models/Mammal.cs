namespace RazorPagesEFCoreFilterDemo.Models;

public abstract class Mammal : Animal
{
    public ICollection<Color> HairColors { get; set; } = default!;
}
