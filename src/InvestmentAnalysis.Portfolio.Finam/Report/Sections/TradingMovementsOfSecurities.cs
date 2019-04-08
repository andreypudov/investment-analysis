﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    /// <summary>
    /// Торговые движения ценных бумаг (включая незавершенные сделки), в т.ч. Комиссии.
    /// </summary>
    [Serializable()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.CodeAnalysis.FxCopAnalyzers", "CA2235: Mark all non-serializable fields")]
    public sealed class TradingMovementsOfSecurities
    {
        /// <summary>
        /// Название таблицы.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        public string Name { get; set; }

        [XmlElement("R")]
        public Collection<TradingMovementsOfSecuritiesRow> Rows { get; private set; }

        [XmlElement("T")]
        public Collection<TradingMovementsOfSecuritiesTotal> Total { get; private set; }

        public TradingMovementsOfSecurities()
        {
            Rows = new Collection<TradingMovementsOfSecuritiesRow>();
            Total = new Collection<TradingMovementsOfSecuritiesTotal>();
        }
    }
}
