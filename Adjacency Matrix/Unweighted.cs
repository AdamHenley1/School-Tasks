using System;
namespace graphs
{
    public class Main
    {
        public Main(string[] args)
        {
            Graph Matrix = new Graph();

            Matrix.Node_Add("A");
            Matrix.Size();

        }
    }
    public class Graph
    {
        List<List<int>> Data;
        List<int> Temp;
        List<string> Alphabet;

        public Graph()
        {
            Data = new List<List<int>>();
            Alphabet = new List<string>();
            Temp = new List<int>();

        }
        public void Node_Add(string Item)
        {
            Alphabet.Add(Item);
        }
        public void Size()
        {
            for(int i = 0; i < Alphabet.Count; i++)
            {
                List<int> temp = new List<int>();
                for (int x = 0; x < Alphabet.Count; x++)
                {
                    Temp.Add(0);
                    Console.WriteLine(Temp);
                }
            }
        }
    }
}