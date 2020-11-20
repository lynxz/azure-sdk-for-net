// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Iot.TimeSeriesInsights;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> Time series type defines variables or formulas for doing computation on events associated with time series instances. Each time series instance is associated with exactly one type. A type can have one or more variables. For example, a time series instance might be of type Temperature Sensor, which consists of the variables avg temperature, min temperature, and max temperature. </summary>
    public partial class TimeSeriesType
    {
        /// <summary> Initializes a new instance of TimeSeriesType. </summary>
        /// <param name="name"> User-given unique name for the type. Mutable, not null. </param>
        /// <param name="variables"> Different variables associated with the type. Not empty, not null. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="variables"/> is null. </exception>
        public TimeSeriesType(string name, IDictionary<string, TimeSeriesVariable> variables)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (variables == null)
            {
                throw new ArgumentNullException(nameof(variables));
            }

            Name = name;
            Variables = variables;
        }

        /// <summary> Initializes a new instance of TimeSeriesType. </summary>
        /// <param name="id"> Case-sensitive unique type identifier that is immutable. Can be null on create or update requests, and then server generates the ID. Not null on get and delete operations. </param>
        /// <param name="name"> User-given unique name for the type. Mutable, not null. </param>
        /// <param name="description"> Description of the type. May be null. </param>
        /// <param name="variables"> Different variables associated with the type. Not empty, not null. </param>
        internal TimeSeriesType(string id, string name, string description, IDictionary<string, TimeSeriesVariable> variables)
        {
            Id = id;
            Name = name;
            Description = description;
            Variables = variables;
        }

        /// <summary> Case-sensitive unique type identifier that is immutable. Can be null on create or update requests, and then server generates the ID. Not null on get and delete operations. </summary>
        public string Id { get; set; }
        /// <summary> User-given unique name for the type. Mutable, not null. </summary>
        public string Name { get; set; }
        /// <summary> Description of the type. May be null. </summary>
        public string Description { get; set; }
        /// <summary> Different variables associated with the type. Not empty, not null. </summary>
        public IDictionary<string, TimeSeriesVariable> Variables { get; }
    }
}