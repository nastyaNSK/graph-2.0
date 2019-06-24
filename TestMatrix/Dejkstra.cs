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

namespace TestMatrix

{
    [TestClass]
    public class Dejkstra
    {
        [TestMethod]
        public void TestMethod1()
        {
            List <Edge> E = new List<Edge>();
            E.Add( new Edge(0, 1, 1));
            E.Add(new Edge(1, 2, 1));
            E.Add(new Edge(0, 2, 1));
            int[,] Matrix = new int[,] { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 }};

            int[,] AMatrix = new int[3, 3];
            DrawGraph G = new DrawGraph(100, 100);
            G.fillAdjacencyMatrix(3, E, AMatrix);
            bool a;
            if (Array.Equals(Matrix, AMatrix))
                a = false;
            else
                a = true;
            Assert.IsTrue(a);
        }
    }
}
