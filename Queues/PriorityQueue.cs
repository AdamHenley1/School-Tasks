class MainProgram
{
    public static void Main(string[] args)
    {
        Stack<string> Stack = new Stack<string>(5);
        LinearQueue<string> Linear = new LinearQueue<string>(5);
        CircularQueue<string> circ = new CircularQueue<string>(5);
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
    public int FP = 0;

    private Tuple<B,int>[] Data;

    public PriorityQueue(int Max)
    {
        Maxs = Max;
        Data = new Tuple<B, int>[Maxs];
    }

    public void Enqueue(B item, int Priority)
    {
        if (count+1 > Maxs)
        {
            Console.WriteLine("Error Cannot Add Any More To The Queue");
            return;
        }
        else
        { 
            Data[count] = new Tuple<B, int>(item, Priority);
            count += 1;
            Console.WriteLine("Adding " + item + Priority);
            return;

        }
        var sorted = Data.Skip(FP).Take(count-FP).OrderBy(tuple => tuple.Item2).ToArray();
        Array.Copy(sorted, Data, count);
    }
    public void peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Error: Queue is empty");
        }
        else
        {
            Console.WriteLine("The Current Task Is " + Data[FP-1].Item1);
            //Console.WriteLine(FP);
        }
    }
    public void DeQueue()
    { 
        if (count == 0)
        {
            Console.WriteLine("Error: Queue is Empty");
        }
        else
        {
            //Console.WriteLine("executing " + Data[FP].Item1);
            FP += 1;
            count -= 1;
        }
    }
    public void IsFull()
    {
        if (count == Maxs)
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
        if (count == 0)
        {
            Console.WriteLine("Queue is Empty");
        }
        else
        {
            Console.WriteLine("Queue isnt Empty");
        }
    }
}
