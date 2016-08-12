namespace Santase.LogicTests
{
    using NUnit.Framework;

    using Santase.Logic.Cards;

    [TestFixture]
    [Category("Card tests")]
    public class CardTests
    {
        [Test]
        public void CardConstructor_ShouldSetSuitAndType()
        {
            var card = new Card(CardSuit.Club, CardType.Ace);

            Assert.AreEqual(card.Suit, CardSuit.Club);
            Assert.AreEqual(card.Type, CardType.Ace);
        }

        [TestCase(CardType.Nine)]
        [TestCase(CardType.Ten)]
        [TestCase(CardType.Jack)]
        [TestCase(CardType.Queen)]
        [TestCase(CardType.King)]
        [TestCase(CardType.Ace)]
        public void GetValue_WhenValidType_ShouldReturnIntValue(CardType cardType)
        {
            var card = new Card(CardSuit.Club, cardType);

            var intValue = card.GetValue();

            Assert.AreEqual(intValue.GetType().Name, typeof(int).Name);
        }
        
        [Test]
        public void Equals_WhenSameCard_ShouldReturnTrue()
        {
            var firstCard = new Card(CardSuit.Club, CardType.Ace);
            var secondCard = new Card(CardSuit.Club, CardType.Ace);

            Assert.IsTrue(firstCard.Equals(secondCard));
        }

        [Test]
        public void Equals_WhenDifferentCard_ShouldReturnFalse()
        {
            var firstCard = new Card(CardSuit.Club, CardType.Ten);
            var secondCard = new Card(CardSuit.Club, CardType.Ace);

            Assert.IsFalse(firstCard.Equals(secondCard));
        }

        [Test]
        public void DeepClone_ShouldReturnNewCard()
        {
            var card = new Card(CardSuit.Club, CardType.Ten);

            var clonedCard = card.DeepClone();

            Assert.AreNotSame(card, clonedCard);
        }

        [Test]
        public void ToString_ShouldReturnFriendlyString()
        {
            var card = new Card(CardSuit.Club, CardType.Ten);

            Assert.AreEqual("10\u2663", card.ToString());
        }
    }
}
