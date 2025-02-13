using System;

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Alice", 5000, "Développeur", new DateTime(2020, 5, 1));
        Employee emp2 = new Employee("Bob", 4000, "Analyste", new DateTime(2021, 6, 15));
        Employee emp3 = new Employee("Charlie", 6000, "Manager", new DateTime(2019, 8, 30));

        GestionEmployes gestion = new GestionEmployes();
        gestion.AddEmployee(emp1);
        gestion.AddEmployee(emp2);
        gestion.AddEmployee(emp3);

        Directeur directeur = Directeur.GetInstance();
        directeur.SetGestionEmployes(gestion);
        directeur.DisplayCompanyInfo();
    }
}
