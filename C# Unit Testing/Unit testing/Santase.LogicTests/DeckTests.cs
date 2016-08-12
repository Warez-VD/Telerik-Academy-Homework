using System;
using NUnit.Framework;
using Santase.Logic.Cards;
using Santase.Logic;

namespace Santase.LogicTests
{
    [TestFixture]
    [Category("Deck tests")]
    public class DeckTests
    {
        [Test]
        public void ListOfCards_IsNotNull_ShouldReturnTrue()
        {
            //Arrange
            var deck = new Deck();

            //Act
            Assert.IsNotNull(deck);
        }

        [Test]
        public void GetNextCard_IfCardListIsZero_ShouldThrowException()
        {
            //Arrange
            var deck = new Deck();
            var expectedResult = 0;
            var intialCardListCount = deck.CardsLeft;

            //Act
            for (int i = 0; i < expectedResult; i++)
            {
                Assert.Throws<InternalGameException>(() => deck.GetNextCard());
            }
        }

        [Test]
        public void GetNextCard_IfCardValid_ShouldReturnCard()
        {
            //Arrange
            var deck = new Deck();
            var expectedResult = new Card(CardSuit.Club, CardType.Ace);
            var intialCardListCount = deck.CardsLeft;
            var cardsCount = deck.CardsLeft;
            var card = deck.GetNextCard();

            //Act
            for (int i = 0; i < cardsCount; i++)
            {
                if(card.Suit == expectedResult.Suit &&
                    card.Type == expectedResult.Type)
                {
                    break;
                }

                card = deck.GetNextCard();
            }

            //Assert
            Assert.AreEqual(expectedResult, card);
        }

        [Test]
        public void TrumpCard_ShouldNotBeNull()
        {
            //Arrange
            var deck = new Deck();
            var trumpCard = deck.TrumpCard;

            //Assert
            Assert.IsNotNull(trumpCard);
        }

        [Test]
        public void ChangeTrumpCard_ChangedTrumpCard_WhenNewCardIsPassed()
        {
            //Arrange
            var deck = new Deck();
            var trumpCard = deck.TrumpCard;
            var otherCard = deck.GetNextCard();

            //Act
            deck.ChangeTrumpCard(otherCard);
            var newTrumpCard = deck.TrumpCard;

            //Assert
            Assert.AreNotEqual(trumpCard, newTrumpCard);
        }
    }
}
