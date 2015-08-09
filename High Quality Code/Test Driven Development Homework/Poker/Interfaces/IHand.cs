﻿namespace Poker.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IHand
    {
        IList<ICard> Cards { get; }
        string ToString();
    }
}
