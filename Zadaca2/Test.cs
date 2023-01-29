using NUnit.Framework;
using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.QA
{
    public class Test
    {
        [Test]
        public void TestTrainSize()
        {
            Vlak smallTrain = new Vlak(Vlak.Size.Small);
            Assert.AreEqual(smallTrain.GetSize(), Vlak.Size.Small);
            Console.WriteLine("Test proso");

            Assert.AreEqual(smallTrain.GetCapacity(), 8);
            Console.WriteLine("Test proso");

            Vlak largeTrain = new Vlak(Vlak.Size.Large);
            Assert.AreEqual(largeTrain.GetSize(), Vlak.Size.Large);
            Console.WriteLine("Test proso");
            Assert.AreEqual(largeTrain.GetCapacity(), 6);
            Console.WriteLine("Test proso");
        }
    }
}
