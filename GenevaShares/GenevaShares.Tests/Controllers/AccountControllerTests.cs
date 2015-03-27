using GenevaShares.Controllers;
using GenevaShares.Models;
using GenevaShares.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GenevaShares.Tests.Controllers
{
    [TestClass]
    public class AccountController_Login_Positive : TestingContext<AccountController, ActionResult>
    {
        public override void Given()
        {
            var service = new Mock<IUserService>();
            var authService = new Mock<IAuthService>();
            service.Setup(x => x.Authenticate("Test", "Test")).Returns(true);
            this.Subject = new AccountController(service.Object, authService.Object);


        }

        public override void When()
        {
            var model = new LoginViewModel{ Username = "Test", Password = "Test"};
            this.Result = this.Subject.Login(model);
        }

        [TestMethod]
        public void Then_It_Should_Return_Index()
        {
            var viewname = ((RedirectToRouteResult)this.Result).RouteValues["action"];

            Assert.AreEqual(viewname, "Index");
        }
    }

    [TestClass]
    public class AccountController_Register_Positive : TestingContext<AccountController, ActionResult>
    {
        public override void Given()
        {
            var service = new Mock<IUserService>();
            var authService = new Mock<IAuthService>();
            this.Subject = new AccountController(service.Object, authService.Object);
        }

        public override void When()
        {
            var user = new User { Email = "test@email.com", Password = "test", Username = "test" };
            this.Result = this.Subject.Register(user);
        }

        [TestMethod]
        public void Then_It_Should_Redirect_To_Index()
        {
            var viewname = ((RedirectToRouteResult)this.Result).RouteValues["action"];

            Assert.AreEqual(viewname, "Index");
        }
    }

    [TestClass]
    public class AccountController_Register_Negative : TestingContext<AccountController, ActionResult>
    {
        public override void Given()
        {
            var service = new Mock<IUserService>();
            var authService = new Mock<IAuthService>();
            service.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);
            this.Subject = new AccountController(service.Object, authService.Object);
        }

        public override void When()
        {
            var user = new User { Username = "test" };
            this.Result = this.Subject.Register(user);
        }

        [TestMethod]
        public void Then_It_Should_Redirect_To_Index()
        {
            var viewname = ((ViewResult)this.Result).ViewName;

            Assert.AreEqual(viewname, "Register");
        }
    }
}
