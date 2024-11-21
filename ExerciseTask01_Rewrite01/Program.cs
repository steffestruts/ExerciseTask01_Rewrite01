using System.Collections.Generic;

/* Typ 50/50 på Chatgpt-kod - Kommentar från originalappen. Gjort så du kan ta bort. */

List<string> ShoppingList = new List<string>();
Console.WriteLine("Välkommen till din shoppinglista3000! \n");
Console.WriteLine("Skriv in produkter du vill lägga till, behöver du ta bort får du göra klart listan.\n");
Console.WriteLine("Du kan skriva klar för visa listan.\n");

// Loopar igenom tills avslutningsord är skrivet
while (true)
{
    // Uppmanar användaren att skriva produkter till listan
    Console.Write("Inmatning: ");
    string ShoppingItem = Console.ReadLine()!;

    // Skriver användaren "mätt" eller "klar" visas färdiga listan och sen avslutas inmatningen
    if (ShoppingItem.ToLower() == "klar")
    {
        Console.Clear();
        Console.WriteLine("Klar med inmatningen. Din slutgiltiga lista: \n");
        break;
    }
    // Lägger till i listan
    ShoppingList.Add(ShoppingItem);
}

// Skriver ut listan efter användaren har skrivit avslutningsord
foreach (string Shopping in ShoppingList)
{
    Console.WriteLine("- " + Shopping);
}

// Andra delen av programmet - Ta bort en produkt
while (true)
{
    // Skriv produktens namn för ta bort den
    Console.WriteLine("Skriv in namnet på produkten som du vill ta bort. För att avsluta: skriv sluta. \n");
    string ShoppingItem = Console.ReadLine()!;

    // Avslutningsord: sluta eller nej
    if (ShoppingItem.ToLower() == "sluta")
    {
        Console.Clear();
        Console.WriteLine("Klar med inmatningen. Så ser listan ut efter ändringarna: \n");
        break;
    }
    // Tar bort förmålet som blev inskrivet
    ShoppingList.Remove(ShoppingItem);
}

// Visar nya listan
foreach (string Shopping in ShoppingList)
{
    Console.WriteLine("- " + Shopping);
}

Console.ReadKey();