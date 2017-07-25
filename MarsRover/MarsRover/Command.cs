using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Command : ICommand
    {
        private double right=0;
        private double up = 90;
        private double left = 180;
        private double down = 270;

        double ICommand.Right {
            get
            {
                return right;
            }
            set
            {
                this.right = value;
            }
        }

        double ICommand.Up
        {
            get
            {
                return up;
            }
            set
            {
                this.up = value;
            }
        }

        double ICommand.Left
        {
            get
            {
                return left;
            }
            set
            {
                this.left = value;
            }
        }

        double ICommand.Down
        {
            get
            {
                return down;
            }
            set
            {
                this.down = value;
            }
        }

      

    }
}
