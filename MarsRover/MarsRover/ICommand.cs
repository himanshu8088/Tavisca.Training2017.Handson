using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface ICommand
    {
        double Up { get; set; }
        double Down { get; set; }
        double Left { get; set; }
        double Right { get; set; }
    }
}
