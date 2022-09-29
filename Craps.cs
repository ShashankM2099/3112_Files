// /*
// * Shashank Mondrati: ITCS 3112
// */
// using System; // using clause
// namespace Craps
// { // namespace
//     public class Craps
//     { // class name
//         static void Main(string[] args) // main method
//         {

//             int total_chips = 100;  // total chips = 100
//             int wager; // wager by the yser
//             int dice1, dice2, total_rolls; // two dice rolls followed by the sum

//             while (total_chips != 0) // while total chips arent eql to 
//             {
//                 Console.WriteLine(" Make a wager: "); // user makes a wager
//                 wager = Convert.ToInt16(Console.ReadLine()); // converting it to a number as w3 said
//                 dice1 = goDiceRolll(); // method callback
//                 dice2 = goDiceRolll(); // method callback
//                 total_rolls = dice1 + dice2; // total rolls is sum of 2 rolls
//                 Console.WriteLine(" After the first roll :: " + total_rolls); // after the roll they get

//                 if (total_rolls == 2 || total_rolls == 3 || total_rolls == 12) // if 2 3 7 you lose
//                 {
//                     Console.WriteLine(" YOU LOOSE.");
//                     total_chips -= wager; // 100 - bet the user makes
//                 }
//                 else if (total_rolls == 7 || total_rolls == 11) // if 7 11 you WIN
//                 {
//                     Console.WriteLine("You WIN THE GAME.....");
//                     total_chips += 2 * wager; // total chips = total chips * two dice rolls
//                 }
//                 else if (total_rolls == 4 || total_rolls == 5 || total_rolls == 6 || total_rolls == 8 || total_rolls == 9 || total_rolls == 10)
//                 {
//                     // if 4 5 6  8 9 10 eqls the SUM by the method goDiceRolll

//                     while (true) // while true
//                     {
//                         int point = total_rolls;
//                         string choice; // to get the choice y/n
//                         Console.WriteLine("Why dont you roll again ?? Give it another go(y/n)?"); // asking the user to get their input if they want to roll or not
//                         choice = Console.ReadLine(); // storing in a variable
//                         if (choice.Equals("y")) // if the choice is y for yes
//                         {
//                             dice1 = goDiceRolll(); // method call back for randomizing dice rolls
//                             dice2 = goDiceRolll(); // method call back for randomizing dice rolls
//                             total_rolls = dice1 + dice2; // combining dice rools
//                             Console.WriteLine(" After the roll, you get:: " + total_rolls); // displaying

//                             if (total_rolls == 7) // if 7 you lose
//                             {
//                                 Console.WriteLine("You LOSE");
//                                 total_chips -= wager;
//                                 Console.WriteLine("Chips left: " + total_chips);
//                                 break;
//                             }

//                             if (total_rolls == point) // if rolls eqls the point or the sums u win
//                             {
//                                 Console.WriteLine("VICTORYYY");
//                                 total_chips += 2 * wager;
//                                 Console.WriteLine("Won with " + total_chips + " chips left.");
//                                 break;
//                             }
//                         }
//                         else
//                             break;
//                     }
//                 }
//                 Console.WriteLine(" Fancy another game(y/n)? "); // asking for another game
//                 string choice1 = Console.ReadLine(); // storing in another variable
//                 if (choice1 == "n") // if choice is n for No
//                 {
//                     Console.WriteLine("Left with " + total_chips + " remaining. \nThanks for playing! "); // remaining chips
//                     break;
//                 }
//             }
//         }

//         public static int goDiceRolll() // method to calculate random dice rolls
//         {
//             Random diceRoll = new Random(); // using a random variable
//             return diceRoll.Next(1, 6); // to calc chips math.random (max-min)+1 from java
//         }

//     }
// }
