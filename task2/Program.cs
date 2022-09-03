// A. Слоник. За какое минимальное количество шагов он может добраться до дома друга.
// https://codeforces.com/contest/617/problem/A

int homeX = 7;

int step = 0;
if (homeX % 5 == 0) step = homeX / 5;
else step = homeX / 5 + 1;

Console.WriteLine($"Количество шагов {step}");

/* int homeX = int.Parse(Console.ReadLine());
int step = 0;
if (homeX % 5 == 0) step = homeX / 5;
else step = homeX / 5 + 1;
Console.WriteLine(step); */