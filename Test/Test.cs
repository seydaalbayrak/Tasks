using System;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using yenim;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestInvalidInputKullanici()
        {
            cKullanici login = new cKullanici();
            try
            {
                int result = login.KullaniciGetir("asdfgtrfdeswaqxcvfgb");
                Assert.Fail();
            }
            catch(InvalidOperationException)
            {

            }

        }

        [TestMethod]
        public void TestInvalidInputProje()
        {
            cProje proje = new cProje();
            try
            {
                int result = proje.ProjeGetir("projeprojeprojeproje");
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

        }


    }

}
