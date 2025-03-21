﻿using CryptoExchange.Net.Attributes;

namespace Kucoin.Net.Enums
{
    /// <summary>
    /// Position side
    /// </summary>
    public enum PositionSide
    {
        /// <summary>
        /// Both (One way position mode)
        /// </summary>
        [Map("BOTH")]
        Both,
        /// <summary>
        /// Long
        /// </summary>
        [Map("LONG")]
        Long,
        /// <summary>
        /// Short
        /// </summary>
        [Map("SHORT")]
        Short
    }
}
