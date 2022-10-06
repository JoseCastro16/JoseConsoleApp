// See https://aka.ms/new-console-template for more information
using System;

// Interface
interface IReyna
{
     string this[int index] { get; set; } // indexer declaration
     string? Ability1 { get; set; } // Property
     string? getAbility2(); // Instance Method  

     void setAbility2(string str1); // Intance Method

     string? Ability3 { get; set; } // Property

    string? Ultimate { get; set; } // Property
    void ReynaAbilities(); // Interface method 

    void WeaponList(); // Interface method
}

class Valorant : IReyna
{
    private string[] weaponList = new string[10]; // indexer

    public string this[int index] // indexer declaration
    {
        get
        {
            return weaponList[index];
        }
        set
        {
            weaponList[index] = value;
        }
    }

    private string? Ability2; // Instance

    public string? Ability1 { get; set; } // Property

    public string? Ability3 { get; set; } // Property

    public string? Ultimate { get; set; } // Property

    public string? getAbility2() // Instance Method
    {
        return this.Ability2;
    }

    public void setAbility2(string str1) // Instance Method
    {
        Ability2 = str1;
    }
    public void ReynaAbilities() // Interface Methof
    {
        
        Console.WriteLine(Ability1);
        Console.WriteLine(Ability2);
        Console.WriteLine(Ability3);
        Console.WriteLine(Ultimate);
    }

    public void WeaponList()
    {
        for(int i = 0; i < weaponList.Length; i++)
        {
            Console.Write(" " + weaponList[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Valorant reyna = new Valorant();  // Create a Valorant Object
        reyna[0] = "Vandal";
        reyna[1] = "Phantom";
        reyna[2] = "Spectre";
        reyna.Ability1 = "Ability 1: Leer";
        reyna.setAbility2("Ability 2: Dismiss");
        reyna.Ability3 = "Ability 3: Devour";
        reyna.Ultimate = "Ultimate: Empress";
        reyna.ReynaAbilities();
        Console.WriteLine("Weapons Used: ");
        reyna.WeaponList();
    }
}

// create a console app with a class that has an interface and push it to a git repo! Send me the link to the repo when done. 
// Your class should have at least one interface and three different types of properties 

// The interface (and therefore, your class) should have at least three out of these four things:

// instance methods, properties, events, indexers

// Make sure you have an instance of this class in main
