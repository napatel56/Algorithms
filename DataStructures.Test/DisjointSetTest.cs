using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADT;
using System.Collections.Generic;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class DisjointSetTest
    {
    
        [TestMethod]
        public void Disjoint_Set()
        {
            char result;
            Console.Write("testing Disjoint sets.");
            List<char> elementCollection = new List<char>(){'A','B','C','D','E'};
            DisjointSet<char> disjointSet = new DisjointSet<char>(elementCollection);
            
            char itemtoSearch = 'D';
            result = disjointSet.Find(itemtoSearch);
            Console.WriteLine(string.Format("The searched item {0} is associated with Disjoint Set {1}", itemtoSearch, result));
            disjointSet.Union('D', 'A'); // Sets A is a parent element of item D. Now, A and D will be in the same Set.

            result = disjointSet.Find(itemtoSearch);
            Console.WriteLine(string.Format("The searched item {0} is associated with Disjoint Set {1}", itemtoSearch, result));

            disjointSet.Union('A', 'B'); // Sets B is a parent element of item A. Now, A, B and D will be in the same Set.

            result = disjointSet.Find(itemtoSearch);
            Console.WriteLine(string.Format("The searched item {0} is associated with Disjoint Set {1}", itemtoSearch, result));


        }
    }
}
