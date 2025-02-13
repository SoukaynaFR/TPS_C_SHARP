using System;

public class Fichier {
    public string Nom { get; set; }
    public string Extension { get; set; }
    public float Taille { get; set; }

    public Fichier(string nom, string extension, float taille) {
        Nom = nom;
        Extension = extension;
        Taille = taille;
    }
    public void Afficher(){
        Console.WriteLine($"Nom : {Nom}, Extension : {Extension}, Taille : {Taille} Mo");
    }


}