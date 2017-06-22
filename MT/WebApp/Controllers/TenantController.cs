using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TenantController : Controller
    {
        public ActionResult Index()
        {
            var tenants = new List<Tenant>
            {
                new Tenant()
                {
                    Name = "SVCC",
                    DomainName = "www.siliconvalley-codecamp.com",
                    Id = 1,
                    Default = true
                },
                new Tenant()
                {
                    Name = "ANGU",
                    DomainName = "www.angularu.com",
                    Id = 1,
                    Default = true
                },
                new Tenant()
                {
                    Name = "CSSC",
                    DomainName = "www.codestarsummit.com",
                    Id = 1,
                    Default = true
                }
            };
            return View(tenants);
        }
        
    }
}