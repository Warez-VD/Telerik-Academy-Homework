namespace Santase.LogicTests
{
    using NUnit.Framework;

    using Santase.Logic.Extensions;

    [TestFixture]
    [Category("Random provider tests")]
    public class RandomProviderTests
    {
        [Test]
        public void Next_ShouldReturnRandomIntValue_BetweenMinAndMax()
        {
            var min = 5;
            var max = 10;
            var randomNumber = RandomProvider.Next(min, max);

            Assert.IsTrue(min <= randomNumber && randomNumber < max);
        }
    }
}
