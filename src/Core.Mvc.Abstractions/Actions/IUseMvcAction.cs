﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Web.Optimization;
using System.Web.Routing;

namespace ExtCore.Mvc.Infrastructure.Actions
{
    /// <summary>
    /// Describes an action that must be executed inside the UseMvc method and might be used by the extensions
    /// to configure the routes.
    /// </summary>
    public interface IUseMvcAction
    {
        /// <summary>
        /// Priority of the action. The actions will be executed in the order specified by the priority (from smallest to largest).
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// Contains any code that must be executed inside the UseMvc method.
        /// </summary>
        /// <param name="routeBuilder">
        /// Will be provided by the ExtCore.Mvc and might be used to configure the routes.
        /// </param>
        /// <param name="serviceProvider">
        /// Will be provided by the ExtCore.Mvc and might be used to get any service that is registered inside the DI at this moment.
        /// </param>
        void Execute(RouteCollection routeBuilder, BundleCollection bundleCollection, IServiceProvider serviceProvider);
    }
}