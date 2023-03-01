using System.Runtime.ExceptionServices;

namespace DnD_5e_Encounter_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm the D&D Encounter Assistant, How Can I Help You Today?");
            Console.WriteLine("Press 1 to Use The Combat Rating Calulator, Press 2 to Veiw Entire Monster List");
           // string Response1 = new Response1;
            string Response1 = Console.ReadLine();
            if (Response1 = 1)
            {
                CR_Calc
            }
            if (Response1 = 2)
            {

            }
            else
            {
                Console.WriteLine("Not A Valid Response");
            }
        }
    }
}