using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbyyTask.Business;
using AbbyyTask.Business.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbbyyTask.Tests.Services
{
    [TestClass]
    public class FormServiceTest
    {
        private static readonly Form TestFrom = new Form
        {
            Concepts =
                new Concept[]
                {
                    new Concept
                    {
                        Cardinality = "1",
                        Name = "Concept",
                        Properties = new Property[] {new Property {Cardinality = "1", Name = "Name", Type = "string"}}
                    }
                }
        };

        private static readonly string ResultString = "{\"Concept\":{\"_cardinality\":\"1\",\"Name\":{\"_cardinality\":\"1\"}}}";

        [TestMethod]
        public void ServiceTest()
        {
            var service = new FormService();
            var result = service.GetJson(TestFrom);

            Assert.AreEqual(result, ResultString);
        }
    }
}
