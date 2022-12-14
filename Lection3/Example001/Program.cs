void Method21(string mss, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(mss);
        i++;
    }
}
// Method21(mss: "dsds", count: 4);

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
    
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
string Method4(int count, string text)
{
    
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(20, "z");
Console.WriteLine (res);

for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}