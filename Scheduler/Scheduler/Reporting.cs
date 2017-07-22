using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingScheduler
{
    class Reporting
    {
        Plan p;
        public Reporting(Plan p)
        {
            this.p = p;
        }
        public void CheckStatus()
        {
            foreach(ToDoList toDo in p.GetToDoList())
            {
                if (toDo.actualCompletionDate.Equals(toDo.completionDate))
                {
                    Console.WriteLine("Task:"+toDo.taskAssigned+" Completed On Time");
                }
                else
                {
                    Console.WriteLine("Task:" + toDo.taskAssigned + "Not Completed On Time");
                }
            }
        }
    }
}
