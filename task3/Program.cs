// A. Красивый год. Найдите наименьший номер года, который строго больше заданного и в котором все цифры различны.
// https://codeforces.com/contest/271/problem/A

int yearY = 1987;

while (yearY < 10000)
{
yearY++;
int digit4 = yearY % 10;
int digit3 = (yearY / 10) % 10;
int digit2 = (yearY / 100) % 10;
int digit1 = yearY / 1000;
if (digit1 != digit2 && digit1 != digit3 && digit1 != digit4 && digit2 != digit3 && digit2 != digit4 && digit3 != digit4) break;
}

Console.WriteLine($"Красивый год {yearY}");

/* int yearY = int.Parse(Console.ReadLine());

while (yearY < 10000)
{
yearY++;
int digit4 = yearY % 10;
int digit3 = (yearY / 10) % 10;
int digit2 = (yearY / 100) % 10;
int digit1 = yearY / 1000;
if (digit1 != digit2 && digit1 != digit3 && digit1 != digit4 && digit2 != digit3 && digit2 != digit4 && digit3 != digit4) break;
}

Console.WriteLine(yearY); */