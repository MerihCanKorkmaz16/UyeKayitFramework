using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ÜyeKayıtFramework.Business.Abstract;
using ÜyeKayıtFramework.Entities.Concrete;
using ÜyeKayıtFramework.Mvc.WebUI.Models;
using ÜyeKayıtFramework.Mvc.WebUI.Filters;

namespace ÜyeKayıtFramework.Mvc.WebUI.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        // GET: Member
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }
        [HttpPost]
        [ExceptionHandlerAttritube]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);

            return View(new MemberAddViewModel());
        }
    }
}