using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LgcWMS.Business.Controllers;

namespace LgcWMS.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DespachosController dController = new DespachosController();
            dController.GetData((int)DespachosController.ActionType.ImportDespachos);
        }
    }
}
