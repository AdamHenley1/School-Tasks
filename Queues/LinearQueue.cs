using systems;
class MainProgram
  {
    public static void Main(string[] args)
    {
     LinearQueue<string> lqs = new LinearQueue<string>(5); 
    }
  }

// Linear Queue -------------------------------------------------
public class LinearQueue<T>
{
  public int Max;
  public int FP;
  public int RP; 

  private T[] Data;
  
  public LinearQueue(int Max)
  {
    Data = new T[Max];
    M = Max;
    FP = 0;
    RP = -1;
  }
  
  public void Enqueue(T i)
  {    
    RP += 1;
    Data[RP] = i;
  }  
  public void DeQueue()
  {
    FP += 1;
    M += 1;
  }

