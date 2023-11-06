using System.Collections.Immutable;
using BAFA.Models;

namespace BAFA.Services;

public static class ProductProviderService
{
    public static readonly ImmutableList<Product> Products = ImmutableList.CreateRange(new List<Product>()
    {
        new()
        {
            Id = Guid.NewGuid(),
            Name = "BAFA Home Shorts",
            Description = "A nice pair of shorts",
            Price = 25,
            Image="shorts.jpeg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "BAFA Home T-Shirt",
            Description = "A nice T-shirt",
            Price = 25,
            Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        },
        new()
        {
	        Id = Guid.NewGuid(),
	        Name = "BAFA Home T-Shirt",
	        Description = "A nice T-shirt",
	        Price = 25,
	        Image = "tshirt.jpeg"
        }
});
}