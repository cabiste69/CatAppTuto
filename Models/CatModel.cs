using System;

namespace CatApp.Models;

public class CatModel
{
    public string Name { get; set; }

    public int Weight { get; set; }

    public DateOnly BirthDate { get; set; }

    public int Age => DateTime.Now.Year - BirthDate.Year;
}