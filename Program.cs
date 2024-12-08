namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int[] x1 = {1,2,3,4,5};

        Console.WriteLine("Введите количество позиций для ротации:");
        int d = Convert.ToInt16(Console.ReadLine());

        int n = x1.Length;
        d = d % n;
        int[] x2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            x2[(i + d) % n] = x1[i];
        }
        for (int i = 0; i < n; i++)
        {
            x1[i] = x2[i];
        }
        
        Console.WriteLine("------------------------------------------------------------------------------");
        foreach (int i in x1){
            Console.WriteLine(i);
        }
    }
}