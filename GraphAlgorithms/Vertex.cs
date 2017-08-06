using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms
{
    // Adajecy List representation of Graph.
    public class Vertex<T>
    {
        T data;

        List<Vertex<T>>[] neighbors;
    }
}
