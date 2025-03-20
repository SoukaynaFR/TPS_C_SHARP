using System;
using System.Collections.Generic;

public class NewRepertoire{
    public string Nom{get; set; }
    public int Nbr_fichiers{get; set;}
    private list<NewFichier> newFichiers;

    public NewRepertoire(string nom){
        Nom = nom;
        Nbr_fichiers = 0;
        newFichiers = new List<NewFichier>();
    }

    public NewRepertoire(string nom){
        this.Nom = nom;
        this.Nbr_fichiers = 0;
        newFichiers = new List<NewFichier>();
    }

    public void Afficher(){
        Console.WriteLine( "Le repertoire:" + this.Nom +"Contient les fichiers suivants:" )
        if(this.Nbr_fichiers>0){
            for( int i=0 ; i < Nbr_fichiers ; i++){
                if (newFichiersichiers[i] != null)
                Console.WriteLine( $"Fichier {i+1} : {newFichiers[i].Nom}");
            }
        }
        Console.WriteLine("Le repertoire est vide");
    }

    public int Rechercher(string nomFichier){
        if (this.Nbr_fichiers>0){
            for ( int i = 0 ; i < Nbr_fichiers ; i++){
                if(newFichiers[i] != null && newFichiers[i].Nom == nomFichier)
                return i;
            }
            return -1;
        }
    }

    public void Ajouter(NewFichier fich){
        if( Nbr_fichiers < 30)
        newFichiers.add(fich);
         else
            Console.WriteLine("Le répertoire est plein !")
    }

    public void AfficherPDF(){
        if(Nbr_fichiers>0)
        foreach ( var fichier in newFichiers){
            if (fichier.extension == "pdf")
            Console.Writeline($" {fichier.Nom}.{fichier.Extension} - {fichier.Taille} KO")
        }
    }


    public void Supprimer(string nomFichier){
         int index = Rechercher(nom);
         if (index != -1)

            newFichiers.removeAt(index);
              else
            Console.WriteLine("Fichier introuvable !");

    }

    public void Renommer(string nvNom){
this.Nom = nvNom;
    }


        public void Modifier(float nvlTaille){
             int index = Rechercher(nom);
        if (index != -1)
            fichiers[index].Taille = nouvelleTaille;
        else
            Console.WriteLine("Fichier introuvable !");
        }


        public float getTaille(){
            float tailleTotalle = 0;
            if (Nbr_fichiers > 0){
                foreach ( var fichier in newFichiers){
                    tailleTotalle += fichier.Taille;
                }
            }
            Console.WriteLine("Le repertoire est vide");
             return tailleTotalle/1024;
        }
    


}