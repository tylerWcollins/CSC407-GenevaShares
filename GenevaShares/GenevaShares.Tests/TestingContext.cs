using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenevaShares.Tests
{
    public abstract class TestingContext<TSubject, TResult>
    {
        public TSubject Subject { get; protected set; }
        public TResult Result { get; protected set; }

        public abstract void Given();
        public abstract void When();

        [TestInitialize]
        public void TestInitialize()
        {
            this.Given();
            this.When();
        }
    }
}
