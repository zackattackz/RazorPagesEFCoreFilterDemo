namespace RazorPagesEFCoreFilterDemo.Models;

public class Crocodile : Reptile
{
    public int BiteForce { get; set; }

    public int CrocodileTypeId { get; set; }

    public CrocodileType CrocodileType { get; set; } = default!;
}
