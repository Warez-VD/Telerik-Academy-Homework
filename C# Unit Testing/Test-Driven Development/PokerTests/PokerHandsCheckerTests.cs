using NUnit.Framework;
using Poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTests
{
    [TestFixture]
    [Category("PokerHandsChecker tests")]
    public class PokerHandsCheckerTests
    {
        [Test]
        public void IsValidHand_WhenContainsFiveDifferentCard_ShouldReturnTrue()
        {
            //Arrange
            var pokerCheker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerCheker.IsValidHand(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsFlush_WhenAllCardHaveSameSuit_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs)
            });
            var firstCardSuit = hand.Cards[0].Suit;
            var expectedResult = hand.Cards.All(c => c.Suit == firstCardSuit);

            //Act
            var actualResult = pokerChecker.IsFlush(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsFourOfAKind_WhenFourCardFacesAreEqual_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsFourOfAKind(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsHighCard_WhenAllCardsAreDifferent_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsHighCard(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsOnePair_WhenOnlyTwoCardsAreWithEqualFaces_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsOnePair(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsThreeOfAKind_WhenThreeCardsAreWithSameSuits_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsThreeOfAKind(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsTwoPair_TwoCardsHaveTheirEqualCardFace_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsTwoPair(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsStraight_WhenFiveCardFacesAreOrderedInARow_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsStraight(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsFullHouse_WhenThreeCardFacesAreEqualAndTheRestTwoAreEqualToo_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsFullHouse(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsStraightFlush_WhenAllCardsAreOrderedByFaceAndSuitInARow_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });
            var expectedResult = true;

            //Act
            var actualResult = pokerChecker.IsStraightFlush(hand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CompareHands_WhenAreEqualByThePokerRules_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();

            IHand firstHand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            IHand secondHand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            var expectedResult = 0;


            //Act
            var actualResult = pokerChecker.CompareHands(firstHand, secondHand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void CompareHands_WhenFirstHandIsStrongerByThePokerRules_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();

            IHand firstHand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            IHand secondHand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            var expectedResult = -1;
            
            //Act
            var actualResult = pokerChecker.CompareHands(firstHand, secondHand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CompareHands_WhenSecondHandIsStrongerByThePokerRules_ShouldReturnTrue()
        {
            //Arrange
            var pokerChecker = this.PokerChecker();

            IHand firstHand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            IHand secondHand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            var expectedResult = 1;

            //Act
            var actualResult = pokerChecker.CompareHands(firstHand, secondHand);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        private PokerHandsChecker PokerChecker()
        {
            return new PokerHandsChecker();
        }
    }
}
