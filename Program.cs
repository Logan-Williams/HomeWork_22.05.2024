//// Задание 1
//class Program
//{
//    static void Main(string[] args)
//    {
//        string a = "ASD";
//        string b = "OPU";
//        Console.WriteLine($"A={a}, B={b}");
//        Swap(ref a, ref b);
//        Console.WriteLine($"A={a}, B={b}");

//    }

//     static void Swap<T>(ref T a, ref T b)
//    {
//        T temp = a;
//        a = b;
//        b = temp;
//    } 
//}


// Задание 2 
class MyList<T>
{
    public List<T> Items { get; set; }
    public MyList()
    {
        Items = new List<T>();
    }

    public void Add(T item)
    {
        Items.Add(item);
    }

    public void RemoveAt(int index)
    {
      Items.RemoveAt(index);
    }

    public T GetAt(int index)
    {
       return Items[index];
    }

    public int Count()
    {
        return Items.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList<int> intList = new MyList<int>();
        intList.Add(17);
        intList.Add(20);
        intList.Add(38);
        intList.Add(90);

        Console.WriteLine("Элементы списка:");
        for (int i = 0; i < intList.Count(); i++)
        {
            Console.Write(intList.GetAt(i) + " ");
        }

        Console.WriteLine(" ");
        Console.Write("Длина листа равна ");
        Console.Write(intList.Count());

        intList.RemoveAt(0);
        Console.WriteLine(" ");

        Console.WriteLine("Элементы списка после удаления:");
        for (int i = 0; i < intList.Count(); i++)
        {
            Console.Write(intList.GetAt(i) + " ");
        }
        Console.WriteLine(" ");
        Console.Write("Длина листа равна ");
        Console.Write(intList.Count());
    }
}



