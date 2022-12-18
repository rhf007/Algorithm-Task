using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KruskalAlgorithmTask.Program;

namespace KruskalAlgorithmTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int verticesCount = 4;
            int edgesCount = 5;
            graph graph = creategraph(verticesCount, edgesCount);

                        graph.edge[0].source = 0;
            graph.edge[0].destination = 1;
            graph.edge[0].weight = 10;

                        graph.edge[1].source = 0;
            graph.edge[1].destination = 2;
            graph.edge[1].weight = 6;

            graph.edge[2].source = 0;
            graph.edge[2].destination = 3;
            graph.edge[2].weight = 5;

            graph.edge[3].source = 1;
            graph.edge[3].destination = 3;
            graph.edge[3].weight = 15;

            graph.edge[4].source = 2;
            graph.edge[4].destination = 3;
            graph.edge[4].weight = 4;

            kruskal(graph);
            Console.ReadKey();
        }
        
        public struct edge
        {
            public int source;
            public int destination;
            public int weight;
        }

        public struct graph
        {
            public int edgecount1;
            public int vertexcount1;
            public edge[] edge;
        }

        public struct subset
        {
            public int parent;
            public int rank;
        }

        public static graph creategraph(int vertexcount2, int edgecount2)
        {
            graph graph = new graph();
            graph.vertexcount1 = vertexcount2;
            graph.edgecount1 = edgecount2;
            graph.edge = new edge[graph.edgecount1];

            return graph;
        }

        public static int find(subset[] subsets, int i)
        {
            if (subsets[i].parent != i)
            {
                subsets[i].parent = find(subsets, subsets[i].parent);
            }

            return subsets[i].parent;
        }

        public static void union(subset[] subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);

            if (subsets[xroot].rank < subsets[yroot].rank)
            {
                subsets[xroot].parent = yroot;
            }

            else if (subsets[xroot].rank > subsets[yroot].rank)
            {
                subsets[yroot].parent = xroot;
            }

            else
            {
                subsets[yroot].parent = xroot;
                ++subsets[xroot].rank;
            }
        }

        public static void printresult(edge[] result, int e)
        {
            for (int i = 0; i < e; ++i)
            {
                Console.WriteLine("{0} -- {1} == {2}", result[i].source, result[i].destination, result[i].weight);
            }
        }

        public static void kruskal(graph graph)
        {
            int vertexcount2 = graph.vertexcount1;
            edge[] result = new edge[vertexcount2];
            int i = 0;
            int e = 0;
            Array.Sort(graph.edge, delegate (edge a, edge b)
            {
                return a.weight.CompareTo(b.weight);
            });

            subset[] subsets = new subset[vertexcount2];

            for (int v = 0; v < vertexcount2; ++v)
            {
                subsets[v].parent = v;
                subsets[v].rank = 0;
            }

            while (e < vertexcount2 - 1)
            {
                edge nextedge = graph.edge[i++];
                int x = find(subsets, nextedge.source);
                int y = find(subsets, nextedge.destination);

                if (x != y)
                {
                    result[e++] = nextedge;
                    union(subsets, x, y);
                }
            }

            printresult(result, e);
        }
    }
    
}
