using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LgcWMS.Business.Controllers;
using LgcWMS.Business.Controllers.Operation;

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
