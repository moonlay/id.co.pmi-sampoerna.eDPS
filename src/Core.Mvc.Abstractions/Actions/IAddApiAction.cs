using Autofac;
using System.Web.Http;

namespace Core.Mvc.Infrastructure.Actions
{
    public interface IAddApiAction
    {
        /// <summary>
        /// Priority of the action. The actions will be executed in the order specified by the priority (from smallest to largest).
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// Contains any code that must be executed inside the AddMvc method.
        /// </summary>
        /// <param name="mvcBuilder">
        /// Will be provided by the ExtCore.Mvc and might be used to configure the MVC.
        /// </param>
        /// <param name="serviceProvider">
        /// Will be provided by the ExtCore.Mvc and might be used to get any service that is registered inside the DI at this moment.
        /// </param>
        void Execute(HttpConfiguration httpConfig, IContainer serviceProvider);
    }
}
