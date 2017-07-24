using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Command : ICommand,IAngle
    {
        double ICommand.Right => IAngle.Turn(0);

        double ICommand.Up => Turn(90);

        double ICommand.Left => Turn(180);

        double ICommand.Down => Turn(270);
               
        double IAngle.Turn(double degree)
        {
            return degree;
        }
    }
}
