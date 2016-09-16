using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
                List<string> grocery = new List<string>();
                grocery.Add("Milk");
                grocery.Add("Eggs");
                grocery.Add("Cereal");
                grocery.Add("Steak");




            ////Convert list to Array
            //string[] arr = new string[4];
            //grocery[0] = "Milk";
            //grocery[1] = "Eggs";
            //grocery[2] = "Cereal";
            //grocery[3] =  "Steak";
            //List<string> list = new List<string>(arr);
            //Console.WriteLine(list.Count);
            //string[] convertedArray = list.ToArray();


            //Convert Array to list
            //string[] arr = new string[4];
            //arr[0] = "Honey";
            //arr[1] = "Gatorade";
            //arr[2] = "Popsicles";
            //arr[3] = "Cantalope";
            //List<string> list = new List<string>(arr);
            //Console.WriteLine(list.Count);

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.IndexOf(5);
            list.IndexOf(23);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[list.IndexOf(5)]);


        }
    }
}
