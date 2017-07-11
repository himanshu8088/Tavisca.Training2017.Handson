using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockSolution
{
    public class Clock
    {
        private double theta;
        private double cal_theta;        
        private string MatchedTimeList;

        public Clock(double theta)
        {
            this.theta = theta;
        }

        public string GetListOfTimeMatched()
        {
            double increment=0;
            if (theta < 30)
                increment = 0.25f;
            else
                increment = 1;
            for(int hh = 1; hh <= 12; hh++)
            {                
                for (double mm = 0; mm <= 59; mm+=increment)
                {                    
                    cal_theta = EvaluatePossibleAngle(hh, mm);                   
                    if (cal_theta == theta || 360-cal_theta==theta)
                    {
                        MatchedTimeList += "\n\n" + hh + ":" + mm + "\ntheta:" + cal_theta;
                    }
                }
            }
            return MatchedTimeList;
        }

        private double EvaluatePossibleAngle(int hh,double mm)
        {
            double hour_hand_angle_with_ref = 0.5 * hh * 60;
            double minute_hand_angle_with_ref = mm * 6;
            double angle_between_hour_and_minute = hour_hand_angle_with_ref - minute_hand_angle_with_ref;
            return angle_between_hour_and_minute;
        }            
    }
}
