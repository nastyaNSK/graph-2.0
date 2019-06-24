using System;
using SystAnalys_lr1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestVertexLilst
{
    [TestClass]
    public class VertexList
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Edge> E = new List<Edge>();
            List<Vertex> V = new List<Vertex>();
            Form1 d = new Form1();
            d.Load_Click();
            bool a = false;
            if (E.Count > 0)
                a = true;

            Assert.IsFalse(a);
        }
    }
}
