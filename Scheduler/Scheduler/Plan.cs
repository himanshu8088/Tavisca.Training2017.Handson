using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingScheduler
{
    struct ToDoList
    {
        public string taskAssigned;
        public string assignDate;
        public string completionDate;        
        public int noOfPeopleAllocated;
        public string actualCompletionDate;
    }
    class Plan
    {
        private List<ToDoList> taskList;

        public Plan()
        {
            taskList = new List<ToDoList>();
        }
        public List<ToDoList> GetToDoList()
        {
            return taskList;
        }
        public void SetToDoList(string task_Assigned,string assign_Date,string completion_Date,int no_Of_People_Allocated)
        {
            ToDoList taskEntry = new ToDoList();
            taskEntry.taskAssigned = task_Assigned;
            taskEntry.assignDate = assign_Date;
            taskEntry.completionDate = completion_Date;
            taskEntry.noOfPeopleAllocated = no_Of_People_Allocated;
            taskEntry.actualCompletionDate = "";
            taskList.Add(taskEntry);            
        }        
        public void SetActualCompletionDate(string task, string date)
        {
           for(int iterator=0;iterator<taskList.Count;iterator++)
           {
                ToDoList toDo = taskList[iterator];
                if (toDo.taskAssigned.Equals(task))
                    toDo.actualCompletionDate = date;
                taskList[iterator] = toDo;
           }
        }
    }
}
