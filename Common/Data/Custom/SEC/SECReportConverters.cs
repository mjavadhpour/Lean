﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QuantConnect.Data.Custom.SEC
{
    /// <summary>
    /// Specifies format for parsing <see cref="DateTime"/> values from SEC data
    /// </summary>
    public class SECReportDateTimeConverter : IsoDateTimeConverter
    {
        public SECReportDateTimeConverter()
        {
            DateTimeFormat = "yyyyMMdd HH:mm:ss";
        }
    }
}