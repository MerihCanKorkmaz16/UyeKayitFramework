using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜyeKayıtFramework.Business.Abstract;
using ÜyeKayıtFramework.Business.Concrete;
using ÜyeKayıtFramework.Business.ServiceAdapters;
using ÜyeKayıtFramework.DataAccess.Abstract;
using ÜyeKayıtFramework.DataAccess.Concrete.EntityFramework;

namespace KurumsalMimari.Core.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
