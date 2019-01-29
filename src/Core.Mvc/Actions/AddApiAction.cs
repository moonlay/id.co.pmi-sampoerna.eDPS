using Core.Mvc.Infrastructure.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Core.Mvc.Actions
{
    public class AddApiAction : IAddApiAction
    {
        public int Priority
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Execute(System.Web.Http.HttpConfiguration httpConfig, IContainer serviceProvider)
        {
            throw new NotImplementedException();
        }
    }
}
