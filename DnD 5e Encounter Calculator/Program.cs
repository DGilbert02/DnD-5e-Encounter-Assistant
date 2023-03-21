using System.Runtime.ExceptionServices;
using static DnD_5e_Encounter_Calculator.CRCalculator;
namespace DnD_5e_Encounter_Calculator
{
    internal class Program:PartyList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm the D&D Encounter Assistant, How Can I Help You Today?");
            Console.WriteLine("Press 1 to Use The Combat Rating Calulator, Press 2 to Veiw Entire Monster List");
            int Response1 = int.Parse(Console.ReadLine());
            PartyList partyList = new();
            CRCalculator cRCalculator = new();
            if (Response1 == 1)
            {
                    Console.WriteLine("How Many Members are in Your Party");
                    int numberOfMembers = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please Input the Level of Each Party Member");
                    
                    for (int i = 0; i < numberOfMembers; i++)
                    {
                        var adventurer = new Party();
                        adventurer.AdventurerLvl = int.Parse(Console.ReadLine());
                        partyList.AdventurerList.Add(adventurer);
                        Console.WriteLine("Please state the level of the next party member");
                    }
                Console.WriteLine("The Challenge Rating of the party is" + cRCalculator.CRCalc() + "!");
            }

            if (Response1 == 2)
            {
                DnD5eApiCall.InitializeAPI();
            }

            else
            {
                Console.WriteLine("Not A Valid Response");
            }
        }
    }
}