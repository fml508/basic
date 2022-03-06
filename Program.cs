using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot hogy meddig írja ki a program a számokat");
            int p;
            p = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < p+1; i++)
            {

                Console.Write($"|{i}|");
            }
            int pozitiv;
            do
            {
                Console.WriteLine("\nAdjon meg egy pozitív számot");
                pozitiv = Convert.ToInt32(Console.ReadLine());

            } while (pozitiv % 2 !=0);
            Console.WriteLine(pozitiv);

            Console.WriteLine("Adjon egy számot 1-3 ig");
            int switchszam;
            switchszam = Convert.ToInt32(Console.ReadLine());
            int szamolas;
            switch (switchszam)
            {
                case 1:
                    Console.WriteLine("Adja meg a számot amit 2 vel szeretne osztani.");
                    int case1;
                    case1 = Convert.ToInt32(Console.ReadLine());
                    szamolas = case1 / 2 ;
                    Console.WriteLine($"{case1} / 2 ={szamolas}");
                    break;
                
                case 2:
                    Console.WriteLine("Adja meg a számot amit 3 al szeretne osztani.");
                    int case2;
                    case2 = Convert.ToInt32(Console.ReadLine());
                    szamolas = case2 / 3;
                    Console.WriteLine($"{case2} / 3 = {szamolas}");
                    break;
                
                case 3:
                    Console.WriteLine("Adja meg a számot amit 4 el szeretne osztani.");
                    int case3;
                    case3 = Convert.ToInt32(Console.ReadLine());
                    szamolas = case3 / 4;
                    Console.WriteLine($"{case3} / 4 = {szamolas}");
                    break;
            }

            string username;
            int age;
            string gender;

            Console.Write("Name:");
           username = Console.ReadLine();

            Console.Write("Age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender:");
            gender = Console.ReadLine();

            Console.WriteLine($"Your name is {username} also your age is {age} and your gender is {gender}");

            Console.WriteLine("Enter a number between 120-1000");
            int number;                                             //number integer 
            do                                                      //do while for number input
            {
                 number = Convert.ToInt32(Console.ReadLine());     //Convert.ToInt32 for while we get the input instantly converting into integer instead of string 
            } while (number < 120 || number > 1000);               //while the given number is not between 12 and 1000 keeps repeating do
            Console.WriteLine("\n",number);                             //writing  out just to check 


            List<int> numbers = new List<int>();                   //we create a list List<int> anything = new List<int>(); 
            Random random = new Random();                          //we create our random generator (this named random)
            for (int i = 0; i < number; i++)
            {
                numbers.Add(random.Next(120, 1000));              //numbers.Add <-- adding to the list - (numbers) - random.Next(120,1000) <-- here we creating a random number between 12|1000 

            }

            for (int i = 0; i < numbers.Count; i++)       //numbers.Count <--- Counting the list elements
            {
                Console.Write($"{numbers[i]}, ");         //numbers[i]   <--- write out the list elements one by one
            }



            for (int a = 0; a < numbers.Count;  a++)             //counting the list elements and if a lower then numbers.Count then add + to a 
            {
                if (numbers[a] < 200 && numbers[a] > 600)        //checking the list number that was counted to the a integer numbers[a] if it is between 200 600
                {
                    int valuesb = 0;                             //integer with value = 0
                    valuesb = valuesb + numbers[a];              //create we pass the given number to our separate integer
                    Console.WriteLine(valuesb);                  //we write out the final number
                }
                
            }
            int z = 0;                                          //create a z named integer
            for (int i = 0; i < numbers.Count; i++)             //count the list elements
            {
                if (numbers[i] % 3 != 0)                        //cheching if the list elements are divisible by 3 
                {

                    z++;                                        //if it's true give z +1
                }
                
            }
            Console.WriteLine($"a listaban ennyi 3al nem oszthato szam van: {z}");

            int min = numbers[0];                              //min integer equal to the list [0] elements
            int max = numbers[0];                              //max integer equal to the list [0] elements
            for (int i = 0; i < numbers.Count; i++)            //List elements count
            {
                if (min > numbers[i])                         //if min > then numbers[i]
                {
                    min = numbers[i];                        //set min to numbers[i]
                    
                }
               
            
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (max < numbers[i])                       //if max < then numbers[i]
                {
                    max = numbers[i];                       //set min to numbers[i]

                }
            }
            Console.WriteLine($"A minimum érték {min} , a maximum pedig: {max}");


            List<int> odd = new List<int>();
            int odd1 = odd[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i)
                {

                }
            }
           

            List<int> paros = new List<int>();







            Console.ReadKey();
        }
    
    }
}
