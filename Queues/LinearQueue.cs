class MainProgram
{
    public static void Main(string[] args)
    {
        LinearQueue<string> Linear = new LinearQueue<string>(5);

        Linear.Enqueue("1");
        Linear.Enqueue("3");
        Linear.Enqueue("64");
        Linear.Enqueue("2");
        Linear.Enqueue("4");
        Linear.Enqueue("6");
        Linear.peek();
        Linear.DeQueue();
        Linear.peek();
        Linear.DeQueue();
        Linear.DeQueue();
        Linear.DeQueue();
        Linear.DeQueue();
        Linear.peek();
        Linear.Enqueue("6");
    }
}

// Linear Queue -------------------------------------------------
public class LinearQueue<T>
{
    public int Maxs;
    public int FP;
    public int RP;

    private T[] Data;

    public LinearQueue(int Max)
    {
        Data = new T[Max];
        Maxs = Max;
        FP = 0;
        RP = -1;
    }

    public void Enqueue(T i)
    {
        if (RP == Maxs - 1)
        {
            Console.WriteLine("Error Cannot Add Any More To The Queue");
        }
        else
        {
            Console.WriteLine("Adding " + i);
            RP += 1;
            Data[RP] = i;
        }
    }
    public void peek()
    {
        if (FP > RP)
        {
            Console.WriteLine("Error Queue Is Complete");
        }
        else
        {
            Console.WriteLine("The Current Task Is "+Data[FP]);
        }
    }
    public void DeQueue() {
        if (FP > RP)
        {
            Console.WriteLine("Error The Queue Is Empty");
        }
        else
        {
            Console.WriteLine("executing " + Data[FP]);
            FP += 1;
        }
    }
}
