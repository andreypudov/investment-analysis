﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System.Diagnostics.Contracts;

namespace InvestmentAnalysis.Portfolio
{
    [ContractClass(typeof(PortfolioFactoryContract))]
    public interface IPortfolioFactory<out T> where T : IPortfolio<ITransaction>
    {
        T CreatePortfolio();
    }
}