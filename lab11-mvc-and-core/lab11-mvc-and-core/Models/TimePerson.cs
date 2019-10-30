using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Summary description for Year
/// </summary>


namespace lab11_mvc_and_core.Models
{
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

        public static List<TimePerson> GetPersons(TimeSelected timeSelected)
        {
            string[] allData = File.ReadAllLines("./wwwroot/personOfTheYear.csv");
            List<TimePerson> people = new List<TimePerson>();

            for (int i = 1; i < allData.Length; i++)
            {
                string[] columns = allData[i].Split(',');
                TimePerson person = new TimePerson()
                {
                    Year = Convert.ToInt32(columns[0]),
                    Honor = columns[1],
                    Name = columns[2],
                    Country = columns[3],
                    BirthYear = (columns[4] == "") ? 0 : Convert.ToInt32(columns[4]),
                    DeathYear = (columns[5] == "") ? 0 : Convert.ToInt32(columns[5]),
                    Title = columns[6],
                    Category = columns[7],
                    Context = columns[8]
                };
                people.Add(person); // Use Add() method to add object in List
            }
            List<TimePerson> result = people.Where(p => (p.Year >= timeSelected.FromYear && p.Year <= timeSelected.ToYear)).ToList();
            return result;
        }
    }
}
