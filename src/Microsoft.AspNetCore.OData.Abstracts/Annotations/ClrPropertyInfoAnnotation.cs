﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Reflection;
using Microsoft.OData.Edm;

namespace Microsoft.AspNetCore.OData.Abstracts.Annotations
{
    /// <summary>
    /// Represents a mapping from an <see cref="IEdmProperty"/> to a CLR property info.
    /// </summary>
    public class ClrPropertyInfoAnnotation
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ClrPropertyInfoAnnotation"/> class.
        /// </summary>
        /// <param name="clrPropertyInfo">The backing CLR property info for the EDM property.</param>
        public ClrPropertyInfoAnnotation(PropertyInfo clrPropertyInfo)
        {
            ClrPropertyInfo = clrPropertyInfo ?? throw new ArgumentNullException(nameof(clrPropertyInfo));
        }

        /// <summary>
        /// Gets the backing CLR property info for the EDM property.
        /// </summary>
        public PropertyInfo ClrPropertyInfo { get; }
    }
}
