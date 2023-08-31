using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuUtente1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> menuItems = new List<string>
            {
                "Coca Cola 150 ml (€ 2.50)",
                "Insalata di pollo (€ 5.20)",
                "Pizza Margherita (€ 10.00)",
                "Pizza 4 Formaggi (€ 12.50)",
                "Pz patatine fritte (€ 3.50)",
                "Insalata di riso (€ 8.00)",
                "Frutta di stagione (€ 5.00)",
                "Pizza fritta (€ 5.00)",
                "Piadina vegetariana (€ 6.00)",
                "Panino Hamburger (€ 7.90)"
            };

            List<double> prices = new List<double>
            {
                2.50, 5.20, 10.00, 12.50, 3.50, 8.00, 5.00, 5.00, 6.00, 7.90
            };

            List<int> selectedItems = new List<int>();

            while (true)
            {
                Console.WriteLine("=========MENU=========");
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {menuItems[i]}");
                }
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("=========MENU=========");

                Console.Write("Seleziona un numero di cibo (1-11): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 11)
                {
                    Console.WriteLine("Conto finale:");
                    double totalCost = 3.00;
                    foreach (int itemIndex in selectedItems)
                    {
                        Console.WriteLine($"{menuItems[itemIndex - 1]}");
                        totalCost += prices[itemIndex - 1];
                    }
                    Console.WriteLine($"Costo finale comprensivo di servizio: € {totalCost:F2}");
                    break;
                }
                else if (choice >= 1 && choice <= 10)
                {
                    selectedItems.Add(choice);
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Riprova.");
                }
            }
        }
    }
}
