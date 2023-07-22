using System;
using System.Linq;
using CatApp.Models;

namespace CatApp.Services;

public class CatsService
{
    // first google result
    private static readonly string[] Names = new[]
    {
        "Luna", "Charlie", "Shadow", "Oliver", "Simba", "Smokey", "Bella", "Tiger", "Pepper", "Milo", "Nala"
    };

    // Generates a random array of Cats
    public static CatModel[] GetCatsAsync()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        return Enumerable.Range(1, 30).Select(index => new CatModel
        {
            Name = Names[Random.Shared.Next(Names.Length)],
            Weight = Random.Shared.Next(0, 10),
            // roughly how many days in 20 years
            BirthDate = today.AddDays(Random.Shared.Next(-7300, 0))
        }).ToArray();
    }
}