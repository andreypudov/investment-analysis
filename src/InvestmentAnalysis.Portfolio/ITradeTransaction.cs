﻿// <copyright file="ITradeTransaction.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace InvestmentAnalysis.Portfolio
{
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Represents a financial transaction.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="ISecurity"/>.</typeparam>
    [ContractClass(typeof(TradeTransactionContract))]
    public interface ITradeTransaction<out T> : ITransaction<T>
        where T : ISecurity
    {
        /// <summary>
        /// Gets the financial security.
        /// </summary>
        /// <value>The financial security.</value>
        T Security { get; }

        /// <summary>
        /// Gets the units of the transaction.
        /// </summary>
        /// <value>The units of the transaction.</value>
        int Units { get; }
    }
}
