﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClass(typeof(TransactionContract))]
    public interface ITransaction
    {
        TransactionType TransactionType { get; }

        long DateTime { get; }

        int Units { get; }

        decimal Price { get; }
    }
}