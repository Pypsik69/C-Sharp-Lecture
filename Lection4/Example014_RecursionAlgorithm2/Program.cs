using static System.Console;
Clear();

// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// for (int i = 1; i < 40; i++)
// {
//     WriteLine($"{i}! = {Factorial(i)}");
// }


// Фибоначчи - это сложение на превыдущие числа

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    WriteLine($"f({i}) = ({Fibonacci(i)})");
}

