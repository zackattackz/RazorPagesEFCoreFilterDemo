using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RazorPagesEFCoreFilterDemo.Models.Enums;

public enum AnimalSubtype
{
    Canines,
    Primates,
    Crocodiles,
    Turtles
}

public static class AnimalSubtypeExtensions
{
    private static bool BelongsToType(this AnimalSubtype subtype, AnimalType type)
    {
        return type switch
        {
            AnimalType.Mammals => subtype == AnimalSubtype.Canines
                                || subtype == AnimalSubtype.Primates,
            AnimalType.Reptiles => subtype == AnimalSubtype.Crocodiles
                                || subtype == AnimalSubtype.Turtles,
            _ => throw new ArgumentOutOfRangeException($"Value {type} is not a valid {nameof(AnimalType)}"),
        };
    }

    public static bool TryParseToAnimalSubtype(this string? subtypeString, AnimalType type, out AnimalSubtype subtype)
    {
        var subTypeIsValid = Enum.TryParse(subtypeString, out subtype);
        if(!subTypeIsValid)
        {
            return false;
        }
        return subtype.BelongsToType(type);
    }
}
