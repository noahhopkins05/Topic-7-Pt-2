namespace Topic_7_Pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input, vegetableAdd, vegetableSearch, vegetableFound, vegetableRemove, vegetableIndex;
            int inputNum, vegetableIndexNum;
            List <string> vegetables = new List<string>() { "CARROT", "BEET", "CELERY", "RADISH", "CABBAGE" };

            while (true)
            {
                Console.WriteLine("1 - Remove a vegetable by index");
                Console.WriteLine("2 - Remove a vegetable by value");
                Console.WriteLine("3 - Search for a vegetable");
                Console.WriteLine("4 - Add a vegetable");
                Console.WriteLine("5 - Sort list"); 
                Console.WriteLine("6 - Clear list");
                input = Console.ReadLine();

                if (Int32.TryParse(input, out inputNum))
                {
                    if (inputNum == 1)
                    {
                        Console.Clear();
                        vegetableIndex = Console.ReadLine();
                        if (Int32.TryParse(vegetableIndex, out vegetableIndexNum))
                        {
                            if (vegetableIndexNum > vegetables.Count - 1)
                            { 
                                Console.WriteLine("Invalid Input.");
                            }
                            else
                            {
                                vegetables.RemoveAt(vegetableIndexNum); 
                                foreach (string vegtable in vegetables)
                                {
                                    Console.Write(vegtable + ", ");
                                }
                            }                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again.");
                        }
                        Console.WriteLine();
                    }
                    else if (inputNum == 2)
                    {
                        Console.Clear();
                        vegetableRemove = Console.ReadLine();
                        vegetableRemove = vegetableRemove.ToUpper();
                        vegetables.RemoveAll(x => x == vegetableRemove);
                        foreach (string vegtable in vegetables)
                        {
                            Console.Write(vegtable + ", ");
                        }
                        Console.WriteLine();
                    }
                    else if (inputNum == 3)
                    {
                        Console.Clear();
                        vegetableSearch = Console.ReadLine();
                        vegetableSearch = vegetableSearch.ToUpper();
                        vegetableFound = vegetables.Find(x => x == vegetableSearch);
                        if (vegetableFound != null)
                        {
                            Console.WriteLine("FOUND!");
                        }
                        else
                        {
                            Console.WriteLine("Not found :[");
                        }
                        Console.WriteLine();
                    }
                    else if (inputNum == 4)
                    {
                        Console.Clear();
                        vegetableAdd = Console.ReadLine();
                        vegetableAdd = vegetableAdd.ToUpper();
                        vegetables.Add(vegetableAdd);
                        foreach (string vegtable in vegetables)
                        {
                            Console.Write(vegtable + ", ");
                        }
                        Console.WriteLine();
                    }
                    else if (inputNum == 5)
                    {
                        Console.Clear();
                        vegetables.Sort();
                        foreach (string vegtable in vegetables)
                        {
                            Console.Write(vegtable + ", ");
                        }
                        Console.WriteLine();
                    }
                    else if (inputNum == 6)
                    {
                        Console.Clear();
                        vegetables.Clear();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}