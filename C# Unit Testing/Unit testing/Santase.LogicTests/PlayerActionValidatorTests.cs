namespace Santase.LogicTests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Moq;

    using Santase.Logic.Cards;
    using Santase.Logic.PlayerActionValidate;
    using Santase.Logic.Players;
    using Santase.Logic.RoundStates;
    
    [TestFixture]
    [Category("PlayerActionValidator tests")]
    public class PlayerActionValidatorTests
    {
        [Test]
        public void IsValid_IfActionIsNull_ShouldReturnFalse()
        {
            //Arrange
            var playerValidator = new PlayerActionValidator();
            PlayerAction playerAction = null;
            PlayerTurnContext context = new PlayerTurnContext(new StateManager().State,
                                                                new Card(CardSuit.Club, CardType.Jack),
                                                                3, 10, 10);
            ICollection<Card> playerCards = new List<Card>();
            var expectedResult = false;

            //Act
            var actualResult = playerValidator.IsValid(playerAction, context, playerCards);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Implement correct test
        public void IsValid_WhenActionTypeIsPlayCard_ShouldReturnPlayCard()
        {
            var playerValidator = new PlayerActionValidator();
            var playerAction = PlayerAction.PlayCard(new Card(CardSuit.Club, CardType.Jack));
            var stateManager = new StateManager();
            var trumpCard = new Card(CardSuit.Spade, CardType.Ace);
            var cardsLeftInDeck = 5;
            var fPlayerRoundPoints = 10;
            var sPlayerRoundPoints = 15;
            ICollection<Card> playerCards = new List<Card>();
            var context = new PlayerTurnContext(stateManager.State, trumpCard, cardsLeftInDeck, fPlayerRoundPoints, sPlayerRoundPoints);
            context.FirstPlayedCard = null;

            Assert.IsTrue(playerValidator.IsValid(playerAction, context, playerCards));
        }
    }
}
