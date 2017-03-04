using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileWordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText("File.txt"); 
            //string enteredText;
            int countedText;
            char[] stringSpliter = new char[] {' ','\n','\r'};

            Console.WriteLine("Welcome to the Word Counter Program!");
            //Console.WriteLine("\nPlease Enter some Text below:");
            //enteredText = Console.ReadLine();
            string fileString = reader.ReadToEnd();


            countedText = fileString.Split(stringSpliter, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine(countedText);
            //Console.WriteLine(fileString);

            Console.ReadKey();
        }
    }
}




