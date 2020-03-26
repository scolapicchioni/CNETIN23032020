using System;
using Xunit;
using Moq;

namespace GameScenario.UnitTests {
    public class GameTests {
        [Fact]
        public void WhenPlayer1Wins_GameShouldReturnPlayer1() {
            //Arrange

            Mock<IPlayer> p1 = new Mock<IPlayer>();
            p1.Setup(p => p.Play()).Returns(6);


            Mock<IPlayer> p2 = new Mock<IPlayer>();
            p2.Setup(p => p.Play()).Returns(1);

            Game sut = new Game(p1.Object,p2.Object);
            
            //Act
            IPlayer actual = sut.Play();

            //Assert
            Assert.Equal(p1.Object, actual);
        }
    }
}
