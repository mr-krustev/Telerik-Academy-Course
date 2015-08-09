using System.Text;

namespace Poker.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using NUnit.Framework;

    using Poker.Interfaces;

    [TestFixture]
    public class HandTests
    {
        private Random random = new Random();

        public List<ICard> GetCards()
        {
            List<ICard> cards = new List<ICard>();

            for (var i = 0; i < 5; i++)
            {
                var face = (CardFace)(random.Next(2, 15));
                var suit = (CardSuit)(random.Next(1, 5));
                cards.Add(new Card(face, suit));
            }
            return cards;
        }

        [TestCase(5)]
        public void ToStringShouldReturnValidDataWhenCalled(int numberOfTest)
        {
            for (int i = 0; i < numberOfTest; i++)
            {
                var hand = new Hand(GetCards());
                var result = string.Join(", ", hand.Cards);

                Assert.AreEqual(result, hand.ToString());
            }   
        }
    }
}
