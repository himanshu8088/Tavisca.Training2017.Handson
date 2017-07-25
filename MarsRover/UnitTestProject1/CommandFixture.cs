using System;
using Xunit;
using MarsRover;
namespace MarsRoverFixture
{
    public class CommandFixture
    {
       ICommand command;        

        [Fact]
        public void Turn_left_At_0_Degree()
        {
            command = new Command();
            double actualAngle = command.Left;
            double expectedAngle = 180;
            Assert.True(expectedAngle==actualAngle);
        }

        [Fact]
        public void Turn_right_At_180_Degree()
        {
            command = new Command();
            double actualAngle = command.Right;
            double expectedAngle = 0;
            Assert.True(expectedAngle == actualAngle);
        }

        [Fact]
        public void Turn_Up_At_90_Degree()
        {
            command = new Command();
            double actualAngle = command.Up;
            double expectedAngle = 90;
            Assert.True(expectedAngle == actualAngle);
        }

        [Fact]
        public void Turn_Down_At_270_Degree()
        {
            command = new Command();
            double actualAngle = command.Down;
            double expectedAngle = 270;
            Assert.True(expectedAngle == actualAngle);
        }
    }
}
