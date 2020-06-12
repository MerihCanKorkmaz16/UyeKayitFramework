using KurumsalMimari.Core.DependencyResolvers.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜyeKayıtFramework.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GEtInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
