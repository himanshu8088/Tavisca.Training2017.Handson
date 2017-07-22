using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingScheduler
{
    class Schedule
    {
        Plan p;
        public Schedule(Plan p)
        {
            this.p = p;
            SchedulePlan();
        }
        public void SchedulePlan()
        {
            Console.WriteLine("To provide training plan press any key.\nTo to go to main application press (-1).");            
            string wantToContinue = Console.ReadLine();           
            while (wantToContinue != "-1")
            {
                Console.WriteLine("Please Provide plan in following format:\n<task name>,<date of assignment>,<date of completion>,<number of people assigned>");
                string[] input = Console.ReadLine().Split(',');
                p.SetToDoList(input[0],input[1], input[2],int.Parse(input[3]));
                Console.WriteLine("To add another plan press any key.\nTo to go to main application press (-1).");
                wantToContinue = Console.ReadLine();
            }
        }
    }
}
