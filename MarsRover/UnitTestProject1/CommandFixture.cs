using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using MarsRover;
namespace MarsRoverFixture
{
    public class CommandFixture
    {
        [Fact]
        public void Move_left_At_0_Degree()
        {
            ICommand command = new Command();
            IAngle angle = command;
            command.Right;

        }
    }
}
