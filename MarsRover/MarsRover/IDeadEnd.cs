using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IDeadEnd<U>
    {
       bool UpEnd(U yCoordinate,U length);
       bool DownEnd(U yCoordinate);
       bool LeftEnd(U xCoordinate);
       bool RightEnd(U xCoordinate, U breadth);        
    }
}
