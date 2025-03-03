﻿using CryptoExchange.Net.Attributes;

namespace Kucoin.Net.Enums
{
    /// <summary>
    /// Liquidity type of a trade
    /// </summary>
    public enum LiquidityType
    {
        /// <summary>
        /// Maker, order was on the order book and got filled
        /// </summary>
        [Map("maker")]
        Maker,
        /// <summary>
        /// Taker, trade filled an existing order on the order book
        /// </summary>
        [Map("taker")]
        Taker
    }
}
