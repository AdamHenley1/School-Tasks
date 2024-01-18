class MainProgram
{
    public static void Main(string[] args)
    {
        Stack<string> Stack = new Stack<string>(5);

        Stack.Push("1");
        Stack.Push("2");
        Stack.Push("3");
        Stack.Peek();
        Stack.Pop();
        Stack.Peek();
        Stack.Push("4");
        Stack.Peek();
        Stack.Pop();
        Stack.Peek();
    }
}

// Linear Queue -------------------------------------------------
public class Stack<T>
{
    public int Maxs;
    public int FP;
    public int RP;

    private T[] Data;

    public Stack(int Max)
    {
        Data = new T[Max];
        Maxs = Max;
        FP = 0;
        RP = -1;
    }

    public void Push(T i)
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
    public void Peek()
    {
        Console.WriteLine("The Current Task Is "+Data[RP]);
    }
    public void Pop() {
        if (FP == RP)
        {
            Console.WriteLine("Error The Queue Is Empty");
        }
        else
        {
            Console.WriteLine("executing " + Data[RP]);
            RP -= 1;
        }
    }
}
