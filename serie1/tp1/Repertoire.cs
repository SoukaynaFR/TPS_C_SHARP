using System;

public class Repertoire {
    private string Nom{get; set;}
    private int Nbr_fichiers;
    Fichier[] fichiers;


    public Repertoire(string nom) {
        Nom = nom;
        Nbr_fichiers = 0;
        fichiers = new Fichier[30];
    }

    public void Afficher(){
        Console.WriteLine("Nom du répertoire : " + Nom);
        Console.WriteLine("liste des fichiers : " );
        if(Nbr_fichiers == 0){
            Console.WriteLine("Aucun fichier dans ce répertoire");
            return;
        }

        for (int i = 0;i < Nbr_fichiers ; i++){
            if( fichiers[i] != null ){
                Console.WriteLine("Fichier " + (i + 1) + " : " + fichiers[i].Nom);


            }
        }
    }

    public int Rechercher(string nomFichier){
        for (int i = 0; i < Nbr_fichiers ; i++){
            if( nomFichier.Equals(fichiers[i].Nom))
            {
                return i; 
            }

    }
    return -1;
}

public void Ajouter(Fichier fichier){
    if (Nbr_fichiers < 30 ){
        fichiers[Nbr_fichiers++] = fichier;
        Console.WriteLine("Fichier" + fichier.Nom + "ajouté avec succès !");

    }
}

public void Supprimer(string nomFichier){
    int index = Rechercher(nomFichier);
    
    if (index == -1) {
        Console.WriteLine($"Le fichier '{nomFichier}' n'existe pas !");
        return;
    }

    for (int i = index; i < Nbr_fichiers - 1; i++) {
        fichiers[i] = fichiers[i + 1]; 
    }

    fichiers[Nbr_fichiers - 1] = null;
    Nbr_fichiers--;
}


}