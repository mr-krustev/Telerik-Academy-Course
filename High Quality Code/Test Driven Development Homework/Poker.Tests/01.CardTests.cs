using System.Collections;

namespace Poker.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CardTests
    {
        [TestCase(CardFace.Ace, CardSuit.Clubs)]
        [TestCase(CardFace.King, CardSuit.Clubs)]
        [TestCase(CardFace.Queen, CardSuit.Clubs)]
        [TestCase(CardFace.Jack, CardSuit.Clubs)]
        [TestCase(CardFace.Ten, CardSuit.Clubs)]
        [TestCase(CardFace.Nine, CardSuit.Clubs)]
        [TestCase(CardFace.Nine, CardSuit.Spades)]
        [TestCase(CardFace.Nine, CardSuit.Diamonds)]
        [TestCase(CardFace.Nine, CardSuit.Hearts)]
        public void ToStringShouldReturnValidDataWhenCalled(CardFace cardFace, CardSuit cardSuit)
        {
            var card = new Card(cardFace, cardSuit);
            Assert.AreEqual(
                string.Format("{0} of {1}", cardFace.ToString(), cardSuit.ToString()), 
                card.ToString());
        }
    }
}
