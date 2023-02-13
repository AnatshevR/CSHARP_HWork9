//  Показать натуральные числа от N до 1, N задано


void ShowMe (int N)
{
    if (N==0) return ;
    Console.WriteLine(N);
    ShowMe (N-1);

}

Console.WriteLine("enter any integer");
int N = int.Parse(Console.ReadLine()!);
ShowMe(N);

