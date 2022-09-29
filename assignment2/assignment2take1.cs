/*
* Shashank M
* Student ID: 801026182
* Inventory Management System
*/
using System;
using System.IO; //input/output
using System.Collections.Generic;
class Inventory
{
    // Instance variable, 'Name'
    public String Name;
    // 'Items' stores quantity of each one of the 5 items.
    public int[] Items;
    // Constructor, creates Inventory object.
    public Inventory(int[] items, String Name)
    {
        //class name
        this.Name = Name;
        // quantity number
        this.Items = new int[5];
        for (int i = 0; i < 5; i++)
        {
            this.Items[i] = items[i];
        }
    }

    // Each inventory print.
    // think of this method as toString() in C#
    public void Print()
    {
        //Name plus item
        Console.WriteLine(this.Name);
        Console.Write(this.Items[0] + " " + this.Items[1] + " " + this.Items[2] + " " + this.Items[3] + " " + this.Items[4] + "\n\n");
    }
}

//creating a warehouse class
class Warehouses
{
    // String array to Integer array.
    private static void ParseStringToInteger(String[] strlist, int[] Items)
    {
        Items[0] = Int32.Parse(strlist[0]);
        Items[1] = Int32.Parse(strlist[1]);
        Items[2] = Int32.Parse(strlist[2]);
        Items[3] = Int32.Parse(strlist[3]);
        Items[4] = Int32.Parse(strlist[4]);
    }

    // Inventory of minimum quantity of a specified item, represented by min_quantity
    private static Inventory minInventory(Inventory one, Inventory two, Inventory three, Inventory fourth, Inventory fifth, Inventory sixth, int min_quantity)
    {
        // Calculate minimum quantity of the item in all classes.
        int min = Math.Min(one.Items[min_quantity], Math.Min(two.Items[min_quantity], Math.Min(three.Items[min_quantity], Math.Min(fourth.Items[min_quantity], Math.Min(fifth.Items[min_quantity], sixth.Items[min_quantity])))));

        // Matches the minimum quantity with the present in each inventory.
        if (min == one.Items[min_quantity])
        {
            return one;
        }
        else if (min == two.Items[min_quantity])
        {
            return two;
        }
        else if (min == three.Items[min_quantity])
        {
            return three;
        }
        else if (min == fourth.Items[min_quantity])
        {
            return fourth;
        }
        else if (min == fifth.Items[min_quantity])
        {
            return fifth;
        }
        return sixth;
    }

    // Same as 'minInventory()'  except returns the inventory with maximum quantity.
    private static Inventory maximumInventory(Inventory one, Inventory two, Inventory three, Inventory fourth, Inventory fifth, Inventory sixth, int min_quantity)
    {
        // Finding maximum quantity
        int max = Math.Max(one.Items[min_quantity], Math.Max(two.Items[min_quantity], Math.Max(three.Items[min_quantity], Math.Max(fourth.Items[min_quantity], Math.Max(fifth.Items[min_quantity], sixth.Items[min_quantity])))));
        // Return inventory == maximum quantity.
        if (max == one.Items[min_quantity])
        {
            return one;
        }
        else if (max == two.Items[min_quantity])
        {
            return two;
        }
        else if (max == three.Items[min_quantity])
        {
            return three;
        }
        else if (max == fourth.Items[min_quantity])
        {
            return fourth;
        }
        else if (max == fifth.Items[min_quantity])
        {
            return fifth;
        }
        return sixth;
    }

    // Main class.
    public static void Main(String[] args)
    {

        // Dictionary b/w item number and its min_Q in "Inventory.Items" array.
        Dictionary<String, int> mapping = new Dictionary<String, int>();
        mapping.Add("102", 0);
        mapping.Add("215", 1);
        mapping.Add("410", 2);
        mapping.Add("525", 3);
        mapping.Add("711", 4);

        //file name.
        Console.Write(":: Enter the File Name :: ");
        // Reading file name from cmd--since i used windows cmd prompt
        String inventoryFile = Console.ReadLine();
        String line;
        // Creating instances . for cities
        Inventory Atlanta, Baltimore, Chicago, Denver, Ely, Fargo, warehouse;
        // This 'Items' array will store the quantity for each item in each inventory.
        int[] Items = new int[5];
        // Trying to open inputs and read them.

        try
        {
            // Creating input  for 'Inventory.txt'.
            using (StreamReader sr = new StreamReader(inventoryFile))
            {
                // Reading data for 'Atlanta'. city
                line = sr.ReadLine();
                String[] strlist = line.Split(" ");
                ParseStringToInteger(strlist, Items);
                // Creating 'Atlanta' object.
                Atlanta = new Inventory(Items, "Atlanta");

                // Reading data for 'Baltmiore' city
                line = sr.ReadLine();
                strlist = line.Split(" ");
                ParseStringToInteger(strlist, Items);
                // Creating Object for 'Baltimore'.
                Baltimore = new Inventory(Items, "Baltimore");

                // Reading data for 'Chicago'. city
                line = sr.ReadLine();
                strlist = line.Split(" ");
                ParseStringToInteger(strlist, Items);
                // Creating 'Chicago' object.
                Chicago = new Inventory(Items, "Chicago");

                // Reading data for 'Denver'. city
                line = sr.ReadLine();
                strlist = line.Split(" ");
                ParseStringToInteger(strlist, Items);
                // Creating 'Denver' object.
                Denver = new Inventory(Items, "Denver");

                // Reading data for 'Ely'. city..wheres it again???
                line = sr.ReadLine();
                strlist = line.Split(" ");
                ParseStringToInteger(strlist, Items);
                // Creating 'Ely' object.
                Ely = new Inventory(Items, "Ely");

                // Reading data for 'Fargo'...like wells fargo?
                line = sr.ReadLine();
                strlist = line.Split(" ");
                ParseStringToInteger(strlist, Items);
                // Creating 'Fargo' object.
                Fargo = new Inventory(Items, "Fargo");
            }

            // Priting 'Inventory's' status before processing transactions.
            Console.WriteLine("<************************>");
            Console.WriteLine(":: Status of each Inventory before Transactions:: ");

            //Printing in alpha order
            Atlanta.Print();
            Baltimore.Print();
            Chicago.Print();
            Denver.Print();
            Ely.Print();
            Fargo.Print();

            // Processing transactions and printing status of updated inventory.
            Console.WriteLine("<************************>");
            Console.Write(":: Enter the Transactions file name :: ");
            // Reading transaction file name from user.
            String transactionFile = Console.ReadLine();
            // Creating stream for transaction
            using (StreamReader sr = new StreamReader(transactionFile))
            {
                // Reading transaction file line by line.
                // if file !==null
                // found on stackoverflow with the while loop
                while ((line = sr.ReadLine()) != null)
                {
                    String[] strlist = line.Split(" ");
                    // Using swith-case for diff scenarios
                    switch (strlist[0])
                    {
                        case "P":
                            // If transaction == purchasing
                            warehouse = minInventory(Atlanta, Baltimore, Chicago, Denver, Ely, Fargo, mapping[strlist[1]]);
                            warehouse.Items[mapping[strlist[1]]] += Int32.Parse(strlist[2]);
                            warehouse.Print();
                            break;
                        case "S":
                            // If transaction == selling.
                            warehouse = maximumInventory(Atlanta, Baltimore, Chicago, Denver, Ely, Fargo, mapping[strlist[1]]);
                            warehouse.Items[mapping[strlist[1]]] -= Int32.Parse(strlist[2]);
                            warehouse.Print();
                            break;
                        default:
                            Console.WriteLine(":: File contains unwanted data. ::");
                            break;
                    }
                }
            }

            // Printing Inventory's status transactions.
            Console.WriteLine("\n<********************************************>");
            Console.WriteLine(":: Status of each Inventory after Transactions :: ");
            Atlanta.Print();
            Baltimore.Print();
            Chicago.Print();
            Denver.Print();
            Ely.Print();
            Fargo.Print();

            // Catch for catching xceptions
        }
        catch (Exception ex)
        {
            //displaying a message
            Console.WriteLine(":: Cant read the File ::");
            Console.WriteLine(ex.Message);
        }
    }
}

