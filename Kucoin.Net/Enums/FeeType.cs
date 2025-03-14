﻿using CryptoExchange.Net.Attributes;

namespace Kucoin.Net.Enums
{
    /// <summary>
    /// Type of fee paid
    /// </summary>
    public enum FeeType
    {
        /// <summary>
        /// Maker fee rate
        /// </summary>
        [Map("makerFee")]
        MakerFee,
        /// <summary>
        /// Taker fee rate
        /// </summary>
        [Map("takerFee")]
        TakerFee
    }
}
