namespace PokerTests
{
    using NUnit.Framework;

    using Poker;

    [TestFixture]
    [Category("Card tests")]
    public class CardTests
    {
        [Test]
        public void ToString_Card_ShouldReturnOtherThanDefault()
        {
            //Arrange
            var cardSuit = CardSuit.Clubs;
            var cardFace = CardFace.Ace;
            var card = new Card(cardFace, cardSuit);
            var expectedResult = $"{card.Face} {card.Suit}";

            //Act
            var actualResult = card.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Face_ShouldReturnCardFace()
        {
            //Arrange
            var card = new Card(CardFace.Queen, CardSuit.Clubs);
            var expectedFace = CardFace.Queen;

            //Act
            var actualFace = card.Face;

            //Assert
            Assert.AreEqual(expectedFace, actualFace);
        }

        [Test]
        public void Suit_ShouldReturnCardSuit()
        {
            //Arrange
            var card = new Card(CardFace.Queen, CardSuit.Clubs);
            var expectedSuit = CardSuit.Clubs;

            //Act
            var actualSuit = card.Suit;

            //Assert
            Assert.AreEqual(expectedSuit, actualSuit);
        }
    }
}
