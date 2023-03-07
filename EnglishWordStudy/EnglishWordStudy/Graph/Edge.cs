using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordStudy.Graph
{
    public class Edge
    {
        public Vertex[] _verticesOfEdge;

        public Edge(Vertex vertex1, Vertex vertex2)
        {
            _verticesOfEdge = new Vertex[2];
            _verticesOfEdge[0] = vertex1;
            _verticesOfEdge[1] = vertex2;
        }


    }
}
