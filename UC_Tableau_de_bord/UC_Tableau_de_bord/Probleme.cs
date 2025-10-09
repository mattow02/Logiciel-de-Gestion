using System;
using System.Collections.Generic;

namespace UC_Tableau_de_bord
{
    public class Probleme
    {
        public int Id { get; set; } = 1; // Valeur par défaut si tu ne veux pas gérer ça maintenant
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateSignalement { get; set; }
        public string NiveauUrgence { get; set; }
        public string Caserne { get; set; } = "Inconnue"; // Valeur par défaut

        public DateTime? DateRetour { get; set; }

    }

}


public class MissionComplete
{
    public int Id { get; set; }

    // Données principales
    public string Titre { get; set; }               // utilisé : nomSinistre
    public string Description { get; set; }         // utilisé : motifAppel
    public string Adresse { get; set; }
    public string Caserne { get; set; }
    public string CompteRendu { get; set; }

    // Ces 3 propriétés étaient manquantes
    public string NatureSinistre { get; set; }      // ex : libellé de la nature
    public DateTime DateDepart { get; set; }        // autre nom de DateDebut

    public DateTime DateDebut { get; set; }         // alias clair de DateDepart
    public DateTime? DateRetour { get; set; }

    public List<string> Pompiers { get; set; }
    public List<string> Engins { get; set; }

    public MissionComplete()
    {
        Pompiers = new List<string>();
        Engins = new List<string>();
    }
}
