using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystAnalys_lr1
{
    public class Dekstra
    {
        List<Vertex> V;
        List<Edge> E;
        int[,] AMatrix;
        int [] distance;
        bool[] visited;
        int startPoint;
        int endpoint;
        public Dekstra(List<Vertex> V1, List<Edge> E1, int[,] AMatrix1, int startPoint1, int endpoint1)
        {
            V = V1;
            E = E1;
            AMatrix = AMatrix1;
            startPoint = startPoint1 - 1;
            endpoint = endpoint1 - 1;

        }
        public Dekstra()
        {
          
        }
        public string Dijkstra()
        {

            distance = new int[V.Count];
            int count, index = 0, i, u, m = startPoint + 1;
            visited = new bool [V.Count];
            for (i = 0; i < V.Count; i++)
            {
                distance[i] = int.MaxValue; visited[i] = false;
            }
            distance[startPoint] = 0;
            string path = "";
            for (count = 0; count < V.Count - 1; count++)
            {
                int min = int.MaxValue;
                for (i = 0; i < V.Count; i++)
                    if (!visited[i] && distance[i] <= min)
                    {
                        min = distance[i]; index = i;
                    }
                u = index;
                visited[u] = true;
                for (i = 0; i < endpoint+1; i++)
                {
                    if (!visited[i] && AMatrix[u, i] != 0 && distance[u] != int.MaxValue &&
                    distance[u] + AMatrix[u, i] < distance[i])
                    {
                        distance[i] = distance[u] + AMatrix[u, i];
                        path += u;
                    }
                 }


            }
            //"Стоимость пути из начальной вершины до остальных:\t\n";
            string s="";
            int j = 0;
            s =Convert.ToString( distance[endpoint]);

            return s;
        }
       
    }


}
