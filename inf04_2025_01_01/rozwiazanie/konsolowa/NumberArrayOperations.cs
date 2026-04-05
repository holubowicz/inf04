namespace ConsoleApp;

public class NumberArrayOperations
{
    private static readonly Random Rand = new();
    
    private readonly int[] _arr;
    private readonly int _size;

    public NumberArrayOperations(int size)
    {
        _size = size;
        _arr = new int[size];
        
        for (int i = 0; i < size; i++)
            _arr[i] = Rand.Next(1, 1001);
    }

    /**********************************************
    nazwa metody: PrintAll
    opis metody: Wyświetlanie elementów tablicy wraz z indeksami.
    parametry: brak
    zwracany typ i opis: brak
    autor: 00000000000
    ***********************************************/
    public void PrintAll()
    {
        for (int i = 0; i < _size; i++)
            Console.WriteLine($"{i}: {_arr[i]}");
    }

    public int FindFirst(int number)
    {
        for (int i = 0; i < _size; i++)
            if (_arr[i] == number)
                return i;
        return -1;
    }

    public int PrintOddNumbers()
    {
        int[] oddNumbers = _arr.Where(x => x % 2 != 0).ToArray();
        foreach (int number in oddNumbers)
            Console.WriteLine(number);
        return oddNumbers.Length;
    }

    public float GetMean()
    {
        return (float)_arr.Sum() / _size;
    }
}