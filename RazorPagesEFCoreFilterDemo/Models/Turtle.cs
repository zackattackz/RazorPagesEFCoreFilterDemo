using System.ComponentModel.DataAnnotations;

namespace RazorPagesEFCoreFilterDemo.Models;

public class Turtle : Reptile
{
    [Range(1, 10)]
    public int ShellHardness { get; set; }

    public int TurtleTypeId { get; set; }

    public TurtleType TurtleType { get; set; } = default!;
}
