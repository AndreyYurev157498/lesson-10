// Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

using System.Text;
void RecursiveNRepeated(int N)
{
    if (N == 0)
    {
        return;
    }
    else
    {
        {
            string str = new StringBuilder($"{N} ".Length * N).Insert(0, $"{N} ", N).ToString();
            RecursiveNRepeated(N - 1);
            System.Console.Write(str);
        }
    }
}

int Prompt(string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

void Solve()
{
    int N = Prompt("Введите число N ");
    RecursiveNRepeated(N);
}

Solve();