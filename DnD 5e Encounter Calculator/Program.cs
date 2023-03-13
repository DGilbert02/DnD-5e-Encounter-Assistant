using System.Runtime.ExceptionServices;

namespace DnD_5e_Encounter_Calculator
{
    public class Program:PartyList
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello I'm the D&D Encounter Assistant, How Can I Help You Today?");
            Console.WriteLine("Press 1 to Use The Combat Rating Calulator, Press 2 to Veiw Entire Monster List");
            int Response1 = int.Parse(Console.ReadLine());

            if (Response1 == 1)
            {
                    Console.WriteLine("How Many Members are in Your Party");
                    int numberOfMembers = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please Input the Level of Each Party Member");

                    for (int i = 0; i < numberOfMembers; i++)
                    {
                        var adventurer = new Party();
                        Console.WriteLine("Please state the level of the next party member");
                        adventurer.AdventurerLvl = int.Parse(Console.ReadLine());
                        AdventurerList.Add(adventurer);
                    }
            }

            if (Response1 == 2)
            {
                Console.WriteLine("Not currently implimented.");
                //DnD5eApiCall.InitializeAPI();
            }

            else
            {
                Console.WriteLine("Not A Valid Response");
            }
        }
    }
}