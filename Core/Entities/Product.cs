using System;

namespace Core.Entities;

public class Product : BaseEntity
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public decimal Price { get; set; }

    public required string PictureUrl { get; set; }

    // Type = kategorija npr. Hljeb, Pecivo, Pita, Kolac, Torta
    public required string Type { get; set; }

    // Brand -> Proizvodjac/Vrsta tijesta npr. Pšenično, Raženo, Kukuruzno, Integralno
    public required string Brand { get; set; }

    public int QuantityInStock { get; set; }
}
