using GenevaShares.Controllers;
using GenevaShares.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GenevaShares.Tests.Account
{
    [TestClass]
    public class AccountController_Login_Positive : TestingContext<AccountController, ActionResult>
    {
        public override void Given()
        {
            this.Subject = new AccountController();
        }

        public override void When()
        {
            this.Result = this.Subject.Login(new LoginViewModel() { Username = "Jeff", Password = "Jeff" });
        }

        [TestMethod]
        public void Then_It_Should_Return_Home()
        {
            var viewResult = (this.Result as ViewResult);

            Assert.AreEqual(viewResult.ViewName, "Index");
        }
    }
}
