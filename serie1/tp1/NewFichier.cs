using System;
public class NewFichier{

    public string Nom{get; set; }
    public string Extension { get; set; }
    public float Taille { get; set; }

    public NewFichier(string nom , string extension , float taille){
        this.Nom= nom;
        this.Extension= extension;
        this.Taille= taille;
    }

    public override string ToString(){
        return $"{Nom}.{Extension} - {Taille} KO";
    }
}