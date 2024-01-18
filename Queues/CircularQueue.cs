
using System.Reflection;
class MainProgram
{
    public static void Main(string[] args)
    {
        CircularQueue<string> circ = new CircularQueue<string>(5);

        circ.Enqueue("1");
        circ.Enqueue("2");
        circ.Enqueue("3");
        circ.Enqueue("4");
        circ.Enqueue("5");
        circ.Enqueue("6");
        circ.DeQueue();
        circ.DeQueue();
        circ.Enqueue("6");
        circ.Enqueue("9");
        circ.Enqueue("69");
        circ.Enqueue("9887");
        circ.Enqueue("643");
        circ.Enqueue("953553");
        circ.DeQueue();
        circ.IsEmpty();
        circ.Enqueue("3jk");
        circ.IsFull();
        circ.DeQueue();
        circ.DeQueue();
        circ.DeQueue();
        circ.DeQueue();
        circ.DeQueue();
        circ.IsFull();
        circ.IsEmpty();
    }
}

// Circular Queue
public class CircularQueue<J>
{
    public int Maxs;
    public int FP;
    public int RP;
    public int count;

    private J[] Data;

    public CircularQueue(int Max)
    {
        Data = new J[Max];
        Maxs = Max
    ;
        RP = -1;
        count = 0;
    }

    public void Enqueue(J i)
    {
        if (count == Maxs)
        {
        Console.WriteLine("error Queue is full");
        }   
        else if (RP == Maxs-1 && FP > 0)
        {
            Console.WriteLine("[Loop]Adding " + i);
            RP = 0;
            Data[RP] = i;
            count += 1;
        }
        else
        {
            Console.WriteLine("Adding " + i);
            RP += 1;
            Data[RP] = i;
            count += 1;
        }
    }
    public void peek()
    {
        Console.WriteLine("The Current Task Is " + Data[FP]);
    }
    public void DeQueue()
    {
        if (FP == Maxs-1 && RP > 0)
        {
            Console.WriteLine("[Loop]Executing " + Data[FP]);
            FP = 0;
            count -= 1;
        }
        else
        {
            Console.WriteLine("executing " + Data[FP]);
            FP += 1;
            count -= 1;
        }
    }
    public void IsFull()
    {
        if (count == Maxs)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    public void IsEmpty()
    {
        if (count == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
    