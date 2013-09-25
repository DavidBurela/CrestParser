// Disable ReSharper naming conventions due to JSON strings
// ReSharper disable InconsistentNaming

using Newtonsoft.Json;
using System.Collections.Generic;

namespace CrestParser.Models
{
    public class Owner
    {
        public string Id_str { get; set; }
        public string Href { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Constellation
    {
        public string Id_str { get; set; }
        public string Href { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class System
    {
        public string Id_str { get; set; }
        public double Security { get; set; }
        public string Href { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Infrastructure
    {
        public string Id_str { get; set; }
        public string Href { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Region
    {
        public string Id_str { get; set; }
        public string Href { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Planet
    {
        public string Id_str { get; set; }
        public string Href { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class District
    {
        public string CloneRate_str { get; set; }
        public bool Generating { get; set; }
        public Owner Owner { get; set; }
        public int Reinforce { get; set; }
        public string Href { get; set; }
        public bool Conquerable { get; set; }
        public Constellation Constellation { get; set; }
        public int Id { get; set; }
        public string NextReinforce { get; set; }
        public int Index { get; set; }
        public System System { get; set; }
        public string Id_str { get; set; }
        public int CloneCapacity { get; set; }
        public double Latitude { get; set; }
        public string CloneCapacity_str { get; set; }
        public string Reinforce_str { get; set; }
        public Infrastructure Infrastructure { get; set; }
        public bool Attacked { get; set; }
        public int CloneRate { get; set; }
        public int Clones { get; set; }
        public string Index_str { get; set; }
        public bool Locked { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        public double Longitude { get; set; }
        public Planet Planet { get; set; }
        public string Clones_str { get; set; }
    }


    public class DistrictRootObject
    {
        [JsonProperty]
        public string TotalCount_str { get; set; }
        public List<District> Items { get; set; }
        public int PageCount { get; set; }
        public string PageCount_str { get; set; }
        public int TotalCount { get; set; }
    }
}
