using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrainingScheduler
{
    class Program
    {
        static Schedule schedule;
        static Tracking track;
        static Reporting report;
        static void Main(string[] args)
        {
            Plan p = new Plan();
            Console.WriteLine("To schedule press 1\nTo Track press 2\nTo Report press 3");
            int choice=int.Parse(Console.ReadLine());

            while(choice>=1 && choice <= 3)
            {
                if (choice == 1)
                    schedule = new Schedule(p);
                if (choice == 2)
                {
                    track = new Tracking(p);
                    Console.WriteLine("Please provide task and actual completion date separeted by (,):");
                    string[] trackingData = Console.ReadLine().Split(',');
                    track.UpdateCompletionDate(trackingData[0],trackingData[1]);
                }                    
                if (choice == 3)
                {
                    report = new Reporting(p);
                    report.CheckStatus();
                }
                    

                Console.WriteLine("To schedule press 1\nTo Track press 2\nTo Report press 3");
                choice = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
