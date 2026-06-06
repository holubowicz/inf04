namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            SelectionSort selectionSort = new SelectionSort();
            selectionSort.GetUserInput();
            selectionSort.SortDescending();
            selectionSort.PrintArray();
        }
    }
}