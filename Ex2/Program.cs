int a = -9;
int b = -3;       
int min = 0;
int max = 0;

if (a > b)
{
  max = a;
  min = b;
}
else
{
  max = b;
  min = a;
}
Console.WriteLine(min);
Console.WriteLine(max);