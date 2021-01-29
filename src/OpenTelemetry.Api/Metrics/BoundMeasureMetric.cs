// <copyright file="BoundMeasureMetric.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using OpenTelemetry.Trace;

namespace OpenTelemetry.Metrics
{
    /// <summary>
    /// Bound measure metric with the defined <see cref="LabelSet"/>.
    /// </summary>
    /// <typeparam name="T">The type of Measure. Only long and double are supported now.</typeparam>
    [Obsolete("Metrics API/SDK is not recommended for production. See https://github.com/open-telemetry/opentelemetry-dotnet/issues/1501 for more information on metrics support.")]
    public abstract class BoundMeasureMetric<T>
        where T : struct
    {
        /// <summary>
        /// Record the given value to the bound measure metric.
        /// </summary>
        /// <param name="context">the associated <see cref="SpanContext"/>.</param>
        /// <param name="value">the measurement to be recorded.</param>
        public abstract void Record(in SpanContext context, T value);

        /// <summary>
        /// Record the given value to the bound measure metric.
        /// </summary>
        /// <param name="context">the associated <see cref="Baggage"/>.</param>
        /// <param name="value">the measurement to be recorded.</param>
        public abstract void Record(in Baggage context, T value);
    }
}
