using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜyeKayıtFramework.Business.Abstract;
using ÜyeKayıtFramework.Business.DependencyResolvers.Ninject;
using ÜyeKayıtFramework.Entities.Concrete;

namespace ÜyeKayıtFramework.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GEtInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName="Merih Can",
                LastName="Korkmaz",
                DateOfBirth = new DateTime(1997,3,29),
                TcNo = "23566525060",
                Email="merihcankorkmaz16@gmail.com"
            });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
