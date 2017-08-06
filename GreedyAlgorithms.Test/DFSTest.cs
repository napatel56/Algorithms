using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GreedyAlgorithms.Test
{
    /*
    [TestClass]
    public class DFSTest
    {
        [TestMethod]
        public void DFSTest()
        {
            string[] input = Console.ReadLine().Split(' ');
            
            // Number of Vertices - V
            // Number of Edges - M
            int V = Convert.ToInt32(input[0]);
            int M = Convert.ToInt32(input[1]);

            List<int>[] neighbors = new List<int>[V];

            for(int i=0; i< V; i++)
            {
                neighbors[i] = new List<int>();
            }

            for(int i=0; i< M ; i++)
            {
                int startVertex;
                int endVertex;

                string[] edges = Console.ReadLine().Split(' ');
                startVertex = Convert.ToInt32(edges[0]);
                endVertex = Convert.ToInt32(edges[1]);

                // Symmetric for Undirected Graph.
                neighbors[startVertex].Add(endVertex);
                neighbors[endVertex].Add(startVertex);
            }



        }
    }

    */
}
