using System;

class Program {
    static void Main() {

        Repertoire monRepertoire = new Repertoire("Documents");

        Fichier fichier1 = new Fichier("rapport", "pdf", 1.2f);
        Fichier fichier2 = new Fichier("photo", "jpg", 3.5f);
        Fichier fichier3 = new Fichier("code", "cs", 0.5f);

        monRepertoire.Ajouter(fichier1);
        monRepertoire.Ajouter(fichier2);
        monRepertoire.Ajouter(fichier3);

        monRepertoire.Afficher();

        // Rechercher
        string nomRecherche = "photo";
        int index = monRepertoire.Rechercher(nomRecherche);
        Console.WriteLine(index != -1 ? $"Le fichier '{nomRecherche}' est à l'index {index}." : $"Le fichier '{nomRecherche}' n'existe pas.");

        monRepertoire.Supprimer("photo");

        monRepertoire.Afficher();

        Console.WriteLine($"Taille totale du répertoire : {monRepertoire.GetTaille()} Mo");
    }
}
