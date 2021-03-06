// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Services.Remoting.V2.Builder
{
    using System;
    using System.Collections.Generic;

    internal class InterfaceDetails
    {
        internal InterfaceDetails()
        {
            this.Id = 0;
            this.MethodNames = new Dictionary<string, int>();
            this.RequestWrappedKnownTypes = new List<Type>();
            this.ResponseWrappedKnownTypes = new List<Type>();
            this.ResponseKnownTypes = new List<Type>();
            this.ServiceInterfaceType = null;
            this.RequestKnownTypes = new List<Type>();
        }

        public Type ServiceInterfaceType { get; internal set; }

        public int Id { get; internal set; }

        public List<Type> RequestKnownTypes { get; internal set; }

        public List<Type> ResponseKnownTypes { get; internal set; }

        public IEnumerable<Type> RequestWrappedKnownTypes { get; internal set; }

        public IEnumerable<Type> ResponseWrappedKnownTypes { get; internal set; }

        public Dictionary<string, int> MethodNames { get; internal set; }
    }
}
