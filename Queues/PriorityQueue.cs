class MainProgram
{
    public static void Main(string[] args)
    {
        PriorityQueue<string> prio = new PriorityQueue<string>(5);

        prio.Enqueue("yes", 9);
        prio.Enqueue("hi", 6);
        prio.Enqueue("bob", 3);
        prio.Enqueue("terry", 7);
        prio.Enqueue("garry", 1);
        prio.Enqueue("jill", 341);
        prio.peek();
        prio.DeQueue();
        prio.peek();
        prio.Enqueue("bob", 1);
        prio.peek();
        prio.DeQueue();
        prio.peek();
        prio.DeQueue();
        prio.peek();
        prio.DeQueue();
        prio.peek();
        prio.DeQueue();
        prio.peek();
        prio.DeQueue();
        prio.peek();
        prio.DeQueue();
    }
}

public class PriorityQueue<B>
{
    public int Maxs;
    public int count = 0;
    public int RP =0;

    private Tuple<B,int,int>[] Data;

    public PriorityQueue(int Max)
    {
        Maxs = Max;
        Data = new Tuple<B, int, int>[Maxs];
    }

    public void Enqueue(B item, int Priority, int date)
    {
        if (RP == Maxs)
        {
            Console.WriteLine("Error Cannot Add Any More To The Queue");
        }
        else
        { 
            Data[RP] = new Tuple<B, int, int>(item, Priority, date);
            Console.WriteLine("Adding " + Data[RP]);
            RP += 1;
            count += 1;
            if (RP >= 1)
            {
                var Sorted = Data
                    .AsParallel()
                    .Take(RP)
                    .OrderBy(tuple => tuple.Item2)
                    .ThenBy(tuple => tuple.Item3)
                    .Reverse()
                    .ToArray();

                Array.Copy(Sorted, Data, RP);
                return;
            }
            
        }
    }
    public void peek()
    {
        if (RP == 0)
        {
            Console.WriteLine("Error: Queue is empty");
        }
        else
        {
            Console.WriteLine("The Current Task Is " + Data[0]);
            //Console.WriteLine(FP);
        }
    }
    public void DeQueue()
    { 
        if (RP == 0)
        {
            Console.WriteLine("Error: Queue is Empty");
        }
        else
        {
            //Console.WriteLine("executing " + Data[FP].Item1);
            //Data[0] = null;
            Console.WriteLine("Dequeing " + Data[0]);
            var decrease = Data.Skip(1).ToArray();
            Array.Copy(decrease, Data, RP-1);
            if (RP > 1)
            {
                var sortedkk = Data
                    .Take(RP)
                    .OrderBy(tuple => tuple.Item2)
                    .ThenBy(tuple => tuple.Item3)
                    .Reverse()
                    .ToArray();

                Array.Copy(sortedkk, Data, RP);
                RP -= 1;
            }
            else
            {
                RP -= 1;
            }
        }
    }
    public void IsFull()
    {
        if (RP == Maxs)
        {
            Console.WriteLine("Queue is Full");
        }
        else
        {
            Console.WriteLine("Queue isnt Full");
        }
    }
    public void IsEmpty()
    {
        if (RP == 0)
        {
            Console.WriteLine("Queue is Empty");
        }
        else
        {
            Console.WriteLine("Queue isnt Empty");
        }
    }
}