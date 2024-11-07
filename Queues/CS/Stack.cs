class MainProgram
{
    public static void Main(string[] args)
    {
        Stack<string> Stack = new Stack<string>(5);

        Stack.Push("1");
        Stack.Push("2");
        Stack.Push("3");
        Stack.Push("4");
        Stack.Push("5");
        Stack.IsFull();
        Stack.Peek();
        Stack.Pop();
        Stack.Peek();
        Stack.Push("10");
        Stack.Peek();
        Stack.Pop();
        Stack.Pop();
        Stack.Pop();
        Stack.Pop();
        Stack.Pop();
        Stack.IsEmpty();
    }
}

// Stack
public class Stack<T>
{
    public int Maxs;
    public int Pointer;

    private T[] Data;

    public Stack(int Max)
    {
        Data = new T[Max];
        Maxs = Max-1;
        Pointer = -1;
    }

    public void Push(T i)
    {
        if (Pointer == Maxs)
        {
            Console.WriteLine("Error Cannot Add Any More To The Queue");
        }
        else
        {
            Console.WriteLine("Adding " + i);
            Pointer += 1;
            Data[Pointer] = i;
        }
    }

    public void Pop() {
        if (Pointer == -1)
        {
            Console.WriteLine("Error The Queue Is Empty");
        }
        else
        {
            Console.WriteLine("executing " + Data[Pointer]);
            Pointer -= 1;
        }
    }

    public void Peek()
    {
        Console.WriteLine("The Current Task Is " + Data[Pointer]);
    }

    public void IsFull()
    {
        if(Pointer == Maxs)
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
        if (Pointer == -1)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
