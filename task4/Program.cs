// A. Почти счастливое число. В единственной строке выведите «YES», если число n — почти счастливое, и «NO» в противном случае (без кавычек).
// https://codeforces.com/contest/110/problem/A

long number = 7747774;
int count = 0;

while (number > 0)
{
    if (number % 10 == 4 || number % 10 == 7) count++;
    number /= 10;
}

if (count == 4 || count == 7)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");

/* long number = long.Parse(Console.ReadLine());
int count = 0;

while (number > 0)
{
    if (number % 10 == 4 || number % 10 == 7) count++;
    number /= 10;
}

if (count == 4 || count == 7)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO"); */