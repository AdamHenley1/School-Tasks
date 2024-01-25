using System;
using System.Linq;
using System.Collections.Generic;
namespace graphs
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            Graph Matrix = new Graph();

            Matrix.Node_Add("A");
            Matrix.Node_Add("b");
            Matrix.Node_Add("c");
            Matrix.Node_Add("d");
            Matrix.Node_Add("e");
            Matrix.Node_Add("f");
            Matrix.Node_Remove("e");

        }
    }
    public class Graph
    {
        public List<List<int>> Data; // holds all the co-ordinats 
        public List<int> Temp; // temporary list
        public List<string> Nodes; // all the nodes

        public Graph()
        {
            Data = new List<List<int>>();
            Nodes = new List<string>();
            Temp = new List<int>();

        }
        public void Node_Add(string Item)
        {
            foreach (var Row in Data)
            {
                Row.Add(0);
            }
            Nodes.Add(Item);
            for (int i = 0; i < 1; i++)
            {
                List<int> temp = new List<int>();

                for (int x = 0; x < Nodes.Count; x++)
                {
                    Temp.Add(0);
                    //Console.WriteLine(Temp);
                }
                Data.Add(temp);
            }
        }
        public void Node_Remove(string Item) 
        {
            Int32 length = Nodes.Count;

            for (int i = 0; i < length; i++)
                {
                for(int x = 0;x<length;x++)

                    if (Nodes[i] == Item)
                    {
                        Data.RemoveAt(i);
                        foreach (var Row in Data)
                        {
                            Row.RemoveAt(i);
                        }
                    }
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    for (int j = 0; j < Data.Count; j++)
                    //Console.Write("{0} " + Data[i, j]);
                    Console.WriteLine(Data[i][j]);
                }
            }

    }
}