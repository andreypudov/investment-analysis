﻿// Copyright (c) Andrey Pudov.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See LICENSE.txt in the project root for license information.

using System;
using System.Xml.Serialization;

namespace InvestmentAnalysis.Portfolio.Finam.FinamReport
{
    /// <summary>
    /// Клиент.
    /// </summary>
    [Serializable()]
    public class Client
    {
        /// <summary>
        /// Наименование клиента.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute]
        public string Name { get; set; }
    }
}
