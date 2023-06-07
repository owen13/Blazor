using System;
using System.Collections.Generic;

namespace Models
{
    public abstract class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        
        public List<Character> Characters { get; set; } = new List<Character>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }
    public class Movie : Production
    {
        public int DurationInMinutes { get; set; }
        public double WorldwideBoxOfficeGross { get; set; }
    }
    public class Series : Production
    {
        public int NumberOfEpisodes { get; set; }
    }
    
    public class Rating
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public string Source { get; set; }
        public int Stars { get; set; }
    }
    
    public class Character
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public string Name { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
    }
    
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}