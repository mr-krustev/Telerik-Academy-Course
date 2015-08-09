using System.Linq;

namespace Poker
{
    using System;
    using Interfaces;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                return false;
            }

            if (hand.Cards.Count != 5)
            {
                return false;
            }


            for (var i = 0; i < hand.Cards.Count - 1; i++)
            {
                var currCard = hand.Cards[i];

                for (var j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[j].Suit == currCard.Suit && hand.Cards[j].Face == currCard.Face)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
           throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }
       
            for (var i = 0; i < hand.Cards.Count - 3; i++)
            {
                var currCard = hand.Cards[0];
                var counter = 1;

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (currCard.Suit == hand.Cards[j].Suit)
                    {
                        continue;
                    }

                    if (currCard.Face == hand.Cards[j].Face)
                    {
                        counter++;
                    }

                    if (counter == 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }
            var suit = hand.Cards[0].Suit;
            return hand.Cards.All(card => card.Suit == suit);
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
