using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜyeKayıtFramework.Business.Abstract;
using ÜyeKayıtFramework.Business.ServiceAdapters;
using ÜyeKayıtFramework.Business.ValidationRules.FluentValidation;
using ÜyeKayıtFramework.DataAccess.Abstract;
using ÜyeKayıtFramework.Entities.Concrete;
using FluentValidation;
using KurumsalMimari.Core.Aspects.Postsharp;

namespace ÜyeKayıtFramework.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;
        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckIfMemberExists(member);
            CheckIfUserValidFromKps(member);
            //kötü kod çünkü ilerde bu yapı değişebilir vs adapter design pattern
            //KpsServiceReference.KPSPublicSoapClient client = new KpsServiceReference.KPSPublicSoapClient();
            //client.TCKimlikNoDogrula();
            //kötü kod bitiş
            _memberDal.Add(member);
        }

        private void CheckIfUserValidFromKps(Member member)
        {
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanıcı doğrulaması geçerli değil");
            }
        }

        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("Bu Kullanıcı daha önce kayıtlı olmuştur");
            }
        }
    }
}
