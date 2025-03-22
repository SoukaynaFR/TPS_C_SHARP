using System;
using System.Collections.Generic;

public class Projet {
    public int Code { get; set; }
    public string Sujet { get; set; }
    public int DureeSemaines  { get; set; }

    private List<Programmeur> programmeurs;
    public List<ConsoCafe> consommations;

    


    public Projet(int code, string sujet, int dureeSemaines) {
        Code = code;
        Sujet = sujet;
        DureeSemaines = dureeSemaines;
        programmeurs = new List<Programmeur>();
        consommations = new List<ConsoCafe>();
    }

       public void AjouterProgrammeur(Programmeur p)
    {
        programmeurs.Add(p);
        Console.WriteLine($"Programmeur {p.Nom} ajouté au projet.");
    }

        public Programmeur RechercherProgrammeur(int id)
    {
        return programmeurs.FirstOrDefault(p => p.ID == id);
    }

public void AjouterProgrammeurDepuisConsole()
{
    Console.WriteLine("Ajout d'un nouveau programmeur :");

    Console.Write("ID : ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Nom : ");
    string nom = Console.ReadLine();

    Console.Write("Prénom : ");
    string prenom = Console.ReadLine();

    Console.Write("Numéro de bureau : ");
    int bureau = int.Parse(Console.ReadLine());

    Programmeur nouveauProgrammeur = new Programmeur(id, nom,prenom , bureau);
    AjouterProgrammeur(nouveauProgrammeur);
}


    public void SupprimerProgrammeur(int id)
    {
        var prog = RechercherProgrammeur(id);
        if (prog != null)
        {
            programmeurs.Remove(prog);
            Console.WriteLine($"Programmeur {prog.Nom} supprimé.");
        }
        else
        {
            Console.WriteLine("Programmeur non trouvé.");
        }
    }

    public void AfficherProgrammeurs()
    {
        Console.WriteLine("Liste des programmeurs :");
        foreach (var p in programmeurs)
        {
            p.Afficher();
        }
    }


    public void AjouterConsommation(int noSemaine, int idProgrammeur, int nbTasses)
    {
        if (RechercherProgrammeur(idProgrammeur) != null)
        {
            consommations.Add(new ConsoCafe(noSemaine, idProgrammeur, nbTasses));
            Console.WriteLine("Consommation ajoutée avec succès.");
        }
        else
        {
            Console.WriteLine("Programmeur non trouvé.");
        }
    }

    public void ModifierBureau(int id, int nouveauBureau)
    {
        var prog = RechercherProgrammeur(id);
        if (prog != null)
        {
            prog.Bureau = nouveauBureau;
            Console.WriteLine($"Bureau du programmeur {prog.Nom} mis à jour.");
        }
        else
        {
            Console.WriteLine("Programmeur introuvable.");
        }
    }
     public void AfficherConsommationProgrammeur(int idProgrammeur)
    {
        var conso = consommations.Where(c => c.IDProgrammeur == idProgrammeur).ToList();
        if (conso.Count > 0)
        {
            Console.WriteLine($"Consommation de café du programmeur {idProgrammeur} :");
            foreach (var c in conso)
            {
                Console.WriteLine($"Semaine {c.NoSemaine} : {c.NbTasses} tasses");
            }
        }
        else
        {
            Console.WriteLine("Aucune consommation enregistrée.");
        }
    }

        public void AfficherConsommationTotale()
    {
        int total = consommations.Sum(c => c.NbTasses);
        Console.WriteLine($"Consommation totale de café du projet : {total} tasses");
    }

}