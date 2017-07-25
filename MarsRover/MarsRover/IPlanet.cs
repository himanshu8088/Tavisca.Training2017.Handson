using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IPlanet<T>:IDeadEnd<T>
    {
        T Length { get; set; }
        T Breadth { get; set; }
        bool IsDeadEnd(T xCoordinate,T yCoordinate);        
    }
}
