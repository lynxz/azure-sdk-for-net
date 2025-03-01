﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.ResourceManager.Core
{
    internal static partial class SpendingLimitExtensions
    {
        public static string ToSerialString(this SpendingLimit value) => value switch
        {
            SpendingLimit.On => "On",
            SpendingLimit.Off => "Off",
            SpendingLimit.CurrentPeriodOff => "CurrentPeriodOff",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SpendingLimit value.")
        };

        public static SpendingLimit ToSpendingLimit(this string value)
        {
            if (string.Equals(value, "On", StringComparison.InvariantCultureIgnoreCase))
                return SpendingLimit.On;
            if (string.Equals(value, "Off", StringComparison.InvariantCultureIgnoreCase))
                return SpendingLimit.Off;
            if (string.Equals(value, "CurrentPeriodOff", StringComparison.InvariantCultureIgnoreCase))
                return SpendingLimit.CurrentPeriodOff;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SpendingLimit value.");
        }
    }
}
