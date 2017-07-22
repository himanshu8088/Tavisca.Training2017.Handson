using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingScheduler
{
    class Tracking
    {
       Plan p;
       public Tracking(Plan p)
       {
            this.p = p;
       } 
       public void UpdateCompletionDate(string task, string date)
       {
            p.SetActualCompletionDate(task, date);
       }
    }
}
