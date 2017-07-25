using System;
using Xunit;
using MarsRover;
namespace TestMarsRover
{    
    public class MarsFixture
    {
        [Fact]
        public void Valid_Length()
        {
            IPlanet<int> mars = new Mars();
            double actualLength = mars.Length;
            double expectedLength = 50;
            Assert.True(actualLength==expectedLength);
        }

        [Fact]
        public void Valid_Breadth()
        {
            IPlanet<int> mars = new Mars();
            double actualBreadth = mars.Breadth;
            double expectedBreadth = 50;
            Assert.True(actualBreadth == expectedBreadth);
        }

        [Fact]
        public void Is_Rover_Lie_In_Dead()
        {
            IPlanet<int> mars = new Mars();
            bool isEnd=mars.IsDeadEnd(150,150);
            Assert.True(isEnd);
        }
        [Fact]
        public void Is_Rover_Lie_Not_In_Dead()
        {
            IPlanet<int> mars = new Mars();
            bool isNotEnd = mars.IsDeadEnd(15, 15);
            Assert.True(isEnd);
        }
    }
}
