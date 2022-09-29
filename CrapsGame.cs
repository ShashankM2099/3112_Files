// // Shashank Mondrati
// // Student ID: 801026182

// namespace CrapsGame{
// public class Crapsgame
// {
//     public static void Main(string[] args)
//     {

//          int total_chips = 100; 
//         int wager;
//         int dice1, dice2, total_rolls;


//         while (total_chips != 0 && true)
//         {
//                 Console.WriteLine(" Make a wager: ");
//                 wager = Convert.ToInt16(Console.ReadLine());
//                 if (wager <= totaal_chips)
//                     break;
//                 else
//                     Console.WriteLine(" Greater than you bargained you for !");
            
//             dice1 = goDiceRolll();
//             dice2 = goDiceRolll();
//             total_rolls = dice1 + dice2;
//             Console.WriteLine(" After the first roll :: " + total_rolls);

//             if (total_rolls == 2 || total_rolls == 3 || total_rolls == 12) // if 2 3 7 you lose
//             {
//                 Console.WriteLine(" YOU LOOSE.");
//                 total_chips -= wager;
//             }
//             else if (total_rolls == 7 || total_rolls == 11) // if 7 11 you WIN
//             {
//                 Console.WriteLine("You WIN THE GAME.....");
//                 total_chips += 2 * wager;
//             }
//             else if (total_rolls == 4 || total_rolls == 5 || total_rolls == 6 || total_rolls == 8 || total_rolls ==9 || total_rolls ==10)
//             {
//                 // if 4 5 6  8 9 10 eqls the SUM
//                 int point = total_rolls;
//                 while (true)
//                 {
//                     String choice;
//                     Console.WriteLine("Why dont you roll again ?? Give it another go(y/n)?");
//                     choice = Console.ReadLine();
//                     if (choice == "y")
//                     {
//                         dice1 = goDiceRolll();
//                         dice2 = goDiceRolll();
//                         total_rolls = dice1 + dice2;
//                         Console.WriteLine(" After the roll, you get:: " + total_rolls);

//                         if (total_rolls == 7)
//                         {
//                             Console.WriteLine(" You LOOSE");
//                             total_chips -= wager;
//                             break;
//                         }

//                         if (total_rolls == point)
//                         {
//                             Console.WriteLine(" VICTORYYY");
//                             total_chips += 2 * wager;
//                             break;
//                         }
//                     }
//                     else
//                         break;
//                 }
//             }
//             Console.WriteLine(" Fancy another game(y/n)? ");
//             string choice1 = Console.ReadLine();
//             if (choice1 == "y" && wager > 0)
//                 continue;
//             else
//                 break;
//         }
//         Console.WriteLine("Left with " + total_chips + " remaining.");

//     }

//     public static int goDiceRolll()
//     {
//         Random random = new Random();
//         return random.Next(1, 6);
//     }

// }
// }
