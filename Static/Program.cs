using Static.Static;

namespace Static
{
    public class Program
    {
        public static void Main()
        {
            
            
            int result = Calculation.Add(5, 6);
            Console.WriteLine("Addition: "+result);  
            
             result = Calculation.Sub(5, 4);
            Console.WriteLine("Subtraction: "+result);  
        }
    }
}