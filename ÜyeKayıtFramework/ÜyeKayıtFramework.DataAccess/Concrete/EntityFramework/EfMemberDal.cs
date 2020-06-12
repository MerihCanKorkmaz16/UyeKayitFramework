using KurumsalMimari.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜyeKayıtFramework.DataAccess.Abstract;
using ÜyeKayıtFramework.Entities.Concrete;

namespace ÜyeKayıtFramework.DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal:EfEntityRepositoryBase<Member,MembershipContext>,IMemberDal
    {
    }
}
