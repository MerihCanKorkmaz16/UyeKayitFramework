using KurumsalMimari.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜyeKayıtFramework.Entities.Concrete;

namespace ÜyeKayıtFramework.DataAccess.Abstract
{
    public interface IMemberDal:IEntityRepository<Member>
    {
    }
}
