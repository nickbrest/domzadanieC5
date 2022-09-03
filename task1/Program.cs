// A. Театральная площадь. Какое наименьшее количество плит понадобится для замощения площади?
// https://codeforces.com/contest/1/problem/A

int lengthN = 14;
int widthM = 7;
int plateA = 3;

int lengthPlate = 0;
int widthPlate = 0;

if (lengthN % plateA == 0) lengthPlate = lengthN / plateA;
else lengthPlate = lengthN / plateA + 1;
if (widthM % plateA == 0) widthPlate = widthM / plateA;
else widthPlate = widthM / plateA + 1;

int quantityPlate = lengthPlate * widthPlate;

Console.WriteLine($"Количество плит {quantityPlate}");

/* string str = Console.ReadLine();
long[] array = str.Split(' ').Select(long.Parse).ToArray();
long lengthPlate = 0;
long widthPlate = 0;
if (array[0] % array[2] == 0) lengthPlate = array[0] / array[2];
else lengthPlate = array[0] / array[2] + 1;
if (array[1] % array[2] == 0) widthPlate = array[1] / array[2];
else widthPlate = array[1] / array[2] + 1;
long quantityPlate = lengthPlate * widthPlate;
Console.WriteLine(quantityPlate); */
