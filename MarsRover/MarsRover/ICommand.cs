using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface ICommand
    {
        double Up { get; }
        double Down { get; }
        double Left { get; }
        double Right { get; }
    }
}
