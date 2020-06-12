using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜyeKayıtFramework.Entities.Concrete;

namespace ÜyeKayıtFramework.Business.ValidationRules.FluentValidation
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.DateOfBirth).NotEmpty();
            RuleFor(x => x.TcNo).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            //kişinin girdiği doğum tarihi bugünden küçük olmalı
            RuleFor(x => x.DateOfBirth).LessThan(DateTime.Now);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.TcNo).Length(11);
        }
    }
}
