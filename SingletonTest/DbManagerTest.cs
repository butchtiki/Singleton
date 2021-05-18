namespace SingletonTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Singleton;

    [TestClass]
    public class DbManagerTest
    {
        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        public void GetInstance_MethodIsRan_ReturnsSameObject()
        {
            DbManager firstTarget = DbManager.GetInstance();
            DbManager secondTarget = DbManager.GetInstance();

            Assert.AreEqual(firstTarget, secondTarget);
        }



    }
}
