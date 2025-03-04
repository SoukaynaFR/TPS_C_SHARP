using System;

public class Programmeur{

    public int ID { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Bureau { get; set; }

public Programmeur(int id , string nom , string prenom , int bureau){
    this.ID= id;
    this.Nom= nom;
    this.Prenom= prenom;
    this.Bureau= bureau;
}


    public void Afficher() {
        Console.WriteLine($" ID:  {this.ID}  , Nom: {this.Nom} , Prenom: {this.Prenom} , Bureau: {this.Bureau}");
        }


}