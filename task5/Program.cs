// A. Солдат и бананы. Выведите единственное целое число — количество долларов, которое солдату надо одолжить у однополчанина. Если деньги одалживать не надо, выведите 0.
// https://codeforces.com/contest/546/problem/A

int priceK = 3;
int moneyN = 17;
int bananaW = 4;
int summ = 0;

for (int i = 1; i <= bananaW; i++)
summ += i * priceK;

int credit = summ - moneyN;
if (credit < 0) credit = 0;

Console.WriteLine($"Количество долларов которых надо отдолжить {credit}");

/* string str = Console.ReadLine();
int[] array = str.Split(' ').Select(int.Parse).ToArray();

int summ = 0;

for (int i = 1; i <= array[2]; i++)
summ += i * array[0];

int credit = summ - array[1];
if (credit < 0) credit = 0;

Console.WriteLine(credit); */
