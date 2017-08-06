using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class Item
    {
        private int data;
        private int max;
        
        public Item(int data)  {
            this.data = data;
            this.max = data;
        }

        public Item(int data, int max)
        {
            this.data = data;
            this.max = max;
        }

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                this.data = value;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                this.max = value;
            }
        }
    }
}
