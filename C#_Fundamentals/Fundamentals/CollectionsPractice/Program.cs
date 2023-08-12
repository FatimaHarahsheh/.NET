using System;

namespace CollectionsPractice
{
     class Program
    {
        static void Main(string[] args)
        {
            //Create an array to hold integer values 0 through 9
            int [] array ={0,1,2,3,4,5,6,7,8,9};
            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string [] names ={"Tim","Martin","Nikki","Sara"};
            //Create an array of length 10 that alternates between true and false values, starting with true
            bool [] arr={true,false};
            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> icecream = new List<string>();
            icecream.Add("strawberry");
            icecream.Add("beery");
            icecream.Add("louts");
            icecream.Add("chocolate");
            icecream.Add("dark chocolate");
            //Output the length of this list after building it
            Console.WriteLine(icecream.Count);
            //Output the third flavor in the list, then remove this value
            Console.WriteLine(icecream[3]);
            icecream.RemoveAt(3);
           // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(icecream.Count);
          //Create a dictionary that will store both string keys as well as string values
          Dictionary<string,string> dict = new Dictionary<string,string>();
          Random rand = new Random();
          for(int i =0; i<names.Length;i++){
            dict.Add(names[i],icecream[rand.Next(icecream.Count)]);
          }
        //Loop through the dictionary and print out each user's name and their associated ice cream flavor
        foreach (KeyValuePair<string,string> entry in dict)
    {
            Console.WriteLine(entry.Key + " - " + entry.Value);
    }







        }
    }
}
