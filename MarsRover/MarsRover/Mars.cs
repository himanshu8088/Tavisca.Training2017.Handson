using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Mars : IPlanet<int>
    {
        private int length = 50;
        private int breadth = 50;
        int IPlanet<int>.Length
        {
            get
            {
                return length;
            }
            set
            {
                this.length = value;
            }
        }

        int IPlanet<int>.Breadth
        {
            get
            {
                return breadth;
            }
            set
            {
                this.breadth = value;
            }
        }

        bool IPlanet<int>.IsDeadEnd(int xCoordinate, int yCoordinate)
        {
            return false;
        }

        bool IDeadEnd<int>.UpEnd(int yCoordinate,int length)
        {
            if (yCoordinate > length)
                return true;
            return false;
        }
        bool IDeadEnd<int>.DownEnd(int yCoordinate)
        {
            if (yCoordinate < 0)
                return true;
            return false;
        }
        bool IDeadEnd<int>.RightEnd(int xCoordinate, int breadth)
        {
            if (xCoordinate > breadth)
                return true;
            return false;
        }
        bool IDeadEnd<int>.LeftEnd(int yCoordinate)
        {
            if (yCoordinate <0)
                return true;
            return false;
        }

    }
}
