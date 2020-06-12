using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜyeKayıtFramework.Entities.Concrete;

namespace ÜyeKayıtFramework.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(Member member)
        {
            KpsServiceReference.KPSPublicSoapClient client = new KpsServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo),member.FirstName.ToUpper(),member.LastName.ToUpper(),member.DateOfBirth.Year);

        }
    }
}
