namespace Santase.LogicTests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    using Santase.Logic.Cards;
    using Santase.Logic.Extensions;

    [TestFixture]
    [Category("Enumerable extension tests")]
    public class EnumerableExtensionTests
    {
        [Test]
        public void Shuffle_WhenCollectionIsNull_ShouldThrowArgumentNullException()
        {
            IEnumerable<Card> cards = null;
            Assert.Throws<ArgumentNullException>(() => EnumerableExtensions.Shuffle(cards));
        }

        [Test]
        public void Shuffle_WhenCollectionIsValid_ShouldReturnIEnumerableShuffled()
        {
            IEnumerable<Card> cards = new List<Card>
            {
                new Card(CardSuit.Club, CardType.Ace),
                new Card(CardSuit.Club, CardType.King),
                new Card(CardSuit.Club, CardType.Queen),
                new Card(CardSuit.Club, CardType.Jack),
                new Card(CardSuit.Club, CardType.Ten),
                new Card(CardSuit.Club, CardType.Nine)
            };

            var shuffledCards = EnumerableExtensions.Shuffle(cards);
            var equal = true;

            foreach (var card in cards)
            {
                foreach (var shuffledCard in shuffledCards)
                {
                    if(card != shuffledCard)
                    {
                        equal = false;
                        break;
                    }

                    if (!equal)
                    {
                        break;
                    }
                }
            }

            Assert.IsFalse(equal);
        }
    }
    
}
