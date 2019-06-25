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
        int[] parent;
        bool[] visited;
        int startPoint;
        int endpoint;
        public Dekstra(List<Vertex> V1, List<Edge> E1, int[,] AMatrix1, int startPoint1, int endpoint1, int[] parent1)
        {
            V = V1;
            E = E1;
            AMatrix = AMatrix1;
            startPoint = startPoint1 - 1;
            endpoint = endpoint1 - 1;
            parent = parent1;

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
                        


                    }
                   
                }


            }
            //"Стоимость пути из начальной вершины до остальных:\t\n";

            // массив посещенных вершин
             // индекс конечной вершины = 5 - 1
            parent[0] = endpoint + 1; // начальный элемент - конечная вершина
            int k = 1; // индекс предыдущей вершины
            int weight = distance[endpoint]; // вес конечной вершины

            while (endpoint != startPoint) // пока не дошли до начальной вершины
            {
                for (i = 0; i < V.Count; i++) // просматриваем все вершины
                    if (AMatrix[endpoint,i] != 0)   // если связь есть
                    {
                        int temp = weight - AMatrix[endpoint, i]; // определяем вес пути из предыдущей вершины
                        if (temp == distance[i]) // если вес совпал с рассчитанным
                        {                 // значит из этой вершины и был переход
                            weight = temp; // сохраняем новый вес
                            endpoint = i;       // сохраняем предыдущую вершину
                            parent[k] = i + 1; // и записываем ее в массив
                            k++;
                        }
                    }
            }
            for (int j = V.Count - 1; j != 0; j--)
            {
                if (parent[j] != 0)
                {
                    path += Convert.ToString(parent[j]);
                    path += " ";
                }
            }
            path += Convert.ToString(parent[0]);
            path += " Стоимость пути:";
            path += Convert.ToString(distance[weight]);
            return path;
        }
        public int Dijkstra(int [,] AMatrix, int V)
        {
            distance = new int[V];
            int count, index = 0, i, u, m = 1;
            startPoint = 0;
            visited = new bool[V];
            for (i = 0; i < V; i++)
            {
                distance[i] = int.MaxValue; visited[i] = false;
            }
            distance[startPoint] = 0;
            for (count = 0; count < V - 1; count++)
            {
                int min = int.MaxValue;
                for (i = 0; i < V; i++)
                    if (!visited[i] && distance[i] <= min)
                    {
                        min = distance[i]; index = i;
                    }
                u = index;
                visited[u] = true;
                for (i = 0; i < V; i++)
                    if (!visited[i] && AMatrix[u, i] != 0 && distance[u] != int.MaxValue &&
                    distance[u] + AMatrix[u, i] < distance[i])
                        distance[i] = distance[u] + AMatrix[u, i];
            }
            //"Стоимость пути из начальной вершины до остальных:\t\n";
            int s = 0;
           return s = distance[V - 1];


        }
    }


}
