using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Year
/// </summary>
public class TimePerson
{
    public int Year { get; set; }
    public string Honor { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public int BirthYear { get; set; }
    public int DeathYear { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
    public string Context { get; set; }

    public TimePerson(int year, string honor, string name, string country, int birthYear, int deathYear, string title, string category, string context)
    {
        Year = year;
        Honor = honor;
        Name = name;
        Country = country;
        BirthYear = birthYear;
        DeathYear = deathYear;
        Title = title;
        Category = category;
        Context = context;
    }
	public TimePerson()
	{

	}

    public static List<TimePerson> GetPersons(int fromYear, int toYear)
    {
        return List<TimePerson>;
    }
}
