﻿// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.Localization
{
    /// <summary>
    /// An abstract base class provider for determining the culture information of an <see cref="HttpRequest"/>.
    /// </summary>
    public abstract class RequestCultureProvider : IRequestCultureProvider
    {
        /// <summary>
        /// The current options for the <see cref="RequestLocalizationMiddleware"/>.
        /// </summary>
        public RequestLocalizationOptions Options { get; set; }

        /// <inheritdoc />
        public abstract Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext);

    }
}
