﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace InvestmentAnalysis.Portfolio
{
    public sealed class PortfolioReaderException : Exception
    {
        public PortfolioReaderException()
        {
        }

        public PortfolioReaderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public PortfolioReaderException(string message)
            : this(message, new List<string>())
        {
        }

        public PortfolioReaderException(string message, IEnumerable<string> errors)
            : base(message)
        {
            Data["Errors"] = errors;
        }
    }
}