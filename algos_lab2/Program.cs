using System;

namespace algos_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.ADD_V(new Vertex("1", 1));
            graph.ADD_V(new Vertex("2", 2));
            graph.ADD_V(new Vertex("3", 3));

            graph.ADD_E(new Edge(graph.Vertexes[1], graph.Vertexes[0], 1));
            graph.ADD_E(new Edge(graph.Vertexes[2], graph.Vertexes[1], 1));
            graph.ADD_E(new Edge(graph.Vertexes[0], graph.Vertexes[2], 1));

            graph.Print();

            graph.DEL_E(graph.Vertexes[0], graph.Vertexes[2]) ;

            graph.Print();

            Console.ReadLine();
        }
    }
}
