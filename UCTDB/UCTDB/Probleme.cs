using System;
using System.Collections.Generic;

namespace UCTDB
{
    /// <summary>
    /// Represents a reported problem or incident at a fire station.
    /// </summary>
    public class Probleme
    {
        public int Id { get; set; } = 1;
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateSignalement { get; set; }
        public string NiveauUrgence { get; set; }
        public string Caserne { get; set; } = "Unknown";
        public DateTime? DateRetour { get; set; }
    }
}

/// <summary>
/// Complete mission data including assigned firefighters and vehicles.
/// </summary>
public class MissionComplete
{
    public int Id { get; set; }
    public string Titre { get; set; }
    public string Description { get; set; }
    public string Adresse { get; set; }
    public string Caserne { get; set; }
    public string CompteRendu { get; set; }
    public string NatureSinistre { get; set; }
    public DateTime DateDepart { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime? DateRetour { get; set; }
    public List<string> Pompiers { get; set; }
    public List<string> Engins { get; set; }

    public MissionComplete()
    {
        Pompiers = new List<string>();
        Engins = new List<string>();
    }
}
