using System;
using System.Collections.Generic;
using System.Linq;
namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            var actualResult = false;

            if (hand.Cards.Count == 5)
            {
                actualResult = true;

                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    var currentCard = hand.Cards[i];

                    for (int j = i + 1; j < hand.Cards.Count; j++)
                    {
                        if (currentCard.Face == hand.Cards[j].Face &&
                            currentCard.Suit == hand.Cards[j].Suit)
                        {
                            actualResult = false;
                            break;
                        }
                    }
                }
            }

            return actualResult;
        }

        public bool IsStraightFlush(IHand hand)
        {
            var cards = hand.Cards.OrderBy(c => (int)c.Face).ToList();

            var firstCard = cards[0];
            var result = true;

            for (int i = 1; i < cards.Count; i++)
            {
                if ((int)firstCard.Face >= (int)cards[i].Face)
                {
                    result = false;
                    break;
                }

                firstCard = cards[i];
            }

            if (cards.All(c => c.Suit != firstCard.Suit))
            {
                result = false;
            }

            return result;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var faceCount = Enum.GetValues(typeof(CardFace))
            .Cast<CardFace>()
            .ToList();

            var countOccurances = new int[faceCount.Count + 2];

            foreach (var card in hand.Cards)
            {
                if (faceCount.Contains(card.Face))
                {
                    countOccurances[(int)card.Face] += 1; 
                }
            }

            return countOccurances.Contains(4);
        }

        public bool IsFullHouse(IHand hand)
        {
            var faceCount = Enum.GetValues(typeof(CardFace))
            .Cast<CardFace>()
            .ToList();

            var countOccurances = new int[faceCount.Count + 2];

            foreach (var card in hand.Cards)
            {
                if (faceCount.Contains(card.Face))
                {
                    countOccurances[(int)card.Face] += 1;
                }
            }

            return (countOccurances.Contains(2) && countOccurances.Contains(3));
        }

        public bool IsFlush(IHand hand)
        {
            var cards = hand.Cards.OrderBy(c => (int)c.Face).ToList();

            var firstCard = cards[0];
            var notOrdered = false;

            for (int i = 1; i < cards.Count; i++)
            {
                if ((int)firstCard.Face >= (int)cards[i].Face)
                {
                    notOrdered = false;
                    break;
                }

                if((int)cards[i].Face - (int)firstCard.Face > 1)
                {
                    notOrdered = true;
                    break;
                }

                firstCard = cards[i];
            }
            
            var firstCardSuit = hand.Cards[0].Suit;
            return (hand.Cards.All(c => c.Suit == firstCardSuit) && notOrdered);
        }

        public bool IsStraight(IHand hand)
        {
            var cards = hand.Cards.OrderBy(c => (int)c.Face).ToList();

            var firstCard = cards[0];
            var result = true;

            for (int i = 1; i < cards.Count; i++)
            {
                if((int)firstCard.Face >= (int)cards[i].Face)
                {
                    result = false;
                    break;
                }

                firstCard = cards[i];
            }

            if(cards.All(c => c.Suit == firstCard.Suit))
            {
                result = false;
            }

            return result;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            var faceCount = Enum.GetValues(typeof(CardFace))
            .Cast<CardFace>()
            .ToList();

            var countOccurances = new int[faceCount.Count + 2];

            foreach (var card in hand.Cards)
            {
                if (faceCount.Contains(card.Face))
                {
                    countOccurances[(int)card.Face] += 1;
                }
            }

            return countOccurances.Contains(3);
        }

        public bool IsTwoPair(IHand hand)
        {
            var result = false;
            var countPairs = 0;

            var faceCount = Enum.GetValues(typeof(CardFace))
            .Cast<CardFace>()
            .ToList();

            var countOccurances = new int[faceCount.Count + 2];

            foreach (var card in hand.Cards)
            {
                if (faceCount.Contains(card.Face))
                {
                    countOccurances[(int)card.Face] += 1;
                }
            }

            for (int i = 0; i < countOccurances.Length; i++)
            {
                if(countOccurances[i] == 2)
                {
                    countPairs++;
                }
            }

            if(countPairs == 2)
            {
                result = true;
            }

            return result;
        }

        public bool IsOnePair(IHand hand)
        {
            var faceCount = Enum.GetValues(typeof(CardFace))
            .Cast<CardFace>()
            .ToList();

            var countOccurances = new int[faceCount.Count + 2];

            foreach (var card in hand.Cards)
            {
                if (faceCount.Contains(card.Face))
                {
                    countOccurances[(int)card.Face] += 1;
                }
            }

            return countOccurances.Contains(2);
        }

        public bool IsHighCard(IHand hand)
        {
            var result = true;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var currentCard = hand.Cards[i];

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if(currentCard.Face == hand.Cards[j].Face)
                    {
                        result = false;
                        break;
                    }
                }
            }
            var firstCardSuit = hand.Cards[0].Suit;
            if(hand.Cards.All(x => x.Suit == firstCardSuit))
            {
                result = false;
            }
            
            return result;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if (this.CheckHand(firstHand) > this.CheckHand(secondHand))
            {
                return -1;
            }
            else if (this.CheckHand(firstHand) < this.CheckHand(secondHand))
            {
                return 1;
            }

            return 0;
        }

        private int CheckHand(IHand hand)
        {
            if (this.IsHighCard(hand))
            {
                return 0;
            }
            else if (this.IsOnePair(hand))
            {
                return 1;
            }
            else if (this.IsTwoPair(hand))
            {
                return 2;
            }
            else if (this.IsThreeOfAKind(hand))
            {
                return 3;
            }
            else if (this.IsStraight(hand))
            {
                return 4;
            }
            else if (this.IsFlush(hand))
            {
                return 5;
            }
            else if (this.IsFullHouse(hand))
            {
                return 6;
            }
            else if (this.IsFourOfAKind(hand))
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }
    }
}