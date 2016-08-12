namespace PokerTests
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    using Poker;

    [TestFixture]
    [Category("Hand tests")]
    public class HandTests
    {
        [Test]
        public void ToString_Hand_ShouldReturnDifferentResultThanDefault()
        {
            //Arrange
            var cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Jack, CardSuit.Clubs));
            var hand = new Hand(cards);
            var expectedResult = string.Join(", ", cards);

            //Act
            var actualResult = hand.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Cards_ShouldReturnCardsList()
        {
            //Arrange
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            var expectedCards = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });
            var actualCards = hand.Cards;

            //Act
            var actualResult = true;
            for (int i = 0; i < actualCards.Count; i++)
            {
                if(expectedCards.Cards[i].Face != actualCards[i].Face
                    || expectedCards.Cards[i].Suit != actualCards[i].Suit)
                {
                    actualResult = false;
                    break;
                }
            }

            //Assert
            Assert.IsTrue(actualResult);
        }
    }
}
