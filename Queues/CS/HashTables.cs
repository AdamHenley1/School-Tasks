class MainProgram
{
    public static void Main(string[] args)
    {
        
        Primefinder n = new Primefinder();
        var maxSize = n.find(12);
        HashTables hash = new HashTables(maxSize);

        hash.IsEmpty();
        hash.IsFull();
        hash.Enqueue("Jack", false);
        hash.Find("Jack");
        hash.Enqueue("gary", false);
        hash.Enqueue("garyasdsasda", false);
        hash.Enqueue("Steve", false);
        hash.Enqueue("gahhhhry", false);
        hash.Enqueue("garjjkiyasdsasda", false);
        hash.Enqueue("Stekjeajve", false);
        hash.Enqueue("gxvbbxcbvxary", false);
        hash.Enqueue("garyasdsasfcvxda", false);
        hash.Enqueue("Stevsddsdse", false);
        hash.Enqueue("gahhhhrddsy", false);
        hash.Enqueue("garjjkdddsiyasdsasda", false);
        hash.Enqueue("Stekddjeajve", false);
        hash.Enqueue("bill", false);
        hash.Enqueue("billlll", false);
        hash.IsFull();
        hash.Find("bill");
        hash.Find("gary");
        hash.Find("Steve");
        hash.Dequeue("Steve");
        hash.Find("Steve");
        hash.IsEmpty();
    }
   // Hash Tables -------------------------------------------------
    public class HashTables
    {
        // Attributes ----------------------------------------------
        public int maxSize;
        public int ascii;
        public int position;

        private Tuple<string, bool>[] HashStorage;

        // Constructor ---------------------------------------------
        public HashTables(int MaxSize)
        {
            maxSize = MaxSize;
            HashStorage = new Tuple<string, bool>[MaxSize];
        }


        public void Enqueue(string item, bool flagged)
        {
            ascii = 0;
            for (int i = 0; i == item.Length; i++)
            {
                ascii += (int)item[i];
            }

            position = ascii % maxSize;
            int x = position - 1;
            int Looped = -1;
            bool whatever = false;

            while (whatever == false)
            {
                x += 1;
                Looped += 1;
                if (Looped > maxSize)
                {
                    Console.WriteLine("space is full");
                    whatever = true;
                }
                if (x == maxSize)
                {
                    x = -1;
                }
                else if (HashStorage[x] == null || HashStorage[x].Item2 == true)
                {
                    HashStorage[x] = new Tuple<string, bool>(item, false);
                    Console.WriteLine("adding " + item);
                    whatever = true;
                }
            }
        }
        public void Dequeue(string item)
        {
            ascii = 0;

            for (int i = 0; i == item.Length; i++)
            {
                ascii += (int)item[i];
            }
            position = ascii % maxSize;
            int x = position - 1;
            int Looped = 0;
            bool whatever = false;

            while (whatever == false)
            {
                x += 1;
                Looped += 1;
                if (Looped > maxSize)
                {
                    Console.WriteLine("cannot find it");
                    whatever = true;
                }
                if (x == maxSize)
                {
                    x = -1;
                }
                else if (HashStorage[x].Item1 == item)
                {
                    Console.WriteLine("deleting " + item);
                    HashStorage[x] = new Tuple<string, bool>(item, true);
                    whatever = true;
                }
            }
        }

        public void Find(string look)
        {
            ascii = 0;

            for (int i = 0; i == look.Length; i++)
            {
                ascii += (int)look[i];
            }
            position = ascii % maxSize;
            int x = position - 1;
            int Looped = 0;
            bool whatever = false;

            while (whatever == false)
            {
                x += 1;
                Looped += 1;
                if (Looped > maxSize)
                {
                    Console.WriteLine("cannot find it");
                    whatever = true;
                }
                if (x == maxSize)
                {
                    x = -1;
                }
                else if (HashStorage[x].Item1 == look && HashStorage[x].Item2 != true)
                { 
                    Console.WriteLine("found " + look + " at "+ x);
                    whatever = true;
                }
            }
        }
        public void IsEmpty()
        {
            int Looped = 0;
            bool whatever = false;

            while (whatever == false)
            {
                Looped += 1;
                if (Looped >= maxSize)
                {
                    Console.WriteLine("HashTable is empty");
                    whatever = true;
                }
                else if (HashStorage[Looped] != null && HashStorage[Looped].Item2 == false)
                {
                    Console.WriteLine("HashTable isnt empty");
                    whatever = true;
                }
            }
        }
        public void IsFull()
        {
            int Looped = 0;
            bool whatever = false;

            while (whatever == false)
            {
                Looped += 1;
                if (Looped >= maxSize)
                {
                    Console.WriteLine("HashTable is Full");
                    whatever = true;
                }
                else if (HashStorage[Looped] == null || HashStorage[Looped].Item2 == true)
                {
                    Console.WriteLine("HashTable isnt Full");
                    whatever = true;
                }
            }
        }

    }

    public class Primefinder
    {


        public int find(int number)
        {
            //set the isPrime to false
            bool isPrime = false;

            //do this while isPrime is still false
            do
            {
                //increment the number by 1 each time
                number = number + 1;

                int squaredNumber = (int)Math.Sqrt(number);

                //start at 2 and increment by 1 until it gets to the squared number
                for (int i = 2; i <= squaredNumber; i++)
                {
                    //how do I check all i's?
                    if (number % i != 0)
                    {
                        isPrime = true;
                    }


                }


            } while (isPrime == false);

            //return the prime number
            return number;
        }
    }
}