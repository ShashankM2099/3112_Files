using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Text;

namespace main
{
    public class fileIOActivity
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo shashankDir = new DirectoryInfo(@"C:\Users\sudha\fileIO");

            // Console.WriteLine(shashankDir.FullName);
            // Console.WriteLine(shashankDir.Name);
            // System.Console.WriteLine(shashankDir.Parent);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\sudha\fileIO\C#Data");
            //Directory.Delete(@"C:\Users\sudha\fileIO\C#Data");

            string[] customers = {
                "Bob Smith",
                "MR.Smith",
                "Bruce Banner",
                "The Wolverine"
            };
            string textPath = @"C:\Users\sudha\fileIO\C#Data\textFile.txt";
            File.WriteAllLines(textPath, customers);

            foreach (string cust in File.ReadLines(textPath))
            {
                System.Console.WriteLine("$Customer:" + cust);
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\sudha\fileIO\C#Data");
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            System.Console.WriteLine("Matches: {0} " , txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                System.Console.WriteLine(file.Name);
                System.Console.WriteLine(file.Length);
            }

            string textPath2 = @"C:\Users\sudha\fileIO\C#Data\textFile2.txt";
            FileStream fs = File.Open(textPath2, FileMode.Create);
            string randomString = " This is the random String - Professor X";
            byte[] rsByteArray = Encoding.Default.GetBytes(randomString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;
            byte[] fileByteArray = new byte[rsByteArray.Length];


            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            System.Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            fs.Close();

            // Stream Write and Reader
            string textPath3 = @"C:\Users\sudha\fileIO\C#Data\textFile3.txt";
            StreamWriter sw = File.CreateText(textPath3);
            sw.WriteLine("Its morbin time");
            sw.WriteLine("I am V3Nom");

            sw.Close();
            StreamReader sr = File.OpenText(textPath3);

            System.Console.WriteLine("Peek: {0}", Convert.ToChar(sr.Peek()));
            System.Console.WriteLine("1st String: {0}", sr.ReadLine());
            System.Console.WriteLine("Everything: {0}", sr.ReadToEnd());

            sr.Close();

            //Binary Writer and Reader
            string textPath4 = @"C:\Users\sudha\fileIO\C#Data\textFile4.dat";
            FileInfo datFile = new FileInfo(textPath4);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string someTxt = "This is txt to fill the file";
            int age = 22;
            double height= 5.7;

            bw.Write(someTxt);
             bw.Write(age);
              bw.Write(height);
            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            System.Console.WriteLine(br.ReadString());
            System.Console.WriteLine(br.ReadInt32());
            System.Console.WriteLine(br.ReadDouble());  
            br.Close();


            //Console.ReadLine();
        }
    }
}