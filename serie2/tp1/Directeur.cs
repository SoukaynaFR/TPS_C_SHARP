using System;

public class Directeur
{
    private static Directeur instance = null!;
    private GestionEmployes gestionEmployes;

    private Directeur()
    {
        gestionEmployes = new GestionEmployes();
    }

    public static Directeur GetInstance()
    {
        if (instance == null)
        {
            instance = new Directeur();
        }
        return instance;
    }

    public GestionEmployes GetGestionEmployes()
    {
        return gestionEmployes;
    }

    public void SetGestionEmployes(GestionEmployes newGestionEmployes)
    {
        gestionEmployes = newGestionEmployes;
    }

    public void DisplayCompanyInfo()
    {
        Console.WriteLine($"Salaire total de l'entreprise : {gestionEmployes.CalculateTotalSalary()}");
        Console.WriteLine($"Salaire moyen des employés : {gestionEmployes.CalculateAverageSalary()}");
    }
}
