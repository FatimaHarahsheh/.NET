using System;

namespace BoxingUnboxing

{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty List of type object
            List<object> obj = new List<object>();
            //Add the following values to the list: 7, 28, -1, true, "chair"
            obj.Add(7);
            obj.Add(28);
            obj.Add(-1);
            obj.Add(true);
            obj.Add("chair");
            //Loop through the list and print all the values
            for (int i = 0; i < obj.Count; i++)
            {
                Console.WriteLine(obj[i]);
            }
            //Add all values that are Int type together and output the sum (Hint: Type Inference might help here!)
            int sum =0;
              for (int i = 0; i < obj.Count; i++)
            {
                
                if (obj[i].GetType()==typeof(int)){
                    sum+=(int)obj[i];
                }
               
            } Console.WriteLine(sum);
        }
    }
}
