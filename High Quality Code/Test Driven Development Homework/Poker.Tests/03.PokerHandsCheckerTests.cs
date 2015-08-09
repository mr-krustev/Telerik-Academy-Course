using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker.Interfaces;

namespace Poker.Tests
{
    using System;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class PokerHandsCheckerTests
    {
        private readonly IPokerHandsChecker _pokerHandsChecker = new PokerHandsChecker();
      
        private List<ICard> GetCards(int numberOfCards, bool haveSameCards = false)
        {
            var cards = new List<ICard>();
            for (var i = 0; i < numberOfCards; i++)
            {
                var card = new Card((CardFace)i + 2, (CardSuit)i + 2);
                if (haveSameCards)
                {
                    card = new Card(CardFace.Ace, CardSuit.Clubs);
                    if (i > 1)
                    {
                        haveSameCards = false;
                    }
                }
                cards.Add(card);
            }
            return cards;
        }

        [Test]
        public void IsValidHandShouldReturnFalseWhenNullValueIsPassed()
        {
            var actual= _pokerHandsChecker.IsValidHand(null);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsValidHandShouldReturnFalseWhenSameCardsInHand()
        {
            var cards = GetCards(5, true);
            var hand = new Hand(cards);

            var actual = _pokerHandsChecker.IsValidHand(hand);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsValidHandShouldReturnFalseWhenLessCardsInHand()
        {
            var cards = GetCards(4);
            var hand = new Hand(cards);

            var actual= _pokerHandsChecker.IsValidHand(hand);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsValidHandShouldThrowArgumentExceptionWhenMoreCardsInHand()
        {
            var cards = GetCards(6);
            var hand = new Hand(cards);

            var actual= _pokerHandsChecker.IsValidHand(hand);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenCalledWithEmptyHand()
        {
            var cards = GetCards(0);
            var hand = new Hand(cards);

            var actual = _pokerHandsChecker.IsFlush(hand);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenCalledWithLessCardsInHand()
        {
            var cards = GetCards(4, true);
            var hand = new Hand(cards);

            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenSameCardsInHand()
        {
            var cards = GetCards(5, true);
            var hand = new Hand(cards);

            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenHandWithFullHouseIsPassed()
        {
            var hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs)
            });

            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenHandWithPairIsPassed()
        {
            var hand = new Hand(new List<ICard>
            {
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs)
            });

            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenHandWithThreeOfAKindIsPassed()
        {
            var hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs)
            });
            
            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenHandWithFourOfAKindIsPassed()
        {
            var hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs)
            });

            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFlushShouldReturnTrueWhenHandWithFlushIsPassed()
        {
            var hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });

            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void IsFlushShouldReturnFalseWhenHandWithSixCardsIsProvided()
        {
            var hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            var actual = _pokerHandsChecker.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseWhenHandWithLessCards()
        {
            var cards = GetCards(4);
            var hand = new Hand(cards);

            var actual = _pokerHandsChecker.IsFourOfAKind(hand);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseWhenHandWithMoreCards()
        {
            var cards = GetCards(6);
            var hand = new Hand(cards);

            var actual = _pokerHandsChecker.IsFourOfAKind(hand);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFourOfAKindShouldReturnFalseWhenHandWithSameCards()
        {
            var cards = GetCards(5, true);
            var hand = new Hand(cards);

            var actual = _pokerHandsChecker.IsFourOfAKind(hand);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsFourOfAKindShouldReturnTrueWhenHandWithFourfAKind()
        {
            var hand = new Hand(new List<ICard>
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs)
            });
            
            var actual = _pokerHandsChecker.IsFourOfAKind(hand);
            Assert.AreEqual(true, actual);
        }
    }
}
