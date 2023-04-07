using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using Xceed.Wpf.Toolkit;
using static DnD_5e_Encounter_Calculator.CRCalculator;
using static DnD_5e_Encounter_Calculator.PartyList;
//using static DnD_5e_Encounter_Calculator.DnD5eApiCall;
namespace DnD_5e_Encounter_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                //DnD5eApiCall.InitializeAPI();
                Console.WriteLine("Hello I'm the D&D Encounter Assistant, How Can I Help You Today?");
                Console.WriteLine("Press 1 to Use The Combat Rating Calulator, Press 2 to exit");
                int Response1 = int.Parse(Console.ReadLine());
                PartyList partyList = new();
                CRCalculator cRCalculator = new();
                if (Response1 == 1)
                {
                    bool calcRun = true;
                    while (calcRun == true && run == true)
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
                        double PartyCR = cRCalculator.CRCalc(partyList.AdventurerList);
                        Console.WriteLine("The Challenge Rating of the party is " + PartyCR + "!");

                        Console.WriteLine("Would you like to veiw the list of equivilent teir monsters[1], exit to the begining[2], or calcutate the challenge rating of a different party[Any Button(besides 1 or 2)]?");
                        int Response2 = int.Parse(Console.ReadLine());
                        if (Response2 == 1) 
                        {
                            ApiSorter.MonsterSorter(PartyCR);
                            Console.WriteLine("");
                            Console.WriteLine("Would you like to exit to the begining[1] or to calcutate the challenge rating of a different party[Any Button(besides 1)]?");
                            int Response3 = int.Parse(Console.ReadLine());
                            if (Response3 == 1) 
                            {
                                calcRun = false;
                            }
                            
                            //Console.WriteLine("");
                            //Console.WriteLine("Would you like to veiw the stats of a particular monster[1], or exit to the start[2]?");
                            //int Response3 = int.Parse(Console.ReadLine());
                            //if (Response3 == 1)
                            //{
                            //    Console.WriteLine("Please input the name of the monster you wish to view.");
                            //    string name = Console.ReadLine();
                            //    //Console.WriteLine(monster);
                            //}
                            //else if (Response3 == 2)
                            //{

                            //}
                            //else
                            //{
                            //    Console.WriteLine("Not A Valid Response");
                            //}
                        }
                        else if (Response2 == 2)
                        {
                            calcRun = false;
                        }
                    }
                }

                else if (Response1 == 2)
                {
                    run = false;
                }

                else
                {
                    Console.WriteLine("Not A Valid Response");
                }
            }
        }
    }
}