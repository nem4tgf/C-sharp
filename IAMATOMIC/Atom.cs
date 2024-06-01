using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAMATOMIC
{
    public class Atom
    {
        
   public int AtomicNumber { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public double AtomicWeight { get; set; }

    public Atom(int atomicNumber, string symbol, string name, double atomicWeight)
    {
        AtomicNumber = atomicNumber;
        Symbol = symbol;
        Name = name;
        AtomicWeight = atomicWeight;
    }
}

class Program
{
    static void Main()
    {
        List<Atom> atoms = new List<Atom>();
        int maxAtoms = 10;

        Console.WriteLine("Atomic Information");
        Console.WriteLine("==================");

        for (int i = 0; i < maxAtoms; i++)
        {
            Console.Write("Enter atomic number (0 to stop): ");
            if (!int.TryParse(Console.ReadLine(), out int atomicNumber) || atomicNumber == 0)
            {
                break;
            }

            Console.Write("Enter symbol: ");
            string symbol = Console.ReadLine();

            Console.Write("Enter full name: ");
            string name = Console.ReadLine();

            Console.Write("Enter atomic weight: ");
            if (!double.TryParse(Console.ReadLine(), out double atomicWeight))
            {
                Console.WriteLine("Invalid input. Please enter numeric values for atomic weight.");
                i--; // Decrement i to retry the same entry
                continue;
            }

            atoms.Add(new Atom(atomicNumber, symbol, name, atomicWeight));
        }

        Console.WriteLine("\nNo  Sym Name     Weight");
        Console.WriteLine("------------------------------------");
        foreach (var atom in atoms)
        {
            Console.WriteLine($"{atom.AtomicNumber,-4} {atom.Symbol,-3} {atom.Name,-8} {atom.AtomicWeight,-8:F3}");
        }
    }
}
}