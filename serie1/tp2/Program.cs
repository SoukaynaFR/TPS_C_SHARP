using System;

class Program
{
    static void Main()
    {
        Projet projet = new Projet(1, "Développement d'une application mobile", 10);
        projet.AjouterProgrammeurDepuisConsole();


        projet.AjouterProgrammeur(new Programmeur(1, "Halim", "Ahmed", 205));
        projet.AjouterProgrammeur(new Programmeur(2, "Bakali", "Anass", 123));

        projet.AfficherProgrammeurs();

        projet.ModifierBureau(1, 300);
        projet.AfficherProgrammeurs();

        projet.AjouterConsommation(1, 1, 5);
        projet.AjouterConsommation(2, 1, 6);
        projet.AjouterConsommation(1, 2, 3);

        projet.AfficherConsommationProgrammeur(20);

        projet.AfficherConsommationTotale();
    }
}
