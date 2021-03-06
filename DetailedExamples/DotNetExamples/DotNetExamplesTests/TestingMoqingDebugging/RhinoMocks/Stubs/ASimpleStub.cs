namespace TestingMoqingDebugging.RhinoMocks.Tests
{
    using System;
    using NUnit.Framework;
    using Rhino.Mocks;
    
    [TestFixture]   
    public class ASimpleStub
    {   
        private ISimpleModel sut;

        public ASimpleStub()
        {
            this.sut = MockRepository.GenerateStub<ISimpleModel>();
            this.sut.Stub(x => x.Do()).Return(1);
        }

        [Test]
        public void WhenSimple()
        {
            Assert.That(this.sut.Do().Equals(1));
        }
    }
}