﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.Report
{
    /// <summary>
    /// Счет(а) депо.
    /// </summary>
    [Serializable()]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.CodeAnalysis.FxCopAnalyzers", "CA2235: Mark all non-serializable fields")]
    public class DepoAccount
    {
        /// <summary>
        /// Наименование. (optional)
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("N")]
        public string Name { get; set; }
    }
}