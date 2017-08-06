using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class DisjointSet<T>
    {
        /// <summary>
        /// 1. Dictionary represents Parent child relationship between the items.
        /// 2. Maintains a list of elements (items) as keys and their associated Parent element (item) as Values.
        /// </summary>
        private Dictionary<T,T> parentsList;
        private Dictionary<T, int> rank;    // Records the depth of the Trees.

        public DisjointSet(List<T> elements)
        {
            parentsList = new Dictionary<T, T>();
            rank = new Dictionary<T, int>();


            List<T> universe = elements;

            foreach (T x in universe)
            {
                parentsList[x] = x; // Sets it's parent to itself 
                               // which means we are going to have # disjoints sets each containing one item.
            }

        }

        /// <summary>
        /// Complexity of Find function is the Order of the depth of the Tree.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public T Find(T item)
        {
            T parent;

            if (parentsList.TryGetValue(item, out parent))
            {
                if (parent.Equals(item)) // Tests if the parent of the item is the item itself.
                    return item;
                else
                    return Find(parent); // value represents the parent of the Item being looked up for.
            }
            else
                throw new ArgumentException("The item you are attempting to searching in not a valid item.");
        }   

        /// <summary>
        /// Union operations sets the Root of the second Set as the root of the first set as a result the first root 
        /// is no longer a root, and the root of the second set is now the root of the merged disjoint set.
        /// </summary>
        /// <param name="set_1"></param>
        /// <param name="set_2"></param>
        public void Union (T set_1, T set_2)
        {
            parentsList[set_1] = set_2;
        }


    }
 }
