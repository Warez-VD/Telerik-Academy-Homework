namespace Santase.LogicTests
{
    using NUnit.Framework;

    using Santase.Logic;
    using Santase.Logic.Extensions;

    [TestFixture]
    [Category("Player position extensions tests")]
    public class PlayerPositionExtensionTests
    {
        [TestCase(PlayerPosition.FirstPlayer)]
        [TestCase(PlayerPosition.SecondPlayer)]
        public void OtherPlayer_WhenValidOpositePlayerPosition_ShouldReturnPlayerPosition(PlayerPosition position)
        {
            var otherPlayerPosition = PlayerPositionExtensions.OtherPlayer(position);
            Assert.AreNotEqual(position, otherPlayerPosition);
        }

        [Test]
        public void OtherPlayer_WhenPlayerPositionIsNoOne_ShouldReturnPlayerPositionNoOne()
        {
            var otherPlayerPosition = PlayerPositionExtensions.OtherPlayer(PlayerPosition.NoOne);
            Assert.AreEqual(PlayerPosition.NoOne, otherPlayerPosition);
        }
    }
}
