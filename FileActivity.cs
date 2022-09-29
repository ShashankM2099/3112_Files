/*
* Shashank M
* Student ID: 801026182
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file // namespace
{
    class classes // class
    {
        public static void Main(string[] args) // main method
        {
            int[] arr = { 0 };
            //creating pathways to find the file
            FileStream fileStream = new FileStream(@"C:\Users\sudha\FileAct\Numbers.txt", FileMode.OpenOrCreate);
            FileStream fileEven = new FileStream(@"C:\Users\sudha\FileAct\Even.txt", FileMode.OpenOrCreate);
            FileStream fileOdd = new FileStream(@"C:\Users\sudha\FileAct\Odd.txt", FileMode.OpenOrCreate);

            //creating readers to read the file
            StreamReader streamReader = new StreamReader(fileStream);
            StreamWriter streamEven = new StreamWriter(fileEven);
            StreamWriter streamOdd = new StreamWriter(fileOdd);

            //numberline and sr's number line starting at the top
            string numberLine;
            int i = 0; // index 
            while ((numberLine = streamReader.ReadLine()) != null)
            {
                arr[i] = Convert.ToInt32(numberLine);
                // if the numbers are divisble are 2 they are even
                if (arr[i] % 2 == 0)
                {
                    //writing to even
                    streamEven.WriteLine(arr[i]);
                }
                // else they are odd by not divisible by 2
                else //if (arr[i] % 2 != 0)
                {
                    //writing to odd
                    streamOdd.WriteLine(arr[i]);
                }
            }
            //After running close the file reader and writer
            streamEven.Close();
            streamOdd.Close();
            streamReader.Close();
            fileStream.Close();

            System.Console.WriteLine("Check the files"); // telling the user to check the files

            Console.ReadLine(); // idk why i put this from the video
        }
    }
}
